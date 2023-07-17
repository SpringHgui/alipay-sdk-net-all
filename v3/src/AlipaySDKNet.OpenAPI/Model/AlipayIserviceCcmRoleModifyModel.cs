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
    /// AlipayIserviceCcmRoleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmRoleModifyModel")]
    public partial class AlipayIserviceCcmRoleModifyModel : IEquatable<AlipayIserviceCcmRoleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmRoleModifyModel" /> class.
        /// </summary>
        /// <param name="ccsInstanceId">部门id（即租户实例ID、数据权限ID），不传默认使用租户id.</param>
        /// <param name="description">描述信息.</param>
        /// <param name="functionIds">角色关联额功能点id.</param>
        /// <param name="id">角色id.</param>
        /// <param name="updaterId">最后修改人id.</param>
        public AlipayIserviceCcmRoleModifyModel(string ccsInstanceId = default(string), string description = default(string), List<string> functionIds = default(List<string>), string id = default(string), string updaterId = default(string))
        {
            this.CcsInstanceId = ccsInstanceId;
            this.Description = description;
            this.FunctionIds = functionIds;
            this.Id = id;
            this.UpdaterId = updaterId;
        }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID），不传默认使用租户id
        /// </summary>
        /// <value>部门id（即租户实例ID、数据权限ID），不传默认使用租户id</value>
        [DataMember(Name = "ccs_instance_id", EmitDefaultValue = false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        /// <value>描述信息</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 角色关联额功能点id
        /// </summary>
        /// <value>角色关联额功能点id</value>
        [DataMember(Name = "function_ids", EmitDefaultValue = false)]
        public List<string> FunctionIds { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        /// <value>角色id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// 最后修改人id
        /// </summary>
        /// <value>最后修改人id</value>
        [DataMember(Name = "updater_id", EmitDefaultValue = false)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmRoleModifyModel {\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FunctionIds: ").Append(FunctionIds).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdaterId: ").Append(UpdaterId).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmRoleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmRoleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmRoleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmRoleModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CcsInstanceId == input.CcsInstanceId ||
                    (this.CcsInstanceId != null &&
                    this.CcsInstanceId.Equals(input.CcsInstanceId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FunctionIds == input.FunctionIds ||
                    this.FunctionIds != null &&
                    input.FunctionIds != null &&
                    this.FunctionIds.SequenceEqual(input.FunctionIds)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UpdaterId == input.UpdaterId ||
                    (this.UpdaterId != null &&
                    this.UpdaterId.Equals(input.UpdaterId))
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
                if (this.CcsInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FunctionIds != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionIds.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UpdaterId != null)
                {
                    hashCode = (hashCode * 59) + this.UpdaterId.GetHashCode();
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
