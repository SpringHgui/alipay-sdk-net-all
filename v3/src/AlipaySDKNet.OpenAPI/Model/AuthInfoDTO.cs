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
    /// AuthInfoDTO
    /// </summary>
    [DataContract(Name = "AuthInfoDTO")]
    public partial class AuthInfoDTO : IEquatable<AuthInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthInfoDTO" /> class.
        /// </summary>
        /// <param name="agreementNo">授权协议号.</param>
        /// <param name="alipayLogonId">授权的支付宝账号，脱敏。.</param>
        public AuthInfoDTO(string agreementNo = default(string), string alipayLogonId = default(string))
        {
            this.AgreementNo = agreementNo;
            this.AlipayLogonId = alipayLogonId;
        }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <value>授权协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 授权的支付宝账号，脱敏。
        /// </summary>
        /// <value>授权的支付宝账号，脱敏。</value>
        [DataMember(Name = "alipay_logon_id", EmitDefaultValue = false)]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthInfoDTO {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AlipayLogonId: ").Append(AlipayLogonId).Append("\n");
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
            return this.Equals(input as AuthInfoDTO);
        }

        /// <summary>
        /// Returns true if AuthInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AlipayLogonId == input.AlipayLogonId ||
                    (this.AlipayLogonId != null &&
                    this.AlipayLogonId.Equals(input.AlipayLogonId))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AlipayLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayLogonId.GetHashCode();
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
