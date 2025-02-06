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
    /// AlipayTradeFastpayRefundQueryModel
    /// </summary>
    [DataContract(Name = "AlipayTradeFastpayRefundQueryModel")]
    public partial class AlipayTradeFastpayRefundQueryModel : IEquatable<AlipayTradeFastpayRefundQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeFastpayRefundQueryModel" /> class.
        /// </summary>
        /// <param name="orgPid">银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;.</param>
        /// <param name="outRequestNo">退款请求号。 请求退款接口时，传入的退款请求号，如果在退款请求时未传入，则该值为创建交易时的商户订单号。.</param>
        /// <param name="outTradeNo">商户订单号。 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no.</param>
        /// <param name="queryOptions">查询选项，商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。枚举支持： refund_detail_item_list：本次退款使用的资金渠道； gmt_refund_pay：退款执行成功的时间； deposit_back_info：银行卡冲退信息；.</param>
        /// <param name="tradeNo">支付宝交易号。 和商户订单号不能同时为空.</param>
        public AlipayTradeFastpayRefundQueryModel(string orgPid = default(string), string outRequestNo = default(string), string outTradeNo = default(string), List<string> queryOptions = default(List<string>), string tradeNo = default(string))
        {
            this.OrgPid = orgPid;
            this.OutRequestNo = outRequestNo;
            this.OutTradeNo = outTradeNo;
            this.QueryOptions = queryOptions;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;
        /// </summary>
        /// <value>银行间联模式下有用，其它场景请不要使用；  双联通过该参数指定需要查询的交易所属收单机构的pid;</value>
        [DataMember(Name = "org_pid", EmitDefaultValue = false)]
        public string OrgPid { get; set; }

        /// <summary>
        /// 退款请求号。 请求退款接口时，传入的退款请求号，如果在退款请求时未传入，则该值为创建交易时的商户订单号。
        /// </summary>
        /// <value>退款请求号。 请求退款接口时，传入的退款请求号，如果在退款请求时未传入，则该值为创建交易时的商户订单号。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no
        /// </summary>
        /// <value>商户订单号。 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 查询选项，商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。枚举支持： refund_detail_item_list：本次退款使用的资金渠道； gmt_refund_pay：退款执行成功的时间； deposit_back_info：银行卡冲退信息；
        /// </summary>
        /// <value>查询选项，商户通过上送该参数来定制同步需要额外返回的信息字段，数组格式。枚举支持： refund_detail_item_list：本次退款使用的资金渠道； gmt_refund_pay：退款执行成功的时间； deposit_back_info：银行卡冲退信息；</value>
        [DataMember(Name = "query_options", EmitDefaultValue = false)]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// 支付宝交易号。 和商户订单号不能同时为空
        /// </summary>
        /// <value>支付宝交易号。 和商户订单号不能同时为空</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeFastpayRefundQueryModel {\n");
            sb.Append("  OrgPid: ").Append(OrgPid).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  QueryOptions: ").Append(QueryOptions).Append("\n");
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
            return this.Equals(input as AlipayTradeFastpayRefundQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeFastpayRefundQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeFastpayRefundQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeFastpayRefundQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrgPid == input.OrgPid ||
                    (this.OrgPid != null &&
                    this.OrgPid.Equals(input.OrgPid))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.QueryOptions == input.QueryOptions ||
                    this.QueryOptions != null &&
                    input.QueryOptions != null &&
                    this.QueryOptions.SequenceEqual(input.QueryOptions)
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
                if (this.OrgPid != null)
                {
                    hashCode = (hashCode * 59) + this.OrgPid.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.QueryOptions != null)
                {
                    hashCode = (hashCode * 59) + this.QueryOptions.GetHashCode();
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
