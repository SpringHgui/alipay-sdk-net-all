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
    /// AlipayCommerceEcEmployeeInfoModifyModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEmployeeInfoModifyModel")]
    public partial class AlipayCommerceEcEmployeeInfoModifyModel : IEquatable<AlipayCommerceEcEmployeeInfoModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeInfoModifyModel" /> class.
        /// </summary>
        /// <param name="departmentIds">员工所属部门。如果不传值，则不更新所属部门.</param>
        /// <param name="employeeEmail">员工邮箱。如果不传值，则不更新邮箱。.</param>
        /// <param name="employeeId">员工id.</param>
        /// <param name="employeeMobile">员工手机号。如果不传值，则不更新手机号。.</param>
        /// <param name="employeeName">员工姓名.</param>
        /// <param name="employeeNo">员工工号。如果不传值，则不更新工号。.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="profiles">个性化信息。如果不传值，则不更新个性化信息。 &lt;a href&#x3D;&#39;https://opendocs.alipay.com/pre-open/0ceh47?pathHash&#x3D;14fac87c&#39;&gt;详见文档&lt;/a&gt;.</param>
        /// <param name="roleList">角色列表，目前只支持填一种角色。如果不传值，则不更新角色。.</param>
        public AlipayCommerceEcEmployeeInfoModifyModel(List<string> departmentIds = default(List<string>), string employeeEmail = default(string), string employeeId = default(string), string employeeMobile = default(string), string employeeName = default(string), string employeeNo = default(string), string enterpriseId = default(string), string profiles = default(string), List<string> roleList = default(List<string>))
        {
            this.DepartmentIds = departmentIds;
            this.EmployeeEmail = employeeEmail;
            this.EmployeeId = employeeId;
            this.EmployeeMobile = employeeMobile;
            this.EmployeeName = employeeName;
            this.EmployeeNo = employeeNo;
            this.EnterpriseId = enterpriseId;
            this.Profiles = profiles;
            this.RoleList = roleList;
        }

        /// <summary>
        /// 员工所属部门。如果不传值，则不更新所属部门
        /// </summary>
        /// <value>员工所属部门。如果不传值，则不更新所属部门</value>
        [DataMember(Name = "department_ids", EmitDefaultValue = false)]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 员工邮箱。如果不传值，则不更新邮箱。
        /// </summary>
        /// <value>员工邮箱。如果不传值，则不更新邮箱。</value>
        [DataMember(Name = "employee_email", EmitDefaultValue = false)]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        /// <value>员工id</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工手机号。如果不传值，则不更新手机号。
        /// </summary>
        /// <value>员工手机号。如果不传值，则不更新手机号。</value>
        [DataMember(Name = "employee_mobile", EmitDefaultValue = false)]
        public string EmployeeMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        /// <value>员工姓名</value>
        [DataMember(Name = "employee_name", EmitDefaultValue = false)]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工工号。如果不传值，则不更新工号。
        /// </summary>
        /// <value>员工工号。如果不传值，则不更新工号。</value>
        [DataMember(Name = "employee_no", EmitDefaultValue = false)]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 个性化信息。如果不传值，则不更新个性化信息。 &lt;a href&#x3D;&#39;https://opendocs.alipay.com/pre-open/0ceh47?pathHash&#x3D;14fac87c&#39;&gt;详见文档&lt;/a&gt;
        /// </summary>
        /// <value>个性化信息。如果不传值，则不更新个性化信息。 &lt;a href&#x3D;&#39;https://opendocs.alipay.com/pre-open/0ceh47?pathHash&#x3D;14fac87c&#39;&gt;详见文档&lt;/a&gt;</value>
        [DataMember(Name = "profiles", EmitDefaultValue = false)]
        public string Profiles { get; set; }

        /// <summary>
        /// 角色列表，目前只支持填一种角色。如果不传值，则不更新角色。
        /// </summary>
        /// <value>角色列表，目前只支持填一种角色。如果不传值，则不更新角色。</value>
        [DataMember(Name = "role_list", EmitDefaultValue = false)]
        public List<string> RoleList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEmployeeInfoModifyModel {\n");
            sb.Append("  DepartmentIds: ").Append(DepartmentIds).Append("\n");
            sb.Append("  EmployeeEmail: ").Append(EmployeeEmail).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeMobile: ").Append(EmployeeMobile).Append("\n");
            sb.Append("  EmployeeName: ").Append(EmployeeName).Append("\n");
            sb.Append("  EmployeeNo: ").Append(EmployeeNo).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  RoleList: ").Append(RoleList).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEmployeeInfoModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEmployeeInfoModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEmployeeInfoModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEmployeeInfoModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepartmentIds == input.DepartmentIds ||
                    this.DepartmentIds != null &&
                    input.DepartmentIds != null &&
                    this.DepartmentIds.SequenceEqual(input.DepartmentIds)
                ) && 
                (
                    this.EmployeeEmail == input.EmployeeEmail ||
                    (this.EmployeeEmail != null &&
                    this.EmployeeEmail.Equals(input.EmployeeEmail))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EmployeeMobile == input.EmployeeMobile ||
                    (this.EmployeeMobile != null &&
                    this.EmployeeMobile.Equals(input.EmployeeMobile))
                ) && 
                (
                    this.EmployeeName == input.EmployeeName ||
                    (this.EmployeeName != null &&
                    this.EmployeeName.Equals(input.EmployeeName))
                ) && 
                (
                    this.EmployeeNo == input.EmployeeNo ||
                    (this.EmployeeNo != null &&
                    this.EmployeeNo.Equals(input.EmployeeNo))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.Profiles == input.Profiles ||
                    (this.Profiles != null &&
                    this.Profiles.Equals(input.Profiles))
                ) && 
                (
                    this.RoleList == input.RoleList ||
                    this.RoleList != null &&
                    input.RoleList != null &&
                    this.RoleList.SequenceEqual(input.RoleList)
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
                if (this.DepartmentIds != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentIds.GetHashCode();
                }
                if (this.EmployeeEmail != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeEmail.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EmployeeMobile != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeMobile.GetHashCode();
                }
                if (this.EmployeeName != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeName.GetHashCode();
                }
                if (this.EmployeeNo != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeNo.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.Profiles != null)
                {
                    hashCode = (hashCode * 59) + this.Profiles.GetHashCode();
                }
                if (this.RoleList != null)
                {
                    hashCode = (hashCode * 59) + this.RoleList.GetHashCode();
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
