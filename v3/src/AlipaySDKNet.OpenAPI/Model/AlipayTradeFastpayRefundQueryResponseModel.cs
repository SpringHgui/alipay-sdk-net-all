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
    /// AlipayTradeFastpayRefundQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeFastpayRefundQueryResponseModel")]
    public partial class AlipayTradeFastpayRefundQueryResponseModel : IEquatable<AlipayTradeFastpayRefundQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeFastpayRefundQueryResponseModel" /> class.
        /// </summary>
        /// <param name="depositBackInfo">depositBackInfo.</param>
        /// <param name="enterprisePayInfo">enterprisePayInfo.</param>
        /// <param name="errorCode">退款失败错误码。只在使用异步退款接口情况下才会返回该字段.</param>
        /// <param name="gmtRefundPay">退款时间。默认不返回该信息，需要在入参的query_options中指定\&quot;gmt_refund_pay\&quot;值时才返回该字段信息。.</param>
        /// <param name="industrySepcDetail">行业特殊信息（例如在医保卡支付退款中，医保局向商户返回医疗信息）。.</param>
        /// <param name="outRequestNo">本笔退款对应的退款请求号.</param>
        /// <param name="outTradeNo">创建交易传入的商户订单号.</param>
        /// <param name="presentRefundBuyerAmount">本次退款金额中买家退款金额。单位：元。 该字段默认不返回；.</param>
        /// <param name="presentRefundDiscountAmount">本次退款金额中平台优惠退款金额。单位：元。 该字段默认不返回；.</param>
        /// <param name="presentRefundMdiscountAmount">本次退款金额中商家优惠退款金额。单位：元。 该字段默认不返回；.</param>
        /// <param name="refundAmount">本次退款请求，对应的退款金额。单位：元。.</param>
        /// <param name="refundChannelList">若支付渠道包含医保统筹、个账，则显示退款的渠道信息。如统筹OUTSIDEGOVCARD，个账OUTSIDEACCCARD.</param>
        /// <param name="refundChannelStatus">若支付渠道包含医保统筹、个账，全渠道退款成功时返回SUCCESS，全失败时返回FAIL，部分成功时返回PART_SUCCESS.</param>
        /// <param name="refundChargeAmount">本次退款针对收款方的退收费金额；单位：元。 只在机构间联模式下返回，其它场景下不返回该字段；.</param>
        /// <param name="refundChargeInfoList">退费信息.</param>
        /// <param name="refundDetailItemList">本次退款使用的资金渠道； 默认不返回该信息，需要在入参的query_options中指定\&quot;refund_detail_item_list\&quot;值时才返回该字段信息。.</param>
        /// <param name="refundHybAmount">本次退款金额中退惠营宝的金额。单位：元。.</param>
        /// <param name="refundReason">发起退款时，传入的退款原因.</param>
        /// <param name="refundRoyaltys">退分账明细信息，当前仅在直付通产品中返回。.</param>
        /// <param name="refundSettlementId">退款清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；.</param>
        /// <param name="refundStatus">退款状态。枚举值： REFUND_SUCCESS 退款处理成功； 未返回该字段表示退款请求未收到或者退款失败； 注：如果退款查询发起时间早于退款时间，或者间隔退款发起时间太短，可能出现退款查询时还没处理成功，后面又处理成功的情况，建议商户在退款发起后间隔10秒以上再发起退款查询请求。.</param>
        /// <param name="sendBackFee">本次商户实际退回金额；单位：元。 默认不返回该信息，需要在入参的query_options中指定\&quot;refund_detail_item_list\&quot;值时才返回该字段信息。.</param>
        /// <param name="totalAmount">该笔退款所对应的交易的订单金额。单位：元。.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeFastpayRefundQueryResponseModel(DepositBackInfo depositBackInfo = default(DepositBackInfo), EnterprisePayInfo enterprisePayInfo = default(EnterprisePayInfo), string errorCode = default(string), string gmtRefundPay = default(string), string industrySepcDetail = default(string), string outRequestNo = default(string), string outTradeNo = default(string), string presentRefundBuyerAmount = default(string), string presentRefundDiscountAmount = default(string), string presentRefundMdiscountAmount = default(string), string refundAmount = default(string), string refundChannelList = default(string), string refundChannelStatus = default(string), string refundChargeAmount = default(string), List<RefundChargeInfo> refundChargeInfoList = default(List<RefundChargeInfo>), List<TradeFundBill> refundDetailItemList = default(List<TradeFundBill>), string refundHybAmount = default(string), string refundReason = default(string), List<RefundRoyaltyResult> refundRoyaltys = default(List<RefundRoyaltyResult>), string refundSettlementId = default(string), string refundStatus = default(string), string sendBackFee = default(string), string totalAmount = default(string), string tradeNo = default(string))
        {
            this.DepositBackInfo = depositBackInfo;
            this.EnterprisePayInfo = enterprisePayInfo;
            this.ErrorCode = errorCode;
            this.GmtRefundPay = gmtRefundPay;
            this.IndustrySepcDetail = industrySepcDetail;
            this.OutRequestNo = outRequestNo;
            this.OutTradeNo = outTradeNo;
            this.PresentRefundBuyerAmount = presentRefundBuyerAmount;
            this.PresentRefundDiscountAmount = presentRefundDiscountAmount;
            this.PresentRefundMdiscountAmount = presentRefundMdiscountAmount;
            this.RefundAmount = refundAmount;
            this.RefundChannelList = refundChannelList;
            this.RefundChannelStatus = refundChannelStatus;
            this.RefundChargeAmount = refundChargeAmount;
            this.RefundChargeInfoList = refundChargeInfoList;
            this.RefundDetailItemList = refundDetailItemList;
            this.RefundHybAmount = refundHybAmount;
            this.RefundReason = refundReason;
            this.RefundRoyaltys = refundRoyaltys;
            this.RefundSettlementId = refundSettlementId;
            this.RefundStatus = refundStatus;
            this.SendBackFee = sendBackFee;
            this.TotalAmount = totalAmount;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// Gets or Sets DepositBackInfo
        /// </summary>
        [DataMember(Name = "deposit_back_info", EmitDefaultValue = false)]
        public DepositBackInfo DepositBackInfo { get; set; }

        /// <summary>
        /// Gets or Sets EnterprisePayInfo
        /// </summary>
        [DataMember(Name = "enterprise_pay_info", EmitDefaultValue = false)]
        public EnterprisePayInfo EnterprisePayInfo { get; set; }

        /// <summary>
        /// 退款失败错误码。只在使用异步退款接口情况下才会返回该字段
        /// </summary>
        /// <value>退款失败错误码。只在使用异步退款接口情况下才会返回该字段</value>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 退款时间。默认不返回该信息，需要在入参的query_options中指定\&quot;gmt_refund_pay\&quot;值时才返回该字段信息。
        /// </summary>
        /// <value>退款时间。默认不返回该信息，需要在入参的query_options中指定\&quot;gmt_refund_pay\&quot;值时才返回该字段信息。</value>
        [DataMember(Name = "gmt_refund_pay", EmitDefaultValue = false)]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 行业特殊信息（例如在医保卡支付退款中，医保局向商户返回医疗信息）。
        /// </summary>
        /// <value>行业特殊信息（例如在医保卡支付退款中，医保局向商户返回医疗信息）。</value>
        [DataMember(Name = "industry_sepc_detail", EmitDefaultValue = false)]
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 本笔退款对应的退款请求号
        /// </summary>
        /// <value>本笔退款对应的退款请求号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 创建交易传入的商户订单号
        /// </summary>
        /// <value>创建交易传入的商户订单号</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次退款金额中买家退款金额。单位：元。 该字段默认不返回；
        /// </summary>
        /// <value>本次退款金额中买家退款金额。单位：元。 该字段默认不返回；</value>
        [DataMember(Name = "present_refund_buyer_amount", EmitDefaultValue = false)]
        public string PresentRefundBuyerAmount { get; set; }

        /// <summary>
        /// 本次退款金额中平台优惠退款金额。单位：元。 该字段默认不返回；
        /// </summary>
        /// <value>本次退款金额中平台优惠退款金额。单位：元。 该字段默认不返回；</value>
        [DataMember(Name = "present_refund_discount_amount", EmitDefaultValue = false)]
        public string PresentRefundDiscountAmount { get; set; }

        /// <summary>
        /// 本次退款金额中商家优惠退款金额。单位：元。 该字段默认不返回；
        /// </summary>
        /// <value>本次退款金额中商家优惠退款金额。单位：元。 该字段默认不返回；</value>
        [DataMember(Name = "present_refund_mdiscount_amount", EmitDefaultValue = false)]
        public string PresentRefundMdiscountAmount { get; set; }

        /// <summary>
        /// 本次退款请求，对应的退款金额。单位：元。
        /// </summary>
        /// <value>本次退款请求，对应的退款金额。单位：元。</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 若支付渠道包含医保统筹、个账，则显示退款的渠道信息。如统筹OUTSIDEGOVCARD，个账OUTSIDEACCCARD
        /// </summary>
        /// <value>若支付渠道包含医保统筹、个账，则显示退款的渠道信息。如统筹OUTSIDEGOVCARD，个账OUTSIDEACCCARD</value>
        [DataMember(Name = "refund_channel_list", EmitDefaultValue = false)]
        public string RefundChannelList { get; set; }

        /// <summary>
        /// 若支付渠道包含医保统筹、个账，全渠道退款成功时返回SUCCESS，全失败时返回FAIL，部分成功时返回PART_SUCCESS
        /// </summary>
        /// <value>若支付渠道包含医保统筹、个账，全渠道退款成功时返回SUCCESS，全失败时返回FAIL，部分成功时返回PART_SUCCESS</value>
        [DataMember(Name = "refund_channel_status", EmitDefaultValue = false)]
        public string RefundChannelStatus { get; set; }

        /// <summary>
        /// 本次退款针对收款方的退收费金额；单位：元。 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        /// <value>本次退款针对收款方的退收费金额；单位：元。 只在机构间联模式下返回，其它场景下不返回该字段；</value>
        [DataMember(Name = "refund_charge_amount", EmitDefaultValue = false)]
        public string RefundChargeAmount { get; set; }

        /// <summary>
        /// 退费信息
        /// </summary>
        /// <value>退费信息</value>
        [DataMember(Name = "refund_charge_info_list", EmitDefaultValue = false)]
        public List<RefundChargeInfo> RefundChargeInfoList { get; set; }

        /// <summary>
        /// 本次退款使用的资金渠道； 默认不返回该信息，需要在入参的query_options中指定\&quot;refund_detail_item_list\&quot;值时才返回该字段信息。
        /// </summary>
        /// <value>本次退款使用的资金渠道； 默认不返回该信息，需要在入参的query_options中指定\&quot;refund_detail_item_list\&quot;值时才返回该字段信息。</value>
        [DataMember(Name = "refund_detail_item_list", EmitDefaultValue = false)]
        public List<TradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 本次退款金额中退惠营宝的金额。单位：元。
        /// </summary>
        /// <value>本次退款金额中退惠营宝的金额。单位：元。</value>
        [DataMember(Name = "refund_hyb_amount", EmitDefaultValue = false)]
        public string RefundHybAmount { get; set; }

        /// <summary>
        /// 发起退款时，传入的退款原因
        /// </summary>
        /// <value>发起退款时，传入的退款原因</value>
        [DataMember(Name = "refund_reason", EmitDefaultValue = false)]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退分账明细信息，当前仅在直付通产品中返回。
        /// </summary>
        /// <value>退分账明细信息，当前仅在直付通产品中返回。</value>
        [DataMember(Name = "refund_royaltys", EmitDefaultValue = false)]
        public List<RefundRoyaltyResult> RefundRoyaltys { get; set; }

        /// <summary>
        /// 退款清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；
        /// </summary>
        /// <value>退款清算编号，用于清算对账使用； 只在机构间联模式下返回，其它场景下不返回该字段；</value>
        [DataMember(Name = "refund_settlement_id", EmitDefaultValue = false)]
        public string RefundSettlementId { get; set; }

        /// <summary>
        /// 退款状态。枚举值： REFUND_SUCCESS 退款处理成功； 未返回该字段表示退款请求未收到或者退款失败； 注：如果退款查询发起时间早于退款时间，或者间隔退款发起时间太短，可能出现退款查询时还没处理成功，后面又处理成功的情况，建议商户在退款发起后间隔10秒以上再发起退款查询请求。
        /// </summary>
        /// <value>退款状态。枚举值： REFUND_SUCCESS 退款处理成功； 未返回该字段表示退款请求未收到或者退款失败； 注：如果退款查询发起时间早于退款时间，或者间隔退款发起时间太短，可能出现退款查询时还没处理成功，后面又处理成功的情况，建议商户在退款发起后间隔10秒以上再发起退款查询请求。</value>
        [DataMember(Name = "refund_status", EmitDefaultValue = false)]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次商户实际退回金额；单位：元。 默认不返回该信息，需要在入参的query_options中指定\&quot;refund_detail_item_list\&quot;值时才返回该字段信息。
        /// </summary>
        /// <value>本次商户实际退回金额；单位：元。 默认不返回该信息，需要在入参的query_options中指定\&quot;refund_detail_item_list\&quot;值时才返回该字段信息。</value>
        [DataMember(Name = "send_back_fee", EmitDefaultValue = false)]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 该笔退款所对应的交易的订单金额。单位：元。
        /// </summary>
        /// <value>该笔退款所对应的交易的订单金额。单位：元。</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        /// <value>支付宝交易号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeFastpayRefundQueryResponseModel {\n");
            sb.Append("  DepositBackInfo: ").Append(DepositBackInfo).Append("\n");
            sb.Append("  EnterprisePayInfo: ").Append(EnterprisePayInfo).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  GmtRefundPay: ").Append(GmtRefundPay).Append("\n");
            sb.Append("  IndustrySepcDetail: ").Append(IndustrySepcDetail).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  PresentRefundBuyerAmount: ").Append(PresentRefundBuyerAmount).Append("\n");
            sb.Append("  PresentRefundDiscountAmount: ").Append(PresentRefundDiscountAmount).Append("\n");
            sb.Append("  PresentRefundMdiscountAmount: ").Append(PresentRefundMdiscountAmount).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundChannelList: ").Append(RefundChannelList).Append("\n");
            sb.Append("  RefundChannelStatus: ").Append(RefundChannelStatus).Append("\n");
            sb.Append("  RefundChargeAmount: ").Append(RefundChargeAmount).Append("\n");
            sb.Append("  RefundChargeInfoList: ").Append(RefundChargeInfoList).Append("\n");
            sb.Append("  RefundDetailItemList: ").Append(RefundDetailItemList).Append("\n");
            sb.Append("  RefundHybAmount: ").Append(RefundHybAmount).Append("\n");
            sb.Append("  RefundReason: ").Append(RefundReason).Append("\n");
            sb.Append("  RefundRoyaltys: ").Append(RefundRoyaltys).Append("\n");
            sb.Append("  RefundSettlementId: ").Append(RefundSettlementId).Append("\n");
            sb.Append("  RefundStatus: ").Append(RefundStatus).Append("\n");
            sb.Append("  SendBackFee: ").Append(SendBackFee).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as AlipayTradeFastpayRefundQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeFastpayRefundQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeFastpayRefundQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeFastpayRefundQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepositBackInfo == input.DepositBackInfo ||
                    (this.DepositBackInfo != null &&
                    this.DepositBackInfo.Equals(input.DepositBackInfo))
                ) && 
                (
                    this.EnterprisePayInfo == input.EnterprisePayInfo ||
                    (this.EnterprisePayInfo != null &&
                    this.EnterprisePayInfo.Equals(input.EnterprisePayInfo))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.GmtRefundPay == input.GmtRefundPay ||
                    (this.GmtRefundPay != null &&
                    this.GmtRefundPay.Equals(input.GmtRefundPay))
                ) && 
                (
                    this.IndustrySepcDetail == input.IndustrySepcDetail ||
                    (this.IndustrySepcDetail != null &&
                    this.IndustrySepcDetail.Equals(input.IndustrySepcDetail))
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
                    this.PresentRefundBuyerAmount == input.PresentRefundBuyerAmount ||
                    (this.PresentRefundBuyerAmount != null &&
                    this.PresentRefundBuyerAmount.Equals(input.PresentRefundBuyerAmount))
                ) && 
                (
                    this.PresentRefundDiscountAmount == input.PresentRefundDiscountAmount ||
                    (this.PresentRefundDiscountAmount != null &&
                    this.PresentRefundDiscountAmount.Equals(input.PresentRefundDiscountAmount))
                ) && 
                (
                    this.PresentRefundMdiscountAmount == input.PresentRefundMdiscountAmount ||
                    (this.PresentRefundMdiscountAmount != null &&
                    this.PresentRefundMdiscountAmount.Equals(input.PresentRefundMdiscountAmount))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.RefundChannelList == input.RefundChannelList ||
                    (this.RefundChannelList != null &&
                    this.RefundChannelList.Equals(input.RefundChannelList))
                ) && 
                (
                    this.RefundChannelStatus == input.RefundChannelStatus ||
                    (this.RefundChannelStatus != null &&
                    this.RefundChannelStatus.Equals(input.RefundChannelStatus))
                ) && 
                (
                    this.RefundChargeAmount == input.RefundChargeAmount ||
                    (this.RefundChargeAmount != null &&
                    this.RefundChargeAmount.Equals(input.RefundChargeAmount))
                ) && 
                (
                    this.RefundChargeInfoList == input.RefundChargeInfoList ||
                    this.RefundChargeInfoList != null &&
                    input.RefundChargeInfoList != null &&
                    this.RefundChargeInfoList.SequenceEqual(input.RefundChargeInfoList)
                ) && 
                (
                    this.RefundDetailItemList == input.RefundDetailItemList ||
                    this.RefundDetailItemList != null &&
                    input.RefundDetailItemList != null &&
                    this.RefundDetailItemList.SequenceEqual(input.RefundDetailItemList)
                ) && 
                (
                    this.RefundHybAmount == input.RefundHybAmount ||
                    (this.RefundHybAmount != null &&
                    this.RefundHybAmount.Equals(input.RefundHybAmount))
                ) && 
                (
                    this.RefundReason == input.RefundReason ||
                    (this.RefundReason != null &&
                    this.RefundReason.Equals(input.RefundReason))
                ) && 
                (
                    this.RefundRoyaltys == input.RefundRoyaltys ||
                    this.RefundRoyaltys != null &&
                    input.RefundRoyaltys != null &&
                    this.RefundRoyaltys.SequenceEqual(input.RefundRoyaltys)
                ) && 
                (
                    this.RefundSettlementId == input.RefundSettlementId ||
                    (this.RefundSettlementId != null &&
                    this.RefundSettlementId.Equals(input.RefundSettlementId))
                ) && 
                (
                    this.RefundStatus == input.RefundStatus ||
                    (this.RefundStatus != null &&
                    this.RefundStatus.Equals(input.RefundStatus))
                ) && 
                (
                    this.SendBackFee == input.SendBackFee ||
                    (this.SendBackFee != null &&
                    this.SendBackFee.Equals(input.SendBackFee))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.DepositBackInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DepositBackInfo.GetHashCode();
                }
                if (this.EnterprisePayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnterprisePayInfo.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.GmtRefundPay != null)
                {
                    hashCode = (hashCode * 59) + this.GmtRefundPay.GetHashCode();
                }
                if (this.IndustrySepcDetail != null)
                {
                    hashCode = (hashCode * 59) + this.IndustrySepcDetail.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.PresentRefundBuyerAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PresentRefundBuyerAmount.GetHashCode();
                }
                if (this.PresentRefundDiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PresentRefundDiscountAmount.GetHashCode();
                }
                if (this.PresentRefundMdiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PresentRefundMdiscountAmount.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundChannelList != null)
                {
                    hashCode = (hashCode * 59) + this.RefundChannelList.GetHashCode();
                }
                if (this.RefundChannelStatus != null)
                {
                    hashCode = (hashCode * 59) + this.RefundChannelStatus.GetHashCode();
                }
                if (this.RefundChargeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundChargeAmount.GetHashCode();
                }
                if (this.RefundChargeInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.RefundChargeInfoList.GetHashCode();
                }
                if (this.RefundDetailItemList != null)
                {
                    hashCode = (hashCode * 59) + this.RefundDetailItemList.GetHashCode();
                }
                if (this.RefundHybAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundHybAmount.GetHashCode();
                }
                if (this.RefundReason != null)
                {
                    hashCode = (hashCode * 59) + this.RefundReason.GetHashCode();
                }
                if (this.RefundRoyaltys != null)
                {
                    hashCode = (hashCode * 59) + this.RefundRoyaltys.GetHashCode();
                }
                if (this.RefundSettlementId != null)
                {
                    hashCode = (hashCode * 59) + this.RefundSettlementId.GetHashCode();
                }
                if (this.RefundStatus != null)
                {
                    hashCode = (hashCode * 59) + this.RefundStatus.GetHashCode();
                }
                if (this.SendBackFee != null)
                {
                    hashCode = (hashCode * 59) + this.SendBackFee.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
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
