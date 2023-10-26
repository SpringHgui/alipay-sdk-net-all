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
    /// AlipayTradeApplepayAuthenticationSubmitResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeApplepayAuthenticationSubmitResponseModel")]
    public partial class AlipayTradeApplepayAuthenticationSubmitResponseModel : IEquatable<AlipayTradeApplepayAuthenticationSubmitResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeApplepayAuthenticationSubmitResponseModel" /> class.
        /// </summary>
        /// <param name="authenticationError">核身错误信息.</param>
        /// <param name="fallbackAuthenticationMechanisms">失败时的鉴权重试机制.</param>
        /// <param name="responseHeader">responseHeader.</param>
        /// <param name="retryAuthenticationMechanisms">鉴权重试机制.</param>
        /// <param name="signingCertificate">base64之后的证书.</param>
        /// <param name="updatedAuthenticationDetails">updatedAuthenticationDetails.</param>
        /// <param name="updatedTransactionStatus">交易状态.</param>
        public AlipayTradeApplepayAuthenticationSubmitResponseModel(string authenticationError = default(string), List<string> fallbackAuthenticationMechanisms = default(List<string>), OpenApiResponseHeader responseHeader = default(OpenApiResponseHeader), List<string> retryAuthenticationMechanisms = default(List<string>), string signingCertificate = default(string), UpdatedAuthenticationDetails updatedAuthenticationDetails = default(UpdatedAuthenticationDetails), string updatedTransactionStatus = default(string))
        {
            this.AuthenticationError = authenticationError;
            this.FallbackAuthenticationMechanisms = fallbackAuthenticationMechanisms;
            this.ResponseHeader = responseHeader;
            this.RetryAuthenticationMechanisms = retryAuthenticationMechanisms;
            this.SigningCertificate = signingCertificate;
            this.UpdatedAuthenticationDetails = updatedAuthenticationDetails;
            this.UpdatedTransactionStatus = updatedTransactionStatus;
        }

        /// <summary>
        /// 核身错误信息
        /// </summary>
        /// <value>核身错误信息</value>
        [DataMember(Name = "authentication_error", EmitDefaultValue = false)]
        public string AuthenticationError { get; set; }

        /// <summary>
        /// 失败时的鉴权重试机制
        /// </summary>
        /// <value>失败时的鉴权重试机制</value>
        [DataMember(Name = "fallback_authentication_mechanisms", EmitDefaultValue = false)]
        public List<string> FallbackAuthenticationMechanisms { get; set; }

        /// <summary>
        /// Gets or Sets ResponseHeader
        /// </summary>
        [DataMember(Name = "response_header", EmitDefaultValue = false)]
        public OpenApiResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// 鉴权重试机制
        /// </summary>
        /// <value>鉴权重试机制</value>
        [DataMember(Name = "retry_authentication_mechanisms", EmitDefaultValue = false)]
        public List<string> RetryAuthenticationMechanisms { get; set; }

        /// <summary>
        /// base64之后的证书
        /// </summary>
        /// <value>base64之后的证书</value>
        [DataMember(Name = "signing_certificate", EmitDefaultValue = false)]
        public string SigningCertificate { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAuthenticationDetails
        /// </summary>
        [DataMember(Name = "updated_authentication_details", EmitDefaultValue = false)]
        public UpdatedAuthenticationDetails UpdatedAuthenticationDetails { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        /// <value>交易状态</value>
        [DataMember(Name = "updated_transaction_status", EmitDefaultValue = false)]
        public string UpdatedTransactionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeApplepayAuthenticationSubmitResponseModel {\n");
            sb.Append("  AuthenticationError: ").Append(AuthenticationError).Append("\n");
            sb.Append("  FallbackAuthenticationMechanisms: ").Append(FallbackAuthenticationMechanisms).Append("\n");
            sb.Append("  ResponseHeader: ").Append(ResponseHeader).Append("\n");
            sb.Append("  RetryAuthenticationMechanisms: ").Append(RetryAuthenticationMechanisms).Append("\n");
            sb.Append("  SigningCertificate: ").Append(SigningCertificate).Append("\n");
            sb.Append("  UpdatedAuthenticationDetails: ").Append(UpdatedAuthenticationDetails).Append("\n");
            sb.Append("  UpdatedTransactionStatus: ").Append(UpdatedTransactionStatus).Append("\n");
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
            return this.Equals(input as AlipayTradeApplepayAuthenticationSubmitResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeApplepayAuthenticationSubmitResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeApplepayAuthenticationSubmitResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeApplepayAuthenticationSubmitResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationError == input.AuthenticationError ||
                    (this.AuthenticationError != null &&
                    this.AuthenticationError.Equals(input.AuthenticationError))
                ) && 
                (
                    this.FallbackAuthenticationMechanisms == input.FallbackAuthenticationMechanisms ||
                    this.FallbackAuthenticationMechanisms != null &&
                    input.FallbackAuthenticationMechanisms != null &&
                    this.FallbackAuthenticationMechanisms.SequenceEqual(input.FallbackAuthenticationMechanisms)
                ) && 
                (
                    this.ResponseHeader == input.ResponseHeader ||
                    (this.ResponseHeader != null &&
                    this.ResponseHeader.Equals(input.ResponseHeader))
                ) && 
                (
                    this.RetryAuthenticationMechanisms == input.RetryAuthenticationMechanisms ||
                    this.RetryAuthenticationMechanisms != null &&
                    input.RetryAuthenticationMechanisms != null &&
                    this.RetryAuthenticationMechanisms.SequenceEqual(input.RetryAuthenticationMechanisms)
                ) && 
                (
                    this.SigningCertificate == input.SigningCertificate ||
                    (this.SigningCertificate != null &&
                    this.SigningCertificate.Equals(input.SigningCertificate))
                ) && 
                (
                    this.UpdatedAuthenticationDetails == input.UpdatedAuthenticationDetails ||
                    (this.UpdatedAuthenticationDetails != null &&
                    this.UpdatedAuthenticationDetails.Equals(input.UpdatedAuthenticationDetails))
                ) && 
                (
                    this.UpdatedTransactionStatus == input.UpdatedTransactionStatus ||
                    (this.UpdatedTransactionStatus != null &&
                    this.UpdatedTransactionStatus.Equals(input.UpdatedTransactionStatus))
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
                if (this.AuthenticationError != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationError.GetHashCode();
                }
                if (this.FallbackAuthenticationMechanisms != null)
                {
                    hashCode = (hashCode * 59) + this.FallbackAuthenticationMechanisms.GetHashCode();
                }
                if (this.ResponseHeader != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseHeader.GetHashCode();
                }
                if (this.RetryAuthenticationMechanisms != null)
                {
                    hashCode = (hashCode * 59) + this.RetryAuthenticationMechanisms.GetHashCode();
                }
                if (this.SigningCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.SigningCertificate.GetHashCode();
                }
                if (this.UpdatedAuthenticationDetails != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAuthenticationDetails.GetHashCode();
                }
                if (this.UpdatedTransactionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedTransactionStatus.GetHashCode();
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
