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
    /// InviteResultDTO
    /// </summary>
    [DataContract(Name = "InviteResultDTO")]
    public partial class InviteResultDTO : IEquatable<InviteResultDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteResultDTO" /> class.
        /// </summary>
        /// <param name="identity">（被邀请人）用户唯一标识&lt;br&gt; 补充说明：&lt;br&gt; - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致.</param>
        /// <param name="identityType">（被邀请人）账号类型，参考值如下：&lt;br&gt; - OUT_USER_ID：商户侧用户唯一标识&lt;br&gt; 补充说明： - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致.</param>
        /// <param name="processId">审批单号，不同被邀请人之间的审批单号不同（支付宝侧生成）.</param>
        public InviteResultDTO(string identity = default(string), string identityType = default(string), string processId = default(string))
        {
            this.Identity = identity;
            this.IdentityType = identityType;
            this.ProcessId = processId;
        }

        /// <summary>
        /// （被邀请人）用户唯一标识&lt;br&gt; 补充说明：&lt;br&gt; - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致
        /// </summary>
        /// <value>（被邀请人）用户唯一标识&lt;br&gt; 补充说明：&lt;br&gt; - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public string Identity { get; set; }

        /// <summary>
        /// （被邀请人）账号类型，参考值如下：&lt;br&gt; - OUT_USER_ID：商户侧用户唯一标识&lt;br&gt; 补充说明： - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致
        /// </summary>
        /// <value>（被邀请人）账号类型，参考值如下：&lt;br&gt; - OUT_USER_ID：商户侧用户唯一标识&lt;br&gt; 补充说明： - 该字段与签约接口alipay.fund.jointaccount.sign请求参数中传入值保持一致</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// 审批单号，不同被邀请人之间的审批单号不同（支付宝侧生成）
        /// </summary>
        /// <value>审批单号，不同被邀请人之间的审批单号不同（支付宝侧生成）</value>
        [DataMember(Name = "process_id", EmitDefaultValue = false)]
        public string ProcessId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InviteResultDTO {\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  ProcessId: ").Append(ProcessId).Append("\n");
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
            return this.Equals(input as InviteResultDTO);
        }

        /// <summary>
        /// Returns true if InviteResultDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteResultDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.ProcessId == input.ProcessId ||
                    (this.ProcessId != null &&
                    this.ProcessId.Equals(input.ProcessId))
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
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.ProcessId != null)
                {
                    hashCode = (hashCode * 59) + this.ProcessId.GetHashCode();
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
