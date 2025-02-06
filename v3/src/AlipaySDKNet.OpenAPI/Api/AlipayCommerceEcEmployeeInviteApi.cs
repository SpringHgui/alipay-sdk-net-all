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
    public interface IAlipayCommerceEcEmployeeInviteApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 获取员工签约激活链接
        /// </summary>
        /// <remarks>
        /// 获取员工签约激活链接
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="employeeId">企业码员工ID，签约适用对象为指定员工时填写 (optional)</param>
        /// <param name="pageContentCode">用于展示不同的页面文案，使用标准页面文案是无需传值 (optional)</param>
        /// <param name="withholdingSignStr">代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。 (optional)</param>
        /// <param name="createShareCode">是否生成签约吱口令，不传默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceEcEmployeeInviteQueryResponseModel</returns>
        AlipayCommerceEcEmployeeInviteQueryResponseModel Query(string enterpriseId = default(string), string employeeId = default(string), string pageContentCode = default(string), string withholdingSignStr = default(string), string createShareCode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 获取员工签约激活链接
        /// </summary>
        /// <remarks>
        /// 获取员工签约激活链接
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="employeeId">企业码员工ID，签约适用对象为指定员工时填写 (optional)</param>
        /// <param name="pageContentCode">用于展示不同的页面文案，使用标准页面文案是无需传值 (optional)</param>
        /// <param name="withholdingSignStr">代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。 (optional)</param>
        /// <param name="createShareCode">是否生成签约吱口令，不传默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceEcEmployeeInviteQueryResponseModel</returns>
        ApiResponse<AlipayCommerceEcEmployeeInviteQueryResponseModel> QueryWithHttpInfo(string enterpriseId = default(string), string employeeId = default(string), string pageContentCode = default(string), string withholdingSignStr = default(string), string createShareCode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceEcEmployeeInviteApi : IAlipayCommerceEcEmployeeInviteApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayCommerceEcEmployeeInviteApi : IAlipayCommerceEcEmployeeInviteApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeInviteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceEcEmployeeInviteApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeInviteApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceEcEmployeeInviteApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeInviteApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayCommerceEcEmployeeInviteApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeInviteApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayCommerceEcEmployeeInviteApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 获取员工签约激活链接 获取员工签约激活链接
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="employeeId">企业码员工ID，签约适用对象为指定员工时填写 (optional)</param>
        /// <param name="pageContentCode">用于展示不同的页面文案，使用标准页面文案是无需传值 (optional)</param>
        /// <param name="withholdingSignStr">代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。 (optional)</param>
        /// <param name="createShareCode">是否生成签约吱口令，不传默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceEcEmployeeInviteQueryResponseModel</returns>
        public AlipayCommerceEcEmployeeInviteQueryResponseModel Query(string enterpriseId = default(string), string employeeId = default(string), string pageContentCode = default(string), string withholdingSignStr = default(string), string createShareCode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcEmployeeInviteQueryResponseModel> localVarResponse = QueryWithHttpInfo(enterpriseId, employeeId, pageContentCode, withholdingSignStr, createShareCode, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 获取员工签约激活链接 获取员工签约激活链接
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="employeeId">企业码员工ID，签约适用对象为指定员工时填写 (optional)</param>
        /// <param name="pageContentCode">用于展示不同的页面文案，使用标准页面文案是无需传值 (optional)</param>
        /// <param name="withholdingSignStr">代扣签约串。需要签约代扣协议时，必传，返回的签约链接会拼接上代扣签约串。 (optional)</param>
        /// <param name="createShareCode">是否生成签约吱口令，不传默认为N (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceEcEmployeeInviteQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcEmployeeInviteQueryResponseModel> QueryWithHttpInfo(string enterpriseId = default(string), string employeeId = default(string), string pageContentCode = default(string), string withholdingSignStr = default(string), string createShareCode = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (enterpriseId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "enterprise_id", enterpriseId));
            }
            if (employeeId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "employee_id", employeeId));
            }
            if (pageContentCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_content_code", pageContentCode));
            }
            if (withholdingSignStr != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "withholding_sign_str", withholdingSignStr));
            }
            if (createShareCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "create_share_code", createShareCode));
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcEmployeeInviteApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayCommerceEcEmployeeInviteQueryResponseModel>("/v3/alipay/commerce/ec/employee/invite", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayCommerceEcEmployeeInviteQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
