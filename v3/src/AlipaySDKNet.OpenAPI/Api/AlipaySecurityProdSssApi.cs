/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using AlipaySDKNet.OpenAPI.Client;
using AlipaySDKNet.OpenAPI.Model;
using AlipaySDKNet.OpenAPI.Util;
using AlipaySDKNet.OpenAPI.Util.Model;

namespace AlipaySDKNet.OpenAPI.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipaySecurityProdSssApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 金柚测试3.0接口
        /// </summary>
        /// <remarks>
        /// 金柚测试3.0接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipaySecurityProdSssQueryResponseModel</returns>
        AlipaySecurityProdSssQueryResponseModel Query(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 金柚测试3.0接口
        /// </summary>
        /// <remarks>
        /// 金柚测试3.0接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipaySecurityProdSssQueryResponseModel</returns>
        ApiResponse<AlipaySecurityProdSssQueryResponseModel> QueryWithHttpInfo(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipaySecurityProdSssApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 金柚测试3.0接口
        /// </summary>
        /// <remarks>
        /// 金柚测试3.0接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipaySecurityProdSssQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipaySecurityProdSssQueryResponseModel> QueryAsync(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 金柚测试3.0接口
        /// </summary>
        /// <remarks>
        /// 金柚测试3.0接口
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipaySecurityProdSssQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipaySecurityProdSssQueryResponseModel>> QueryWithHttpInfoAsync(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipaySecurityProdSssApi : IAlipaySecurityProdSssApiSync, IAlipaySecurityProdSssApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipaySecurityProdSssApi : IAlipaySecurityProdSssApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityProdSssApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipaySecurityProdSssApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityProdSssApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipaySecurityProdSssApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityProdSssApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipaySecurityProdSssApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityProdSssApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipaySecurityProdSssApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public AlipaySDKNet.OpenAPI.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public AlipaySDKNet.OpenAPI.Client.ExceptionFactory ExceptionFactory
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
        /// 金柚测试3.0接口 金柚测试3.0接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipaySecurityProdSssQueryResponseModel</returns>
        public AlipaySecurityProdSssQueryResponseModel Query(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipaySecurityProdSssQueryResponseModel> localVarResponse = QueryWithHttpInfo(bbb, aaa, aaaOpenId, alipaySecurityProdSssQueryModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 金柚测试3.0接口 金柚测试3.0接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipaySecurityProdSssQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipaySecurityProdSssQueryResponseModel> QueryWithHttpInfo(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            // verify the required parameter 'bbb' is set
            if (bbb == null)
            {
                throw new AlipaySDKNet.OpenAPI.Client.ApiException(400, "Missing required parameter 'bbb' when calling AlipaySecurityProdSssApi->Query");
            }

            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("bbb", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(bbb)); // path parameter
            if (aaa != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "aaa", aaa));
            }
            if (aaaOpenId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "aaa_open_id", aaaOpenId));
            }
            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipaySecurityProdSssQueryModel;
            }

            localVarRequestOptions.Operation = "AlipaySecurityProdSssApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AlipaySecurityProdSssQueryResponseModel>("/v3/alipay/security/prod/sss/query/{bbb}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipaySecurityProdSssQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
                        }
                        catch (Exception e)
                        {
                            AlipayLogger.logBizWarn("解析default body内容失败", e);
                        }
                    }
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 金柚测试3.0接口 金柚测试3.0接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipaySecurityProdSssQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipaySecurityProdSssQueryResponseModel> QueryAsync(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipaySecurityProdSssQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(bbb, aaa, aaaOpenId, alipaySecurityProdSssQueryModel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 金柚测试3.0接口 金柚测试3.0接口
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="bbb">activity_id 词条描述</param>
        /// <param name="aaa">1 (optional)</param>
        /// <param name="aaaOpenId">1 (optional)</param>
        /// <param name="alipaySecurityProdSssQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipaySecurityProdSssQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipaySecurityProdSssQueryResponseModel>> QueryWithHttpInfoAsync(string bbb, string aaa = default(string), string aaaOpenId = default(string), AlipaySecurityProdSssQueryModel alipaySecurityProdSssQueryModel = default(AlipaySecurityProdSssQueryModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            // verify the required parameter 'bbb' is set
            if (bbb == null)
            {
                throw new AlipaySDKNet.OpenAPI.Client.ApiException(400, "Missing required parameter 'bbb' when calling AlipaySecurityProdSssApi->Query");
            }


            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = AlipaySDKNet.OpenAPI.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("bbb", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(bbb)); // path parameter
            if (aaa != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "aaa", aaa));
            }
            if (aaaOpenId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "aaa_open_id", aaaOpenId));
            }
            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipaySecurityProdSssQueryModel;
            }

            localVarRequestOptions.Operation = "AlipaySecurityProdSssApi.Query";
            localVarRequestOptions.OperationIndex = operationIndex;

            
            if (customizedParams != null)
            {
                //额外query参数
                if (customizedParams.QueryParams != null && customizedParams.QueryParams.Count > 0)
                {
                    foreach (var param in customizedParams.QueryParams)
                    {
                        localVarRequestOptions.QueryParameters.Add(param.Key, param.Value);
                    }
                }

                if (!string.IsNullOrEmpty(customizedParams.AppAuthToken))
                {
                    localVarRequestOptions.HeaderParameters.Add("alipay-app-auth-token", customizedParams.AppAuthToken);
                }
                
                //额外非全局header参数
                if (customizedParams.HeaderParams != null && customizedParams.HeaderParams.Count > 0)
                {
                    foreach (var param in customizedParams.HeaderParams)
                    {
                        localVarRequestOptions.HeaderParameters.Add(param.Key, param.Value);
                    }
                }
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AlipaySecurityProdSssQueryResponseModel>("/v3/alipay/security/prod/sss/query/{bbb}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
