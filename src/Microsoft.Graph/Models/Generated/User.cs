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
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "accountEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? AccountEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets assigned licenses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedLicenses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedLicense> AssignedLicenses { get; set; }
    
        /// <summary>
        /// Gets or sets assigned plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AssignedPlan> AssignedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets business phones.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessPhones", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> BusinessPhones { get; set; }
    
        /// <summary>
        /// Gets or sets city.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "city", Required = Newtonsoft.Json.Required.Default)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or sets company name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "companyName", Required = Newtonsoft.Json.Required.Default)]
        public string CompanyName { get; set; }
    
        /// <summary>
        /// Gets or sets country.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "country", Required = Newtonsoft.Json.Required.Default)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or sets department.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "department", Required = Newtonsoft.Json.Required.Default)]
        public string Department { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets given name.
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
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobTitle", Required = Newtonsoft.Json.Required.Default)]
        public string JobTitle { get; set; }
    
        /// <summary>
        /// Gets or sets mail.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mail", Required = Newtonsoft.Json.Required.Default)]
        public string Mail { get; set; }
    
        /// <summary>
        /// Gets or sets mail nickname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailNickname", Required = Newtonsoft.Json.Required.Default)]
        public string MailNickname { get; set; }
    
        /// <summary>
        /// Gets or sets mobile phone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mobilePhone", Required = Newtonsoft.Json.Required.Default)]
        public string MobilePhone { get; set; }
    
        /// <summary>
        /// Gets or sets on premises immutable id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesImmutableId", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesImmutableId { get; set; }
    
        /// <summary>
        /// Gets or sets on premises last sync date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesLastSyncDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets on premises security identifier.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSecurityIdentifier", Required = Newtonsoft.Json.Required.Default)]
        public string OnPremisesSecurityIdentifier { get; set; }
    
        /// <summary>
        /// Gets or sets on premises sync enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onPremisesSyncEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnPremisesSyncEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets password policies.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordPolicies", Required = Newtonsoft.Json.Required.Default)]
        public string PasswordPolicies { get; set; }
    
        /// <summary>
        /// Gets or sets password profile.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "passwordProfile", Required = Newtonsoft.Json.Required.Default)]
        public PasswordProfile PasswordProfile { get; set; }
    
        /// <summary>
        /// Gets or sets office location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "officeLocation", Required = Newtonsoft.Json.Required.Default)]
        public string OfficeLocation { get; set; }
    
        /// <summary>
        /// Gets or sets postal code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postalCode", Required = Newtonsoft.Json.Required.Default)]
        public string PostalCode { get; set; }
    
        /// <summary>
        /// Gets or sets preferred language.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredLanguage", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredLanguage { get; set; }
    
        /// <summary>
        /// Gets or sets provisioned plans.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisionedPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ProvisionedPlan> ProvisionedPlans { get; set; }
    
        /// <summary>
        /// Gets or sets proxy addresses.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyAddresses", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ProxyAddresses { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "state", Required = Newtonsoft.Json.Required.Default)]
        public string State { get; set; }
    
        /// <summary>
        /// Gets or sets street address.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "streetAddress", Required = Newtonsoft.Json.Required.Default)]
        public string StreetAddress { get; set; }
    
        /// <summary>
        /// Gets or sets surname.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "surname", Required = Newtonsoft.Json.Required.Default)]
        public string Surname { get; set; }
    
        /// <summary>
        /// Gets or sets usage location.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usageLocation", Required = Newtonsoft.Json.Required.Default)]
        public string UsageLocation { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets user type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userType", Required = Newtonsoft.Json.Required.Default)]
        public string UserType { get; set; }
    
        /// <summary>
        /// Gets or sets mailbox settings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailboxSettings", Required = Newtonsoft.Json.Required.Default)]
        public MailboxSettings MailboxSettings { get; set; }
    
        /// <summary>
        /// Gets or sets about me.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "aboutMe", Required = Newtonsoft.Json.Required.Default)]
        public string AboutMe { get; set; }
    
        /// <summary>
        /// Gets or sets birthday.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "birthday", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? Birthday { get; set; }
    
        /// <summary>
        /// Gets or sets hire date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hireDate", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? HireDate { get; set; }
    
        /// <summary>
        /// Gets or sets interests.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "interests", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Interests { get; set; }
    
        /// <summary>
        /// Gets or sets my site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mySite", Required = Newtonsoft.Json.Required.Default)]
        public string MySite { get; set; }
    
        /// <summary>
        /// Gets or sets past projects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pastProjects", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> PastProjects { get; set; }
    
        /// <summary>
        /// Gets or sets preferred name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "preferredName", Required = Newtonsoft.Json.Required.Default)]
        public string PreferredName { get; set; }
    
        /// <summary>
        /// Gets or sets responsibilities.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "responsibilities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Responsibilities { get; set; }
    
        /// <summary>
        /// Gets or sets schools.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schools", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Schools { get; set; }
    
        /// <summary>
        /// Gets or sets skills.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skills", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Skills { get; set; }
    
        /// <summary>
        /// Gets or sets owned devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IUserOwnedDevicesCollectionWithReferencesPage OwnedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets registered devices.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredDevices", Required = Newtonsoft.Json.Required.Default)]
        public IUserRegisteredDevicesCollectionWithReferencesPage RegisteredDevices { get; set; }
    
        /// <summary>
        /// Gets or sets manager.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "manager", Required = Newtonsoft.Json.Required.Default)]
        public DirectoryObject Manager { get; set; }
    
        /// <summary>
        /// Gets or sets direct reports.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "directReports", Required = Newtonsoft.Json.Required.Default)]
        public IUserDirectReportsCollectionWithReferencesPage DirectReports { get; set; }
    
        /// <summary>
        /// Gets or sets member of.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberOf", Required = Newtonsoft.Json.Required.Default)]
        public IUserMemberOfCollectionWithReferencesPage MemberOf { get; set; }
    
        /// <summary>
        /// Gets or sets created objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdObjects", Required = Newtonsoft.Json.Required.Default)]
        public IUserCreatedObjectsCollectionWithReferencesPage CreatedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets owned objects.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownedObjects", Required = Newtonsoft.Json.Required.Default)]
        public IUserOwnedObjectsCollectionWithReferencesPage OwnedObjects { get; set; }
    
        /// <summary>
        /// Gets or sets license details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseDetails", Required = Newtonsoft.Json.Required.Default)]
        public IUserLicenseDetailsCollectionPage LicenseDetails { get; set; }
    
        /// <summary>
        /// Gets or sets messages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "messages", Required = Newtonsoft.Json.Required.Default)]
        public IUserMessagesCollectionPage Messages { get; set; }
    
        /// <summary>
        /// Gets or sets mail folders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mailFolders", Required = Newtonsoft.Json.Required.Default)]
        public IUserMailFoldersCollectionPage MailFolders { get; set; }
    
        /// <summary>
        /// Gets or sets calendar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendar", Required = Newtonsoft.Json.Required.Default)]
        public Calendar Calendar { get; set; }
    
        /// <summary>
        /// Gets or sets calendars.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendars", Required = Newtonsoft.Json.Required.Default)]
        public IUserCalendarsCollectionPage Calendars { get; set; }
    
        /// <summary>
        /// Gets or sets calendar groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarGroups", Required = Newtonsoft.Json.Required.Default)]
        public IUserCalendarGroupsCollectionPage CalendarGroups { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "calendarView", Required = Newtonsoft.Json.Required.Default)]
        public IUserCalendarViewCollectionPage CalendarView { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "events", Required = Newtonsoft.Json.Required.Default)]
        public IUserEventsCollectionPage Events { get; set; }
    
        /// <summary>
        /// Gets or sets contacts.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contacts", Required = Newtonsoft.Json.Required.Default)]
        public IUserContactsCollectionPage Contacts { get; set; }
    
        /// <summary>
        /// Gets or sets contact folders.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactFolders", Required = Newtonsoft.Json.Required.Default)]
        public IUserContactFoldersCollectionPage ContactFolders { get; set; }
    
        /// <summary>
        /// Gets or sets inference classification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inferenceClassification", Required = Newtonsoft.Json.Required.Default)]
        public InferenceClassification InferenceClassification { get; set; }
    
        /// <summary>
        /// Gets or sets photo.
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
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drives", Required = Newtonsoft.Json.Required.Default)]
        public IUserDrivesCollectionPage Drives { get; set; }
    
        /// <summary>
        /// Gets or sets planner.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "planner", Required = Newtonsoft.Json.Required.Default)]
        public PlannerUser Planner { get; set; }
    
    }
}

