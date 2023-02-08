// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface ITenantRelationshipRequestBuilder.
    /// </summary>
    public partial interface ITenantRelationshipRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        ITenantRelationshipRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        ITenantRelationshipRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for DelegatedAdminCustomers.
        /// </summary>
        /// <returns>The <see cref="ITenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder"/>.</returns>
        ITenantRelationshipDelegatedAdminCustomersCollectionRequestBuilder DelegatedAdminCustomers { get; }

        /// <summary>
        /// Gets the request builder for DelegatedAdminRelationships.
        /// </summary>
        /// <returns>The <see cref="ITenantRelationshipDelegatedAdminRelationshipsCollectionRequestBuilder"/>.</returns>
        ITenantRelationshipDelegatedAdminRelationshipsCollectionRequestBuilder DelegatedAdminRelationships { get; }
    
    }
}
