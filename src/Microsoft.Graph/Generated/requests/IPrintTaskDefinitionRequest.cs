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
    /// The interface IPrintTaskDefinitionRequest.
    /// </summary>
    public partial interface IPrintTaskDefinitionRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintTaskDefinition using POST.
        /// </summary>
        /// <param name="printTaskDefinitionToCreate">The PrintTaskDefinition to create.</param>
        /// <returns>The created PrintTaskDefinition.</returns>
        System.Threading.Tasks.Task<PrintTaskDefinition> CreateAsync(PrintTaskDefinition printTaskDefinitionToCreate);        /// <summary>
        /// Creates the specified PrintTaskDefinition using POST.
        /// </summary>
        /// <param name="printTaskDefinitionToCreate">The PrintTaskDefinition to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintTaskDefinition.</returns>
        System.Threading.Tasks.Task<PrintTaskDefinition> CreateAsync(PrintTaskDefinition printTaskDefinitionToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrintTaskDefinition.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrintTaskDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrintTaskDefinition.
        /// </summary>
        /// <returns>The PrintTaskDefinition.</returns>
        System.Threading.Tasks.Task<PrintTaskDefinition> GetAsync();

        /// <summary>
        /// Gets the specified PrintTaskDefinition.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintTaskDefinition.</returns>
        System.Threading.Tasks.Task<PrintTaskDefinition> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrintTaskDefinition using PATCH.
        /// </summary>
        /// <param name="printTaskDefinitionToUpdate">The PrintTaskDefinition to update.</param>
        /// <returns>The updated PrintTaskDefinition.</returns>
        System.Threading.Tasks.Task<PrintTaskDefinition> UpdateAsync(PrintTaskDefinition printTaskDefinitionToUpdate);

        /// <summary>
        /// Updates the specified PrintTaskDefinition using PATCH.
        /// </summary>
        /// <param name="printTaskDefinitionToUpdate">The PrintTaskDefinition to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintTaskDefinition.</returns>
        System.Threading.Tasks.Task<PrintTaskDefinition> UpdateAsync(PrintTaskDefinition printTaskDefinitionToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskDefinitionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskDefinitionRequest Expand(Expression<Func<PrintTaskDefinition, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskDefinitionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintTaskDefinitionRequest Select(Expression<Func<PrintTaskDefinition, object>> selectExpression);

    }
}
