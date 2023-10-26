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
    /// AlipayOpenBizCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenBizCreateResponseModel")]
    public partial class AlipayOpenBizCreateResponseModel : IEquatable<AlipayOpenBizCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenBizCreateResponseModel" /> class.
        /// </summary>
        /// <param name="a">1.</param>
        /// <param name="b">b.</param>
        /// <param name="c">1.</param>
        public AlipayOpenBizCreateResponseModel(string a = default(string), GavintestNewonline b = default(GavintestNewonline), string c = default(string))
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "a", EmitDefaultValue = false)]
        public string A { get; set; }

        /// <summary>
        /// Gets or Sets B
        /// </summary>
        [DataMember(Name = "b", EmitDefaultValue = false)]
        public GavintestNewonline B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "c", EmitDefaultValue = false)]
        public string C { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenBizCreateResponseModel {\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  C: ").Append(C).Append("\n");
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
            return this.Equals(input as AlipayOpenBizCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenBizCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenBizCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenBizCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.A == input.A ||
                    (this.A != null &&
                    this.A.Equals(input.A))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
                ) && 
                (
                    this.C == input.C ||
                    (this.C != null &&
                    this.C.Equals(input.C))
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
                if (this.A != null)
                {
                    hashCode = (hashCode * 59) + this.A.GetHashCode();
                }
                if (this.B != null)
                {
                    hashCode = (hashCode * 59) + this.B.GetHashCode();
                }
                if (this.C != null)
                {
                    hashCode = (hashCode * 59) + this.C.GetHashCode();
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
