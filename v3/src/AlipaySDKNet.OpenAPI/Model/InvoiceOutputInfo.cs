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
    /// InvoiceOutputInfo
    /// </summary>
    [DataContract(Name = "InvoiceOutputInfo")]
    public partial class InvoiceOutputInfo : IEquatable<InvoiceOutputInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceOutputInfo" /> class.
        /// </summary>
        /// <param name="checkCode">发票防伪码，验证码.</param>
        /// <param name="checker">票面上复核人信息。.</param>
        /// <param name="clerk">票面上开票员信息。.</param>
        /// <param name="exTaxAmount">不含税金额，票面上的不含税金额，单位（元），保留两位小数。.</param>
        /// <param name="invoiceCode">发票代码.</param>
        /// <param name="invoiceContent">发票明细项。.</param>
        /// <param name="invoiceDate">开票日期，格式如：YYYY-MM-DD。.</param>
        /// <param name="invoiceImgUrl">发票预览图片地址.</param>
        /// <param name="invoiceKind">标识发票的类型，PLAIN:增值税电子普通发票;SPECIAL:增值税专用发票;PLAIN_INVOICE:增值税普通发票;SALSE_INVOICE:机动车销售统一发票 ;PAPER_INVOICE:增值税普通发票(卷式)。.</param>
        /// <param name="invoiceMemo">票面上备注信息。.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="invoiceTitle">invoiceTitle.</param>
        /// <param name="invoiceType">标识是红票还是蓝票，RED:红票;BLUE:蓝票.</param>
        /// <param name="oriBlueInvCode">红票情况下，必须填入原始蓝票的发票代码。.</param>
        /// <param name="oriBlueInvNo">红票情况下，必须填入原始蓝票的发票号码。.</param>
        /// <param name="payee">票面上收款人信息。.</param>
        /// <param name="payeeAddressTel">票面上销售方地址、电话信息。.</param>
        /// <param name="payeeBankNameAccount">票面上销售方开户行及账号。.</param>
        /// <param name="payeeName">票面上销售方企业名称。.</param>
        /// <param name="payeeRegisterNo">票面上销售方税号信息。.</param>
        /// <param name="sumAmount">价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount&#x3D;ex_tax_amount+tax_amount。.</param>
        /// <param name="taxAmount">合计税额，票面上的合计税额，单位（元），保留两位小数。.</param>
        public InvoiceOutputInfo(string checkCode = default(string), string checker = default(string), string clerk = default(string), string exTaxAmount = default(string), string invoiceCode = default(string), List<InvoiceItemOpenModel> invoiceContent = default(List<InvoiceItemOpenModel>), string invoiceDate = default(string), string invoiceImgUrl = default(string), string invoiceKind = default(string), string invoiceMemo = default(string), string invoiceNo = default(string), InvoiceTitleOpenModel invoiceTitle = default(InvoiceTitleOpenModel), string invoiceType = default(string), string oriBlueInvCode = default(string), string oriBlueInvNo = default(string), string payee = default(string), string payeeAddressTel = default(string), string payeeBankNameAccount = default(string), string payeeName = default(string), string payeeRegisterNo = default(string), string sumAmount = default(string), string taxAmount = default(string))
        {
            this.CheckCode = checkCode;
            this.Checker = checker;
            this.Clerk = clerk;
            this.ExTaxAmount = exTaxAmount;
            this.InvoiceCode = invoiceCode;
            this.InvoiceContent = invoiceContent;
            this.InvoiceDate = invoiceDate;
            this.InvoiceImgUrl = invoiceImgUrl;
            this.InvoiceKind = invoiceKind;
            this.InvoiceMemo = invoiceMemo;
            this.InvoiceNo = invoiceNo;
            this.InvoiceTitle = invoiceTitle;
            this.InvoiceType = invoiceType;
            this.OriBlueInvCode = oriBlueInvCode;
            this.OriBlueInvNo = oriBlueInvNo;
            this.Payee = payee;
            this.PayeeAddressTel = payeeAddressTel;
            this.PayeeBankNameAccount = payeeBankNameAccount;
            this.PayeeName = payeeName;
            this.PayeeRegisterNo = payeeRegisterNo;
            this.SumAmount = sumAmount;
            this.TaxAmount = taxAmount;
        }

        /// <summary>
        /// 发票防伪码，验证码
        /// </summary>
        /// <value>发票防伪码，验证码</value>
        [DataMember(Name = "check_code", EmitDefaultValue = false)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 票面上复核人信息。
        /// </summary>
        /// <value>票面上复核人信息。</value>
        [DataMember(Name = "checker", EmitDefaultValue = false)]
        public string Checker { get; set; }

        /// <summary>
        /// 票面上开票员信息。
        /// </summary>
        /// <value>票面上开票员信息。</value>
        [DataMember(Name = "clerk", EmitDefaultValue = false)]
        public string Clerk { get; set; }

        /// <summary>
        /// 不含税金额，票面上的不含税金额，单位（元），保留两位小数。
        /// </summary>
        /// <value>不含税金额，票面上的不含税金额，单位（元），保留两位小数。</value>
        [DataMember(Name = "ex_tax_amount", EmitDefaultValue = false)]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        /// <value>发票代码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票明细项。
        /// </summary>
        /// <value>发票明细项。</value>
        [DataMember(Name = "invoice_content", EmitDefaultValue = false)]
        public List<InvoiceItemOpenModel> InvoiceContent { get; set; }

        /// <summary>
        /// 开票日期，格式如：YYYY-MM-DD。
        /// </summary>
        /// <value>开票日期，格式如：YYYY-MM-DD。</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票预览图片地址
        /// </summary>
        /// <value>发票预览图片地址</value>
        [DataMember(Name = "invoice_img_url", EmitDefaultValue = false)]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 标识发票的类型，PLAIN:增值税电子普通发票;SPECIAL:增值税专用发票;PLAIN_INVOICE:增值税普通发票;SALSE_INVOICE:机动车销售统一发票 ;PAPER_INVOICE:增值税普通发票(卷式)。
        /// </summary>
        /// <value>标识发票的类型，PLAIN:增值税电子普通发票;SPECIAL:增值税专用发票;PLAIN_INVOICE:增值税普通发票;SALSE_INVOICE:机动车销售统一发票 ;PAPER_INVOICE:增值税普通发票(卷式)。</value>
        [DataMember(Name = "invoice_kind", EmitDefaultValue = false)]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 票面上备注信息。
        /// </summary>
        /// <value>票面上备注信息。</value>
        [DataMember(Name = "invoice_memo", EmitDefaultValue = false)]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceTitle
        /// </summary>
        [DataMember(Name = "invoice_title", EmitDefaultValue = false)]
        public InvoiceTitleOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 标识是红票还是蓝票，RED:红票;BLUE:蓝票
        /// </summary>
        /// <value>标识是红票还是蓝票，RED:红票;BLUE:蓝票</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票代码。
        /// </summary>
        /// <value>红票情况下，必须填入原始蓝票的发票代码。</value>
        [DataMember(Name = "ori_blue_inv_code", EmitDefaultValue = false)]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票号码。
        /// </summary>
        /// <value>红票情况下，必须填入原始蓝票的发票号码。</value>
        [DataMember(Name = "ori_blue_inv_no", EmitDefaultValue = false)]
        public string OriBlueInvNo { get; set; }

        /// <summary>
        /// 票面上收款人信息。
        /// </summary>
        /// <value>票面上收款人信息。</value>
        [DataMember(Name = "payee", EmitDefaultValue = false)]
        public string Payee { get; set; }

        /// <summary>
        /// 票面上销售方地址、电话信息。
        /// </summary>
        /// <value>票面上销售方地址、电话信息。</value>
        [DataMember(Name = "payee_address_tel", EmitDefaultValue = false)]
        public string PayeeAddressTel { get; set; }

        /// <summary>
        /// 票面上销售方开户行及账号。
        /// </summary>
        /// <value>票面上销售方开户行及账号。</value>
        [DataMember(Name = "payee_bank_name_account", EmitDefaultValue = false)]
        public string PayeeBankNameAccount { get; set; }

        /// <summary>
        /// 票面上销售方企业名称。
        /// </summary>
        /// <value>票面上销售方企业名称。</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// 票面上销售方税号信息。
        /// </summary>
        /// <value>票面上销售方税号信息。</value>
        [DataMember(Name = "payee_register_no", EmitDefaultValue = false)]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount&#x3D;ex_tax_amount+tax_amount。
        /// </summary>
        /// <value>价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount&#x3D;ex_tax_amount+tax_amount。</value>
        [DataMember(Name = "sum_amount", EmitDefaultValue = false)]
        public string SumAmount { get; set; }

        /// <summary>
        /// 合计税额，票面上的合计税额，单位（元），保留两位小数。
        /// </summary>
        /// <value>合计税额，票面上的合计税额，单位（元），保留两位小数。</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceOutputInfo {\n");
            sb.Append("  CheckCode: ").Append(CheckCode).Append("\n");
            sb.Append("  Checker: ").Append(Checker).Append("\n");
            sb.Append("  Clerk: ").Append(Clerk).Append("\n");
            sb.Append("  ExTaxAmount: ").Append(ExTaxAmount).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceContent: ").Append(InvoiceContent).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceImgUrl: ").Append(InvoiceImgUrl).Append("\n");
            sb.Append("  InvoiceKind: ").Append(InvoiceKind).Append("\n");
            sb.Append("  InvoiceMemo: ").Append(InvoiceMemo).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceTitle: ").Append(InvoiceTitle).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  OriBlueInvCode: ").Append(OriBlueInvCode).Append("\n");
            sb.Append("  OriBlueInvNo: ").Append(OriBlueInvNo).Append("\n");
            sb.Append("  Payee: ").Append(Payee).Append("\n");
            sb.Append("  PayeeAddressTel: ").Append(PayeeAddressTel).Append("\n");
            sb.Append("  PayeeBankNameAccount: ").Append(PayeeBankNameAccount).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  PayeeRegisterNo: ").Append(PayeeRegisterNo).Append("\n");
            sb.Append("  SumAmount: ").Append(SumAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(input as InvoiceOutputInfo);
        }

        /// <summary>
        /// Returns true if InvoiceOutputInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceOutputInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceOutputInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) && 
                (
                    this.Checker == input.Checker ||
                    (this.Checker != null &&
                    this.Checker.Equals(input.Checker))
                ) && 
                (
                    this.Clerk == input.Clerk ||
                    (this.Clerk != null &&
                    this.Clerk.Equals(input.Clerk))
                ) && 
                (
                    this.ExTaxAmount == input.ExTaxAmount ||
                    (this.ExTaxAmount != null &&
                    this.ExTaxAmount.Equals(input.ExTaxAmount))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceContent == input.InvoiceContent ||
                    this.InvoiceContent != null &&
                    input.InvoiceContent != null &&
                    this.InvoiceContent.SequenceEqual(input.InvoiceContent)
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceImgUrl == input.InvoiceImgUrl ||
                    (this.InvoiceImgUrl != null &&
                    this.InvoiceImgUrl.Equals(input.InvoiceImgUrl))
                ) && 
                (
                    this.InvoiceKind == input.InvoiceKind ||
                    (this.InvoiceKind != null &&
                    this.InvoiceKind.Equals(input.InvoiceKind))
                ) && 
                (
                    this.InvoiceMemo == input.InvoiceMemo ||
                    (this.InvoiceMemo != null &&
                    this.InvoiceMemo.Equals(input.InvoiceMemo))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceTitle == input.InvoiceTitle ||
                    (this.InvoiceTitle != null &&
                    this.InvoiceTitle.Equals(input.InvoiceTitle))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && 
                (
                    this.OriBlueInvCode == input.OriBlueInvCode ||
                    (this.OriBlueInvCode != null &&
                    this.OriBlueInvCode.Equals(input.OriBlueInvCode))
                ) && 
                (
                    this.OriBlueInvNo == input.OriBlueInvNo ||
                    (this.OriBlueInvNo != null &&
                    this.OriBlueInvNo.Equals(input.OriBlueInvNo))
                ) && 
                (
                    this.Payee == input.Payee ||
                    (this.Payee != null &&
                    this.Payee.Equals(input.Payee))
                ) && 
                (
                    this.PayeeAddressTel == input.PayeeAddressTel ||
                    (this.PayeeAddressTel != null &&
                    this.PayeeAddressTel.Equals(input.PayeeAddressTel))
                ) && 
                (
                    this.PayeeBankNameAccount == input.PayeeBankNameAccount ||
                    (this.PayeeBankNameAccount != null &&
                    this.PayeeBankNameAccount.Equals(input.PayeeBankNameAccount))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.PayeeRegisterNo == input.PayeeRegisterNo ||
                    (this.PayeeRegisterNo != null &&
                    this.PayeeRegisterNo.Equals(input.PayeeRegisterNo))
                ) && 
                (
                    this.SumAmount == input.SumAmount ||
                    (this.SumAmount != null &&
                    this.SumAmount.Equals(input.SumAmount))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
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
                if (this.CheckCode != null)
                {
                    hashCode = (hashCode * 59) + this.CheckCode.GetHashCode();
                }
                if (this.Checker != null)
                {
                    hashCode = (hashCode * 59) + this.Checker.GetHashCode();
                }
                if (this.Clerk != null)
                {
                    hashCode = (hashCode * 59) + this.Clerk.GetHashCode();
                }
                if (this.ExTaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ExTaxAmount.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceContent != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceContent.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceImgUrl.GetHashCode();
                }
                if (this.InvoiceKind != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceKind.GetHashCode();
                }
                if (this.InvoiceMemo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceMemo.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTitle.GetHashCode();
                }
                if (this.InvoiceType != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                }
                if (this.OriBlueInvCode != null)
                {
                    hashCode = (hashCode * 59) + this.OriBlueInvCode.GetHashCode();
                }
                if (this.OriBlueInvNo != null)
                {
                    hashCode = (hashCode * 59) + this.OriBlueInvNo.GetHashCode();
                }
                if (this.Payee != null)
                {
                    hashCode = (hashCode * 59) + this.Payee.GetHashCode();
                }
                if (this.PayeeAddressTel != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeAddressTel.GetHashCode();
                }
                if (this.PayeeBankNameAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeBankNameAccount.GetHashCode();
                }
                if (this.PayeeName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeName.GetHashCode();
                }
                if (this.PayeeRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeRegisterNo.GetHashCode();
                }
                if (this.SumAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SumAmount.GetHashCode();
                }
                if (this.TaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
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
