﻿using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Tennis_Open_Data_Standards
{
    [XmlRoot("Persons"), XmlType(TypeName = "Persons")]
    public class Persons
    {
        [XmlElement(IsNullable = false)]
        public Collection<Person> Person { get; set; }
    }
    /// <summary>
    /// A Person.
    /// </summary>
    /// <remarks>
    /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938561/Introduction+to+the+Person">Introduction to the person</see>
    /// </remarks>

    public class Person : CommonElements
    {
        /// <summary>
        /// Person Identifier.
        /// </summary>
        /// <remarks>
        /// Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1273102565/Including+Multiple+Identifiers">How to Include multiple Identifiers</see>
        /// </remarks>

        //XML minOccurs=1 to 1
        [JsonProperty(Required = Required.Always)]
        public string PersonId { get; set; }
        //[JsonProperty(Required = Required.Always)] ITF requirement and not TODS
        // Validation ?
        /// <summary>
        /// Tennis Identifier
        /// </summary>
        /// <remarks>
        /// Uniquely identify any individual in Tennis; including players, coaches, parents, referees, captains etc
        /// </remarks>
        public string TennisId { get; set; }
        /// <summary>
        /// Preferred Family Name
        /// </summary>
        /// <remarks>
        /// Uses ISO/IEC 8859-1 Latin-1 script. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938619/Transliteration+of+Names+to+Latin+Script">Transliteration of Names to Latin Script</see> document
        /// <seealso href="https://cs.stanford.edu/people/miles/iso8859.html" />
        /// <seealso href="https://en.wikipedia.org/wiki/ISO/IEC_8859-1" />
        /// </remarks>
        public string PreferredFamilyName { get; set; }
        /// <summary>
        /// Preferred Given Name
        /// </summary>
        /// <remarks>
        /// Uses ISO/IEC 8859-1 Latin-1 script. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938619/Transliteration+of+Names+to+Latin+Script">Transliteration of Names to Latin Script</see> document
        /// <seealso href="https://cs.stanford.edu/people/miles/iso8859.html" />
        /// <seealso href="https://en.wikipedia.org/wiki/ISO/IEC_8859-1" />
        /// </remarks>
        public string PreferredGivenName { get; set; }
        /// <summary>
        /// Native Family Name
        /// </summary>
        /// <remarks>
        /// Unicode. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938619/Transliteration+of+Names+to+Latin+Script">Transliteration of Names to Latin Script</see> document
        /// </remarks>
        public string NativeFamilyName { get; set; }
        /// <summary>
        /// Native Given Name
        /// </summary>
        /// <remarks>
        /// Unicode. Please see the <see href="https://itftennis.atlassian.net/wiki/spaces/TODS/pages/1272938619/Transliteration+of+Names+to+Latin+Script">Transliteration of Names to Latin Script</see> document
        /// </remarks>
        public string NativeGivenName { get; set; }
        /// <summary>
        /// Birth Date
        /// </summary>
        /// <remarks>
        /// A person's date of birth in YYYY-MM-DD standard
        /// </remarks>

        //XML minOccurs=0 to 1
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// Gender
        /// </summary>
        /// <remarks>
        /// As per recognised by Tournament Entry Process. Please see <see href="Gender">Gender</see>
        /// </remarks>
        public string Gender { get; set; }
        /// <summary>
        /// Nationality Code
        /// </summary>
        /// <remarks>
        /// The Nationality (ISO3166-3 standards). Please see Wikipedia <see href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3"> ISO_3166-1_alpha-3</see>
        /// </remarks>
        public string NationalityCode { get; set; }
        /// <summary>
        /// Email Address
        /// </summary>
        /// <remarks>
        /// Primary email address
        /// </remarks>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Adresses
        /// </summary>
        /// <remarks>
        /// All known addresses of the person
        /// Please see the <see cref="Address">Address</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("Addresses", typeof(Addresses))]
        public Collection<Address> Addresses { get; set; }
        /// <summary>
        /// Online Profiles
        /// </summary>
        /// <remarks>
        /// All online profiles of the person
        /// Please see the <see cref="OnlineProfile">OnlineProfile</see>
        /// </remarks>

        //XML minOccurs=0 to 1
        [XmlElement("OnlineProfiles", typeof(OnlineProfiles))]
        public Collection<OnlineProfile> OnlineProfiles { get; set; }
        /// <summary>
        /// Biographical Information
        /// </summary>
        /// <remarks>
        /// Please see the <see cref="BiographicalInformation">BiographicalInformation</see>
        /// </remarks>
        public BiographicalInformation BiographicalInformation { get; set; }
    }
}
