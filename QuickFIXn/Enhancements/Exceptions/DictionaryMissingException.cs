#region Using Directives

using System;
using System.Runtime.Serialization;

#endregion

namespace QuickFix.Enhancements.Exceptions
{
    internal class DictionaryMissingException : Exception
    {
        public DictionaryMissingException()
        {
        }

        public DictionaryMissingException(string message) : base(message)
        {
        }

        public DictionaryMissingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DictionaryMissingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}