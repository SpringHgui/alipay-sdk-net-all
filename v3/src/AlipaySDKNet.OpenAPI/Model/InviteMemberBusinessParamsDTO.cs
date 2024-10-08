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
    /// InviteMemberBusinessParamsDTO
    /// </summary>
    [DataContract(Name = "InviteMemberBusinessParamsDTO")]
    public partial class InviteMemberBusinessParamsDTO : IEquatable<InviteMemberBusinessParamsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteMemberBusinessParamsDTO" /> class.
        /// </summary>
        /// <param name="employeeId">企业员工工卡.</param>
        /// <param name="fundExtInfo">fundExtInfo.</param>
        /// <param name="groupIdList">员工关联的群组ID，当前系统仅支持一个.</param>
        public InviteMemberBusinessParamsDTO(string employeeId = default(string), FundExtInfo fundExtInfo = default(FundExtInfo), List<string> groupIdList = default(List<string>))
        {
            this.EmployeeId = employeeId;
            this.FundExtInfo = fundExtInfo;
            this.GroupIdList = groupIdList;
        }

        /// <summary>
        /// 企业员工工卡
        /// </summary>
        /// <value>企业员工工卡</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// Gets or Sets FundExtInfo
        /// </summary>
        [DataMember(Name = "fund_ext_info", EmitDefaultValue = false)]
        public FundExtInfo FundExtInfo { get; set; }

        /// <summary>
        /// 员工关联的群组ID，当前系统仅支持一个
        /// </summary>
        /// <value>员工关联的群组ID，当前系统仅支持一个</value>
        [DataMember(Name = "group_id_list", EmitDefaultValue = false)]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InviteMemberBusinessParamsDTO {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  FundExtInfo: ").Append(FundExtInfo).Append("\n");
            sb.Append("  GroupIdList: ").Append(GroupIdList).Append("\n");
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
            return this.Equals(input as InviteMemberBusinessParamsDTO);
        }

        /// <summary>
        /// Returns true if InviteMemberBusinessParamsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of InviteMemberBusinessParamsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InviteMemberBusinessParamsDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.FundExtInfo == input.FundExtInfo ||
                    (this.FundExtInfo != null &&
                    this.FundExtInfo.Equals(input.FundExtInfo))
                ) && 
                (
                    this.GroupIdList == input.GroupIdList ||
                    this.GroupIdList != null &&
                    input.GroupIdList != null &&
                    this.GroupIdList.SequenceEqual(input.GroupIdList)
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
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.FundExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.FundExtInfo.GetHashCode();
                }
                if (this.GroupIdList != null)
                {
                    hashCode = (hashCode * 59) + this.GroupIdList.GetHashCode();
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
