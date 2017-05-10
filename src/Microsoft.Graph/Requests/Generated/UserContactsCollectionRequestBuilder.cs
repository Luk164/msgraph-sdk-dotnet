// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type UserContactsCollectionRequestBuilder.
    /// </summary>
    public partial class UserContactsCollectionRequestBuilder : BaseRequestBuilder, IUserContactsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserContactsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserContactsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserContactsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserContactsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserContactsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IContactRequestBuilder"/> for the specified UserContact.
        /// </summary>
        /// <param name="id">The ID for the UserContact.</param>
        /// <returns>The <see cref="IContactRequestBuilder"/>.</returns>
        public IContactRequestBuilder this[string id]
        {
            get
            {
                return new ContactRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
