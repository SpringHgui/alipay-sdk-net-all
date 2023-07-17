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
    public interface IAlipayFundJointaccountDetailApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 共享资金-查询账户详情
        /// </summary>
        /// <remarks>
        /// 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountDetailQueryResponseModel</returns>
        AlipayFundJointaccountDetailQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 共享资金-查询账户详情
        /// </summary>
        /// <remarks>
        /// 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountDetailQueryResponseModel</returns>
        ApiResponse<AlipayFundJointaccountDetailQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundJointaccountDetailApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 共享资金-查询账户详情
        /// </summary>
        /// <remarks>
        /// 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayFundJointaccountDetailQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayFundJointaccountDetailQueryResponseModel> QueryAsync(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 共享资金-查询账户详情
        /// </summary>
        /// <remarks>
        /// 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayFundJointaccountDetailQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayFundJointaccountDetailQueryResponseModel>> QueryWithHttpInfoAsync(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundJointaccountDetailApi : IAlipayFundJointaccountDetailApiSync, IAlipayFundJointaccountDetailApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundJointaccountDetailApi : IAlipayFundJointaccountDetailApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountDetailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountDetailApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountDetailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountDetailApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountDetailApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundJointaccountDetailApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountDetailApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundJointaccountDetailApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 共享资金-查询账户详情 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountDetailQueryResponseModel</returns>
        public AlipayFundJointaccountDetailQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountDetailQueryResponseModel> localVarResponse = QueryWithHttpInfo(productCode, bizScene, accountId, agreementNo, outBizNo, channel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 共享资金-查询账户详情 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountDetailQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountDetailQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (productCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "product_code", productCode));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }
            if (channel != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "channel", channel));
            }

            localVarRequestOptions.Operation = "AlipayFundJointaccountDetailApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundJointaccountDetailQueryResponseModel>("/v3/alipay/fund/jointaccount/detail/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundJointaccountDetailQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 共享资金-查询账户详情 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayFundJointaccountDetailQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayFundJointaccountDetailQueryResponseModel> QueryAsync(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountDetailQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(productCode, bizScene, accountId, agreementNo, outBizNo, channel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 共享资金-查询账户详情 发起人在商户上点击查看账户详情，商户服务端进行受理，并调用支付宝进行处理。处理结果，同步返回给商户。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">销售产品码 (optional)</param>
        /// <param name="bizScene">业务场景码 (optional)</param>
        /// <param name="accountId">合花群ID（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="agreementNo">授权协议号（查询方式二：通过传入account_id+agreement_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段可在签约接口alipay.fund.jointaccount.sign调用后，由账户变更结果通知接口alipay.fund.jointaccount.account.completed中返回。&lt;br&gt; -该字段可在签约接口调用后，由查询账户详情接口alipay.fund.jointaccount.detail.query中返回。 (optional)</param>
        /// <param name="outBizNo">商户侧单号（查询方式一：通过传入 out_biz_no查询）&lt;br&gt; 补充说明：&lt;br&gt; -该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致 (optional)</param>
        /// <param name="channel">业务渠道&lt;/br&gt; 补充说明：&lt;/br&gt; 需要商户侧必传，支付宝侧不做强校验 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayFundJointaccountDetailQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountDetailQueryResponseModel>> QueryWithHttpInfoAsync(string productCode = default(string), string bizScene = default(string), string accountId = default(string), string agreementNo = default(string), string outBizNo = default(string), string channel = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (productCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "product_code", productCode));
            }
            if (bizScene != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "biz_scene", bizScene));
            }
            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (outBizNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "out_biz_no", outBizNo));
            }
            if (channel != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "channel", channel));
            }

            localVarRequestOptions.Operation = "AlipayFundJointaccountDetailApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayFundJointaccountDetailQueryResponseModel>("/v3/alipay/fund/jointaccount/detail/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
