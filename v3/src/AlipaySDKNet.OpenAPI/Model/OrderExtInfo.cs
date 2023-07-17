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
    /// OrderExtInfo
    /// </summary>
    [DataContract(Name = "OrderExtInfo")]
    public partial class OrderExtInfo : IEquatable<OrderExtInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExtInfo" /> class.
        /// </summary>
        /// <param name="extKey">键值.</param>
        /// <param name="extValue">值.</param>
        public OrderExtInfo(string extKey = default(string), string extValue = default(string))
        {
            this.ExtKey = extKey;
            this.ExtValue = extValue;
        }

        /// <summary>
        /// 键值
        /// </summary>
        /// <value>键值</value>
        [DataMember(Name = "ext_key", EmitDefaultValue = false)]
        public string ExtKey { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        /// <value>值</value>
        [DataMember(Name = "ext_value", EmitDefaultValue = false)]
        public string ExtValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderExtInfo {\n");
            sb.Append("  ExtKey: ").Append(ExtKey).Append("\n");
            sb.Append("  ExtValue: ").Append(ExtValue).Append("\n");
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
            return this.Equals(input as OrderExtInfo);
        }

        /// <summary>
        /// Returns true if OrderExtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderExtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderExtInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtKey == input.ExtKey ||
                    (this.ExtKey != null &&
                    this.ExtKey.Equals(input.ExtKey))
                ) && 
                (
                    this.ExtValue == input.ExtValue ||
                    (this.ExtValue != null &&
                    this.ExtValue.Equals(input.ExtValue))
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
                if (this.ExtKey != null)
                {
                    hashCode = (hashCode * 59) + this.ExtKey.GetHashCode();
                }
                if (this.ExtValue != null)
                {
                    hashCode = (hashCode * 59) + this.ExtValue.GetHashCode();
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
