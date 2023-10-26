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
    /// BizFundReportResult
    /// </summary>
    [DataContract(Name = "BizFundReportResult")]
    public partial class BizFundReportResult : IEquatable<BizFundReportResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BizFundReportResult" /> class.
        /// </summary>
        /// <param name="alipayAmount">实付金额（元）.</param>
        /// <param name="batchType">是否批量转账.</param>
        /// <param name="bizType">业务类型.</param>
        /// <param name="bizTypeDesc">业务类型描述.</param>
        /// <param name="chargeFee">服务费（元）.</param>
        /// <param name="gmtCreate">交易时间.</param>
        /// <param name="instructionId">2020xxx.</param>
        /// <param name="memo">出借.</param>
        /// <param name="noMbillEncrypt">是否脱敏.</param>
        /// <param name="orderId">业务订单号.</param>
        /// <param name="payAmount">实付金额（元）.</param>
        /// <param name="payeeCardNo">收款方银行卡号.</param>
        /// <param name="payeeFullName">收款方全名.</param>
        /// <param name="payeeFundType">收款方资金类型.</param>
        /// <param name="payeeFundTypeDesc">支付宝余额.</param>
        /// <param name="payeeInstName">收款银行中文简称.</param>
        /// <param name="payeeLoginEmail">收款方登录Id.</param>
        /// <param name="payeeName">收款方姓名.</param>
        /// <param name="payerFundType">付款方资金类型.</param>
        /// <param name="payerFundTypeDesc">付款方资金类型描述.</param>
        /// <param name="refundAmount">退款金额.</param>
        /// <param name="showDetail">是否展示细节，默认为true.</param>
        /// <param name="showVoucher">是否出示凭证.</param>
        /// <param name="source">数据来源.</param>
        /// <param name="status">单据状态.</param>
        /// <param name="statusDesc">单据状态描述.</param>
        /// <param name="subBizType">业务子类型.</param>
        /// <param name="subBizTypeDesc">业务子类型描述.</param>
        public BizFundReportResult(string alipayAmount = default(string), string batchType = default(string), string bizType = default(string), string bizTypeDesc = default(string), string chargeFee = default(string), string gmtCreate = default(string), string instructionId = default(string), string memo = default(string), string noMbillEncrypt = default(string), string orderId = default(string), string payAmount = default(string), string payeeCardNo = default(string), string payeeFullName = default(string), string payeeFundType = default(string), string payeeFundTypeDesc = default(string), string payeeInstName = default(string), string payeeLoginEmail = default(string), string payeeName = default(string), string payerFundType = default(string), string payerFundTypeDesc = default(string), string refundAmount = default(string), string showDetail = default(string), string showVoucher = default(string), string source = default(string), string status = default(string), string statusDesc = default(string), string subBizType = default(string), string subBizTypeDesc = default(string))
        {
            this.AlipayAmount = alipayAmount;
            this.BatchType = batchType;
            this.BizType = bizType;
            this.BizTypeDesc = bizTypeDesc;
            this.ChargeFee = chargeFee;
            this.GmtCreate = gmtCreate;
            this.InstructionId = instructionId;
            this.Memo = memo;
            this.NoMbillEncrypt = noMbillEncrypt;
            this.OrderId = orderId;
            this.PayAmount = payAmount;
            this.PayeeCardNo = payeeCardNo;
            this.PayeeFullName = payeeFullName;
            this.PayeeFundType = payeeFundType;
            this.PayeeFundTypeDesc = payeeFundTypeDesc;
            this.PayeeInstName = payeeInstName;
            this.PayeeLoginEmail = payeeLoginEmail;
            this.PayeeName = payeeName;
            this.PayerFundType = payerFundType;
            this.PayerFundTypeDesc = payerFundTypeDesc;
            this.RefundAmount = refundAmount;
            this.ShowDetail = showDetail;
            this.ShowVoucher = showVoucher;
            this.Source = source;
            this.Status = status;
            this.StatusDesc = statusDesc;
            this.SubBizType = subBizType;
            this.SubBizTypeDesc = subBizTypeDesc;
        }

        /// <summary>
        /// 实付金额（元）
        /// </summary>
        /// <value>实付金额（元）</value>
        [DataMember(Name = "alipay_amount", EmitDefaultValue = false)]
        public string AlipayAmount { get; set; }

        /// <summary>
        /// 是否批量转账
        /// </summary>
        /// <value>是否批量转账</value>
        [DataMember(Name = "batch_type", EmitDefaultValue = false)]
        public string BatchType { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        /// <value>业务类型</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 业务类型描述
        /// </summary>
        /// <value>业务类型描述</value>
        [DataMember(Name = "biz_type_desc", EmitDefaultValue = false)]
        public string BizTypeDesc { get; set; }

        /// <summary>
        /// 服务费（元）
        /// </summary>
        /// <value>服务费（元）</value>
        [DataMember(Name = "charge_fee", EmitDefaultValue = false)]
        public string ChargeFee { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        /// <value>交易时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 2020xxx
        /// </summary>
        /// <value>2020xxx</value>
        [DataMember(Name = "instruction_id", EmitDefaultValue = false)]
        public string InstructionId { get; set; }

        /// <summary>
        /// 出借
        /// </summary>
        /// <value>出借</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 是否脱敏
        /// </summary>
        /// <value>是否脱敏</value>
        [DataMember(Name = "no_mbill_encrypt", EmitDefaultValue = false)]
        public string NoMbillEncrypt { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        /// <value>业务订单号</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 实付金额（元）
        /// </summary>
        /// <value>实付金额（元）</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 收款方银行卡号
        /// </summary>
        /// <value>收款方银行卡号</value>
        [DataMember(Name = "payee_card_no", EmitDefaultValue = false)]
        public string PayeeCardNo { get; set; }

        /// <summary>
        /// 收款方全名
        /// </summary>
        /// <value>收款方全名</value>
        [DataMember(Name = "payee_full_name", EmitDefaultValue = false)]
        public string PayeeFullName { get; set; }

        /// <summary>
        /// 收款方资金类型
        /// </summary>
        /// <value>收款方资金类型</value>
        [DataMember(Name = "payee_fund_type", EmitDefaultValue = false)]
        public string PayeeFundType { get; set; }

        /// <summary>
        /// 支付宝余额
        /// </summary>
        /// <value>支付宝余额</value>
        [DataMember(Name = "payee_fund_type_desc", EmitDefaultValue = false)]
        public string PayeeFundTypeDesc { get; set; }

        /// <summary>
        /// 收款银行中文简称
        /// </summary>
        /// <value>收款银行中文简称</value>
        [DataMember(Name = "payee_inst_name", EmitDefaultValue = false)]
        public string PayeeInstName { get; set; }

        /// <summary>
        /// 收款方登录Id
        /// </summary>
        /// <value>收款方登录Id</value>
        [DataMember(Name = "payee_login_email", EmitDefaultValue = false)]
        public string PayeeLoginEmail { get; set; }

        /// <summary>
        /// 收款方姓名
        /// </summary>
        /// <value>收款方姓名</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// 付款方资金类型
        /// </summary>
        /// <value>付款方资金类型</value>
        [DataMember(Name = "payer_fund_type", EmitDefaultValue = false)]
        public string PayerFundType { get; set; }

        /// <summary>
        /// 付款方资金类型描述
        /// </summary>
        /// <value>付款方资金类型描述</value>
        [DataMember(Name = "payer_fund_type_desc", EmitDefaultValue = false)]
        public string PayerFundTypeDesc { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        /// <value>退款金额</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 是否展示细节，默认为true
        /// </summary>
        /// <value>是否展示细节，默认为true</value>
        [DataMember(Name = "show_detail", EmitDefaultValue = false)]
        public string ShowDetail { get; set; }

        /// <summary>
        /// 是否出示凭证
        /// </summary>
        /// <value>是否出示凭证</value>
        [DataMember(Name = "show_voucher", EmitDefaultValue = false)]
        public string ShowVoucher { get; set; }

        /// <summary>
        /// 数据来源
        /// </summary>
        /// <value>数据来源</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// 单据状态
        /// </summary>
        /// <value>单据状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 单据状态描述
        /// </summary>
        /// <value>单据状态描述</value>
        [DataMember(Name = "status_desc", EmitDefaultValue = false)]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 业务子类型
        /// </summary>
        /// <value>业务子类型</value>
        [DataMember(Name = "sub_biz_type", EmitDefaultValue = false)]
        public string SubBizType { get; set; }

        /// <summary>
        /// 业务子类型描述
        /// </summary>
        /// <value>业务子类型描述</value>
        [DataMember(Name = "sub_biz_type_desc", EmitDefaultValue = false)]
        public string SubBizTypeDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BizFundReportResult {\n");
            sb.Append("  AlipayAmount: ").Append(AlipayAmount).Append("\n");
            sb.Append("  BatchType: ").Append(BatchType).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  BizTypeDesc: ").Append(BizTypeDesc).Append("\n");
            sb.Append("  ChargeFee: ").Append(ChargeFee).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  InstructionId: ").Append(InstructionId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  NoMbillEncrypt: ").Append(NoMbillEncrypt).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  PayeeCardNo: ").Append(PayeeCardNo).Append("\n");
            sb.Append("  PayeeFullName: ").Append(PayeeFullName).Append("\n");
            sb.Append("  PayeeFundType: ").Append(PayeeFundType).Append("\n");
            sb.Append("  PayeeFundTypeDesc: ").Append(PayeeFundTypeDesc).Append("\n");
            sb.Append("  PayeeInstName: ").Append(PayeeInstName).Append("\n");
            sb.Append("  PayeeLoginEmail: ").Append(PayeeLoginEmail).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  PayerFundType: ").Append(PayerFundType).Append("\n");
            sb.Append("  PayerFundTypeDesc: ").Append(PayerFundTypeDesc).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  ShowDetail: ").Append(ShowDetail).Append("\n");
            sb.Append("  ShowVoucher: ").Append(ShowVoucher).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDesc: ").Append(StatusDesc).Append("\n");
            sb.Append("  SubBizType: ").Append(SubBizType).Append("\n");
            sb.Append("  SubBizTypeDesc: ").Append(SubBizTypeDesc).Append("\n");
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
            return this.Equals(input as BizFundReportResult);
        }

        /// <summary>
        /// Returns true if BizFundReportResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BizFundReportResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BizFundReportResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayAmount == input.AlipayAmount ||
                    (this.AlipayAmount != null &&
                    this.AlipayAmount.Equals(input.AlipayAmount))
                ) && 
                (
                    this.BatchType == input.BatchType ||
                    (this.BatchType != null &&
                    this.BatchType.Equals(input.BatchType))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.BizTypeDesc == input.BizTypeDesc ||
                    (this.BizTypeDesc != null &&
                    this.BizTypeDesc.Equals(input.BizTypeDesc))
                ) && 
                (
                    this.ChargeFee == input.ChargeFee ||
                    (this.ChargeFee != null &&
                    this.ChargeFee.Equals(input.ChargeFee))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.InstructionId == input.InstructionId ||
                    (this.InstructionId != null &&
                    this.InstructionId.Equals(input.InstructionId))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.NoMbillEncrypt == input.NoMbillEncrypt ||
                    (this.NoMbillEncrypt != null &&
                    this.NoMbillEncrypt.Equals(input.NoMbillEncrypt))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.PayeeCardNo == input.PayeeCardNo ||
                    (this.PayeeCardNo != null &&
                    this.PayeeCardNo.Equals(input.PayeeCardNo))
                ) && 
                (
                    this.PayeeFullName == input.PayeeFullName ||
                    (this.PayeeFullName != null &&
                    this.PayeeFullName.Equals(input.PayeeFullName))
                ) && 
                (
                    this.PayeeFundType == input.PayeeFundType ||
                    (this.PayeeFundType != null &&
                    this.PayeeFundType.Equals(input.PayeeFundType))
                ) && 
                (
                    this.PayeeFundTypeDesc == input.PayeeFundTypeDesc ||
                    (this.PayeeFundTypeDesc != null &&
                    this.PayeeFundTypeDesc.Equals(input.PayeeFundTypeDesc))
                ) && 
                (
                    this.PayeeInstName == input.PayeeInstName ||
                    (this.PayeeInstName != null &&
                    this.PayeeInstName.Equals(input.PayeeInstName))
                ) && 
                (
                    this.PayeeLoginEmail == input.PayeeLoginEmail ||
                    (this.PayeeLoginEmail != null &&
                    this.PayeeLoginEmail.Equals(input.PayeeLoginEmail))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.PayerFundType == input.PayerFundType ||
                    (this.PayerFundType != null &&
                    this.PayerFundType.Equals(input.PayerFundType))
                ) && 
                (
                    this.PayerFundTypeDesc == input.PayerFundTypeDesc ||
                    (this.PayerFundTypeDesc != null &&
                    this.PayerFundTypeDesc.Equals(input.PayerFundTypeDesc))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.ShowDetail == input.ShowDetail ||
                    (this.ShowDetail != null &&
                    this.ShowDetail.Equals(input.ShowDetail))
                ) && 
                (
                    this.ShowVoucher == input.ShowVoucher ||
                    (this.ShowVoucher != null &&
                    this.ShowVoucher.Equals(input.ShowVoucher))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusDesc == input.StatusDesc ||
                    (this.StatusDesc != null &&
                    this.StatusDesc.Equals(input.StatusDesc))
                ) && 
                (
                    this.SubBizType == input.SubBizType ||
                    (this.SubBizType != null &&
                    this.SubBizType.Equals(input.SubBizType))
                ) && 
                (
                    this.SubBizTypeDesc == input.SubBizTypeDesc ||
                    (this.SubBizTypeDesc != null &&
                    this.SubBizTypeDesc.Equals(input.SubBizTypeDesc))
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
                if (this.AlipayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayAmount.GetHashCode();
                }
                if (this.BatchType != null)
                {
                    hashCode = (hashCode * 59) + this.BatchType.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.BizTypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BizTypeDesc.GetHashCode();
                }
                if (this.ChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeFee.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.InstructionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstructionId.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.NoMbillEncrypt != null)
                {
                    hashCode = (hashCode * 59) + this.NoMbillEncrypt.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.PayeeCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeCardNo.GetHashCode();
                }
                if (this.PayeeFullName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeFullName.GetHashCode();
                }
                if (this.PayeeFundType != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeFundType.GetHashCode();
                }
                if (this.PayeeFundTypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeFundTypeDesc.GetHashCode();
                }
                if (this.PayeeInstName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeInstName.GetHashCode();
                }
                if (this.PayeeLoginEmail != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeLoginEmail.GetHashCode();
                }
                if (this.PayeeName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeName.GetHashCode();
                }
                if (this.PayerFundType != null)
                {
                    hashCode = (hashCode * 59) + this.PayerFundType.GetHashCode();
                }
                if (this.PayerFundTypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.PayerFundTypeDesc.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.ShowDetail != null)
                {
                    hashCode = (hashCode * 59) + this.ShowDetail.GetHashCode();
                }
                if (this.ShowVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.ShowVoucher.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StatusDesc.GetHashCode();
                }
                if (this.SubBizType != null)
                {
                    hashCode = (hashCode * 59) + this.SubBizType.GetHashCode();
                }
                if (this.SubBizTypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.SubBizTypeDesc.GetHashCode();
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
