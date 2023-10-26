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
    /// PaymentVoucherAvailableMerchantModify
    /// </summary>
    [DataContract(Name = "PaymentVoucherAvailableMerchantModify")]
    public partial class PaymentVoucherAvailableMerchantModify : IEquatable<PaymentVoucherAvailableMerchantModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherAvailableMerchantModify" /> class.
        /// </summary>
        /// <param name="availablePids">优惠券可以核销的直连商户PID。默认不修改。  限制：  1、核销商户范围只能增大不能减小。.</param>
        /// <param name="availableSmids">优惠券可以核销的间连商户SMID。默认不修改。  限制：   1、核销商户范围只能增大不能减小。.</param>
        public PaymentVoucherAvailableMerchantModify(List<string> availablePids = default(List<string>), List<string> availableSmids = default(List<string>))
        {
            this.AvailablePids = availablePids;
            this.AvailableSmids = availableSmids;
        }

        /// <summary>
        /// 优惠券可以核销的直连商户PID。默认不修改。  限制：  1、核销商户范围只能增大不能减小。
        /// </summary>
        /// <value>优惠券可以核销的直连商户PID。默认不修改。  限制：  1、核销商户范围只能增大不能减小。</value>
        [DataMember(Name = "available_pids", EmitDefaultValue = false)]
        public List<string> AvailablePids { get; set; }

        /// <summary>
        /// 优惠券可以核销的间连商户SMID。默认不修改。  限制：   1、核销商户范围只能增大不能减小。
        /// </summary>
        /// <value>优惠券可以核销的间连商户SMID。默认不修改。  限制：   1、核销商户范围只能增大不能减小。</value>
        [DataMember(Name = "available_smids", EmitDefaultValue = false)]
        public List<string> AvailableSmids { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherAvailableMerchantModify {\n");
            sb.Append("  AvailablePids: ").Append(AvailablePids).Append("\n");
            sb.Append("  AvailableSmids: ").Append(AvailableSmids).Append("\n");
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
            return this.Equals(input as PaymentVoucherAvailableMerchantModify);
        }

        /// <summary>
        /// Returns true if PaymentVoucherAvailableMerchantModify instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherAvailableMerchantModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherAvailableMerchantModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailablePids == input.AvailablePids ||
                    this.AvailablePids != null &&
                    input.AvailablePids != null &&
                    this.AvailablePids.SequenceEqual(input.AvailablePids)
                ) && 
                (
                    this.AvailableSmids == input.AvailableSmids ||
                    this.AvailableSmids != null &&
                    input.AvailableSmids != null &&
                    this.AvailableSmids.SequenceEqual(input.AvailableSmids)
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
                if (this.AvailablePids != null)
                {
                    hashCode = (hashCode * 59) + this.AvailablePids.GetHashCode();
                }
                if (this.AvailableSmids != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableSmids.GetHashCode();
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
