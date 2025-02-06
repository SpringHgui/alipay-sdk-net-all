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
    /// BoxBusinessDistrictModule
    /// </summary>
    [DataContract(Name = "BoxBusinessDistrictModule")]
    public partial class BoxBusinessDistrictModule : IEquatable<BoxBusinessDistrictModule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoxBusinessDistrictModule" /> class.
        /// </summary>
        /// <param name="businessDistrictInfos">商圈选择.</param>
        /// <param name="moduleId">模块配置ID.</param>
        /// <param name="moduleType">搜索直达模块类型.</param>
        public BoxBusinessDistrictModule(List<BoxBusinessDistrictInfo> businessDistrictInfos = default(List<BoxBusinessDistrictInfo>), string moduleId = default(string), string moduleType = default(string))
        {
            this.BusinessDistrictInfos = businessDistrictInfos;
            this.ModuleId = moduleId;
            this.ModuleType = moduleType;
        }

        /// <summary>
        /// 商圈选择
        /// </summary>
        /// <value>商圈选择</value>
        [DataMember(Name = "business_district_infos", EmitDefaultValue = false)]
        public List<BoxBusinessDistrictInfo> BusinessDistrictInfos { get; set; }

        /// <summary>
        /// 模块配置ID
        /// </summary>
        /// <value>模块配置ID</value>
        [DataMember(Name = "module_id", EmitDefaultValue = false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// 搜索直达模块类型
        /// </summary>
        /// <value>搜索直达模块类型</value>
        [DataMember(Name = "module_type", EmitDefaultValue = false)]
        public string ModuleType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BoxBusinessDistrictModule {\n");
            sb.Append("  BusinessDistrictInfos: ").Append(BusinessDistrictInfos).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  ModuleType: ").Append(ModuleType).Append("\n");
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
            return this.Equals(input as BoxBusinessDistrictModule);
        }

        /// <summary>
        /// Returns true if BoxBusinessDistrictModule instances are equal
        /// </summary>
        /// <param name="input">Instance of BoxBusinessDistrictModule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoxBusinessDistrictModule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessDistrictInfos == input.BusinessDistrictInfos ||
                    this.BusinessDistrictInfos != null &&
                    input.BusinessDistrictInfos != null &&
                    this.BusinessDistrictInfos.SequenceEqual(input.BusinessDistrictInfos)
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
                ) && 
                (
                    this.ModuleType == input.ModuleType ||
                    (this.ModuleType != null &&
                    this.ModuleType.Equals(input.ModuleType))
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
                if (this.BusinessDistrictInfos != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessDistrictInfos.GetHashCode();
                }
                if (this.ModuleId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                }
                if (this.ModuleType != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleType.GetHashCode();
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
