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
    /// AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel" /> class.
        /// </summary>
        /// <param name="expenseConsumeInfo">expenseConsumeInfo.</param>
        /// <param name="expenseInvoiceInfo">expenseInvoiceInfo.</param>
        /// <param name="voucherInfo">voucherInfo.</param>
        public AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel(ExpenseConsumeInfo expenseConsumeInfo = default(ExpenseConsumeInfo), ExpenseInvoiceInfo expenseInvoiceInfo = default(ExpenseInvoiceInfo), ExpenseVoucherInfo voucherInfo = default(ExpenseVoucherInfo))
        {
            this.ExpenseConsumeInfo = expenseConsumeInfo;
            this.ExpenseInvoiceInfo = expenseInvoiceInfo;
            this.VoucherInfo = voucherInfo;
        }

        /// <summary>
        /// Gets or Sets ExpenseConsumeInfo
        /// </summary>
        [DataMember(Name = "expense_consume_info", EmitDefaultValue = false)]
        public ExpenseConsumeInfo ExpenseConsumeInfo { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseInvoiceInfo
        /// </summary>
        [DataMember(Name = "expense_invoice_info", EmitDefaultValue = false)]
        public ExpenseInvoiceInfo ExpenseInvoiceInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherInfo
        /// </summary>
        [DataMember(Name = "voucher_info", EmitDefaultValue = false)]
        public ExpenseVoucherInfo VoucherInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel {\n");
            sb.Append("  ExpenseConsumeInfo: ").Append(ExpenseConsumeInfo).Append("\n");
            sb.Append("  ExpenseInvoiceInfo: ").Append(ExpenseInvoiceInfo).Append("\n");
            sb.Append("  VoucherInfo: ").Append(VoucherInfo).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponseModel input)
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
                    this.ExpenseInvoiceInfo == input.ExpenseInvoiceInfo ||
                    (this.ExpenseInvoiceInfo != null &&
                    this.ExpenseInvoiceInfo.Equals(input.ExpenseInvoiceInfo))
                ) && 
                (
                    this.VoucherInfo == input.VoucherInfo ||
                    (this.VoucherInfo != null &&
                    this.VoucherInfo.Equals(input.VoucherInfo))
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
                if (this.ExpenseInvoiceInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseInvoiceInfo.GetHashCode();
                }
                if (this.VoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherInfo.GetHashCode();
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
