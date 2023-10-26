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
    /// AlipayFundTransCommonQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransCommonQueryResponseModel")]
    public partial class AlipayFundTransCommonQueryResponseModel : IEquatable<AlipayFundTransCommonQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransCommonQueryResponseModel" /> class.
        /// </summary>
        /// <param name="arrivalTimeEnd">预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。  注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。.</param>
        /// <param name="deductBillInfo">商户查询代扣订单信息时返回其在代扣请求中传入的账单属性.</param>
        /// <param name="errorCode">查询到的订单状态为FAIL失败或REFUND退票时，返回错误代码.</param>
        /// <param name="failReason">查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。.</param>
        /// <param name="orderFee">预计收费金额（元），转账到银行卡专用，数字格式，精确到小数点后2位，转账失败或转账受理失败不返回。.</param>
        /// <param name="orderId">支付宝转账单据号，查询失败不返回。.</param>
        /// <param name="outBizNo">商户订单号.</param>
        /// <param name="passbackParams">商户回传参数.</param>
        /// <param name="payDate">支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。.</param>
        /// <param name="payFundOrderId">支付宝支付资金流水号，转账失败不返回。.</param>
        /// <param name="settleSerialNo">金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400.</param>
        /// <param name="status">转账单据状态。可能出现的状态如下： SUCCESS：转账成功； WAIT_PAY：等待支付； CLOSED：订单超时关闭； FAIL：失败（适用于\&quot;单笔转账到银行卡\&quot;）； DEALING：处理中（适用于\&quot;单笔转账到银行卡\&quot;）； REFUND：退票（适用于\&quot;单笔转账到银行卡\&quot;）； alipay.fund.trans.app.pay涉及的状态： WAIT_PAY、SUCCESS、CLOSED alipay.fund.trans.refund涉及的状态：SUCCESS alipay.fund.trans.uni.transfer涉及的状态：SUCCESS、FAIL、DEALING、REFUND.</param>
        /// <param name="subOrderErrorCode">特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景.</param>
        /// <param name="subOrderFailReason">特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景.</param>
        /// <param name="subOrderStatus">退款子单失败状态.</param>
        /// <param name="transAmount">付款金额，收银台场景下付款成功后的支付金额，订单状态为SUCCESS才返回，其他状态不返回。.</param>
        /// <param name="transferBillInfo">商户在查询代发订单信息时返回其在代发请求中传入的账单属性。.</param>
        public AlipayFundTransCommonQueryResponseModel(string arrivalTimeEnd = default(string), string deductBillInfo = default(string), string errorCode = default(string), string failReason = default(string), string orderFee = default(string), string orderId = default(string), string outBizNo = default(string), string passbackParams = default(string), string payDate = default(string), string payFundOrderId = default(string), string settleSerialNo = default(string), string status = default(string), string subOrderErrorCode = default(string), string subOrderFailReason = default(string), string subOrderStatus = default(string), string transAmount = default(string), string transferBillInfo = default(string))
        {
            this.ArrivalTimeEnd = arrivalTimeEnd;
            this.DeductBillInfo = deductBillInfo;
            this.ErrorCode = errorCode;
            this.FailReason = failReason;
            this.OrderFee = orderFee;
            this.OrderId = orderId;
            this.OutBizNo = outBizNo;
            this.PassbackParams = passbackParams;
            this.PayDate = payDate;
            this.PayFundOrderId = payFundOrderId;
            this.SettleSerialNo = settleSerialNo;
            this.Status = status;
            this.SubOrderErrorCode = subOrderErrorCode;
            this.SubOrderFailReason = subOrderFailReason;
            this.SubOrderStatus = subOrderStatus;
            this.TransAmount = transAmount;
            this.TransferBillInfo = transferBillInfo;
        }

        /// <summary>
        /// 预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。  注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。
        /// </summary>
        /// <value>预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。  注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。</value>
        [DataMember(Name = "arrival_time_end", EmitDefaultValue = false)]
        public string ArrivalTimeEnd { get; set; }

        /// <summary>
        /// 商户查询代扣订单信息时返回其在代扣请求中传入的账单属性
        /// </summary>
        /// <value>商户查询代扣订单信息时返回其在代扣请求中传入的账单属性</value>
        [DataMember(Name = "deduct_bill_info", EmitDefaultValue = false)]
        public string DeductBillInfo { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回错误代码
        /// </summary>
        /// <value>查询到的订单状态为FAIL失败或REFUND退票时，返回错误代码</value>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。
        /// </summary>
        /// <value>查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 预计收费金额（元），转账到银行卡专用，数字格式，精确到小数点后2位，转账失败或转账受理失败不返回。
        /// </summary>
        /// <value>预计收费金额（元），转账到银行卡专用，数字格式，精确到小数点后2位，转账失败或转账受理失败不返回。</value>
        [DataMember(Name = "order_fee", EmitDefaultValue = false)]
        public string OrderFee { get; set; }

        /// <summary>
        /// 支付宝转账单据号，查询失败不返回。
        /// </summary>
        /// <value>支付宝转账单据号，查询失败不返回。</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <value>商户订单号</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户回传参数
        /// </summary>
        /// <value>商户回传参数</value>
        [DataMember(Name = "passback_params", EmitDefaultValue = false)]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。
        /// </summary>
        /// <value>支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。</value>
        [DataMember(Name = "pay_date", EmitDefaultValue = false)]
        public string PayDate { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号，转账失败不返回。
        /// </summary>
        /// <value>支付宝支付资金流水号，转账失败不返回。</value>
        [DataMember(Name = "pay_fund_order_id", EmitDefaultValue = false)]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400
        /// </summary>
        /// <value>金融机构发起签约类、支付类、差错类业务时，应为每笔业务分配唯一的交易流水号。31位交易流水号组成规则为：“8位日期”+“16位序列号”+“1位预留位”+“6位控制位”，其中： a）“8位日期”为系统当前日期，ISODate格式：“YYYYMMDD” b）“16位序列号”由金融机构生成，金融机构应确保该值在网联当日唯一 c）“1位预留位”由平台分配 d）“6位控制位”由金融机构通过平台获取 例如：2023052993044491260542090100400</value>
        [DataMember(Name = "settle_serial_no", EmitDefaultValue = false)]
        public string SettleSerialNo { get; set; }

        /// <summary>
        /// 转账单据状态。可能出现的状态如下： SUCCESS：转账成功； WAIT_PAY：等待支付； CLOSED：订单超时关闭； FAIL：失败（适用于\&quot;单笔转账到银行卡\&quot;）； DEALING：处理中（适用于\&quot;单笔转账到银行卡\&quot;）； REFUND：退票（适用于\&quot;单笔转账到银行卡\&quot;）； alipay.fund.trans.app.pay涉及的状态： WAIT_PAY、SUCCESS、CLOSED alipay.fund.trans.refund涉及的状态：SUCCESS alipay.fund.trans.uni.transfer涉及的状态：SUCCESS、FAIL、DEALING、REFUND
        /// </summary>
        /// <value>转账单据状态。可能出现的状态如下： SUCCESS：转账成功； WAIT_PAY：等待支付； CLOSED：订单超时关闭； FAIL：失败（适用于\&quot;单笔转账到银行卡\&quot;）； DEALING：处理中（适用于\&quot;单笔转账到银行卡\&quot;）； REFUND：退票（适用于\&quot;单笔转账到银行卡\&quot;）； alipay.fund.trans.app.pay涉及的状态： WAIT_PAY、SUCCESS、CLOSED alipay.fund.trans.refund涉及的状态：SUCCESS alipay.fund.trans.uni.transfer涉及的状态：SUCCESS、FAIL、DEALING、REFUND</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景
        /// </summary>
        /// <value>特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景</value>
        [DataMember(Name = "sub_order_error_code", EmitDefaultValue = false)]
        public string SubOrderErrorCode { get; set; }

        /// <summary>
        /// 特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景
        /// </summary>
        /// <value>特殊场景提供，当子单出现异常导致主单失败或者退款时，会提供此字段，用于透出子单具体的错误场景</value>
        [DataMember(Name = "sub_order_fail_reason", EmitDefaultValue = false)]
        public string SubOrderFailReason { get; set; }

        /// <summary>
        /// 退款子单失败状态
        /// </summary>
        /// <value>退款子单失败状态</value>
        [DataMember(Name = "sub_order_status", EmitDefaultValue = false)]
        public string SubOrderStatus { get; set; }

        /// <summary>
        /// 付款金额，收银台场景下付款成功后的支付金额，订单状态为SUCCESS才返回，其他状态不返回。
        /// </summary>
        /// <value>付款金额，收银台场景下付款成功后的支付金额，订单状态为SUCCESS才返回，其他状态不返回。</value>
        [DataMember(Name = "trans_amount", EmitDefaultValue = false)]
        public string TransAmount { get; set; }

        /// <summary>
        /// 商户在查询代发订单信息时返回其在代发请求中传入的账单属性。
        /// </summary>
        /// <value>商户在查询代发订单信息时返回其在代发请求中传入的账单属性。</value>
        [DataMember(Name = "transfer_bill_info", EmitDefaultValue = false)]
        public string TransferBillInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransCommonQueryResponseModel {\n");
            sb.Append("  ArrivalTimeEnd: ").Append(ArrivalTimeEnd).Append("\n");
            sb.Append("  DeductBillInfo: ").Append(DeductBillInfo).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  OrderFee: ").Append(OrderFee).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PassbackParams: ").Append(PassbackParams).Append("\n");
            sb.Append("  PayDate: ").Append(PayDate).Append("\n");
            sb.Append("  PayFundOrderId: ").Append(PayFundOrderId).Append("\n");
            sb.Append("  SettleSerialNo: ").Append(SettleSerialNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubOrderErrorCode: ").Append(SubOrderErrorCode).Append("\n");
            sb.Append("  SubOrderFailReason: ").Append(SubOrderFailReason).Append("\n");
            sb.Append("  SubOrderStatus: ").Append(SubOrderStatus).Append("\n");
            sb.Append("  TransAmount: ").Append(TransAmount).Append("\n");
            sb.Append("  TransferBillInfo: ").Append(TransferBillInfo).Append("\n");
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
            return this.Equals(input as AlipayFundTransCommonQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransCommonQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransCommonQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransCommonQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ArrivalTimeEnd == input.ArrivalTimeEnd ||
                    (this.ArrivalTimeEnd != null &&
                    this.ArrivalTimeEnd.Equals(input.ArrivalTimeEnd))
                ) && 
                (
                    this.DeductBillInfo == input.DeductBillInfo ||
                    (this.DeductBillInfo != null &&
                    this.DeductBillInfo.Equals(input.DeductBillInfo))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.OrderFee == input.OrderFee ||
                    (this.OrderFee != null &&
                    this.OrderFee.Equals(input.OrderFee))
                ) && 
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
                    this.PassbackParams == input.PassbackParams ||
                    (this.PassbackParams != null &&
                    this.PassbackParams.Equals(input.PassbackParams))
                ) && 
                (
                    this.PayDate == input.PayDate ||
                    (this.PayDate != null &&
                    this.PayDate.Equals(input.PayDate))
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
                    this.SubOrderErrorCode == input.SubOrderErrorCode ||
                    (this.SubOrderErrorCode != null &&
                    this.SubOrderErrorCode.Equals(input.SubOrderErrorCode))
                ) && 
                (
                    this.SubOrderFailReason == input.SubOrderFailReason ||
                    (this.SubOrderFailReason != null &&
                    this.SubOrderFailReason.Equals(input.SubOrderFailReason))
                ) && 
                (
                    this.SubOrderStatus == input.SubOrderStatus ||
                    (this.SubOrderStatus != null &&
                    this.SubOrderStatus.Equals(input.SubOrderStatus))
                ) && 
                (
                    this.TransAmount == input.TransAmount ||
                    (this.TransAmount != null &&
                    this.TransAmount.Equals(input.TransAmount))
                ) && 
                (
                    this.TransferBillInfo == input.TransferBillInfo ||
                    (this.TransferBillInfo != null &&
                    this.TransferBillInfo.Equals(input.TransferBillInfo))
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
                if (this.ArrivalTimeEnd != null)
                {
                    hashCode = (hashCode * 59) + this.ArrivalTimeEnd.GetHashCode();
                }
                if (this.DeductBillInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DeductBillInfo.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.OrderFee != null)
                {
                    hashCode = (hashCode * 59) + this.OrderFee.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PassbackParams != null)
                {
                    hashCode = (hashCode * 59) + this.PassbackParams.GetHashCode();
                }
                if (this.PayDate != null)
                {
                    hashCode = (hashCode * 59) + this.PayDate.GetHashCode();
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
                if (this.SubOrderErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubOrderErrorCode.GetHashCode();
                }
                if (this.SubOrderFailReason != null)
                {
                    hashCode = (hashCode * 59) + this.SubOrderFailReason.GetHashCode();
                }
                if (this.SubOrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SubOrderStatus.GetHashCode();
                }
                if (this.TransAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TransAmount.GetHashCode();
                }
                if (this.TransferBillInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TransferBillInfo.GetHashCode();
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
