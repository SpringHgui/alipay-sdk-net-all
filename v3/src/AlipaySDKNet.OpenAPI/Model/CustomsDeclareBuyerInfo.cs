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
    /// CustomsDeclareBuyerInfo
    /// </summary>
    [DataContract(Name = "CustomsDeclareBuyerInfo")]
    public partial class CustomsDeclareBuyerInfo : IEquatable<CustomsDeclareBuyerInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomsDeclareBuyerInfo" /> class.
        /// </summary>
        /// <param name="buyerCertNo">订购人身份证号。即订购人留在商户处的身份证信息.</param>
        /// <param name="buyerName">订购人姓名。即订购人留在商户处的姓名信息.</param>
        public CustomsDeclareBuyerInfo(string buyerCertNo = default(string), string buyerName = default(string))
        {
            this.BuyerCertNo = buyerCertNo;
            this.BuyerName = buyerName;
        }

        /// <summary>
        /// 订购人身份证号。即订购人留在商户处的身份证信息
        /// </summary>
        /// <value>订购人身份证号。即订购人留在商户处的身份证信息</value>
        [DataMember(Name = "buyer_cert_no", EmitDefaultValue = false)]
        public string BuyerCertNo { get; set; }

        /// <summary>
        /// 订购人姓名。即订购人留在商户处的姓名信息
        /// </summary>
        /// <value>订购人姓名。即订购人留在商户处的姓名信息</value>
        [DataMember(Name = "buyer_name", EmitDefaultValue = false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomsDeclareBuyerInfo {\n");
            sb.Append("  BuyerCertNo: ").Append(BuyerCertNo).Append("\n");
            sb.Append("  BuyerName: ").Append(BuyerName).Append("\n");
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
            return this.Equals(input as CustomsDeclareBuyerInfo);
        }

        /// <summary>
        /// Returns true if CustomsDeclareBuyerInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomsDeclareBuyerInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomsDeclareBuyerInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuyerCertNo == input.BuyerCertNo ||
                    (this.BuyerCertNo != null &&
                    this.BuyerCertNo.Equals(input.BuyerCertNo))
                ) && 
                (
                    this.BuyerName == input.BuyerName ||
                    (this.BuyerName != null &&
                    this.BuyerName.Equals(input.BuyerName))
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
                if (this.BuyerCertNo != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerCertNo.GetHashCode();
                }
                if (this.BuyerName != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerName.GetHashCode();
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
