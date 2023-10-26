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
    /// MCardDetail
    /// </summary>
    [DataContract(Name = "MCardDetail")]
    public partial class MCardDetail : IEquatable<MCardDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MCardDetail" /> class.
        /// </summary>
        /// <param name="availableAmount">储值卡可用余额.</param>
        /// <param name="name">储值卡名称.</param>
        /// <param name="payAmount">储值卡支付金额.</param>
        public MCardDetail(string availableAmount = default(string), string name = default(string), string payAmount = default(string))
        {
            this.AvailableAmount = availableAmount;
            this.Name = name;
            this.PayAmount = payAmount;
        }

        /// <summary>
        /// 储值卡可用余额
        /// </summary>
        /// <value>储值卡可用余额</value>
        [DataMember(Name = "available_amount", EmitDefaultValue = false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 储值卡名称
        /// </summary>
        /// <value>储值卡名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 储值卡支付金额
        /// </summary>
        /// <value>储值卡支付金额</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MCardDetail {\n");
            sb.Append("  AvailableAmount: ").Append(AvailableAmount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
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
            return this.Equals(input as MCardDetail);
        }

        /// <summary>
        /// Returns true if MCardDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of MCardDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MCardDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableAmount == input.AvailableAmount ||
                    (this.AvailableAmount != null &&
                    this.AvailableAmount.Equals(input.AvailableAmount))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
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
                if (this.AvailableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableAmount.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
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
