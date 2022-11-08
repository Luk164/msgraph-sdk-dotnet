using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class SearchAlteration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Defines the altered highlighted query string with spelling correction. The annotation around the corrected segment is: /ue000, /ue001.</summary>
        public string AlteredHighlightedQueryString {
            get { return BackingStore?.Get<string>("alteredHighlightedQueryString"); }
            set { BackingStore?.Set("alteredHighlightedQueryString", value); }
        }
        /// <summary>Defines the altered query string with spelling correction.</summary>
        public string AlteredQueryString {
            get { return BackingStore?.Get<string>("alteredQueryString"); }
            set { BackingStore?.Set("alteredQueryString", value); }
        }
        /// <summary>Represents changed segments related to an original user query.</summary>
        public List<AlteredQueryToken> AlteredQueryTokens {
            get { return BackingStore?.Get<List<AlteredQueryToken>>("alteredQueryTokens"); }
            set { BackingStore?.Set("alteredQueryTokens", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new searchAlteration and sets the default values.
        /// </summary>
        public SearchAlteration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.searchAlteration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchAlteration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchAlteration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alteredHighlightedQueryString", n => { AlteredHighlightedQueryString = n.GetStringValue(); } },
                {"alteredQueryString", n => { AlteredQueryString = n.GetStringValue(); } },
                {"alteredQueryTokens", n => { AlteredQueryTokens = n.GetCollectionOfObjectValues<AlteredQueryToken>(AlteredQueryToken.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alteredHighlightedQueryString", AlteredHighlightedQueryString);
            writer.WriteStringValue("alteredQueryString", AlteredQueryString);
            writer.WriteCollectionOfObjectValues<AlteredQueryToken>("alteredQueryTokens", AlteredQueryTokens);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
