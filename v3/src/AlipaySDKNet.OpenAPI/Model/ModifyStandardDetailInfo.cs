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
    /// ModifyStandardDetailInfo
    /// </summary>
    [DataContract(Name = "ModifyStandardDetailInfo")]
    public partial class ModifyStandardDetailInfo : IEquatable<ModifyStandardDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyStandardDetailInfo" /> class.
        /// </summary>
        /// <param name="addStandardList">新增的使用规则列表.</param>
        /// <param name="deleteStandardIdList">待删除的使用规则id列表.</param>
        /// <param name="modifyStandardList">待修改的使用规则信息列表.</param>
        public ModifyStandardDetailInfo(List<StandardInfo> addStandardList = default(List<StandardInfo>), List<string> deleteStandardIdList = default(List<string>), List<ModifyStandardInfo> modifyStandardList = default(List<ModifyStandardInfo>))
        {
            this.AddStandardList = addStandardList;
            this.DeleteStandardIdList = deleteStandardIdList;
            this.ModifyStandardList = modifyStandardList;
        }

        /// <summary>
        /// 新增的使用规则列表
        /// </summary>
        /// <value>新增的使用规则列表</value>
        [DataMember(Name = "add_standard_list", EmitDefaultValue = false)]
        public List<StandardInfo> AddStandardList { get; set; }

        /// <summary>
        /// 待删除的使用规则id列表
        /// </summary>
        /// <value>待删除的使用规则id列表</value>
        [DataMember(Name = "delete_standard_id_list", EmitDefaultValue = false)]
        public List<string> DeleteStandardIdList { get; set; }

        /// <summary>
        /// 待修改的使用规则信息列表
        /// </summary>
        /// <value>待修改的使用规则信息列表</value>
        [DataMember(Name = "modify_standard_list", EmitDefaultValue = false)]
        public List<ModifyStandardInfo> ModifyStandardList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ModifyStandardDetailInfo {\n");
            sb.Append("  AddStandardList: ").Append(AddStandardList).Append("\n");
            sb.Append("  DeleteStandardIdList: ").Append(DeleteStandardIdList).Append("\n");
            sb.Append("  ModifyStandardList: ").Append(ModifyStandardList).Append("\n");
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
            return this.Equals(input as ModifyStandardDetailInfo);
        }

        /// <summary>
        /// Returns true if ModifyStandardDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifyStandardDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyStandardDetailInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddStandardList == input.AddStandardList ||
                    this.AddStandardList != null &&
                    input.AddStandardList != null &&
                    this.AddStandardList.SequenceEqual(input.AddStandardList)
                ) && 
                (
                    this.DeleteStandardIdList == input.DeleteStandardIdList ||
                    this.DeleteStandardIdList != null &&
                    input.DeleteStandardIdList != null &&
                    this.DeleteStandardIdList.SequenceEqual(input.DeleteStandardIdList)
                ) && 
                (
                    this.ModifyStandardList == input.ModifyStandardList ||
                    this.ModifyStandardList != null &&
                    input.ModifyStandardList != null &&
                    this.ModifyStandardList.SequenceEqual(input.ModifyStandardList)
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
                if (this.AddStandardList != null)
                {
                    hashCode = (hashCode * 59) + this.AddStandardList.GetHashCode();
                }
                if (this.DeleteStandardIdList != null)
                {
                    hashCode = (hashCode * 59) + this.DeleteStandardIdList.GetHashCode();
                }
                if (this.ModifyStandardList != null)
                {
                    hashCode = (hashCode * 59) + this.ModifyStandardList.GetHashCode();
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
