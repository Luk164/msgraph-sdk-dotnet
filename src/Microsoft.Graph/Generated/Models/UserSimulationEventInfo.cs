using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserSimulationEventInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Browser information from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Browser {
            get { return BackingStore?.Get<string?>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
#nullable restore
#else
        public string Browser {
            get { return BackingStore?.Get<string>("browser"); }
            set { BackingStore?.Set("browser", value); }
        }
#endif
        /// <summary>Date and time of the simulation event by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("eventDateTime"); }
            set { BackingStore?.Set("eventDateTime", value); }
        }
        /// <summary>Name of the simulation event by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventName {
            get { return BackingStore?.Get<string?>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#nullable restore
#else
        public string EventName {
            get { return BackingStore?.Get<string>("eventName"); }
            set { BackingStore?.Set("eventName", value); }
        }
#endif
        /// <summary>IP address from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress {
            get { return BackingStore?.Get<string?>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#nullable restore
#else
        public string IpAddress {
            get { return BackingStore?.Get<string>("ipAddress"); }
            set { BackingStore?.Set("ipAddress", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The operating system, platform, and device details from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsPlatformDeviceDetails {
            get { return BackingStore?.Get<string?>("osPlatformDeviceDetails"); }
            set { BackingStore?.Set("osPlatformDeviceDetails", value); }
        }
#nullable restore
#else
        public string OsPlatformDeviceDetails {
            get { return BackingStore?.Get<string>("osPlatformDeviceDetails"); }
            set { BackingStore?.Set("osPlatformDeviceDetails", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new userSimulationEventInfo and sets the default values.
        /// </summary>
        public UserSimulationEventInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSimulationEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSimulationEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"browser", n => { Browser = n.GetStringValue(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventName", n => { EventName = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osPlatformDeviceDetails", n => { OsPlatformDeviceDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osPlatformDeviceDetails", OsPlatformDeviceDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
