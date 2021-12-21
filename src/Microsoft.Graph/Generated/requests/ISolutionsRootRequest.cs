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
    /// The interface ISolutionsRootRequest.
    /// </summary>
    public partial interface ISolutionsRootRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SolutionsRoot using POST.
        /// </summary>
        /// <param name="solutionsRootToCreate">The SolutionsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SolutionsRoot.</returns>
        System.Threading.Tasks.Task<SolutionsRoot> CreateAsync(SolutionsRoot solutionsRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates the specified SolutionsRoot using POST and returns a <see cref="GraphResponse{SolutionsRoot}"/> object.
        /// </summary>
        /// <param name="solutionsRootToCreate">The SolutionsRoot to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SolutionsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SolutionsRoot>> CreateResponseAsync(SolutionsRoot solutionsRootToCreate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SolutionsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the specified SolutionsRoot and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SolutionsRoot.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SolutionsRoot.</returns>
        System.Threading.Tasks.Task<SolutionsRoot> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the specified SolutionsRoot and returns a <see cref="GraphResponse{SolutionsRoot}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SolutionsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SolutionsRoot>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SolutionsRoot using PATCH.
        /// </summary>
        /// <param name="solutionsRootToUpdate">The SolutionsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated SolutionsRoot.</returns>
        System.Threading.Tasks.Task<SolutionsRoot> UpdateAsync(SolutionsRoot solutionsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SolutionsRoot using PATCH and returns a <see cref="GraphResponse{SolutionsRoot}"/> object.
        /// </summary>
        /// <param name="solutionsRootToUpdate">The SolutionsRoot to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{SolutionsRoot}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<SolutionsRoot>> UpdateResponseAsync(SolutionsRoot solutionsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SolutionsRoot using PUT.
        /// </summary>
        /// <param name="solutionsRootToUpdate">The SolutionsRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<SolutionsRoot> PutAsync(SolutionsRoot solutionsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the specified SolutionsRoot using PUT and returns a <see cref="GraphResponse{SolutionsRoot}"/> object.
        /// </summary>
        /// <param name="solutionsRootToUpdate">The SolutionsRoot object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{SolutionsRoot}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<SolutionsRoot>> PutResponseAsync(SolutionsRoot solutionsRootToUpdate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootRequest Expand(Expression<Func<SolutionsRoot, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootRequest Select(Expression<Func<SolutionsRoot, object>> selectExpression);

    }
}
