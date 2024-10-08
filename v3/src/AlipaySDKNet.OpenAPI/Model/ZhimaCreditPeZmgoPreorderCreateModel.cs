/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// ZhimaCreditPeZmgoPreorderCreateModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoPreorderCreateModel")]
    public partial class ZhimaCreditPeZmgoPreorderCreateModel : IEquatable<ZhimaCreditPeZmgoPreorderCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoPreorderCreateModel" /> class.
        /// </summary>
        /// <param name="alipayOpenId">支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变.</param>
        /// <param name="alipayUserId">支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变.</param>
        /// <param name="bizTime">业务发生时间，如2016-07-06 00:00:02 签约超时关单时间依赖这个时间 这个时间会做幂等校验，如果创单幂等，但时间不同会失败.</param>
        /// <param name="customTempConf">废弃字段，勿用.</param>
        /// <param name="expireAisleData">协议到期后通知.</param>
        /// <param name="extTemplateConf">extTemplateConf.</param>
        /// <param name="extendParams">extendParams.</param>
        /// <param name="freezeAmount">冻结金额，单位：元.</param>
        /// <param name="isvPid">ISV商户ID.</param>
        /// <param name="outRequestNo">外部请求号，唯一.</param>
        /// <param name="partnerId">商户ID.</param>
        /// <param name="partnerUserIdentifier">商户侧用户唯一标识。ex.商户侧uid.</param>
        /// <param name="payAisleData">结算成功后通知.</param>
        /// <param name="signAisleData">签约成功后通知.</param>
        /// <param name="templateId">签约芝麻GO的模板ID.</param>
        /// <param name="timeoutExpress">超时关单时间 默认1H。1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m 签约超时关单时间依赖这个时间.</param>
        public ZhimaCreditPeZmgoPreorderCreateModel(string alipayOpenId = default(string), string alipayUserId = default(string), string bizTime = default(string), string customTempConf = default(string), string expireAisleData = default(string), ExtTemplateConf extTemplateConf = default(ExtTemplateConf), PreOrderExtInfo extendParams = default(PreOrderExtInfo), string freezeAmount = default(string), string isvPid = default(string), string outRequestNo = default(string), string partnerId = default(string), string partnerUserIdentifier = default(string), string payAisleData = default(string), string signAisleData = default(string), string templateId = default(string), string timeoutExpress = default(string))
        {
            this.AlipayOpenId = alipayOpenId;
            this.AlipayUserId = alipayUserId;
            this.BizTime = bizTime;
            this.CustomTempConf = customTempConf;
            this.ExpireAisleData = expireAisleData;
            this.ExtTemplateConf = extTemplateConf;
            this.ExtendParams = extendParams;
            this.FreezeAmount = freezeAmount;
            this.IsvPid = isvPid;
            this.OutRequestNo = outRequestNo;
            this.PartnerId = partnerId;
            this.PartnerUserIdentifier = partnerUserIdentifier;
            this.PayAisleData = payAisleData;
            this.SignAisleData = signAisleData;
            this.TemplateId = templateId;
            this.TimeoutExpress = timeoutExpress;
        }

        /// <summary>
        /// 支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变
        /// </summary>
        /// <value>支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变</value>
        [DataMember(Name = "alipay_open_id", EmitDefaultValue = false)]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变
        /// </summary>
        /// <value>支付宝用户ID。同一个外部请求号，调用方要确保支付宝userId取值不变</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 业务发生时间，如2016-07-06 00:00:02 签约超时关单时间依赖这个时间 这个时间会做幂等校验，如果创单幂等，但时间不同会失败
        /// </summary>
        /// <value>业务发生时间，如2016-07-06 00:00:02 签约超时关单时间依赖这个时间 这个时间会做幂等校验，如果创单幂等，但时间不同会失败</value>
        [DataMember(Name = "biz_time", EmitDefaultValue = false)]
        public string BizTime { get; set; }

        /// <summary>
        /// 废弃字段，勿用
        /// </summary>
        /// <value>废弃字段，勿用</value>
        [DataMember(Name = "custom_temp_conf", EmitDefaultValue = false)]
        public string CustomTempConf { get; set; }

        /// <summary>
        /// 协议到期后通知
        /// </summary>
        /// <value>协议到期后通知</value>
        [DataMember(Name = "expire_aisle_data", EmitDefaultValue = false)]
        public string ExpireAisleData { get; set; }

        /// <summary>
        /// Gets or Sets ExtTemplateConf
        /// </summary>
        [DataMember(Name = "ext_template_conf", EmitDefaultValue = false)]
        public ExtTemplateConf ExtTemplateConf { get; set; }

        /// <summary>
        /// Gets or Sets ExtendParams
        /// </summary>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public PreOrderExtInfo ExtendParams { get; set; }

        /// <summary>
        /// 冻结金额，单位：元
        /// </summary>
        /// <value>冻结金额，单位：元</value>
        [DataMember(Name = "freeze_amount", EmitDefaultValue = false)]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// ISV商户ID
        /// </summary>
        /// <value>ISV商户ID</value>
        [DataMember(Name = "isv_pid", EmitDefaultValue = false)]
        public string IsvPid { get; set; }

        /// <summary>
        /// 外部请求号，唯一
        /// </summary>
        /// <value>外部请求号，唯一</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 商户侧用户唯一标识。ex.商户侧uid
        /// </summary>
        /// <value>商户侧用户唯一标识。ex.商户侧uid</value>
        [DataMember(Name = "partner_user_identifier", EmitDefaultValue = false)]
        public string PartnerUserIdentifier { get; set; }

        /// <summary>
        /// 结算成功后通知
        /// </summary>
        /// <value>结算成功后通知</value>
        [DataMember(Name = "pay_aisle_data", EmitDefaultValue = false)]
        public string PayAisleData { get; set; }

        /// <summary>
        /// 签约成功后通知
        /// </summary>
        /// <value>签约成功后通知</value>
        [DataMember(Name = "sign_aisle_data", EmitDefaultValue = false)]
        public string SignAisleData { get; set; }

        /// <summary>
        /// 签约芝麻GO的模板ID
        /// </summary>
        /// <value>签约芝麻GO的模板ID</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 超时关单时间 默认1H。1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m 签约超时关单时间依赖这个时间
        /// </summary>
        /// <value>超时关单时间 默认1H。1m～15d。m表示分钟，h表示小时，d表示天。该参数数值不接受小数点， 如1.5h，可转换为90m 签约超时关单时间依赖这个时间</value>
        [DataMember(Name = "timeout_express", EmitDefaultValue = false)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoPreorderCreateModel {\n");
            sb.Append("  AlipayOpenId: ").Append(AlipayOpenId).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  BizTime: ").Append(BizTime).Append("\n");
            sb.Append("  CustomTempConf: ").Append(CustomTempConf).Append("\n");
            sb.Append("  ExpireAisleData: ").Append(ExpireAisleData).Append("\n");
            sb.Append("  ExtTemplateConf: ").Append(ExtTemplateConf).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  FreezeAmount: ").Append(FreezeAmount).Append("\n");
            sb.Append("  IsvPid: ").Append(IsvPid).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  PartnerUserIdentifier: ").Append(PartnerUserIdentifier).Append("\n");
            sb.Append("  PayAisleData: ").Append(PayAisleData).Append("\n");
            sb.Append("  SignAisleData: ").Append(SignAisleData).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TimeoutExpress: ").Append(TimeoutExpress).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoPreorderCreateModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoPreorderCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoPreorderCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoPreorderCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayOpenId == input.AlipayOpenId ||
                    (this.AlipayOpenId != null &&
                    this.AlipayOpenId.Equals(input.AlipayOpenId))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.BizTime == input.BizTime ||
                    (this.BizTime != null &&
                    this.BizTime.Equals(input.BizTime))
                ) && 
                (
                    this.CustomTempConf == input.CustomTempConf ||
                    (this.CustomTempConf != null &&
                    this.CustomTempConf.Equals(input.CustomTempConf))
                ) && 
                (
                    this.ExpireAisleData == input.ExpireAisleData ||
                    (this.ExpireAisleData != null &&
                    this.ExpireAisleData.Equals(input.ExpireAisleData))
                ) && 
                (
                    this.ExtTemplateConf == input.ExtTemplateConf ||
                    (this.ExtTemplateConf != null &&
                    this.ExtTemplateConf.Equals(input.ExtTemplateConf))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.FreezeAmount == input.FreezeAmount ||
                    (this.FreezeAmount != null &&
                    this.FreezeAmount.Equals(input.FreezeAmount))
                ) && 
                (
                    this.IsvPid == input.IsvPid ||
                    (this.IsvPid != null &&
                    this.IsvPid.Equals(input.IsvPid))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.PartnerUserIdentifier == input.PartnerUserIdentifier ||
                    (this.PartnerUserIdentifier != null &&
                    this.PartnerUserIdentifier.Equals(input.PartnerUserIdentifier))
                ) && 
                (
                    this.PayAisleData == input.PayAisleData ||
                    (this.PayAisleData != null &&
                    this.PayAisleData.Equals(input.PayAisleData))
                ) && 
                (
                    this.SignAisleData == input.SignAisleData ||
                    (this.SignAisleData != null &&
                    this.SignAisleData.Equals(input.SignAisleData))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TimeoutExpress == input.TimeoutExpress ||
                    (this.TimeoutExpress != null &&
                    this.TimeoutExpress.Equals(input.TimeoutExpress))
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
                if (this.AlipayOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOpenId.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.BizTime != null)
                {
                    hashCode = (hashCode * 59) + this.BizTime.GetHashCode();
                }
                if (this.CustomTempConf != null)
                {
                    hashCode = (hashCode * 59) + this.CustomTempConf.GetHashCode();
                }
                if (this.ExpireAisleData != null)
                {
                    hashCode = (hashCode * 59) + this.ExpireAisleData.GetHashCode();
                }
                if (this.ExtTemplateConf != null)
                {
                    hashCode = (hashCode * 59) + this.ExtTemplateConf.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.FreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FreezeAmount.GetHashCode();
                }
                if (this.IsvPid != null)
                {
                    hashCode = (hashCode * 59) + this.IsvPid.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.PartnerUserIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerUserIdentifier.GetHashCode();
                }
                if (this.PayAisleData != null)
                {
                    hashCode = (hashCode * 59) + this.PayAisleData.GetHashCode();
                }
                if (this.SignAisleData != null)
                {
                    hashCode = (hashCode * 59) + this.SignAisleData.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TimeoutExpress != null)
                {
                    hashCode = (hashCode * 59) + this.TimeoutExpress.GetHashCode();
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
