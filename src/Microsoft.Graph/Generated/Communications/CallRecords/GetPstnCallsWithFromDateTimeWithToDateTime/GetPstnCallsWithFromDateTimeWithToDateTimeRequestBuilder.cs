using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Microsoft.Graph.Communications.CallRecords.GetPstnCallsWithFromDateTimeWithToDateTime {
    /// <summary>Provides operations to call the getPstnCalls method.</summary>
    public class GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder and sets the default values.
        /// <param name="fromDateTime">Usage: fromDateTime=&apos;{fromDateTime}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// <param name="toDateTime">Usage: toDateTime=&apos;{toDateTime}&apos;</param>
        /// </summary>
        public GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, DateTimeOffset? fromDateTime = default, DateTimeOffset? toDateTime = default) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/communications/callRecords/microsoft.graph.callRecords.getPstnCalls(fromDateTime='{fromDateTime}',toDateTime='{toDateTime}')";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            urlTplParams.Add("fromDateTime", fromDateTime);
            urlTplParams.Add("toDateTime", toDateTime);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/communications/callRecords/microsoft.graph.callRecords.getPstnCalls(fromDateTime='{fromDateTime}',toDateTime='{toDateTime}')";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Invoke function getPstnCalls
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Invoke function getPstnCalls
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<GetPstnCallsWithFromDateTimeWithToDateTimeResponse> GetAsync(CancellationToken cancellationToken = default, Action<GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"4XX", ODataError.CreateFromDiscriminatorValue},
                {"5XX", ODataError.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<GetPstnCallsWithFromDateTimeWithToDateTimeResponse>(requestInfo, GetPstnCallsWithFromDateTimeWithToDateTimeResponse.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new getPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public GetPstnCallsWithFromDateTimeWithToDateTimeRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
