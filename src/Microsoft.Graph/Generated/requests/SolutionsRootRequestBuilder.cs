// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type SolutionsRootRequestBuilder.
    /// </summary>
    public partial class SolutionsRootRequestBuilder : BaseRequestBuilder, ISolutionsRootRequestBuilder
    {

        /// <summary>
        /// Constructs a new SolutionsRootRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SolutionsRootRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISolutionsRootRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISolutionsRootRequest Request(IEnumerable<Option> options)
        {
            return new SolutionsRootRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for BookingBusinesses.
        /// </summary>
        /// <returns>The <see cref="ISolutionsRootBookingBusinessesCollectionRequestBuilder"/>.</returns>
        public ISolutionsRootBookingBusinessesCollectionRequestBuilder BookingBusinesses
        {
            get
            {
                return new SolutionsRootBookingBusinessesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("bookingBusinesses"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for BookingCurrencies.
        /// </summary>
        /// <returns>The <see cref="ISolutionsRootBookingCurrenciesCollectionRequestBuilder"/>.</returns>
        public ISolutionsRootBookingCurrenciesCollectionRequestBuilder BookingCurrencies
        {
            get
            {
                return new SolutionsRootBookingCurrenciesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("bookingCurrencies"), this.Client);
            }
        }
    
    }
}
