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
    /// The type Print.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class Print
    {
    
		///<summary>
		/// The Print constructor
		///</summary>
        public Print()
        {
            this.ODataType = "microsoft.graph.print";
        }
	
        /// <summary>
        /// Gets or sets settings.
        /// Tenant-wide settings for the Universal Print service.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settings", Required = Newtonsoft.Json.Required.Default)]
        public PrintSettings Settings { get; set; }
    
        /// <summary>
        /// Gets or sets connectors.
        /// The list of available print connectors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectors", Required = Newtonsoft.Json.Required.Default)]
        public IPrintConnectorsCollectionPage Connectors { get; set; }
    
        /// <summary>
        /// Gets or sets operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operations", Required = Newtonsoft.Json.Required.Default)]
        public IPrintOperationsCollectionPage Operations { get; set; }
    
        /// <summary>
        /// Gets or sets printers.
        /// The list of printers registered in the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "printers", Required = Newtonsoft.Json.Required.Default)]
        public IPrintPrintersCollectionPage Printers { get; set; }
    
        /// <summary>
        /// Gets or sets services.
        /// The list of available Universal Print service endpoints.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "services", Required = Newtonsoft.Json.Required.Default)]
        public IPrintServicesCollectionPage Services { get; set; }
    
        /// <summary>
        /// Gets or sets shares.
        /// The list of printer shares registered in the tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "shares", Required = Newtonsoft.Json.Required.Default)]
        public IPrintSharesCollectionPage Shares { get; set; }
    
        /// <summary>
        /// Gets or sets task definitions.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "taskDefinitions", Required = Newtonsoft.Json.Required.Default)]
        public IPrintTaskDefinitionsCollectionPage TaskDefinitions { get; set; }
    
        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }
    
    }
}

