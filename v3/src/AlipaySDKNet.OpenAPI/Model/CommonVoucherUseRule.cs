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
    /// CommonVoucherUseRule
    /// </summary>
    [DataContract(Name = "CommonVoucherUseRule")]
    public partial class CommonVoucherUseRule : IEquatable<CommonVoucherUseRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVoucherUseRule" /> class.
        /// </summary>
        /// <param name="discountVoucher">discountVoucher.</param>
        /// <param name="exchangeVoucher">exchangeVoucher.</param>
        /// <param name="fixVoucher">fixVoucher.</param>
        /// <param name="specialVoucher">specialVoucher.</param>
        public CommonVoucherUseRule(ActivityDiscountVoucher discountVoucher = default(ActivityDiscountVoucher), ActivityExchangeVoucher exchangeVoucher = default(ActivityExchangeVoucher), ActivityFixVoucher fixVoucher = default(ActivityFixVoucher), ActivitySpecialVoucher specialVoucher = default(ActivitySpecialVoucher))
        {
            this.DiscountVoucher = discountVoucher;
            this.ExchangeVoucher = exchangeVoucher;
            this.FixVoucher = fixVoucher;
            this.SpecialVoucher = specialVoucher;
        }

        /// <summary>
        /// Gets or Sets DiscountVoucher
        /// </summary>
        [DataMember(Name = "discount_voucher", EmitDefaultValue = false)]
        public ActivityDiscountVoucher DiscountVoucher { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeVoucher
        /// </summary>
        [DataMember(Name = "exchange_voucher", EmitDefaultValue = false)]
        public ActivityExchangeVoucher ExchangeVoucher { get; set; }

        /// <summary>
        /// Gets or Sets FixVoucher
        /// </summary>
        [DataMember(Name = "fix_voucher", EmitDefaultValue = false)]
        public ActivityFixVoucher FixVoucher { get; set; }

        /// <summary>
        /// Gets or Sets SpecialVoucher
        /// </summary>
        [DataMember(Name = "special_voucher", EmitDefaultValue = false)]
        public ActivitySpecialVoucher SpecialVoucher { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonVoucherUseRule {\n");
            sb.Append("  DiscountVoucher: ").Append(DiscountVoucher).Append("\n");
            sb.Append("  ExchangeVoucher: ").Append(ExchangeVoucher).Append("\n");
            sb.Append("  FixVoucher: ").Append(FixVoucher).Append("\n");
            sb.Append("  SpecialVoucher: ").Append(SpecialVoucher).Append("\n");
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
            return this.Equals(input as CommonVoucherUseRule);
        }

        /// <summary>
        /// Returns true if CommonVoucherUseRule instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonVoucherUseRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonVoucherUseRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiscountVoucher == input.DiscountVoucher ||
                    (this.DiscountVoucher != null &&
                    this.DiscountVoucher.Equals(input.DiscountVoucher))
                ) && 
                (
                    this.ExchangeVoucher == input.ExchangeVoucher ||
                    (this.ExchangeVoucher != null &&
                    this.ExchangeVoucher.Equals(input.ExchangeVoucher))
                ) && 
                (
                    this.FixVoucher == input.FixVoucher ||
                    (this.FixVoucher != null &&
                    this.FixVoucher.Equals(input.FixVoucher))
                ) && 
                (
                    this.SpecialVoucher == input.SpecialVoucher ||
                    (this.SpecialVoucher != null &&
                    this.SpecialVoucher.Equals(input.SpecialVoucher))
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
                if (this.DiscountVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountVoucher.GetHashCode();
                }
                if (this.ExchangeVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeVoucher.GetHashCode();
                }
                if (this.FixVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.FixVoucher.GetHashCode();
                }
                if (this.SpecialVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialVoucher.GetHashCode();
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
