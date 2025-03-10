// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// TilesOperations operations.
    /// </summary>
    public partial class TilesOperations : IServiceOperations<PowerBIClient>, ITilesOperations
    {
        /// <summary>
        /// Initializes a new instance of the TilesOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public TilesOperations(PowerBIClient client)
        {
            if (client == null)
            {
                throw new System.ArgumentNullException("client");
            }
            Client = client;
        }

        /// <summary>
        /// Gets a reference to the PowerBIClient
        /// </summary>
        public PowerBIClient Client { get; private set; }

        /// <summary>
        /// Generates an embed token to view the specified tile from the specified
        /// workspace.
        /// </summary>
        /// <remarks>
        ///
        /// &gt; [!IMPORTANT]
        /// &gt; This API call is only relevant to the [embed for your
        /// customers](/power-bi/developer/embed-sample-for-customers) scenario. To
        /// learn more about using this API, see [Considerations when generating an
        /// embed token](/power-bi/developer/embedded/generate-embed-token).
        ///
        /// ## Permissions
        ///
        /// When using a service principal for authentication, refer to [Embed Power BI
        /// content with service
        /// principal](/power-bi/developer/embed-service-principal) and [Considerations
        /// and
        /// limitations](/power-bi/developer/embedded/embed-service-principal#considerations-and-limitations).
        ///
        /// ## Required Scope
        ///
        /// All of the following:
        ///
        /// - Dashboard.ReadWrite.All or Dashboard.Read.All
        /// - Report.ReadWrite.All or Report.Read.All
        /// - Dataset.ReadWrite.All or Dataset.Read.All
        /// &lt;br&gt;&lt;br&gt;
        /// </remarks>
        /// <param name='groupId'>
        /// The workspace ID
        /// </param>
        /// <param name='dashboardId'>
        /// The dashboard ID
        /// </param>
        /// <param name='tileId'>
        /// The tile ID
        /// </param>
        /// <param name='requestParameters'>
        /// Generate token parameters
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        /// <return>
        /// A response object containing the response body and response headers.
        /// </return>
        public async Task<HttpOperationResponse<EmbedToken>> GenerateTokenInGroupWithHttpMessagesAsync(System.Guid groupId, System.Guid dashboardId, System.Guid tileId, GenerateTokenRequest requestParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (requestParameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "requestParameters");
            }
            // Tracing
            bool _shouldTrace = ServiceClientTracing.IsEnabled;
            string _invocationId = null;
            if (_shouldTrace)
            {
                _invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("groupId", groupId);
                tracingParameters.Add("dashboardId", dashboardId);
                tracingParameters.Add("tileId", tileId);
                tracingParameters.Add("requestParameters", requestParameters);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(_invocationId, this, "GenerateTokenInGroup", tracingParameters);
            }
            // Construct URL
            var _baseUrl = Client.BaseUri.AbsoluteUri;
            var _url = new System.Uri(new System.Uri(_baseUrl + (_baseUrl.EndsWith("/") ? "" : "/")), "v1.0/myorg/groups/{groupId}/dashboards/{dashboardId}/tiles/{tileId}/GenerateToken").ToString();
            _url = _url.Replace("{groupId}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(groupId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{dashboardId}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(dashboardId, Client.SerializationSettings).Trim('"')));
            _url = _url.Replace("{tileId}", System.Uri.EscapeDataString(Rest.Serialization.SafeJsonConvert.SerializeObject(tileId, Client.SerializationSettings).Trim('"')));
            // Create HTTP transport objects
            var _httpRequest = new HttpRequestMessage();
            HttpResponseMessage _httpResponse = null;
            _httpRequest.Method = new HttpMethod("POST");
            _httpRequest.RequestUri = new System.Uri(_url);
            // Set Headers


            if (customHeaders != null)
            {
                foreach(var _header in customHeaders)
                {
                    if (_httpRequest.Headers.Contains(_header.Key))
                    {
                        _httpRequest.Headers.Remove(_header.Key);
                    }
                    _httpRequest.Headers.TryAddWithoutValidation(_header.Key, _header.Value);
                }
            }

            // Serialize Request
            string _requestContent = null;
            if(requestParameters != null)
            {
                _requestContent = Rest.Serialization.SafeJsonConvert.SerializeObject(requestParameters, Client.SerializationSettings);
                _httpRequest.Content = new StringContent(_requestContent, System.Text.Encoding.UTF8);
                _httpRequest.Content.Headers.ContentType =System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            }
            // Set Credentials
            if (Client.Credentials != null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                await Client.Credentials.ProcessHttpRequestAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            }
            // Send Request
            if (_shouldTrace)
            {
                ServiceClientTracing.SendRequest(_invocationId, _httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            _httpResponse = await Client.HttpClient.SendAsync(_httpRequest, cancellationToken).ConfigureAwait(false);
            if (_shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(_invocationId, _httpResponse);
            }
            HttpStatusCode _statusCode = _httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            string _responseContent = null;
            if ((int)_statusCode != 200)
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", _statusCode));
                if (_httpResponse.Content != null) {
                    _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                }
                else {
                    _responseContent = string.Empty;
                }
                ex.Request = new HttpRequestMessageWrapper(_httpRequest, _requestContent);
                ex.Response = new HttpResponseMessageWrapper(_httpResponse, _responseContent);
                if (_shouldTrace)
                {
                    ServiceClientTracing.Error(_invocationId, ex);
                }
                _httpRequest.Dispose();
                if (_httpResponse != null)
                {
                    _httpResponse.Dispose();
                }
                throw ex;
            }
            // Create Result
            var _result = new HttpOperationResponse<EmbedToken>();
            _result.Request = _httpRequest;
            _result.Response = _httpResponse;
            // Deserialize Response
            if ((int)_statusCode == 200)
            {
                _responseContent = await _httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    _result.Body = Rest.Serialization.SafeJsonConvert.DeserializeObject<EmbedToken>(_responseContent, Client.DeserializationSettings);
                }
                catch (JsonException ex)
                {
                    _httpRequest.Dispose();
                    if (_httpResponse != null)
                    {
                        _httpResponse.Dispose();
                    }
                    throw new SerializationException("Unable to deserialize the response.", _responseContent, ex);
                }
            }
            if (_shouldTrace)
            {
                ServiceClientTracing.Exit(_invocationId, _result);
            }
            return _result;
        }

    }
}
