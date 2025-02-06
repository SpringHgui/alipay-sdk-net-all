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
    /// AlipayTradeOrderSettleModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOrderSettleModel")]
    public partial class AlipayTradeOrderSettleModel : IEquatable<AlipayTradeOrderSettleModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderSettleModel" /> class.
        /// </summary>
        /// <param name="extendParams">extendParams.</param>
        /// <param name="operatorId">操作员 ID，商家自定义操作员编号。.</param>
        /// <param name="outRequestNo">结算请求流水号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。.</param>
        /// <param name="royaltyMode">分账模式，目前有两种分账同步执行sync，分账异步执行async，不传默认同步执行.</param>
        /// <param name="royaltyParameters">分账明细信息。单独调用分账完结时，可以不传此参数。其他场景必传。 注意：商家分账场景下分账收入方 trans_in 只支持支付宝账户，不支持使用 cardAliasNo 卡编号。.</param>
        /// <param name="tradeNo">支付宝订单号.</param>
        public AlipayTradeOrderSettleModel(SettleExtendParams extendParams = default(SettleExtendParams), string operatorId = default(string), string outRequestNo = default(string), string royaltyMode = default(string), List<OpenApiRoyaltyDetailInfoPojo> royaltyParameters = default(List<OpenApiRoyaltyDetailInfoPojo>), string tradeNo = default(string))
        {
            this.ExtendParams = extendParams;
            this.OperatorId = operatorId;
            this.OutRequestNo = outRequestNo;
            this.RoyaltyMode = royaltyMode;
            this.RoyaltyParameters = royaltyParameters;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// Gets or Sets ExtendParams
        /// </summary>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public SettleExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 操作员 ID，商家自定义操作员编号。
        /// </summary>
        /// <value>操作员 ID，商家自定义操作员编号。</value>
        [DataMember(Name = "operator_id", EmitDefaultValue = false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        /// <value>结算请求流水号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账模式，目前有两种分账同步执行sync，分账异步执行async，不传默认同步执行
        /// </summary>
        /// <value>分账模式，目前有两种分账同步执行sync，分账异步执行async，不传默认同步执行</value>
        [DataMember(Name = "royalty_mode", EmitDefaultValue = false)]
        public string RoyaltyMode { get; set; }

        /// <summary>
        /// 分账明细信息。单独调用分账完结时，可以不传此参数。其他场景必传。 注意：商家分账场景下分账收入方 trans_in 只支持支付宝账户，不支持使用 cardAliasNo 卡编号。
        /// </summary>
        /// <value>分账明细信息。单独调用分账完结时，可以不传此参数。其他场景必传。 注意：商家分账场景下分账收入方 trans_in 只支持支付宝账户，不支持使用 cardAliasNo 卡编号。</value>
        [DataMember(Name = "royalty_parameters", EmitDefaultValue = false)]
        public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        /// <value>支付宝订单号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeOrderSettleModel {\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RoyaltyMode: ").Append(RoyaltyMode).Append("\n");
            sb.Append("  RoyaltyParameters: ").Append(RoyaltyParameters).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeOrderSettleModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOrderSettleModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOrderSettleModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOrderSettleModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.OperatorId == input.OperatorId ||
                    (this.OperatorId != null &&
                    this.OperatorId.Equals(input.OperatorId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.RoyaltyMode == input.RoyaltyMode ||
                    (this.RoyaltyMode != null &&
                    this.RoyaltyMode.Equals(input.RoyaltyMode))
                ) && 
                (
                    this.RoyaltyParameters == input.RoyaltyParameters ||
                    this.RoyaltyParameters != null &&
                    input.RoyaltyParameters != null &&
                    this.RoyaltyParameters.SequenceEqual(input.RoyaltyParameters)
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.OperatorId != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RoyaltyMode != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyMode.GetHashCode();
                }
                if (this.RoyaltyParameters != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyParameters.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
