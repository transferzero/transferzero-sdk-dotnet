/* 
 * TransferZero API
 *
 * Reference documentation for the TransferZero API V1
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
    public interface ICurrencyInfoApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Getting a list of possible requested currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyListResponse</returns>
        CurrencyListResponse InfoCurrencies ();

        /// <summary>
        /// Getting a list of possible requested currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyListResponse</returns>
        ApiResponse<CurrencyListResponse> InfoCurrenciesWithHttpInfo ();
        /// <summary>
        /// Getting a list of possible input currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyExchangeListResponse</returns>
        CurrencyExchangeListResponse InfoCurrenciesIn ();

        /// <summary>
        /// Getting a list of possible input currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyExchangeListResponse</returns>
        ApiResponse<CurrencyExchangeListResponse> InfoCurrenciesInWithHttpInfo ();
        /// <summary>
        /// Getting a list of possible output currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyExchangeListResponse</returns>
        CurrencyExchangeListResponse InfoCurrenciesOut ();

        /// <summary>
        /// Getting a list of possible output currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyExchangeListResponse</returns>
        ApiResponse<CurrencyExchangeListResponse> InfoCurrenciesOutWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Getting a list of possible requested currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyListResponse</returns>
        System.Threading.Tasks.Task<CurrencyListResponse> InfoCurrenciesAsync ();

        /// <summary>
        /// Getting a list of possible requested currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrencyListResponse>> InfoCurrenciesAsyncWithHttpInfo ();
        /// <summary>
        /// Getting a list of possible input currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyExchangeListResponse</returns>
        System.Threading.Tasks.Task<CurrencyExchangeListResponse> InfoCurrenciesInAsync ();

        /// <summary>
        /// Getting a list of possible input currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyExchangeListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrencyExchangeListResponse>> InfoCurrenciesInAsyncWithHttpInfo ();
        /// <summary>
        /// Getting a list of possible output currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyExchangeListResponse</returns>
        System.Threading.Tasks.Task<CurrencyExchangeListResponse> InfoCurrenciesOutAsync ();

        /// <summary>
        /// Getting a list of possible output currencies
        /// </summary>
        /// <remarks>
        /// Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </remarks>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyExchangeListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CurrencyExchangeListResponse>> InfoCurrenciesOutAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CurrencyInfoApi : ICurrencyInfoApi
    {
        private TransferZero.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CurrencyInfoApi(String basePath)
        {
            this.Configuration = new TransferZero.Sdk.Client.Configuration { BasePath = basePath };

            ExceptionFactory = TransferZero.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyInfoApi"/> class
        /// </summary>
        /// <returns></returns>
        public CurrencyInfoApi()
        {
            this.Configuration = TransferZero.Sdk.Client.Configuration.Default;

            ExceptionFactory = TransferZero.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyInfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CurrencyInfoApi(TransferZero.Sdk.Client.Configuration configuration = null)
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
        /// Getting a list of possible requested currencies Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyListResponse</returns>
        public CurrencyListResponse InfoCurrencies ()
        {
             ApiResponse<CurrencyListResponse> localVarResponse = InfoCurrenciesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Getting a list of possible requested currencies Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyListResponse</returns>
        public ApiResponse< CurrencyListResponse > InfoCurrenciesWithHttpInfo ()
        {

            var localVarPath = "/info/currencies";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            var request = new RestRequest(localVarPath, Method.GET);

            // add path and query parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InfoCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrencyListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyListResponse)));
        }

        /// <summary>
        /// Getting a list of possible requested currencies Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyListResponse</returns>
        public async System.Threading.Tasks.Task<CurrencyListResponse> InfoCurrenciesAsync ()
        {
             ApiResponse<CurrencyListResponse> localVarResponse = await InfoCurrenciesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Getting a list of possible requested currencies Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CurrencyListResponse>> InfoCurrenciesAsyncWithHttpInfo ()
        {

            var localVarPath = "/info/currencies";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            var request = new RestRequest(localVarPath, Method.GET);

            // add path parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InfoCurrencies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrencyListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyListResponse)));
        }

        /// <summary>
        /// Getting a list of possible input currencies Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyExchangeListResponse</returns>
        public CurrencyExchangeListResponse InfoCurrenciesIn ()
        {
             ApiResponse<CurrencyExchangeListResponse> localVarResponse = InfoCurrenciesInWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Getting a list of possible input currencies Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyExchangeListResponse</returns>
        public ApiResponse< CurrencyExchangeListResponse > InfoCurrenciesInWithHttpInfo ()
        {

            var localVarPath = "/info/currencies/in";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            var request = new RestRequest(localVarPath, Method.GET);

            // add path and query parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InfoCurrenciesIn", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyExchangeListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrencyExchangeListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyExchangeListResponse)));
        }

        /// <summary>
        /// Getting a list of possible input currencies Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyExchangeListResponse</returns>
        public async System.Threading.Tasks.Task<CurrencyExchangeListResponse> InfoCurrenciesInAsync ()
        {
             ApiResponse<CurrencyExchangeListResponse> localVarResponse = await InfoCurrenciesInAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Getting a list of possible input currencies Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that&#39;s available. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyExchangeListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CurrencyExchangeListResponse>> InfoCurrenciesInAsyncWithHttpInfo ()
        {

            var localVarPath = "/info/currencies/in";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            var request = new RestRequest(localVarPath, Method.GET);

            // add path parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InfoCurrenciesIn", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyExchangeListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrencyExchangeListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyExchangeListResponse)));
        }

        /// <summary>
        /// Getting a list of possible output currencies Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CurrencyExchangeListResponse</returns>
        public CurrencyExchangeListResponse InfoCurrenciesOut ()
        {
             ApiResponse<CurrencyExchangeListResponse> localVarResponse = InfoCurrenciesOutWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Getting a list of possible output currencies Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CurrencyExchangeListResponse</returns>
        public ApiResponse< CurrencyExchangeListResponse > InfoCurrenciesOutWithHttpInfo ()
        {

            var localVarPath = "/info/currencies/out";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            var request = new RestRequest(localVarPath, Method.GET);

            // add path and query parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InfoCurrenciesOut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyExchangeListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrencyExchangeListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyExchangeListResponse)));
        }

        /// <summary>
        /// Getting a list of possible output currencies Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of CurrencyExchangeListResponse</returns>
        public async System.Threading.Tasks.Task<CurrencyExchangeListResponse> InfoCurrenciesOutAsync ()
        {
             ApiResponse<CurrencyExchangeListResponse> localVarResponse = await InfoCurrenciesOutAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Getting a list of possible output currencies Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 
        /// </summary>
        /// <exception cref="TransferZero.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (CurrencyExchangeListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CurrencyExchangeListResponse>> InfoCurrenciesOutAsyncWithHttpInfo ()
        {

            var localVarPath = "/info/currencies/out";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            var request = new RestRequest(localVarPath, Method.GET);

            // add path parameter, if any
            foreach (var param in localVarPathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in localVarQueryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // generate full URL
            string fullUri = this.Configuration.ApiClient.RestClient.BuildUri(request).AbsoluteUri;

			string nonce = System.Guid.NewGuid().ToString();
            string authSignature = this.Configuration.GetSignature(nonce, fullUri, "GET", localVarPostBody == null ? "" : localVarPostBody.ToString());
			localVarHeaderParams.Add("Authorization-Key", this.Configuration.ApiKey);
            localVarHeaderParams.Add("Authorization-Nonce", nonce);
			localVarHeaderParams.Add("Authorization-Signature", authSignature);

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("InfoCurrenciesOut", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CurrencyExchangeListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CurrencyExchangeListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CurrencyExchangeListResponse)));
        }

    }
}
