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
    /// AlipayCommerceEcDepartmentDeleteModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcDepartmentDeleteModel")]
    public partial class AlipayCommerceEcDepartmentDeleteModel : IEquatable<AlipayCommerceEcDepartmentDeleteModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentDeleteModel" /> class.
        /// </summary>
        /// <param name="departmentId">部门id.</param>
        /// <param name="enterpriseId">企业id.</param>
        public AlipayCommerceEcDepartmentDeleteModel(string departmentId = default(string), string enterpriseId = default(string))
        {
            this.DepartmentId = departmentId;
            this.EnterpriseId = enterpriseId;
        }

        /// <summary>
        /// 部门id
        /// </summary>
        /// <value>部门id</value>
        [DataMember(Name = "department_id", EmitDefaultValue = false)]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcDepartmentDeleteModel {\n");
            sb.Append("  DepartmentId: ").Append(DepartmentId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcDepartmentDeleteModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcDepartmentDeleteModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcDepartmentDeleteModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcDepartmentDeleteModel input)
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
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
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
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
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
