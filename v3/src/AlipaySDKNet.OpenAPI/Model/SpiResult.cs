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
    /// SpiResult
    /// </summary>
    [DataContract(Name = "SpiResult")]
    public partial class SpiResult : IEquatable<SpiResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpiResult" /> class.
        /// </summary>
        /// <param name="bizCode">isv自定义业务代码.</param>
        /// <param name="spiId">spi唯一id.</param>
        public SpiResult(string bizCode = default(string), int spiId = default(int))
        {
            this.BizCode = bizCode;
            this.SpiId = spiId;
        }

        /// <summary>
        /// isv自定义业务代码
        /// </summary>
        /// <value>isv自定义业务代码</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// spi唯一id
        /// </summary>
        /// <value>spi唯一id</value>
        [DataMember(Name = "spi_id", EmitDefaultValue = false)]
        public int SpiId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpiResult {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  SpiId: ").Append(SpiId).Append("\n");
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
            return this.Equals(input as SpiResult);
        }

        /// <summary>
        /// Returns true if SpiResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SpiResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpiResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizCode == input.BizCode ||
                    (this.BizCode != null &&
                    this.BizCode.Equals(input.BizCode))
                ) && 
                (
                    this.SpiId == input.SpiId ||
                    this.SpiId.Equals(input.SpiId)
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
                if (this.BizCode != null)
                {
                    hashCode = (hashCode * 59) + this.BizCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SpiId.GetHashCode();
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
