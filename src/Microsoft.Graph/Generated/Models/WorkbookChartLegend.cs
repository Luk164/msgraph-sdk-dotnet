using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class WorkbookChartLegend : Entity, IParsable {
        /// <summary>Represents the formatting of a chart legend, which includes fill and font formatting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartLegendFormat? Format {
            get { return BackingStore?.Get<WorkbookChartLegendFormat?>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#nullable restore
#else
        public WorkbookChartLegendFormat Format {
            get { return BackingStore?.Get<WorkbookChartLegendFormat>("format"); }
            set { BackingStore?.Set("format", value); }
        }
#endif
        /// <summary>Boolean value for whether the chart legend should overlap with the main body of the chart.</summary>
        public bool? Overlay {
            get { return BackingStore?.Get<bool?>("overlay"); }
            set { BackingStore?.Set("overlay", value); }
        }
        /// <summary>Represents the position of the legend on the chart. The possible values are: Top, Bottom, Left, Right, Corner, Custom.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Position {
            get { return BackingStore?.Get<string?>("position"); }
            set { BackingStore?.Set("position", value); }
        }
#nullable restore
#else
        public string Position {
            get { return BackingStore?.Get<string>("position"); }
            set { BackingStore?.Set("position", value); }
        }
#endif
        /// <summary>A boolean value the represents the visibility of a ChartLegend object.</summary>
        public bool? Visible {
            get { return BackingStore?.Get<bool?>("visible"); }
            set { BackingStore?.Set("visible", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookChartLegend CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartLegend();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"format", n => { Format = n.GetObjectValue<WorkbookChartLegendFormat>(WorkbookChartLegendFormat.CreateFromDiscriminatorValue); } },
                {"overlay", n => { Overlay = n.GetBoolValue(); } },
                {"position", n => { Position = n.GetStringValue(); } },
                {"visible", n => { Visible = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartLegendFormat>("format", Format);
            writer.WriteBoolValue("overlay", Overlay);
            writer.WriteStringValue("position", Position);
            writer.WriteBoolValue("visible", Visible);
        }
    }
}
