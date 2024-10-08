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
    /// AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel")]
    public partial class AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel : IEquatable<AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel" /> class.
        /// </summary>
        /// <param name="aggregationId">费控聚合关系ID.</param>
        public AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel(string aggregationId = default(string))
        {
            this.AggregationId = aggregationId;
        }

        /// <summary>
        /// 费控聚合关系ID
        /// </summary>
        /// <value>费控聚合关系ID</value>
        [DataMember(Name = "aggregation_id", EmitDefaultValue = false)]
        public string AggregationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel {\n");
            sb.Append("  AggregationId: ").Append(AggregationId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecontrolAggregationCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AggregationId == input.AggregationId ||
                    (this.AggregationId != null &&
                    this.AggregationId.Equals(input.AggregationId))
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
                if (this.AggregationId != null)
                {
                    hashCode = (hashCode * 59) + this.AggregationId.GetHashCode();
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
