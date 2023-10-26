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
    /// OpenCertifyIdentifyInfo
    /// </summary>
    [DataContract(Name = "OpenCertifyIdentifyInfo")]
    public partial class OpenCertifyIdentifyInfo : IEquatable<OpenCertifyIdentifyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCertifyIdentifyInfo" /> class.
        /// </summary>
        /// <param name="certName">填入真实姓名.</param>
        /// <param name="certNo">填入姓名相匹配的证件号码.</param>
        /// <param name="certType">当前仅支持IDENTITY_CARD.</param>
        /// <param name="identityType">当前仅支持CERT_INFO.</param>
        /// <param name="phoneNo">选填手机号.</param>
        public OpenCertifyIdentifyInfo(string certName = default(string), string certNo = default(string), string certType = default(string), string identityType = default(string), string phoneNo = default(string))
        {
            this.CertName = certName;
            this.CertNo = certNo;
            this.CertType = certType;
            this.IdentityType = identityType;
            this.PhoneNo = phoneNo;
        }

        /// <summary>
        /// 填入真实姓名
        /// </summary>
        /// <value>填入真实姓名</value>
        [DataMember(Name = "cert_name", EmitDefaultValue = false)]
        public string CertName { get; set; }

        /// <summary>
        /// 填入姓名相匹配的证件号码
        /// </summary>
        /// <value>填入姓名相匹配的证件号码</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 当前仅支持IDENTITY_CARD
        /// </summary>
        /// <value>当前仅支持IDENTITY_CARD</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// 当前仅支持CERT_INFO
        /// </summary>
        /// <value>当前仅支持CERT_INFO</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// 选填手机号
        /// </summary>
        /// <value>选填手机号</value>
        [DataMember(Name = "phone_no", EmitDefaultValue = false)]
        public string PhoneNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenCertifyIdentifyInfo {\n");
            sb.Append("  CertName: ").Append(CertName).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  PhoneNo: ").Append(PhoneNo).Append("\n");
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
            return this.Equals(input as OpenCertifyIdentifyInfo);
        }

        /// <summary>
        /// Returns true if OpenCertifyIdentifyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenCertifyIdentifyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenCertifyIdentifyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.PhoneNo == input.PhoneNo ||
                    (this.PhoneNo != null &&
                    this.PhoneNo.Equals(input.PhoneNo))
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
                if (this.CertName != null)
                {
                    hashCode = (hashCode * 59) + this.CertName.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.PhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNo.GetHashCode();
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
