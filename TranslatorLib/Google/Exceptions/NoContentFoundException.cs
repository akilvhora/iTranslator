using System;
using System.Runtime.Serialization;

namespace TranslatorLib.Google.Exceptions
{
    public class NoContentFoundException : Exception
    {
        public NoContentFoundException()
            : base() { }

        public NoContentFoundException(string message)
            : base(message) { }
    }
}
