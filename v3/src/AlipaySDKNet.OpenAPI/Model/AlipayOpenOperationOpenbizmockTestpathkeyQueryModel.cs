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
    /// AlipayOpenOperationOpenbizmockTestpathkeyQueryModel
    /// </summary>
    [DataContract(Name = "AlipayOpenOperationOpenbizmockTestpathkeyQueryModel")]
    public partial class AlipayOpenOperationOpenbizmockTestpathkeyQueryModel : IEquatable<AlipayOpenOperationOpenbizmockTestpathkeyQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenOperationOpenbizmockTestpathkeyQueryModel" /> class.
        /// </summary>
        /// <param name="d">4.</param>
        /// <param name="e">1.</param>
        /// <param name="testPrice">1.</param>
        public AlipayOpenOperationOpenbizmockTestpathkeyQueryModel(string d = default(string), string e = default(string), string testPrice = default(string))
        {
            this.D = d;
            this.E = e;
            this.TestPrice = testPrice;
        }

        /// <summary>
        /// 4
        /// </summary>
        /// <value>4</value>
        [DataMember(Name = "d", EmitDefaultValue = false)]
        public string D { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "e", EmitDefaultValue = false)]
        public string E { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "test_price", EmitDefaultValue = false)]
        public string TestPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenOperationOpenbizmockTestpathkeyQueryModel {\n");
            sb.Append("  D: ").Append(D).Append("\n");
            sb.Append("  E: ").Append(E).Append("\n");
            sb.Append("  TestPrice: ").Append(TestPrice).Append("\n");
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
            return this.Equals(input as AlipayOpenOperationOpenbizmockTestpathkeyQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenOperationOpenbizmockTestpathkeyQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenOperationOpenbizmockTestpathkeyQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenOperationOpenbizmockTestpathkeyQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.D == input.D ||
                    (this.D != null &&
                    this.D.Equals(input.D))
                ) && 
                (
                    this.E == input.E ||
                    (this.E != null &&
                    this.E.Equals(input.E))
                ) && 
                (
                    this.TestPrice == input.TestPrice ||
                    (this.TestPrice != null &&
                    this.TestPrice.Equals(input.TestPrice))
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
                if (this.D != null)
                {
                    hashCode = (hashCode * 59) + this.D.GetHashCode();
                }
                if (this.E != null)
                {
                    hashCode = (hashCode * 59) + this.E.GetHashCode();
                }
                if (this.TestPrice != null)
                {
                    hashCode = (hashCode * 59) + this.TestPrice.GetHashCode();
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
