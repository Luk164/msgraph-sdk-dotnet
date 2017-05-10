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
    /// The type WorkbookFunctionsOct2HexRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsOct2HexRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsOct2HexRequest>, IWorkbookFunctionsOct2HexRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsOct2HexRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="number">A number parameter for the OData method call.</param>
        /// <param name="places">A places parameter for the OData method call.</param>
        public WorkbookFunctionsOct2HexRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken number,
            Newtonsoft.Json.Linq.JToken places)
            : base(requestUrl, client)
        {
            this.SetParameter("number", number, true);
            this.SetParameter("places", places, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsOct2HexRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsOct2HexRequest(functionUrl, this.Client, options);

            if (this.HasParameter("number"))
            {
                request.RequestBody.Number = this.GetParameter<Newtonsoft.Json.Linq.JToken>("number");
            }

            if (this.HasParameter("places"))
            {
                request.RequestBody.Places = this.GetParameter<Newtonsoft.Json.Linq.JToken>("places");
            }

            return request;
        }
    }
}
