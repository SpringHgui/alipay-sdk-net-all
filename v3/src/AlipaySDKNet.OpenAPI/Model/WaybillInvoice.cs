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
    /// WaybillInvoice
    /// </summary>
    [DataContract(Name = "WaybillInvoice")]
    public partial class WaybillInvoice : IEquatable<WaybillInvoice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaybillInvoice" /> class.
        /// </summary>
        /// <param name="waybillAmount">即时配送运单金额.</param>
        /// <param name="waybillNo">即时配送运单编号.</param>
        public WaybillInvoice(string waybillAmount = default(string), string waybillNo = default(string))
        {
            this.WaybillAmount = waybillAmount;
            this.WaybillNo = waybillNo;
        }

        /// <summary>
        /// 即时配送运单金额
        /// </summary>
        /// <value>即时配送运单金额</value>
        [DataMember(Name = "waybill_amount", EmitDefaultValue = false)]
        public string WaybillAmount { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        /// <value>即时配送运单编号</value>
        [DataMember(Name = "waybill_no", EmitDefaultValue = false)]
        public string WaybillNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaybillInvoice {\n");
            sb.Append("  WaybillAmount: ").Append(WaybillAmount).Append("\n");
            sb.Append("  WaybillNo: ").Append(WaybillNo).Append("\n");
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
            return this.Equals(input as WaybillInvoice);
        }

        /// <summary>
        /// Returns true if WaybillInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of WaybillInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaybillInvoice input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.WaybillAmount == input.WaybillAmount ||
                    (this.WaybillAmount != null &&
                    this.WaybillAmount.Equals(input.WaybillAmount))
                ) && 
                (
                    this.WaybillNo == input.WaybillNo ||
                    (this.WaybillNo != null &&
                    this.WaybillNo.Equals(input.WaybillNo))
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
                if (this.WaybillAmount != null)
                {
                    hashCode = (hashCode * 59) + this.WaybillAmount.GetHashCode();
                }
                if (this.WaybillNo != null)
                {
                    hashCode = (hashCode * 59) + this.WaybillNo.GetHashCode();
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
