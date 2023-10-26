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
    /// AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="expenseConsumeInfoList">企业查询到的员工账单列表.</param>
        public AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel(List<ExpenseConsumeInfo> expenseConsumeInfoList = default(List<ExpenseConsumeInfo>))
        {
            this.ExpenseConsumeInfoList = expenseConsumeInfoList;
        }

        /// <summary>
        /// 企业查询到的员工账单列表
        /// </summary>
        /// <value>企业查询到的员工账单列表</value>
        [DataMember(Name = "expense_consume_info_list", EmitDefaultValue = false)]
        public List<ExpenseConsumeInfo> ExpenseConsumeInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel {\n");
            sb.Append("  ExpenseConsumeInfoList: ").Append(ExpenseConsumeInfoList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeConsumeBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpenseConsumeInfoList == input.ExpenseConsumeInfoList ||
                    this.ExpenseConsumeInfoList != null &&
                    input.ExpenseConsumeInfoList != null &&
                    this.ExpenseConsumeInfoList.SequenceEqual(input.ExpenseConsumeInfoList)
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
                if (this.ExpenseConsumeInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseConsumeInfoList.GetHashCode();
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
