using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Print : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The list of available print connectors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintConnector>? Connectors {
            get { return BackingStore?.Get<List<PrintConnector>?>("connectors"); }
            set { BackingStore?.Set("connectors", value); }
        }
#nullable restore
#else
        public List<PrintConnector> Connectors {
            get { return BackingStore?.Get<List<PrintConnector>>("connectors"); }
            set { BackingStore?.Set("connectors", value); }
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
        /// <summary>The list of print long running operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintOperation>? Operations {
            get { return BackingStore?.Get<List<PrintOperation>?>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#nullable restore
#else
        public List<PrintOperation> Operations {
            get { return BackingStore?.Get<List<PrintOperation>>("operations"); }
            set { BackingStore?.Set("operations", value); }
        }
#endif
        /// <summary>The list of printers registered in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Printer>? Printers {
            get { return BackingStore?.Get<List<Printer>?>("printers"); }
            set { BackingStore?.Set("printers", value); }
        }
#nullable restore
#else
        public List<Printer> Printers {
            get { return BackingStore?.Get<List<Printer>>("printers"); }
            set { BackingStore?.Set("printers", value); }
        }
#endif
        /// <summary>The list of available Universal Print service endpoints.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintService>? Services {
            get { return BackingStore?.Get<List<PrintService>?>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#nullable restore
#else
        public List<PrintService> Services {
            get { return BackingStore?.Get<List<PrintService>>("services"); }
            set { BackingStore?.Set("services", value); }
        }
#endif
        /// <summary>Tenant-wide settings for the Universal Print service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintSettings? Settings {
            get { return BackingStore?.Get<PrintSettings?>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#nullable restore
#else
        public PrintSettings Settings {
            get { return BackingStore?.Get<PrintSettings>("settings"); }
            set { BackingStore?.Set("settings", value); }
        }
#endif
        /// <summary>The list of printer shares registered in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrinterShare>? Shares {
            get { return BackingStore?.Get<List<PrinterShare>?>("shares"); }
            set { BackingStore?.Set("shares", value); }
        }
#nullable restore
#else
        public List<PrinterShare> Shares {
            get { return BackingStore?.Get<List<PrinterShare>>("shares"); }
            set { BackingStore?.Set("shares", value); }
        }
#endif
        /// <summary>List of abstract definition for a task that can be triggered when various events occur within Universal Print.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintTaskDefinition>? TaskDefinitions {
            get { return BackingStore?.Get<List<PrintTaskDefinition>?>("taskDefinitions"); }
            set { BackingStore?.Set("taskDefinitions", value); }
        }
#nullable restore
#else
        public List<PrintTaskDefinition> TaskDefinitions {
            get { return BackingStore?.Get<List<PrintTaskDefinition>>("taskDefinitions"); }
            set { BackingStore?.Set("taskDefinitions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new Print and sets the default values.
        /// </summary>
        public Print() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Print CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Print();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<PrintConnector>(PrintConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<PrintOperation>(PrintOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"printers", n => { Printers = n.GetCollectionOfObjectValues<Printer>(Printer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<PrintService>(PrintService.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<PrintSettings>(PrintSettings.CreateFromDiscriminatorValue); } },
                {"shares", n => { Shares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskDefinitions", n => { TaskDefinitions = n.GetCollectionOfObjectValues<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<PrintOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Printer>("printers", Printers);
            writer.WriteCollectionOfObjectValues<PrintService>("services", Services);
            writer.WriteObjectValue<PrintSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<PrintTaskDefinition>("taskDefinitions", TaskDefinitions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
