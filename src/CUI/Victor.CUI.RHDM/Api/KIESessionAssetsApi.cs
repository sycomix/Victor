/* 
 * KIE Server
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 7.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Victor.CUI.RHDM.KIE.Client;
using Victor.CUI.RHDM.KIE.Model;

namespace Victor.CUI.RHDM.KIE.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IKIESessionAssetsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Executes one or more runtime commands
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>Response</returns>
        Response ExecuteContainerRules(string containerId, string body);

        /// <summary>
        /// Executes one or more runtime commands
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> ExecuteContainerRulesWithHttpInfo (string containerId, string body);
        #endregion Synchronous Operations

        #region Asynchronous Operations
        /// <summary>
        /// Executes one or more runtime commands
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> ExecuteContainerRulesAsync (string containerId, string body);

        /// <summary>
        /// Executes one or more runtime commands
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> ExecuteContainerRulesAsyncWithHttpInfo (string containerId, string body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KIESessionAssetsApi : IKIESessionAssetsApi
    {
        private Victor.CUI.RHDM.KIE.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="KIESessionAssetsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KIESessionAssetsApi(String basePath)
        {
            this.Configuration = new Victor.CUI.RHDM.KIE.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Victor.CUI.RHDM.KIE.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KIESessionAssetsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KIESessionAssetsApi(Victor.CUI.RHDM.KIE.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Victor.CUI.RHDM.KIE.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Victor.CUI.RHDM.KIE.Client.Configuration.DefaultExceptionFactory;
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
        public Victor.CUI.RHDM.KIE.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Victor.CUI.RHDM.KIE.Client.ExceptionFactory ExceptionFactory
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
        /// Executes one or more runtime commands 
        /// </summary>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>Response</returns>
        public Response ExecuteContainerRules(string containerId, string body)
        {
             ApiResponse<Response> localVarResponse = ExecuteContainerRulesWithHttpInfo(containerId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Executes one or more runtime commands 
        /// </summary>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > ExecuteContainerRulesWithHttpInfo (string containerId, string body)
        {
            // verify the required parameter 'containerId' is set
            if (containerId == null)
                throw new ApiException(400, "Missing required parameter 'containerId' when calling KIESessionAssetsApi->ManageContainer");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KIESessionAssetsApi->ManageContainer");

            var localVarPath = "/server/containers/instances/{containerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (containerId != null) localVarPathParams.Add("containerId", this.Configuration.ApiClient.ParameterToString(containerId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ManageContainer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
        }

        /// <summary>
        /// Executes one or more runtime commands 
        /// </summary>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> ExecuteContainerRulesAsync (string containerId, string body)
        {
             ApiResponse<Response> localVarResponse = await ExecuteContainerRulesAsyncWithHttpInfo(containerId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Executes one or more runtime commands 
        /// </summary>
        /// <exception cref="Victor.CUI.RHDM.KIE.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="containerId">Container id where rules should be evaluated on</param>
        /// <param name="body">Commands to be executed on rule engine given as BatchExecutionCommand type</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> ExecuteContainerRulesAsyncWithHttpInfo (string containerId, string body)
        {
            // verify the required parameter 'containerId' is set
            if (containerId == null)
                throw new ApiException(400, "Missing required parameter 'containerId' when calling KIESessionAssetsApi->ManageContainer");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling KIESessionAssetsApi->ManageContainer");

            var localVarPath = "/server/containers/instances/{containerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/xml", 
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/xml",
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (containerId != null) localVarPathParams.Add("containerId", this.Configuration.ApiClient.ParameterToString(containerId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ManageContainer", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Response)));
        }

    }
}
