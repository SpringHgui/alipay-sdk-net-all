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
    public interface IAlipayEbppInvoiceExpenserulesProjectruleApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 创建项目费控规则
        /// </summary>
        /// <remarks>
        /// 创建项目费控规则
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpenserulesProjectruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel</returns>
        AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel Create(AlipayEbppInvoiceExpenserulesProjectruleCreateModel alipayEbppInvoiceExpenserulesProjectruleCreateModel = default(AlipayEbppInvoiceExpenserulesProjectruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 创建项目费控规则
        /// </summary>
        /// <remarks>
        /// 创建项目费控规则
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpenserulesProjectruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceExpenserulesProjectruleCreateModel alipayEbppInvoiceExpenserulesProjectruleCreateModel = default(AlipayEbppInvoiceExpenserulesProjectruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询项目费控规则
        /// </summary>
        /// <remarks>
        /// 查询项目费控规则
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">共同账号ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="projectId">项目id（可空） (optional)</param>
        /// <param name="employeeId">员工UID（可空） (optional)</param>
        /// <param name="employeeOpenId">切换open_id后请使用：员工open_id（可空） (optional)</param>
        /// <param name="pageNum">页数 (optional)</param>
        /// <param name="pageSize">页大小 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel</returns>
        AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel Query(string accountId = default(string), string agreementNo = default(string), string projectId = default(string), string employeeId = default(string), string employeeOpenId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询项目费控规则
        /// </summary>
        /// <remarks>
        /// 查询项目费控规则
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">共同账号ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="projectId">项目id（可空） (optional)</param>
        /// <param name="employeeId">员工UID（可空） (optional)</param>
        /// <param name="employeeOpenId">切换open_id后请使用：员工open_id（可空） (optional)</param>
        /// <param name="pageNum">页数 (optional)</param>
        /// <param name="pageSize">页大小 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel</returns>
        ApiResponse<AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel> QueryWithHttpInfo(string accountId = default(string), string agreementNo = default(string), string projectId = default(string), string employeeId = default(string), string employeeOpenId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayEbppInvoiceExpenserulesProjectruleApi : IAlipayEbppInvoiceExpenserulesProjectruleApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayEbppInvoiceExpenserulesProjectruleApi : IAlipayEbppInvoiceExpenserulesProjectruleApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesProjectruleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceExpenserulesProjectruleApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesProjectruleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayEbppInvoiceExpenserulesProjectruleApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesProjectruleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayEbppInvoiceExpenserulesProjectruleApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesProjectruleApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayEbppInvoiceExpenserulesProjectruleApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 创建项目费控规则 创建项目费控规则
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpenserulesProjectruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel</returns>
        public AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel Create(AlipayEbppInvoiceExpenserulesProjectruleCreateModel alipayEbppInvoiceExpenserulesProjectruleCreateModel = default(AlipayEbppInvoiceExpenserulesProjectruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayEbppInvoiceExpenserulesProjectruleCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 创建项目费控规则 创建项目费控规则
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayEbppInvoiceExpenserulesProjectruleCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel> CreateWithHttpInfo(AlipayEbppInvoiceExpenserulesProjectruleCreateModel alipayEbppInvoiceExpenserulesProjectruleCreateModel = default(AlipayEbppInvoiceExpenserulesProjectruleCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayEbppInvoiceExpenserulesProjectruleCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceExpenserulesProjectruleApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayEbppInvoiceExpenserulesProjectruleCreateResponseModel>("/v3/alipay/ebpp/invoice/expenserules/projectrule/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceExpenserulesProjectruleCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询项目费控规则 查询项目费控规则
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">共同账号ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="projectId">项目id（可空） (optional)</param>
        /// <param name="employeeId">员工UID（可空） (optional)</param>
        /// <param name="employeeOpenId">切换open_id后请使用：员工open_id（可空） (optional)</param>
        /// <param name="pageNum">页数 (optional)</param>
        /// <param name="pageSize">页大小 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel</returns>
        public AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel Query(string accountId = default(string), string agreementNo = default(string), string projectId = default(string), string employeeId = default(string), string employeeOpenId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel> localVarResponse = QueryWithHttpInfo(accountId, agreementNo, projectId, employeeId, employeeOpenId, pageNum, pageSize, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询项目费控规则 查询项目费控规则
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accountId">共同账号ID (optional)</param>
        /// <param name="agreementNo">授权签约协议号 (optional)</param>
        /// <param name="projectId">项目id（可空） (optional)</param>
        /// <param name="employeeId">员工UID（可空） (optional)</param>
        /// <param name="employeeOpenId">切换open_id后请使用：员工open_id（可空） (optional)</param>
        /// <param name="pageNum">页数 (optional)</param>
        /// <param name="pageSize">页大小 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel> QueryWithHttpInfo(string accountId = default(string), string agreementNo = default(string), string projectId = default(string), string employeeId = default(string), string employeeOpenId = default(string), int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (accountId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "account_id", accountId));
            }
            if (agreementNo != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "agreement_no", agreementNo));
            }
            if (projectId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "project_id", projectId));
            }
            if (employeeId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "employee_id", employeeId));
            }
            if (employeeOpenId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "employee_open_id", employeeOpenId));
            }
            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "AlipayEbppInvoiceExpenserulesProjectruleApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayEbppInvoiceExpenserulesProjectruleQueryResponseModel>("/v3/alipay/ebpp/invoice/expenserules/projectrule/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayEbppInvoiceExpenserulesProjectruleQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
