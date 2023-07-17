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
    /// VoucherPackageActivityInfo
    /// </summary>
    [DataContract(Name = "VoucherPackageActivityInfo")]
    public partial class VoucherPackageActivityInfo : IEquatable<VoucherPackageActivityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherPackageActivityInfo" /> class.
        /// </summary>
        /// <param name="activityBaseInfo">activityBaseInfo.</param>
        /// <param name="voucherAvailableScopeInfo">voucherAvailableScopeInfo.</param>
        /// <param name="voucherDeductInfo">voucherDeductInfo.</param>
        /// <param name="voucherDisplayPatternInfo">voucherDisplayPatternInfo.</param>
        /// <param name="voucherSendModeInfo">voucherSendModeInfo.</param>
        /// <param name="voucherUseRuleInfo">voucherUseRuleInfo.</param>
        public VoucherPackageActivityInfo(ActivityBaseInfo activityBaseInfo = default(ActivityBaseInfo), VoucherAvailableScopeInfo voucherAvailableScopeInfo = default(VoucherAvailableScopeInfo), VoucherDeductInfo voucherDeductInfo = default(VoucherDeductInfo), VoucherDisplayPatternInfo voucherDisplayPatternInfo = default(VoucherDisplayPatternInfo), VoucherSendModeInfo voucherSendModeInfo = default(VoucherSendModeInfo), VoucherUseRuleInfo voucherUseRuleInfo = default(VoucherUseRuleInfo))
        {
            this.ActivityBaseInfo = activityBaseInfo;
            this.VoucherAvailableScopeInfo = voucherAvailableScopeInfo;
            this.VoucherDeductInfo = voucherDeductInfo;
            this.VoucherDisplayPatternInfo = voucherDisplayPatternInfo;
            this.VoucherSendModeInfo = voucherSendModeInfo;
            this.VoucherUseRuleInfo = voucherUseRuleInfo;
        }

        /// <summary>
        /// Gets or Sets ActivityBaseInfo
        /// </summary>
        [DataMember(Name = "activity_base_info", EmitDefaultValue = false)]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherAvailableScopeInfo
        /// </summary>
        [DataMember(Name = "voucher_available_scope_info", EmitDefaultValue = false)]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDeductInfo
        /// </summary>
        [DataMember(Name = "voucher_deduct_info", EmitDefaultValue = false)]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDisplayPatternInfo
        /// </summary>
        [DataMember(Name = "voucher_display_pattern_info", EmitDefaultValue = false)]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendModeInfo
        /// </summary>
        [DataMember(Name = "voucher_send_mode_info", EmitDefaultValue = false)]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseRuleInfo
        /// </summary>
        [DataMember(Name = "voucher_use_rule_info", EmitDefaultValue = false)]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherPackageActivityInfo {\n");
            sb.Append("  ActivityBaseInfo: ").Append(ActivityBaseInfo).Append("\n");
            sb.Append("  VoucherAvailableScopeInfo: ").Append(VoucherAvailableScopeInfo).Append("\n");
            sb.Append("  VoucherDeductInfo: ").Append(VoucherDeductInfo).Append("\n");
            sb.Append("  VoucherDisplayPatternInfo: ").Append(VoucherDisplayPatternInfo).Append("\n");
            sb.Append("  VoucherSendModeInfo: ").Append(VoucherSendModeInfo).Append("\n");
            sb.Append("  VoucherUseRuleInfo: ").Append(VoucherUseRuleInfo).Append("\n");
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
            return this.Equals(input as VoucherPackageActivityInfo);
        }

        /// <summary>
        /// Returns true if VoucherPackageActivityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherPackageActivityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherPackageActivityInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityBaseInfo == input.ActivityBaseInfo ||
                    (this.ActivityBaseInfo != null &&
                    this.ActivityBaseInfo.Equals(input.ActivityBaseInfo))
                ) && 
                (
                    this.VoucherAvailableScopeInfo == input.VoucherAvailableScopeInfo ||
                    (this.VoucherAvailableScopeInfo != null &&
                    this.VoucherAvailableScopeInfo.Equals(input.VoucherAvailableScopeInfo))
                ) && 
                (
                    this.VoucherDeductInfo == input.VoucherDeductInfo ||
                    (this.VoucherDeductInfo != null &&
                    this.VoucherDeductInfo.Equals(input.VoucherDeductInfo))
                ) && 
                (
                    this.VoucherDisplayPatternInfo == input.VoucherDisplayPatternInfo ||
                    (this.VoucherDisplayPatternInfo != null &&
                    this.VoucherDisplayPatternInfo.Equals(input.VoucherDisplayPatternInfo))
                ) && 
                (
                    this.VoucherSendModeInfo == input.VoucherSendModeInfo ||
                    (this.VoucherSendModeInfo != null &&
                    this.VoucherSendModeInfo.Equals(input.VoucherSendModeInfo))
                ) && 
                (
                    this.VoucherUseRuleInfo == input.VoucherUseRuleInfo ||
                    (this.VoucherUseRuleInfo != null &&
                    this.VoucherUseRuleInfo.Equals(input.VoucherUseRuleInfo))
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
                if (this.ActivityBaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityBaseInfo.GetHashCode();
                }
                if (this.VoucherAvailableScopeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScopeInfo.GetHashCode();
                }
                if (this.VoucherDeductInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDeductInfo.GetHashCode();
                }
                if (this.VoucherDisplayPatternInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDisplayPatternInfo.GetHashCode();
                }
                if (this.VoucherSendModeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendModeInfo.GetHashCode();
                }
                if (this.VoucherUseRuleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseRuleInfo.GetHashCode();
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
