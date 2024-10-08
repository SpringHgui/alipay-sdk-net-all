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
    /// AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel")]
    public partial class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel : IEquatable<AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户ID.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="invoiceRuleId">开票规则ID.</param>
        /// <param name="invoiceRuleName">开票规则名称.</param>
        /// <param name="invoiceTitleId">发票抬头.</param>
        /// <param name="receiveAddress">收件人地址.</param>
        /// <param name="receiveName">收件人姓名.</param>
        /// <param name="receivePhone">收件人手机号.</param>
        /// <param name="sellerType">销方类型.</param>
        public AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel(string accountId = default(string), string agreementNo = default(string), string enterpriseId = default(string), string invoiceRuleId = default(string), string invoiceRuleName = default(string), string invoiceTitleId = default(string), string receiveAddress = default(string), string receiveName = default(string), string receivePhone = default(string), string sellerType = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.EnterpriseId = enterpriseId;
            this.InvoiceRuleId = invoiceRuleId;
            this.InvoiceRuleName = invoiceRuleName;
            this.InvoiceTitleId = invoiceTitleId;
            this.ReceiveAddress = receiveAddress;
            this.ReceiveName = receiveName;
            this.ReceivePhone = receivePhone;
            this.SellerType = sellerType;
        }

        /// <summary>
        /// 企业共同账户ID
        /// </summary>
        /// <value>企业共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 开票规则ID
        /// </summary>
        /// <value>开票规则ID</value>
        [DataMember(Name = "invoice_rule_id", EmitDefaultValue = false)]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 开票规则名称
        /// </summary>
        /// <value>开票规则名称</value>
        [DataMember(Name = "invoice_rule_name", EmitDefaultValue = false)]
        public string InvoiceRuleName { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        /// <value>发票抬头</value>
        [DataMember(Name = "invoice_title_id", EmitDefaultValue = false)]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 收件人地址
        /// </summary>
        /// <value>收件人地址</value>
        [DataMember(Name = "receive_address", EmitDefaultValue = false)]
        public string ReceiveAddress { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        /// <value>收件人姓名</value>
        [DataMember(Name = "receive_name", EmitDefaultValue = false)]
        public string ReceiveName { get; set; }

        /// <summary>
        /// 收件人手机号
        /// </summary>
        /// <value>收件人手机号</value>
        [DataMember(Name = "receive_phone", EmitDefaultValue = false)]
        public string ReceivePhone { get; set; }

        /// <summary>
        /// 销方类型
        /// </summary>
        /// <value>销方类型</value>
        [DataMember(Name = "seller_type", EmitDefaultValue = false)]
        public string SellerType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  InvoiceRuleId: ").Append(InvoiceRuleId).Append("\n");
            sb.Append("  InvoiceRuleName: ").Append(InvoiceRuleName).Append("\n");
            sb.Append("  InvoiceTitleId: ").Append(InvoiceTitleId).Append("\n");
            sb.Append("  ReceiveAddress: ").Append(ReceiveAddress).Append("\n");
            sb.Append("  ReceiveName: ").Append(ReceiveName).Append("\n");
            sb.Append("  ReceivePhone: ").Append(ReceivePhone).Append("\n");
            sb.Append("  SellerType: ").Append(SellerType).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseconsumeEnterpriseopenruleModifyModel input)
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
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.InvoiceRuleId == input.InvoiceRuleId ||
                    (this.InvoiceRuleId != null &&
                    this.InvoiceRuleId.Equals(input.InvoiceRuleId))
                ) && 
                (
                    this.InvoiceRuleName == input.InvoiceRuleName ||
                    (this.InvoiceRuleName != null &&
                    this.InvoiceRuleName.Equals(input.InvoiceRuleName))
                ) && 
                (
                    this.InvoiceTitleId == input.InvoiceTitleId ||
                    (this.InvoiceTitleId != null &&
                    this.InvoiceTitleId.Equals(input.InvoiceTitleId))
                ) && 
                (
                    this.ReceiveAddress == input.ReceiveAddress ||
                    (this.ReceiveAddress != null &&
                    this.ReceiveAddress.Equals(input.ReceiveAddress))
                ) && 
                (
                    this.ReceiveName == input.ReceiveName ||
                    (this.ReceiveName != null &&
                    this.ReceiveName.Equals(input.ReceiveName))
                ) && 
                (
                    this.ReceivePhone == input.ReceivePhone ||
                    (this.ReceivePhone != null &&
                    this.ReceivePhone.Equals(input.ReceivePhone))
                ) && 
                (
                    this.SellerType == input.SellerType ||
                    (this.SellerType != null &&
                    this.SellerType.Equals(input.SellerType))
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
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.InvoiceRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceRuleId.GetHashCode();
                }
                if (this.InvoiceRuleName != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceRuleName.GetHashCode();
                }
                if (this.InvoiceTitleId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTitleId.GetHashCode();
                }
                if (this.ReceiveAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiveAddress.GetHashCode();
                }
                if (this.ReceiveName != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiveName.GetHashCode();
                }
                if (this.ReceivePhone != null)
                {
                    hashCode = (hashCode * 59) + this.ReceivePhone.GetHashCode();
                }
                if (this.SellerType != null)
                {
                    hashCode = (hashCode * 59) + this.SellerType.GetHashCode();
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
