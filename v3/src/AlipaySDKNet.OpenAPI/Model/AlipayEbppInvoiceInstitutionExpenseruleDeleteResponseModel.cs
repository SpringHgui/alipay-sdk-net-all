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
    /// AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel")]
    public partial class AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel : IEquatable<AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel" /> class.
        /// </summary>
        /// <param name="result">删除是否成功.</param>
        public AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel(bool result = default(bool))
        {
            this.Result = result;
        }

        /// <summary>
        /// 删除是否成功
        /// </summary>
        /// <value>删除是否成功</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public bool Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionExpenseruleDeleteResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
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
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
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
