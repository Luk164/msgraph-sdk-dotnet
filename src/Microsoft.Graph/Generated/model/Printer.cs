// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Printer.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Printer : PrinterBase
    {
    
		///<summary>
		/// The Printer constructor
		///</summary>
        public Printer()
        {
            this.ODataType = "microsoft.graph.printer";
        }
	
        /// <summary>
        /// Gets or sets has physical device.
        /// True if the printer has a physical device for printing. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasPhysicalDevice", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasPhysicalDevice { get; set; }
    
        /// <summary>
        /// Gets or sets is shared.
        /// True if the printer is shared; false otherwise. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isShared", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsShared { get; set; }
    
        /// <summary>
        /// Gets or sets registered date time.
        /// The DateTimeOffset when the printer was registered. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "registeredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? RegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets connectors.
        /// The connectors that are associated with the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectors", Required = Newtonsoft.Json.Required.Default)]
        public IPrinterConnectorsCollectionWithReferencesPage Connectors { get; set; }
    
        /// <summary>
        /// Gets or sets shares.
        /// The list of printerShares that are associated with the printer. Currently, only one printerShare can be associated with the printer. Read-only. Nullable.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shares", Required = Newtonsoft.Json.Required.Default)]
        public IPrinterSharesCollectionWithReferencesPage Shares { get; set; }
    
        /// <summary>
        /// Gets or sets task triggers.
        /// A list of task triggers that are associated with the printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taskTriggers", Required = Newtonsoft.Json.Required.Default)]
        public IPrinterTaskTriggersCollectionPage TaskTriggers { get; set; }
    
    }
}

