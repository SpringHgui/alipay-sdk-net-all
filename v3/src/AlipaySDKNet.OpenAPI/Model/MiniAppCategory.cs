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
    /// MiniAppCategory
    /// </summary>
    [DataContract(Name = "MiniAppCategory")]
    public partial class MiniAppCategory : IEquatable<MiniAppCategory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppCategory" /> class.
        /// </summary>
        /// <param name="categoryId">类目id.</param>
        /// <param name="categoryName">类目名称.</param>
        /// <param name="hasChild">是否有子类目.</param>
        /// <param name="needLicense">是否需要营业执照.</param>
        /// <param name="needOutDoorPic">是否需要门头照.</param>
        /// <param name="needSpecialLicense">是否需要特许营业执照.</param>
        /// <param name="parentCategoryId">父类目id.</param>
        public MiniAppCategory(string categoryId = default(string), string categoryName = default(string), bool hasChild = default(bool), bool needLicense = default(bool), bool needOutDoorPic = default(bool), bool needSpecialLicense = default(bool), string parentCategoryId = default(string))
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.HasChild = hasChild;
            this.NeedLicense = needLicense;
            this.NeedOutDoorPic = needOutDoorPic;
            this.NeedSpecialLicense = needSpecialLicense;
            this.ParentCategoryId = parentCategoryId;
        }

        /// <summary>
        /// 类目id
        /// </summary>
        /// <value>类目id</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        /// <value>类目名称</value>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 是否有子类目
        /// </summary>
        /// <value>是否有子类目</value>
        [DataMember(Name = "has_child", EmitDefaultValue = true)]
        public bool HasChild { get; set; }

        /// <summary>
        /// 是否需要营业执照
        /// </summary>
        /// <value>是否需要营业执照</value>
        [DataMember(Name = "need_license", EmitDefaultValue = true)]
        public bool NeedLicense { get; set; }

        /// <summary>
        /// 是否需要门头照
        /// </summary>
        /// <value>是否需要门头照</value>
        [DataMember(Name = "need_out_door_pic", EmitDefaultValue = true)]
        public bool NeedOutDoorPic { get; set; }

        /// <summary>
        /// 是否需要特许营业执照
        /// </summary>
        /// <value>是否需要特许营业执照</value>
        [DataMember(Name = "need_special_license", EmitDefaultValue = true)]
        public bool NeedSpecialLicense { get; set; }

        /// <summary>
        /// 父类目id
        /// </summary>
        /// <value>父类目id</value>
        [DataMember(Name = "parent_category_id", EmitDefaultValue = false)]
        public string ParentCategoryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniAppCategory {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  HasChild: ").Append(HasChild).Append("\n");
            sb.Append("  NeedLicense: ").Append(NeedLicense).Append("\n");
            sb.Append("  NeedOutDoorPic: ").Append(NeedOutDoorPic).Append("\n");
            sb.Append("  NeedSpecialLicense: ").Append(NeedSpecialLicense).Append("\n");
            sb.Append("  ParentCategoryId: ").Append(ParentCategoryId).Append("\n");
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
            return this.Equals(input as MiniAppCategory);
        }

        /// <summary>
        /// Returns true if MiniAppCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniAppCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniAppCategory input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.HasChild == input.HasChild ||
                    this.HasChild.Equals(input.HasChild)
                ) && 
                (
                    this.NeedLicense == input.NeedLicense ||
                    this.NeedLicense.Equals(input.NeedLicense)
                ) && 
                (
                    this.NeedOutDoorPic == input.NeedOutDoorPic ||
                    this.NeedOutDoorPic.Equals(input.NeedOutDoorPic)
                ) && 
                (
                    this.NeedSpecialLicense == input.NeedSpecialLicense ||
                    this.NeedSpecialLicense.Equals(input.NeedSpecialLicense)
                ) && 
                (
                    this.ParentCategoryId == input.ParentCategoryId ||
                    (this.ParentCategoryId != null &&
                    this.ParentCategoryId.Equals(input.ParentCategoryId))
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
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasChild.GetHashCode();
                hashCode = (hashCode * 59) + this.NeedLicense.GetHashCode();
                hashCode = (hashCode * 59) + this.NeedOutDoorPic.GetHashCode();
                hashCode = (hashCode * 59) + this.NeedSpecialLicense.GetHashCode();
                if (this.ParentCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentCategoryId.GetHashCode();
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
