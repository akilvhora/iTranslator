﻿
using System.Net;

namespace TranslatorLib.Google
{
    public interface IGoogleRequest
    {
        string Execute(string requestUri);
    }
}
