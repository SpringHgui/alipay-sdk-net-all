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
    public interface IAlipayMarketingActivityDeliveryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 创建推广计划
        /// </summary>
        /// <remarks>
        /// 为商家提供推广内容能力。创建推广成功后，请依据推广变更消息alipay.marketing.activity.delivery.message感知推广变更状态。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingActivityDeliveryCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityDeliveryCreateResponseModel</returns>
        AlipayMarketingActivityDeliveryCreateResponseModel Create(AlipayMarketingActivityDeliveryCreateModel alipayMarketingActivityDeliveryCreateModel = default(AlipayMarketingActivityDeliveryCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 创建推广计划
        /// </summary>
        /// <remarks>
        /// 为商家提供推广内容能力。创建推广成功后，请依据推广变更消息alipay.marketing.activity.delivery.message感知推广变更状态。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingActivityDeliveryCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityDeliveryCreateResponseModel</returns>
        ApiResponse<AlipayMarketingActivityDeliveryCreateResponseModel> CreateWithHttpInfo(AlipayMarketingActivityDeliveryCreateModel alipayMarketingActivityDeliveryCreateModel = default(AlipayMarketingActivityDeliveryCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 查询推广计划
        /// </summary>
        /// <remarks>
        /// 查询推广计划详情信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityDeliveryQueryResponseModel</returns>
        AlipayMarketingActivityDeliveryQueryResponseModel Query(string deliveryId, AlipayMarketingActivityDeliveryQueryModel alipayMarketingActivityDeliveryQueryModel = default(AlipayMarketingActivityDeliveryQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 查询推广计划
        /// </summary>
        /// <remarks>
        /// 查询推广计划详情信息。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityDeliveryQueryResponseModel</returns>
        ApiResponse<AlipayMarketingActivityDeliveryQueryResponseModel> QueryWithHttpInfo(string deliveryId, AlipayMarketingActivityDeliveryQueryModel alipayMarketingActivityDeliveryQueryModel = default(AlipayMarketingActivityDeliveryQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        /// <summary>
        /// 停止推广计划
        /// </summary>
        /// <remarks>
        /// 停止推广计划。  注意：停止推广操作成功到推广内容停止生效，可能存在几分钟的延迟。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryStopModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityDeliveryStopResponseModel</returns>
        AlipayMarketingActivityDeliveryStopResponseModel Stop(string deliveryId, AlipayMarketingActivityDeliveryStopModel alipayMarketingActivityDeliveryStopModel = default(AlipayMarketingActivityDeliveryStopModel), int operationIndex = 0, CustomizedParams customizedParams = null);

        /// <summary>
        /// 停止推广计划
        /// </summary>
        /// <remarks>
        /// 停止推广计划。  注意：停止推广操作成功到推广内容停止生效，可能存在几分钟的延迟。
        /// </remarks>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryStopModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityDeliveryStopResponseModel</returns>
        ApiResponse<AlipayMarketingActivityDeliveryStopResponseModel> StopWithHttpInfo(string deliveryId, AlipayMarketingActivityDeliveryStopModel alipayMarketingActivityDeliveryStopModel = default(AlipayMarketingActivityDeliveryStopModel), int operationIndex = 0, CustomizedParams customizedParams = null);
        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAlipayMarketingActivityDeliveryApi : IAlipayMarketingActivityDeliveryApiSync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AlipayMarketingActivityDeliveryApi : IAlipayMarketingActivityDeliveryApi
    {
        private AlipaySDKNet.OpenAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingActivityDeliveryApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AlipayMarketingActivityDeliveryApi(string basePath)
        {
            this.Configuration = AlipaySDKNet.OpenAPI.Client.Configuration.MergeConfigurations(
                AlipaySDKNet.OpenAPI.Client.GlobalConfiguration.Instance,
                new AlipaySDKNet.OpenAPI.Client.Configuration { BasePath = basePath }
            );
            this.Client = new AlipaySDKNet.OpenAPI.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = AlipaySDKNet.OpenAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AlipayMarketingActivityDeliveryApi(AlipaySDKNet.OpenAPI.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AlipayMarketingActivityDeliveryApi(AlipaySDKNet.OpenAPI.Client.ISynchronousClient client, AlipaySDKNet.OpenAPI.Client.IReadableConfiguration configuration)
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
        /// 创建推广计划 为商家提供推广内容能力。创建推广成功后，请依据推广变更消息alipay.marketing.activity.delivery.message感知推广变更状态。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingActivityDeliveryCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityDeliveryCreateResponseModel</returns>
        public AlipayMarketingActivityDeliveryCreateResponseModel Create(AlipayMarketingActivityDeliveryCreateModel alipayMarketingActivityDeliveryCreateModel = default(AlipayMarketingActivityDeliveryCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityDeliveryCreateResponseModel> localVarResponse = CreateWithHttpInfo(alipayMarketingActivityDeliveryCreateModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 创建推广计划 为商家提供推广内容能力。创建推广成功后，请依据推广变更消息alipay.marketing.activity.delivery.message感知推广变更状态。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="alipayMarketingActivityDeliveryCreateModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityDeliveryCreateResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityDeliveryCreateResponseModel> CreateWithHttpInfo(AlipayMarketingActivityDeliveryCreateModel alipayMarketingActivityDeliveryCreateModel = default(AlipayMarketingActivityDeliveryCreateModel), int operationIndex = 0, CustomizedParams customizedParams = null)
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
                localVarRequestOptions.Data = alipayMarketingActivityDeliveryCreateModel;
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityDeliveryApi.Create";
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
            var localVarResponse = this.Client.Post<AlipayMarketingActivityDeliveryCreateResponseModel>("/v3/alipay/marketing/delivery", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingActivityDeliveryCreateDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 查询推广计划 查询推广计划详情信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityDeliveryQueryResponseModel</returns>
        public AlipayMarketingActivityDeliveryQueryResponseModel Query(string deliveryId, AlipayMarketingActivityDeliveryQueryModel alipayMarketingActivityDeliveryQueryModel = default(AlipayMarketingActivityDeliveryQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityDeliveryQueryResponseModel> localVarResponse = QueryWithHttpInfo(deliveryId, alipayMarketingActivityDeliveryQueryModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 查询推广计划 查询推广计划详情信息。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryQueryModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityDeliveryQueryResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityDeliveryQueryResponseModel> QueryWithHttpInfo(string deliveryId, AlipayMarketingActivityDeliveryQueryModel alipayMarketingActivityDeliveryQueryModel = default(AlipayMarketingActivityDeliveryQueryModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            // verify the required path parameter 'deliveryId' is set
            if (deliveryId == null)
            {
                throw new AlipaySDKNet.OpenAPI.Client.ApiException(400, "Missing required parameter 'deliveryId' when calling AlipayMarketingActivityDeliveryApi->Query");
            }

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

            if (deliveryId != null)
            {
                localVarRequestOptions.PathParameters.Add("delivery_id", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(deliveryId)); // path parameter
            }
            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayMarketingActivityDeliveryQueryModel;
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityDeliveryApi.Query";
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
            var localVarResponse = this.Client.Post<AlipayMarketingActivityDeliveryQueryResponseModel>("/v3/alipay/marketing/delivery/{delivery_id}/query", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Query", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingActivityDeliveryQueryDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
        /// 停止推广计划 停止推广计划。  注意：停止推广操作成功到推广内容停止生效，可能存在几分钟的延迟。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryStopModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>AlipayMarketingActivityDeliveryStopResponseModel</returns>
        public AlipayMarketingActivityDeliveryStopResponseModel Stop(string deliveryId, AlipayMarketingActivityDeliveryStopModel alipayMarketingActivityDeliveryStopModel = default(AlipayMarketingActivityDeliveryStopModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityDeliveryStopResponseModel> localVarResponse = StopWithHttpInfo(deliveryId, alipayMarketingActivityDeliveryStopModel, operationIndex, customizedParams);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 停止推广计划 停止推广计划。  注意：停止推广操作成功到推广内容停止生效，可能存在几分钟的延迟。
        /// </summary>
        /// <exception cref="AlipaySDKNet.OpenAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="deliveryId">推广计划id</param>
        /// <param name="alipayMarketingActivityDeliveryStopModel"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="customizedParams">customizedParams</param>
        /// <returns>ApiResponse of AlipayMarketingActivityDeliveryStopResponseModel</returns>
        public AlipaySDKNet.OpenAPI.Client.ApiResponse<AlipayMarketingActivityDeliveryStopResponseModel> StopWithHttpInfo(string deliveryId, AlipayMarketingActivityDeliveryStopModel alipayMarketingActivityDeliveryStopModel = default(AlipayMarketingActivityDeliveryStopModel), int operationIndex = 0, CustomizedParams customizedParams = null)
        {
            // verify the required path parameter 'deliveryId' is set
            if (deliveryId == null)
            {
                throw new AlipaySDKNet.OpenAPI.Client.ApiException(400, "Missing required parameter 'deliveryId' when calling AlipayMarketingActivityDeliveryApi->Stop");
            }

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

            if (deliveryId != null)
            {
                localVarRequestOptions.PathParameters.Add("delivery_id", AlipaySDKNet.OpenAPI.Client.ClientUtils.ParameterToString(deliveryId)); // path parameter
            }
            //自定义body内容
            if (customizedParams != null && !string.IsNullOrEmpty(customizedParams.BodyContent))
            {
                localVarRequestOptions.Data = customizedParams.BodyContent;
            }
            else
            {
                localVarRequestOptions.Data = alipayMarketingActivityDeliveryStopModel;
            }

            localVarRequestOptions.Operation = "AlipayMarketingActivityDeliveryApi.Stop";
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
            var localVarResponse = this.Client.Patch<AlipayMarketingActivityDeliveryStopResponseModel>("/v3/alipay/marketing/delivery/{delivery_id}/stop", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Stop", localVarResponse);
                if (_exception != null)
                {
                    if (_exception is ApiException exception && exception.ErrorContent != null)
                    {
                        try
                        {
                            exception.ErrorObject = AlipayMarketingActivityDeliveryStopDefaultResponse.FromJson(exception.ErrorContent.ToString());
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
