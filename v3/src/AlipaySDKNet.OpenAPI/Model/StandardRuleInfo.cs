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
    /// StandardRuleInfo
    /// </summary>
    [DataContract(Name = "StandardRuleInfo")]
    public partial class StandardRuleInfo : IEquatable<StandardRuleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StandardRuleInfo" /> class.
        /// </summary>
        /// <param name="effectiveEndDate">有效期截止.</param>
        /// <param name="effectiveStartDate">有效期起始.</param>
        /// <param name="expenseCtrlRuleInfoList">费控条件列表.</param>
        /// <param name="paymentPolicy">当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）.</param>
        /// <param name="standardDesc">费控规则说明.</param>
        /// <param name="standardId">费控规则ID.</param>
        /// <param name="standardName">费控规则名称.</param>
        public StandardRuleInfo(string effectiveEndDate = default(string), string effectiveStartDate = default(string), List<ExpenseCtrRuleInfo> expenseCtrlRuleInfoList = default(List<ExpenseCtrRuleInfo>), string paymentPolicy = default(string), string standardDesc = default(string), string standardId = default(string), string standardName = default(string))
        {
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.ExpenseCtrlRuleInfoList = expenseCtrlRuleInfoList;
            this.PaymentPolicy = paymentPolicy;
            this.StandardDesc = standardDesc;
            this.StandardId = standardId;
            this.StandardName = standardName;
        }

        /// <summary>
        /// 有效期截止
        /// </summary>
        /// <value>有效期截止</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        /// <value>有效期起始</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 费控条件列表
        /// </summary>
        /// <value>费控条件列表</value>
        [DataMember(Name = "expense_ctrl_rule_info_list", EmitDefaultValue = false)]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）
        /// </summary>
        /// <value>当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）</value>
        [DataMember(Name = "payment_policy", EmitDefaultValue = false)]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 费控规则说明
        /// </summary>
        /// <value>费控规则说明</value>
        [DataMember(Name = "standard_desc", EmitDefaultValue = false)]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 费控规则ID
        /// </summary>
        /// <value>费控规则ID</value>
        [DataMember(Name = "standard_id", EmitDefaultValue = false)]
        public string StandardId { get; set; }

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
            sb.Append("class StandardRuleInfo {\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  ExpenseCtrlRuleInfoList: ").Append(ExpenseCtrlRuleInfoList).Append("\n");
            sb.Append("  PaymentPolicy: ").Append(PaymentPolicy).Append("\n");
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
            return this.Equals(input as StandardRuleInfo);
        }

        /// <summary>
        /// Returns true if StandardRuleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of StandardRuleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StandardRuleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.ExpenseCtrlRuleInfoList == input.ExpenseCtrlRuleInfoList ||
                    this.ExpenseCtrlRuleInfoList != null &&
                    input.ExpenseCtrlRuleInfoList != null &&
                    this.ExpenseCtrlRuleInfoList.SequenceEqual(input.ExpenseCtrlRuleInfoList)
                ) && 
                (
                    this.PaymentPolicy == input.PaymentPolicy ||
                    (this.PaymentPolicy != null &&
                    this.PaymentPolicy.Equals(input.PaymentPolicy))
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
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.ExpenseCtrlRuleInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseCtrlRuleInfoList.GetHashCode();
                }
                if (this.PaymentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentPolicy.GetHashCode();
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
