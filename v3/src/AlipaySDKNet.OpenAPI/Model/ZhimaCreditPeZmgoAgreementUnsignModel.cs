/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// ZhimaCreditPeZmgoAgreementUnsignModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoAgreementUnsignModel")]
    public partial class ZhimaCreditPeZmgoAgreementUnsignModel : IEquatable<ZhimaCreditPeZmgoAgreementUnsignModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoAgreementUnsignModel" /> class.
        /// </summary>
        /// <param name="agreementId">支付宝系统中用以唯一标识用户签约记录的编号。.</param>
        /// <param name="alipayUserId">支付宝的用户id.</param>
        /// <param name="openId">支付宝的用户id.</param>
        /// <param name="partnerId">商户ID.</param>
        /// <param name="quitType">quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT.</param>
        public ZhimaCreditPeZmgoAgreementUnsignModel(string agreementId = default(string), string alipayUserId = default(string), string openId = default(string), string partnerId = default(string), string quitType = default(string))
        {
            this.AgreementId = agreementId;
            this.AlipayUserId = alipayUserId;
            this.OpenId = openId;
            this.PartnerId = partnerId;
            this.QuitType = quitType;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝的用户id
        /// </summary>
        /// <value>支付宝的用户id</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝的用户id
        /// </summary>
        /// <value>支付宝的用户id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT
        /// </summary>
        /// <value>quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT</value>
        [DataMember(Name = "quit_type", EmitDefaultValue = false)]
        public string QuitType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoAgreementUnsignModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  QuitType: ").Append(QuitType).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoAgreementUnsignModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoAgreementUnsignModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoAgreementUnsignModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoAgreementUnsignModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.QuitType == input.QuitType ||
                    (this.QuitType != null &&
                    this.QuitType.Equals(input.QuitType))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.QuitType != null)
                {
                    hashCode = (hashCode * 59) + this.QuitType.GetHashCode();
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
