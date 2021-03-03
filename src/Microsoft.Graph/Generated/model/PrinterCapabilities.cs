// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type PrinterCapabilities.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PrinterCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrinterCapabilities"/> class.
        /// </summary>
        public PrinterCapabilities()
        {
            this.ODataType = "microsoft.graph.printerCapabilities";
        }

        /// <summary>
        /// Gets or sets bottomMargins.
        /// A list of supported bottom margins(in microns) for the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "bottomMargins", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Int32> BottomMargins { get; set; }
    
        /// <summary>
        /// Gets or sets collation.
        /// True if the printer supports collating when printing muliple copies of a multi-page document; false otherwise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "collation", Required = Newtonsoft.Json.Required.Default)]
        public bool? Collation { get; set; }
    
        /// <summary>
        /// Gets or sets colorModes.
        /// The color modes supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "colorModes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintColorMode> ColorModes { get; set; }
    
        /// <summary>
        /// Gets or sets contentTypes.
        /// A list of supported content (MIME) types that the printer supports. It is not guaranteed that the Universal Print service supports printing all of these MIME types.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ContentTypes { get; set; }
    
        /// <summary>
        /// Gets or sets copiesPerJob.
        /// The range of copies per job supported by the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "copiesPerJob", Required = Newtonsoft.Json.Required.Default)]
        public IntegerRange CopiesPerJob { get; set; }
    
        /// <summary>
        /// Gets or sets dpis.
        /// The list of print resolutions in DPI that are supported by the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dpis", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Int32> Dpis { get; set; }
    
        /// <summary>
        /// Gets or sets duplexModes.
        /// The list of duplex modes that are supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "duplexModes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintDuplexMode> DuplexModes { get; set; }
    
        /// <summary>
        /// Gets or sets feedOrientations.
        /// The list of feed orientations that are supported by the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feedOrientations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrinterFeedOrientation> FeedOrientations { get; set; }
    
        /// <summary>
        /// Gets or sets finishings.
        /// Finishing processes the printer supports for a printed document.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "finishings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintFinishing> Finishings { get; set; }
    
        /// <summary>
        /// Gets or sets inputBins.
        /// Supported input bins for the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "inputBins", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> InputBins { get; set; }
    
        /// <summary>
        /// Gets or sets isColorPrintingSupported.
        /// True if color printing is supported by the printer; false otherwise. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isColorPrintingSupported", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsColorPrintingSupported { get; set; }
    
        /// <summary>
        /// Gets or sets isPageRangeSupported.
        /// True if the printer supports printing by page ranges; false otherwise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isPageRangeSupported", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsPageRangeSupported { get; set; }
    
        /// <summary>
        /// Gets or sets leftMargins.
        /// A list of supported left margins(in microns) for the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "leftMargins", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Int32> LeftMargins { get; set; }
    
        /// <summary>
        /// Gets or sets mediaColors.
        /// The media (i.e., paper) colors supported by the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaColors", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MediaColors { get; set; }
    
        /// <summary>
        /// Gets or sets mediaSizes.
        /// The media sizes supported by the printer. Supports standard size names for ISO and ANSI media sizes, along with any custom sizes supported by the associated printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaSizes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MediaSizes { get; set; }
    
        /// <summary>
        /// Gets or sets mediaTypes.
        /// The media types supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mediaTypes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> MediaTypes { get; set; }
    
        /// <summary>
        /// Gets or sets multipageLayouts.
        /// The presentation directions supported by the printer. Supported values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "multipageLayouts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintMultipageLayout> MultipageLayouts { get; set; }
    
        /// <summary>
        /// Gets or sets orientations.
        /// The print orientations supported by the printer. Valid values are described in the following table.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orientations", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintOrientation> Orientations { get; set; }
    
        /// <summary>
        /// Gets or sets outputBins.
        /// The printer's supported output bins (trays).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "outputBins", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OutputBins { get; set; }
    
        /// <summary>
        /// Gets or sets pagesPerSheet.
        /// Supported number of Input Pages to impose upon a single Impression.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pagesPerSheet", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Int32> PagesPerSheet { get; set; }
    
        /// <summary>
        /// Gets or sets qualities.
        /// The print qualities supported by the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qualities", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintQuality> Qualities { get; set; }
    
        /// <summary>
        /// Gets or sets rightMargins.
        /// A list of supported right margins(in microns) for the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rightMargins", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Int32> RightMargins { get; set; }
    
        /// <summary>
        /// Gets or sets scalings.
        /// Supported print scalings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scalings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<PrintScaling> Scalings { get; set; }
    
        /// <summary>
        /// Gets or sets supportsFitPdfToPage.
        /// True if the printer supports scaling PDF pages to match the print media size; false otherwise.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportsFitPdfToPage", Required = Newtonsoft.Json.Required.Default)]
        public bool? SupportsFitPdfToPage { get; set; }
    
        /// <summary>
        /// Gets or sets topMargins.
        /// A list of supported top margins(in microns) for the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "topMargins", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Int32> TopMargins { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
