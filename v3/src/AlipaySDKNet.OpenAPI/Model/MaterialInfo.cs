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
    /// MaterialInfo
    /// </summary>
    [DataContract(Name = "MaterialInfo")]
    public partial class MaterialInfo : IEquatable<MaterialInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaterialInfo" /> class.
        /// </summary>
        /// <param name="content">素材内容（素材地址或素材KEY）.</param>
        /// <param name="materialId">素材ID.</param>
        /// <param name="type">素材类型.</param>
        public MaterialInfo(string content = default(string), string materialId = default(string), string type = default(string))
        {
            this.Content = content;
            this.MaterialId = materialId;
            this.Type = type;
        }

        /// <summary>
        /// 素材内容（素材地址或素材KEY）
        /// </summary>
        /// <value>素材内容（素材地址或素材KEY）</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 素材ID
        /// </summary>
        /// <value>素材ID</value>
        [DataMember(Name = "material_id", EmitDefaultValue = false)]
        public string MaterialId { get; set; }

        /// <summary>
        /// 素材类型
        /// </summary>
        /// <value>素材类型</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MaterialInfo {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  MaterialId: ").Append(MaterialId).Append("\n");
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
            return this.Equals(input as MaterialInfo);
        }

        /// <summary>
        /// Returns true if MaterialInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MaterialInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaterialInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.MaterialId == input.MaterialId ||
                    (this.MaterialId != null &&
                    this.MaterialId.Equals(input.MaterialId))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.MaterialId != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialId.GetHashCode();
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
