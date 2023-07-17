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
    public interface IAlipayMarketingActivityMerchantApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询活动可用商户
        /// </summary>
        /// <remarks>
        /// 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityMerchantBatchqueryResponseModel</returns>
        AlipayMarketingActivityMerchantBatchqueryResponseModel Batchquery(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询活动可用商户
        /// </summary>
        /// <remarks>
        /// 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityMerchantBatchqueryResponseModel</returns>
        ApiResponse<AlipayMarketingActivityMerchantBatchqueryResponseModel> BatchqueryWithHttpInfo(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingActivityMerchantApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 查询活动可用商户
        /// </summary>
        /// <remarks>
        /// 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayMarketingActivityMerchantBatchqueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayMarketingActivityMerchantBatchqueryResponseModel> BatchqueryAsync(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询活动可用商户
        /// </summary>
        /// <remarks>
        /// 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayMarketingActivityMerchantBatchqueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayMarketingActivityMerchantBatchqueryResponseModel>> BatchqueryWithHttpInfoAsync(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingActivityMerchantApi : IAlipayMarketingActivityMerchantApiSync, IAlipayMarketingActivityMerchantApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayMarketingActivityMerchantApi : IAlipayMarketingActivityMerchantApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityMerchantApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingActivityMerchantApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityMerchantApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingActivityMerchantApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityMerchantApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayMarketingActivityMerchantApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityMerchantApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayMarketingActivityMerchantApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 查询活动可用商户 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityMerchantBatchqueryResponseModel</returns>
        public AlipayMarketingActivityMerchantBatchqueryResponseModel Batchquery(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityMerchantBatchqueryResponseModel> localVarResponse = BatchqueryWithHttpInfo(activityId, merchantId, pageNum, pageSize, merchantAccessMode, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询活动可用商户 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityMerchantBatchqueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityMerchantBatchqueryResponseModel> BatchqueryWithHttpInfo(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            // verify the required parameter 'activityId' is set
            if (activityId == null)
            {
                throw new AlipaySDKNet.OpenAPI.Client.ApiException(400, "Missing required parameter 'activityId' when calling AlipayMarketingActivityMerchantApi->Batchquery");
            }

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

            localVarRequestOptions.PathParameters.Add("activity_id", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(activityId)); // path parameter
            if (merchantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_id", merchantId));
            }
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (merchantAccessMode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_access_mode", merchantAccessMode));
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityMerchantApi.Batchquery";
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
            var localVarResponse = this.Client.Get<AlipayMarketingActivityMerchantBatchqueryResponseModel>("/v3/alipay/marketing/activity/{activity_id}/merchant/batchquery", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Batchquery", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingActivityMerchantBatchqueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询活动可用商户 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayMarketingActivityMerchantBatchqueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayMarketingActivityMerchantBatchqueryResponseModel> BatchqueryAsync(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityMerchantBatchqueryResponseModel> localVarResponse = await BatchqueryWithHttpInfoAsync(activityId, merchantId, pageNum, pageSize, merchantAccessMode, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询活动可用商户 通过此接口可查询活动的可用商户,判断活动是否在某商户可用，来决定是否展示。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="activityId">活动id</param>
        /// <param name="merchantId">商户PID,默认为当前接口调用商户  限制:  接口调用者必须有商户代运营权限。   代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83 (optional)</param>
        /// <param name="pageNum">分页查询页码。  限制:  必须为大于0的整数 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数。  限制:  1.必须为大于0的整数  2.每页最大值为20 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayMarketingActivityMerchantBatchqueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityMerchantBatchqueryResponseModel>> BatchqueryWithHttpInfoAsync(string activityId, string merchantId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), string merchantAccessMode = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            // verify the required parameter 'activityId' is set
            if (activityId == null)
            {
                throw new AlipaySDKNet.OpenAPI.Client.ApiException(400, "Missing required parameter 'activityId' when calling AlipayMarketingActivityMerchantApi->Batchquery");
            }


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

            localVarRequestOptions.PathParameters.Add("activity_id", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(activityId)); // path parameter
            if (merchantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_id", merchantId));
            }
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (merchantAccessMode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_access_mode", merchantAccessMode));
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityMerchantApi.Batchquery";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayMarketingActivityMerchantBatchqueryResponseModel>("/v3/alipay/marketing/activity/{activity_id}/merchant/batchquery", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Batchquery", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
