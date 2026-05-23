#!/usr/bin/env python
"""
Build 10_FIX50SP2_FP_QF.xml by merging FixPortal-specific customizations from FIX44
into the upstream FIX50SP2 spec.

Input files:
  - Base: spec/fix/FIX50SP2.xml
  - FixPortal source: spec/FixPortal/9_FIX44_FP_QF.xml
  - Upstream FIX44: spec/fix/FIX44.xml

Output: spec/FixPortal/10_FIX50SP2_FP_QF.xml
"""

import xml.etree.ElementTree as ET
from defusedxml.ElementTree import parse as safe_parse
import copy
import os
import sys
from collections import OrderedDict

# -- Paths -----------------------------------------------------------------
BASE_DIR = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
FIX50SP2_PATH = os.path.join(BASE_DIR, "spec", "fix", "FIX50SP2.xml")
FP_FIX44_PATH = os.path.join(BASE_DIR, "spec", "FixPortal", "9_FIX44_FP_QF.xml")
UP_FIX44_PATH = os.path.join(BASE_DIR, "spec", "fix", "FIX44.xml")
OUTPUT_PATH   = os.path.join(BASE_DIR, "spec", "FixPortal", "10_FIX50SP2_FP_QF.xml")

# -- Conflict resolution constants ----------------------------------------
SKIP_FP_TAGS = set(range(22086, 22092))        # 22086-22091: PartyAltID -> 1516-1521 in SP2
COLLISION_SP2_WINS = set(range(1586, 1606))     # 1586-1605
COLLISION_SP2_WINS.add(327)                     # HaltReasonInt
TAG47_FP_ENUMS = {"NC", "CL", "ST", "IN", "MP", "OF", "OT", "BU"}
# Tags where FixPortal redefines as a different field - skip enum merge
SKIP_ENUM_MERGE_TAGS = {800} | set(range(1586, 1606))

# -- Helpers ---------------------------------------------------------------

def parse_xml(path):
    tree = safe_parse(path)  # nosem: defusedxml is the recommended safe parser
    return tree.getroot()


def build_field_index(fields_elem):
    """tag_number(int) -> element"""
    idx = {}
    if fields_elem is None:
        return idx
    for f in fields_elem:
        if f.tag == 'field':
            idx[int(f.get('number'))] = f
    return idx


def build_name_index(section_elem):
    """name -> element"""
    idx = OrderedDict()
    if section_elem is None:
        return idx
    for elem in section_elem:
        name = elem.get('name')
        if name:
            idx[name] = elem
    return idx


def get_enum_set(field_elem):
    return {v.get('enum') for v in field_elem.findall('value')}


def child_key(child):
    """Unique key for a field/component/group child inside a message or component."""
    if child.tag in ('field', 'component', 'group'):
        return (child.tag, child.get('name'))
    return (child.tag, child.get('name', ''))


def get_child_keys(elem):
    return {child_key(c) for c in elem}


# -- XML Writer (single-quote attributes, matching FIX50SP2.xml style) -----

def escape_attr(text):
    text = text.replace('&', '&amp;')
    text = text.replace('<', '&lt;')
    text = text.replace('>', '&gt;')
    text = text.replace("'", '&apos;')
    return text


def attr_str(elem):
    return ''.join(" %s='%s'" % (k, escape_attr(v)) for k, v in elem.items())


def write_element(f, elem, indent):
    pfx = ' ' * indent
    children = list(elem)
    if not children:
        f.write("%s<%s%s />\n" % (pfx, elem.tag, attr_str(elem)))
    else:
        f.write("%s<%s%s>\n" % (pfx, elem.tag, attr_str(elem)))
        for ch in children:
            write_element(f, ch, indent + 1)
        f.write("%s</%s>\n" % (pfx, elem.tag))


def write_fix_xml(root, output_path):
    with open(output_path, 'w', encoding='utf-8') as f:
        f.write("<%s%s>\n" % (root.tag, attr_str(root)))
        for section in root:
            children = list(section)
            if section.tag in ('header', 'trailer') or not children:
                f.write(" <%s />\n" % section.tag)
                continue
            f.write(" <%s>\n" % section.tag)
            for ch in children:
                write_element(f, ch, 2)
            f.write(" </%s>\n" % section.tag)
        f.write("</%s>\n" % root.tag)


# -- Field merge -----------------------------------------------------------

def merge_fields(sp2_fields, cp_fields, up44_fields):
    sp2_idx  = build_field_index(sp2_fields)
    cp_idx   = build_field_index(cp_fields)
    up44_idx = build_field_index(up44_fields)

    log = []
    merged = copy.deepcopy(sp2_fields)
    merged_idx = build_field_index(merged)

    # FixPortal-specific tags: in FixPortal but NOT in upstream FIX44
    cp_specific = {t for t in cp_idx if t not in up44_idx}

    for tag in sorted(cp_specific):
        if tag in SKIP_FP_TAGS:
            log.append("SKIP tag %d (%s): PartyAltID range -> 1516-1521 in SP2" %
                       (tag, cp_idx[tag].get('name')))
            continue
        if tag in sp2_idx:
            log.append("COLLISION tag %d: SP2 '%s' wins over FixPortal '%s'" %
                       (tag, sp2_idx[tag].get('name'), cp_idx[tag].get('name')))
            continue
        new_f = copy.deepcopy(cp_idx[tag])
        merged.append(new_f)
        log.append("ADD tag %d: %s (%s)" % (tag, cp_idx[tag].get('name'), cp_idx[tag].get('type')))

    # Enum merges: fields in BOTH SP2 and FixPortal FIX44
    for tag in sorted(cp_idx):
        if tag not in sp2_idx or tag in SKIP_FP_TAGS or tag in SKIP_ENUM_MERGE_TAGS:
            continue
        up_enums  = get_enum_set(up44_idx[tag]) if tag in up44_idx else set()
        cp_enums  = get_enum_set(cp_idx[tag])
        sp2_enums = get_enum_set(merged_idx[tag])

        cp_specific_enums = cp_enums - up_enums
        new_enums = cp_specific_enums - sp2_enums

        if tag == 47:
            new_enums = new_enums & TAG47_FP_ENUMS  # only known FixPortal additions

        if new_enums:
            target = merged_idx[tag]
            for v in cp_idx[tag].findall('value'):
                if v.get('enum') in new_enums:
                    target.append(copy.deepcopy(v))
            log.append("ENUM MERGE tag %d (%s): added %s" %
                       (tag, sp2_idx[tag].get('name'), sorted(new_enums)))

    # Sort by tag number
    items = list(merged)
    for item in items:
        merged.remove(item)
    items.sort(key=lambda x: int(x.get('number', '0')))
    for item in items:
        merged.append(item)

    return merged, log


# -- Component merge -------------------------------------------------------

def merge_components(sp2_comps, cp_comps, up44_comps):
    sp2_idx  = build_name_index(sp2_comps)
    cp_idx   = build_name_index(cp_comps)
    up44_idx = build_name_index(up44_comps)

    log = []
    merged = copy.deepcopy(sp2_comps)
    merged_idx = build_name_index(merged)

    for name, cp_comp in cp_idx.items():
        is_cp_specific = (name not in up44_idx)

        if name not in sp2_idx:
            # Not in SP2 -> add it (whether FixPortal-specific or not, if it's needed)
            if is_cp_specific or name not in up44_idx:
                new_comp = copy.deepcopy(cp_comp)
                merged.append(new_comp)
                log.append("ADD component '%s'" % name)
            continue

        # In both SP2 and FixPortal: append FixPortal-specific children
        up_keys  = get_child_keys(up44_idx[name]) if name in up44_idx else set()
        cp_keys  = get_child_keys(cp_comp)
        sp2_keys = get_child_keys(merged_idx[name])

        cp_only = cp_keys - up_keys
        new_kids = cp_only - sp2_keys

        if new_kids:
            target = merged_idx[name]
            for ch in cp_comp:
                if child_key(ch) in new_kids:
                    nc = copy.deepcopy(ch)
                    nc.set('required', 'N')
                    target.append(nc)
            log.append("AUGMENT component '%s': +%d FixPortal children" % (name, len(new_kids)))

    return merged, log


# -- Message merge ----------------------------------------------------------

def merge_messages(sp2_msgs, cp_msgs, up44_msgs):
    def by_type(section):
        idx = {}
        if section is None:
            return idx
        for m in section:
            mt = m.get('msgtype')
            if mt:
                idx[mt] = m
        return idx

    sp2_bt  = by_type(sp2_msgs)
    cp_bt   = by_type(cp_msgs)
    up44_bt = by_type(up44_msgs)

    log = []
    merged = copy.deepcopy(sp2_msgs)
    merged_bt = by_type(merged)

    for mt, cp_msg in cp_bt.items():
        if cp_msg.get('msgcat') == 'admin':
            continue
        if mt not in sp2_bt:
            continue
        if mt not in up44_bt:
            continue

        up_keys  = get_child_keys(up44_bt[mt])
        cp_keys  = get_child_keys(cp_msg)
        sp2_keys = get_child_keys(merged_bt[mt])

        cp_only  = cp_keys - up_keys
        new_kids = cp_only - sp2_keys

        if new_kids:
            target = merged_bt[mt]
            additions = []
            for ch in cp_msg:
                k = child_key(ch)
                if k in new_kids:
                    nc = copy.deepcopy(ch)
                    nc.set('required', 'N')
                    target.append(nc)
                    additions.append("%s:%s" % k)
            log.append("AUGMENT '%s' (%s): +%d -> %s" %
                       (cp_msg.get('name'), mt, len(additions), ', '.join(additions)))

    return merged, log


# -- Main ------------------------------------------------------------------

def main():
    print("=" * 70)
    print("Building 10_FIX50SP2_FP_QF.xml")
    print("=" * 70)

    print("\nParsing inputs...")
    sp2  = parse_xml(FIX50SP2_PATH)
    FixPortal   = parse_xml(FP_FIX44_PATH)
    up44 = parse_xml(UP_FIX44_PATH)

    sp2_f, cp_f, up_f = sp2.find('fields'),     FixPortal.find('fields'),     up44.find('fields')
    sp2_c, cp_c, up_c = sp2.find('components'),  FixPortal.find('components'),  up44.find('components')
    sp2_m, cp_m, up_m = sp2.find('messages'),    FixPortal.find('messages'),    up44.find('messages')

    print("  SP2 : %d fields, %d comps, %d msgs" % (len(sp2_f), len(sp2_c), len(sp2_m)))
    print("  CP44: %d fields, %d comps, %d msgs" % (len(cp_f), len(cp_c), len(cp_m)))
    print("  UP44: %d fields, %d comps, %d msgs" % (len(up_f), len(up_c), len(up_m)))

    # -- Fields
    print("\n--- FIELDS ---")
    merged_fields, f_log = merge_fields(sp2_f, cp_f, up_f)
    for l in f_log:
        print("  " + l)

    # -- Components
    print("\n--- COMPONENTS ---")
    merged_comps, c_log = merge_components(sp2_c, cp_c, up_c)
    for l in c_log:
        print("  " + l)

    # -- Messages
    print("\n--- MESSAGES ---")
    merged_msgs, m_log = merge_messages(sp2_m, cp_m, up_m)
    for l in m_log:
        print("  " + l)

    # -- Build output
    out = ET.Element('fix')
    out.set('major', '5')
    out.set('type', 'FIX')
    out.set('servicepack', '2')
    out.set('minor', '0')
    out.set('name', 'FIX50SP2_FP_QF')

    ET.SubElement(out, 'header')
    ET.SubElement(out, 'trailer')
    out.append(merged_msgs)
    out.append(merged_comps)
    out.append(merged_fields)

    # -- Write
    print("\nWriting: %s" % OUTPUT_PATH)
    write_fix_xml(out, OUTPUT_PATH)

    # -- Validate
    print("\n--- VALIDATION ---")
    try:
        vr = parse_xml(OUTPUT_PATH)
        vf = vr.find('fields')
        vc = vr.find('components')
        vm = vr.find('messages')
        nf = len(vf) if vf is not None else 0
        nc = len(vc) if vc is not None else 0
        nm = len(vm) if vm is not None else 0
        print("  Well-formed XML: YES")
        print("  Fields: %d  Components: %d  Messages: %d" % (nf, nc, nm))
        print("  Root: <%s %s>" % (vr.tag,
              ' '.join("%s='%s'" % (k, v) for k, v in vr.items())))

        fi = build_field_index(vf)

        # Verify skipped tags
        for t in range(22086, 22092):
            status = "ABSENT (correct)" if t not in fi else "PRESENT (ERROR!)"
            print("  Tag %d: %s" % (t, status))

        # Verify conflict winners
        if 327 in fi:
            print("  Tag 327: %s (SP2 wins)" % fi[327].get('name'))
        for t in (1586, 1600, 1605):
            if t in fi:
                print("  Tag %d: %s (SP2 wins)" % (t, fi[t].get('name')))

        # Tag 47 FixPortal enums
        if 47 in fi:
            enums = get_enum_set(fi[47])
            found = TAG47_FP_ENUMS & enums
            print("  Tag 47 Rule80A: %d/%d FixPortal enums present: %s" %
                  (len(found), len(TAG47_FP_ENUMS), sorted(found)))

        # Tag 800
        if 800 in fi:
            print("  Tag 800: %s (%s)" % (fi[800].get('name'), fi[800].get('type')))
        else:
            print("  Tag 800: not present (not in SP2 base)")

    except ET.ParseError as e:
        print("  XML PARSE ERROR: %s" % e)
        sys.exit(1)

    print("\n" + "=" * 70)
    print("DONE")
    print("=" * 70)


if __name__ == '__main__':
    main()
