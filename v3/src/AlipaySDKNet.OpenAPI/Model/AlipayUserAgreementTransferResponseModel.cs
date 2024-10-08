/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// AlipayUserAgreementTransferResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementTransferResponseModel")]
    public partial class AlipayUserAgreementTransferResponseModel : IEquatable<AlipayUserAgreementTransferResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementTransferResponseModel" /> class.
        /// </summary>
        /// <param name="amount">单次金额限制，单位为元.</param>
        /// <param name="executeTime">执行时间.</param>
        /// <param name="period">周期.</param>
        /// <param name="periodType">周期类型.</param>
        /// <param name="totalAmount">总金额限制，单位为元.</param>
        /// <param name="totalPayments">总支付次数.</param>
        public AlipayUserAgreementTransferResponseModel(string amount = default(string), string executeTime = default(string), string period = default(string), string periodType = default(string), string totalAmount = default(string), string totalPayments = default(string))
        {
            this.Amount = amount;
            this.ExecuteTime = executeTime;
            this.Period = period;
            this.PeriodType = periodType;
            this.TotalAmount = totalAmount;
            this.TotalPayments = totalPayments;
        }

        /// <summary>
        /// 单次金额限制，单位为元
        /// </summary>
        /// <value>单次金额限制，单位为元</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 执行时间
        /// </summary>
        /// <value>执行时间</value>
        [DataMember(Name = "execute_time", EmitDefaultValue = false)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        /// <value>周期</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public string Period { get; set; }

        /// <summary>
        /// 周期类型
        /// </summary>
        /// <value>周期类型</value>
        [DataMember(Name = "period_type", EmitDefaultValue = false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 总金额限制，单位为元
        /// </summary>
        /// <value>总金额限制，单位为元</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 总支付次数
        /// </summary>
        /// <value>总支付次数</value>
        [DataMember(Name = "total_payments", EmitDefaultValue = false)]
        public string TotalPayments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAgreementTransferResponseModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ExecuteTime: ").Append(ExecuteTime).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TotalPayments: ").Append(TotalPayments).Append("\n");
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
            return this.Equals(input as AlipayUserAgreementTransferResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementTransferResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementTransferResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementTransferResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.ExecuteTime == input.ExecuteTime ||
                    (this.ExecuteTime != null &&
                    this.ExecuteTime.Equals(input.ExecuteTime))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.TotalPayments == input.TotalPayments ||
                    (this.TotalPayments != null &&
                    this.TotalPayments.Equals(input.TotalPayments))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.ExecuteTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExecuteTime.GetHashCode();
                }
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                if (this.PeriodType != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodType.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.TotalPayments != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPayments.GetHashCode();
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
