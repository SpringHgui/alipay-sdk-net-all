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
    /// GoodsDetailDTO
    /// </summary>
    [DataContract(Name = "GoodsDetailDTO")]
    public partial class GoodsDetailDTO : IEquatable<GoodsDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsDetailDTO" /> class.
        /// </summary>
        /// <param name="goodsId">商品编号.</param>
        /// <param name="goodsName">商品名称.</param>
        /// <param name="price">商品单价。单位 元  精确到小数点后2位。.</param>
        /// <param name="quantity">商品数量.</param>
        public GoodsDetailDTO(string goodsId = default(string), string goodsName = default(string), string price = default(string), int quantity = default(int))
        {
            this.GoodsId = goodsId;
            this.GoodsName = goodsName;
            this.Price = price;
            this.Quantity = quantity;
        }

        /// <summary>
        /// 商品编号
        /// </summary>
        /// <value>商品编号</value>
        [DataMember(Name = "goods_id", EmitDefaultValue = false)]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品单价。单位 元  精确到小数点后2位。
        /// </summary>
        /// <value>商品单价。单位 元  精确到小数点后2位。</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>商品数量</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsDetailDTO {\n");
            sb.Append("  GoodsId: ").Append(GoodsId).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            return this.Equals(input as GoodsDetailDTO);
        }

        /// <summary>
        /// Returns true if GoodsDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsDetailDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsId == input.GoodsId ||
                    (this.GoodsId != null &&
                    this.GoodsId.Equals(input.GoodsId))
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
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
                if (this.GoodsId != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsId.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
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
