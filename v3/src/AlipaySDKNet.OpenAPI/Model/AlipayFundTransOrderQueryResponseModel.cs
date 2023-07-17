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
    /// AlipayFundTransOrderQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransOrderQueryResponseModel")]
    public partial class AlipayFundTransOrderQueryResponseModel : IEquatable<AlipayFundTransOrderQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransOrderQueryResponseModel" /> class.
        /// </summary>
        /// <param name="arrivalTimeEnd">预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。     注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。.</param>
        /// <param name="errorCode">查询失败时，本参数为错误代 码。   查询成功不返回。 对于退票订单，不返回该参数。.</param>
        /// <param name="failReason">查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。.</param>
        /// <param name="orderFee">预计收费金额（元），转账到银行卡专用，数字格式，精确到小数点后2位，转账失败或转账受理失败不返回。.</param>
        /// <param name="orderId">支付宝转账单据号，查询失败不返回。.</param>
        /// <param name="outBizNo">发起转账来源方定义的转账单据号。   该参数的赋值均以查询结果中 的 out_biz_no 为准。   如果查询失败，不返回该参数。.</param>
        /// <param name="payDate">支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。.</param>
        /// <param name="status">转账单据状态。   SUCCESS：成功（配合\&quot;单笔转账到银行账户接口\&quot;产品使用时, 同一笔单据多次查询有可能从成功变成退票状态）；   FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）；   INIT：等待处理；   DEALING：处理中；   REFUND：退票（仅配合\&quot;单笔转账到银行账户接口\&quot;产品使用时会涉及, 具体退票原因请参见fail_reason返回值）；   UNKNOWN：状态未知。.</param>
        public AlipayFundTransOrderQueryResponseModel(string arrivalTimeEnd = default(string), string errorCode = default(string), string failReason = default(string), string orderFee = default(string), string orderId = default(string), string outBizNo = default(string), string payDate = default(string), string status = default(string))
        {
            this.ArrivalTimeEnd = arrivalTimeEnd;
            this.ErrorCode = errorCode;
            this.FailReason = failReason;
            this.OrderFee = orderFee;
            this.OrderId = orderId;
            this.OutBizNo = outBizNo;
            this.PayDate = payDate;
            this.Status = status;
        }

        /// <summary>
        /// 预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。     注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。
        /// </summary>
        /// <value>预计到账时间，转账到银行卡专用，格式为yyyy-MM-dd HH:mm:ss，转账受理失败不返回。     注意：  此参数为预计时间，可能与实际到账时间有较大误差，不能作为实际到账时间使用，仅供参考用途。</value>
        [DataMember(Name = "arrival_time_end", EmitDefaultValue = false)]
        public string ArrivalTimeEnd { get; set; }

        /// <summary>
        /// 查询失败时，本参数为错误代 码。   查询成功不返回。 对于退票订单，不返回该参数。
        /// </summary>
        /// <value>查询失败时，本参数为错误代 码。   查询成功不返回。 对于退票订单，不返回该参数。</value>
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
        /// 发起转账来源方定义的转账单据号。   该参数的赋值均以查询结果中 的 out_biz_no 为准。   如果查询失败，不返回该参数。
        /// </summary>
        /// <value>发起转账来源方定义的转账单据号。   该参数的赋值均以查询结果中 的 out_biz_no 为准。   如果查询失败，不返回该参数。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。
        /// </summary>
        /// <value>支付时间，格式为yyyy-MM-dd HH:mm:ss，转账失败不返回。</value>
        [DataMember(Name = "pay_date", EmitDefaultValue = false)]
        public string PayDate { get; set; }

        /// <summary>
        /// 转账单据状态。   SUCCESS：成功（配合\&quot;单笔转账到银行账户接口\&quot;产品使用时, 同一笔单据多次查询有可能从成功变成退票状态）；   FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）；   INIT：等待处理；   DEALING：处理中；   REFUND：退票（仅配合\&quot;单笔转账到银行账户接口\&quot;产品使用时会涉及, 具体退票原因请参见fail_reason返回值）；   UNKNOWN：状态未知。
        /// </summary>
        /// <value>转账单据状态。   SUCCESS：成功（配合\&quot;单笔转账到银行账户接口\&quot;产品使用时, 同一笔单据多次查询有可能从成功变成退票状态）；   FAIL：失败（具体失败原因请参见error_code以及fail_reason返回值）；   INIT：等待处理；   DEALING：处理中；   REFUND：退票（仅配合\&quot;单笔转账到银行账户接口\&quot;产品使用时会涉及, 具体退票原因请参见fail_reason返回值）；   UNKNOWN：状态未知。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransOrderQueryResponseModel {\n");
            sb.Append("  ArrivalTimeEnd: ").Append(ArrivalTimeEnd).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  OrderFee: ").Append(OrderFee).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PayDate: ").Append(PayDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayFundTransOrderQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransOrderQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransOrderQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransOrderQueryResponseModel input)
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
                    this.PayDate == input.PayDate ||
                    (this.PayDate != null &&
                    this.PayDate.Equals(input.PayDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.PayDate != null)
                {
                    hashCode = (hashCode * 59) + this.PayDate.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
