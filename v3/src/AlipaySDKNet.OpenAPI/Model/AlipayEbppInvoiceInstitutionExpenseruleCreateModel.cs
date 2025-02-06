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
    /// AlipayEbppInvoiceInstitutionExpenseruleCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionExpenseruleCreateModel")]
    public partial class AlipayEbppInvoiceInstitutionExpenseruleCreateModel : IEquatable<AlipayEbppInvoiceInstitutionExpenseruleCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionExpenseruleCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换).</param>
        /// <param name="agreementNo">授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换).</param>
        /// <param name="assetShareSourceInfo">assetShareSourceInfo.</param>
        /// <param name="consumeMode">消费模式.</param>
        /// <param name="enterpriseId">企业码id.</param>
        /// <param name="expenseCtrlRuleInfoList">expenseCtrlRuleInfoList.</param>
        /// <param name="expenseTypeSubCategory">费用类型子类.</param>
        /// <param name="institutionId">制度id.</param>
        /// <param name="openRuleId">开票规则id.</param>
        /// <param name="outerSourceId">外部唯一标识，填写该字段可用于创建幂等，防止重复创建.</param>
        /// <param name="paymentPolicy">支付策略.</param>
        /// <param name="personalQrcodeMode">个人收款码转账是否支持因公付，默认为0。可选值：0（不支持）、1（支持）.</param>
        /// <param name="standardConditionInfoList">使用规则因子列表.</param>
        /// <param name="standardDesc">使用规则描述.</param>
        /// <param name="standardName">费控规则名称.</param>
        public AlipayEbppInvoiceInstitutionExpenseruleCreateModel(string accountId = default(string), string agreementNo = default(string), AssetShareSourceInfo assetShareSourceInfo = default(AssetShareSourceInfo), string consumeMode = default(string), string enterpriseId = default(string), ExpenseCtrRuleInfo expenseCtrlRuleInfoList = default(ExpenseCtrRuleInfo), string expenseTypeSubCategory = default(string), string institutionId = default(string), string openRuleId = default(string), string outerSourceId = default(string), string paymentPolicy = default(string), int personalQrcodeMode = default(int), List<StandardConditionInfo> standardConditionInfoList = default(List<StandardConditionInfo>), string standardDesc = default(string), string standardName = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.AssetShareSourceInfo = assetShareSourceInfo;
            this.ConsumeMode = consumeMode;
            this.EnterpriseId = enterpriseId;
            this.ExpenseCtrlRuleInfoList = expenseCtrlRuleInfoList;
            this.ExpenseTypeSubCategory = expenseTypeSubCategory;
            this.InstitutionId = institutionId;
            this.OpenRuleId = openRuleId;
            this.OuterSourceId = outerSourceId;
            this.PaymentPolicy = paymentPolicy;
            this.PersonalQrcodeMode = personalQrcodeMode;
            this.StandardConditionInfoList = standardConditionInfoList;
            this.StandardDesc = standardDesc;
            this.StandardName = standardName;
        }

        /// <summary>
        /// 企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        /// <value>企业共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        [Obsolete]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        /// <value>授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        [Obsolete]
        public string AgreementNo { get; set; }

        /// <summary>
        /// Gets or Sets AssetShareSourceInfo
        /// </summary>
        [DataMember(Name = "asset_share_source_info", EmitDefaultValue = false)]
        public AssetShareSourceInfo AssetShareSourceInfo { get; set; }

        /// <summary>
        /// 消费模式
        /// </summary>
        /// <value>消费模式</value>
        [DataMember(Name = "consume_mode", EmitDefaultValue = false)]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 企业码id
        /// </summary>
        /// <value>企业码id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseCtrlRuleInfoList
        /// </summary>
        [DataMember(Name = "expense_ctrl_rule_info_list", EmitDefaultValue = false)]
        public ExpenseCtrRuleInfo ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费用类型子类
        /// </summary>
        /// <value>费用类型子类</value>
        [DataMember(Name = "expense_type_sub_category", EmitDefaultValue = false)]
        public string ExpenseTypeSubCategory { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        /// <value>制度id</value>
        [DataMember(Name = "institution_id", EmitDefaultValue = false)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 开票规则id
        /// </summary>
        /// <value>开票规则id</value>
        [DataMember(Name = "open_rule_id", EmitDefaultValue = false)]
        public string OpenRuleId { get; set; }

        /// <summary>
        /// 外部唯一标识，填写该字段可用于创建幂等，防止重复创建
        /// </summary>
        /// <value>外部唯一标识，填写该字段可用于创建幂等，防止重复创建</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 支付策略
        /// </summary>
        /// <value>支付策略</value>
        [DataMember(Name = "payment_policy", EmitDefaultValue = false)]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 个人收款码转账是否支持因公付，默认为0。可选值：0（不支持）、1（支持）
        /// </summary>
        /// <value>个人收款码转账是否支持因公付，默认为0。可选值：0（不支持）、1（支持）</value>
        [DataMember(Name = "personal_qrcode_mode", EmitDefaultValue = false)]
        public int PersonalQrcodeMode { get; set; }

        /// <summary>
        /// 使用规则因子列表
        /// </summary>
        /// <value>使用规则因子列表</value>
        [DataMember(Name = "standard_condition_info_list", EmitDefaultValue = false)]
        public List<StandardConditionInfo> StandardConditionInfoList { get; set; }

        /// <summary>
        /// 使用规则描述
        /// </summary>
        /// <value>使用规则描述</value>
        [DataMember(Name = "standard_desc", EmitDefaultValue = false)]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 费控规则名称
        /// </summary>
        /// <value>费控规则名称</value>
        [DataMember(Name = "standard_name", EmitDefaultValue = false)]
        public string StandardName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionExpenseruleCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AssetShareSourceInfo: ").Append(AssetShareSourceInfo).Append("\n");
            sb.Append("  ConsumeMode: ").Append(ConsumeMode).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  ExpenseCtrlRuleInfoList: ").Append(ExpenseCtrlRuleInfoList).Append("\n");
            sb.Append("  ExpenseTypeSubCategory: ").Append(ExpenseTypeSubCategory).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  OpenRuleId: ").Append(OpenRuleId).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  PaymentPolicy: ").Append(PaymentPolicy).Append("\n");
            sb.Append("  PersonalQrcodeMode: ").Append(PersonalQrcodeMode).Append("\n");
            sb.Append("  StandardConditionInfoList: ").Append(StandardConditionInfoList).Append("\n");
            sb.Append("  StandardDesc: ").Append(StandardDesc).Append("\n");
            sb.Append("  StandardName: ").Append(StandardName).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionExpenseruleCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionExpenseruleCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionExpenseruleCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionExpenseruleCreateModel input)
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
                    this.AssetShareSourceInfo == input.AssetShareSourceInfo ||
                    (this.AssetShareSourceInfo != null &&
                    this.AssetShareSourceInfo.Equals(input.AssetShareSourceInfo))
                ) && 
                (
                    this.ConsumeMode == input.ConsumeMode ||
                    (this.ConsumeMode != null &&
                    this.ConsumeMode.Equals(input.ConsumeMode))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.ExpenseCtrlRuleInfoList == input.ExpenseCtrlRuleInfoList ||
                    (this.ExpenseCtrlRuleInfoList != null &&
                    this.ExpenseCtrlRuleInfoList.Equals(input.ExpenseCtrlRuleInfoList))
                ) && 
                (
                    this.ExpenseTypeSubCategory == input.ExpenseTypeSubCategory ||
                    (this.ExpenseTypeSubCategory != null &&
                    this.ExpenseTypeSubCategory.Equals(input.ExpenseTypeSubCategory))
                ) && 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && 
                (
                    this.OpenRuleId == input.OpenRuleId ||
                    (this.OpenRuleId != null &&
                    this.OpenRuleId.Equals(input.OpenRuleId))
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.PaymentPolicy == input.PaymentPolicy ||
                    (this.PaymentPolicy != null &&
                    this.PaymentPolicy.Equals(input.PaymentPolicy))
                ) && 
                (
                    this.PersonalQrcodeMode == input.PersonalQrcodeMode ||
                    this.PersonalQrcodeMode.Equals(input.PersonalQrcodeMode)
                ) && 
                (
                    this.StandardConditionInfoList == input.StandardConditionInfoList ||
                    this.StandardConditionInfoList != null &&
                    input.StandardConditionInfoList != null &&
                    this.StandardConditionInfoList.SequenceEqual(input.StandardConditionInfoList)
                ) && 
                (
                    this.StandardDesc == input.StandardDesc ||
                    (this.StandardDesc != null &&
                    this.StandardDesc.Equals(input.StandardDesc))
                ) && 
                (
                    this.StandardName == input.StandardName ||
                    (this.StandardName != null &&
                    this.StandardName.Equals(input.StandardName))
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
                if (this.AssetShareSourceInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AssetShareSourceInfo.GetHashCode();
                }
                if (this.ConsumeMode != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeMode.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.ExpenseCtrlRuleInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseCtrlRuleInfoList.GetHashCode();
                }
                if (this.ExpenseTypeSubCategory != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseTypeSubCategory.GetHashCode();
                }
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.OpenRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenRuleId.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.PaymentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentPolicy.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PersonalQrcodeMode.GetHashCode();
                if (this.StandardConditionInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardConditionInfoList.GetHashCode();
                }
                if (this.StandardDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StandardDesc.GetHashCode();
                }
                if (this.StandardName != null)
                {
                    hashCode = (hashCode * 59) + this.StandardName.GetHashCode();
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
