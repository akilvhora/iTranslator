// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Translation.cs" company="ArvaTech">
//   copy
// </copyright>
// <summary>
//   Defines the DummyLanguage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.Runtime.Serialization;

namespace TranslatorLib.Google.Domain
{
    /// <summary>
    /// The translation.
    /// </summary>
    [DataContract]
    internal class Translation
    {
        /// <summary>
        /// Gets or sets the translated text.
        /// </summary>
        [DataMember(Name = "translatedText")]
        public string TranslatedText { get; set; }
    }
}
