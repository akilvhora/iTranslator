using System;

namespace TranslatorLib.Google.Exceptions
{
    public class NoContentFoundException : Exception
    {
        public NoContentFoundException(string message)
            : base(message) { }
    }
}
