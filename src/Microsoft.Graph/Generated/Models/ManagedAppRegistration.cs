using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    /// </summary>
    public class ManagedAppRegistration : Entity, IParsable {
        /// <summary>The app package Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MobileAppIdentifier? AppIdentifier {
            get { return BackingStore?.Get<MobileAppIdentifier?>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
#nullable restore
#else
        public MobileAppIdentifier AppIdentifier {
            get { return BackingStore?.Get<MobileAppIdentifier>("appIdentifier"); }
            set { BackingStore?.Set("appIdentifier", value); }
        }
#endif
        /// <summary>App version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationVersion {
            get { return BackingStore?.Get<string?>("applicationVersion"); }
            set { BackingStore?.Set("applicationVersion", value); }
        }
#nullable restore
#else
        public string ApplicationVersion {
            get { return BackingStore?.Get<string>("applicationVersion"); }
            set { BackingStore?.Set("applicationVersion", value); }
        }
#endif
        /// <summary>Zero or more policys already applied on the registered app when it last synchronized with managment service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppPolicy>? AppliedPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>?>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
#nullable restore
#else
        public List<ManagedAppPolicy> AppliedPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("appliedPolicies"); }
            set { BackingStore?.Set("appliedPolicies", value); }
        }
#endif
        /// <summary>Date and time of creation</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Host device name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName {
            get { return BackingStore?.Get<string?>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#nullable restore
#else
        public string DeviceName {
            get { return BackingStore?.Get<string>("deviceName"); }
            set { BackingStore?.Set("deviceName", value); }
        }
#endif
        /// <summary>App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceTag {
            get { return BackingStore?.Get<string?>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
#nullable restore
#else
        public string DeviceTag {
            get { return BackingStore?.Get<string>("deviceTag"); }
            set { BackingStore?.Set("deviceTag", value); }
        }
#endif
        /// <summary>Host device type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType {
            get { return BackingStore?.Get<string?>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#nullable restore
#else
        public string DeviceType {
            get { return BackingStore?.Get<string>("deviceType"); }
            set { BackingStore?.Set("deviceType", value); }
        }
#endif
        /// <summary>Zero or more reasons an app registration is flagged. E.g. app running on rooted device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppFlaggedReason?>? FlaggedReasons {
            get { return BackingStore?.Get<List<ManagedAppFlaggedReason?>?>("flaggedReasons"); }
            set { BackingStore?.Set("flaggedReasons", value); }
        }
#nullable restore
#else
        public List<ManagedAppFlaggedReason?> FlaggedReasons {
            get { return BackingStore?.Get<List<ManagedAppFlaggedReason?>>("flaggedReasons"); }
            set { BackingStore?.Set("flaggedReasons", value); }
        }
#endif
        /// <summary>Zero or more policies admin intended for the app as of now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppPolicy>? IntendedPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>?>("intendedPolicies"); }
            set { BackingStore?.Set("intendedPolicies", value); }
        }
#nullable restore
#else
        public List<ManagedAppPolicy> IntendedPolicies {
            get { return BackingStore?.Get<List<ManagedAppPolicy>>("intendedPolicies"); }
            set { BackingStore?.Set("intendedPolicies", value); }
        }
#endif
        /// <summary>Date and time of last the app synced with management service.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>App management SDK version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementSdkVersion {
            get { return BackingStore?.Get<string?>("managementSdkVersion"); }
            set { BackingStore?.Set("managementSdkVersion", value); }
        }
#nullable restore
#else
        public string ManagementSdkVersion {
            get { return BackingStore?.Get<string>("managementSdkVersion"); }
            set { BackingStore?.Set("managementSdkVersion", value); }
        }
#endif
        /// <summary>Zero or more long running operations triggered on the app registration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppOperation>? Operations {
            get { return BackingStore?.Get<List<ManagedAppOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<ManagedAppOperation> Operations {
            get { return BackingStore?.Get<List<ManagedAppOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>Operating System version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlatformVersion {
            get { return BackingStore?.Get<string?>("platformVersion"); }
            set { BackingStore?.Set("platformVersion", value); }
        }
#nullable restore
#else
        public string PlatformVersion {
            get { return BackingStore?.Get<string>("platformVersion"); }
            set { BackingStore?.Set("platformVersion", value); }
        }
#endif
        /// <summary>The user Id to who this app registration belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version {
            get { return BackingStore?.Get<string?>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#nullable restore
#else
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedAppRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidManagedAppRegistration" => new AndroidManagedAppRegistration(),
                "#microsoft.graph.iosManagedAppRegistration" => new IosManagedAppRegistration(),
                _ => new ManagedAppRegistration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appIdentifier", n => { AppIdentifier = n.GetObjectValue<MobileAppIdentifier>(MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                {"applicationVersion", n => { ApplicationVersion = n.GetStringValue(); } },
                {"appliedPolicies", n => { AppliedPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetStringValue(); } },
                {"flaggedReasons", n => { FlaggedReasons = n.GetCollectionOfEnumValues<ManagedAppFlaggedReason>()?.ToList(); } },
                {"intendedPolicies", n => { IntendedPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managementSdkVersion", n => { ManagementSdkVersion = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<ManagedAppOperation>(ManagedAppOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"platformVersion", n => { PlatformVersion = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MobileAppIdentifier>("appIdentifier", AppIdentifier);
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("appliedPolicies", AppliedPolicies);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteCollectionOfEnumValues<ManagedAppFlaggedReason>("flaggedReasons", FlaggedReasons);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("intendedPolicies", IntendedPolicies);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managementSdkVersion", ManagementSdkVersion);
            writer.WriteCollectionOfObjectValues<ManagedAppOperation>("operations", Operations);
            writer.WriteStringValue("platformVersion", PlatformVersion);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("version", Version);
        }
    }
}
