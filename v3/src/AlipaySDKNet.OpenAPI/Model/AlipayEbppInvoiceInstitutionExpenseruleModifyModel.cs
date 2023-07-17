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
    /// AlipayEbppInvoiceInstitutionExpenseruleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionExpenseruleModifyModel")]
    public partial class AlipayEbppInvoiceInstitutionExpenseruleModifyModel : IEquatable<AlipayEbppInvoiceInstitutionExpenseruleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionExpenseruleModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户id.</param>
        /// <param name="action">修改使用规则.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="assetShareSourceInfo">assetShareSourceInfo.</param>
        /// <param name="consumeMode">该使用规则支持的资产消费模式，不填写则为默认模式，默认模式下有余额时使用余额，没有余额则使用规则中的限额，点券模式为只能使用点券，点券+余额模式为可以使用点券和余额。.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="expenseCtrlRuleInfoList">使用规则条件列表（已废弃）.</param>
        /// <param name="institutionId">制度id.</param>
        /// <param name="openRuleId">开票规则id.</param>
        /// <param name="paymentPolicy">当笔消费金额大于规则可用余额时，用于控制支付策略.</param>
        /// <param name="standardConditionInfoList">规则条件列表.</param>
        /// <param name="standardDesc">规则描述.</param>
        /// <param name="standardId">使用规则id.</param>
        /// <param name="standardName">规则名称.</param>
        public AlipayEbppInvoiceInstitutionExpenseruleModifyModel(string accountId = default(string), string action = default(string), string agreementNo = default(string), AssetShareSourceInfo assetShareSourceInfo = default(AssetShareSourceInfo), string consumeMode = default(string), string enterpriseId = default(string), List<ExpenseCtrRuleInfo> expenseCtrlRuleInfoList = default(List<ExpenseCtrRuleInfo>), string institutionId = default(string), string openRuleId = default(string), string paymentPolicy = default(string), List<StandardConditionInfo> standardConditionInfoList = default(List<StandardConditionInfo>), string standardDesc = default(string), string standardId = default(string), string standardName = default(string))
        {
            this.AccountId = accountId;
            this.Action = action;
            this.AgreementNo = agreementNo;
            this.AssetShareSourceInfo = assetShareSourceInfo;
            this.ConsumeMode = consumeMode;
            this.EnterpriseId = enterpriseId;
            this.ExpenseCtrlRuleInfoList = expenseCtrlRuleInfoList;
            this.InstitutionId = institutionId;
            this.OpenRuleId = openRuleId;
            this.PaymentPolicy = paymentPolicy;
            this.StandardConditionInfoList = standardConditionInfoList;
            this.StandardDesc = standardDesc;
            this.StandardId = standardId;
            this.StandardName = standardName;
        }

        /// <summary>
        /// 企业共同账户id
        /// </summary>
        /// <value>企业共同账户id</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改使用规则
        /// </summary>
        /// <value>修改使用规则</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// Gets or Sets AssetShareSourceInfo
        /// </summary>
        [DataMember(Name = "asset_share_source_info", EmitDefaultValue = false)]
        public AssetShareSourceInfo AssetShareSourceInfo { get; set; }

        /// <summary>
        /// 该使用规则支持的资产消费模式，不填写则为默认模式，默认模式下有余额时使用余额，没有余额则使用规则中的限额，点券模式为只能使用点券，点券+余额模式为可以使用点券和余额。
        /// </summary>
        /// <value>该使用规则支持的资产消费模式，不填写则为默认模式，默认模式下有余额时使用余额，没有余额则使用规则中的限额，点券模式为只能使用点券，点券+余额模式为可以使用点券和余额。</value>
        [DataMember(Name = "consume_mode", EmitDefaultValue = false)]
        public string ConsumeMode { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 使用规则条件列表（已废弃）
        /// </summary>
        /// <value>使用规则条件列表（已废弃）</value>
        [DataMember(Name = "expense_ctrl_rule_info_list", EmitDefaultValue = false)]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

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
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略
        /// </summary>
        /// <value>当笔消费金额大于规则可用余额时，用于控制支付策略</value>
        [DataMember(Name = "payment_policy", EmitDefaultValue = false)]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 规则条件列表
        /// </summary>
        /// <value>规则条件列表</value>
        [DataMember(Name = "standard_condition_info_list", EmitDefaultValue = false)]
        public List<StandardConditionInfo> StandardConditionInfoList { get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        /// <value>规则描述</value>
        [DataMember(Name = "standard_desc", EmitDefaultValue = false)]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 使用规则id
        /// </summary>
        /// <value>使用规则id</value>
        [DataMember(Name = "standard_id", EmitDefaultValue = false)]
        public string StandardId { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        /// <value>规则名称</value>
        [DataMember(Name = "standard_name", EmitDefaultValue = false)]
        public string StandardName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionExpenseruleModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AssetShareSourceInfo: ").Append(AssetShareSourceInfo).Append("\n");
            sb.Append("  ConsumeMode: ").Append(ConsumeMode).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  ExpenseCtrlRuleInfoList: ").Append(ExpenseCtrlRuleInfoList).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  OpenRuleId: ").Append(OpenRuleId).Append("\n");
            sb.Append("  PaymentPolicy: ").Append(PaymentPolicy).Append("\n");
            sb.Append("  StandardConditionInfoList: ").Append(StandardConditionInfoList).Append("\n");
            sb.Append("  StandardDesc: ").Append(StandardDesc).Append("\n");
            sb.Append("  StandardId: ").Append(StandardId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionExpenseruleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionExpenseruleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionExpenseruleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionExpenseruleModifyModel input)
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                    this.ExpenseCtrlRuleInfoList != null &&
                    input.ExpenseCtrlRuleInfoList != null &&
                    this.ExpenseCtrlRuleInfoList.SequenceEqual(input.ExpenseCtrlRuleInfoList)
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
                    this.PaymentPolicy == input.PaymentPolicy ||
                    (this.PaymentPolicy != null &&
                    this.PaymentPolicy.Equals(input.PaymentPolicy))
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
                    this.StandardId == input.StandardId ||
                    (this.StandardId != null &&
                    this.StandardId.Equals(input.StandardId))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
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
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.OpenRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenRuleId.GetHashCode();
                }
                if (this.PaymentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentPolicy.GetHashCode();
                }
                if (this.StandardConditionInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardConditionInfoList.GetHashCode();
                }
                if (this.StandardDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StandardDesc.GetHashCode();
                }
                if (this.StandardId != null)
                {
                    hashCode = (hashCode * 59) + this.StandardId.GetHashCode();
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
