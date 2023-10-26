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
    /// ZMGOCycleWithholdConfig
    /// </summary>
    [DataContract(Name = "ZMGOCycleWithholdConfig")]
    public partial class ZMGOCycleWithholdConfig : IEquatable<ZMGOCycleWithholdConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGOCycleWithholdConfig" /> class.
        /// </summary>
        /// <param name="deductPlan">扣款计划.</param>
        /// <param name="exemptionPeriod">豁免期天数.</param>
        /// <param name="period">周期.</param>
        /// <param name="periodType">扣款周期类型，支持DAY-天模式，MONTH-月模式.</param>
        /// <param name="supportCycleWithholdHighMode">是否支持周期扣高级模式，高级模式下扣款计划中内一起的扣款金额可以进行定制.</param>
        /// <param name="supportExemptionPeriod">是否支持豁免期，如果支持豁免期，用户开通后再豁免期内退出无需扣款.</param>
        /// <param name="withholdMode">设置扣款模式，目前支持每月固定日期或固定时间间隔.</param>
        public ZMGOCycleWithholdConfig(List<string> deductPlan = default(List<string>), string exemptionPeriod = default(string), string period = default(string), string periodType = default(string), bool supportCycleWithholdHighMode = default(bool), bool supportExemptionPeriod = default(bool), string withholdMode = default(string))
        {
            this.DeductPlan = deductPlan;
            this.ExemptionPeriod = exemptionPeriod;
            this.Period = period;
            this.PeriodType = periodType;
            this.SupportCycleWithholdHighMode = supportCycleWithholdHighMode;
            this.SupportExemptionPeriod = supportExemptionPeriod;
            this.WithholdMode = withholdMode;
        }

        /// <summary>
        /// 扣款计划
        /// </summary>
        /// <value>扣款计划</value>
        [DataMember(Name = "deduct_plan", EmitDefaultValue = false)]
        public List<string> DeductPlan { get; set; }

        /// <summary>
        /// 豁免期天数
        /// </summary>
        /// <value>豁免期天数</value>
        [DataMember(Name = "exemption_period", EmitDefaultValue = false)]
        public string ExemptionPeriod { get; set; }

        /// <summary>
        /// 周期
        /// </summary>
        /// <value>周期</value>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public string Period { get; set; }

        /// <summary>
        /// 扣款周期类型，支持DAY-天模式，MONTH-月模式
        /// </summary>
        /// <value>扣款周期类型，支持DAY-天模式，MONTH-月模式</value>
        [DataMember(Name = "period_type", EmitDefaultValue = false)]
        public string PeriodType { get; set; }

        /// <summary>
        /// 是否支持周期扣高级模式，高级模式下扣款计划中内一起的扣款金额可以进行定制
        /// </summary>
        /// <value>是否支持周期扣高级模式，高级模式下扣款计划中内一起的扣款金额可以进行定制</value>
        [DataMember(Name = "support_cycle_withhold_high_mode", EmitDefaultValue = true)]
        public bool SupportCycleWithholdHighMode { get; set; }

        /// <summary>
        /// 是否支持豁免期，如果支持豁免期，用户开通后再豁免期内退出无需扣款
        /// </summary>
        /// <value>是否支持豁免期，如果支持豁免期，用户开通后再豁免期内退出无需扣款</value>
        [DataMember(Name = "support_exemption_period", EmitDefaultValue = true)]
        public bool SupportExemptionPeriod { get; set; }

        /// <summary>
        /// 设置扣款模式，目前支持每月固定日期或固定时间间隔
        /// </summary>
        /// <value>设置扣款模式，目前支持每月固定日期或固定时间间隔</value>
        [DataMember(Name = "withhold_mode", EmitDefaultValue = false)]
        public string WithholdMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGOCycleWithholdConfig {\n");
            sb.Append("  DeductPlan: ").Append(DeductPlan).Append("\n");
            sb.Append("  ExemptionPeriod: ").Append(ExemptionPeriod).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  SupportCycleWithholdHighMode: ").Append(SupportCycleWithholdHighMode).Append("\n");
            sb.Append("  SupportExemptionPeriod: ").Append(SupportExemptionPeriod).Append("\n");
            sb.Append("  WithholdMode: ").Append(WithholdMode).Append("\n");
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
            return this.Equals(input as ZMGOCycleWithholdConfig);
        }

        /// <summary>
        /// Returns true if ZMGOCycleWithholdConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGOCycleWithholdConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGOCycleWithholdConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeductPlan == input.DeductPlan ||
                    this.DeductPlan != null &&
                    input.DeductPlan != null &&
                    this.DeductPlan.SequenceEqual(input.DeductPlan)
                ) && 
                (
                    this.ExemptionPeriod == input.ExemptionPeriod ||
                    (this.ExemptionPeriod != null &&
                    this.ExemptionPeriod.Equals(input.ExemptionPeriod))
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
                    this.SupportCycleWithholdHighMode == input.SupportCycleWithholdHighMode ||
                    this.SupportCycleWithholdHighMode.Equals(input.SupportCycleWithholdHighMode)
                ) && 
                (
                    this.SupportExemptionPeriod == input.SupportExemptionPeriod ||
                    this.SupportExemptionPeriod.Equals(input.SupportExemptionPeriod)
                ) && 
                (
                    this.WithholdMode == input.WithholdMode ||
                    (this.WithholdMode != null &&
                    this.WithholdMode.Equals(input.WithholdMode))
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
                if (this.DeductPlan != null)
                {
                    hashCode = (hashCode * 59) + this.DeductPlan.GetHashCode();
                }
                if (this.ExemptionPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.ExemptionPeriod.GetHashCode();
                }
                if (this.Period != null)
                {
                    hashCode = (hashCode * 59) + this.Period.GetHashCode();
                }
                if (this.PeriodType != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SupportCycleWithholdHighMode.GetHashCode();
                hashCode = (hashCode * 59) + this.SupportExemptionPeriod.GetHashCode();
                if (this.WithholdMode != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdMode.GetHashCode();
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
