using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class EBookInstallSummary : Entity, IParsable {
        /// <summary>Number of Devices that have failed to install this book.</summary>
        public int? FailedDeviceCount {
            get { return BackingStore?.Get<int?>("failedDeviceCount"); }
            set { BackingStore?.Set("failedDeviceCount", value); }
        }
        /// <summary>Number of Users that have 1 or more device that failed to install this book.</summary>
        public int? FailedUserCount {
            get { return BackingStore?.Get<int?>("failedUserCount"); }
            set { BackingStore?.Set("failedUserCount", value); }
        }
        /// <summary>Number of Devices that have successfully installed this book.</summary>
        public int? InstalledDeviceCount {
            get { return BackingStore?.Get<int?>("installedDeviceCount"); }
            set { BackingStore?.Set("installedDeviceCount", value); }
        }
        /// <summary>Number of Users whose devices have all succeeded to install this book.</summary>
        public int? InstalledUserCount {
            get { return BackingStore?.Get<int?>("installedUserCount"); }
            set { BackingStore?.Set("installedUserCount", value); }
        }
        /// <summary>Number of Devices that does not have this book installed.</summary>
        public int? NotInstalledDeviceCount {
            get { return BackingStore?.Get<int?>("notInstalledDeviceCount"); }
            set { BackingStore?.Set("notInstalledDeviceCount", value); }
        }
        /// <summary>Number of Users that did not install this book.</summary>
        public int? NotInstalledUserCount {
            get { return BackingStore?.Get<int?>("notInstalledUserCount"); }
            set { BackingStore?.Set("notInstalledUserCount", value); }
        }
        /// <summary>
        /// Instantiates a new eBookInstallSummary and sets the default values.
        /// </summary>
        public EBookInstallSummary() : base() {
            OdataType = "#microsoft.graph.eBookInstallSummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EBookInstallSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EBookInstallSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"failedDeviceCount", n => { FailedDeviceCount = n.GetIntValue(); } },
                {"failedUserCount", n => { FailedUserCount = n.GetIntValue(); } },
                {"installedDeviceCount", n => { InstalledDeviceCount = n.GetIntValue(); } },
                {"installedUserCount", n => { InstalledUserCount = n.GetIntValue(); } },
                {"notInstalledDeviceCount", n => { NotInstalledDeviceCount = n.GetIntValue(); } },
                {"notInstalledUserCount", n => { NotInstalledUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("failedDeviceCount", FailedDeviceCount);
            writer.WriteIntValue("failedUserCount", FailedUserCount);
            writer.WriteIntValue("installedDeviceCount", InstalledDeviceCount);
            writer.WriteIntValue("installedUserCount", InstalledUserCount);
            writer.WriteIntValue("notInstalledDeviceCount", NotInstalledDeviceCount);
            writer.WriteIntValue("notInstalledUserCount", NotInstalledUserCount);
        }
    }
}
