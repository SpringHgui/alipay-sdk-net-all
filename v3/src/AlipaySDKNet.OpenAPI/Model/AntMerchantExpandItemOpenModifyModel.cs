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
    /// AntMerchantExpandItemOpenModifyModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandItemOpenModifyModel")]
    public partial class AntMerchantExpandItemOpenModifyModel : IEquatable<AntMerchantExpandItemOpenModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemOpenModifyModel" /> class.
        /// </summary>
        /// <param name="description">商品描述.</param>
        /// <param name="extInfo">商品扩展信息（覆盖商品已存在扩展信息、具体KEY请参见产品文档）.</param>
        /// <param name="itemId">商品ID.</param>
        /// <param name="materialList">商品素材列表（会和商品已存在素材做差异化比较后做增删改操作）.</param>
        /// <param name="name">商品名称.</param>
        /// <param name="propertyList">商品属性列表（覆盖商品已存在属性）.</param>
        /// <param name="skuList">SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）.</param>
        /// <param name="standardCategoryId">商品所属标准类目ID，当 type 为STANDARD_GOODS（标品）时必填。 请填入 https://opendocs.alipay.com/mini/011lxt 小程序商品类目表中三级类目ID。.</param>
        /// <param name="status">商品状态.</param>
        /// <param name="type">商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）.</param>
        public AntMerchantExpandItemOpenModifyModel(string description = default(string), List<ItemExtInfo> extInfo = default(List<ItemExtInfo>), string itemId = default(string), List<MaterialModifyInfo> materialList = default(List<MaterialModifyInfo>), string name = default(string), List<ItemPropertyInfo> propertyList = default(List<ItemPropertyInfo>), List<SkuModifyInfo> skuList = default(List<SkuModifyInfo>), string standardCategoryId = default(string), string status = default(string), string type = default(string))
        {
            this.Description = description;
            this.ExtInfo = extInfo;
            this.ItemId = itemId;
            this.MaterialList = materialList;
            this.Name = name;
            this.PropertyList = propertyList;
            this.SkuList = skuList;
            this.StandardCategoryId = standardCategoryId;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// 商品描述
        /// </summary>
        /// <value>商品描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 商品扩展信息（覆盖商品已存在扩展信息、具体KEY请参见产品文档）
        /// </summary>
        /// <value>商品扩展信息（覆盖商品已存在扩展信息、具体KEY请参见产品文档）</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<ItemExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        /// <value>商品ID</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品素材列表（会和商品已存在素材做差异化比较后做增删改操作）
        /// </summary>
        /// <value>商品素材列表（会和商品已存在素材做差异化比较后做增删改操作）</value>
        [DataMember(Name = "material_list", EmitDefaultValue = false)]
        public List<MaterialModifyInfo> MaterialList { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 商品属性列表（覆盖商品已存在属性）
        /// </summary>
        /// <value>商品属性列表（覆盖商品已存在属性）</value>
        [DataMember(Name = "property_list", EmitDefaultValue = false)]
        public List<ItemPropertyInfo> PropertyList { get; set; }

        /// <summary>
        /// SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）
        /// </summary>
        /// <value>SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）</value>
        [DataMember(Name = "sku_list", EmitDefaultValue = false)]
        public List<SkuModifyInfo> SkuList { get; set; }

        /// <summary>
        /// 商品所属标准类目ID，当 type 为STANDARD_GOODS（标品）时必填。 请填入 https://opendocs.alipay.com/mini/011lxt 小程序商品类目表中三级类目ID。
        /// </summary>
        /// <value>商品所属标准类目ID，当 type 为STANDARD_GOODS（标品）时必填。 请填入 https://opendocs.alipay.com/mini/011lxt 小程序商品类目表中三级类目ID。</value>
        [DataMember(Name = "standard_category_id", EmitDefaultValue = false)]
        public string StandardCategoryId { get; set; }

        /// <summary>
        /// 商品状态
        /// </summary>
        /// <value>商品状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）
        /// </summary>
        /// <value>商品类型：STANDARD_GOODS（标品）、NON_STANDARD_GOODS（非标品）</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandItemOpenModifyModel {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  MaterialList: ").Append(MaterialList).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PropertyList: ").Append(PropertyList).Append("\n");
            sb.Append("  SkuList: ").Append(SkuList).Append("\n");
            sb.Append("  StandardCategoryId: ").Append(StandardCategoryId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AntMerchantExpandItemOpenModifyModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandItemOpenModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandItemOpenModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandItemOpenModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.MaterialList == input.MaterialList ||
                    this.MaterialList != null &&
                    input.MaterialList != null &&
                    this.MaterialList.SequenceEqual(input.MaterialList)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PropertyList == input.PropertyList ||
                    this.PropertyList != null &&
                    input.PropertyList != null &&
                    this.PropertyList.SequenceEqual(input.PropertyList)
                ) && 
                (
                    this.SkuList == input.SkuList ||
                    this.SkuList != null &&
                    input.SkuList != null &&
                    this.SkuList.SequenceEqual(input.SkuList)
                ) && 
                (
                    this.StandardCategoryId == input.StandardCategoryId ||
                    (this.StandardCategoryId != null &&
                    this.StandardCategoryId.Equals(input.StandardCategoryId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.MaterialList != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialList.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PropertyList != null)
                {
                    hashCode = (hashCode * 59) + this.PropertyList.GetHashCode();
                }
                if (this.SkuList != null)
                {
                    hashCode = (hashCode * 59) + this.SkuList.GetHashCode();
                }
                if (this.StandardCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardCategoryId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
