// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IOrganizationalBrandingLocalizationRequest.
    /// </summary>
    public partial interface IOrganizationalBrandingLocalizationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified OrganizationalBrandingLocalization using POST.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToCreate">The OrganizationalBrandingLocalization to create.</param>
        /// <returns>The created OrganizationalBrandingLocalization.</returns>
        System.Threading.Tasks.Task<OrganizationalBrandingLocalization> CreateAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToCreate);        /// <summary>
        /// Creates the specified OrganizationalBrandingLocalization using POST.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToCreate">The OrganizationalBrandingLocalization to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created OrganizationalBrandingLocalization.</returns>
        System.Threading.Tasks.Task<OrganizationalBrandingLocalization> CreateAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified OrganizationalBrandingLocalization.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified OrganizationalBrandingLocalization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified OrganizationalBrandingLocalization.
        /// </summary>
        /// <returns>The OrganizationalBrandingLocalization.</returns>
        System.Threading.Tasks.Task<OrganizationalBrandingLocalization> GetAsync();

        /// <summary>
        /// Gets the specified OrganizationalBrandingLocalization.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The OrganizationalBrandingLocalization.</returns>
        System.Threading.Tasks.Task<OrganizationalBrandingLocalization> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified OrganizationalBrandingLocalization using PATCH.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToUpdate">The OrganizationalBrandingLocalization to update.</param>
        /// <returns>The updated OrganizationalBrandingLocalization.</returns>
        System.Threading.Tasks.Task<OrganizationalBrandingLocalization> UpdateAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToUpdate);

        /// <summary>
        /// Updates the specified OrganizationalBrandingLocalization using PATCH.
        /// </summary>
        /// <param name="organizationalBrandingLocalizationToUpdate">The OrganizationalBrandingLocalization to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated OrganizationalBrandingLocalization.</returns>
        System.Threading.Tasks.Task<OrganizationalBrandingLocalization> UpdateAsync(OrganizationalBrandingLocalization organizationalBrandingLocalizationToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingLocalizationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingLocalizationRequest Expand(Expression<Func<OrganizationalBrandingLocalization, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingLocalizationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IOrganizationalBrandingLocalizationRequest Select(Expression<Func<OrganizationalBrandingLocalization, object>> selectExpression);

    }
}
