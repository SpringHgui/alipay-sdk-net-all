/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    public interface IAlipayMarketingActivityUserApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 条件查询用户券
        /// </summary>
        /// <remarks>
        /// 可通过该接口查询用户在某商户可用的全部券，可用于商户的小程序/H5中，用户\&quot;我的优惠券\&quot;或\&quot;提交订单页\&quot;展示优惠信息。只能查询商户配的券，无法查询平台优惠券。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">支付宝用户 id (optional)</param>
        /// <param name="openId">支付宝用户openId (optional)</param>
        /// <param name="activityId">活动 id (optional)</param>
        /// <param name="belongMerchantId">券归属商户 (optional)</param>
        /// <param name="senderMerchantId">券发放商户 (optional)</param>
        /// <param name="voucherStatus">券状态，其中已过期状态可查询6个月内的数据 (optional)</param>
        /// <param name="pageNum">分页查询页码 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityUserBatchqueryvoucherResponseModel</returns>
        AlipayMarketingActivityUserBatchqueryvoucherResponseModel Batchqueryvoucher(string userId = default(string), string openId = default(string), string activityId = default(string), string belongMerchantId = default(string), string senderMerchantId = default(string), string voucherStatus = default(string), int? pageNum = default(int?), string merchantAccessMode = default(string), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 条件查询用户券
        /// </summary>
        /// <remarks>
        /// 可通过该接口查询用户在某商户可用的全部券，可用于商户的小程序/H5中，用户\&quot;我的优惠券\&quot;或\&quot;提交订单页\&quot;展示优惠信息。只能查询商户配的券，无法查询平台优惠券。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">支付宝用户 id (optional)</param>
        /// <param name="openId">支付宝用户openId (optional)</param>
        /// <param name="activityId">活动 id (optional)</param>
        /// <param name="belongMerchantId">券归属商户 (optional)</param>
        /// <param name="senderMerchantId">券发放商户 (optional)</param>
        /// <param name="voucherStatus">券状态，其中已过期状态可查询6个月内的数据 (optional)</param>
        /// <param name="pageNum">分页查询页码 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityUserBatchqueryvoucherResponseModel</returns>
        ApiResponse<AlipayMarketingActivityUserBatchqueryvoucherResponseModel> BatchqueryvoucherWithHttpInfo(string userId = default(string), string openId = default(string), string activityId = default(string), string belongMerchantId = default(string), string senderMerchantId = default(string), string voucherStatus = default(string), int? pageNum = default(int?), string merchantAccessMode = default(string), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询用户券详情
        /// </summary>
        /// <remarks>
        /// 通过此接口可以查询用户券信息，包括用户券的基础信息、状态。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">商户 PID，默认为当前接口调用商户。 (optional)</param>
        /// <param name="userId">支付宝user_id账号 (optional)</param>
        /// <param name="openId">领券的支付宝用户openId (optional)</param>
        /// <param name="activityId">活动id (optional)</param>
        /// <param name="voucherId">用户券 id。支付宝为用户优惠券唯一分配的 id。 (optional)</param>
        /// <param name="voucherCode">用户领取的商家券券码。 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityUserQueryvoucherResponseModel</returns>
        AlipayMarketingActivityUserQueryvoucherResponseModel Queryvoucher(string merchantId = default(string), string userId = default(string), string openId = default(string), string activityId = default(string), string voucherId = default(string), string voucherCode = default(string), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询用户券详情
        /// </summary>
        /// <remarks>
        /// 通过此接口可以查询用户券信息，包括用户券的基础信息、状态。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">商户 PID，默认为当前接口调用商户。 (optional)</param>
        /// <param name="userId">支付宝user_id账号 (optional)</param>
        /// <param name="openId">领券的支付宝用户openId (optional)</param>
        /// <param name="activityId">活动id (optional)</param>
        /// <param name="voucherId">用户券 id。支付宝为用户优惠券唯一分配的 id。 (optional)</param>
        /// <param name="voucherCode">用户领取的商家券券码。 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityUserQueryvoucherResponseModel</returns>
        ApiResponse<AlipayMarketingActivityUserQueryvoucherResponseModel> QueryvoucherWithHttpInfo(string merchantId = default(string), string userId = default(string), string openId = default(string), string activityId = default(string), string voucherId = default(string), string voucherCode = default(string), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingActivityUserApi : IAlipayMarketingActivityUserApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayMarketingActivityUserApi : IAlipayMarketingActivityUserApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityUserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingActivityUserApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityUserApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingActivityUserApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityUserApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayMarketingActivityUserApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityUserApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayMarketingActivityUserApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 条件查询用户券 可通过该接口查询用户在某商户可用的全部券，可用于商户的小程序/H5中，用户\&quot;我的优惠券\&quot;或\&quot;提交订单页\&quot;展示优惠信息。只能查询商户配的券，无法查询平台优惠券。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">支付宝用户 id (optional)</param>
        /// <param name="openId">支付宝用户openId (optional)</param>
        /// <param name="activityId">活动 id (optional)</param>
        /// <param name="belongMerchantId">券归属商户 (optional)</param>
        /// <param name="senderMerchantId">券发放商户 (optional)</param>
        /// <param name="voucherStatus">券状态，其中已过期状态可查询6个月内的数据 (optional)</param>
        /// <param name="pageNum">分页查询页码 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityUserBatchqueryvoucherResponseModel</returns>
        public AlipayMarketingActivityUserBatchqueryvoucherResponseModel Batchqueryvoucher(string userId = default(string), string openId = default(string), string activityId = default(string), string belongMerchantId = default(string), string senderMerchantId = default(string), string voucherStatus = default(string), int? pageNum = default(int?), string merchantAccessMode = default(string), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityUserBatchqueryvoucherResponseModel> localVarResponse = BatchqueryvoucherWithHttpInfo(userId, openId, activityId, belongMerchantId, senderMerchantId, voucherStatus, pageNum, merchantAccessMode, pageSize, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 条件查询用户券 可通过该接口查询用户在某商户可用的全部券，可用于商户的小程序/H5中，用户\&quot;我的优惠券\&quot;或\&quot;提交订单页\&quot;展示优惠信息。只能查询商户配的券，无法查询平台优惠券。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">支付宝用户 id (optional)</param>
        /// <param name="openId">支付宝用户openId (optional)</param>
        /// <param name="activityId">活动 id (optional)</param>
        /// <param name="belongMerchantId">券归属商户 (optional)</param>
        /// <param name="senderMerchantId">券发放商户 (optional)</param>
        /// <param name="voucherStatus">券状态，其中已过期状态可查询6个月内的数据 (optional)</param>
        /// <param name="pageNum">分页查询页码 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式 (optional)</param>
        /// <param name="pageSize">分页查询单页数据条数 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityUserBatchqueryvoucherResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityUserBatchqueryvoucherResponseModel> BatchqueryvoucherWithHttpInfo(string userId = default(string), string openId = default(string), string activityId = default(string), string belongMerchantId = default(string), string senderMerchantId = default(string), string voucherStatus = default(string), int? pageNum = default(int?), string merchantAccessMode = default(string), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (activityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "activity_id", activityId));
            }
            if (belongMerchantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "belong_merchant_id", belongMerchantId));
            }
            if (senderMerchantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "sender_merchant_id", senderMerchantId));
            }
            if (voucherStatus != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "voucher_status", voucherStatus));
            }
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (merchantAccessMode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_access_mode", merchantAccessMode));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityUserApi.Batchqueryvoucher";
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
            var localVarResponse = this.Client.Get<AlipayMarketingActivityUserBatchqueryvoucherResponseModel>("/v3/alipay/marketing/activity/ordervoucher/user/batchqueryvoucher", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Batchqueryvoucher", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingActivityUserBatchqueryvoucherDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询用户券详情 通过此接口可以查询用户券信息，包括用户券的基础信息、状态。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">商户 PID，默认为当前接口调用商户。 (optional)</param>
        /// <param name="userId">支付宝user_id账号 (optional)</param>
        /// <param name="openId">领券的支付宝用户openId (optional)</param>
        /// <param name="activityId">活动id (optional)</param>
        /// <param name="voucherId">用户券 id。支付宝为用户优惠券唯一分配的 id。 (optional)</param>
        /// <param name="voucherCode">用户领取的商家券券码。 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityUserQueryvoucherResponseModel</returns>
        public AlipayMarketingActivityUserQueryvoucherResponseModel Queryvoucher(string merchantId = default(string), string userId = default(string), string openId = default(string), string activityId = default(string), string voucherId = default(string), string voucherCode = default(string), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityUserQueryvoucherResponseModel> localVarResponse = QueryvoucherWithHttpInfo(merchantId, userId, openId, activityId, voucherId, voucherCode, merchantAccessMode, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询用户券详情 通过此接口可以查询用户券信息，包括用户券的基础信息、状态。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantId">商户 PID，默认为当前接口调用商户。 (optional)</param>
        /// <param name="userId">支付宝user_id账号 (optional)</param>
        /// <param name="openId">领券的支付宝用户openId (optional)</param>
        /// <param name="activityId">活动id (optional)</param>
        /// <param name="voucherId">用户券 id。支付宝为用户优惠券唯一分配的 id。 (optional)</param>
        /// <param name="voucherCode">用户领取的商家券券码。 (optional)</param>
        /// <param name="merchantAccessMode">商户接入模式。 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityUserQueryvoucherResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityUserQueryvoucherResponseModel> QueryvoucherWithHttpInfo(string merchantId = default(string), string userId = default(string), string openId = default(string), string activityId = default(string), string voucherId = default(string), string voucherCode = default(string), string merchantAccessMode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (merchantId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_id", merchantId));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (activityId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "activity_id", activityId));
            }
            if (voucherId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "voucher_id", voucherId));
            }
            if (voucherCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "voucher_code", voucherCode));
            }
            if (merchantAccessMode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "merchant_access_mode", merchantAccessMode));
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityUserApi.Queryvoucher";
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
            var localVarResponse = this.Client.Get<AlipayMarketingActivityUserQueryvoucherResponseModel>("/v3/alipay/marketing/activity/ordervoucher/user/voucher", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Queryvoucher", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingActivityUserQueryvoucherDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
