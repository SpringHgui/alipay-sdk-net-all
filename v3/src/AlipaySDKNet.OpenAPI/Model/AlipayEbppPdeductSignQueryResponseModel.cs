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
    /// AlipayEbppPdeductSignQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductSignQueryResponseModel")]
    public partial class AlipayEbppPdeductSignQueryResponseModel : IEquatable<AlipayEbppPdeductSignQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agreementId">协议ID.</param>
        /// <param name="billKey">户号.</param>
        /// <param name="chargeInst">出账机构.</param>
        /// <param name="outAgreementId">朗新协议ID.</param>
        /// <param name="signDate">签约时间.</param>
        /// <param name="userId">用户ID.</param>
        public AlipayEbppPdeductSignQueryResponseModel(string agreementId = default(string), string billKey = default(string), string chargeInst = default(string), string outAgreementId = default(string), string signDate = default(string), string userId = default(string))
        {
            this.AgreementId = agreementId;
            this.BillKey = billKey;
            this.ChargeInst = chargeInst;
            this.OutAgreementId = outAgreementId;
            this.SignDate = signDate;
            this.UserId = userId;
        }

        /// <summary>
        /// 协议ID
        /// </summary>
        /// <value>协议ID</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        /// <value>户号</value>
        [DataMember(Name = "bill_key", EmitDefaultValue = false)]
        public string BillKey { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        /// <value>出账机构</value>
        [DataMember(Name = "charge_inst", EmitDefaultValue = false)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 朗新协议ID
        /// </summary>
        /// <value>朗新协议ID</value>
        [DataMember(Name = "out_agreement_id", EmitDefaultValue = false)]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        /// <value>签约时间</value>
        [DataMember(Name = "sign_date", EmitDefaultValue = false)]
        public string SignDate { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        /// <value>用户ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductSignQueryResponseModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  BillKey: ").Append(BillKey).Append("\n");
            sb.Append("  ChargeInst: ").Append(ChargeInst).Append("\n");
            sb.Append("  OutAgreementId: ").Append(OutAgreementId).Append("\n");
            sb.Append("  SignDate: ").Append(SignDate).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductSignQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductSignQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductSignQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductSignQueryResponseModel input)
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
                    this.BillKey == input.BillKey ||
                    (this.BillKey != null &&
                    this.BillKey.Equals(input.BillKey))
                ) && 
                (
                    this.ChargeInst == input.ChargeInst ||
                    (this.ChargeInst != null &&
                    this.ChargeInst.Equals(input.ChargeInst))
                ) && 
                (
                    this.OutAgreementId == input.OutAgreementId ||
                    (this.OutAgreementId != null &&
                    this.OutAgreementId.Equals(input.OutAgreementId))
                ) && 
                (
                    this.SignDate == input.SignDate ||
                    (this.SignDate != null &&
                    this.SignDate.Equals(input.SignDate))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.BillKey != null)
                {
                    hashCode = (hashCode * 59) + this.BillKey.GetHashCode();
                }
                if (this.ChargeInst != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeInst.GetHashCode();
                }
                if (this.OutAgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.OutAgreementId.GetHashCode();
                }
                if (this.SignDate != null)
                {
                    hashCode = (hashCode * 59) + this.SignDate.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
