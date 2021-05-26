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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Printer.
    /// </summary>
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
        [JsonPropertyName("hasPhysicalDevice")]
        public bool? HasPhysicalDevice { get; set; }
    
        /// <summary>
        /// Gets or sets is shared.
        /// True if the printer is shared; false otherwise. Read-only.
        /// </summary>
        [JsonPropertyName("isShared")]
        public bool? IsShared { get; set; }
    
        /// <summary>
        /// Gets or sets last seen date time.
        /// The most recent dateTimeOffset when a printer interacted with Universal Print. Read-only.
        /// </summary>
        [JsonPropertyName("lastSeenDateTime")]
        public DateTimeOffset? LastSeenDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets registered date time.
        /// The DateTimeOffset when the printer was registered. Read-only.
        /// </summary>
        [JsonPropertyName("registeredDateTime")]
        public DateTimeOffset? RegisteredDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets connectors.
        /// The connectors that are associated with the printer.
        /// </summary>
        [JsonPropertyName("connectors")]
        public IPrinterConnectorsCollectionWithReferencesPage Connectors { get; set; }

        /// <summary>
        /// Gets or sets connectorsNextLink.
        /// </summary>
        [JsonPropertyName("connectors@odata.nextLink")]
        public string ConnectorsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets shares.
        /// The list of printerShares that are associated with the printer. Currently, only one printerShare can be associated with the printer. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("shares")]
        public IPrinterSharesCollectionWithReferencesPage Shares { get; set; }

        /// <summary>
        /// Gets or sets sharesNextLink.
        /// </summary>
        [JsonPropertyName("shares@odata.nextLink")]
        public string SharesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets task triggers.
        /// A list of task triggers that are associated with the printer.
        /// </summary>
        [JsonPropertyName("taskTriggers")]
        public IPrinterTaskTriggersCollectionPage TaskTriggers { get; set; }

        /// <summary>
        /// Gets or sets taskTriggersNextLink.
        /// </summary>
        [JsonPropertyName("taskTriggers@odata.nextLink")]
        public string TaskTriggersNextLink { get; set; }
    
    }
}

