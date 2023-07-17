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
    public interface IAlipayFundJointaccountListApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 企业查询代付账户列表
        /// </summary>
        /// <remarks>
        /// 企业查询代付账户列表
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountListQueryResponseModel</returns>
        AlipayFundJointaccountListQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业查询代付账户列表
        /// </summary>
        /// <remarks>
        /// 企业查询代付账户列表
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountListQueryResponseModel</returns>
        ApiResponse<AlipayFundJointaccountListQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundJointaccountListApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 企业查询代付账户列表
        /// </summary>
        /// <remarks>
        /// 企业查询代付账户列表
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayFundJointaccountListQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayFundJointaccountListQueryResponseModel> QueryAsync(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业查询代付账户列表
        /// </summary>
        /// <remarks>
        /// 企业查询代付账户列表
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayFundJointaccountListQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayFundJointaccountListQueryResponseModel>> QueryWithHttpInfoAsync(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayFundJointaccountListApi : IAlipayFundJointaccountListApiSync, IAlipayFundJointaccountListApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayFundJointaccountListApi : IAlipayFundJointaccountListApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountListApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountListApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountListApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayFundJointaccountListApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountListApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayFundJointaccountListApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountListApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayFundJointaccountListApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 企业查询代付账户列表 企业查询代付账户列表
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayFundJointaccountListQueryResponseModel</returns>
        public AlipayFundJointaccountListQueryResponseModel Query(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountListQueryResponseModel> localVarResponse = QueryWithHttpInfo(productCode, bizScene, operateRole, agreementNo, identity, identityType, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业查询代付账户列表 企业查询代付账户列表
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayFundJointaccountListQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountListQueryResponseModel> QueryWithHttpInfo(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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
            if (operateRole != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "operate_role", operateRole));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (identity != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "identity", identity));
            }
            if (identityType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "identity_type", identityType));
            }

            localVarRequestOptions.Operation = "AlipayFundJointaccountListApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayFundJointaccountListQueryResponseModel>("/v3/alipay/fund/jointaccount/list/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayFundJointaccountListQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 企业查询代付账户列表 企业查询代付账户列表
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayFundJointaccountListQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayFundJointaccountListQueryResponseModel> QueryAsync(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountListQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(productCode, bizScene, operateRole, agreementNo, identity, identityType, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业查询代付账户列表 企业查询代付账户列表
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productCode">产品码 (optional)</param>
        /// <param name="bizScene">业务场景 (optional)</param>
        /// <param name="operateRole">角色：创建方(CREATOR)、参与方(PARTICIPANT) (optional)</param>
        /// <param name="agreementNo">授权协议号 (optional)</param>
        /// <param name="identity">员工账号：  identity_type是ALIPAY_USER_ID填支付宝会员ID（2088开头）；  是ALIPAY_LOGON_ID 填支付宝登录号 (optional)</param>
        /// <param name="identityType">账号类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayFundJointaccountListQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayFundJointaccountListQueryResponseModel>> QueryWithHttpInfoAsync(string productCode = default(string), string bizScene = default(string), string operateRole = default(string), string agreementNo = default(string), string identity = default(string), string identityType = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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
            if (operateRole != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "operate_role", operateRole));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (identity != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "identity", identity));
            }
            if (identityType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "identity_type", identityType));
            }

            localVarRequestOptions.Operation = "AlipayFundJointaccountListApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayFundJointaccountListQueryResponseModel>("/v3/alipay/fund/jointaccount/list/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
