// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph.Ediscovery
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type CaseLegalHoldsCollectionRequestBuilder.
    /// </summary>
    public partial class CaseLegalHoldsCollectionRequestBuilder : Microsoft.Graph.BaseRequestBuilder, ICaseLegalHoldsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CaseLegalHoldsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="Microsoft.Graph.IBaseClient"/> for handling requests.</param>
        public CaseLegalHoldsCollectionRequestBuilder(
            string requestUrl,
            Microsoft.Graph.IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICaseLegalHoldsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICaseLegalHoldsCollectionRequest Request(IEnumerable<Microsoft.Graph.Option> options)
        {
            return new CaseLegalHoldsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="ILegalHoldRequestBuilder"/> for the specified CaseLegalHold.
        /// </summary>
        /// <param name="id">The ID for the CaseLegalHold.</param>
        /// <returns>The <see cref="ILegalHoldRequestBuilder"/>.</returns>
        public ILegalHoldRequestBuilder this[string id]
        {
            get
            {
                return new LegalHoldRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
