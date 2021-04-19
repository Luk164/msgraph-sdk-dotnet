// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type OrganizationRequest.
    /// </summary>
    public partial class OrganizationRequest : BaseRequest, IOrganizationRequest
    {
        /// <summary>
        /// Constructs a new OrganizationRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public OrganizationRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified Organization using POST.
        /// </summary>
        /// <param name="organizationToCreate">The Organization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Organization.</returns>
        public async System.Threading.Tasks.Task<Organization> CreateAsync(Organization organizationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<Organization>(organizationToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified Organization using POST and returns a <see cref="GraphResponse{Organization}"/> object.
        /// </summary>
        /// <param name="organizationToCreate">The Organization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Organization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Organization>> CreateResponseAsync(Organization organizationToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<Organization>(organizationToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified Organization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<Organization>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified Organization and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified Organization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Organization.</returns>
        public async System.Threading.Tasks.Task<Organization> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<Organization>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified Organization and returns a <see cref="GraphResponse{Organization}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{Organization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Organization>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<Organization>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Organization using PATCH.
        /// </summary>
        /// <param name="organizationToUpdate">The Organization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated Organization.</returns>
        public async System.Threading.Tasks.Task<Organization> UpdateAsync(Organization organizationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<Organization>(organizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Organization using PATCH and returns a <see cref="GraphResponse{Organization}"/> object.
        /// </summary>
        /// <param name="organizationToUpdate">The Organization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{Organization}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Organization>> UpdateResponseAsync(Organization organizationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<Organization>(organizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified Organization using PUT.
        /// </summary>
        /// <param name="organizationToUpdate">The Organization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<Organization> PutAsync(Organization organizationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<Organization>(organizationToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified Organization using PUT and returns a <see cref="GraphResponse{Organization}"/> object.
        /// </summary>
        /// <param name="organizationToUpdate">The Organization object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{Organization}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<Organization>> PutResponseAsync(Organization organizationToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<Organization>(organizationToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationRequest Expand(Expression<Func<Organization, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IOrganizationRequest Select(Expression<Func<Organization, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="organizationToInitialize">The <see cref="Organization"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(Organization organizationToInitialize)
        {

            if (organizationToInitialize != null)
            {
                if (organizationToInitialize.CertificateBasedAuthConfiguration != null && organizationToInitialize.CertificateBasedAuthConfiguration.CurrentPage != null)
                {
                    organizationToInitialize.CertificateBasedAuthConfiguration.InitializeNextPageRequest(this.Client, organizationToInitialize.CertificateBasedAuthConfigurationNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    organizationToInitialize.CertificateBasedAuthConfiguration.AdditionalData = organizationToInitialize.AdditionalData;
                }
                if (organizationToInitialize.Extensions != null && organizationToInitialize.Extensions.CurrentPage != null)
                {
                    organizationToInitialize.Extensions.InitializeNextPageRequest(this.Client, organizationToInitialize.ExtensionsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    organizationToInitialize.Extensions.AdditionalData = organizationToInitialize.AdditionalData;
                }

            }


        }
    }
}
