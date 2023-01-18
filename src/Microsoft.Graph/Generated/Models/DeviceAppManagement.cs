using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AndroidManagedAppProtection>? AndroidManagedAppProtections {
            get { return BackingStore?.Get<List<AndroidManagedAppProtection>?>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
#else
        public List<AndroidManagedAppProtection> AndroidManagedAppProtections {
            get { return BackingStore?.Get<List<AndroidManagedAppProtection>>("androidManagedAppProtections"); }
            set { BackingStore?.Set("androidManagedAppProtections", value); }
        }
#endif
        /// <summary>Default managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<DefaultManagedAppProtection>? DefaultManagedAppProtections {
            get { return BackingStore?.Get<List<DefaultManagedAppProtection>?>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
#else
        public List<DefaultManagedAppProtection> DefaultManagedAppProtections {
            get { return BackingStore?.Get<List<DefaultManagedAppProtection>>("defaultManagedAppProtections"); }
            set { BackingStore?.Set("defaultManagedAppProtections", value); }
        }
#endif
        /// <summary>iOS managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<IosManagedAppProtection>? IosManagedAppProtections {
            get { return BackingStore?.Get<List<IosManagedAppProtection>?>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
#else
        public List<IosManagedAppProtection> IosManagedAppProtections {
            get { return BackingStore?.Get<List<IosManagedAppProtection>>("iosManagedAppProtections"); }
            set { BackingStore?.Set("iosManagedAppProtections", value); }
        }
#endif
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness {
            get { return BackingStore?.Get<bool?>("isEnabledForMicrosoftStoreForBusiness"); }
            set { BackingStore?.Set("isEnabledForMicrosoftStoreForBusiness", value); }
        }
        /// <summary>Managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedAppPolicy>? ManagedAppPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>?>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
#else
        public List<ManagedAppPolicy> ManagedAppPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("managedAppPolicies"); }
            set { BackingStore?.Set("managedAppPolicies", value); }
        }
#endif
        /// <summary>The managed app registrations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedAppRegistration>? ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>?>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#else
        public List<ManagedAppRegistration> ManagedAppRegistrations {
            get { return BackingStore?.Get<List<ManagedAppRegistration>>("managedAppRegistrations"); }
            set { BackingStore?.Set("managedAppRegistrations", value); }
        }
#endif
        /// <summary>The managed app statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedAppStatus>? ManagedAppStatuses {
            get { return BackingStore?.Get<List<ManagedAppStatus>?>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
#else
        public List<ManagedAppStatus> ManagedAppStatuses {
            get { return BackingStore?.Get<List<ManagedAppStatus>>("managedAppStatuses"); }
            set { BackingStore?.Set("managedAppStatuses", value); }
        }
#endif
        /// <summary>The Managed eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedEBook>? ManagedEBooks {
            get { return BackingStore?.Get<List<ManagedEBook>?>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
#else
        public List<ManagedEBook> ManagedEBooks {
            get { return BackingStore?.Get<List<ManagedEBook>>("managedEBooks"); }
            set { BackingStore?.Set("managedEBooks", value); }
        }
#endif
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MdmWindowsInformationProtectionPolicy>? MdmWindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<MdmWindowsInformationProtectionPolicy>?>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
#else
        public List<MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<MdmWindowsInformationProtectionPolicy>>("mdmWindowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("mdmWindowsInformationProtectionPolicies", value); }
        }
#endif
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&lt;country/regioncode2&gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? MicrosoftStoreForBusinessLanguage {
            get { return BackingStore?.Get<string?>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
#else
        public string MicrosoftStoreForBusinessLanguage {
            get { return BackingStore?.Get<string>("microsoftStoreForBusinessLanguage"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLanguage", value); }
        }
#endif
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime {
            get { return BackingStore?.Get<DateTimeOffset?>("microsoftStoreForBusinessLastCompletedApplicationSyncTime"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLastCompletedApplicationSyncTime", value); }
        }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("microsoftStoreForBusinessLastSuccessfulSyncDateTime"); }
            set { BackingStore?.Set("microsoftStoreForBusinessLastSuccessfulSyncDateTime", value); }
        }
        /// <summary>The mobile app categories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MobileAppCategory>? MobileAppCategories {
            get { return BackingStore?.Get<List<MobileAppCategory>?>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
#else
        public List<MobileAppCategory> MobileAppCategories {
            get { return BackingStore?.Get<List<MobileAppCategory>>("mobileAppCategories"); }
            set { BackingStore?.Set("mobileAppCategories", value); }
        }
#endif
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<ManagedDeviceMobileAppConfiguration>? MobileAppConfigurations {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfiguration>?>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
#else
        public List<ManagedDeviceMobileAppConfiguration> MobileAppConfigurations {
            get { return BackingStore?.Get<List<ManagedDeviceMobileAppConfiguration>>("mobileAppConfigurations"); }
            set { BackingStore?.Set("mobileAppConfigurations", value); }
        }
#endif
        /// <summary>The mobile apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<MobileApp>? MobileApps {
            get { return BackingStore?.Get<List<MobileApp>?>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
#else
        public List<MobileApp> MobileApps {
            get { return BackingStore?.Get<List<MobileApp>>("mobileApps"); }
            set { BackingStore?.Set("mobileApps", value); }
        }
#endif
        /// <summary>Targeted managed app configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<TargetedManagedAppConfiguration>? TargetedManagedAppConfigurations {
            get { return BackingStore?.Get<List<TargetedManagedAppConfiguration>?>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
#else
        public List<TargetedManagedAppConfiguration> TargetedManagedAppConfigurations {
            get { return BackingStore?.Get<List<TargetedManagedAppConfiguration>>("targetedManagedAppConfigurations"); }
            set { BackingStore?.Set("targetedManagedAppConfigurations", value); }
        }
#endif
        /// <summary>List of Vpp tokens for this organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<VppToken>? VppTokens {
            get { return BackingStore?.Get<List<VppToken>?>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
#else
        public List<VppToken> VppTokens {
            get { return BackingStore?.Get<List<VppToken>>("vppTokens"); }
            set { BackingStore?.Set("vppTokens", value); }
        }
#endif
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<WindowsInformationProtectionPolicy>? WindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<WindowsInformationProtectionPolicy>?>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
#else
        public List<WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies {
            get { return BackingStore?.Get<List<WindowsInformationProtectionPolicy>>("windowsInformationProtectionPolicies"); }
            set { BackingStore?.Set("windowsInformationProtectionPolicies", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<AndroidManagedAppProtection>(AndroidManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<DefaultManagedAppProtection>(DefaultManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<IosManagedAppProtection>(IosManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<ManagedAppStatus>(ManagedAppStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<ManagedEBook>(ManagedEBook.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>(MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>(ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<MobileApp>(MobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>(TargetedManagedAppConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<VppToken>(VppToken.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<WindowsInformationProtectionPolicy>(WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
        }
    }
}
