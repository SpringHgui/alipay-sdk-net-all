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
    /// GoodsDetailIstd
    /// </summary>
    [DataContract(Name = "GoodsDetailIstd")]
    public partial class GoodsDetailIstd : IEquatable<GoodsDetailIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsDetailIstd" /> class.
        /// </summary>
        /// <param name="count">商品数量.</param>
        /// <param name="name">商品名称.</param>
        /// <param name="price">商品单价.</param>
        /// <param name="unit">商品单位.</param>
        public GoodsDetailIstd(int count = default(int), string name = default(string), string price = default(string), string unit = default(string))
        {
            this.Count = count;
            this.Name = name;
            this.Price = price;
            this.Unit = unit;
        }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>商品数量</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 商品单价
        /// </summary>
        /// <value>商品单价</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品单位
        /// </summary>
        /// <value>商品单位</value>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsDetailIstd {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
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
            return this.Equals(input as GoodsDetailIstd);
        }

        /// <summary>
        /// Returns true if GoodsDetailIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsDetailIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsDetailIstd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
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
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Unit != null)
                {
                    hashCode = (hashCode * 59) + this.Unit.GetHashCode();
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
