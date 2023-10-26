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
    /// AlipayFundTransUniTransferResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransUniTransferResponseModel")]
    public partial class AlipayFundTransUniTransferResponseModel : IEquatable<AlipayFundTransUniTransferResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransUniTransferResponseModel" /> class.
        /// </summary>
        /// <param name="orderId">支付宝转账订单号.</param>
        /// <param name="outBizNo">商户订单号.</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号.</param>
        /// <param name="settleSerialNo">金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400.</param>
        /// <param name="status">转账单据状态。 SUCCESS（该笔转账交易成功）：成功； FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）； DEALING：处理中（转账到支付宝账户不涉及）； REFUND：退票（转账到支付宝账户不涉及）；.</param>
        /// <param name="transDate">订单支付时间，格式为yyyy-MM-dd HH:mm:ss.</param>
        public AlipayFundTransUniTransferResponseModel(string orderId = default(string), string outBizNo = default(string), string payFundOrderId = default(string), string settleSerialNo = default(string), string status = default(string), string transDate = default(string))
        {
            this.OrderId = orderId;
            this.OutBizNo = outBizNo;
            this.PayFundOrderId = payFundOrderId;
            this.SettleSerialNo = settleSerialNo;
            this.Status = status;
            this.TransDate = transDate;
        }

        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        /// <value>支付宝转账订单号</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <value>商户订单号</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号
        /// </summary>
        /// <value>支付宝支付资金流水号</value>
        [DataMember(Name = "pay_fund_order_id", EmitDefaultValue = false)]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400
        /// </summary>
        /// <value>金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400</value>
        [DataMember(Name = "settle_serial_no", EmitDefaultValue = false)]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 转账单据状态。 SUCCESS（该笔转账交易成功）：成功； FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）； DEALING：处理中（转账到支付宝账户不涉及）； REFUND：退票（转账到支付宝账户不涉及）；
        /// </summary>
        /// <value>转账单据状态。 SUCCESS（该笔转账交易成功）：成功； FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）； DEALING：处理中（转账到支付宝账户不涉及）； REFUND：退票（转账到支付宝账户不涉及）；</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 订单支付时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>订单支付时间，格式为yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "trans_date", EmitDefaultValue = false)]
        public string TransDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransUniTransferResponseModel {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PayFundOrderId: ").Append(PayFundOrderId).Append("\n");
            sb.Append("  SettleSerialNo: ").Append(SettleSerialNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransDate: ").Append(TransDate).Append("\n");
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
            return this.Equals(input as AlipayFundTransUniTransferResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransUniTransferResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransUniTransferResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransUniTransferResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PayFundOrderId == input.PayFundOrderId ||
                    (this.PayFundOrderId != null &&
                    this.PayFundOrderId.Equals(input.PayFundOrderId))
                ) && 
                (
                    this.SettleSerialNo == input.SettleSerialNo ||
                    (this.SettleSerialNo != null &&
                    this.SettleSerialNo.Equals(input.SettleSerialNo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TransDate == input.TransDate ||
                    (this.TransDate != null &&
                    this.TransDate.Equals(input.TransDate))
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PayFundOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.PayFundOrderId.GetHashCode();
                }
                if (this.SettleSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleSerialNo.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TransDate != null)
                {
                    hashCode = (hashCode * 59) + this.TransDate.GetHashCode();
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
