// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GoogleTranslation.cs" company="ArvaTech">
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
    /// The google translation.
    /// </summary>
    [DataContract]
    internal class Response
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        [DataMember(Name = "data")]
        public Data Data { get; set; }
    }
}
