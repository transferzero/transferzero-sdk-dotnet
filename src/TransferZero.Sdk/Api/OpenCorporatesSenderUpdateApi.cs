/* 
 * BitPesa Private API
 *
 * API specification used for internal BitPesa endpoints
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;

namespace TransferZero.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOpenCorporatesSenderUpdateApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Update Sender with data retrieved from Open Corporates
        /// </summary>
        /// <remarks>
        /// This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>OpenCorporatesSenderUpdateResponse</returns>
        OpenCorporatesSenderUpdateResponse UpdateSender (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest);

        /// <summary>
        /// Update Sender with data retrieved from Open Corporates
        /// </summary>
        /// <remarks>
        /// This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>ApiResponse of OpenCorporatesSenderUpdateResponse</returns>
        ApiResponse<OpenCorporatesSenderUpdateResponse> UpdateSenderWithHttpInfo (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Update Sender with data retrieved from Open Corporates
        /// </summary>
        /// <remarks>
        /// This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>Task of OpenCorporatesSenderUpdateResponse</returns>
        System.Threading.Tasks.Task<OpenCorporatesSenderUpdateResponse> UpdateSenderAsync (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest);

        /// <summary>
        /// Update Sender with data retrieved from Open Corporates
        /// </summary>
        /// <remarks>
        /// This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>Task of ApiResponse (OpenCorporatesSenderUpdateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OpenCorporatesSenderUpdateResponse>> UpdateSenderAsyncWithHttpInfo (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OpenCorporatesSenderUpdateApi : IOpenCorporatesSenderUpdateApi
    {
        private TransferZero.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCorporatesSenderUpdateApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OpenCorporatesSenderUpdateApi(String basePath)
        {
            this.Configuration = new TransferZero.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TransferZero.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCorporatesSenderUpdateApi"/> class
        /// </summary>
        /// <returns></returns>
        public OpenCorporatesSenderUpdateApi()
        {
            this.Configuration = TransferZero.Sdk.Client.Configuration.Default;

            ExceptionFactory = TransferZero.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCorporatesSenderUpdateApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OpenCorporatesSenderUpdateApi(TransferZero.Sdk.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = TransferZero.Sdk.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = TransferZero.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public TransferZero.Sdk.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public TransferZero.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Update Sender with data retrieved from Open Corporates This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>OpenCorporatesSenderUpdateResponse</returns>
        public OpenCorporatesSenderUpdateResponse UpdateSender (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest)
        {
             ApiResponse<OpenCorporatesSenderUpdateResponse> localVarResponse = UpdateSenderWithHttpInfo(openCorporatesSenderUpdateRequest);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Sender with data retrieved from Open Corporates This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>ApiResponse of OpenCorporatesSenderUpdateResponse</returns>
        public ApiResponse< OpenCorporatesSenderUpdateResponse > UpdateSenderWithHttpInfo (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest)
        {
            // verify the required parameter 'openCorporatesSenderUpdateRequest' is set
            if (openCorporatesSenderUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'openCorporatesSenderUpdateRequest' when calling OpenCorporatesSenderUpdateApi->UpdateSender");

            var localVarPath = "/open_corporates/update_sender";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (openCorporatesSenderUpdateRequest != null && openCorporatesSenderUpdateRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(openCorporatesSenderUpdateRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = openCorporatesSenderUpdateRequest; // byte array
            }

            var request = new RestRequest(localVarPath, Method.POST);

            // add path and query parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "POST", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OpenCorporatesSenderUpdateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OpenCorporatesSenderUpdateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenCorporatesSenderUpdateResponse)));
        }

        /// <summary>
        /// Update Sender with data retrieved from Open Corporates This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>Task of OpenCorporatesSenderUpdateResponse</returns>
        public async System.Threading.Tasks.Task<OpenCorporatesSenderUpdateResponse> UpdateSenderAsync (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest)
        {
             ApiResponse<OpenCorporatesSenderUpdateResponse> localVarResponse = await UpdateSenderAsyncWithHttpInfo(openCorporatesSenderUpdateRequest);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Sender with data retrieved from Open Corporates This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="openCorporatesSenderUpdateRequest"></param>
        /// <returns>Task of ApiResponse (OpenCorporatesSenderUpdateResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OpenCorporatesSenderUpdateResponse>> UpdateSenderAsyncWithHttpInfo (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest)
        {
            // verify the required parameter 'openCorporatesSenderUpdateRequest' is set
            if (openCorporatesSenderUpdateRequest == null)
                throw new ApiException(400, "Missing required parameter 'openCorporatesSenderUpdateRequest' when calling OpenCorporatesSenderUpdateApi->UpdateSender");

            var localVarPath = "/open_corporates/update_sender";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (openCorporatesSenderUpdateRequest != null && openCorporatesSenderUpdateRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(openCorporatesSenderUpdateRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = openCorporatesSenderUpdateRequest; // byte array
            }

            var request = new RestRequest(localVarPath, Method.POST);

            // add path parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "POST", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateSender", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OpenCorporatesSenderUpdateResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OpenCorporatesSenderUpdateResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OpenCorporatesSenderUpdateResponse)));
        }

    }
}
