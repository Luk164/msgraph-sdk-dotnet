using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class StaffAvailabilityItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Each item in this collection indicates a slot and the status of the staff member.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public List<AvailabilityItem>? AvailabilityItems {
            get { return BackingStore?.Get<List<AvailabilityItem>?>("availabilityItems"); }
            set { BackingStore?.Set("availabilityItems", value); }
        }
#else
        public List<AvailabilityItem> AvailabilityItems {
            get { return BackingStore?.Get<List<AvailabilityItem>>("availabilityItems"); }
            set { BackingStore?.Set("availabilityItems", value); }
        }
#endif
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The ID of the staff member.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? StaffId {
            get { return BackingStore?.Get<string?>("staffId"); }
            set { BackingStore?.Set("staffId", value); }
        }
#else
        public string StaffId {
            get { return BackingStore?.Get<string>("staffId"); }
            set { BackingStore?.Set("staffId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new staffAvailabilityItem and sets the default values.
        /// </summary>
        public StaffAvailabilityItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StaffAvailabilityItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StaffAvailabilityItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availabilityItems", n => { AvailabilityItems = n.GetCollectionOfObjectValues<AvailabilityItem>(AvailabilityItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"staffId", n => { StaffId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AvailabilityItem>("availabilityItems", AvailabilityItems);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("staffId", StaffId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
