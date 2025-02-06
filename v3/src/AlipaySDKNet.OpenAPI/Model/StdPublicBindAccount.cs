/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// StdPublicBindAccount
    /// </summary>
    [DataContract(Name = "StdPublicBindAccount")]
    public partial class StdPublicBindAccount : IEquatable<StdPublicBindAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StdPublicBindAccount" /> class.
        /// </summary>
        /// <param name="agreementId">协议号是商户会员在支付宝公众账号中的唯一标识。.</param>
        /// <param name="appId">公众账号ID.</param>
        /// <param name="bindAccountNo">绑定的商户会员号.</param>
        /// <param name="displayName">公众账号期望支付宝用户在公众账号首页看到的关于该用户的显示信息，最长10个汉字。.</param>
        /// <param name="fromUserId">绑定的商户会员对应的支付宝用户号，以2088 开头的16位数字。.</param>
        /// <param name="openId">1.</param>
        /// <param name="realName">绑定的商户会员的真实姓名，最长10个汉字。.</param>
        public StdPublicBindAccount(string agreementId = default(string), string appId = default(string), string bindAccountNo = default(string), string displayName = default(string), string fromUserId = default(string), string openId = default(string), string realName = default(string))
        {
            this.AgreementId = agreementId;
            this.AppId = appId;
            this.BindAccountNo = bindAccountNo;
            this.DisplayName = displayName;
            this.FromUserId = fromUserId;
            this.OpenId = openId;
            this.RealName = realName;
        }

        /// <summary>
        /// 协议号是商户会员在支付宝公众账号中的唯一标识。
        /// </summary>
        /// <value>协议号是商户会员在支付宝公众账号中的唯一标识。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        /// <value>公众账号ID</value>
        [DataMember(Name = "app_id", EmitDefaultValue = false)]
        public string AppId { get; set; }

        /// <summary>
        /// 绑定的商户会员号
        /// </summary>
        /// <value>绑定的商户会员号</value>
        [DataMember(Name = "bind_account_no", EmitDefaultValue = false)]
        public string BindAccountNo { get; set; }

        /// <summary>
        /// 公众账号期望支付宝用户在公众账号首页看到的关于该用户的显示信息，最长10个汉字。
        /// </summary>
        /// <value>公众账号期望支付宝用户在公众账号首页看到的关于该用户的显示信息，最长10个汉字。</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 绑定的商户会员对应的支付宝用户号，以2088 开头的16位数字。
        /// </summary>
        /// <value>绑定的商户会员对应的支付宝用户号，以2088 开头的16位数字。</value>
        [DataMember(Name = "from_user_id", EmitDefaultValue = false)]
        public string FromUserId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 绑定的商户会员的真实姓名，最长10个汉字。
        /// </summary>
        /// <value>绑定的商户会员的真实姓名，最长10个汉字。</value>
        [DataMember(Name = "real_name", EmitDefaultValue = false)]
        public string RealName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StdPublicBindAccount {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  BindAccountNo: ").Append(BindAccountNo).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FromUserId: ").Append(FromUserId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  RealName: ").Append(RealName).Append("\n");
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
            return this.Equals(input as StdPublicBindAccount);
        }

        /// <summary>
        /// Returns true if StdPublicBindAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of StdPublicBindAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StdPublicBindAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.AppId == input.AppId ||
                    (this.AppId != null &&
                    this.AppId.Equals(input.AppId))
                ) && 
                (
                    this.BindAccountNo == input.BindAccountNo ||
                    (this.BindAccountNo != null &&
                    this.BindAccountNo.Equals(input.BindAccountNo))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.FromUserId == input.FromUserId ||
                    (this.FromUserId != null &&
                    this.FromUserId.Equals(input.FromUserId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.RealName == input.RealName ||
                    (this.RealName != null &&
                    this.RealName.Equals(input.RealName))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.AppId != null)
                {
                    hashCode = (hashCode * 59) + this.AppId.GetHashCode();
                }
                if (this.BindAccountNo != null)
                {
                    hashCode = (hashCode * 59) + this.BindAccountNo.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.FromUserId != null)
                {
                    hashCode = (hashCode * 59) + this.FromUserId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.RealName != null)
                {
                    hashCode = (hashCode * 59) + this.RealName.GetHashCode();
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
