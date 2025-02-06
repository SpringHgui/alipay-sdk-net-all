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
    /// SignField
    /// </summary>
    [DataContract(Name = "SignField")]
    public partial class SignField : IEquatable<SignField>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignField" /> class.
        /// </summary>
        /// <param name="autoExecute">平台自动签.</param>
        /// <param name="signer">signer.</param>
        /// <param name="structKey">模板组件id.</param>
        public SignField(string autoExecute = default(string), Signer signer = default(Signer), string structKey = default(string))
        {
            this.AutoExecute = autoExecute;
            this.Signer = signer;
            this.StructKey = structKey;
        }

        /// <summary>
        /// 平台自动签
        /// </summary>
        /// <value>平台自动签</value>
        [DataMember(Name = "auto_execute", EmitDefaultValue = false)]
        public string AutoExecute { get; set; }

        /// <summary>
        /// Gets or Sets Signer
        /// </summary>
        [DataMember(Name = "signer", EmitDefaultValue = false)]
        public Signer Signer { get; set; }

        /// <summary>
        /// 模板组件id
        /// </summary>
        /// <value>模板组件id</value>
        [DataMember(Name = "struct_key", EmitDefaultValue = false)]
        public string StructKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignField {\n");
            sb.Append("  AutoExecute: ").Append(AutoExecute).Append("\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
            sb.Append("  StructKey: ").Append(StructKey).Append("\n");
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
            return this.Equals(input as SignField);
        }

        /// <summary>
        /// Returns true if SignField instances are equal
        /// </summary>
        /// <param name="input">Instance of SignField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignField input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AutoExecute == input.AutoExecute ||
                    (this.AutoExecute != null &&
                    this.AutoExecute.Equals(input.AutoExecute))
                ) && 
                (
                    this.Signer == input.Signer ||
                    (this.Signer != null &&
                    this.Signer.Equals(input.Signer))
                ) && 
                (
                    this.StructKey == input.StructKey ||
                    (this.StructKey != null &&
                    this.StructKey.Equals(input.StructKey))
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
                if (this.AutoExecute != null)
                {
                    hashCode = (hashCode * 59) + this.AutoExecute.GetHashCode();
                }
                if (this.Signer != null)
                {
                    hashCode = (hashCode * 59) + this.Signer.GetHashCode();
                }
                if (this.StructKey != null)
                {
                    hashCode = (hashCode * 59) + this.StructKey.GetHashCode();
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
