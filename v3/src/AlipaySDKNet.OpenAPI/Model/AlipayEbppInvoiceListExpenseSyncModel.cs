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
    /// AlipayEbppInvoiceListExpenseSyncModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceListExpenseSyncModel")]
    public partial class AlipayEbppInvoiceListExpenseSyncModel : IEquatable<AlipayEbppInvoiceListExpenseSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceListExpenseSyncModel" /> class.
        /// </summary>
        /// <param name="businessTime">报销进度变更时间.</param>
        /// <param name="expenseOrderNo">商户报销单据号.</param>
        /// <param name="expenseTaxNo">报销企业税号.</param>
        /// <param name="invoiceElementList">需要同步报销状态的发票列表.</param>
        /// <param name="memo">报销审批备注.</param>
        /// <param name="openId">用户uid.</param>
        /// <param name="status">EXPENSE_APPLY:报销申请提交;EXPENSE_APPROVAL_PASS:报销申请审核通过;EXPENSE_FINISHED:报销申请完成;EXPENSE_CANCEL:报销申请撤回.</param>
        /// <param name="userId">用户uid.</param>
        public AlipayEbppInvoiceListExpenseSyncModel(string businessTime = default(string), string expenseOrderNo = default(string), string expenseTaxNo = default(string), List<InvoiceElementStatusSyncOpenModel> invoiceElementList = default(List<InvoiceElementStatusSyncOpenModel>), string memo = default(string), string openId = default(string), string status = default(string), string userId = default(string))
        {
            this.BusinessTime = businessTime;
            this.ExpenseOrderNo = expenseOrderNo;
            this.ExpenseTaxNo = expenseTaxNo;
            this.InvoiceElementList = invoiceElementList;
            this.Memo = memo;
            this.OpenId = openId;
            this.Status = status;
            this.UserId = userId;
        }

        /// <summary>
        /// 报销进度变更时间
        /// </summary>
        /// <value>报销进度变更时间</value>
        [DataMember(Name = "business_time", EmitDefaultValue = false)]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 商户报销单据号
        /// </summary>
        /// <value>商户报销单据号</value>
        [DataMember(Name = "expense_order_no", EmitDefaultValue = false)]
        public string ExpenseOrderNo { get; set; }

        /// <summary>
        /// 报销企业税号
        /// </summary>
        /// <value>报销企业税号</value>
        [DataMember(Name = "expense_tax_no", EmitDefaultValue = false)]
        public string ExpenseTaxNo { get; set; }

        /// <summary>
        /// 需要同步报销状态的发票列表
        /// </summary>
        /// <value>需要同步报销状态的发票列表</value>
        [DataMember(Name = "invoice_element_list", EmitDefaultValue = false)]
        public List<InvoiceElementStatusSyncOpenModel> InvoiceElementList { get; set; }

        /// <summary>
        /// 报销审批备注
        /// </summary>
        /// <value>报销审批备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        /// <value>用户uid</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// EXPENSE_APPLY:报销申请提交;EXPENSE_APPROVAL_PASS:报销申请审核通过;EXPENSE_FINISHED:报销申请完成;EXPENSE_CANCEL:报销申请撤回
        /// </summary>
        /// <value>EXPENSE_APPLY:报销申请提交;EXPENSE_APPROVAL_PASS:报销申请审核通过;EXPENSE_FINISHED:报销申请完成;EXPENSE_CANCEL:报销申请撤回</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户uid
        /// </summary>
        /// <value>用户uid</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceListExpenseSyncModel {\n");
            sb.Append("  BusinessTime: ").Append(BusinessTime).Append("\n");
            sb.Append("  ExpenseOrderNo: ").Append(ExpenseOrderNo).Append("\n");
            sb.Append("  ExpenseTaxNo: ").Append(ExpenseTaxNo).Append("\n");
            sb.Append("  InvoiceElementList: ").Append(InvoiceElementList).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceListExpenseSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceListExpenseSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceListExpenseSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceListExpenseSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessTime == input.BusinessTime ||
                    (this.BusinessTime != null &&
                    this.BusinessTime.Equals(input.BusinessTime))
                ) && 
                (
                    this.ExpenseOrderNo == input.ExpenseOrderNo ||
                    (this.ExpenseOrderNo != null &&
                    this.ExpenseOrderNo.Equals(input.ExpenseOrderNo))
                ) && 
                (
                    this.ExpenseTaxNo == input.ExpenseTaxNo ||
                    (this.ExpenseTaxNo != null &&
                    this.ExpenseTaxNo.Equals(input.ExpenseTaxNo))
                ) && 
                (
                    this.InvoiceElementList == input.InvoiceElementList ||
                    this.InvoiceElementList != null &&
                    input.InvoiceElementList != null &&
                    this.InvoiceElementList.SequenceEqual(input.InvoiceElementList)
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.BusinessTime != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessTime.GetHashCode();
                }
                if (this.ExpenseOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseOrderNo.GetHashCode();
                }
                if (this.ExpenseTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseTaxNo.GetHashCode();
                }
                if (this.InvoiceElementList != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceElementList.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
