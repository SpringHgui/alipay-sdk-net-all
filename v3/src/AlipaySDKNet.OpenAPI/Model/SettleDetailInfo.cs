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
    /// SettleDetailInfo
    /// </summary>
    [DataContract(Name = "SettleDetailInfo")]
    public partial class SettleDetailInfo : IEquatable<SettleDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettleDetailInfo" /> class.
        /// </summary>
        /// <param name="actualAmount">仅在直付通账期模式下，当一笔交易需要分多次发起部分确认结算时使用，表示本次确认结算的实际结算金额。传递本字段后，原amount字段不再生效，结算金额以本字段为准。如已经发生过部分确认结算、不传递本字段则默认按剩余待结算金额一次性结算。.</param>
        /// <param name="amount">结算的金额，单位为元。在创建订单和支付接口时必须和交易金额相同。在结算确认接口时必须等于交易金额减去已退款金额。直付通账期模式下，如使用部分结算能力、传递了actual_amount字段，则忽略本字段的校验、可不传。.</param>
        /// <param name="settleEntityId">结算主体标识。当结算主体类型为SecondMerchant时，为二级商户的SecondMerchantID；当结算主体类型为Store时，为门店的外标。.</param>
        /// <param name="settleEntityType">结算主体类型。.</param>
        /// <param name="summaryDimension">结算汇总维度，按照这个维度汇总成批次结算，由商户指定。  目前需要和结算收款方账户类型为cardAliasNo配合使用.</param>
        /// <param name="transIn">结算收款方。当结算收款方类型是cardAliasNo时，本参数为用户在支付宝绑定的卡编号；结算收款方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；当结算收款方类型是loginName时，本参数为用户的支付宝登录号；当结算收款方类型是defaultSettle时，本参数不能传值，保持为空。.</param>
        /// <param name="transInType">结算收款方的账户类型。.</param>
        public SettleDetailInfo(string actualAmount = default(string), string amount = default(string), string settleEntityId = default(string), string settleEntityType = default(string), string summaryDimension = default(string), string transIn = default(string), string transInType = default(string))
        {
            this.ActualAmount = actualAmount;
            this.Amount = amount;
            this.SettleEntityId = settleEntityId;
            this.SettleEntityType = settleEntityType;
            this.SummaryDimension = summaryDimension;
            this.TransIn = transIn;
            this.TransInType = transInType;
        }

        /// <summary>
        /// 仅在直付通账期模式下，当一笔交易需要分多次发起部分确认结算时使用，表示本次确认结算的实际结算金额。传递本字段后，原amount字段不再生效，结算金额以本字段为准。如已经发生过部分确认结算、不传递本字段则默认按剩余待结算金额一次性结算。
        /// </summary>
        /// <value>仅在直付通账期模式下，当一笔交易需要分多次发起部分确认结算时使用，表示本次确认结算的实际结算金额。传递本字段后，原amount字段不再生效，结算金额以本字段为准。如已经发生过部分确认结算、不传递本字段则默认按剩余待结算金额一次性结算。</value>
        [DataMember(Name = "actual_amount", EmitDefaultValue = false)]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 结算的金额，单位为元。在创建订单和支付接口时必须和交易金额相同。在结算确认接口时必须等于交易金额减去已退款金额。直付通账期模式下，如使用部分结算能力、传递了actual_amount字段，则忽略本字段的校验、可不传。
        /// </summary>
        /// <value>结算的金额，单位为元。在创建订单和支付接口时必须和交易金额相同。在结算确认接口时必须等于交易金额减去已退款金额。直付通账期模式下，如使用部分结算能力、传递了actual_amount字段，则忽略本字段的校验、可不传。</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 结算主体标识。当结算主体类型为SecondMerchant时，为二级商户的SecondMerchantID；当结算主体类型为Store时，为门店的外标。
        /// </summary>
        /// <value>结算主体标识。当结算主体类型为SecondMerchant时，为二级商户的SecondMerchantID；当结算主体类型为Store时，为门店的外标。</value>
        [DataMember(Name = "settle_entity_id", EmitDefaultValue = false)]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型。
        /// </summary>
        /// <value>结算主体类型。</value>
        [DataMember(Name = "settle_entity_type", EmitDefaultValue = false)]
        public string SettleEntityType { get; set; }

        /// <summary>
        /// 结算汇总维度，按照这个维度汇总成批次结算，由商户指定。  目前需要和结算收款方账户类型为cardAliasNo配合使用
        /// </summary>
        /// <value>结算汇总维度，按照这个维度汇总成批次结算，由商户指定。  目前需要和结算收款方账户类型为cardAliasNo配合使用</value>
        [DataMember(Name = "summary_dimension", EmitDefaultValue = false)]
        public string SummaryDimension { get; set; }

        /// <summary>
        /// 结算收款方。当结算收款方类型是cardAliasNo时，本参数为用户在支付宝绑定的卡编号；结算收款方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；当结算收款方类型是loginName时，本参数为用户的支付宝登录号；当结算收款方类型是defaultSettle时，本参数不能传值，保持为空。
        /// </summary>
        /// <value>结算收款方。当结算收款方类型是cardAliasNo时，本参数为用户在支付宝绑定的卡编号；结算收款方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；当结算收款方类型是loginName时，本参数为用户的支付宝登录号；当结算收款方类型是defaultSettle时，本参数不能传值，保持为空。</value>
        [DataMember(Name = "trans_in", EmitDefaultValue = false)]
        public string TransIn { get; set; }

        /// <summary>
        /// 结算收款方的账户类型。
        /// </summary>
        /// <value>结算收款方的账户类型。</value>
        [DataMember(Name = "trans_in_type", EmitDefaultValue = false)]
        public string TransInType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettleDetailInfo {\n");
            sb.Append("  ActualAmount: ").Append(ActualAmount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  SettleEntityId: ").Append(SettleEntityId).Append("\n");
            sb.Append("  SettleEntityType: ").Append(SettleEntityType).Append("\n");
            sb.Append("  SummaryDimension: ").Append(SummaryDimension).Append("\n");
            sb.Append("  TransIn: ").Append(TransIn).Append("\n");
            sb.Append("  TransInType: ").Append(TransInType).Append("\n");
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
            return this.Equals(input as SettleDetailInfo);
        }

        /// <summary>
        /// Returns true if SettleDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleDetailInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActualAmount == input.ActualAmount ||
                    (this.ActualAmount != null &&
                    this.ActualAmount.Equals(input.ActualAmount))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.SettleEntityId == input.SettleEntityId ||
                    (this.SettleEntityId != null &&
                    this.SettleEntityId.Equals(input.SettleEntityId))
                ) && 
                (
                    this.SettleEntityType == input.SettleEntityType ||
                    (this.SettleEntityType != null &&
                    this.SettleEntityType.Equals(input.SettleEntityType))
                ) && 
                (
                    this.SummaryDimension == input.SummaryDimension ||
                    (this.SummaryDimension != null &&
                    this.SummaryDimension.Equals(input.SummaryDimension))
                ) && 
                (
                    this.TransIn == input.TransIn ||
                    (this.TransIn != null &&
                    this.TransIn.Equals(input.TransIn))
                ) && 
                (
                    this.TransInType == input.TransInType ||
                    (this.TransInType != null &&
                    this.TransInType.Equals(input.TransInType))
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
                if (this.ActualAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ActualAmount.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.SettleEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityId.GetHashCode();
                }
                if (this.SettleEntityType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityType.GetHashCode();
                }
                if (this.SummaryDimension != null)
                {
                    hashCode = (hashCode * 59) + this.SummaryDimension.GetHashCode();
                }
                if (this.TransIn != null)
                {
                    hashCode = (hashCode * 59) + this.TransIn.GetHashCode();
                }
                if (this.TransInType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInType.GetHashCode();
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
