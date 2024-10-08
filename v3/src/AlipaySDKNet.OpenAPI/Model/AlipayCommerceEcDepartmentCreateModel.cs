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
    /// AlipayCommerceEcDepartmentCreateModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcDepartmentCreateModel")]
    public partial class AlipayCommerceEcDepartmentCreateModel : IEquatable<AlipayCommerceEcDepartmentCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentCreateModel" /> class.
        /// </summary>
        /// <param name="departmentCode">部门编码.</param>
        /// <param name="departmentName">部门名称.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="parentDepartmentId">上级部门id.</param>
        public AlipayCommerceEcDepartmentCreateModel(string departmentCode = default(string), string departmentName = default(string), string enterpriseId = default(string), string parentDepartmentId = default(string))
        {
            this.DepartmentCode = departmentCode;
            this.DepartmentName = departmentName;
            this.EnterpriseId = enterpriseId;
            this.ParentDepartmentId = parentDepartmentId;
        }

        /// <summary>
        /// 部门编码
        /// </summary>
        /// <value>部门编码</value>
        [DataMember(Name = "department_code", EmitDefaultValue = false)]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        /// <value>部门名称</value>
        [DataMember(Name = "department_name", EmitDefaultValue = false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 上级部门id
        /// </summary>
        /// <value>上级部门id</value>
        [DataMember(Name = "parent_department_id", EmitDefaultValue = false)]
        public string ParentDepartmentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcDepartmentCreateModel {\n");
            sb.Append("  DepartmentCode: ").Append(DepartmentCode).Append("\n");
            sb.Append("  DepartmentName: ").Append(DepartmentName).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  ParentDepartmentId: ").Append(ParentDepartmentId).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcDepartmentCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcDepartmentCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcDepartmentCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcDepartmentCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepartmentCode == input.DepartmentCode ||
                    (this.DepartmentCode != null &&
                    this.DepartmentCode.Equals(input.DepartmentCode))
                ) && 
                (
                    this.DepartmentName == input.DepartmentName ||
                    (this.DepartmentName != null &&
                    this.DepartmentName.Equals(input.DepartmentName))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.ParentDepartmentId == input.ParentDepartmentId ||
                    (this.ParentDepartmentId != null &&
                    this.ParentDepartmentId.Equals(input.ParentDepartmentId))
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
                if (this.DepartmentCode != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentCode.GetHashCode();
                }
                if (this.DepartmentName != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentName.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.ParentDepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentDepartmentId.GetHashCode();
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
