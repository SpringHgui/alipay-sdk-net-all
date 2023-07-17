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
    /// AlipayBossFncInvoicereceiptBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncInvoicereceiptBatchqueryResponseModel")]
    public partial class AlipayBossFncInvoicereceiptBatchqueryResponseModel : IEquatable<AlipayBossFncInvoicereceiptBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncInvoicereceiptBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="resultSet">返回结果对象：可开票单据.</param>
        /// <param name="totalInvAmt">totalInvAmt.</param>
        /// <param name="totalInvedAmt">totalInvedAmt.</param>
        /// <param name="totalLinkInvoiceAmt">totalLinkInvoiceAmt.</param>
        public AlipayBossFncInvoicereceiptBatchqueryResponseModel(List<ArInvoiceReceiptOpenApiResponse> resultSet = default(List<ArInvoiceReceiptOpenApiResponse>), MultiCurrencyMoneyOpenApi totalInvAmt = default(MultiCurrencyMoneyOpenApi), MultiCurrencyMoneyOpenApi totalInvedAmt = default(MultiCurrencyMoneyOpenApi), MultiCurrencyMoneyOpenApi totalLinkInvoiceAmt = default(MultiCurrencyMoneyOpenApi))
        {
            this.ResultSet = resultSet;
            this.TotalInvAmt = totalInvAmt;
            this.TotalInvedAmt = totalInvedAmt;
            this.TotalLinkInvoiceAmt = totalLinkInvoiceAmt;
        }

        /// <summary>
        /// 返回结果对象：可开票单据
        /// </summary>
        /// <value>返回结果对象：可开票单据</value>
        [DataMember(Name = "result_set", EmitDefaultValue = false)]
        public List<ArInvoiceReceiptOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// Gets or Sets TotalInvAmt
        /// </summary>
        [DataMember(Name = "total_inv_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi TotalInvAmt { get; set; }

        /// <summary>
        /// Gets or Sets TotalInvedAmt
        /// </summary>
        [DataMember(Name = "total_inved_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi TotalInvedAmt { get; set; }

        /// <summary>
        /// Gets or Sets TotalLinkInvoiceAmt
        /// </summary>
        [DataMember(Name = "total_link_invoice_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi TotalLinkInvoiceAmt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncInvoicereceiptBatchqueryResponseModel {\n");
            sb.Append("  ResultSet: ").Append(ResultSet).Append("\n");
            sb.Append("  TotalInvAmt: ").Append(TotalInvAmt).Append("\n");
            sb.Append("  TotalInvedAmt: ").Append(TotalInvedAmt).Append("\n");
            sb.Append("  TotalLinkInvoiceAmt: ").Append(TotalLinkInvoiceAmt).Append("\n");
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
            return this.Equals(input as AlipayBossFncInvoicereceiptBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncInvoicereceiptBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncInvoicereceiptBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncInvoicereceiptBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResultSet == input.ResultSet ||
                    this.ResultSet != null &&
                    input.ResultSet != null &&
                    this.ResultSet.SequenceEqual(input.ResultSet)
                ) && 
                (
                    this.TotalInvAmt == input.TotalInvAmt ||
                    (this.TotalInvAmt != null &&
                    this.TotalInvAmt.Equals(input.TotalInvAmt))
                ) && 
                (
                    this.TotalInvedAmt == input.TotalInvedAmt ||
                    (this.TotalInvedAmt != null &&
                    this.TotalInvedAmt.Equals(input.TotalInvedAmt))
                ) && 
                (
                    this.TotalLinkInvoiceAmt == input.TotalLinkInvoiceAmt ||
                    (this.TotalLinkInvoiceAmt != null &&
                    this.TotalLinkInvoiceAmt.Equals(input.TotalLinkInvoiceAmt))
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
                if (this.ResultSet != null)
                {
                    hashCode = (hashCode * 59) + this.ResultSet.GetHashCode();
                }
                if (this.TotalInvAmt != null)
                {
                    hashCode = (hashCode * 59) + this.TotalInvAmt.GetHashCode();
                }
                if (this.TotalInvedAmt != null)
                {
                    hashCode = (hashCode * 59) + this.TotalInvedAmt.GetHashCode();
                }
                if (this.TotalLinkInvoiceAmt != null)
                {
                    hashCode = (hashCode * 59) + this.TotalLinkInvoiceAmt.GetHashCode();
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
