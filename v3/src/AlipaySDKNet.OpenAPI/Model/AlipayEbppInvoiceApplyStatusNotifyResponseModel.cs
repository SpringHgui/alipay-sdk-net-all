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
    /// AlipayEbppInvoiceApplyStatusNotifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceApplyStatusNotifyResponseModel")]
    public partial class AlipayEbppInvoiceApplyStatusNotifyResponseModel : IEquatable<AlipayEbppInvoiceApplyStatusNotifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplyStatusNotifyResponseModel" /> class.
        /// </summary>
        /// <param name="missingInvoices">update_success&#x3D;false时返回。 该申请下存在未归集成功的发票。即：attach_invoices 中携带的发票存在未回传成功的发票。 此时调用方，需先调用发票回传接口，完成发票回传。然后再重试此接口。.</param>
        /// <param name="updateSuccess">事务执行结果，true成功，false失败.</param>
        public AlipayEbppInvoiceApplyStatusNotifyResponseModel(List<InvoiceUkDTO> missingInvoices = default(List<InvoiceUkDTO>), bool updateSuccess = default(bool))
        {
            this.MissingInvoices = missingInvoices;
            this.UpdateSuccess = updateSuccess;
        }

        /// <summary>
        /// update_success&#x3D;false时返回。 该申请下存在未归集成功的发票。即：attach_invoices 中携带的发票存在未回传成功的发票。 此时调用方，需先调用发票回传接口，完成发票回传。然后再重试此接口。
        /// </summary>
        /// <value>update_success&#x3D;false时返回。 该申请下存在未归集成功的发票。即：attach_invoices 中携带的发票存在未回传成功的发票。 此时调用方，需先调用发票回传接口，完成发票回传。然后再重试此接口。</value>
        [DataMember(Name = "missing_invoices", EmitDefaultValue = false)]
        public List<InvoiceUkDTO> MissingInvoices { get; set; }

        /// <summary>
        /// 事务执行结果，true成功，false失败
        /// </summary>
        /// <value>事务执行结果，true成功，false失败</value>
        [DataMember(Name = "update_success", EmitDefaultValue = true)]
        public bool UpdateSuccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceApplyStatusNotifyResponseModel {\n");
            sb.Append("  MissingInvoices: ").Append(MissingInvoices).Append("\n");
            sb.Append("  UpdateSuccess: ").Append(UpdateSuccess).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceApplyStatusNotifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceApplyStatusNotifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceApplyStatusNotifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceApplyStatusNotifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MissingInvoices == input.MissingInvoices ||
                    this.MissingInvoices != null &&
                    input.MissingInvoices != null &&
                    this.MissingInvoices.SequenceEqual(input.MissingInvoices)
                ) && 
                (
                    this.UpdateSuccess == input.UpdateSuccess ||
                    this.UpdateSuccess.Equals(input.UpdateSuccess)
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
                if (this.MissingInvoices != null)
                {
                    hashCode = (hashCode * 59) + this.MissingInvoices.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdateSuccess.GetHashCode();
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
