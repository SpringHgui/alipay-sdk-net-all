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
    /// VoucherRelativePeriodInfo
    /// </summary>
    [DataContract(Name = "VoucherRelativePeriodInfo")]
    public partial class VoucherRelativePeriodInfo : IEquatable<VoucherRelativePeriodInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherRelativePeriodInfo" /> class.
        /// </summary>
        /// <param name="timeRestrictInfo">timeRestrictInfo.</param>
        /// <param name="validDaysAfterReceive">券生效后 N 天内可以使用。 可以配合wait_days_after_receive 字段使用。.</param>
        /// <param name="waitDaysAfterReceive">用户领券后需要等待 N 天，券才可以生效。  字段值为 0 表示用户领券后立刻生效。.</param>
        public VoucherRelativePeriodInfo(TimeRestrictInfo timeRestrictInfo = default(TimeRestrictInfo), int validDaysAfterReceive = default(int), int waitDaysAfterReceive = default(int))
        {
            this.TimeRestrictInfo = timeRestrictInfo;
            this.ValidDaysAfterReceive = validDaysAfterReceive;
            this.WaitDaysAfterReceive = waitDaysAfterReceive;
        }

        /// <summary>
        /// Gets or Sets TimeRestrictInfo
        /// </summary>
        [DataMember(Name = "time_restrict_info", EmitDefaultValue = false)]
        public TimeRestrictInfo TimeRestrictInfo { get; set; }

        /// <summary>
        /// 券生效后 N 天内可以使用。 可以配合wait_days_after_receive 字段使用。
        /// </summary>
        /// <value>券生效后 N 天内可以使用。 可以配合wait_days_after_receive 字段使用。</value>
        [DataMember(Name = "valid_days_after_receive", EmitDefaultValue = false)]
        public int ValidDaysAfterReceive { get; set; }

        /// <summary>
        /// 用户领券后需要等待 N 天，券才可以生效。  字段值为 0 表示用户领券后立刻生效。
        /// </summary>
        /// <value>用户领券后需要等待 N 天，券才可以生效。  字段值为 0 表示用户领券后立刻生效。</value>
        [DataMember(Name = "wait_days_after_receive", EmitDefaultValue = false)]
        public int WaitDaysAfterReceive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherRelativePeriodInfo {\n");
            sb.Append("  TimeRestrictInfo: ").Append(TimeRestrictInfo).Append("\n");
            sb.Append("  ValidDaysAfterReceive: ").Append(ValidDaysAfterReceive).Append("\n");
            sb.Append("  WaitDaysAfterReceive: ").Append(WaitDaysAfterReceive).Append("\n");
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
            return this.Equals(input as VoucherRelativePeriodInfo);
        }

        /// <summary>
        /// Returns true if VoucherRelativePeriodInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherRelativePeriodInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherRelativePeriodInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TimeRestrictInfo == input.TimeRestrictInfo ||
                    (this.TimeRestrictInfo != null &&
                    this.TimeRestrictInfo.Equals(input.TimeRestrictInfo))
                ) && 
                (
                    this.ValidDaysAfterReceive == input.ValidDaysAfterReceive ||
                    this.ValidDaysAfterReceive.Equals(input.ValidDaysAfterReceive)
                ) && 
                (
                    this.WaitDaysAfterReceive == input.WaitDaysAfterReceive ||
                    this.WaitDaysAfterReceive.Equals(input.WaitDaysAfterReceive)
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
                if (this.TimeRestrictInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TimeRestrictInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidDaysAfterReceive.GetHashCode();
                hashCode = (hashCode * 59) + this.WaitDaysAfterReceive.GetHashCode();
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
