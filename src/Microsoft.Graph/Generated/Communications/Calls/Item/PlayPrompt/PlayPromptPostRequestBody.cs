using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Communications.Calls.Item.PlayPrompt {
    public class PlayPromptPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The clientContext property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientContext {
            get { return BackingStore?.Get<string?>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#nullable restore
#else
        public string ClientContext {
            get { return BackingStore?.Get<string>("clientContext"); }
            set { BackingStore?.Set("clientContext", value); }
        }
#endif
        /// <summary>The prompts property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Prompt>? Prompts {
            get { return BackingStore?.Get<List<Prompt>?>("prompts"); }
            set { BackingStore?.Set("prompts", value); }
        }
#nullable restore
#else
        public List<Prompt> Prompts {
            get { return BackingStore?.Get<List<Prompt>>("prompts"); }
            set { BackingStore?.Set("prompts", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new playPromptPostRequestBody and sets the default values.
        /// </summary>
        public PlayPromptPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PlayPromptPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlayPromptPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"clientContext", n => { ClientContext = n.GetStringValue(); } },
                {"prompts", n => { Prompts = n.GetCollectionOfObjectValues<Prompt>(Prompt.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("clientContext", ClientContext);
            writer.WriteCollectionOfObjectValues<Prompt>("prompts", Prompts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
