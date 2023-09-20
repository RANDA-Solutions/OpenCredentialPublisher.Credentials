using System;

namespace OpenCredentialPublisher.Credentials.JsonLd.Normalization.Exceptions
{
    public class JsonLdParseException : Exception
    {
        public string Line
        {
            get;
#if NET6_0
            init;
#else
            set;
#endif
        }
        public int LineNumber
        {
            get;
#if NET6_0
            init;
#else
            set;
#endif
        }

        public JsonLdParseException(string message, Exception innerException = null) : base(message, innerException)
        {
            Line = null;
            LineNumber = -1;
        }
        public JsonLdParseException(string line, int lineNumber) 
            : base($"N-Quads parse error on line {lineNumber}.")
        {
            Line = line;
            LineNumber = lineNumber;
        }
    }
}
