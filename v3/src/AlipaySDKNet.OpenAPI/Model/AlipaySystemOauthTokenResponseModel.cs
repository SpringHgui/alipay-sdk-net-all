/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
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
    /// AlipaySystemOauthTokenResponseModel
    /// </summary>
    [DataContract(Name = "AlipaySystemOauthTokenResponseModel")]
    public partial class AlipaySystemOauthTokenResponseModel : IEquatable<AlipaySystemOauthTokenResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySystemOauthTokenResponseModel" /> class.
        /// </summary>
        /// <param name="accessToken">访问令牌。通过该令牌调用需要授权类接口.</param>
        /// <param name="alipayUserId">已废弃，请勿使用.</param>
        /// <param name="authStart">授权token开始时间，作为有效期计算的起点.</param>
        /// <param name="authTokenType">令牌类型，permanent表示返回的access_token和refresh_token永久有效，非永久令牌不返回该字段.</param>
        /// <param name="expiresIn">访问令牌的有效时间，单位是秒。.</param>
        /// <param name="openId">支付宝用户唯一标识.</param>
        /// <param name="reExpiresIn">刷新令牌的有效时间，单位是秒。.</param>
        /// <param name="refreshToken">刷新令牌。通过该令牌可以刷新access_token.</param>
        /// <param name="unionId">union_id是支付宝用户在开放平台的唯一标识符，在配置应用分组后会返回该值。 同一用户的union_id在同一分组内应用保持一致。.</param>
        /// <param name="userId">支付宝用户的唯一标识。以2088开头的16位数字。.</param>
        public AlipaySystemOauthTokenResponseModel(string accessToken = default(string), string alipayUserId = default(string), string authStart = default(string), string authTokenType = default(string), string expiresIn = default(string), string openId = default(string), string reExpiresIn = default(string), string refreshToken = default(string), string unionId = default(string), string userId = default(string))
        {
            this.AccessToken = accessToken;
            this.AlipayUserId = alipayUserId;
            this.AuthStart = authStart;
            this.AuthTokenType = authTokenType;
            this.ExpiresIn = expiresIn;
            this.OpenId = openId;
            this.ReExpiresIn = reExpiresIn;
            this.RefreshToken = refreshToken;
            this.UnionId = unionId;
            this.UserId = userId;
        }

        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        /// <value>访问令牌。通过该令牌调用需要授权类接口</value>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 已废弃，请勿使用
        /// </summary>
        /// <value>已废弃，请勿使用</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 授权token开始时间，作为有效期计算的起点
        /// </summary>
        /// <value>授权token开始时间，作为有效期计算的起点</value>
        [DataMember(Name = "auth_start", EmitDefaultValue = false)]
        public string AuthStart { get; set; }

        /// <summary>
        /// 令牌类型，permanent表示返回的access_token和refresh_token永久有效，非永久令牌不返回该字段
        /// </summary>
        /// <value>令牌类型，permanent表示返回的access_token和refresh_token永久有效，非永久令牌不返回该字段</value>
        [DataMember(Name = "auth_token_type", EmitDefaultValue = false)]
        public string AuthTokenType { get; set; }

        /// <summary>
        /// 访问令牌的有效时间，单位是秒。
        /// </summary>
        /// <value>访问令牌的有效时间，单位是秒。</value>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 支付宝用户唯一标识
        /// </summary>
        /// <value>支付宝用户唯一标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 刷新令牌的有效时间，单位是秒。
        /// </summary>
        /// <value>刷新令牌的有效时间，单位是秒。</value>
        [DataMember(Name = "re_expires_in", EmitDefaultValue = false)]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌。通过该令牌可以刷新access_token
        /// </summary>
        /// <value>刷新令牌。通过该令牌可以刷新access_token</value>
        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// union_id是支付宝用户在开放平台的唯一标识符，在配置应用分组后会返回该值。 同一用户的union_id在同一分组内应用保持一致。
        /// </summary>
        /// <value>union_id是支付宝用户在开放平台的唯一标识符，在配置应用分组后会返回该值。 同一用户的union_id在同一分组内应用保持一致。</value>
        [DataMember(Name = "union_id", EmitDefaultValue = false)]
        public string UnionId { get; set; }

        /// <summary>
        /// 支付宝用户的唯一标识。以2088开头的16位数字。
        /// </summary>
        /// <value>支付宝用户的唯一标识。以2088开头的16位数字。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySystemOauthTokenResponseModel {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  AuthStart: ").Append(AuthStart).Append("\n");
            sb.Append("  AuthTokenType: ").Append(AuthTokenType).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  ReExpiresIn: ").Append(ReExpiresIn).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
            sb.Append("  UnionId: ").Append(UnionId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipaySystemOauthTokenResponseModel);
        }

        /// <summary>
        /// Returns true if AlipaySystemOauthTokenResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySystemOauthTokenResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySystemOauthTokenResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessToken == input.AccessToken ||
                    (this.AccessToken != null &&
                    this.AccessToken.Equals(input.AccessToken))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.AuthStart == input.AuthStart ||
                    (this.AuthStart != null &&
                    this.AuthStart.Equals(input.AuthStart))
                ) && 
                (
                    this.AuthTokenType == input.AuthTokenType ||
                    (this.AuthTokenType != null &&
                    this.AuthTokenType.Equals(input.AuthTokenType))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    (this.ExpiresIn != null &&
                    this.ExpiresIn.Equals(input.ExpiresIn))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.ReExpiresIn == input.ReExpiresIn ||
                    (this.ReExpiresIn != null &&
                    this.ReExpiresIn.Equals(input.ReExpiresIn))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
                ) && 
                (
                    this.UnionId == input.UnionId ||
                    (this.UnionId != null &&
                    this.UnionId.Equals(input.UnionId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccessToken != null)
                {
                    hashCode = (hashCode * 59) + this.AccessToken.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.AuthStart != null)
                {
                    hashCode = (hashCode * 59) + this.AuthStart.GetHashCode();
                }
                if (this.AuthTokenType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthTokenType.GetHashCode();
                }
                if (this.ExpiresIn != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresIn.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.ReExpiresIn != null)
                {
                    hashCode = (hashCode * 59) + this.ReExpiresIn.GetHashCode();
                }
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
                }
                if (this.UnionId != null)
                {
                    hashCode = (hashCode * 59) + this.UnionId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
