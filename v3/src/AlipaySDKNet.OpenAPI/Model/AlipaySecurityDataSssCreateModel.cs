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
    /// AlipaySecurityDataSssCreateModel
    /// </summary>
    [DataContract(Name = "AlipaySecurityDataSssCreateModel")]
    public partial class AlipaySecurityDataSssCreateModel : IEquatable<AlipaySecurityDataSssCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityDataSssCreateModel" /> class.
        /// </summary>
        /// <param name="areaCode">body,可选，无openid，有枚举值，注意事项.</param>
        /// <param name="f">f.</param>
        public AlipaySecurityDataSssCreateModel(string areaCode = default(string), JinyoutestopenidThree f = default(JinyoutestopenidThree))
        {
            this.AreaCode = areaCode;
            this.F = f;
        }

        /// <summary>
        /// body,可选，无openid，有枚举值，注意事项
        /// </summary>
        /// <value>body,可选，无openid，有枚举值，注意事项</value>
        [DataMember(Name = "area_code", EmitDefaultValue = false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// Gets or Sets F
        /// </summary>
        [DataMember(Name = "f", EmitDefaultValue = false)]
        public JinyoutestopenidThree F { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySecurityDataSssCreateModel {\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  F: ").Append(F).Append("\n");
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
            return this.Equals(input as AlipaySecurityDataSssCreateModel);
        }

        /// <summary>
        /// Returns true if AlipaySecurityDataSssCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySecurityDataSssCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySecurityDataSssCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.F == input.F ||
                    (this.F != null &&
                    this.F.Equals(input.F))
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
                if (this.AreaCode != null)
                {
                    hashCode = (hashCode * 59) + this.AreaCode.GetHashCode();
                }
                if (this.F != null)
                {
                    hashCode = (hashCode * 59) + this.F.GetHashCode();
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
