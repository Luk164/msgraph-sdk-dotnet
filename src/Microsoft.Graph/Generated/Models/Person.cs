using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Person : Entity, IParsable {
        /// <summary>The person&apos;s birthday.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Birthday {
            get { return BackingStore?.Get<string?>("birthday"); }
            set { BackingStore?.Set("birthday", value); }
        }
#nullable restore
#else
        public string Birthday {
            get { return BackingStore?.Get<string>("birthday"); }
            set { BackingStore?.Set("birthday", value); }
        }
#endif
        /// <summary>The name of the person&apos;s company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName {
            get { return BackingStore?.Get<string?>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#nullable restore
#else
        public string CompanyName {
            get { return BackingStore?.Get<string>("companyName"); }
            set { BackingStore?.Set("companyName", value); }
        }
#endif
        /// <summary>The person&apos;s department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#nullable restore
#else
        public string Department {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The person&apos;s display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The person&apos;s given name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName {
            get { return BackingStore?.Get<string?>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#nullable restore
#else
        public string GivenName {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#endif
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImAddress {
            get { return BackingStore?.Get<string?>("imAddress"); }
            set { BackingStore?.Set("imAddress", value); }
        }
#nullable restore
#else
        public string ImAddress {
            get { return BackingStore?.Get<string>("imAddress"); }
            set { BackingStore?.Set("imAddress", value); }
        }
#endif
        /// <summary>true if the user has flagged this person as a favorite.</summary>
        public bool? IsFavorite {
            get { return BackingStore?.Get<bool?>("isFavorite"); }
            set { BackingStore?.Set("isFavorite", value); }
        }
        /// <summary>The person&apos;s job title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle {
            get { return BackingStore?.Get<string?>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#nullable restore
#else
        public string JobTitle {
            get { return BackingStore?.Get<string>("jobTitle"); }
            set { BackingStore?.Set("jobTitle", value); }
        }
#endif
        /// <summary>The location of the person&apos;s office.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficeLocation {
            get { return BackingStore?.Get<string?>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#nullable restore
#else
        public string OfficeLocation {
            get { return BackingStore?.Get<string>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#endif
        /// <summary>Free-form notes that the user has taken about this person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonNotes {
            get { return BackingStore?.Get<string?>("personNotes"); }
            set { BackingStore?.Set("personNotes", value); }
        }
#nullable restore
#else
        public string PersonNotes {
            get { return BackingStore?.Get<string>("personNotes"); }
            set { BackingStore?.Set("personNotes", value); }
        }
#endif
        /// <summary>The type of person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PersonType? PersonType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PersonType?>("personType"); }
            set { BackingStore?.Set("personType", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PersonType PersonType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PersonType>("personType"); }
            set { BackingStore?.Set("personType", value); }
        }
#endif
        /// <summary>The person&apos;s phone numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Phone>? Phones {
            get { return BackingStore?.Get<List<Phone>?>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#nullable restore
#else
        public List<Phone> Phones {
            get { return BackingStore?.Get<List<Phone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#endif
        /// <summary>The person&apos;s addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Location>? PostalAddresses {
            get { return BackingStore?.Get<List<Location>?>("postalAddresses"); }
            set { BackingStore?.Set("postalAddresses", value); }
        }
#nullable restore
#else
        public List<Location> PostalAddresses {
            get { return BackingStore?.Get<List<Location>>("postalAddresses"); }
            set { BackingStore?.Set("postalAddresses", value); }
        }
#endif
        /// <summary>The person&apos;s profession.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Profession {
            get { return BackingStore?.Get<string?>("profession"); }
            set { BackingStore?.Set("profession", value); }
        }
#nullable restore
#else
        public string Profession {
            get { return BackingStore?.Get<string>("profession"); }
            set { BackingStore?.Set("profession", value); }
        }
#endif
        /// <summary>The person&apos;s email addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScoredEmailAddress>? ScoredEmailAddresses {
            get { return BackingStore?.Get<List<ScoredEmailAddress>?>("scoredEmailAddresses"); }
            set { BackingStore?.Set("scoredEmailAddresses", value); }
        }
#nullable restore
#else
        public List<ScoredEmailAddress> ScoredEmailAddresses {
            get { return BackingStore?.Get<List<ScoredEmailAddress>>("scoredEmailAddresses"); }
            set { BackingStore?.Set("scoredEmailAddresses", value); }
        }
#endif
        /// <summary>The person&apos;s surname.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname {
            get { return BackingStore?.Get<string?>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#nullable restore
#else
        public string Surname {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#endif
        /// <summary>The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person&apos;s email name. The general format is alias@domain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#nullable restore
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>The person&apos;s websites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Website>? Websites {
            get { return BackingStore?.Get<List<Website>?>("websites"); }
            set { BackingStore?.Set("websites", value); }
        }
#nullable restore
#else
        public List<Website> Websites {
            get { return BackingStore?.Get<List<Website>>("websites"); }
            set { BackingStore?.Set("websites", value); }
        }
#endif
        /// <summary>The phonetic Japanese name of the person&apos;s company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiCompany {
            get { return BackingStore?.Get<string?>("yomiCompany"); }
            set { BackingStore?.Set("yomiCompany", value); }
        }
#nullable restore
#else
        public string YomiCompany {
            get { return BackingStore?.Get<string>("yomiCompany"); }
            set { BackingStore?.Set("yomiCompany", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Person CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Person();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"birthday", n => { Birthday = n.GetStringValue(); } },
                {"companyName", n => { CompanyName = n.GetStringValue(); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"imAddress", n => { ImAddress = n.GetStringValue(); } },
                {"isFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                {"jobTitle", n => { JobTitle = n.GetStringValue(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"personNotes", n => { PersonNotes = n.GetStringValue(); } },
                {"personType", n => { PersonType = n.GetObjectValue<Microsoft.Graph.Models.PersonType>(Microsoft.Graph.Models.PersonType.CreateFromDiscriminatorValue); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue)?.ToList(); } },
                {"postalAddresses", n => { PostalAddresses = n.GetCollectionOfObjectValues<Location>(Location.CreateFromDiscriminatorValue)?.ToList(); } },
                {"profession", n => { Profession = n.GetStringValue(); } },
                {"scoredEmailAddresses", n => { ScoredEmailAddresses = n.GetCollectionOfObjectValues<ScoredEmailAddress>(ScoredEmailAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"websites", n => { Websites = n.GetCollectionOfObjectValues<Website>(Website.CreateFromDiscriminatorValue)?.ToList(); } },
                {"yomiCompany", n => { YomiCompany = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("birthday", Birthday);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("imAddress", ImAddress);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("personNotes", PersonNotes);
            writer.WriteObjectValue<Microsoft.Graph.Models.PersonType>("personType", PersonType);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteCollectionOfObjectValues<Location>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<ScoredEmailAddress>("scoredEmailAddresses", ScoredEmailAddresses);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<Website>("websites", Websites);
            writer.WriteStringValue("yomiCompany", YomiCompany);
        }
    }
}
