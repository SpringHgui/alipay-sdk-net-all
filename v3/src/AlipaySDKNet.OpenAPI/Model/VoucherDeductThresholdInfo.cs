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
    /// VoucherDeductThresholdInfo
    /// </summary>
    [DataContract(Name = "VoucherDeductThresholdInfo")]
    public partial class VoucherDeductThresholdInfo : IEquatable<VoucherDeductThresholdInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherDeductThresholdInfo" /> class.
        /// </summary>
        /// <param name="customerDefineVoucherThresholdDesc">自定义门槛描述.</param>
        /// <param name="voucherExpressInfo">voucherExpressInfo.</param>
        /// <param name="voucherGoodsQuantitySpecificationInfo">voucherGoodsQuantitySpecificationInfo.</param>
        public VoucherDeductThresholdInfo(string customerDefineVoucherThresholdDesc = default(string), VoucherExpressInfo voucherExpressInfo = default(VoucherExpressInfo), VoucherGoodsQuantitySpecificationInfo voucherGoodsQuantitySpecificationInfo = default(VoucherGoodsQuantitySpecificationInfo))
        {
            this.CustomerDefineVoucherThresholdDesc = customerDefineVoucherThresholdDesc;
            this.VoucherExpressInfo = voucherExpressInfo;
            this.VoucherGoodsQuantitySpecificationInfo = voucherGoodsQuantitySpecificationInfo;
        }

        /// <summary>
        /// 自定义门槛描述
        /// </summary>
        /// <value>自定义门槛描述</value>
        [DataMember(Name = "customer_define_voucher_threshold_desc", EmitDefaultValue = false)]
        public string CustomerDefineVoucherThresholdDesc { get; set; }

        /// <summary>
        /// Gets or Sets VoucherExpressInfo
        /// </summary>
        [DataMember(Name = "voucher_express_info", EmitDefaultValue = false)]
        public VoucherExpressInfo VoucherExpressInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherGoodsQuantitySpecificationInfo
        /// </summary>
        [DataMember(Name = "voucher_goods_quantity_specification_info", EmitDefaultValue = false)]
        public VoucherGoodsQuantitySpecificationInfo VoucherGoodsQuantitySpecificationInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherDeductThresholdInfo {\n");
            sb.Append("  CustomerDefineVoucherThresholdDesc: ").Append(CustomerDefineVoucherThresholdDesc).Append("\n");
            sb.Append("  VoucherExpressInfo: ").Append(VoucherExpressInfo).Append("\n");
            sb.Append("  VoucherGoodsQuantitySpecificationInfo: ").Append(VoucherGoodsQuantitySpecificationInfo).Append("\n");
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
            return this.Equals(input as VoucherDeductThresholdInfo);
        }

        /// <summary>
        /// Returns true if VoucherDeductThresholdInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherDeductThresholdInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherDeductThresholdInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerDefineVoucherThresholdDesc == input.CustomerDefineVoucherThresholdDesc ||
                    (this.CustomerDefineVoucherThresholdDesc != null &&
                    this.CustomerDefineVoucherThresholdDesc.Equals(input.CustomerDefineVoucherThresholdDesc))
                ) && 
                (
                    this.VoucherExpressInfo == input.VoucherExpressInfo ||
                    (this.VoucherExpressInfo != null &&
                    this.VoucherExpressInfo.Equals(input.VoucherExpressInfo))
                ) && 
                (
                    this.VoucherGoodsQuantitySpecificationInfo == input.VoucherGoodsQuantitySpecificationInfo ||
                    (this.VoucherGoodsQuantitySpecificationInfo != null &&
                    this.VoucherGoodsQuantitySpecificationInfo.Equals(input.VoucherGoodsQuantitySpecificationInfo))
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
                if (this.CustomerDefineVoucherThresholdDesc != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerDefineVoucherThresholdDesc.GetHashCode();
                }
                if (this.VoucherExpressInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherExpressInfo.GetHashCode();
                }
                if (this.VoucherGoodsQuantitySpecificationInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherGoodsQuantitySpecificationInfo.GetHashCode();
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
