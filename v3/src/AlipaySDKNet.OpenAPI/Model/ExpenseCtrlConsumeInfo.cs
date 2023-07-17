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
    /// ExpenseCtrlConsumeInfo
    /// </summary>
    [DataContract(Name = "ExpenseCtrlConsumeInfo")]
    public partial class ExpenseCtrlConsumeInfo : IEquatable<ExpenseCtrlConsumeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseCtrlConsumeInfo" /> class.
        /// </summary>
        /// <param name="expenseConsumeInfo">expenseConsumeInfo.</param>
        /// <param name="relatedEnterpriseConsumeList">关联凑票账单列表（开票限额，多次消费后合并开票）.</param>
        /// <param name="relatedEnterpriseInvoiceList">关联发票凭证对象.</param>
        public ExpenseCtrlConsumeInfo(ExpenseConsumeInfo expenseConsumeInfo = default(ExpenseConsumeInfo), List<ExpenseConsumeInfo> relatedEnterpriseConsumeList = default(List<ExpenseConsumeInfo>), List<ExpenseInvoiceInfo> relatedEnterpriseInvoiceList = default(List<ExpenseInvoiceInfo>))
        {
            this.ExpenseConsumeInfo = expenseConsumeInfo;
            this.RelatedEnterpriseConsumeList = relatedEnterpriseConsumeList;
            this.RelatedEnterpriseInvoiceList = relatedEnterpriseInvoiceList;
        }

        /// <summary>
        /// Gets or Sets ExpenseConsumeInfo
        /// </summary>
        [DataMember(Name = "expense_consume_info", EmitDefaultValue = false)]
        public ExpenseConsumeInfo ExpenseConsumeInfo { get; set; }

        /// <summary>
        /// 关联凑票账单列表（开票限额，多次消费后合并开票）
        /// </summary>
        /// <value>关联凑票账单列表（开票限额，多次消费后合并开票）</value>
        [DataMember(Name = "related_enterprise_consume_list", EmitDefaultValue = false)]
        public List<ExpenseConsumeInfo> RelatedEnterpriseConsumeList { get; set; }

        /// <summary>
        /// 关联发票凭证对象
        /// </summary>
        /// <value>关联发票凭证对象</value>
        [DataMember(Name = "related_enterprise_invoice_list", EmitDefaultValue = false)]
        public List<ExpenseInvoiceInfo> RelatedEnterpriseInvoiceList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseCtrlConsumeInfo {\n");
            sb.Append("  ExpenseConsumeInfo: ").Append(ExpenseConsumeInfo).Append("\n");
            sb.Append("  RelatedEnterpriseConsumeList: ").Append(RelatedEnterpriseConsumeList).Append("\n");
            sb.Append("  RelatedEnterpriseInvoiceList: ").Append(RelatedEnterpriseInvoiceList).Append("\n");
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
            return this.Equals(input as ExpenseCtrlConsumeInfo);
        }

        /// <summary>
        /// Returns true if ExpenseCtrlConsumeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseCtrlConsumeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseCtrlConsumeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpenseConsumeInfo == input.ExpenseConsumeInfo ||
                    (this.ExpenseConsumeInfo != null &&
                    this.ExpenseConsumeInfo.Equals(input.ExpenseConsumeInfo))
                ) && 
                (
                    this.RelatedEnterpriseConsumeList == input.RelatedEnterpriseConsumeList ||
                    this.RelatedEnterpriseConsumeList != null &&
                    input.RelatedEnterpriseConsumeList != null &&
                    this.RelatedEnterpriseConsumeList.SequenceEqual(input.RelatedEnterpriseConsumeList)
                ) && 
                (
                    this.RelatedEnterpriseInvoiceList == input.RelatedEnterpriseInvoiceList ||
                    this.RelatedEnterpriseInvoiceList != null &&
                    input.RelatedEnterpriseInvoiceList != null &&
                    this.RelatedEnterpriseInvoiceList.SequenceEqual(input.RelatedEnterpriseInvoiceList)
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
                if (this.ExpenseConsumeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseConsumeInfo.GetHashCode();
                }
                if (this.RelatedEnterpriseConsumeList != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedEnterpriseConsumeList.GetHashCode();
                }
                if (this.RelatedEnterpriseInvoiceList != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedEnterpriseInvoiceList.GetHashCode();
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
