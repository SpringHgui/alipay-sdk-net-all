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
    public interface IAlipayIserviceCcmInstanceApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 创建租户实例
        /// </summary>
        /// <remarks>
        /// 创建租户实例
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayIserviceCcmInstanceCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayIserviceCcmInstanceCreateResponseModel</returns>
        AlipayIserviceCcmInstanceCreateResponseModel Create(AlipayIserviceCcmInstanceCreateModel alipayIserviceCcmInstanceCreateModel = default(AlipayIserviceCcmInstanceCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 创建租户实例
        /// </summary>
        /// <remarks>
        /// 创建租户实例
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayIserviceCcmInstanceCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayIserviceCcmInstanceCreateResponseModel</returns>
        ApiResponse<AlipayIserviceCcmInstanceCreateResponseModel> CreateWithHttpInfo(AlipayIserviceCcmInstanceCreateModel alipayIserviceCcmInstanceCreateModel = default(AlipayIserviceCcmInstanceCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询单个租户实例（数据权限）
        /// </summary>
        /// <remarks>
        /// 查询单个租户实例（数据权限）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">部门id（即租户实例ID、数据权限ID） (optional)</param>
        /// <param name="externalId">外部id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayIserviceCcmInstanceGetResponseModel</returns>
        AlipayIserviceCcmInstanceGetResponseModel Get(string id = default(string), string externalId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询单个租户实例（数据权限）
        /// </summary>
        /// <remarks>
        /// 查询单个租户实例（数据权限）
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">部门id（即租户实例ID、数据权限ID） (optional)</param>
        /// <param name="externalId">外部id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayIserviceCcmInstanceGetResponseModel</returns>
        ApiResponse<AlipayIserviceCcmInstanceGetResponseModel> GetWithHttpInfo(string id = default(string), string externalId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 列出所有的租户实例（数据权限）
        /// </summary>
        /// <remarks>
        /// 列出所有的租户实例（数据权限）。一个云客服租户下可以有多个租户实例（数据权限），每个租户实例之间的数据是隔离的（除了用户、权限、私信、IVR数据外）。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNum">查询结果的页码，起始值为 1，默认值为 1 (optional)</param>
        /// <param name="pageSize">分页查询时设置的每页记录数，最大值 100 行，默认为 10 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayIserviceCcmInstanceQueryResponseModel</returns>
        AlipayIserviceCcmInstanceQueryResponseModel Query(int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 列出所有的租户实例（数据权限）
        /// </summary>
        /// <remarks>
        /// 列出所有的租户实例（数据权限）。一个云客服租户下可以有多个租户实例（数据权限），每个租户实例之间的数据是隔离的（除了用户、权限、私信、IVR数据外）。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNum">查询结果的页码，起始值为 1，默认值为 1 (optional)</param>
        /// <param name="pageSize">分页查询时设置的每页记录数，最大值 100 行，默认为 10 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayIserviceCcmInstanceQueryResponseModel</returns>
        ApiResponse<AlipayIserviceCcmInstanceQueryResponseModel> QueryWithHttpInfo(int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayIserviceCcmInstanceApi : IAlipayIserviceCcmInstanceApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayIserviceCcmInstanceApi : IAlipayIserviceCcmInstanceApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmInstanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayIserviceCcmInstanceApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmInstanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayIserviceCcmInstanceApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmInstanceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayIserviceCcmInstanceApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmInstanceApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayIserviceCcmInstanceApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 创建租户实例 创建租户实例
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayIserviceCcmInstanceCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayIserviceCcmInstanceCreateResponseModel</returns>
        public AlipayIserviceCcmInstanceCreateResponseModel Create(AlipayIserviceCcmInstanceCreateModel alipayIserviceCcmInstanceCreateModel = default(AlipayIserviceCcmInstanceCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayIserviceCcmInstanceCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayIserviceCcmInstanceCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 创建租户实例 创建租户实例
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayIserviceCcmInstanceCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayIserviceCcmInstanceCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayIserviceCcmInstanceCreateResponseModel> CreateWithHttpInfo(AlipayIserviceCcmInstanceCreateModel alipayIserviceCcmInstanceCreateModel = default(AlipayIserviceCcmInstanceCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayIserviceCcmInstanceCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayIserviceCcmInstanceApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayIserviceCcmInstanceCreateResponseModel>("/v3/alipay/iservice/ccm/instance/create", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayIserviceCcmInstanceCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询单个租户实例（数据权限） 查询单个租户实例（数据权限）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">部门id（即租户实例ID、数据权限ID） (optional)</param>
        /// <param name="externalId">外部id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayIserviceCcmInstanceGetResponseModel</returns>
        public AlipayIserviceCcmInstanceGetResponseModel Get(string id = default(string), string externalId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayIserviceCcmInstanceGetResponseModel> localVarResponse = GetWithHttpInfo(id, externalId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询单个租户实例（数据权限） 查询单个租户实例（数据权限）
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">部门id（即租户实例ID、数据权限ID） (optional)</param>
        /// <param name="externalId">外部id (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayIserviceCcmInstanceGetResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayIserviceCcmInstanceGetResponseModel> GetWithHttpInfo(string id = default(string), string externalId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (externalId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "external_id", externalId));
            }

            localVarRequestOptions.Operation = "AlipayIserviceCcmInstanceApi.Get";
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
            var localVarResponse = this.Client.Get<AlipayIserviceCcmInstanceGetResponseModel>("/v3/alipay/iservice/ccm/instance/get", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayIserviceCcmInstanceGetDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 列出所有的租户实例（数据权限） 列出所有的租户实例（数据权限）。一个云客服租户下可以有多个租户实例（数据权限），每个租户实例之间的数据是隔离的（除了用户、权限、私信、IVR数据外）。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNum">查询结果的页码，起始值为 1，默认值为 1 (optional)</param>
        /// <param name="pageSize">分页查询时设置的每页记录数，最大值 100 行，默认为 10 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayIserviceCcmInstanceQueryResponseModel</returns>
        public AlipayIserviceCcmInstanceQueryResponseModel Query(int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayIserviceCcmInstanceQueryResponseModel> localVarResponse = QueryWithHttpInfo(pageNum, pageSize, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 列出所有的租户实例（数据权限） 列出所有的租户实例（数据权限）。一个云客服租户下可以有多个租户实例（数据权限），每个租户实例之间的数据是隔离的（除了用户、权限、私信、IVR数据外）。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageNum">查询结果的页码，起始值为 1，默认值为 1 (optional)</param>
        /// <param name="pageSize">分页查询时设置的每页记录数，最大值 100 行，默认为 10 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayIserviceCcmInstanceQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayIserviceCcmInstanceQueryResponseModel> QueryWithHttpInfo(int? pageNum = default(int?), int? pageSize = default(int?), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (pageNum != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_num", pageNum));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }

            localVarRequestOptions.Operation = "AlipayIserviceCcmInstanceApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayIserviceCcmInstanceQueryResponseModel>("/v3/alipay/iservice/ccm/instance/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayIserviceCcmInstanceQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
