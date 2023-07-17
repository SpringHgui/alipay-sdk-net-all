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
    public interface IAlipayCommerceLogisticsInvoiceIstdwaybillApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 开即时配送订单发票
        /// </summary>
        /// <remarks>
        /// 开即时配送订单发票
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel</returns>
        AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel Create(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 开即时配送订单发票
        /// </summary>
        /// <remarks>
        /// 开即时配送订单发票
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel</returns>
        ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel> CreateWithHttpInfo(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询即时配送订单的开票结果
        /// </summary>
        /// <remarks>
        /// 查询即时配送订单的开票结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel</returns>
        AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel Query(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询即时配送订单的开票结果
        /// </summary>
        /// <remarks>
        /// 查询即时配送订单的开票结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel</returns>
        ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel> QueryWithHttpInfo(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceLogisticsInvoiceIstdwaybillApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 开即时配送订单发票
        /// </summary>
        /// <remarks>
        /// 开即时配送订单发票
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel</returns>
        System.Threading.Tasks.Task<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel> CreateAsync(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 开即时配送订单发票
        /// </summary>
        /// <remarks>
        /// 开即时配送订单发票
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel>> CreateWithHttpInfoAsync(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询即时配送订单的开票结果
        /// </summary>
        /// <remarks>
        /// 查询即时配送订单的开票结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel> QueryAsync(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询即时配送订单的开票结果
        /// </summary>
        /// <remarks>
        /// 查询即时配送订单的开票结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel>> QueryWithHttpInfoAsync(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceLogisticsInvoiceIstdwaybillApi : IAlipayCommerceLogisticsInvoiceIstdwaybillApiSync, IAlipayCommerceLogisticsInvoiceIstdwaybillApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayCommerceLogisticsInvoiceIstdwaybillApi : IAlipayCommerceLogisticsInvoiceIstdwaybillApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsInvoiceIstdwaybillApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceLogisticsInvoiceIstdwaybillApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsInvoiceIstdwaybillApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceLogisticsInvoiceIstdwaybillApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsInvoiceIstdwaybillApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayCommerceLogisticsInvoiceIstdwaybillApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsInvoiceIstdwaybillApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayCommerceLogisticsInvoiceIstdwaybillApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 开即时配送订单发票 开即时配送订单发票
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel</returns>
        public AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel Create(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayCommerceLogisticsInvoiceIstdwaybillCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 开即时配送订单发票 开即时配送订单发票
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel> CreateWithHttpInfo(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayCommerceLogisticsInvoiceIstdwaybillCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayCommerceLogisticsInvoiceIstdwaybillApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel>("/v3/alipay/commerce/logistics/invoice/istdwaybill/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayCommerceLogisticsInvoiceIstdwaybillCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 开即时配送订单发票 开即时配送订单发票
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel> CreateAsync(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel> localVarResponse = await CreateWithHttpInfoAsync(alipayCommerceLogisticsInvoiceIstdwaybillCreateModel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 开即时配送订单发票 开即时配送订单发票
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceLogisticsInvoiceIstdwaybillCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel>> CreateWithHttpInfoAsync(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel alipayCommerceLogisticsInvoiceIstdwaybillCreateModel = default(AlipayCommerceLogisticsInvoiceIstdwaybillCreateModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {

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

            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayCommerceLogisticsInvoiceIstdwaybillCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayCommerceLogisticsInvoiceIstdwaybillApi.Create";
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
            var localVarResponse = await this.AsynchronousClient.PostAsync<AlipayCommerceLogisticsInvoiceIstdwaybillCreateResponseModel>("/v3/alipay/commerce/logistics/invoice/istdwaybill/create", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 查询即时配送订单的开票结果 查询即时配送订单的开票结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel</returns>
        public AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel Query(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel> localVarResponse = QueryWithHttpInfo(logisticsCode, outInvoiceRequestNo, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询即时配送订单的开票结果 查询即时配送订单的开票结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel> QueryWithHttpInfo(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            if (logisticsCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "logistics_code", logisticsCode));
            }
            if (outInvoiceRequestNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_invoice_request_no", outInvoiceRequestNo));
            }

            localVarRequestOptions.Operation = "AlipayCommerceLogisticsInvoiceIstdwaybillApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel>("/v3/alipay/commerce/logistics/invoice/istdwaybill/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayCommerceLogisticsInvoiceIstdwaybillQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询即时配送订单的开票结果 查询即时配送订单的开票结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel> QueryAsync(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(logisticsCode, outInvoiceRequestNo, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询即时配送订单的开票结果 查询即时配送订单的开票结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="logisticsCode">即时配送公司编码 (optional)</param>
        /// <param name="outInvoiceRequestNo">开票请求流水号 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel>> QueryWithHttpInfoAsync(string logisticsCode = default(string), string outInvoiceRequestNo = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {

            AlipaySDKNet.OpenAPI.Client.RequestOptions localVarRequestOptions = new AlipaySDKNet.OpenAPI.Client.RequestOptions();

            string[] _contentTypes = new string[] {
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

            if (logisticsCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "logistics_code", logisticsCode));
            }
            if (outInvoiceRequestNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_invoice_request_no", outInvoiceRequestNo));
            }

            localVarRequestOptions.Operation = "AlipayCommerceLogisticsInvoiceIstdwaybillApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayCommerceLogisticsInvoiceIstdwaybillQueryResponseModel>("/v3/alipay/commerce/logistics/invoice/istdwaybill/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
