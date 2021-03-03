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
    /// The type PrintCertificateSigningRequest.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PrintCertificateSigningRequestObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintCertificateSigningRequestObject"/> class.
        /// </summary>
        public PrintCertificateSigningRequestObject()
        {
            this.ODataType = "microsoft.graph.printCertificateSigningRequest";
        }

        /// <summary>
        /// Gets or sets content.
        /// A base64-encoded pkcs10 certificate request. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "content", Required = Newtonsoft.Json.Required.Default)]
        public string Content { get; set; }
    
        /// <summary>
        /// Gets or sets transportKey.
        /// The base64-encoded public portion of an asymmetric key that is generated by the client. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "transportKey", Required = Newtonsoft.Json.Required.Default)]
        public string TransportKey { get; set; }
    
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
