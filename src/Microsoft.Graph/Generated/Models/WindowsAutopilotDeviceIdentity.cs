using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// The windowsAutopilotDeviceIdentity resource represents a Windows Autopilot Device.
    /// </summary>
    public class WindowsAutopilotDeviceIdentity : Entity, IParsable {
        /// <summary>Addressable user name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddressableUserName {
            get { return BackingStore?.Get<string?>("addressableUserName"); }
            set { BackingStore?.Set("addressableUserName", value); }
        }
#nullable restore
#else
        public string AddressableUserName {
            get { return BackingStore?.Get<string>("addressableUserName"); }
            set { BackingStore?.Set("addressableUserName", value); }
        }
#endif
        /// <summary>AAD Device ID - to be deprecated</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureActiveDirectoryDeviceId {
            get { return BackingStore?.Get<string?>("azureActiveDirectoryDeviceId"); }
            set { BackingStore?.Set("azureActiveDirectoryDeviceId", value); }
        }
#nullable restore
#else
        public string AzureActiveDirectoryDeviceId {
            get { return BackingStore?.Get<string>("azureActiveDirectoryDeviceId"); }
            set { BackingStore?.Set("azureActiveDirectoryDeviceId", value); }
        }
#endif
        /// <summary>Display Name</summary>
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
        /// <summary>The enrollmentState property</summary>
        public Microsoft.Graph.Models.EnrollmentState? EnrollmentState {
            get { return BackingStore?.Get<Microsoft.Graph.Models.EnrollmentState?>("enrollmentState"); }
            set { BackingStore?.Set("enrollmentState", value); }
        }
        /// <summary>Group Tag of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupTag {
            get { return BackingStore?.Get<string?>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
#nullable restore
#else
        public string GroupTag {
            get { return BackingStore?.Get<string>("groupTag"); }
            set { BackingStore?.Set("groupTag", value); }
        }
#endif
        /// <summary>Intune Last Contacted Date Time of the Windows autopilot device.</summary>
        public DateTimeOffset? LastContactedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastContactedDateTime"); }
            set { BackingStore?.Set("lastContactedDateTime", value); }
        }
        /// <summary>Managed Device ID</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceId {
            get { return BackingStore?.Get<string?>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#nullable restore
#else
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>("managedDeviceId"); }
            set { BackingStore?.Set("managedDeviceId", value); }
        }
#endif
        /// <summary>Oem manufacturer of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer {
            get { return BackingStore?.Get<string?>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#nullable restore
#else
        public string Manufacturer {
            get { return BackingStore?.Get<string>("manufacturer"); }
            set { BackingStore?.Set("manufacturer", value); }
        }
#endif
        /// <summary>Model name of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model {
            get { return BackingStore?.Get<string?>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#nullable restore
#else
        public string Model {
            get { return BackingStore?.Get<string>("model"); }
            set { BackingStore?.Set("model", value); }
        }
#endif
        /// <summary>Product Key of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProductKey {
            get { return BackingStore?.Get<string?>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#nullable restore
#else
        public string ProductKey {
            get { return BackingStore?.Get<string>("productKey"); }
            set { BackingStore?.Set("productKey", value); }
        }
#endif
        /// <summary>Purchase Order Identifier of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PurchaseOrderIdentifier {
            get { return BackingStore?.Get<string?>("purchaseOrderIdentifier"); }
            set { BackingStore?.Set("purchaseOrderIdentifier", value); }
        }
#nullable restore
#else
        public string PurchaseOrderIdentifier {
            get { return BackingStore?.Get<string>("purchaseOrderIdentifier"); }
            set { BackingStore?.Set("purchaseOrderIdentifier", value); }
        }
#endif
        /// <summary>Resource Name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName {
            get { return BackingStore?.Get<string?>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#nullable restore
#else
        public string ResourceName {
            get { return BackingStore?.Get<string>("resourceName"); }
            set { BackingStore?.Set("resourceName", value); }
        }
#endif
        /// <summary>Serial number of the Windows autopilot device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber {
            get { return BackingStore?.Get<string?>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#nullable restore
#else
        public string SerialNumber {
            get { return BackingStore?.Get<string>("serialNumber"); }
            set { BackingStore?.Set("serialNumber", value); }
        }
#endif
        /// <summary>SKU Number</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuNumber {
            get { return BackingStore?.Get<string?>("skuNumber"); }
            set { BackingStore?.Set("skuNumber", value); }
        }
#nullable restore
#else
        public string SkuNumber {
            get { return BackingStore?.Get<string>("skuNumber"); }
            set { BackingStore?.Set("skuNumber", value); }
        }
#endif
        /// <summary>System Family</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemFamily {
            get { return BackingStore?.Get<string?>("systemFamily"); }
            set { BackingStore?.Set("systemFamily", value); }
        }
#nullable restore
#else
        public string SystemFamily {
            get { return BackingStore?.Get<string>("systemFamily"); }
            set { BackingStore?.Set("systemFamily", value); }
        }
#endif
        /// <summary>User Principal Name.</summary>
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsAutopilotDeviceIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAutopilotDeviceIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addressableUserName", n => { AddressableUserName = n.GetStringValue(); } },
                {"azureActiveDirectoryDeviceId", n => { AzureActiveDirectoryDeviceId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enrollmentState", n => { EnrollmentState = n.GetEnumValue<EnrollmentState>(); } },
                {"groupTag", n => { GroupTag = n.GetStringValue(); } },
                {"lastContactedDateTime", n => { LastContactedDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"productKey", n => { ProductKey = n.GetStringValue(); } },
                {"purchaseOrderIdentifier", n => { PurchaseOrderIdentifier = n.GetStringValue(); } },
                {"resourceName", n => { ResourceName = n.GetStringValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"skuNumber", n => { SkuNumber = n.GetStringValue(); } },
                {"systemFamily", n => { SystemFamily = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("addressableUserName", AddressableUserName);
            writer.WriteStringValue("azureActiveDirectoryDeviceId", AzureActiveDirectoryDeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EnrollmentState>("enrollmentState", EnrollmentState);
            writer.WriteStringValue("groupTag", GroupTag);
            writer.WriteDateTimeOffsetValue("lastContactedDateTime", LastContactedDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("productKey", ProductKey);
            writer.WriteStringValue("purchaseOrderIdentifier", PurchaseOrderIdentifier);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("serialNumber", SerialNumber);
            writer.WriteStringValue("skuNumber", SkuNumber);
            writer.WriteStringValue("systemFamily", SystemFamily);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
