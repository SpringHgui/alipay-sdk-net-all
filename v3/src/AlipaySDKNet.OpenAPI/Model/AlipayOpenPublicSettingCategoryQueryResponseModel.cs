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
    /// AlipayOpenPublicSettingCategoryQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicSettingCategoryQueryResponseModel")]
    public partial class AlipayOpenPublicSettingCategoryQueryResponseModel : IEquatable<AlipayOpenPublicSettingCategoryQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicSettingCategoryQueryResponseModel" /> class.
        /// </summary>
        /// <param name="primaryCategory">已设置的一级行业分类名称。 .</param>
        /// <param name="secondaryCategory">已设置的二级行业分类名称。.</param>
        public AlipayOpenPublicSettingCategoryQueryResponseModel(string primaryCategory = default(string), string secondaryCategory = default(string))
        {
            this.PrimaryCategory = primaryCategory;
            this.SecondaryCategory = secondaryCategory;
        }

        /// <summary>
        /// 已设置的一级行业分类名称。 
        /// </summary>
        /// <value>已设置的一级行业分类名称。 </value>
        [DataMember(Name = "primary_category", EmitDefaultValue = false)]
        public string PrimaryCategory { get; set; }

        /// <summary>
        /// 已设置的二级行业分类名称。
        /// </summary>
        /// <value>已设置的二级行业分类名称。</value>
        [DataMember(Name = "secondary_category", EmitDefaultValue = false)]
        public string SecondaryCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicSettingCategoryQueryResponseModel {\n");
            sb.Append("  PrimaryCategory: ").Append(PrimaryCategory).Append("\n");
            sb.Append("  SecondaryCategory: ").Append(SecondaryCategory).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicSettingCategoryQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicSettingCategoryQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicSettingCategoryQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicSettingCategoryQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PrimaryCategory == input.PrimaryCategory ||
                    (this.PrimaryCategory != null &&
                    this.PrimaryCategory.Equals(input.PrimaryCategory))
                ) && 
                (
                    this.SecondaryCategory == input.SecondaryCategory ||
                    (this.SecondaryCategory != null &&
                    this.SecondaryCategory.Equals(input.SecondaryCategory))
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
                if (this.PrimaryCategory != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryCategory.GetHashCode();
                }
                if (this.SecondaryCategory != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryCategory.GetHashCode();
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
