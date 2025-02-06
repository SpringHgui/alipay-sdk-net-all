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
    /// AlipayMerchantIndirectAuthorderQuerystatusResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIndirectAuthorderQuerystatusResponseModel")]
    public partial class AlipayMerchantIndirectAuthorderQuerystatusResponseModel : IEquatable<AlipayMerchantIndirectAuthorderQuerystatusResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectAuthorderQuerystatusResponseModel" /> class.
        /// </summary>
        /// <param name="orderNo">商家认证申请单号.</param>
        /// <param name="orderStatus">商家认证申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核驳回(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中（CONTACT_PROCESSING）.</param>
        /// <param name="qrCode">商家认证小程序二维码图片链接，申请单状态处于审核通过、待联系人确认、待法人确认、已冻结、审核失败时返回，商户使用支付宝APP扫码后完成后续确认、修改信息等动作。 此字段是平台生成并返回的二维码码值，通过浏览器访问即可获得一个二维码的图片。服务商在推广过程中，可引导商家使用支付宝APP扫描此二维码，进入认证申请单页面，完成认证申请的后续确认操作。.</param>
        /// <param name="verifyList">申请单审核失败时的原因描述列表.</param>
        public AlipayMerchantIndirectAuthorderQuerystatusResponseModel(string orderNo = default(string), string orderStatus = default(string), string qrCode = default(string), List<IndirectAuthOrderFailedReason> verifyList = default(List<IndirectAuthOrderFailedReason>))
        {
            this.OrderNo = orderNo;
            this.OrderStatus = orderStatus;
            this.QrCode = qrCode;
            this.VerifyList = verifyList;
        }

        /// <summary>
        /// 商家认证申请单号
        /// </summary>
        /// <value>商家认证申请单号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家认证申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核驳回(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中（CONTACT_PROCESSING）
        /// </summary>
        /// <value>商家认证申请单状态，枚举值：审核中(AUDITING)、待联系人确认（CONTACT_CONFIRM），待法人确认（LEGAL_CONFIRM）、审核通过(AUDIT_PASS)、审核驳回(AUDIT_REJECT)、已冻结(AUDIT_FREEZE)、已撤回(CANCELED)、联系人处理中（CONTACT_PROCESSING）</value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商家认证小程序二维码图片链接，申请单状态处于审核通过、待联系人确认、待法人确认、已冻结、审核失败时返回，商户使用支付宝APP扫码后完成后续确认、修改信息等动作。 此字段是平台生成并返回的二维码码值，通过浏览器访问即可获得一个二维码的图片。服务商在推广过程中，可引导商家使用支付宝APP扫描此二维码，进入认证申请单页面，完成认证申请的后续确认操作。
        /// </summary>
        /// <value>商家认证小程序二维码图片链接，申请单状态处于审核通过、待联系人确认、待法人确认、已冻结、审核失败时返回，商户使用支付宝APP扫码后完成后续确认、修改信息等动作。 此字段是平台生成并返回的二维码码值，通过浏览器访问即可获得一个二维码的图片。服务商在推广过程中，可引导商家使用支付宝APP扫描此二维码，进入认证申请单页面，完成认证申请的后续确认操作。</value>
        [DataMember(Name = "qr_code", EmitDefaultValue = false)]
        public string QrCode { get; set; }

        /// <summary>
        /// 申请单审核失败时的原因描述列表
        /// </summary>
        /// <value>申请单审核失败时的原因描述列表</value>
        [DataMember(Name = "verify_list", EmitDefaultValue = false)]
        public List<IndirectAuthOrderFailedReason> VerifyList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIndirectAuthorderQuerystatusResponseModel {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  QrCode: ").Append(QrCode).Append("\n");
            sb.Append("  VerifyList: ").Append(VerifyList).Append("\n");
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
            return this.Equals(input as AlipayMerchantIndirectAuthorderQuerystatusResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIndirectAuthorderQuerystatusResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIndirectAuthorderQuerystatusResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIndirectAuthorderQuerystatusResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.QrCode == input.QrCode ||
                    (this.QrCode != null &&
                    this.QrCode.Equals(input.QrCode))
                ) && 
                (
                    this.VerifyList == input.VerifyList ||
                    this.VerifyList != null &&
                    input.VerifyList != null &&
                    this.VerifyList.SequenceEqual(input.VerifyList)
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
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                }
                if (this.QrCode != null)
                {
                    hashCode = (hashCode * 59) + this.QrCode.GetHashCode();
                }
                if (this.VerifyList != null)
                {
                    hashCode = (hashCode * 59) + this.VerifyList.GetHashCode();
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
