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
    /// AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel" /> class.
        /// </summary>
        /// <param name="accountId">企业ID.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="consumptionEnd">交易结束时间，格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="consumptionStart">交易开始时间，格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="employeeList">员工支付宝UID列表，单次传入最大员工数量为10.</param>
        /// <param name="employeeOpenIds">员工支付宝UID列表，单次传入最大员工数量为10.</param>
        public AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel(string accountId = default(string), string agreementNo = default(string), string consumptionEnd = default(string), string consumptionStart = default(string), List<string> employeeList = default(List<string>), List<string> employeeOpenIds = default(List<string>))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.ConsumptionEnd = consumptionEnd;
            this.ConsumptionStart = consumptionStart;
            this.EmployeeList = employeeList;
            this.EmployeeOpenIds = employeeOpenIds;
        }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 交易结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>交易结束时间，格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "consumption_end", EmitDefaultValue = false)]
        public string ConsumptionEnd { get; set; }

        /// <summary>
        /// 交易开始时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>交易开始时间，格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "consumption_start", EmitDefaultValue = false)]
        public string ConsumptionStart { get; set; }

        /// <summary>
        /// 员工支付宝UID列表，单次传入最大员工数量为10
        /// </summary>
        /// <value>员工支付宝UID列表，单次传入最大员工数量为10</value>
        [DataMember(Name = "employee_list", EmitDefaultValue = false)]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 员工支付宝UID列表，单次传入最大员工数量为10
        /// </summary>
        /// <value>员工支付宝UID列表，单次传入最大员工数量为10</value>
        [DataMember(Name = "employee_open_ids", EmitDefaultValue = false)]
        public List<string> EmployeeOpenIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  ConsumptionEnd: ").Append(ConsumptionEnd).Append("\n");
            sb.Append("  ConsumptionStart: ").Append(ConsumptionStart).Append("\n");
            sb.Append("  EmployeeList: ").Append(EmployeeList).Append("\n");
            sb.Append("  EmployeeOpenIds: ").Append(EmployeeOpenIds).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryModel input)
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
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.ConsumptionEnd == input.ConsumptionEnd ||
                    (this.ConsumptionEnd != null &&
                    this.ConsumptionEnd.Equals(input.ConsumptionEnd))
                ) && 
                (
                    this.ConsumptionStart == input.ConsumptionStart ||
                    (this.ConsumptionStart != null &&
                    this.ConsumptionStart.Equals(input.ConsumptionStart))
                ) && 
                (
                    this.EmployeeList == input.EmployeeList ||
                    this.EmployeeList != null &&
                    input.EmployeeList != null &&
                    this.EmployeeList.SequenceEqual(input.EmployeeList)
                ) && 
                (
                    this.EmployeeOpenIds == input.EmployeeOpenIds ||
                    this.EmployeeOpenIds != null &&
                    input.EmployeeOpenIds != null &&
                    this.EmployeeOpenIds.SequenceEqual(input.EmployeeOpenIds)
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.ConsumptionEnd != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumptionEnd.GetHashCode();
                }
                if (this.ConsumptionStart != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumptionStart.GetHashCode();
                }
                if (this.EmployeeList != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeList.GetHashCode();
                }
                if (this.EmployeeOpenIds != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeOpenIds.GetHashCode();
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
