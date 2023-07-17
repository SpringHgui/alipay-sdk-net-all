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
    public interface IAlipayCommerceEcDepartmentInfoApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 企业部门信息修改
        /// </summary>
        /// <remarks>
        /// 修改企业部门信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        Object Modify(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业部门信息修改
        /// </summary>
        /// <remarks>
        /// 修改企业部门信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> ModifyWithHttpInfo(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询部门详情
        /// </summary>
        /// <remarks>
        /// 根据部门id查询企业下某个部门的详细信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceEcDepartmentInfoQueryResponseModel</returns>
        AlipayCommerceEcDepartmentInfoQueryResponseModel Query(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询部门详情
        /// </summary>
        /// <remarks>
        /// 根据部门id查询企业下某个部门的详细信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceEcDepartmentInfoQueryResponseModel</returns>
        ApiResponse<AlipayCommerceEcDepartmentInfoQueryResponseModel> QueryWithHttpInfo(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceEcDepartmentInfoApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 企业部门信息修改
        /// </summary>
        /// <remarks>
        /// 修改企业部门信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> ModifyAsync(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 企业部门信息修改
        /// </summary>
        /// <remarks>
        /// 修改企业部门信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ModifyWithHttpInfoAsync(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询部门详情
        /// </summary>
        /// <remarks>
        /// 根据部门id查询企业下某个部门的详细信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceEcDepartmentInfoQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayCommerceEcDepartmentInfoQueryResponseModel> QueryAsync(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询部门详情
        /// </summary>
        /// <remarks>
        /// 根据部门id查询企业下某个部门的详细信息
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceEcDepartmentInfoQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayCommerceEcDepartmentInfoQueryResponseModel>> QueryWithHttpInfoAsync(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayCommerceEcDepartmentInfoApi : IAlipayCommerceEcDepartmentInfoApiSync, IAlipayCommerceEcDepartmentInfoApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayCommerceEcDepartmentInfoApi : IAlipayCommerceEcDepartmentInfoApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceEcDepartmentInfoApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentInfoApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayCommerceEcDepartmentInfoApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentInfoApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayCommerceEcDepartmentInfoApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentInfoApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayCommerceEcDepartmentInfoApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 企业部门信息修改 修改企业部门信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Object</returns>
        public Object Modify(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> localVarResponse = ModifyWithHttpInfo(alipayCommerceEcDepartmentInfoModifyModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业部门信息修改 修改企业部门信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of Object</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> ModifyWithHttpInfo(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayCommerceEcDepartmentInfoModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcDepartmentInfoApi.Modify";
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
            var localVarResponse = this.Client.Put<Object>("/v3/alipay/commerce/ec/department", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayCommerceEcDepartmentInfoModifyDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 企业部门信息修改 修改企业部门信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> ModifyAsync(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<Object> localVarResponse = await ModifyWithHttpInfoAsync(alipayCommerceEcDepartmentInfoModifyModel, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 企业部门信息修改 修改企业部门信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayCommerceEcDepartmentInfoModifyModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<Object>> ModifyWithHttpInfoAsync(AlipayCommerceEcDepartmentInfoModifyModel alipayCommerceEcDepartmentInfoModifyModel = default(AlipayCommerceEcDepartmentInfoModifyModel), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayCommerceEcDepartmentInfoModifyModel;
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcDepartmentInfoApi.Modify";
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
            var localVarResponse = await this.AsynchronousClient.PutAsync<Object>("/v3/alipay/commerce/ec/department", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Modify", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 查询部门详情 根据部门id查询企业下某个部门的详细信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayCommerceEcDepartmentInfoQueryResponseModel</returns>
        public AlipayCommerceEcDepartmentInfoQueryResponseModel Query(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcDepartmentInfoQueryResponseModel> localVarResponse = QueryWithHttpInfo(enterpriseId, departmentId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询部门详情 根据部门id查询企业下某个部门的详细信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayCommerceEcDepartmentInfoQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcDepartmentInfoQueryResponseModel> QueryWithHttpInfo(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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
            if (departmentId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "department_id", departmentId));
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcDepartmentInfoApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayCommerceEcDepartmentInfoQueryResponseModel>("/v3/alipay/commerce/ec/department/info/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayCommerceEcDepartmentInfoQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询部门详情 根据部门id查询企业下某个部门的详细信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayCommerceEcDepartmentInfoQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayCommerceEcDepartmentInfoQueryResponseModel> QueryAsync(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcDepartmentInfoQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(enterpriseId, departmentId, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询部门详情 根据部门id查询企业下某个部门的详细信息
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="enterpriseId">企业id (optional)</param>
        /// <param name="departmentId">部门id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayCommerceEcDepartmentInfoQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayCommerceEcDepartmentInfoQueryResponseModel>> QueryWithHttpInfoAsync(string enterpriseId = default(string), string departmentId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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
            if (departmentId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "department_id", departmentId));
            }

            localVarRequestOptions.Operation = "AlipayCommerceEcDepartmentInfoApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayCommerceEcDepartmentInfoQueryResponseModel>("/v3/alipay/commerce/ec/department/info/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
