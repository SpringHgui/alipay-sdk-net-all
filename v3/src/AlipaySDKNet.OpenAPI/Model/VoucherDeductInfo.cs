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
    /// VoucherDeductInfo
    /// </summary>
    [DataContract(Name = "VoucherDeductInfo")]
    public partial class VoucherDeductInfo : IEquatable<VoucherDeductInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherDeductInfo" /> class.
        /// </summary>
        /// <param name="customerDefineVoucherInfo">customerDefineVoucherInfo.</param>
        /// <param name="discountVoucherInfo">discountVoucherInfo.</param>
        /// <param name="exchangeVoucherInfo">exchangeVoucherInfo.</param>
        /// <param name="fixVoucherInfo">fixVoucherInfo.</param>
        /// <param name="specialVoucherInfo">specialVoucherInfo.</param>
        /// <param name="voucherType">券类型。.</param>
        public VoucherDeductInfo(CustomerDefineVoucherInfo customerDefineVoucherInfo = default(CustomerDefineVoucherInfo), DiscountVoucherInfo discountVoucherInfo = default(DiscountVoucherInfo), ExchangeVoucherInfo exchangeVoucherInfo = default(ExchangeVoucherInfo), FixVoucherInfo fixVoucherInfo = default(FixVoucherInfo), SpecialVoucherInfo specialVoucherInfo = default(SpecialVoucherInfo), string voucherType = default(string))
        {
            this.CustomerDefineVoucherInfo = customerDefineVoucherInfo;
            this.DiscountVoucherInfo = discountVoucherInfo;
            this.ExchangeVoucherInfo = exchangeVoucherInfo;
            this.FixVoucherInfo = fixVoucherInfo;
            this.SpecialVoucherInfo = specialVoucherInfo;
            this.VoucherType = voucherType;
        }

        /// <summary>
        /// Gets or Sets CustomerDefineVoucherInfo
        /// </summary>
        [DataMember(Name = "customer_define_voucher_info", EmitDefaultValue = false)]
        public CustomerDefineVoucherInfo CustomerDefineVoucherInfo { get; set; }

        /// <summary>
        /// Gets or Sets DiscountVoucherInfo
        /// </summary>
        [DataMember(Name = "discount_voucher_info", EmitDefaultValue = false)]
        public DiscountVoucherInfo DiscountVoucherInfo { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeVoucherInfo
        /// </summary>
        [DataMember(Name = "exchange_voucher_info", EmitDefaultValue = false)]
        public ExchangeVoucherInfo ExchangeVoucherInfo { get; set; }

        /// <summary>
        /// Gets or Sets FixVoucherInfo
        /// </summary>
        [DataMember(Name = "fix_voucher_info", EmitDefaultValue = false)]
        public FixVoucherInfo FixVoucherInfo { get; set; }

        /// <summary>
        /// Gets or Sets SpecialVoucherInfo
        /// </summary>
        [DataMember(Name = "special_voucher_info", EmitDefaultValue = false)]
        public SpecialVoucherInfo SpecialVoucherInfo { get; set; }

        /// <summary>
        /// 券类型。
        /// </summary>
        /// <value>券类型。</value>
        [DataMember(Name = "voucher_type", EmitDefaultValue = false)]
        public string VoucherType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherDeductInfo {\n");
            sb.Append("  CustomerDefineVoucherInfo: ").Append(CustomerDefineVoucherInfo).Append("\n");
            sb.Append("  DiscountVoucherInfo: ").Append(DiscountVoucherInfo).Append("\n");
            sb.Append("  ExchangeVoucherInfo: ").Append(ExchangeVoucherInfo).Append("\n");
            sb.Append("  FixVoucherInfo: ").Append(FixVoucherInfo).Append("\n");
            sb.Append("  SpecialVoucherInfo: ").Append(SpecialVoucherInfo).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
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
            return this.Equals(input as VoucherDeductInfo);
        }

        /// <summary>
        /// Returns true if VoucherDeductInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherDeductInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherDeductInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerDefineVoucherInfo == input.CustomerDefineVoucherInfo ||
                    (this.CustomerDefineVoucherInfo != null &&
                    this.CustomerDefineVoucherInfo.Equals(input.CustomerDefineVoucherInfo))
                ) && 
                (
                    this.DiscountVoucherInfo == input.DiscountVoucherInfo ||
                    (this.DiscountVoucherInfo != null &&
                    this.DiscountVoucherInfo.Equals(input.DiscountVoucherInfo))
                ) && 
                (
                    this.ExchangeVoucherInfo == input.ExchangeVoucherInfo ||
                    (this.ExchangeVoucherInfo != null &&
                    this.ExchangeVoucherInfo.Equals(input.ExchangeVoucherInfo))
                ) && 
                (
                    this.FixVoucherInfo == input.FixVoucherInfo ||
                    (this.FixVoucherInfo != null &&
                    this.FixVoucherInfo.Equals(input.FixVoucherInfo))
                ) && 
                (
                    this.SpecialVoucherInfo == input.SpecialVoucherInfo ||
                    (this.SpecialVoucherInfo != null &&
                    this.SpecialVoucherInfo.Equals(input.SpecialVoucherInfo))
                ) && 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
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
                if (this.CustomerDefineVoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerDefineVoucherInfo.GetHashCode();
                }
                if (this.DiscountVoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountVoucherInfo.GetHashCode();
                }
                if (this.ExchangeVoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeVoucherInfo.GetHashCode();
                }
                if (this.FixVoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.FixVoucherInfo.GetHashCode();
                }
                if (this.SpecialVoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialVoucherInfo.GetHashCode();
                }
                if (this.VoucherType != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherType.GetHashCode();
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
