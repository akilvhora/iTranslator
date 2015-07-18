using System;

namespace TranslatorLib.Google.Exceptions
{
    using System.Runtime.Serialization;

    public class NoLanguageSupportException : Exception
    {
        public NoLanguageSupportException(string message)
            : base(message) { }
    }
}
