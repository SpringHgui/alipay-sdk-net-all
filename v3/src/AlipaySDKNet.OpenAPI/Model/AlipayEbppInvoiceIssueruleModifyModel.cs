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
    /// AlipayEbppInvoiceIssueruleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceIssueruleModifyModel")]
    public partial class AlipayEbppInvoiceIssueruleModifyModel : IEquatable<AlipayEbppInvoiceIssueruleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceIssueruleModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换).</param>
        /// <param name="action">修改类型，枚举： MODIFY_BASIC_INFO（修改发放规则基本信息）.</param>
        /// <param name="agreementNo">授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换).</param>
        /// <param name="effective">是否启用，\&quot;0\&quot;为停用，\&quot;1\&quot;为启用；.</param>
        /// <param name="effectivePeriod">生效周期（不传则不修改），不限：\&quot;{\\\&quot;all\\\&quot;:true}\&quot;.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="invalidMode">是否可累计（不传则不修改）可选值：0（不可累计）、1（可累计），2（累计天数），3（累计到固定时间）.</param>
        /// <param name="invalidModeValue">累计值.</param>
        /// <param name="issueAmountValue">发放金额（不传则不修改），单位（元）.</param>
        /// <param name="issueEndDate">发放规则的截止时间.</param>
        /// <param name="issueRuleId">发放规则id.</param>
        /// <param name="issueRuleName">发放规则名称（不传则不修改）.</param>
        /// <param name="issueStartDate">发放规则的开始时间.</param>
        /// <param name="issueType">发放类型.</param>
        /// <param name="quotaType">额度类型.</param>
        /// <param name="shareMode">是否可转赠（不传则不修改），可选值：0（不可转赠）、1（可转赠），默认为0，按城市发放不支持可转赠.</param>
        /// <param name="targetId">发放规则关联的目标值 target_type为制度时：制度id.</param>
        /// <param name="targetType">发放规则关联的目标类型.</param>
        public AlipayEbppInvoiceIssueruleModifyModel(string accountId = default(string), string action = default(string), string agreementNo = default(string), string effective = default(string), string effectivePeriod = default(string), string enterpriseId = default(string), int invalidMode = default(int), string invalidModeValue = default(string), string issueAmountValue = default(string), string issueEndDate = default(string), string issueRuleId = default(string), string issueRuleName = default(string), string issueStartDate = default(string), string issueType = default(string), string quotaType = default(string), int shareMode = default(int), string targetId = default(string), string targetType = default(string))
        {
            this.AccountId = accountId;
            this.Action = action;
            this.AgreementNo = agreementNo;
            this.Effective = effective;
            this.EffectivePeriod = effectivePeriod;
            this.EnterpriseId = enterpriseId;
            this.InvalidMode = invalidMode;
            this.InvalidModeValue = invalidModeValue;
            this.IssueAmountValue = issueAmountValue;
            this.IssueEndDate = issueEndDate;
            this.IssueRuleId = issueRuleId;
            this.IssueRuleName = issueRuleName;
            this.IssueStartDate = issueStartDate;
            this.IssueType = issueType;
            this.QuotaType = quotaType;
            this.ShareMode = shareMode;
            this.TargetId = targetId;
            this.TargetType = targetType;
        }

        /// <summary>
        /// 共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        /// <value>共同账户id（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        [Obsolete]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改类型，枚举： MODIFY_BASIC_INFO（修改发放规则基本信息）
        /// </summary>
        /// <value>修改类型，枚举： MODIFY_BASIC_INFO（修改发放规则基本信息）</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        /// <value>授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换）(该字段将废弃，不建议使用，可用enterprise_id字段替换)</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        [Obsolete]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 是否启用，\&quot;0\&quot;为停用，\&quot;1\&quot;为启用；
        /// </summary>
        /// <value>是否启用，\&quot;0\&quot;为停用，\&quot;1\&quot;为启用；</value>
        [DataMember(Name = "effective", EmitDefaultValue = false)]
        public string Effective { get; set; }

        /// <summary>
        /// 生效周期（不传则不修改），不限：\&quot;{\\\&quot;all\\\&quot;:true}\&quot;
        /// </summary>
        /// <value>生效周期（不传则不修改），不限：\&quot;{\\\&quot;all\\\&quot;:true}\&quot;</value>
        [DataMember(Name = "effective_period", EmitDefaultValue = false)]
        public string EffectivePeriod { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 是否可累计（不传则不修改）可选值：0（不可累计）、1（可累计），2（累计天数），3（累计到固定时间）
        /// </summary>
        /// <value>是否可累计（不传则不修改）可选值：0（不可累计）、1（可累计），2（累计天数），3（累计到固定时间）</value>
        [DataMember(Name = "invalid_mode", EmitDefaultValue = false)]
        public int InvalidMode { get; set; }

        /// <summary>
        /// 累计值
        /// </summary>
        /// <value>累计值</value>
        [DataMember(Name = "invalid_mode_value", EmitDefaultValue = false)]
        public string InvalidModeValue { get; set; }

        /// <summary>
        /// 发放金额（不传则不修改），单位（元）
        /// </summary>
        /// <value>发放金额（不传则不修改），单位（元）</value>
        [DataMember(Name = "issue_amount_value", EmitDefaultValue = false)]
        public string IssueAmountValue { get; set; }

        /// <summary>
        /// 发放规则的截止时间
        /// </summary>
        /// <value>发放规则的截止时间</value>
        [DataMember(Name = "issue_end_date", EmitDefaultValue = false)]
        public string IssueEndDate { get; set; }

        /// <summary>
        /// 发放规则id
        /// </summary>
        /// <value>发放规则id</value>
        [DataMember(Name = "issue_rule_id", EmitDefaultValue = false)]
        public string IssueRuleId { get; set; }

        /// <summary>
        /// 发放规则名称（不传则不修改）
        /// </summary>
        /// <value>发放规则名称（不传则不修改）</value>
        [DataMember(Name = "issue_rule_name", EmitDefaultValue = false)]
        public string IssueRuleName { get; set; }

        /// <summary>
        /// 发放规则的开始时间
        /// </summary>
        /// <value>发放规则的开始时间</value>
        [DataMember(Name = "issue_start_date", EmitDefaultValue = false)]
        public string IssueStartDate { get; set; }

        /// <summary>
        /// 发放类型
        /// </summary>
        /// <value>发放类型</value>
        [DataMember(Name = "issue_type", EmitDefaultValue = false)]
        public string IssueType { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        /// <value>额度类型</value>
        [DataMember(Name = "quota_type", EmitDefaultValue = false)]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠（不传则不修改），可选值：0（不可转赠）、1（可转赠），默认为0，按城市发放不支持可转赠
        /// </summary>
        /// <value>是否可转赠（不传则不修改），可选值：0（不可转赠）、1（可转赠），默认为0，按城市发放不支持可转赠</value>
        [DataMember(Name = "share_mode", EmitDefaultValue = false)]
        public int ShareMode { get; set; }

        /// <summary>
        /// 发放规则关联的目标值 target_type为制度时：制度id
        /// </summary>
        /// <value>发放规则关联的目标值 target_type为制度时：制度id</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 发放规则关联的目标类型
        /// </summary>
        /// <value>发放规则关联的目标类型</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceIssueruleModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  Effective: ").Append(Effective).Append("\n");
            sb.Append("  EffectivePeriod: ").Append(EffectivePeriod).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  InvalidMode: ").Append(InvalidMode).Append("\n");
            sb.Append("  InvalidModeValue: ").Append(InvalidModeValue).Append("\n");
            sb.Append("  IssueAmountValue: ").Append(IssueAmountValue).Append("\n");
            sb.Append("  IssueEndDate: ").Append(IssueEndDate).Append("\n");
            sb.Append("  IssueRuleId: ").Append(IssueRuleId).Append("\n");
            sb.Append("  IssueRuleName: ").Append(IssueRuleName).Append("\n");
            sb.Append("  IssueStartDate: ").Append(IssueStartDate).Append("\n");
            sb.Append("  IssueType: ").Append(IssueType).Append("\n");
            sb.Append("  QuotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  ShareMode: ").Append(ShareMode).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceIssueruleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceIssueruleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceIssueruleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceIssueruleModifyModel input)
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
                    this.Effective == input.Effective ||
                    (this.Effective != null &&
                    this.Effective.Equals(input.Effective))
                ) && 
                (
                    this.EffectivePeriod == input.EffectivePeriod ||
                    (this.EffectivePeriod != null &&
                    this.EffectivePeriod.Equals(input.EffectivePeriod))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.InvalidMode == input.InvalidMode ||
                    this.InvalidMode.Equals(input.InvalidMode)
                ) && 
                (
                    this.InvalidModeValue == input.InvalidModeValue ||
                    (this.InvalidModeValue != null &&
                    this.InvalidModeValue.Equals(input.InvalidModeValue))
                ) && 
                (
                    this.IssueAmountValue == input.IssueAmountValue ||
                    (this.IssueAmountValue != null &&
                    this.IssueAmountValue.Equals(input.IssueAmountValue))
                ) && 
                (
                    this.IssueEndDate == input.IssueEndDate ||
                    (this.IssueEndDate != null &&
                    this.IssueEndDate.Equals(input.IssueEndDate))
                ) && 
                (
                    this.IssueRuleId == input.IssueRuleId ||
                    (this.IssueRuleId != null &&
                    this.IssueRuleId.Equals(input.IssueRuleId))
                ) && 
                (
                    this.IssueRuleName == input.IssueRuleName ||
                    (this.IssueRuleName != null &&
                    this.IssueRuleName.Equals(input.IssueRuleName))
                ) && 
                (
                    this.IssueStartDate == input.IssueStartDate ||
                    (this.IssueStartDate != null &&
                    this.IssueStartDate.Equals(input.IssueStartDate))
                ) && 
                (
                    this.IssueType == input.IssueType ||
                    (this.IssueType != null &&
                    this.IssueType.Equals(input.IssueType))
                ) && 
                (
                    this.QuotaType == input.QuotaType ||
                    (this.QuotaType != null &&
                    this.QuotaType.Equals(input.QuotaType))
                ) && 
                (
                    this.ShareMode == input.ShareMode ||
                    this.ShareMode.Equals(input.ShareMode)
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
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
                if (this.Effective != null)
                {
                    hashCode = (hashCode * 59) + this.Effective.GetHashCode();
                }
                if (this.EffectivePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.EffectivePeriod.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvalidMode.GetHashCode();
                if (this.InvalidModeValue != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidModeValue.GetHashCode();
                }
                if (this.IssueAmountValue != null)
                {
                    hashCode = (hashCode * 59) + this.IssueAmountValue.GetHashCode();
                }
                if (this.IssueEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssueEndDate.GetHashCode();
                }
                if (this.IssueRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleId.GetHashCode();
                }
                if (this.IssueRuleName != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleName.GetHashCode();
                }
                if (this.IssueStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssueStartDate.GetHashCode();
                }
                if (this.IssueType != null)
                {
                    hashCode = (hashCode * 59) + this.IssueType.GetHashCode();
                }
                if (this.QuotaType != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShareMode.GetHashCode();
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
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
