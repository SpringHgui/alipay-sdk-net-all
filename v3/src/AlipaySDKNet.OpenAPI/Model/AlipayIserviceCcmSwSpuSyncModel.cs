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
    /// AlipayIserviceCcmSwSpuSyncModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmSwSpuSyncModel")]
    public partial class AlipayIserviceCcmSwSpuSyncModel : IEquatable<AlipayIserviceCcmSwSpuSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwSpuSyncModel" /> class.
        /// </summary>
        /// <param name="attribute">商品属性列表.</param>
        /// <param name="brand">商品品牌.</param>
        /// <param name="category">商品类目，用于商品库中分类.</param>
        /// <param name="description">商品描述.</param>
        /// <param name="icon">商品图片链接 特殊可选规则：is_delete&#x3D;false的情况下必填.</param>
        /// <param name="isDelete">默认为false，为true，表示删除知识点.</param>
        /// <param name="libraryId">知识库id.</param>
        /// <param name="libraryName">知识库名称.</param>
        /// <param name="linkUrl">商品链接 特殊可选规则：is_delete&#x3D;false的情况下必填.</param>
        /// <param name="originalPrice">商品原价.</param>
        /// <param name="price">商品售价 特殊可选规则：is_delete&#x3D;false的情况下必填.</param>
        /// <param name="spuId">商品ID.</param>
        /// <param name="status">商品状态：AVAILABLE 表示可售卖,SOLD_OUT为售罄/不可卖，默认可售卖.</param>
        /// <param name="title">商品名称 特殊可选规则：is_delete&#x3D;false的情况下必填.</param>
        public AlipayIserviceCcmSwSpuSyncModel(List<SpuAttribute> attribute = default(List<SpuAttribute>), string brand = default(string), string category = default(string), string description = default(string), string icon = default(string), string isDelete = default(string), int libraryId = default(int), string libraryName = default(string), string linkUrl = default(string), string originalPrice = default(string), string price = default(string), string spuId = default(string), string status = default(string), string title = default(string))
        {
            this.Attribute = attribute;
            this.Brand = brand;
            this.Category = category;
            this.Description = description;
            this.Icon = icon;
            this.IsDelete = isDelete;
            this.LibraryId = libraryId;
            this.LibraryName = libraryName;
            this.LinkUrl = linkUrl;
            this.OriginalPrice = originalPrice;
            this.Price = price;
            this.SpuId = spuId;
            this.Status = status;
            this.Title = title;
        }

        /// <summary>
        /// 商品属性列表
        /// </summary>
        /// <value>商品属性列表</value>
        [DataMember(Name = "attribute", EmitDefaultValue = false)]
        public List<SpuAttribute> Attribute { get; set; }

        /// <summary>
        /// 商品品牌
        /// </summary>
        /// <value>商品品牌</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// 商品类目，用于商品库中分类
        /// </summary>
        /// <value>商品类目，用于商品库中分类</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <value>商品描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 商品图片链接 特殊可选规则：is_delete&#x3D;false的情况下必填
        /// </summary>
        /// <value>商品图片链接 特殊可选规则：is_delete&#x3D;false的情况下必填</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// 默认为false，为true，表示删除知识点
        /// </summary>
        /// <value>默认为false，为true，表示删除知识点</value>
        [DataMember(Name = "is_delete", EmitDefaultValue = false)]
        public string IsDelete { get; set; }

        /// <summary>
        /// 知识库id
        /// </summary>
        /// <value>知识库id</value>
        [DataMember(Name = "library_id", EmitDefaultValue = false)]
        public int LibraryId { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        /// <value>知识库名称</value>
        [DataMember(Name = "library_name", EmitDefaultValue = false)]
        public string LibraryName { get; set; }

        /// <summary>
        /// 商品链接 特殊可选规则：is_delete&#x3D;false的情况下必填
        /// </summary>
        /// <value>商品链接 特殊可选规则：is_delete&#x3D;false的情况下必填</value>
        [DataMember(Name = "link_url", EmitDefaultValue = false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 商品原价
        /// </summary>
        /// <value>商品原价</value>
        [DataMember(Name = "original_price", EmitDefaultValue = false)]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品售价 特殊可选规则：is_delete&#x3D;false的情况下必填
        /// </summary>
        /// <value>商品售价 特殊可选规则：is_delete&#x3D;false的情况下必填</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        /// <value>商品ID</value>
        [DataMember(Name = "spu_id", EmitDefaultValue = false)]
        public string SpuId { get; set; }

        /// <summary>
        /// 商品状态：AVAILABLE 表示可售卖,SOLD_OUT为售罄/不可卖，默认可售卖
        /// </summary>
        /// <value>商品状态：AVAILABLE 表示可售卖,SOLD_OUT为售罄/不可卖，默认可售卖</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 商品名称 特殊可选规则：is_delete&#x3D;false的情况下必填
        /// </summary>
        /// <value>商品名称 特殊可选规则：is_delete&#x3D;false的情况下必填</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwSpuSyncModel {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  IsDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  LibraryName: ").Append(LibraryName).Append("\n");
            sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SpuId: ").Append(SpuId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmSwSpuSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwSpuSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwSpuSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwSpuSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attribute == input.Attribute ||
                    this.Attribute != null &&
                    input.Attribute != null &&
                    this.Attribute.SequenceEqual(input.Attribute)
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.IsDelete == input.IsDelete ||
                    (this.IsDelete != null &&
                    this.IsDelete.Equals(input.IsDelete))
                ) && 
                (
                    this.LibraryId == input.LibraryId ||
                    this.LibraryId.Equals(input.LibraryId)
                ) && 
                (
                    this.LibraryName == input.LibraryName ||
                    (this.LibraryName != null &&
                    this.LibraryName.Equals(input.LibraryName))
                ) && 
                (
                    this.LinkUrl == input.LinkUrl ||
                    (this.LinkUrl != null &&
                    this.LinkUrl.Equals(input.LinkUrl))
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    (this.OriginalPrice != null &&
                    this.OriginalPrice.Equals(input.OriginalPrice))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.SpuId == input.SpuId ||
                    (this.SpuId != null &&
                    this.SpuId.Equals(input.SpuId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Attribute != null)
                {
                    hashCode = (hashCode * 59) + this.Attribute.GetHashCode();
                }
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.IsDelete != null)
                {
                    hashCode = (hashCode * 59) + this.IsDelete.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LibraryId.GetHashCode();
                if (this.LibraryName != null)
                {
                    hashCode = (hashCode * 59) + this.LibraryName.GetHashCode();
                }
                if (this.LinkUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LinkUrl.GetHashCode();
                }
                if (this.OriginalPrice != null)
                {
                    hashCode = (hashCode * 59) + this.OriginalPrice.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.SpuId != null)
                {
                    hashCode = (hashCode * 59) + this.SpuId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
