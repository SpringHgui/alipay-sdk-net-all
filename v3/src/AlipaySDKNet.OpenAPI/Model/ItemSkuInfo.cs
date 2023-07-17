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
    /// ItemSkuInfo
    /// </summary>
    [DataContract(Name = "ItemSkuInfo")]
    public partial class ItemSkuInfo : IEquatable<ItemSkuInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemSkuInfo" /> class.
        /// </summary>
        /// <param name="costPrice">成本价，单位分.</param>
        /// <param name="extInfo">SKU扩展信息.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">更新时间.</param>
        /// <param name="itemId">商品id.</param>
        /// <param name="originalPrice">标价，单位分.</param>
        /// <param name="price">售价，单位分.</param>
        /// <param name="skuId">商品sku id.</param>
        /// <param name="status">商品SKU状态：EFFECT、INVALID.</param>
        public ItemSkuInfo(int costPrice = default(int), List<ItemExtInfo> extInfo = default(List<ItemExtInfo>), string gmtCreate = default(string), string gmtModified = default(string), string itemId = default(string), int originalPrice = default(int), int price = default(int), string skuId = default(string), string status = default(string))
        {
            this.CostPrice = costPrice;
            this.ExtInfo = extInfo;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.ItemId = itemId;
            this.OriginalPrice = originalPrice;
            this.Price = price;
            this.SkuId = skuId;
            this.Status = status;
        }

        /// <summary>
        /// 成本价，单位分
        /// </summary>
        /// <value>成本价，单位分</value>
        [DataMember(Name = "cost_price", EmitDefaultValue = false)]
        public int CostPrice { get; set; }

        /// <summary>
        /// SKU扩展信息
        /// </summary>
        /// <value>SKU扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <value>更新时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        /// <value>商品id</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        /// <value>标价，单位分</value>
        [DataMember(Name = "original_price", EmitDefaultValue = false)]
        public int OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        /// <value>售价，单位分</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// 商品sku id
        /// </summary>
        /// <value>商品sku id</value>
        [DataMember(Name = "sku_id", EmitDefaultValue = false)]
        public string SkuId { get; set; }

        /// <summary>
        /// 商品SKU状态：EFFECT、INVALID
        /// </summary>
        /// <value>商品SKU状态：EFFECT、INVALID</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemSkuInfo {\n");
            sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SkuId: ").Append(SkuId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as ItemSkuInfo);
        }

        /// <summary>
        /// Returns true if ItemSkuInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemSkuInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemSkuInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CostPrice == input.CostPrice ||
                    this.CostPrice.Equals(input.CostPrice)
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    this.OriginalPrice.Equals(input.OriginalPrice)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.SkuId == input.SkuId ||
                    (this.SkuId != null &&
                    this.SkuId.Equals(input.SkuId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                hashCode = (hashCode * 59) + this.CostPrice.GetHashCode();
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OriginalPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                if (this.SkuId != null)
                {
                    hashCode = (hashCode * 59) + this.SkuId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
