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
    /// EcVoucherInfo
    /// </summary>
    [DataContract(Name = "EcVoucherInfo")]
    public partial class EcVoucherInfo : IEquatable<EcVoucherInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcVoucherInfo" /> class.
        /// </summary>
        /// <param name="accountId">共同账户ID.</param>
        /// <param name="employeeId">员工ID，汇总发票该字段无效.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="openId">员工支付宝UID.</param>
        /// <param name="userId">员工支付宝UID.</param>
        /// <param name="voucherContent">凭证内容.</param>
        /// <param name="voucherDate">凭证创建时间，格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="voucherId">凭证ID，幂等用.</param>
        /// <param name="voucherSource">凭证来源.</param>
        /// <param name="voucherType">凭证类型.</param>
        public EcVoucherInfo(string accountId = default(string), string employeeId = default(string), string enterpriseId = default(string), string openId = default(string), string userId = default(string), string voucherContent = default(string), string voucherDate = default(string), string voucherId = default(string), string voucherSource = default(string), string voucherType = default(string))
        {
            this.AccountId = accountId;
            this.EmployeeId = employeeId;
            this.EnterpriseId = enterpriseId;
            this.OpenId = openId;
            this.UserId = userId;
            this.VoucherContent = voucherContent;
            this.VoucherDate = voucherDate;
            this.VoucherId = voucherId;
            this.VoucherSource = voucherSource;
            this.VoucherType = voucherType;
        }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        /// <value>共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 员工ID，汇总发票该字段无效
        /// </summary>
        /// <value>员工ID，汇总发票该字段无效</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        /// <value>员工支付宝UID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        /// <value>员工支付宝UID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// 凭证内容
        /// </summary>
        /// <value>凭证内容</value>
        [DataMember(Name = "voucher_content", EmitDefaultValue = false)]
        public string VoucherContent { get; set; }

        /// <summary>
        /// 凭证创建时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>凭证创建时间，格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "voucher_date", EmitDefaultValue = false)]
        public string VoucherDate { get; set; }

        /// <summary>
        /// 凭证ID，幂等用
        /// </summary>
        /// <value>凭证ID，幂等用</value>
        [DataMember(Name = "voucher_id", EmitDefaultValue = false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// 凭证来源
        /// </summary>
        /// <value>凭证来源</value>
        [DataMember(Name = "voucher_source", EmitDefaultValue = false)]
        public string VoucherSource { get; set; }

        /// <summary>
        /// 凭证类型
        /// </summary>
        /// <value>凭证类型</value>
        [DataMember(Name = "voucher_type", EmitDefaultValue = false)]
        public string VoucherType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcVoucherInfo {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VoucherContent: ").Append(VoucherContent).Append("\n");
            sb.Append("  VoucherDate: ").Append(VoucherDate).Append("\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
            sb.Append("  VoucherSource: ").Append(VoucherSource).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
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
            return this.Equals(input as EcVoucherInfo);
        }

        /// <summary>
        /// Returns true if EcVoucherInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EcVoucherInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcVoucherInfo input)
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
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.VoucherContent == input.VoucherContent ||
                    (this.VoucherContent != null &&
                    this.VoucherContent.Equals(input.VoucherContent))
                ) && 
                (
                    this.VoucherDate == input.VoucherDate ||
                    (this.VoucherDate != null &&
                    this.VoucherDate.Equals(input.VoucherDate))
                ) && 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
                ) && 
                (
                    this.VoucherSource == input.VoucherSource ||
                    (this.VoucherSource != null &&
                    this.VoucherSource.Equals(input.VoucherSource))
                ) && 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
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
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.VoucherContent != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherContent.GetHashCode();
                }
                if (this.VoucherDate != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDate.GetHashCode();
                }
                if (this.VoucherId != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherId.GetHashCode();
                }
                if (this.VoucherSource != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSource.GetHashCode();
                }
                if (this.VoucherType != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherType.GetHashCode();
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
