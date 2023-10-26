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
    /// CreditRiskInfo
    /// </summary>
    [DataContract(Name = "CreditRiskInfo")]
    public partial class CreditRiskInfo : IEquatable<CreditRiskInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditRiskInfo" /> class.
        /// </summary>
        /// <param name="canRetry">查询失败的情况下，是否可以通过重试解决。true 表示可以适当重试一定次数；false 表示有明确的失败原因，无需重试，.</param>
        /// <param name="code">用户信用数据查询状态.</param>
        /// <param name="data">用户信用风险信息，如：租物场景风险等级、履约历史等级、共租行为等级.</param>
        public CreditRiskInfo(bool canRetry = default(bool), string code = default(string), string data = default(string))
        {
            this.CanRetry = canRetry;
            this.Code = code;
            this.Data = data;
        }

        /// <summary>
        /// 查询失败的情况下，是否可以通过重试解决。true 表示可以适当重试一定次数；false 表示有明确的失败原因，无需重试，
        /// </summary>
        /// <value>查询失败的情况下，是否可以通过重试解决。true 表示可以适当重试一定次数；false 表示有明确的失败原因，无需重试，</value>
        [DataMember(Name = "can_retry", EmitDefaultValue = true)]
        public bool CanRetry { get; set; }

        /// <summary>
        /// 用户信用数据查询状态
        /// </summary>
        /// <value>用户信用数据查询状态</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 用户信用风险信息，如：租物场景风险等级、履约历史等级、共租行为等级
        /// </summary>
        /// <value>用户信用风险信息，如：租物场景风险等级、履约历史等级、共租行为等级</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditRiskInfo {\n");
            sb.Append("  CanRetry: ").Append(CanRetry).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CreditRiskInfo);
        }

        /// <summary>
        /// Returns true if CreditRiskInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditRiskInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditRiskInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanRetry == input.CanRetry ||
                    this.CanRetry.Equals(input.CanRetry)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                hashCode = (hashCode * 59) + this.CanRetry.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
