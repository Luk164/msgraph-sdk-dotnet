// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionWithReferencesResponse.cs.tt
namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ServicePrincipalTokenIssuancePoliciesCollectionWithReferencesResponse.
    /// </summary>
    public class ServicePrincipalTokenIssuancePoliciesCollectionWithReferencesResponse
    {
        /// <summary>
        /// Gets or sets the <see cref="IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesPage"/> value.
        /// </summary>
		[JsonPropertyName("value")]
        public IServicePrincipalTokenIssuancePoliciesCollectionWithReferencesPage Value { get; set; }

        /// <summary>
        /// Gets or sets the nextLink string value.
        /// </summary>
        [JsonPropertyName("@odata.nextLink")]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }
    }
}
