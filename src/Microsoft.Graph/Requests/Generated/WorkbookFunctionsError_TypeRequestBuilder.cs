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
    /// The type WorkbookFunctionsError_TypeRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsError_TypeRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsError_TypeRequest>, IWorkbookFunctionsError_TypeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsError_TypeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="errorVal">A errorVal parameter for the OData method call.</param>
        public WorkbookFunctionsError_TypeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            Newtonsoft.Json.Linq.JToken errorVal)
            : base(requestUrl, client)
        {
            this.SetParameter("errorVal", errorVal, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsError_TypeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsError_TypeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("errorVal"))
            {
                request.RequestBody.ErrorVal = this.GetParameter<Newtonsoft.Json.Linq.JToken>("errorVal");
            }

            return request;
        }
    }
}
