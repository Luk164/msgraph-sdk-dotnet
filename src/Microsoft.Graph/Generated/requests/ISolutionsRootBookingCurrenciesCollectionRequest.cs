// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISolutionsRootBookingCurrenciesCollectionRequest.
    /// </summary>
    public partial interface ISolutionsRootBookingCurrenciesCollectionRequest : IBaseRequest
    {
        /// <summary>
        /// Adds the specified BookingCurrency to the collection via POST.
        /// </summary>
        /// <param name="bookingCurrency">The BookingCurrency to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created BookingCurrency.</returns>
        System.Threading.Tasks.Task<BookingCurrency> AddAsync(BookingCurrency bookingCurrency, CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified BookingCurrency to the collection via POST and returns a <see cref="GraphResponse{BookingCurrency}"/> object of the request.
        /// </summary>
        /// <param name="bookingCurrency">The BookingCurrency to add.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{BookingCurrency}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<BookingCurrency>> AddResponseAsync(BookingCurrency bookingCurrency, CancellationToken cancellationToken = default);


        /// <summary>
        /// Gets the collection page.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The collection page.</returns>
        System.Threading.Tasks.Task<ISolutionsRootBookingCurrenciesCollectionPage> GetAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the collection page and returns a <see cref="GraphResponse{SolutionsRootBookingCurrenciesCollectionResponse}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{SolutionsRootBookingCurrenciesCollectionResponse}"/> object.</returns>
        System.Threading.Tasks.Task<GraphResponse<SolutionsRootBookingCurrenciesCollectionResponse>> GetResponseAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Expand(Expression<Func<BookingCurrency, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Select(Expression<Func<BookingCurrency, object>> selectExpression);

        /// <summary>
        /// Adds the specified top value to the request.
        /// </summary>
        /// <param name="value">The top value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Top(int value);

        /// <summary>
        /// Adds the specified filter value to the request.
        /// </summary>
        /// <param name="value">The filter value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Filter(string value);

        /// <summary>
        /// Adds the specified skip value to the request.
        /// </summary>
        /// <param name="value">The skip value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest Skip(int value);

        /// <summary>
        /// Adds the specified orderby value to the request.
        /// </summary>
        /// <param name="value">The orderby value.</param>
        /// <returns>The request object to send.</returns>
        ISolutionsRootBookingCurrenciesCollectionRequest OrderBy(string value);
    }
}
