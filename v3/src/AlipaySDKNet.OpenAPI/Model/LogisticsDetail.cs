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
    /// LogisticsDetail
    /// </summary>
    [DataContract(Name = "LogisticsDetail")]
    public partial class LogisticsDetail : IEquatable<LogisticsDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticsDetail" /> class.
        /// </summary>
        /// <param name="logisticsType">物流类型.</param>
        public LogisticsDetail(string logisticsType = default(string))
        {
            this.LogisticsType = logisticsType;
        }

        /// <summary>
        /// 物流类型
        /// </summary>
        /// <value>物流类型</value>
        [DataMember(Name = "logistics_type", EmitDefaultValue = false)]
        public string LogisticsType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogisticsDetail {\n");
            sb.Append("  LogisticsType: ").Append(LogisticsType).Append("\n");
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
            return this.Equals(input as LogisticsDetail);
        }

        /// <summary>
        /// Returns true if LogisticsDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of LogisticsDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogisticsDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogisticsType == input.LogisticsType ||
                    (this.LogisticsType != null &&
                    this.LogisticsType.Equals(input.LogisticsType))
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
                if (this.LogisticsType != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsType.GetHashCode();
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
