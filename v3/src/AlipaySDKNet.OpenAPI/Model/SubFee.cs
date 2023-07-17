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
    /// SubFee
    /// </summary>
    [DataContract(Name = "SubFee")]
    public partial class SubFee : IEquatable<SubFee>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFee" /> class.
        /// </summary>
        /// <param name="chargeFee">实收费用.</param>
        /// <param name="originalChargeFee">原始费用.</param>
        /// <param name="switchFeeRate">签约费率.</param>
        public SubFee(string chargeFee = default(string), string originalChargeFee = default(string), string switchFeeRate = default(string))
        {
            this.ChargeFee = chargeFee;
            this.OriginalChargeFee = originalChargeFee;
            this.SwitchFeeRate = switchFeeRate;
        }

        /// <summary>
        /// 实收费用
        /// </summary>
        /// <value>实收费用</value>
        [DataMember(Name = "charge_fee", EmitDefaultValue = false)]
        public string ChargeFee { get; set; }

        /// <summary>
        /// 原始费用
        /// </summary>
        /// <value>原始费用</value>
        [DataMember(Name = "original_charge_fee", EmitDefaultValue = false)]
        public string OriginalChargeFee { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        /// <value>签约费率</value>
        [DataMember(Name = "switch_fee_rate", EmitDefaultValue = false)]
        public string SwitchFeeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubFee {\n");
            sb.Append("  ChargeFee: ").Append(ChargeFee).Append("\n");
            sb.Append("  OriginalChargeFee: ").Append(OriginalChargeFee).Append("\n");
            sb.Append("  SwitchFeeRate: ").Append(SwitchFeeRate).Append("\n");
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
            return this.Equals(input as SubFee);
        }

        /// <summary>
        /// Returns true if SubFee instances are equal
        /// </summary>
        /// <param name="input">Instance of SubFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubFee input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChargeFee == input.ChargeFee ||
                    (this.ChargeFee != null &&
                    this.ChargeFee.Equals(input.ChargeFee))
                ) && 
                (
                    this.OriginalChargeFee == input.OriginalChargeFee ||
                    (this.OriginalChargeFee != null &&
                    this.OriginalChargeFee.Equals(input.OriginalChargeFee))
                ) && 
                (
                    this.SwitchFeeRate == input.SwitchFeeRate ||
                    (this.SwitchFeeRate != null &&
                    this.SwitchFeeRate.Equals(input.SwitchFeeRate))
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
                if (this.ChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeFee.GetHashCode();
                }
                if (this.OriginalChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalChargeFee.GetHashCode();
                }
                if (this.SwitchFeeRate != null)
                {
                    hashCode = (hashCode * 59) + this.SwitchFeeRate.GetHashCode();
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
