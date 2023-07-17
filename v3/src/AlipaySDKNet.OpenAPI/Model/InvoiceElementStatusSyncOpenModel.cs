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
    /// InvoiceElementStatusSyncOpenModel
    /// </summary>
    [DataContract(Name = "InvoiceElementStatusSyncOpenModel")]
    public partial class InvoiceElementStatusSyncOpenModel : IEquatable<InvoiceElementStatusSyncOpenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceElementStatusSyncOpenModel" /> class.
        /// </summary>
        /// <param name="applyId">同步申请id，每次发起同步时生成，isv每次请求需要保证唯一.</param>
        /// <param name="expenseDetailUrl">报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供.</param>
        /// <param name="invoiceCode">发票代码.</param>
        /// <param name="invoiceNo">发票号码.</param>
        public InvoiceElementStatusSyncOpenModel(string applyId = default(string), string expenseDetailUrl = default(string), string invoiceCode = default(string), string invoiceNo = default(string))
        {
            this.ApplyId = applyId;
            this.ExpenseDetailUrl = expenseDetailUrl;
            this.InvoiceCode = invoiceCode;
            this.InvoiceNo = invoiceNo;
        }

        /// <summary>
        /// 同步申请id，每次发起同步时生成，isv每次请求需要保证唯一
        /// </summary>
        /// <value>同步申请id，每次发起同步时生成，isv每次请求需要保证唯一</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供
        /// </summary>
        /// <value>报销详情地址，提供用户通过发票管家查看报销进度的地址  如果报销企业入驻发票管家时需要isv传入报销详情地址，则必须提供</value>
        [DataMember(Name = "expense_detail_url", EmitDefaultValue = false)]
        public string ExpenseDetailUrl { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        /// <value>发票代码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceElementStatusSyncOpenModel {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  ExpenseDetailUrl: ").Append(ExpenseDetailUrl).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
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
            return this.Equals(input as InvoiceElementStatusSyncOpenModel);
        }

        /// <summary>
        /// Returns true if InvoiceElementStatusSyncOpenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceElementStatusSyncOpenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceElementStatusSyncOpenModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.ExpenseDetailUrl == input.ExpenseDetailUrl ||
                    (this.ExpenseDetailUrl != null &&
                    this.ExpenseDetailUrl.Equals(input.ExpenseDetailUrl))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.ExpenseDetailUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseDetailUrl.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
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
