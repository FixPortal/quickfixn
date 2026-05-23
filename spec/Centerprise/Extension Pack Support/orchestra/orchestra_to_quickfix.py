"""
Convert OrchestraFIXLatest.xml (EP302) to QuickFIX XML dictionary format.

Produces a FIX 5.0 APPLICATION dictionary:
  - Empty header/trailer (transport handled by FIXT11)
  - Session-category messages excluded (Heartbeat, Logon, etc.)
  - Groups rendered inline within messages/components

Usage:
    python orchestra_to_quickfix.py OrchestraFIXLatest.xml output.xml
"""

import sys
import xml.etree.ElementTree as ET
from collections import OrderedDict

NS = {"fixr": "http://fixprotocol.io/2020/orchestra/repository"}


def parse_orchestra(path):
    tree = ET.parse(path)
    root = tree.getroot()

    # --- datatypes (name -> name, for baseType resolution) ---
    datatypes = {}
    for dt in root.findall(".//fixr:datatype", NS):
        name = dt.get("name")
        base = dt.get("baseType")
        datatypes[name] = {"name": name, "baseType": base}

    # --- codeSets (name -> {type, codes[]}) ---
    code_sets = {}
    for cs in root.findall(".//fixr:codeSet", NS):
        cs_name = cs.get("name")
        cs_type = cs.get("type")  # base type like "char", "int", "String"
        codes = []
        for code in cs.findall("fixr:code", NS):
            codes.append({
                "name": code.get("name"),
                "value": code.get("value"),
            })
        code_sets[cs_name] = {"type": cs_type, "codes": codes}

    # --- fields (id -> {name, type, codeSet}) ---
    fields = OrderedDict()
    for f in root.findall(".//fixr:field", NS):
        fid = int(f.get("id"))
        fname = f.get("name")
        ftype = f.get("type")
        fields[fid] = {"name": fname, "type": ftype}

    # --- components (id -> {name, members[]}) ---
    components = OrderedDict()
    for c in root.findall(".//fixr:component", NS):
        cid = int(c.get("id"))
        cname = c.get("name")
        members = _parse_members(c)
        components[cid] = {"name": cname, "members": members}

    # --- groups (id -> {name, numInGroupId, members[]}) ---
    groups = OrderedDict()
    for g in root.findall(".//fixr:group", NS):
        gid = int(g.get("id"))
        gname = g.get("name")
        num_elem = g.find("fixr:numInGroup", NS)
        num_id = int(num_elem.get("id")) if num_elem is not None else None
        members = _parse_members(g)
        groups[gid] = {"name": gname, "numInGroupId": num_id, "members": members}

    # --- messages (id -> {name, msgType, category, members[]}) ---
    messages = OrderedDict()
    for m in root.findall(".//fixr:message", NS):
        mid = int(m.get("id"))
        mname = m.get("name")
        msg_type = m.get("msgType")
        category = m.get("category", "")
        struct = m.find("fixr:structure", NS)
        members = _parse_members(struct) if struct is not None else []
        messages[mid] = {
            "name": mname,
            "msgType": msg_type,
            "category": category,
            "members": members,
        }

    return datatypes, code_sets, fields, components, groups, messages


def _parse_members(parent):
    """Parse fieldRef, componentRef, groupRef, numInGroup from a parent element."""
    members = []
    if parent is None:
        return members
    for child in parent:
        tag = child.tag.replace(f"{{{NS['fixr']}}}", "fixr:")
        if tag == "fixr:fieldRef":
            members.append({
                "kind": "field",
                "id": int(child.get("id")),
                "presence": child.get("presence", ""),
            })
        elif tag == "fixr:componentRef":
            members.append({
                "kind": "component",
                "id": int(child.get("id")),
                "presence": child.get("presence", ""),
            })
        elif tag == "fixr:groupRef":
            members.append({
                "kind": "group",
                "id": int(child.get("id")),
                "presence": child.get("presence", ""),
            })
        elif tag == "fixr:numInGroup":
            # numInGroup is the counter field for a group; skip here, handled in group rendering
            pass
    return members


def resolve_type(field_type, code_sets, datatypes):
    """Resolve an Orchestra type to a QuickFIX type string."""
    # If it's a codeSet, get the base type from the codeSet
    if field_type in code_sets:
        base = code_sets[field_type]["type"]
        return _map_type(base, datatypes)
    return _map_type(field_type, datatypes)


def _map_type(type_name, datatypes):
    """Map an Orchestra datatype name to QuickFIX type name."""
    # QuickFIX uses uppercase type names
    type_map = {
        "int": "INT",
        "Length": "LENGTH",
        "TagNum": "TAGNUM",
        "SeqNum": "SEQNUM",
        "NumInGroup": "NUMINGROUP",
        "DayOfMonth": "DAYOFMONTH",
        "float": "FLOAT",
        "Qty": "QTY",
        "Price": "PRICE",
        "PriceOffset": "PRICEOFFSET",
        "Amt": "AMT",
        "Percentage": "PERCENTAGE",
        "char": "CHAR",
        "Boolean": "BOOLEAN",
        "String": "STRING",
        "MultipleCharValue": "MULTIPLECHARVALUE",
        "MultipleStringValue": "MULTIPLESTRINGVALUE",
        "Country": "COUNTRY",
        "Currency": "CURRENCY",
        "Exchange": "EXCHANGE",
        "MonthYear": "MONTHYEAR",
        "UTCTimestamp": "UTCTIMESTAMP",
        "UTCTimeOnly": "UTCTIMEONLY",
        "UTCDateOnly": "UTCDATEONLY",
        "LocalMktDate": "LOCALMKTDATE",
        "LocalMktTime": "LOCALMKTTIME",
        "TZTimeOnly": "TZTIMEONLY",
        "TZTimestamp": "TZTIMESTAMP",
        "data": "DATA",
        "Pattern": "PATTERN",
        "Tenor": "TENOR",
        "Reserved100Plus": "RESERVED100PLUS",
        "Reserved1000Plus": "RESERVED1000PLUS",
        "Reserved4000Plus": "RESERVED4000PLUS",
        "XMLData": "XMLDATA",
        "Language": "LANGUAGE",
        "XID": "XID",
        "XIDREF": "XIDREF",
    }
    if type_name in type_map:
        return type_map[type_name]
    # Check if it's a known datatype with a baseType
    if type_name in datatypes and datatypes[type_name]["baseType"]:
        return _map_type(datatypes[type_name]["baseType"], datatypes)
    # Fallback: uppercase it
    return type_name.upper()


def presence_to_required(presence):
    return "Y" if presence == "required" else "N"


# Header/trailer component IDs to exclude from message output
HEADER_ID = 1024
TRAILER_ID = 1025

# Session-category messages to exclude from app dictionary
SESSION_CATEGORY = "Session"


def write_quickfix(out_path, datatypes, code_sets, fields, components, groups, messages):
    lines = []
    lines.append('<fix major="5" type="FIX" servicepack="2" minor="0" name="FIX_Latest_EP302">')
    lines.append('\t<header />')
    lines.append('\t<trailer />')

    # --- messages ---
    lines.append('\t<messages>')
    for mid, msg in sorted(messages.items()):
        if msg["category"] == SESSION_CATEGORY:
            continue
        lines.append(f'\t\t<message name="{_xml_escape(msg["name"])}" msgtype="{_xml_escape(msg["msgType"])}" msgcat="app">')
        for member in msg["members"]:
            _render_member(lines, member, fields, components, groups, code_sets, datatypes, indent=3)
        lines.append('\t\t</message>')
    lines.append('\t</messages>')

    # --- components ---
    lines.append('\t<components>')
    for cid, comp in sorted(components.items()):
        lines.append(f'\t\t<component name="{_xml_escape(comp["name"])}">')
        for member in comp["members"]:
            _render_member(lines, member, fields, components, groups, code_sets, datatypes, indent=3)
        lines.append('\t\t</component>')
    lines.append('\t</components>')

    # --- fields ---
    lines.append('\t<fields>')
    for fid, fld in sorted(fields.items()):
        ftype = resolve_type(fld["type"], code_sets, datatypes)
        # Check if there are enum values from a codeSet
        if fld["type"] in code_sets and code_sets[fld["type"]]["codes"]:
            lines.append(f'\t\t<field number="{fid}" name="{_xml_escape(fld["name"])}" type="{ftype}">')
            for code in code_sets[fld["type"]]["codes"]:
                lines.append(f'\t\t\t<value enum="{_xml_escape(code["value"])}" description="{_xml_escape(code["name"])}" />')
            lines.append('\t\t</field>')
        else:
            lines.append(f'\t\t<field number="{fid}" name="{_xml_escape(fld["name"])}" type="{ftype}" />')
    lines.append('\t</fields>')

    lines.append('</fix>')

    with open(out_path, "w", encoding="utf-8") as f:
        f.write('\n'.join(lines))
        f.write('\n')


def _render_member(lines, member, fields, components, groups, code_sets, datatypes, indent):
    tabs = '\t' * indent
    kind = member["kind"]
    mid = member["id"]
    req = presence_to_required(member.get("presence", ""))

    if kind == "field":
        if mid in fields:
            fname = fields[mid]["name"]
            lines.append(f'{tabs}<field name="{_xml_escape(fname)}" required="{req}" />')
    elif kind == "component":
        # Skip header/trailer refs
        if mid == HEADER_ID or mid == TRAILER_ID:
            return
        if mid in components:
            cname = components[mid]["name"]
            lines.append(f'{tabs}<component name="{_xml_escape(cname)}" required="{req}" />')
        elif mid in groups:
            # Some componentRefs actually point to groups
            _render_group(lines, mid, groups, fields, components, code_sets, datatypes, indent, req)
    elif kind == "group":
        _render_group(lines, mid, groups, fields, components, code_sets, datatypes, indent, req)


def _render_group(lines, gid, groups, fields, components, code_sets, datatypes, indent, req):
    tabs = '\t' * indent
    if gid not in groups:
        return
    grp = groups[gid]
    num_field_id = grp["numInGroupId"]
    if num_field_id and num_field_id in fields:
        gname = fields[num_field_id]["name"]
    else:
        gname = grp["name"]

    lines.append(f'{tabs}<group name="{_xml_escape(gname)}" required="{req}">')
    for member in grp["members"]:
        _render_member(lines, member, fields, components, groups, code_sets, datatypes, indent + 1)
    lines.append(f'{tabs}</group>')


def _xml_escape(s):
    if s is None:
        return ""
    return s.replace("&", "&amp;").replace("<", "&lt;").replace(">", "&gt;").replace('"', "&quot;")


def main():
    if len(sys.argv) < 3:
        print(f"Usage: {sys.argv[0]} <OrchestraFIXLatest.xml> <output.xml>")
        sys.exit(1)

    src = sys.argv[1]
    dst = sys.argv[2]

    print(f"Parsing {src}...")
    datatypes, code_sets, fields, components, groups, messages = parse_orchestra(src)
    print(f"  Fields: {len(fields)}")
    print(f"  CodeSets: {len(code_sets)}")
    print(f"  Components: {len(components)}")
    print(f"  Groups: {len(groups)}")
    print(f"  Messages: {len(messages)} (total)")

    app_msgs = {k: v for k, v in messages.items() if v["category"] != SESSION_CATEGORY}
    print(f"  Messages: {len(app_msgs)} (app-only, excluding Session)")

    print(f"Writing {dst}...")
    write_quickfix(dst, datatypes, code_sets, fields, components, groups, messages)
    print("Done.")


if __name__ == "__main__":
    main()
