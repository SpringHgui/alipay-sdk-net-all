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
    /// JointAccountQuotaRespDTO
    /// </summary>
    [DataContract(Name = "JointAccountQuotaRespDTO")]
    public partial class JointAccountQuotaRespDTO : IEquatable<JointAccountQuotaRespDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountQuotaRespDTO" /> class.
        /// </summary>
        /// <param name="customBeginDate">额度生效起始日期，精确到分钟。 格式：yyyy-MM-dd HH:mm.</param>
        /// <param name="customEndDate">额度失效结束日期，精确到分钟。 格式：yyyy-MM-dd HH:mm.</param>
        /// <param name="quotaDimension">额度维度.</param>
        /// <param name="quotaRemain">剩余额度.</param>
        /// <param name="quotaRemainCount">展示额度剩余可用次数，-1表示无限次.</param>
        /// <param name="quotaTotal">协议额度.</param>
        /// <param name="quotaUsed">已用额度.</param>
        public JointAccountQuotaRespDTO(string customBeginDate = default(string), string customEndDate = default(string), string quotaDimension = default(string), string quotaRemain = default(string), string quotaRemainCount = default(string), string quotaTotal = default(string), string quotaUsed = default(string))
        {
            this.CustomBeginDate = customBeginDate;
            this.CustomEndDate = customEndDate;
            this.QuotaDimension = quotaDimension;
            this.QuotaRemain = quotaRemain;
            this.QuotaRemainCount = quotaRemainCount;
            this.QuotaTotal = quotaTotal;
            this.QuotaUsed = quotaUsed;
        }

        /// <summary>
        /// 额度生效起始日期，精确到分钟。 格式：yyyy-MM-dd HH:mm
        /// </summary>
        /// <value>额度生效起始日期，精确到分钟。 格式：yyyy-MM-dd HH:mm</value>
        [DataMember(Name = "custom_begin_date", EmitDefaultValue = false)]
        public string CustomBeginDate { get; set; }

        /// <summary>
        /// 额度失效结束日期，精确到分钟。 格式：yyyy-MM-dd HH:mm
        /// </summary>
        /// <value>额度失效结束日期，精确到分钟。 格式：yyyy-MM-dd HH:mm</value>
        [DataMember(Name = "custom_end_date", EmitDefaultValue = false)]
        public string CustomEndDate { get; set; }

        /// <summary>
        /// 额度维度
        /// </summary>
        /// <value>额度维度</value>
        [DataMember(Name = "quota_dimension", EmitDefaultValue = false)]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 剩余额度
        /// </summary>
        /// <value>剩余额度</value>
        [DataMember(Name = "quota_remain", EmitDefaultValue = false)]
        public string QuotaRemain { get; set; }

        /// <summary>
        /// 展示额度剩余可用次数，-1表示无限次
        /// </summary>
        /// <value>展示额度剩余可用次数，-1表示无限次</value>
        [DataMember(Name = "quota_remain_count", EmitDefaultValue = false)]
        public string QuotaRemainCount { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        /// <value>协议额度</value>
        [DataMember(Name = "quota_total", EmitDefaultValue = false)]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 已用额度
        /// </summary>
        /// <value>已用额度</value>
        [DataMember(Name = "quota_used", EmitDefaultValue = false)]
        public string QuotaUsed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountQuotaRespDTO {\n");
            sb.Append("  CustomBeginDate: ").Append(CustomBeginDate).Append("\n");
            sb.Append("  CustomEndDate: ").Append(CustomEndDate).Append("\n");
            sb.Append("  QuotaDimension: ").Append(QuotaDimension).Append("\n");
            sb.Append("  QuotaRemain: ").Append(QuotaRemain).Append("\n");
            sb.Append("  QuotaRemainCount: ").Append(QuotaRemainCount).Append("\n");
            sb.Append("  QuotaTotal: ").Append(QuotaTotal).Append("\n");
            sb.Append("  QuotaUsed: ").Append(QuotaUsed).Append("\n");
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
            return this.Equals(input as JointAccountQuotaRespDTO);
        }

        /// <summary>
        /// Returns true if JointAccountQuotaRespDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountQuotaRespDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountQuotaRespDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomBeginDate == input.CustomBeginDate ||
                    (this.CustomBeginDate != null &&
                    this.CustomBeginDate.Equals(input.CustomBeginDate))
                ) && 
                (
                    this.CustomEndDate == input.CustomEndDate ||
                    (this.CustomEndDate != null &&
                    this.CustomEndDate.Equals(input.CustomEndDate))
                ) && 
                (
                    this.QuotaDimension == input.QuotaDimension ||
                    (this.QuotaDimension != null &&
                    this.QuotaDimension.Equals(input.QuotaDimension))
                ) && 
                (
                    this.QuotaRemain == input.QuotaRemain ||
                    (this.QuotaRemain != null &&
                    this.QuotaRemain.Equals(input.QuotaRemain))
                ) && 
                (
                    this.QuotaRemainCount == input.QuotaRemainCount ||
                    (this.QuotaRemainCount != null &&
                    this.QuotaRemainCount.Equals(input.QuotaRemainCount))
                ) && 
                (
                    this.QuotaTotal == input.QuotaTotal ||
                    (this.QuotaTotal != null &&
                    this.QuotaTotal.Equals(input.QuotaTotal))
                ) && 
                (
                    this.QuotaUsed == input.QuotaUsed ||
                    (this.QuotaUsed != null &&
                    this.QuotaUsed.Equals(input.QuotaUsed))
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
                if (this.CustomBeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.CustomBeginDate.GetHashCode();
                }
                if (this.CustomEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.CustomEndDate.GetHashCode();
                }
                if (this.QuotaDimension != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaDimension.GetHashCode();
                }
                if (this.QuotaRemain != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaRemain.GetHashCode();
                }
                if (this.QuotaRemainCount != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaRemainCount.GetHashCode();
                }
                if (this.QuotaTotal != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaTotal.GetHashCode();
                }
                if (this.QuotaUsed != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaUsed.GetHashCode();
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
