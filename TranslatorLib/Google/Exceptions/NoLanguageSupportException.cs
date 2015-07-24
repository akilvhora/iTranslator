using System;

namespace TranslatorLib.Google.Exceptions
{
    public class NoLanguageSupportException : Exception
    {
        public NoLanguageSupportException(string message)
            : base(message) { }
    }
}
