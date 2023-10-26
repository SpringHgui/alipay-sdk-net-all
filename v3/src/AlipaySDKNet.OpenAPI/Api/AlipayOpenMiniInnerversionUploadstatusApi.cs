/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    public interface IAlipayOpenMiniInnerversionUploadstatusApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 多端小程序-查询构建状态
        /// </summary>
        /// <remarks>
        /// 查询构建状态
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayOpenMiniInnerversionUploadstatusQueryResponseModel</returns>
        AlipayOpenMiniInnerversionUploadstatusQueryResponseModel Query(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 多端小程序-查询构建状态
        /// </summary>
        /// <remarks>
        /// 查询构建状态
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayOpenMiniInnerversionUploadstatusQueryResponseModel</returns>
        ApiResponse<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel> QueryWithHttpInfo(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenMiniInnerversionUploadstatusApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 多端小程序-查询构建状态
        /// </summary>
        /// <remarks>
        /// 查询构建状态
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayOpenMiniInnerversionUploadstatusQueryResponseModel</returns>
        System.Threading.Tasks.Task<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel> QueryAsync(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);

        /// <summary>
        /// 多端小程序-查询构建状态
        /// </summary>
        /// <remarks>
        /// 查询构建状态
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayOpenMiniInnerversionUploadstatusQueryResponseModel)</returns>
        System.Threading.Tasks.Task<ApiResponse<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel>> QueryWithHttpInfoAsync(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayOpenMiniInnerversionUploadstatusApi : IAlipayOpenMiniInnerversionUploadstatusApiSync, IAlipayOpenMiniInnerversionUploadstatusApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayOpenMiniInnerversionUploadstatusApi : IAlipayOpenMiniInnerversionUploadstatusApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenMiniInnerversionUploadstatusApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayOpenMiniInnerversionUploadstatusApi(string basePath)
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
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayOpenMiniInnerversionUploadstatusApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayOpenMiniInnerversionUploadstatusApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IAsynchronousClient asyncClient, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 多端小程序-查询构建状态 查询构建状态
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayOpenMiniInnerversionUploadstatusQueryResponseModel</returns>
        public AlipayOpenMiniInnerversionUploadstatusQueryResponseModel Query(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel> localVarResponse = QueryWithHttpInfo(buildPackageId, miniAppId, buildVersion, instCode, bundleId, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 多端小程序-查询构建状态 查询构建状态
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayOpenMiniInnerversionUploadstatusQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel> QueryWithHttpInfo(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, CustomizedParams customizedParams = null)
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

            if (buildPackageId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "build_package_id", buildPackageId));
            }
            if (miniAppId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "mini_app_id", miniAppId));
            }
            if (buildVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "build_version", buildVersion));
            }
            if (instCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "inst_code", instCode));
            }
            if (bundleId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "bundle_id", bundleId));
            }

            localVarRequestOptions.Operation = "AlipayOpenMiniInnerversionUploadstatusApi.Query";
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
            var localVarResponse = this.Client.Get<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel>("/v3/alipay/open/mini/innerversion/uploadstatus/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 多端小程序-查询构建状态 查询构建状态
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of AlipayOpenMiniInnerversionUploadstatusQueryResponseModel</returns>
        public async System.Threading.Tasks.Task<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel> QueryAsync(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel> localVarResponse = await QueryWithHttpInfoAsync(buildPackageId, miniAppId, buildVersion, instCode, bundleId, operationIndex, cancellationToken, customizedParams).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 多端小程序-查询构建状态 查询构建状态
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="buildPackageId">包管理ID，用于查询打包状态 (optional)</param>
        /// <param name="miniAppId">小程序ID (optional)</param>
        /// <param name="buildVersion">小程序版本 (optional)</param>
        /// <param name="instCode">租户id (optional)</param>
        /// <param name="bundleId">端信息 (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>Task of ApiResponse (AlipayOpenMiniInnerversionUploadstatusQueryResponseModel)</returns>
        public async System.Threading.Tasks.Task<AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel>> QueryWithHttpInfoAsync(string buildPackageId = default(string), string miniAppId = default(string), string buildVersion = default(string), string instCode = default(string), string bundleId = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), CustomizedParams customizedParams = null)
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

            if (buildPackageId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "build_package_id", buildPackageId));
            }
            if (miniAppId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "mini_app_id", miniAppId));
            }
            if (buildVersion != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "build_version", buildVersion));
            }
            if (instCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "inst_code", instCode));
            }
            if (bundleId != null)
            {
                localVarRequestOptions.QueryParameters.Add(AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToMultiMap("", "bundle_id", bundleId));
            }

            localVarRequestOptions.Operation = "AlipayOpenMiniInnerversionUploadstatusApi.Query";
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
            var localVarResponse = await this.AsynchronousClient.GetAsync<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel>("/v3/alipay/open/mini/innerversion/uploadstatus/query", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

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
