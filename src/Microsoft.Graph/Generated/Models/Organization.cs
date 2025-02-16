using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Organization : DirectoryObject, IParsable {
        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedPlan>? AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>?>("assignedPlans"); }
            set { BackingStore?.Set("assignedPlans", value); }
        }
#nullable restore
#else
        public List<AssignedPlan> AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>>("assignedPlans"); }
            set { BackingStore?.Set("assignedPlans", value); }
        }
#endif
        /// <summary>Branding for the organization. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OrganizationalBranding? Branding {
            get { return BackingStore?.Get<OrganizationalBranding?>("branding"); }
            set { BackingStore?.Set("branding", value); }
        }
#nullable restore
#else
        public OrganizationalBranding Branding {
            get { return BackingStore?.Get<OrganizationalBranding>("branding"); }
            set { BackingStore?.Set("branding", value); }
        }
#endif
        /// <summary>Telephone number for the organization. Although this is a string collection, only one number can be set for this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BusinessPhones {
            get { return BackingStore?.Get<List<string>?>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#nullable restore
#else
        public List<string> BusinessPhones {
            get { return BackingStore?.Get<List<string>>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#endif
        /// <summary>Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CertificateBasedAuthConfiguration>? CertificateBasedAuthConfiguration {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CertificateBasedAuthConfiguration>?>("certificateBasedAuthConfiguration"); }
            set { BackingStore?.Set("certificateBasedAuthConfiguration", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CertificateBasedAuthConfiguration> CertificateBasedAuthConfiguration {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CertificateBasedAuthConfiguration>>("certificateBasedAuthConfiguration"); }
            set { BackingStore?.Set("certificateBasedAuthConfiguration", value); }
        }
#endif
        /// <summary>City name of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City {
            get { return BackingStore?.Get<string?>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#nullable restore
#else
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#endif
        /// <summary>Country/region name of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country {
            get { return BackingStore?.Get<string?>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#nullable restore
#else
        public string Country {
            get { return BackingStore?.Get<string>("country"); }
            set { BackingStore?.Set("country", value); }
        }
#endif
        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryLetterCode {
            get { return BackingStore?.Get<string?>("countryLetterCode"); }
            set { BackingStore?.Set("countryLetterCode", value); }
        }
#nullable restore
#else
        public string CountryLetterCode {
            get { return BackingStore?.Get<string>("countryLetterCode"); }
            set { BackingStore?.Set("countryLetterCode", value); }
        }
#endif
        /// <summary>Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Two-letter ISO 3166 country code indicating the default service usage location of an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultUsageLocation {
            get { return BackingStore?.Get<string?>("defaultUsageLocation"); }
            set { BackingStore?.Set("defaultUsageLocation", value); }
        }
#nullable restore
#else
        public string DefaultUsageLocation {
            get { return BackingStore?.Get<string>("defaultUsageLocation"); }
            set { BackingStore?.Set("defaultUsageLocation", value); }
        }
#endif
        /// <summary>The display name for the tenant.</summary>
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
        /// <summary>The collection of open extensions defined for the organization. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions {
            get { return BackingStore?.Get<List<Extension>?>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#nullable restore
#else
        public List<Extension> Extensions {
            get { return BackingStore?.Get<List<Extension>>("extensions"); }
            set { BackingStore?.Set("extensions", value); }
        }
#endif
        /// <summary>Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MarketingNotificationEmails {
            get { return BackingStore?.Get<List<string>?>("marketingNotificationEmails"); }
            set { BackingStore?.Set("marketingNotificationEmails", value); }
        }
#nullable restore
#else
        public List<string> MarketingNotificationEmails {
            get { return BackingStore?.Get<List<string>>("marketingNotificationEmails"); }
            set { BackingStore?.Set("marketingNotificationEmails", value); }
        }
#endif
        /// <summary>Mobile device management authority.</summary>
        public MdmAuthority? MobileDeviceManagementAuthority {
            get { return BackingStore?.Get<MdmAuthority?>("mobileDeviceManagementAuthority"); }
            set { BackingStore?.Set("mobileDeviceManagementAuthority", value); }
        }
        /// <summary>The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("onPremisesLastSyncDateTime"); }
            set { BackingStore?.Set("onPremisesLastSyncDateTime", value); }
        }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).</summary>
        public bool? OnPremisesSyncEnabled {
            get { return BackingStore?.Get<bool?>("onPremisesSyncEnabled"); }
            set { BackingStore?.Set("onPremisesSyncEnabled", value); }
        }
        /// <summary>The type of partnership this tenant has with Microsoft. The possible values are: microsoftSupport, syndicatePartner, breadthPartner, breadthPartnerDelegatedAdmin, resellerPartnerDelegatedAdmin, valueAddedResellerPartnerDelegatedAdmin, unknownFutureValue. Nullable. For more information about the possible types, see partnerTenantType values.</summary>
        public Microsoft.Graph.Models.PartnerTenantType? PartnerTenantType {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PartnerTenantType?>("partnerTenantType"); }
            set { BackingStore?.Set("partnerTenantType", value); }
        }
        /// <summary>Postal code of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode {
            get { return BackingStore?.Get<string?>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#nullable restore
#else
        public string PostalCode {
            get { return BackingStore?.Get<string>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#endif
        /// <summary>The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredLanguage {
            get { return BackingStore?.Get<string?>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#nullable restore
#else
        public string PreferredLanguage {
            get { return BackingStore?.Get<string>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#endif
        /// <summary>The privacy profile of an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PrivacyProfile? PrivacyProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivacyProfile?>("privacyProfile"); }
            set { BackingStore?.Set("privacyProfile", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PrivacyProfile PrivacyProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivacyProfile>("privacyProfile"); }
            set { BackingStore?.Set("privacyProfile", value); }
        }
#endif
        /// <summary>Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisionedPlan>? ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>?>("provisionedPlans"); }
            set { BackingStore?.Set("provisionedPlans", value); }
        }
#nullable restore
#else
        public List<ProvisionedPlan> ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>>("provisionedPlans"); }
            set { BackingStore?.Set("provisionedPlans", value); }
        }
#endif
        /// <summary>The securityComplianceNotificationMails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SecurityComplianceNotificationMails {
            get { return BackingStore?.Get<List<string>?>("securityComplianceNotificationMails"); }
            set { BackingStore?.Set("securityComplianceNotificationMails", value); }
        }
#nullable restore
#else
        public List<string> SecurityComplianceNotificationMails {
            get { return BackingStore?.Get<List<string>>("securityComplianceNotificationMails"); }
            set { BackingStore?.Set("securityComplianceNotificationMails", value); }
        }
#endif
        /// <summary>The securityComplianceNotificationPhones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SecurityComplianceNotificationPhones {
            get { return BackingStore?.Get<List<string>?>("securityComplianceNotificationPhones"); }
            set { BackingStore?.Set("securityComplianceNotificationPhones", value); }
        }
#nullable restore
#else
        public List<string> SecurityComplianceNotificationPhones {
            get { return BackingStore?.Get<List<string>>("securityComplianceNotificationPhones"); }
            set { BackingStore?.Set("securityComplianceNotificationPhones", value); }
        }
#endif
        /// <summary>State name of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>Street name of the address for organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Street {
            get { return BackingStore?.Get<string?>("street"); }
            set { BackingStore?.Set("street", value); }
        }
#nullable restore
#else
        public string Street {
            get { return BackingStore?.Get<string>("street"); }
            set { BackingStore?.Set("street", value); }
        }
#endif
        /// <summary>Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TechnicalNotificationMails {
            get { return BackingStore?.Get<List<string>?>("technicalNotificationMails"); }
            set { BackingStore?.Set("technicalNotificationMails", value); }
        }
#nullable restore
#else
        public List<string> TechnicalNotificationMails {
            get { return BackingStore?.Get<List<string>>("technicalNotificationMails"); }
            set { BackingStore?.Set("technicalNotificationMails", value); }
        }
#endif
        /// <summary>Not nullable. The tenant type option that was selected when the tenant was created. The possible values are:  AAD - An enterprise identity access management (IAM) service that serves business-to-employee and business-to-business (B2B) scenarios.  AAD B2C A customer identity access management (CIAM) service that serves business-to-consumer (B2C) scenarios.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantType {
            get { return BackingStore?.Get<string?>("tenantType"); }
            set { BackingStore?.Set("tenantType", value); }
        }
#nullable restore
#else
        public string TenantType {
            get { return BackingStore?.Get<string>("tenantType"); }
            set { BackingStore?.Set("tenantType", value); }
        }
#endif
        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VerifiedDomain>? VerifiedDomains {
            get { return BackingStore?.Get<List<VerifiedDomain>?>("verifiedDomains"); }
            set { BackingStore?.Set("verifiedDomains", value); }
        }
#nullable restore
#else
        public List<VerifiedDomain> VerifiedDomains {
            get { return BackingStore?.Get<List<VerifiedDomain>>("verifiedDomains"); }
            set { BackingStore?.Set("verifiedDomains", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Organization and sets the default values.
        /// </summary>
        public Organization() : base() {
            OdataType = "#microsoft.graph.organization";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Organization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Organization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"branding", n => { Branding = n.GetObjectValue<OrganizationalBranding>(OrganizationalBranding.CreateFromDiscriminatorValue); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"certificateBasedAuthConfiguration", n => { CertificateBasedAuthConfiguration = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CertificateBasedAuthConfiguration>(Microsoft.Graph.Models.CertificateBasedAuthConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"countryLetterCode", n => { CountryLetterCode = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"defaultUsageLocation", n => { DefaultUsageLocation = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"marketingNotificationEmails", n => { MarketingNotificationEmails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"mobileDeviceManagementAuthority", n => { MobileDeviceManagementAuthority = n.GetEnumValue<MdmAuthority>(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"partnerTenantType", n => { PartnerTenantType = n.GetEnumValue<PartnerTenantType>(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"privacyProfile", n => { PrivacyProfile = n.GetObjectValue<Microsoft.Graph.Models.PrivacyProfile>(Microsoft.Graph.Models.PrivacyProfile.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"securityComplianceNotificationMails", n => { SecurityComplianceNotificationMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"securityComplianceNotificationPhones", n => { SecurityComplianceNotificationPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"street", n => { Street = n.GetStringValue(); } },
                {"technicalNotificationMails", n => { TechnicalNotificationMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tenantType", n => { TenantType = n.GetStringValue(); } },
                {"verifiedDomains", n => { VerifiedDomains = n.GetCollectionOfObjectValues<VerifiedDomain>(VerifiedDomain.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<OrganizationalBranding>("branding", Branding);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CertificateBasedAuthConfiguration>("certificateBasedAuthConfiguration", CertificateBasedAuthConfiguration);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("countryLetterCode", CountryLetterCode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("defaultUsageLocation", DefaultUsageLocation);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfPrimitiveValues<string>("marketingNotificationEmails", MarketingNotificationEmails);
            writer.WriteEnumValue<MdmAuthority>("mobileDeviceManagementAuthority", MobileDeviceManagementAuthority);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteEnumValue<PartnerTenantType>("partnerTenantType", PartnerTenantType);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteObjectValue<Microsoft.Graph.Models.PrivacyProfile>("privacyProfile", PrivacyProfile);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationMails", SecurityComplianceNotificationMails);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationPhones", SecurityComplianceNotificationPhones);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteCollectionOfPrimitiveValues<string>("technicalNotificationMails", TechnicalNotificationMails);
            writer.WriteStringValue("tenantType", TenantType);
            writer.WriteCollectionOfObjectValues<VerifiedDomain>("verifiedDomains", VerifiedDomains);
        }
    }
}
