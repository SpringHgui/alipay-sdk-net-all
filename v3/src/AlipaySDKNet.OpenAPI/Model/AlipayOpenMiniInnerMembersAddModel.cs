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
    /// AlipayOpenMiniInnerMembersAddModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerMembersAddModel")]
    public partial class AlipayOpenMiniInnerMembersAddModel : IEquatable<AlipayOpenMiniInnerMembersAddModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerMembersAddModel" /> class.
        /// </summary>
        /// <param name="appOrigin">业务来源.</param>
        /// <param name="domainAccount">域账号（不为空时会添加联系人）.</param>
        /// <param name="loginId">支付宝登陆账号.</param>
        /// <param name="miniAppId">业务appId.</param>
        /// <param name="type">成员类型.</param>
        public AlipayOpenMiniInnerMembersAddModel(string appOrigin = default(string), string domainAccount = default(string), string loginId = default(string), string miniAppId = default(string), string type = default(string))
        {
            this.AppOrigin = appOrigin;
            this.DomainAccount = domainAccount;
            this.LoginId = loginId;
            this.MiniAppId = miniAppId;
            this.Type = type;
        }

        /// <summary>
        /// 业务来源
        /// </summary>
        /// <value>业务来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 域账号（不为空时会添加联系人）
        /// </summary>
        /// <value>域账号（不为空时会添加联系人）</value>
        [DataMember(Name = "domain_account", EmitDefaultValue = false)]
        public string DomainAccount { get; set; }

        /// <summary>
        /// 支付宝登陆账号
        /// </summary>
        /// <value>支付宝登陆账号</value>
        [DataMember(Name = "login_id", EmitDefaultValue = false)]
        public string LoginId { get; set; }

        /// <summary>
        /// 业务appId
        /// </summary>
        /// <value>业务appId</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 成员类型
        /// </summary>
        /// <value>成员类型</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerMembersAddModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  DomainAccount: ").Append(DomainAccount).Append("\n");
            sb.Append("  LoginId: ").Append(LoginId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerMembersAddModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerMembersAddModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerMembersAddModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerMembersAddModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.DomainAccount == input.DomainAccount ||
                    (this.DomainAccount != null &&
                    this.DomainAccount.Equals(input.DomainAccount))
                ) && 
                (
                    this.LoginId == input.LoginId ||
                    (this.LoginId != null &&
                    this.LoginId.Equals(input.LoginId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.DomainAccount != null)
                {
                    hashCode = (hashCode * 59) + this.DomainAccount.GetHashCode();
                }
                if (this.LoginId != null)
                {
                    hashCode = (hashCode * 59) + this.LoginId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
