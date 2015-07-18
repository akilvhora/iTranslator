// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Data.cs" company="ArvaTech">
//   copy
// </copyright>
// <summary>
//   Defines the DummyLanguage type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TranslatorLib.Google.Domain
{
    /// <summary>
    /// The data.
    /// </summary>
    [DataContract]
    internal class Data
    {
        /// <summary>
        /// Gets or sets the translations.
        /// </summary>
        [DataMember(Name = "translations")]
        public List<Translation> Translations { get; set; }
    }
}
