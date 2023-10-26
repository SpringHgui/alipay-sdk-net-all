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
    /// PaymentVoucherBelongMerchantInfo
    /// </summary>
    [DataContract(Name = "PaymentVoucherBelongMerchantInfo")]
    public partial class PaymentVoucherBelongMerchantInfo : IEquatable<PaymentVoucherBelongMerchantInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherBelongMerchantInfo" /> class.
        /// </summary>
        /// <param name="merchantId">商户支付宝id，默认品牌名和品牌logo将从该商户信息中获取.</param>
        /// <param name="merchantIdType">商户支付宝id类型。.</param>
        public PaymentVoucherBelongMerchantInfo(string merchantId = default(string), string merchantIdType = default(string))
        {
            this.MerchantId = merchantId;
            this.MerchantIdType = merchantIdType;
        }

        /// <summary>
        /// 商户支付宝id，默认品牌名和品牌logo将从该商户信息中获取
        /// </summary>
        /// <value>商户支付宝id，默认品牌名和品牌logo将从该商户信息中获取</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户支付宝id类型。
        /// </summary>
        /// <value>商户支付宝id类型。</value>
        [DataMember(Name = "merchant_id_type", EmitDefaultValue = false)]
        public string MerchantIdType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherBelongMerchantInfo {\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  MerchantIdType: ").Append(MerchantIdType).Append("\n");
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
            return this.Equals(input as PaymentVoucherBelongMerchantInfo);
        }

        /// <summary>
        /// Returns true if PaymentVoucherBelongMerchantInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherBelongMerchantInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherBelongMerchantInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.MerchantIdType == input.MerchantIdType ||
                    (this.MerchantIdType != null &&
                    this.MerchantIdType.Equals(input.MerchantIdType))
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
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.MerchantIdType != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantIdType.GetHashCode();
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
