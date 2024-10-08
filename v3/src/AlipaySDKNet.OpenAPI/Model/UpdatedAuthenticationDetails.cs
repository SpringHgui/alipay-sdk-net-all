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
    /// UpdatedAuthenticationDetails
    /// </summary>
    [DataContract(Name = "UpdatedAuthenticationDetails")]
    public partial class UpdatedAuthenticationDetails : IEquatable<UpdatedAuthenticationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatedAuthenticationDetails" /> class.
        /// </summary>
        /// <param name="authenticationMechanisms">鉴权机制.</param>
        /// <param name="nonce">随机数.</param>
        /// <param name="partialTransactionDetailsSignature">交易签名信息.</param>
        /// <param name="pinFormat">6位密码或者长密码.</param>
        /// <param name="signingKeyMaterial">签名秘钥.</param>
        public UpdatedAuthenticationDetails(List<string> authenticationMechanisms = default(List<string>), string nonce = default(string), string partialTransactionDetailsSignature = default(string), string pinFormat = default(string), string signingKeyMaterial = default(string))
        {
            this.AuthenticationMechanisms = authenticationMechanisms;
            this.Nonce = nonce;
            this.PartialTransactionDetailsSignature = partialTransactionDetailsSignature;
            this.PinFormat = pinFormat;
            this.SigningKeyMaterial = signingKeyMaterial;
        }

        /// <summary>
        /// 鉴权机制
        /// </summary>
        /// <value>鉴权机制</value>
        [DataMember(Name = "authentication_mechanisms", EmitDefaultValue = false)]
        public List<string> AuthenticationMechanisms { get; set; }

        /// <summary>
        /// 随机数
        /// </summary>
        /// <value>随机数</value>
        [DataMember(Name = "nonce", EmitDefaultValue = false)]
        public string Nonce { get; set; }

        /// <summary>
        /// 交易签名信息
        /// </summary>
        /// <value>交易签名信息</value>
        [DataMember(Name = "partial_transaction_details_signature", EmitDefaultValue = false)]
        public string PartialTransactionDetailsSignature { get; set; }

        /// <summary>
        /// 6位密码或者长密码
        /// </summary>
        /// <value>6位密码或者长密码</value>
        [DataMember(Name = "pin_format", EmitDefaultValue = false)]
        public string PinFormat { get; set; }

        /// <summary>
        /// 签名秘钥
        /// </summary>
        /// <value>签名秘钥</value>
        [DataMember(Name = "signing_key_material", EmitDefaultValue = false)]
        public string SigningKeyMaterial { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdatedAuthenticationDetails {\n");
            sb.Append("  AuthenticationMechanisms: ").Append(AuthenticationMechanisms).Append("\n");
            sb.Append("  Nonce: ").Append(Nonce).Append("\n");
            sb.Append("  PartialTransactionDetailsSignature: ").Append(PartialTransactionDetailsSignature).Append("\n");
            sb.Append("  PinFormat: ").Append(PinFormat).Append("\n");
            sb.Append("  SigningKeyMaterial: ").Append(SigningKeyMaterial).Append("\n");
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
            return this.Equals(input as UpdatedAuthenticationDetails);
        }

        /// <summary>
        /// Returns true if UpdatedAuthenticationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdatedAuthenticationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdatedAuthenticationDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationMechanisms == input.AuthenticationMechanisms ||
                    this.AuthenticationMechanisms != null &&
                    input.AuthenticationMechanisms != null &&
                    this.AuthenticationMechanisms.SequenceEqual(input.AuthenticationMechanisms)
                ) && 
                (
                    this.Nonce == input.Nonce ||
                    (this.Nonce != null &&
                    this.Nonce.Equals(input.Nonce))
                ) && 
                (
                    this.PartialTransactionDetailsSignature == input.PartialTransactionDetailsSignature ||
                    (this.PartialTransactionDetailsSignature != null &&
                    this.PartialTransactionDetailsSignature.Equals(input.PartialTransactionDetailsSignature))
                ) && 
                (
                    this.PinFormat == input.PinFormat ||
                    (this.PinFormat != null &&
                    this.PinFormat.Equals(input.PinFormat))
                ) && 
                (
                    this.SigningKeyMaterial == input.SigningKeyMaterial ||
                    (this.SigningKeyMaterial != null &&
                    this.SigningKeyMaterial.Equals(input.SigningKeyMaterial))
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
                if (this.AuthenticationMechanisms != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationMechanisms.GetHashCode();
                }
                if (this.Nonce != null)
                {
                    hashCode = (hashCode * 59) + this.Nonce.GetHashCode();
                }
                if (this.PartialTransactionDetailsSignature != null)
                {
                    hashCode = (hashCode * 59) + this.PartialTransactionDetailsSignature.GetHashCode();
                }
                if (this.PinFormat != null)
                {
                    hashCode = (hashCode * 59) + this.PinFormat.GetHashCode();
                }
                if (this.SigningKeyMaterial != null)
                {
                    hashCode = (hashCode * 59) + this.SigningKeyMaterial.GetHashCode();
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
