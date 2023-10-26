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
    /// InteligentClauseTerm
    /// </summary>
    [DataContract(Name = "InteligentClauseTerm")]
    public partial class InteligentClauseTerm : IEquatable<InteligentClauseTerm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentClauseTerm" /> class.
        /// </summary>
        /// <param name="descriptions">说明描述内容.</param>
        /// <param name="title">说明title.</param>
        public InteligentClauseTerm(List<string> descriptions = default(List<string>), string title = default(string))
        {
            this.Descriptions = descriptions;
            this.Title = title;
        }

        /// <summary>
        /// 说明描述内容
        /// </summary>
        /// <value>说明描述内容</value>
        [DataMember(Name = "descriptions", EmitDefaultValue = false)]
        public List<string> Descriptions { get; set; }

        /// <summary>
        /// 说明title
        /// </summary>
        /// <value>说明title</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentClauseTerm {\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as InteligentClauseTerm);
        }

        /// <summary>
        /// Returns true if InteligentClauseTerm instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentClauseTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentClauseTerm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Descriptions == input.Descriptions ||
                    this.Descriptions != null &&
                    input.Descriptions != null &&
                    this.Descriptions.SequenceEqual(input.Descriptions)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.Descriptions != null)
                {
                    hashCode = (hashCode * 59) + this.Descriptions.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
