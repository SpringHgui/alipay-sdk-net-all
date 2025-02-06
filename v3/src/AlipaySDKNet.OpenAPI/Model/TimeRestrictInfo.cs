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
    /// TimeRestrictInfo
    /// </summary>
    [DataContract(Name = "TimeRestrictInfo")]
    public partial class TimeRestrictInfo : IEquatable<TimeRestrictInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRestrictInfo" /> class.
        /// </summary>
        /// <param name="disablePeriodInfo">不可用时间段.</param>
        /// <param name="usablePeriodInfo">可用时间段.</param>
        public TimeRestrictInfo(List<VoucherUseTimeRuleInfo> disablePeriodInfo = default(List<VoucherUseTimeRuleInfo>), List<VoucherUseTimeRuleInfo> usablePeriodInfo = default(List<VoucherUseTimeRuleInfo>))
        {
            this.DisablePeriodInfo = disablePeriodInfo;
            this.UsablePeriodInfo = usablePeriodInfo;
        }

        /// <summary>
        /// 不可用时间段
        /// </summary>
        /// <value>不可用时间段</value>
        [DataMember(Name = "disable_period_info", EmitDefaultValue = false)]
        public List<VoucherUseTimeRuleInfo> DisablePeriodInfo { get; set; }

        /// <summary>
        /// 可用时间段
        /// </summary>
        /// <value>可用时间段</value>
        [DataMember(Name = "usable_period_info", EmitDefaultValue = false)]
        public List<VoucherUseTimeRuleInfo> UsablePeriodInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeRestrictInfo {\n");
            sb.Append("  DisablePeriodInfo: ").Append(DisablePeriodInfo).Append("\n");
            sb.Append("  UsablePeriodInfo: ").Append(UsablePeriodInfo).Append("\n");
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
            return this.Equals(input as TimeRestrictInfo);
        }

        /// <summary>
        /// Returns true if TimeRestrictInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeRestrictInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRestrictInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisablePeriodInfo == input.DisablePeriodInfo ||
                    this.DisablePeriodInfo != null &&
                    input.DisablePeriodInfo != null &&
                    this.DisablePeriodInfo.SequenceEqual(input.DisablePeriodInfo)
                ) && 
                (
                    this.UsablePeriodInfo == input.UsablePeriodInfo ||
                    this.UsablePeriodInfo != null &&
                    input.UsablePeriodInfo != null &&
                    this.UsablePeriodInfo.SequenceEqual(input.UsablePeriodInfo)
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
                if (this.DisablePeriodInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DisablePeriodInfo.GetHashCode();
                }
                if (this.UsablePeriodInfo != null)
                {
                    hashCode = (hashCode * 59) + this.UsablePeriodInfo.GetHashCode();
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
