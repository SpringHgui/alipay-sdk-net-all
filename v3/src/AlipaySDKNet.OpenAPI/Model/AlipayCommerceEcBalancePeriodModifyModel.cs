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
    /// AlipayCommerceEcBalancePeriodModifyModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcBalancePeriodModifyModel")]
    public partial class AlipayCommerceEcBalancePeriodModifyModel : IEquatable<AlipayCommerceEcBalancePeriodModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcBalancePeriodModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账户id - 适用于在企业码小程序创建的共同账户，和agreement_no搭配使用.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="billDay">月账单账期.</param>
        /// <param name="enterpriseId">企业ID - 适用于在企业码PC端创建的企业账号.</param>
        public AlipayCommerceEcBalancePeriodModifyModel(string accountId = default(string), string agreementNo = default(string), int billDay = default(int), string enterpriseId = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.BillDay = billDay;
            this.EnterpriseId = enterpriseId;
        }

        /// <summary>
        /// 共同账户id - 适用于在企业码小程序创建的共同账户，和agreement_no搭配使用
        /// </summary>
        /// <value>共同账户id - 适用于在企业码小程序创建的共同账户，和agreement_no搭配使用</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 月账单账期
        /// </summary>
        /// <value>月账单账期</value>
        [DataMember(Name = "bill_day", EmitDefaultValue = false)]
        public int BillDay { get; set; }

        /// <summary>
        /// 企业ID - 适用于在企业码PC端创建的企业账号
        /// </summary>
        /// <value>企业ID - 适用于在企业码PC端创建的企业账号</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcBalancePeriodModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  BillDay: ").Append(BillDay).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcBalancePeriodModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcBalancePeriodModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcBalancePeriodModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcBalancePeriodModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.BillDay == input.BillDay ||
                    this.BillDay.Equals(input.BillDay)
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BillDay.GetHashCode();
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
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
