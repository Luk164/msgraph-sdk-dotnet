// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsQuartile_ExcRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsQuartile_ExcRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsQuartile_ExcRequest>, IWorkbookFunctionsQuartile_ExcRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsQuartile_ExcRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="array">A array parameter for the OData method call.</param>
        /// <param name="quart">A quart parameter for the OData method call.</param>
        public WorkbookFunctionsQuartile_ExcRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken array,
            Newtonsoft.Json.Linq.JToken quart)
            : base(requestUrl, client)
        {
            this.SetParameter("array", array, true);
            this.SetParameter("quart", quart, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsQuartile_ExcRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsQuartile_ExcRequest(functionUrl, this.Client, options);

            if (this.HasParameter("array"))
            {
                request.RequestBody.Array = this.GetParameter<Newtonsoft.Json.Linq.JToken>("array");
            }

            if (this.HasParameter("quart"))
            {
                request.RequestBody.Quart = this.GetParameter<Newtonsoft.Json.Linq.JToken>("quart");
            }

            return request;
        }
    }
}
