/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    public interface IAlipayFundTransOrderApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 查询转账订单接口
        /// </summary>
        /// <remarks>
        /// 商户可通过该接口查询转账订单的状态、支付时间等相关信息，主要应用于B2C转账订单查询的场景
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outBizNo">商户转账唯一订单号：发起转账来源方定义的转账单据ID。  和支付宝转账单据号不能同时为空。当和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号：和商户转账唯一订单号不能同时为空。当和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundTransOrderQueryResponseModel</returns>
        AlipayFundTransOrderQueryResponseModel Query(string outBizNo = default(string), string orderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询转账订单接口
        /// </summary>
        /// <remarks>
        /// 商户可通过该接口查询转账订单的状态、支付时间等相关信息，主要应用于B2C转账订单查询的场景
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outBizNo">商户转账唯一订单号：发起转账来源方定义的转账单据ID。  和支付宝转账单据号不能同时为空。当和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号：和商户转账唯一订单号不能同时为空。当和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundTransOrderQueryResponseModel</returns>
        ApiResponse<AlipayFundTransOrderQueryResponseModel> QueryWithHttpInfo(string outBizNo = default(string), string orderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundTransOrderApi : IAlipayFundTransOrderApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundTransOrderApi : IAlipayFundTransOrderApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransOrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundTransOrderApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransOrderApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundTransOrderApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransOrderApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundTransOrderApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransOrderApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundTransOrderApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.Configuration = configuration;
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }


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
        /// 查询转账订单接口 商户可通过该接口查询转账订单的状态、支付时间等相关信息，主要应用于B2C转账订单查询的场景
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outBizNo">商户转账唯一订单号：发起转账来源方定义的转账单据ID。  和支付宝转账单据号不能同时为空。当和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号：和商户转账唯一订单号不能同时为空。当和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundTransOrderQueryResponseModel</returns>
        public AlipayFundTransOrderQueryResponseModel Query(string outBizNo = default(string), string orderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundTransOrderQueryResponseModel> localVarResponse = QueryWithHttpInfo(outBizNo, orderId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询转账订单接口 商户可通过该接口查询转账订单的状态、支付时间等相关信息，主要应用于B2C转账订单查询的场景
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="outBizNo">商户转账唯一订单号：发起转账来源方定义的转账单据ID。  和支付宝转账单据号不能同时为空。当和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数。 (optional)</param>
        /// <param name="orderId">支付宝转账单据号：和商户转账唯一订单号不能同时为空。当和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundTransOrderQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundTransOrderQueryResponseModel> QueryWithHttpInfo(string outBizNo = default(string), string orderId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }
            if (orderId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "order_id", orderId));
            }

            localVarRequestOptions.Operation = "AlipayFundTransOrderApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundTransOrderQueryResponseModel>("/v3/alipay/fund/trans/order/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundTransOrderQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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

    }
}
