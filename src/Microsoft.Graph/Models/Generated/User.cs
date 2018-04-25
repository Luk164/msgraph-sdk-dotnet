// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type User.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class User : DirectoryObject
    {
    
        /// <summary>
        /// Gets or sets account enabled.
        /// true if the account is enabled; otherwise, false. This property is required when a user is created. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// The licenses that are assigned to the user. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedLicenses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedLicense> AssignedLicenses { get; set; }
    
        /// <summary>
        /// Gets or sets assigned plans.
        /// The plans that are assigned to the user. Read-only. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedPlan> AssignedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// The telephone numbers for the user. NOTE: Although this is a string collection, only one number can be set for this property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessPhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// The city in which the user is located. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city", Required = Newtonsoft.Json.Required.Default)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// The company name which the user is associated. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyName", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets country.
        /// The country/region in which the user is located; for example, "US" or "UK". Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "country", Required = Newtonsoft.Json.Required.Default)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// The name for the department in which the user works. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "department", Required = Newtonsoft.Json.Required.Default)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial and last name. This property is required when a user is created and it cannot be cleared during updates. Supports $filter and $orderby.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
        /// The given name (first name) of the user. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "givenName", Required = Newtonsoft.Json.Required.Default)]
        public string GivenName { get; set; }
    
        /// <summary>
        /// Gets or sets im addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "imAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ImAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets job title.
        /// The user's job title. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobTitle", Required = Newtonsoft.Json.Required.Default)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// The SMTP address for the user, for example, "jeff@contoso.onmicrosoft.com". Read-Only. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mail", Required = Newtonsoft.Json.Required.Default)]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// The mail alias for the user. This property must be specified when a user is created. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailNickname", Required = Newtonsoft.Json.Required.Default)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// The primary cellular telephone number for the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobilePhone", Required = Newtonsoft.Json.Required.Default)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets on premises immutable id.
        /// This property is used to associate an on-premises Active Directory user account to their Azure AD user object. This property must be specified when creating a new user account in the Graph if you are using a federated domain for the user's userPrincipalName (UPN) property. Important: The $ and  characters cannot be used when specifying this property. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesImmutableId", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesImmutableId { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// Indicates the last time at which the object was synced with the on-premises directory; for example: "2013-02-16T03:04:54Z". The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesLastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// Contains the on-premises security identifier (SID) for the user that was synchronized from on-premises to the cloud. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSecurityIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesSecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Read-only
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets password policies.
        /// Specifies password policies for the user. This value is an enumeration with one possible value being "DisableStrongPassword", which allows weaker passwords than the default policy to be specified. "DisablePasswordExpiration" can also be specified. The two may be specified together; for example: "DisablePasswordExpiration, DisableStrongPassword".
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPolicies", Required = Newtonsoft.Json.Required.Default)]
        public string PasswordPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets password profile.
        /// Specifies the password profile for the user. The profile contains the user's password. This property is required when a user is created. The password in the profile must satisfy minimum requirements as specified by the passwordPolicies property. By default, a strong password is required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordProfile", Required = Newtonsoft.Json.Required.Default)]
        public PasswordProfile PasswordProfile { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// The office location in the user's place of business.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeLocation", Required = Newtonsoft.Json.Required.Default)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets postal code.
        /// The postal code for the user's postal address. The postal code is specific to the user's country/region. In the United States of America, this attribute contains the ZIP code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalCode", Required = Newtonsoft.Json.Required.Default)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// The preferred language for the user. Should follow ISO 639-1 Code; for example "en-US".
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredLanguage", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets provisioned plans.
        /// The plans that are provisioned for the user. Read-only. Not nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisionedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ProvisionedPlan> ProvisionedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// For example: ["SMTP: bob@contoso.com", "smtp: bob@sales.contoso.com"] The any operator is required for filter expressions on multi-valued properties. Read-only, Not nullable. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// The state or province in the user's address. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets street address.
        /// The street address of the user's place of business.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "streetAddress", Required = Newtonsoft.Json.Required.Default)]
        public string StreetAddress { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// The user's surname (family name or last name). Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "surname", Required = Newtonsoft.Json.Required.Default)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets usage location.
        /// A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries.  Examples include: "US", "JP", and "GB". Not nullable. Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usageLocation", Required = Newtonsoft.Json.Required.Default)]
        public string UsageLocation { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant's collection of verified domains. This property is required when a user is created. The verified domains for the tenant can be accessed from the verifiedDomains property of organization. Supports $filter and $orderby.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// A string value that can be used to classify user types in your directory, such as "Member" and "Guest". Supports $filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userType", Required = Newtonsoft.Json.Required.Default)]
        public string UserType { get; set; }
    
        /// <summary>
        /// Gets or sets mailbox settings.
        /// Settings for the primary mailbox of the signed-in user. You can get or update settings for sending automatic replies to incoming messages, locale and time zone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailboxSettings", Required = Newtonsoft.Json.Required.Default)]
        public MailboxSettings MailboxSettings { get; set; }
    
        /// <summary>
        /// Gets or sets about me.
        /// A freeform text entry field for the user to describe themselves.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "aboutMe", Required = Newtonsoft.Json.Required.Default)]
        public string AboutMe { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// The birthday of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "birthday", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets hire date.
        /// The hire date of the user. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hireDate", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? HireDate { get; set; }
    
        /// <summary>
        /// Gets or sets interests.
        /// A list for the user to describe their interests.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interests", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Interests { get; set; }
    
        /// <summary>
        /// Gets or sets my site.
        /// The URL for the user's personal site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mySite", Required = Newtonsoft.Json.Required.Default)]
        public string MySite { get; set; }
    
        /// <summary>
        /// Gets or sets past projects.
        /// A list for the user to enumerate their past projects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pastProjects", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> PastProjects { get; set; }
    
        /// <summary>
        /// Gets or sets preferred name.
        /// The preferred name for the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredName", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredName { get; set; }
    
        /// <summary>
        /// Gets or sets responsibilities.
        /// A list for the user to enumerate their responsibilities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responsibilities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Responsibilities { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// A list for the user to enumerate the schools they have attended.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schools", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Schools { get; set; }
    
        /// <summary>
        /// Gets or sets skills.
        /// A list for the user to enumerate their skills.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skills", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Skills { get; set; }
    
        /// <summary>
        /// Gets or sets device enrollment limit.
        /// The limit on the maximum number of devices that the user is permitted to enroll. Allowed values are 5 or 1000.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceEnrollmentLimit", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeviceEnrollmentLimit { get; set; }
    
        /// <summary>
        /// Gets or sets owned devices.
        /// Devices that are owned by the user. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IUserOwnedDevicesCollectionWithReferencesPage OwnedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets registered devices.
        /// Devices that are registered for the user. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredDevices", Required = Newtonsoft.Json.Required.Default)]
        public IUserRegisteredDevicesCollectionWithReferencesPage RegisteredDevices { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// The user or contact that is this user's manager. Read-only. (HTTP Methods: GET, PUT, DELETE.)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manager", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryObject Manager { get; set; }
    
        /// <summary>
        /// Gets or sets direct reports.
        /// The users and contacts that report to the user. (The users and contacts that have their manager property set to this user.) Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directReports", Required = Newtonsoft.Json.Required.Default)]
        public IUserDirectReportsCollectionWithReferencesPage DirectReports { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// The groups and directory roles that the user is a member of. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberOf", Required = Newtonsoft.Json.Required.Default)]
        public IUserMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets created objects.
        /// Directory objects that were created by the user. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdObjects", Required = Newtonsoft.Json.Required.Default)]
        public IUserCreatedObjectsCollectionWithReferencesPage CreatedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets owned objects.
        /// Directory objects that are owned by the user. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownedObjects", Required = Newtonsoft.Json.Required.Default)]
        public IUserOwnedObjectsCollectionWithReferencesPage OwnedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets license details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseDetails", Required = Newtonsoft.Json.Required.Default)]
        public IUserLicenseDetailsCollectionPage LicenseDetails { get; set; }
    
        /// <summary>
        /// Gets or sets extensions.
        /// The collection of open extensions defined for the user. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extensions", Required = Newtonsoft.Json.Required.Default)]
        public IUserExtensionsCollectionPage Extensions { get; set; }
    
        /// <summary>
        /// Gets or sets outlook.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outlook", Required = Newtonsoft.Json.Required.Default)]
        public OutlookUser Outlook { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// The messages in a mailbox or folder. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Newtonsoft.Json.Required.Default)]
        public IUserMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets mail folders.
        /// The user's mail folders. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailFolders", Required = Newtonsoft.Json.Required.Default)]
        public IUserMailFoldersCollectionPage MailFolders { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// The user's primary calendar. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendar", Required = Newtonsoft.Json.Required.Default)]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets calendars.
        /// The user's calendars. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendars", Required = Newtonsoft.Json.Required.Default)]
        public IUserCalendarsCollectionPage Calendars { get; set; }
    
        /// <summary>
        /// Gets or sets calendar groups.
        /// The user's calendar groups. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarGroups", Required = Newtonsoft.Json.Required.Default)]
        public IUserCalendarGroupsCollectionPage CalendarGroups { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarView", Required = Newtonsoft.Json.Required.Default)]
        public IUserCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// The user's events. Default is to show Events under the Default Calendar. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "events", Required = Newtonsoft.Json.Required.Default)]
        public IUserEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets people.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "people", Required = Newtonsoft.Json.Required.Default)]
        public IUserPeopleCollectionPage People { get; set; }
    
        /// <summary>
        /// Gets or sets contacts.
        /// The user's contacts. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contacts", Required = Newtonsoft.Json.Required.Default)]
        public IUserContactsCollectionPage Contacts { get; set; }
    
        /// <summary>
        /// Gets or sets contact folders.
        /// The user's contacts folders. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactFolders", Required = Newtonsoft.Json.Required.Default)]
        public IUserContactFoldersCollectionPage ContactFolders { get; set; }
    
        /// <summary>
        /// Gets or sets inference classification.
        /// Relevance classification of the user's messages based on explicit designations which override inferred relevance or importance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inferenceClassification", Required = Newtonsoft.Json.Required.Default)]
        public InferenceClassification InferenceClassification { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
        /// The user's profile photo. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photo", Required = Newtonsoft.Json.Required.Default)]
        public ProfilePhoto Photo { get; set; }
    
        /// <summary>
        /// Gets or sets photos.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "photos", Required = Newtonsoft.Json.Required.Default)]
        public IUserPhotosCollectionPage Photos { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// The user's OneDrive. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// A collection of drives available for this user. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drives", Required = Newtonsoft.Json.Required.Default)]
        public IUserDrivesCollectionPage Drives { get; set; }
    
        /// <summary>
        /// Gets or sets planner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "planner", Required = Newtonsoft.Json.Required.Default)]
        public PlannerUser Planner { get; set; }
    
        /// <summary>
        /// Gets or sets onenote.
        /// Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onenote", Required = Newtonsoft.Json.Required.Default)]
        public Onenote Onenote { get; set; }
    
        /// <summary>
        /// Gets or sets managed devices.
        /// The managed devices associated with the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IUserManagedDevicesCollectionPage ManagedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets managed app registrations.
        /// Zero or more managed app registrations that belong to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "managedAppRegistrations", Required = Newtonsoft.Json.Required.Default)]
        public IUserManagedAppRegistrationsCollectionWithReferencesPage ManagedAppRegistrations { get; set; }
    
        /// <summary>
        /// Gets or sets device management troubleshooting events.
        /// The list of troubleshooting events for this user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceManagementTroubleshootingEvents", Required = Newtonsoft.Json.Required.Default)]
        public IUserDeviceManagementTroubleshootingEventsCollectionPage DeviceManagementTroubleshootingEvents { get; set; }
    
        /// <summary>
        /// Gets or sets activities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activities", Required = Newtonsoft.Json.Required.Default)]
        public IUserActivitiesCollectionPage Activities { get; set; }
    
    }
}

