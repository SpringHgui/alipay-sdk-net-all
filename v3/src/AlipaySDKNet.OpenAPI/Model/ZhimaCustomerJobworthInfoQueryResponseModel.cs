/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// ZhimaCustomerJobworthInfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCustomerJobworthInfoQueryResponseModel")]
    public partial class ZhimaCustomerJobworthInfoQueryResponseModel : IEquatable<ZhimaCustomerJobworthInfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthInfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="acceptanceId">受理台单号作为jsapi的一个参数。如果不使用jsapi可以忽略.</param>
        /// <param name="authToken">用于授权校验,授权之前需要通过token校验.</param>
        /// <param name="htmlUrl">h5url.</param>
        /// <param name="pictureUrl">职得工作证图片url,可以直接用于展示.</param>
        /// <param name="sceneResult">场景授权结果.</param>
        /// <param name="subCode">业务编码.</param>
        /// <param name="subMsg">业务中文结果信息.</param>
        /// <param name="updateUrl">工作证图片更新的url,需要跳转到工作证小程序中进行更新.</param>
        /// <param name="url">职得工作证跳转小程序链接.</param>
        public ZhimaCustomerJobworthInfoQueryResponseModel(string acceptanceId = default(string), string authToken = default(string), string htmlUrl = default(string), string pictureUrl = default(string), bool sceneResult = default(bool), string subCode = default(string), string subMsg = default(string), string updateUrl = default(string), string url = default(string))
        {
            this.AcceptanceId = acceptanceId;
            this.AuthToken = authToken;
            this.HtmlUrl = htmlUrl;
            this.PictureUrl = pictureUrl;
            this.SceneResult = sceneResult;
            this.SubCode = subCode;
            this.SubMsg = subMsg;
            this.UpdateUrl = updateUrl;
            this.Url = url;
        }

        /// <summary>
        /// 受理台单号作为jsapi的一个参数。如果不使用jsapi可以忽略
        /// </summary>
        /// <value>受理台单号作为jsapi的一个参数。如果不使用jsapi可以忽略</value>
        [DataMember(Name = "acceptance_id", EmitDefaultValue = false)]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 用于授权校验,授权之前需要通过token校验
        /// </summary>
        /// <value>用于授权校验,授权之前需要通过token校验</value>
        [DataMember(Name = "auth_token", EmitDefaultValue = false)]
        public string AuthToken { get; set; }

        /// <summary>
        /// h5url
        /// </summary>
        /// <value>h5url</value>
        [DataMember(Name = "html_url", EmitDefaultValue = false)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// 职得工作证图片url,可以直接用于展示
        /// </summary>
        /// <value>职得工作证图片url,可以直接用于展示</value>
        [DataMember(Name = "picture_url", EmitDefaultValue = false)]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 场景授权结果
        /// </summary>
        /// <value>场景授权结果</value>
        [DataMember(Name = "scene_result", EmitDefaultValue = true)]
        public bool SceneResult { get; set; }

        /// <summary>
        /// 业务编码
        /// </summary>
        /// <value>业务编码</value>
        [DataMember(Name = "sub_code", EmitDefaultValue = false)]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        /// <value>业务中文结果信息</value>
        [DataMember(Name = "sub_msg", EmitDefaultValue = false)]
        public string SubMsg { get; set; }

        /// <summary>
        /// 工作证图片更新的url,需要跳转到工作证小程序中进行更新
        /// </summary>
        /// <value>工作证图片更新的url,需要跳转到工作证小程序中进行更新</value>
        [DataMember(Name = "update_url", EmitDefaultValue = false)]
        public string UpdateUrl { get; set; }

        /// <summary>
        /// 职得工作证跳转小程序链接
        /// </summary>
        /// <value>职得工作证跳转小程序链接</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCustomerJobworthInfoQueryResponseModel {\n");
            sb.Append("  AcceptanceId: ").Append(AcceptanceId).Append("\n");
            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
            sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
            sb.Append("  PictureUrl: ").Append(PictureUrl).Append("\n");
            sb.Append("  SceneResult: ").Append(SceneResult).Append("\n");
            sb.Append("  SubCode: ").Append(SubCode).Append("\n");
            sb.Append("  SubMsg: ").Append(SubMsg).Append("\n");
            sb.Append("  UpdateUrl: ").Append(UpdateUrl).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ZhimaCustomerJobworthInfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCustomerJobworthInfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCustomerJobworthInfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCustomerJobworthInfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptanceId == input.AcceptanceId ||
                    (this.AcceptanceId != null &&
                    this.AcceptanceId.Equals(input.AcceptanceId))
                ) && 
                (
                    this.AuthToken == input.AuthToken ||
                    (this.AuthToken != null &&
                    this.AuthToken.Equals(input.AuthToken))
                ) && 
                (
                    this.HtmlUrl == input.HtmlUrl ||
                    (this.HtmlUrl != null &&
                    this.HtmlUrl.Equals(input.HtmlUrl))
                ) && 
                (
                    this.PictureUrl == input.PictureUrl ||
                    (this.PictureUrl != null &&
                    this.PictureUrl.Equals(input.PictureUrl))
                ) && 
                (
                    this.SceneResult == input.SceneResult ||
                    this.SceneResult.Equals(input.SceneResult)
                ) && 
                (
                    this.SubCode == input.SubCode ||
                    (this.SubCode != null &&
                    this.SubCode.Equals(input.SubCode))
                ) && 
                (
                    this.SubMsg == input.SubMsg ||
                    (this.SubMsg != null &&
                    this.SubMsg.Equals(input.SubMsg))
                ) && 
                (
                    this.UpdateUrl == input.UpdateUrl ||
                    (this.UpdateUrl != null &&
                    this.UpdateUrl.Equals(input.UpdateUrl))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AcceptanceId != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptanceId.GetHashCode();
                }
                if (this.AuthToken != null)
                {
                    hashCode = (hashCode * 59) + this.AuthToken.GetHashCode();
                }
                if (this.HtmlUrl != null)
                {
                    hashCode = (hashCode * 59) + this.HtmlUrl.GetHashCode();
                }
                if (this.PictureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PictureUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SceneResult.GetHashCode();
                if (this.SubCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubCode.GetHashCode();
                }
                if (this.SubMsg != null)
                {
                    hashCode = (hashCode * 59) + this.SubMsg.GetHashCode();
                }
                if (this.UpdateUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateUrl.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
