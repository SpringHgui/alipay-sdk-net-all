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
    /// SignMerchantParams
    /// </summary>
    [DataContract(Name = "SignMerchantParams")]
    public partial class SignMerchantParams : IEquatable<SignMerchantParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignMerchantParams" /> class.
        /// </summary>
        /// <param name="subMerchantId">子商户的商户id.</param>
        /// <param name="subMerchantName">子商户的商户名称.</param>
        /// <param name="subMerchantServiceDescription">子商户的服务描述.</param>
        /// <param name="subMerchantServiceName">子商户的服务名称.</param>
        public SignMerchantParams(string subMerchantId = default(string), string subMerchantName = default(string), string subMerchantServiceDescription = default(string), string subMerchantServiceName = default(string))
        {
            this.SubMerchantId = subMerchantId;
            this.SubMerchantName = subMerchantName;
            this.SubMerchantServiceDescription = subMerchantServiceDescription;
            this.SubMerchantServiceName = subMerchantServiceName;
        }

        /// <summary>
        /// 子商户的商户id
        /// </summary>
        /// <value>子商户的商户id</value>
        [DataMember(Name = "sub_merchant_id", EmitDefaultValue = false)]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 子商户的商户名称
        /// </summary>
        /// <value>子商户的商户名称</value>
        [DataMember(Name = "sub_merchant_name", EmitDefaultValue = false)]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 子商户的服务描述
        /// </summary>
        /// <value>子商户的服务描述</value>
        [DataMember(Name = "sub_merchant_service_description", EmitDefaultValue = false)]
        public string SubMerchantServiceDescription { get; set; }

        /// <summary>
        /// 子商户的服务名称
        /// </summary>
        /// <value>子商户的服务名称</value>
        [DataMember(Name = "sub_merchant_service_name", EmitDefaultValue = false)]
        public string SubMerchantServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignMerchantParams {\n");
            sb.Append("  SubMerchantId: ").Append(SubMerchantId).Append("\n");
            sb.Append("  SubMerchantName: ").Append(SubMerchantName).Append("\n");
            sb.Append("  SubMerchantServiceDescription: ").Append(SubMerchantServiceDescription).Append("\n");
            sb.Append("  SubMerchantServiceName: ").Append(SubMerchantServiceName).Append("\n");
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
            return this.Equals(input as SignMerchantParams);
        }

        /// <summary>
        /// Returns true if SignMerchantParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SignMerchantParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignMerchantParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubMerchantId == input.SubMerchantId ||
                    (this.SubMerchantId != null &&
                    this.SubMerchantId.Equals(input.SubMerchantId))
                ) && 
                (
                    this.SubMerchantName == input.SubMerchantName ||
                    (this.SubMerchantName != null &&
                    this.SubMerchantName.Equals(input.SubMerchantName))
                ) && 
                (
                    this.SubMerchantServiceDescription == input.SubMerchantServiceDescription ||
                    (this.SubMerchantServiceDescription != null &&
                    this.SubMerchantServiceDescription.Equals(input.SubMerchantServiceDescription))
                ) && 
                (
                    this.SubMerchantServiceName == input.SubMerchantServiceName ||
                    (this.SubMerchantServiceName != null &&
                    this.SubMerchantServiceName.Equals(input.SubMerchantServiceName))
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
                if (this.SubMerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantId.GetHashCode();
                }
                if (this.SubMerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantName.GetHashCode();
                }
                if (this.SubMerchantServiceDescription != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantServiceDescription.GetHashCode();
                }
                if (this.SubMerchantServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantServiceName.GetHashCode();
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
