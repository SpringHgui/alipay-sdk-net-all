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
    /// AlipayCommerceEcEmployeeTitleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEmployeeTitleModifyModel")]
    public partial class AlipayCommerceEcEmployeeTitleModifyModel : IEquatable<AlipayCommerceEcEmployeeTitleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeTitleModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账号id，与enterprise_id两者必填其一.</param>
        /// <param name="createBy">创建人.</param>
        /// <param name="employeeId">企业域定义的员工id，与user_id两者必填其一.</param>
        /// <param name="enterpriseId">企业域定义下的企业id，与accountId两者必填其一.</param>
        /// <param name="modifyBy">修改人.</param>
        /// <param name="newTitleId">修改后的抬头id.</param>
        /// <param name="oldTitleId">修改前的抬头id.</param>
        /// <param name="openId">支付宝open_id，与employee_id两者必填其一.</param>
        /// <param name="titleTag">员工抬头关系标.</param>
        /// <param name="userId">支付宝id2088，与employee_id两者必填其一.</param>
        public AlipayCommerceEcEmployeeTitleModifyModel(string accountId = default(string), string createBy = default(string), string employeeId = default(string), string enterpriseId = default(string), string modifyBy = default(string), string newTitleId = default(string), string oldTitleId = default(string), string openId = default(string), string titleTag = default(string), string userId = default(string))
        {
            this.AccountId = accountId;
            this.CreateBy = createBy;
            this.EmployeeId = employeeId;
            this.EnterpriseId = enterpriseId;
            this.ModifyBy = modifyBy;
            this.NewTitleId = newTitleId;
            this.OldTitleId = oldTitleId;
            this.OpenId = openId;
            this.TitleTag = titleTag;
            this.UserId = userId;
        }

        /// <summary>
        /// 共同账号id，与enterprise_id两者必填其一
        /// </summary>
        /// <value>共同账号id，与enterprise_id两者必填其一</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        /// <value>创建人</value>
        [DataMember(Name = "create_by", EmitDefaultValue = false)]
        public string CreateBy { get; set; }

        /// <summary>
        /// 企业域定义的员工id，与user_id两者必填其一
        /// </summary>
        /// <value>企业域定义的员工id，与user_id两者必填其一</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业域定义下的企业id，与accountId两者必填其一
        /// </summary>
        /// <value>企业域定义下的企业id，与accountId两者必填其一</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        /// <value>修改人</value>
        [DataMember(Name = "modify_by", EmitDefaultValue = false)]
        public string ModifyBy { get; set; }

        /// <summary>
        /// 修改后的抬头id
        /// </summary>
        /// <value>修改后的抬头id</value>
        [DataMember(Name = "new_title_id", EmitDefaultValue = false)]
        public string NewTitleId { get; set; }

        /// <summary>
        /// 修改前的抬头id
        /// </summary>
        /// <value>修改前的抬头id</value>
        [DataMember(Name = "old_title_id", EmitDefaultValue = false)]
        public string OldTitleId { get; set; }

        /// <summary>
        /// 支付宝open_id，与employee_id两者必填其一
        /// </summary>
        /// <value>支付宝open_id，与employee_id两者必填其一</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 员工抬头关系标
        /// </summary>
        /// <value>员工抬头关系标</value>
        [DataMember(Name = "title_tag", EmitDefaultValue = false)]
        public string TitleTag { get; set; }

        /// <summary>
        /// 支付宝id2088，与employee_id两者必填其一
        /// </summary>
        /// <value>支付宝id2088，与employee_id两者必填其一</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEmployeeTitleModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CreateBy: ").Append(CreateBy).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  ModifyBy: ").Append(ModifyBy).Append("\n");
            sb.Append("  NewTitleId: ").Append(NewTitleId).Append("\n");
            sb.Append("  OldTitleId: ").Append(OldTitleId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  TitleTag: ").Append(TitleTag).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEmployeeTitleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEmployeeTitleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEmployeeTitleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEmployeeTitleModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CreateBy == input.CreateBy ||
                    (this.CreateBy != null &&
                    this.CreateBy.Equals(input.CreateBy))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.ModifyBy == input.ModifyBy ||
                    (this.ModifyBy != null &&
                    this.ModifyBy.Equals(input.ModifyBy))
                ) && 
                (
                    this.NewTitleId == input.NewTitleId ||
                    (this.NewTitleId != null &&
                    this.NewTitleId.Equals(input.NewTitleId))
                ) && 
                (
                    this.OldTitleId == input.OldTitleId ||
                    (this.OldTitleId != null &&
                    this.OldTitleId.Equals(input.OldTitleId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.TitleTag == input.TitleTag ||
                    (this.TitleTag != null &&
                    this.TitleTag.Equals(input.TitleTag))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.CreateBy != null)
                {
                    hashCode = (hashCode * 59) + this.CreateBy.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.ModifyBy != null)
                {
                    hashCode = (hashCode * 59) + this.ModifyBy.GetHashCode();
                }
                if (this.NewTitleId != null)
                {
                    hashCode = (hashCode * 59) + this.NewTitleId.GetHashCode();
                }
                if (this.OldTitleId != null)
                {
                    hashCode = (hashCode * 59) + this.OldTitleId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.TitleTag != null)
                {
                    hashCode = (hashCode * 59) + this.TitleTag.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
