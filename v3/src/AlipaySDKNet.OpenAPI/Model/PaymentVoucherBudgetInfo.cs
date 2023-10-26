/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// PaymentVoucherBudgetInfo
    /// </summary>
    [DataContract(Name = "PaymentVoucherBudgetInfo")]
    public partial class PaymentVoucherBudgetInfo : IEquatable<PaymentVoucherBudgetInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherBudgetInfo" /> class.
        /// </summary>
        /// <param name="amount">营销资金预算,单位元。 总预算&#x3D;优惠金额*总发券张数.</param>
        /// <param name="budgetType">营销资金预算类型 1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。 2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。.</param>
        /// <param name="rechargeInfo">rechargeInfo.</param>
        public PaymentVoucherBudgetInfo(string amount = default(string), string budgetType = default(string), PaymentVoucherRechargeInfo rechargeInfo = default(PaymentVoucherRechargeInfo))
        {
            this.Amount = amount;
            this.BudgetType = budgetType;
            this.RechargeInfo = rechargeInfo;
        }

        /// <summary>
        /// 营销资金预算,单位元。 总预算&#x3D;优惠金额*总发券张数
        /// </summary>
        /// <value>营销资金预算,单位元。 总预算&#x3D;优惠金额*总发券张数</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 营销资金预算类型 1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。 2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。
        /// </summary>
        /// <value>营销资金预算类型 1、免充值：制券方无需提前充值资金，用户核销支付券时，直接从订单原价中扣除优惠减价金额，最终只将用户实际支付的金额结算给核销商户，商户实收少于订单原价。 2.预充值:  制券方需将优惠预算提前充值到支付宝指定营销账户中，用户核销支付券时，系统从该账户可用余额中扣除优惠减价部分对应的资金，连同用户实际支付的资金，一并结算给核销商户，不影响实收。</value>
        [DataMember(Name = "budget_type", EmitDefaultValue = false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// Gets or Sets RechargeInfo
        /// </summary>
        [DataMember(Name = "recharge_info", EmitDefaultValue = false)]
        public PaymentVoucherRechargeInfo RechargeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherBudgetInfo {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BudgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  RechargeInfo: ").Append(RechargeInfo).Append("\n");
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
            return this.Equals(input as PaymentVoucherBudgetInfo);
        }

        /// <summary>
        /// Returns true if PaymentVoucherBudgetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherBudgetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherBudgetInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BudgetType == input.BudgetType ||
                    (this.BudgetType != null &&
                    this.BudgetType.Equals(input.BudgetType))
                ) && 
                (
                    this.RechargeInfo == input.RechargeInfo ||
                    (this.RechargeInfo != null &&
                    this.RechargeInfo.Equals(input.RechargeInfo))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BudgetType != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetType.GetHashCode();
                }
                if (this.RechargeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.RechargeInfo.GetHashCode();
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
