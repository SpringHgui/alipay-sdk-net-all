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
    /// ZhimaCreditPayafteruseCreditagreementTransferResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPayafteruseCreditagreementTransferResponseModel")]
    public partial class ZhimaCreditPayafteruseCreditagreementTransferResponseModel : IEquatable<ZhimaCreditPayafteruseCreditagreementTransferResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditagreementTransferResponseModel" /> class.
        /// </summary>
        /// <param name="creditAgreementId">芝麻开通协议号.</param>
        /// <param name="outAgreementNo">商户外部协议号.</param>
        public ZhimaCreditPayafteruseCreditagreementTransferResponseModel(string creditAgreementId = default(string), string outAgreementNo = default(string))
        {
            this.CreditAgreementId = creditAgreementId;
            this.OutAgreementNo = outAgreementNo;
        }

        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        /// <value>芝麻开通协议号</value>
        [DataMember(Name = "credit_agreement_id", EmitDefaultValue = false)]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 商户外部协议号
        /// </summary>
        /// <value>商户外部协议号</value>
        [DataMember(Name = "out_agreement_no", EmitDefaultValue = false)]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPayafteruseCreditagreementTransferResponseModel {\n");
            sb.Append("  CreditAgreementId: ").Append(CreditAgreementId).Append("\n");
            sb.Append("  OutAgreementNo: ").Append(OutAgreementNo).Append("\n");
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
            return this.Equals(input as ZhimaCreditPayafteruseCreditagreementTransferResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPayafteruseCreditagreementTransferResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPayafteruseCreditagreementTransferResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPayafteruseCreditagreementTransferResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreditAgreementId == input.CreditAgreementId ||
                    (this.CreditAgreementId != null &&
                    this.CreditAgreementId.Equals(input.CreditAgreementId))
                ) && 
                (
                    this.OutAgreementNo == input.OutAgreementNo ||
                    (this.OutAgreementNo != null &&
                    this.OutAgreementNo.Equals(input.OutAgreementNo))
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
                if (this.CreditAgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.CreditAgreementId.GetHashCode();
                }
                if (this.OutAgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutAgreementNo.GetHashCode();
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
