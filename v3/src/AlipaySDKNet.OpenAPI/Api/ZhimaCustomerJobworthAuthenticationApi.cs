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
    public interface IZhimaCustomerJobworthAuthenticationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 职得身份认证查询接口
        /// </summary>
        /// <remarks>
        /// 根据一次性token查询用户身份认证结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connKey">调用第一步创建接口的out_agreement_no，由外部传入 (optional)</param>
        /// <param name="onceToken">查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台 (optional)</param>
        /// <param name="queryType">exact:精确查询,dim:模糊查询 (optional)</param>
        /// <param name="identityType">04:教师，其它身份类型联系芝麻技术支持确认 (optional)</param>
        /// <param name="serviceId">信用服务id，商家接入产品功能包时有运营同学分配 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="certNo">证件号 (optional)</param>
        /// <param name="certType">\&quot;身份证 : 0\&quot;，\&quot;护照: 1\&quot;，\&quot;台湾往来通行证：4\&quot;,\&quot;港澳往来通行证：3\&quot;, \&quot;回乡证: 2\&quot;；\&quot;港澳证件：5\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCustomerJobworthAuthenticationQueryResponseModel</returns>
        ZhimaCustomerJobworthAuthenticationQueryResponseModel Query(string connKey = default(string), string onceToken = default(string), string queryType = default(string), string identityType = default(string), string serviceId = default(string), string userId = default(string), string openId = default(string), string certNo = default(string), string certType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 职得身份认证查询接口
        /// </summary>
        /// <remarks>
        /// 根据一次性token查询用户身份认证结果
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connKey">调用第一步创建接口的out_agreement_no，由外部传入 (optional)</param>
        /// <param name="onceToken">查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台 (optional)</param>
        /// <param name="queryType">exact:精确查询,dim:模糊查询 (optional)</param>
        /// <param name="identityType">04:教师，其它身份类型联系芝麻技术支持确认 (optional)</param>
        /// <param name="serviceId">信用服务id，商家接入产品功能包时有运营同学分配 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="certNo">证件号 (optional)</param>
        /// <param name="certType">\&quot;身份证 : 0\&quot;，\&quot;护照: 1\&quot;，\&quot;台湾往来通行证：4\&quot;,\&quot;港澳往来通行证：3\&quot;, \&quot;回乡证: 2\&quot;；\&quot;港澳证件：5\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCustomerJobworthAuthenticationQueryResponseModel</returns>
        ApiResponse<ZhimaCustomerJobworthAuthenticationQueryResponseModel> QueryWithHttpInfo(string connKey = default(string), string onceToken = default(string), string queryType = default(string), string identityType = default(string), string serviceId = default(string), string userId = default(string), string openId = default(string), string certNo = default(string), string certType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IZhimaCustomerJobworthAuthenticationApi : IZhimaCustomerJobworthAuthenticationApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ZhimaCustomerJobworthAuthenticationApi : IZhimaCustomerJobworthAuthenticationApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCustomerJobworthAuthenticationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ZhimaCustomerJobworthAuthenticationApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ZhimaCustomerJobworthAuthenticationApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthAuthenticationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ZhimaCustomerJobworthAuthenticationApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 职得身份认证查询接口 根据一次性token查询用户身份认证结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connKey">调用第一步创建接口的out_agreement_no，由外部传入 (optional)</param>
        /// <param name="onceToken">查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台 (optional)</param>
        /// <param name="queryType">exact:精确查询,dim:模糊查询 (optional)</param>
        /// <param name="identityType">04:教师，其它身份类型联系芝麻技术支持确认 (optional)</param>
        /// <param name="serviceId">信用服务id，商家接入产品功能包时有运营同学分配 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="certNo">证件号 (optional)</param>
        /// <param name="certType">\&quot;身份证 : 0\&quot;，\&quot;护照: 1\&quot;，\&quot;台湾往来通行证：4\&quot;,\&quot;港澳往来通行证：3\&quot;, \&quot;回乡证: 2\&quot;；\&quot;港澳证件：5\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ZhimaCustomerJobworthAuthenticationQueryResponseModel</returns>
        public ZhimaCustomerJobworthAuthenticationQueryResponseModel Query(string connKey = default(string), string onceToken = default(string), string queryType = default(string), string identityType = default(string), string serviceId = default(string), string userId = default(string), string openId = default(string), string certNo = default(string), string certType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCustomerJobworthAuthenticationQueryResponseModel> localVarResponse = QueryWithHttpInfo(connKey, onceToken, queryType, identityType, serviceId, userId, openId, certNo, certType, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 职得身份认证查询接口 根据一次性token查询用户身份认证结果
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="connKey">调用第一步创建接口的out_agreement_no，由外部传入 (optional)</param>
        /// <param name="onceToken">查询身份认证结果的凭证，在认证结果到达终态后只允许查询成功一次，若需要再次查询，则需要调用第一个接口再拉起受理台 (optional)</param>
        /// <param name="queryType">exact:精确查询,dim:模糊查询 (optional)</param>
        /// <param name="identityType">04:教师，其它身份类型联系芝麻技术支持确认 (optional)</param>
        /// <param name="serviceId">信用服务id，商家接入产品功能包时有运营同学分配 (optional)</param>
        /// <param name="userId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="openId">蚂蚁统一会员ID 和身份证任选一个传入 (optional)</param>
        /// <param name="certNo">证件号 (optional)</param>
        /// <param name="certType">\&quot;身份证 : 0\&quot;，\&quot;护照: 1\&quot;，\&quot;台湾往来通行证：4\&quot;,\&quot;港澳往来通行证：3\&quot;, \&quot;回乡证: 2\&quot;；\&quot;港澳证件：5\&quot; (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of ZhimaCustomerJobworthAuthenticationQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<ZhimaCustomerJobworthAuthenticationQueryResponseModel> QueryWithHttpInfo(string connKey = default(string), string onceToken = default(string), string queryType = default(string), string identityType = default(string), string serviceId = default(string), string userId = default(string), string openId = default(string), string certNo = default(string), string certType = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (connKey != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "conn_key", connKey));
            }
            if (onceToken != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "once_token", onceToken));
            }
            if (queryType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "query_type", queryType));
            }
            if (identityType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "identity_type", identityType));
            }
            if (serviceId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "service_id", serviceId));
            }
            if (userId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "user_id", userId));
            }
            if (openId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "open_id", openId));
            }
            if (certNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "cert_no", certNo));
            }
            if (certType != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "cert_type", certType));
            }

            localVarRequestOptions.Operation = "ZhimaCustomerJobworthAuthenticationApi.Query";
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
            var localVarResponse = this.Client.Get<ZhimaCustomerJobworthAuthenticationQueryResponseModel>("/v3/zhima/customer/jobworth/authentication", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = ZhimaCustomerJobworthAuthenticationQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
