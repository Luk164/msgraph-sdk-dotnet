using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DeviceEnrollmentPlatformRestrictionsConfiguration : DeviceEnrollmentConfiguration, IParsable {
        /// <summary>Android restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceEnrollmentPlatformRestriction? AndroidRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("androidRestriction"); }
            set { BackingStore?.Set("androidRestriction", value); }
        }
#else
        public DeviceEnrollmentPlatformRestriction AndroidRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("androidRestriction"); }
            set { BackingStore?.Set("androidRestriction", value); }
        }
#endif
        /// <summary>Ios restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceEnrollmentPlatformRestriction? IosRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("iosRestriction"); }
            set { BackingStore?.Set("iosRestriction", value); }
        }
#else
        public DeviceEnrollmentPlatformRestriction IosRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("iosRestriction"); }
            set { BackingStore?.Set("iosRestriction", value); }
        }
#endif
        /// <summary>Mac restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceEnrollmentPlatformRestriction? MacOSRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("macOSRestriction"); }
            set { BackingStore?.Set("macOSRestriction", value); }
        }
#else
        public DeviceEnrollmentPlatformRestriction MacOSRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("macOSRestriction"); }
            set { BackingStore?.Set("macOSRestriction", value); }
        }
#endif
        /// <summary>Windows mobile restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceEnrollmentPlatformRestriction? WindowsMobileRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("windowsMobileRestriction"); }
            set { BackingStore?.Set("windowsMobileRestriction", value); }
        }
#else
        public DeviceEnrollmentPlatformRestriction WindowsMobileRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsMobileRestriction"); }
            set { BackingStore?.Set("windowsMobileRestriction", value); }
        }
#endif
        /// <summary>Windows restrictions based on platform, platform operating system version, and device ownership</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public DeviceEnrollmentPlatformRestriction? WindowsRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction?>("windowsRestriction"); }
            set { BackingStore?.Set("windowsRestriction", value); }
        }
#else
        public DeviceEnrollmentPlatformRestriction WindowsRestriction {
            get { return BackingStore?.Get<DeviceEnrollmentPlatformRestriction>("windowsRestriction"); }
            set { BackingStore?.Set("windowsRestriction", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new DeviceEnrollmentPlatformRestrictionsConfiguration and sets the default values.
        /// </summary>
        public DeviceEnrollmentPlatformRestrictionsConfiguration() : base() {
            OdataType = "#microsoft.graph.deviceEnrollmentPlatformRestrictionsConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceEnrollmentPlatformRestrictionsConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEnrollmentPlatformRestrictionsConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidRestriction", n => { AndroidRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"iosRestriction", n => { IosRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"macOSRestriction", n => { MacOSRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsMobileRestriction", n => { WindowsMobileRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
                {"windowsRestriction", n => { WindowsRestriction = n.GetObjectValue<DeviceEnrollmentPlatformRestriction>(DeviceEnrollmentPlatformRestriction.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("androidRestriction", AndroidRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("iosRestriction", IosRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("macOSRestriction", MacOSRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsMobileRestriction", WindowsMobileRestriction);
            writer.WriteObjectValue<DeviceEnrollmentPlatformRestriction>("windowsRestriction", WindowsRestriction);
        }
    }
}
