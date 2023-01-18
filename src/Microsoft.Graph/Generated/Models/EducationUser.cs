using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EducationUser : Entity, IParsable {
        /// <summary>True if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter.</summary>
        public bool? AccountEnabled {
            get { return BackingStore?.Get<bool?>("accountEnabled"); }
            set { BackingStore?.Set("accountEnabled", value); }
        }
        /// <summary>The licenses that are assigned to the user. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AssignedLicense>? AssignedLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>?>("assignedLicenses"); }
            set { BackingStore?.Set("assignedLicenses", value); }
        }
#else
        public List<AssignedLicense> AssignedLicenses {
            get { return BackingStore?.Get<List<AssignedLicense>>("assignedLicenses"); }
            set { BackingStore?.Set("assignedLicenses", value); }
        }
#endif
        /// <summary>The plans that are assigned to the user. Read-only. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AssignedPlan>? AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>?>("assignedPlans"); }
            set { BackingStore?.Set("assignedPlans", value); }
        }
#else
        public List<AssignedPlan> AssignedPlans {
            get { return BackingStore?.Get<List<AssignedPlan>>("assignedPlans"); }
            set { BackingStore?.Set("assignedPlans", value); }
        }
#endif
        /// <summary>Assignments belonging to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EducationAssignment>? Assignments {
            get { return BackingStore?.Get<List<EducationAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#else
        public List<EducationAssignment> Assignments {
            get { return BackingStore?.Get<List<EducationAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The telephone numbers for the user. Note: Although this is a string collection, only one number can be set for this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<string>? BusinessPhones {
            get { return BackingStore?.Get<List<string>?>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#else
        public List<string> BusinessPhones {
            get { return BackingStore?.Get<List<string>>("businessPhones"); }
            set { BackingStore?.Set("businessPhones", value); }
        }
#endif
        /// <summary>Classes to which the user belongs. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EducationClass>? Classes {
            get { return BackingStore?.Get<List<EducationClass>?>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
#else
        public List<EducationClass> Classes {
            get { return BackingStore?.Get<List<EducationClass>>("classes"); }
            set { BackingStore?.Set("classes", value); }
        }
#endif
        /// <summary>The entity who created the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The name for the department in which the user works. Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Department {
            get { return BackingStore?.Get<string?>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#else
        public string Department {
            get { return BackingStore?.Get<string>("department"); }
            set { BackingStore?.Set("department", value); }
        }
#endif
        /// <summary>The name displayed in the address book for the user. This is usually the combination of the user&apos;s first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates. Supports $filter and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>Where this user was created from. Possible values are: sis, manual.</summary>
        public EducationExternalSource? ExternalSource {
            get { return BackingStore?.Get<EducationExternalSource?>("externalSource"); }
            set { BackingStore?.Set("externalSource", value); }
        }
        /// <summary>The name of the external source this resource was generated from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? ExternalSourceDetail {
            get { return BackingStore?.Get<string?>("externalSourceDetail"); }
            set { BackingStore?.Set("externalSourceDetail", value); }
        }
#else
        public string ExternalSourceDetail {
            get { return BackingStore?.Get<string>("externalSourceDetail"); }
            set { BackingStore?.Set("externalSourceDetail", value); }
        }
#endif
        /// <summary>The given name (first name) of the user. Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? GivenName {
            get { return BackingStore?.Get<string?>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#else
        public string GivenName {
            get { return BackingStore?.Get<string>("givenName"); }
            set { BackingStore?.Set("givenName", value); }
        }
#endif
        /// <summary>The SMTP address for the user, for example, jeff@contoso.onmicrosoft.com. Read-Only. Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Mail {
            get { return BackingStore?.Get<string?>("mail"); }
            set { BackingStore?.Set("mail", value); }
        }
#else
        public string Mail {
            get { return BackingStore?.Get<string>("mail"); }
            set { BackingStore?.Set("mail", value); }
        }
#endif
        /// <summary>The mail address of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PhysicalAddress? MailingAddress {
            get { return BackingStore?.Get<PhysicalAddress?>("mailingAddress"); }
            set { BackingStore?.Set("mailingAddress", value); }
        }
#else
        public PhysicalAddress MailingAddress {
            get { return BackingStore?.Get<PhysicalAddress>("mailingAddress"); }
            set { BackingStore?.Set("mailingAddress", value); }
        }
#endif
        /// <summary>The mail alias for the user. This property must be specified when a user is created. Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? MailNickname {
            get { return BackingStore?.Get<string?>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#else
        public string MailNickname {
            get { return BackingStore?.Get<string>("mailNickname"); }
            set { BackingStore?.Set("mailNickname", value); }
        }
#endif
        /// <summary>The middle name of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? MiddleName {
            get { return BackingStore?.Get<string?>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
#else
        public string MiddleName {
            get { return BackingStore?.Get<string>("middleName"); }
            set { BackingStore?.Set("middleName", value); }
        }
#endif
        /// <summary>The primary cellular telephone number for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? MobilePhone {
            get { return BackingStore?.Get<string?>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
#else
        public string MobilePhone {
            get { return BackingStore?.Get<string>("mobilePhone"); }
            set { BackingStore?.Set("mobilePhone", value); }
        }
#endif
        /// <summary>The officeLocation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OfficeLocation {
            get { return BackingStore?.Get<string?>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#else
        public string OfficeLocation {
            get { return BackingStore?.Get<string>("officeLocation"); }
            set { BackingStore?.Set("officeLocation", value); }
        }
#endif
        /// <summary>Additional information used to associate the Azure Active Directory user with its Active Directory counterpart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public EducationOnPremisesInfo? OnPremisesInfo {
            get { return BackingStore?.Get<EducationOnPremisesInfo?>("onPremisesInfo"); }
            set { BackingStore?.Set("onPremisesInfo", value); }
        }
#else
        public EducationOnPremisesInfo OnPremisesInfo {
            get { return BackingStore?.Get<EducationOnPremisesInfo>("onPremisesInfo"); }
            set { BackingStore?.Set("onPremisesInfo", value); }
        }
#endif
        /// <summary>Specifies password policies for the user. This value is an enumeration with one possible value being DisableStrongPassword, which allows weaker passwords than the default policy to be specified. DisablePasswordExpiration can also be specified. The two can be specified together; for example: DisablePasswordExpiration, DisableStrongPassword.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PasswordPolicies {
            get { return BackingStore?.Get<string?>("passwordPolicies"); }
            set { BackingStore?.Set("passwordPolicies", value); }
        }
#else
        public string PasswordPolicies {
            get { return BackingStore?.Get<string>("passwordPolicies"); }
            set { BackingStore?.Set("passwordPolicies", value); }
        }
#endif
        /// <summary>Specifies the password profile for the user. The profile contains the user&apos;s password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Models.PasswordProfile? PasswordProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordProfile?>("passwordProfile"); }
            set { BackingStore?.Set("passwordProfile", value); }
        }
#else
        public Microsoft.Graph.Models.PasswordProfile PasswordProfile {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PasswordProfile>("passwordProfile"); }
            set { BackingStore?.Set("passwordProfile", value); }
        }
#endif
        /// <summary>The preferred language for the user that should follow the ISO 639-1 code, for example, en-US.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? PreferredLanguage {
            get { return BackingStore?.Get<string?>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#else
        public string PreferredLanguage {
            get { return BackingStore?.Get<string>("preferredLanguage"); }
            set { BackingStore?.Set("preferredLanguage", value); }
        }
#endif
        /// <summary>The primaryRole property</summary>
        public EducationUserRole? PrimaryRole {
            get { return BackingStore?.Get<EducationUserRole?>("primaryRole"); }
            set { BackingStore?.Set("primaryRole", value); }
        }
        /// <summary>The plans that are provisioned for the user. Read-only. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ProvisionedPlan>? ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>?>("provisionedPlans"); }
            set { BackingStore?.Set("provisionedPlans", value); }
        }
#else
        public List<ProvisionedPlan> ProvisionedPlans {
            get { return BackingStore?.Get<List<ProvisionedPlan>>("provisionedPlans"); }
            set { BackingStore?.Set("provisionedPlans", value); }
        }
#endif
        /// <summary>The refreshTokensValidFromDateTime property</summary>
        public DateTimeOffset? RefreshTokensValidFromDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("refreshTokensValidFromDateTime"); }
            set { BackingStore?.Set("refreshTokensValidFromDateTime", value); }
        }
        /// <summary>Related records associated with the user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<RelatedContact>? RelatedContacts {
            get { return BackingStore?.Get<List<RelatedContact>?>("relatedContacts"); }
            set { BackingStore?.Set("relatedContacts", value); }
        }
#else
        public List<RelatedContact> RelatedContacts {
            get { return BackingStore?.Get<List<RelatedContact>>("relatedContacts"); }
            set { BackingStore?.Set("relatedContacts", value); }
        }
#endif
        /// <summary>The address where the user lives.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public PhysicalAddress? ResidenceAddress {
            get { return BackingStore?.Get<PhysicalAddress?>("residenceAddress"); }
            set { BackingStore?.Set("residenceAddress", value); }
        }
#else
        public PhysicalAddress ResidenceAddress {
            get { return BackingStore?.Get<PhysicalAddress>("residenceAddress"); }
            set { BackingStore?.Set("residenceAddress", value); }
        }
#endif
        /// <summary>When set, the grading rubric attached to the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EducationRubric>? Rubrics {
            get { return BackingStore?.Get<List<EducationRubric>?>("rubrics"); }
            set { BackingStore?.Set("rubrics", value); }
        }
#else
        public List<EducationRubric> Rubrics {
            get { return BackingStore?.Get<List<EducationRubric>>("rubrics"); }
            set { BackingStore?.Set("rubrics", value); }
        }
#endif
        /// <summary>Schools to which the user belongs. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EducationSchool>? Schools {
            get { return BackingStore?.Get<List<EducationSchool>?>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#else
        public List<EducationSchool> Schools {
            get { return BackingStore?.Get<List<EducationSchool>>("schools"); }
            set { BackingStore?.Set("schools", value); }
        }
#endif
        /// <summary>True if the Outlook Global Address List should contain this user; otherwise, false. If not set, this will be treated as true. For users invited through the invitation manager, this property will be set to false.</summary>
        public bool? ShowInAddressList {
            get { return BackingStore?.Get<bool?>("showInAddressList"); }
            set { BackingStore?.Set("showInAddressList", value); }
        }
        /// <summary>If the primary role is student, this block will contain student specific data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public EducationStudent? Student {
            get { return BackingStore?.Get<EducationStudent?>("student"); }
            set { BackingStore?.Set("student", value); }
        }
#else
        public EducationStudent Student {
            get { return BackingStore?.Get<EducationStudent>("student"); }
            set { BackingStore?.Set("student", value); }
        }
#endif
        /// <summary>The user&apos;s surname (family name or last name). Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? Surname {
            get { return BackingStore?.Get<string?>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#else
        public string Surname {
            get { return BackingStore?.Get<string>("surname"); }
            set { BackingStore?.Set("surname", value); }
        }
#endif
        /// <summary>Classes for which the user is a teacher.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<EducationClass>? TaughtClasses {
            get { return BackingStore?.Get<List<EducationClass>?>("taughtClasses"); }
            set { BackingStore?.Set("taughtClasses", value); }
        }
#else
        public List<EducationClass> TaughtClasses {
            get { return BackingStore?.Get<List<EducationClass>>("taughtClasses"); }
            set { BackingStore?.Set("taughtClasses", value); }
        }
#endif
        /// <summary>If the primary role is teacher, this block will contain teacher specific data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public EducationTeacher? Teacher {
            get { return BackingStore?.Get<EducationTeacher?>("teacher"); }
            set { BackingStore?.Set("teacher", value); }
        }
#else
        public EducationTeacher Teacher {
            get { return BackingStore?.Get<EducationTeacher>("teacher"); }
            set { BackingStore?.Set("teacher", value); }
        }
#endif
        /// <summary>A two-letter country code (ISO standard 3166). Required for users who will be assigned licenses due to a legal requirement to check for availability of services in countries or regions. Examples include: US, JP, and GB. Not nullable. Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? UsageLocation {
            get { return BackingStore?.Get<string?>("usageLocation"); }
            set { BackingStore?.Set("usageLocation", value); }
        }
#else
        public string UsageLocation {
            get { return BackingStore?.Get<string>("usageLocation"); }
            set { BackingStore?.Set("usageLocation", value); }
        }
#endif
        /// <summary>The directory user that corresponds to this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public Microsoft.Graph.Models.User? User {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User?>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#else
        public Microsoft.Graph.Models.User User {
            get { return BackingStore?.Get<Microsoft.Graph.Models.User>("user"); }
            set { BackingStore?.Set("user", value); }
        }
#endif
        /// <summary>The user principal name (UPN) of the user. The UPN is an internet-style login name for the user based on the internet standard RFC 822. By convention, this should map to the user&apos;s email name. The general format is alias@domain, where domain must be present in the tenant&apos;s collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of the organization. Supports $filter and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? UserPrincipalName {
            get { return BackingStore?.Get<string?>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#else
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
#endif
        /// <summary>A string value that can be used to classify user types in your directory, such as Member and Guest. Supports $filter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? UserType {
            get { return BackingStore?.Get<string?>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
#else
        public string UserType {
            get { return BackingStore?.Get<string>("userType"); }
            set { BackingStore?.Set("userType", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationUser CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationUser();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountEnabled", n => { AccountEnabled = n.GetBoolValue(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<EducationAssignment>(EducationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"classes", n => { Classes = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"department", n => { Department = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalSource", n => { ExternalSource = n.GetEnumValue<EducationExternalSource>(); } },
                {"externalSourceDetail", n => { ExternalSourceDetail = n.GetStringValue(); } },
                {"givenName", n => { GivenName = n.GetStringValue(); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailingAddress", n => { MailingAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"middleName", n => { MiddleName = n.GetStringValue(); } },
                {"mobilePhone", n => { MobilePhone = n.GetStringValue(); } },
                {"officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                {"onPremisesInfo", n => { OnPremisesInfo = n.GetObjectValue<EducationOnPremisesInfo>(EducationOnPremisesInfo.CreateFromDiscriminatorValue); } },
                {"passwordPolicies", n => { PasswordPolicies = n.GetStringValue(); } },
                {"passwordProfile", n => { PasswordProfile = n.GetObjectValue<Microsoft.Graph.Models.PasswordProfile>(Microsoft.Graph.Models.PasswordProfile.CreateFromDiscriminatorValue); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"primaryRole", n => { PrimaryRole = n.GetEnumValue<EducationUserRole>(); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"refreshTokensValidFromDateTime", n => { RefreshTokensValidFromDateTime = n.GetDateTimeOffsetValue(); } },
                {"relatedContacts", n => { RelatedContacts = n.GetCollectionOfObjectValues<RelatedContact>(RelatedContact.CreateFromDiscriminatorValue)?.ToList(); } },
                {"residenceAddress", n => { ResidenceAddress = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"rubrics", n => { Rubrics = n.GetCollectionOfObjectValues<EducationRubric>(EducationRubric.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schools", n => { Schools = n.GetCollectionOfObjectValues<EducationSchool>(EducationSchool.CreateFromDiscriminatorValue)?.ToList(); } },
                {"showInAddressList", n => { ShowInAddressList = n.GetBoolValue(); } },
                {"student", n => { Student = n.GetObjectValue<EducationStudent>(EducationStudent.CreateFromDiscriminatorValue); } },
                {"surname", n => { Surname = n.GetStringValue(); } },
                {"taughtClasses", n => { TaughtClasses = n.GetCollectionOfObjectValues<EducationClass>(EducationClass.CreateFromDiscriminatorValue)?.ToList(); } },
                {"teacher", n => { Teacher = n.GetObjectValue<EducationTeacher>(EducationTeacher.CreateFromDiscriminatorValue); } },
                {"usageLocation", n => { UsageLocation = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<Microsoft.Graph.Models.User>(Microsoft.Graph.Models.User.CreateFromDiscriminatorValue); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountEnabled", AccountEnabled);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteCollectionOfObjectValues<EducationAssignment>("assignments", Assignments);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfObjectValues<EducationClass>("classes", Classes);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EducationExternalSource>("externalSource", ExternalSource);
            writer.WriteStringValue("externalSourceDetail", ExternalSourceDetail);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("mail", Mail);
            writer.WriteObjectValue<PhysicalAddress>("mailingAddress", MailingAddress);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteStringValue("middleName", MiddleName);
            writer.WriteStringValue("mobilePhone", MobilePhone);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteObjectValue<EducationOnPremisesInfo>("onPremisesInfo", OnPremisesInfo);
            writer.WriteStringValue("passwordPolicies", PasswordPolicies);
            writer.WriteObjectValue<Microsoft.Graph.Models.PasswordProfile>("passwordProfile", PasswordProfile);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteEnumValue<EducationUserRole>("primaryRole", PrimaryRole);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteDateTimeOffsetValue("refreshTokensValidFromDateTime", RefreshTokensValidFromDateTime);
            writer.WriteCollectionOfObjectValues<RelatedContact>("relatedContacts", RelatedContacts);
            writer.WriteObjectValue<PhysicalAddress>("residenceAddress", ResidenceAddress);
            writer.WriteCollectionOfObjectValues<EducationRubric>("rubrics", Rubrics);
            writer.WriteCollectionOfObjectValues<EducationSchool>("schools", Schools);
            writer.WriteBoolValue("showInAddressList", ShowInAddressList);
            writer.WriteObjectValue<EducationStudent>("student", Student);
            writer.WriteStringValue("surname", Surname);
            writer.WriteCollectionOfObjectValues<EducationClass>("taughtClasses", TaughtClasses);
            writer.WriteObjectValue<EducationTeacher>("teacher", Teacher);
            writer.WriteStringValue("usageLocation", UsageLocation);
            writer.WriteObjectValue<Microsoft.Graph.Models.User>("user", User);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteStringValue("userType", UserType);
        }
    }
}
