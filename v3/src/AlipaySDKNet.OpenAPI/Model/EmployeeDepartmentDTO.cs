/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// EmployeeDepartmentDTO
    /// </summary>
    [DataContract(Name = "EmployeeDepartmentDTO")]
    public partial class EmployeeDepartmentDTO : IEquatable<EmployeeDepartmentDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDepartmentDTO" /> class.
        /// </summary>
        /// <param name="departmentId">部门id.</param>
        /// <param name="departmentName">部门名称.</param>
        public EmployeeDepartmentDTO(string departmentId = default(string), string departmentName = default(string))
        {
            this.DepartmentId = departmentId;
            this.DepartmentName = departmentName;
        }

        /// <summary>
        /// 部门id
        /// </summary>
        /// <value>部门id</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        /// <value>部门名称</value>
        [DataMember(Name = "department_name", EmitDefaultValue = false)]
        public string DepartmentName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeDepartmentDTO {\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  DepartmentName: ").Append(DepartmentName).Append("\n");
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
            return this.Equals(input as EmployeeDepartmentDTO);
        }

        /// <summary>
        /// Returns true if EmployeeDepartmentDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeDepartmentDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeDepartmentDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepartmentId == input.DepartmentId ||
                    (this.DepartmentId != null &&
                    this.DepartmentId.Equals(input.DepartmentId))
                ) && 
                (
                    this.DepartmentName == input.DepartmentName ||
                    (this.DepartmentName != null &&
                    this.DepartmentName.Equals(input.DepartmentName))
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
                if (this.DepartmentId != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentId.GetHashCode();
                }
                if (this.DepartmentName != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentName.GetHashCode();
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
