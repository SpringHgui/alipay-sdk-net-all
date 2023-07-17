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
    /// TradeSettleInfo
    /// </summary>
    [DataContract(Name = "TradeSettleInfo")]
    public partial class TradeSettleInfo : IEquatable<TradeSettleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeSettleInfo" /> class.
        /// </summary>
        /// <param name="tradeSettleDetailList">交易结算明细信息.</param>
        /// <param name="tradeUnsettledAmount">直付通账期、直连账期下返回，其他场景为空，表示一笔订单剩余待结算金额.</param>
        public TradeSettleInfo(List<TradeSettleDetail> tradeSettleDetailList = default(List<TradeSettleDetail>), string tradeUnsettledAmount = default(string))
        {
            this.TradeSettleDetailList = tradeSettleDetailList;
            this.TradeUnsettledAmount = tradeUnsettledAmount;
        }

        /// <summary>
        /// 交易结算明细信息
        /// </summary>
        /// <value>交易结算明细信息</value>
        [DataMember(Name = "trade_settle_detail_list", EmitDefaultValue = false)]
        public List<TradeSettleDetail> TradeSettleDetailList { get; set; }

        /// <summary>
        /// 直付通账期、直连账期下返回，其他场景为空，表示一笔订单剩余待结算金额
        /// </summary>
        /// <value>直付通账期、直连账期下返回，其他场景为空，表示一笔订单剩余待结算金额</value>
        [DataMember(Name = "trade_unsettled_amount", EmitDefaultValue = false)]
        public string TradeUnsettledAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeSettleInfo {\n");
            sb.Append("  TradeSettleDetailList: ").Append(TradeSettleDetailList).Append("\n");
            sb.Append("  TradeUnsettledAmount: ").Append(TradeUnsettledAmount).Append("\n");
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
            return this.Equals(input as TradeSettleInfo);
        }

        /// <summary>
        /// Returns true if TradeSettleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeSettleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeSettleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TradeSettleDetailList == input.TradeSettleDetailList ||
                    this.TradeSettleDetailList != null &&
                    input.TradeSettleDetailList != null &&
                    this.TradeSettleDetailList.SequenceEqual(input.TradeSettleDetailList)
                ) && 
                (
                    this.TradeUnsettledAmount == input.TradeUnsettledAmount ||
                    (this.TradeUnsettledAmount != null &&
                    this.TradeUnsettledAmount.Equals(input.TradeUnsettledAmount))
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
                if (this.TradeSettleDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.TradeSettleDetailList.GetHashCode();
                }
                if (this.TradeUnsettledAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TradeUnsettledAmount.GetHashCode();
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
