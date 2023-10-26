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
    /// VoucherGoodsQuantitySpecificationInfo
    /// </summary>
    [DataContract(Name = "VoucherGoodsQuantitySpecificationInfo")]
    public partial class VoucherGoodsQuantitySpecificationInfo : IEquatable<VoucherGoodsQuantitySpecificationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherGoodsQuantitySpecificationInfo" /> class.
        /// </summary>
        /// <param name="directionalType">定向类型用于规格设置，比如：FIX 表示 固定满X件，APPOINT 表示指定第N件.</param>
        /// <param name="specificationQuantity">数量.</param>
        /// <param name="specificationUnit">单位.</param>
        public VoucherGoodsQuantitySpecificationInfo(string directionalType = default(string), int specificationQuantity = default(int), string specificationUnit = default(string))
        {
            this.DirectionalType = directionalType;
            this.SpecificationQuantity = specificationQuantity;
            this.SpecificationUnit = specificationUnit;
        }

        /// <summary>
        /// 定向类型用于规格设置，比如：FIX 表示 固定满X件，APPOINT 表示指定第N件
        /// </summary>
        /// <value>定向类型用于规格设置，比如：FIX 表示 固定满X件，APPOINT 表示指定第N件</value>
        [DataMember(Name = "directional_type", EmitDefaultValue = false)]
        public string DirectionalType { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <value>数量</value>
        [DataMember(Name = "specification_quantity", EmitDefaultValue = false)]
        public int SpecificationQuantity { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        /// <value>单位</value>
        [DataMember(Name = "specification_unit", EmitDefaultValue = false)]
        public string SpecificationUnit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherGoodsQuantitySpecificationInfo {\n");
            sb.Append("  DirectionalType: ").Append(DirectionalType).Append("\n");
            sb.Append("  SpecificationQuantity: ").Append(SpecificationQuantity).Append("\n");
            sb.Append("  SpecificationUnit: ").Append(SpecificationUnit).Append("\n");
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
            return this.Equals(input as VoucherGoodsQuantitySpecificationInfo);
        }

        /// <summary>
        /// Returns true if VoucherGoodsQuantitySpecificationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherGoodsQuantitySpecificationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherGoodsQuantitySpecificationInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DirectionalType == input.DirectionalType ||
                    (this.DirectionalType != null &&
                    this.DirectionalType.Equals(input.DirectionalType))
                ) && 
                (
                    this.SpecificationQuantity == input.SpecificationQuantity ||
                    this.SpecificationQuantity.Equals(input.SpecificationQuantity)
                ) && 
                (
                    this.SpecificationUnit == input.SpecificationUnit ||
                    (this.SpecificationUnit != null &&
                    this.SpecificationUnit.Equals(input.SpecificationUnit))
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
                if (this.DirectionalType != null)
                {
                    hashCode = (hashCode * 59) + this.DirectionalType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SpecificationQuantity.GetHashCode();
                if (this.SpecificationUnit != null)
                {
                    hashCode = (hashCode * 59) + this.SpecificationUnit.GetHashCode();
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
