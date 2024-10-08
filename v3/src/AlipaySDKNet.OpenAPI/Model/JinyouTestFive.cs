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
    /// JinyouTestFive
    /// </summary>
    [DataContract(Name = "JinyouTestFive")]
    public partial class JinyouTestFive : IEquatable<JinyouTestFive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JinyouTestFive" /> class.
        /// </summary>
        /// <param name="f1F">f1F.</param>
        /// <param name="f2F">f2F.</param>
        /// <param name="f3Openid">1.</param>
        /// <param name="f3Y">1.</param>
        /// <param name="f4N">3.</param>
        public JinyouTestFive(JinyouTestFour f1F = default(JinyouTestFour), JinyouTestThree f2F = default(JinyouTestThree), string f3Openid = default(string), string f3Y = default(string), string f4N = default(string))
        {
            this.F1F = f1F;
            this.F2F = f2F;
            this.F3Openid = f3Openid;
            this.F3Y = f3Y;
            this.F4N = f4N;
        }

        /// <summary>
        /// Gets or Sets F1F
        /// </summary>
        [DataMember(Name = "f_1_f", EmitDefaultValue = false)]
        public JinyouTestFour F1F { get; set; }

        /// <summary>
        /// Gets or Sets F2F
        /// </summary>
        [DataMember(Name = "f_2_f", EmitDefaultValue = false)]
        public JinyouTestThree F2F { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "f_3_openid", EmitDefaultValue = false)]
        public string F3Openid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "f_3_y", EmitDefaultValue = false)]
        public string F3Y { get; set; }

        /// <summary>
        /// 3
        /// </summary>
        /// <value>3</value>
        [DataMember(Name = "f_4_n", EmitDefaultValue = false)]
        public string F4N { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JinyouTestFive {\n");
            sb.Append("  F1F: ").Append(F1F).Append("\n");
            sb.Append("  F2F: ").Append(F2F).Append("\n");
            sb.Append("  F3Openid: ").Append(F3Openid).Append("\n");
            sb.Append("  F3Y: ").Append(F3Y).Append("\n");
            sb.Append("  F4N: ").Append(F4N).Append("\n");
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
            return this.Equals(input as JinyouTestFive);
        }

        /// <summary>
        /// Returns true if JinyouTestFive instances are equal
        /// </summary>
        /// <param name="input">Instance of JinyouTestFive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JinyouTestFive input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.F1F == input.F1F ||
                    (this.F1F != null &&
                    this.F1F.Equals(input.F1F))
                ) && 
                (
                    this.F2F == input.F2F ||
                    (this.F2F != null &&
                    this.F2F.Equals(input.F2F))
                ) && 
                (
                    this.F3Openid == input.F3Openid ||
                    (this.F3Openid != null &&
                    this.F3Openid.Equals(input.F3Openid))
                ) && 
                (
                    this.F3Y == input.F3Y ||
                    (this.F3Y != null &&
                    this.F3Y.Equals(input.F3Y))
                ) && 
                (
                    this.F4N == input.F4N ||
                    (this.F4N != null &&
                    this.F4N.Equals(input.F4N))
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
                if (this.F1F != null)
                {
                    hashCode = (hashCode * 59) + this.F1F.GetHashCode();
                }
                if (this.F2F != null)
                {
                    hashCode = (hashCode * 59) + this.F2F.GetHashCode();
                }
                if (this.F3Openid != null)
                {
                    hashCode = (hashCode * 59) + this.F3Openid.GetHashCode();
                }
                if (this.F3Y != null)
                {
                    hashCode = (hashCode * 59) + this.F3Y.GetHashCode();
                }
                if (this.F4N != null)
                {
                    hashCode = (hashCode * 59) + this.F4N.GetHashCode();
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
