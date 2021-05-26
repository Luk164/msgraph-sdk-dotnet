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
    /// The type B2x Identity User Flow.
    /// </summary>
    public partial class B2xIdentityUserFlow : IdentityUserFlow
    {
    
        /// <summary>
        /// Gets or sets api connector configuration.
        /// Configuration for enabling an API connector for use as part of the self-service sign up user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.
        /// </summary>
        [JsonPropertyName("apiConnectorConfiguration")]
        public UserFlowApiConnectorConfiguration ApiConnectorConfiguration { get; set; }
    
        /// <summary>
        /// Gets or sets identity providers.
        /// The identity providers included in the user flow.
        /// </summary>
        [JsonPropertyName("identityProviders")]
        public IB2xIdentityUserFlowIdentityProvidersCollectionWithReferencesPage IdentityProviders { get; set; }

        /// <summary>
        /// Gets or sets identityProvidersNextLink.
        /// </summary>
        [JsonPropertyName("identityProviders@odata.nextLink")]
        public string IdentityProvidersNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets languages.
        /// The languages supported for customization within the user flow. Language customization is enabled by default in self-service sign up user flow. You cannot create custom languages in self-service sign up user flows.
        /// </summary>
        [JsonPropertyName("languages")]
        public IB2xIdentityUserFlowLanguagesCollectionPage Languages { get; set; }

        /// <summary>
        /// Gets or sets languagesNextLink.
        /// </summary>
        [JsonPropertyName("languages@odata.nextLink")]
        public string LanguagesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user attribute assignments.
        /// The user attribute assignments included in the user flow.
        /// </summary>
        [JsonPropertyName("userAttributeAssignments")]
        public IB2xIdentityUserFlowUserAttributeAssignmentsCollectionPage UserAttributeAssignments { get; set; }

        /// <summary>
        /// Gets or sets userAttributeAssignmentsNextLink.
        /// </summary>
        [JsonPropertyName("userAttributeAssignments@odata.nextLink")]
        public string UserAttributeAssignmentsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets user flow identity providers.
        /// </summary>
        [JsonPropertyName("userFlowIdentityProviders")]
        public IB2xIdentityUserFlowUserFlowIdentityProvidersCollectionWithReferencesPage UserFlowIdentityProviders { get; set; }

        /// <summary>
        /// Gets or sets userFlowIdentityProvidersNextLink.
        /// </summary>
        [JsonPropertyName("userFlowIdentityProviders@odata.nextLink")]
        public string UserFlowIdentityProvidersNextLink { get; set; }
    
    }
}

