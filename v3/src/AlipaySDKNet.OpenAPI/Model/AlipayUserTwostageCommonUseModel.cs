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
    /// AlipayUserTwostageCommonUseModel
    /// </summary>
    [DataContract(Name = "AlipayUserTwostageCommonUseModel")]
    public partial class AlipayUserTwostageCommonUseModel : IEquatable<AlipayUserTwostageCommonUseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserTwostageCommonUseModel" /> class.
        /// </summary>
        /// <param name="dynamicId">商户扫描用户的付款码值。.</param>
        /// <param name="payCheckStrategy">传1表示 校验pid(pay_pid)和来支付的时候的pid一致性； 传2表示校验pid(pay_pid)和来支付的时候的pid一致性、校验scene_no和来支付时DYNAMIC_TOKEN_OUT_BIZ_NO属性一致；                        不传值和value&#x3D;2的表现一致.</param>
        /// <param name="payPid">商家进行二阶段支付的PID信息。.</param>
        /// <param name="senceNo">外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，sence_no必须与上一次保持一致，每次请求的sence_no必须不一样，如alipay.user.twostage.common.use接口配合alipay.trade.pay（统一收单交易支付接口）一并使用时，alipay.trade.pay接口的extend_params属性中必须设置DYNAMIC_TOKEN_OUT_BIZ_NO，且值必须与sence_no保持一致。.</param>
        public AlipayUserTwostageCommonUseModel(string dynamicId = default(string), string payCheckStrategy = default(string), string payPid = default(string), string senceNo = default(string))
        {
            this.DynamicId = dynamicId;
            this.PayCheckStrategy = payCheckStrategy;
            this.PayPid = payPid;
            this.SenceNo = senceNo;
        }

        /// <summary>
        /// 商户扫描用户的付款码值。
        /// </summary>
        /// <value>商户扫描用户的付款码值。</value>
        [DataMember(Name = "dynamic_id", EmitDefaultValue = false)]
        public string DynamicId { get; set; }

        /// <summary>
        /// 传1表示 校验pid(pay_pid)和来支付的时候的pid一致性； 传2表示校验pid(pay_pid)和来支付的时候的pid一致性、校验scene_no和来支付时DYNAMIC_TOKEN_OUT_BIZ_NO属性一致；                        不传值和value&#x3D;2的表现一致
        /// </summary>
        /// <value>传1表示 校验pid(pay_pid)和来支付的时候的pid一致性； 传2表示校验pid(pay_pid)和来支付的时候的pid一致性、校验scene_no和来支付时DYNAMIC_TOKEN_OUT_BIZ_NO属性一致；                        不传值和value&#x3D;2的表现一致</value>
        [DataMember(Name = "pay_check_strategy", EmitDefaultValue = false)]
        public string PayCheckStrategy { get; set; }

        /// <summary>
        /// 商家进行二阶段支付的PID信息。
        /// </summary>
        /// <value>商家进行二阶段支付的PID信息。</value>
        [DataMember(Name = "pay_pid", EmitDefaultValue = false)]
        public string PayPid { get; set; }

        /// <summary>
        /// 外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，sence_no必须与上一次保持一致，每次请求的sence_no必须不一样，如alipay.user.twostage.common.use接口配合alipay.trade.pay（统一收单交易支付接口）一并使用时，alipay.trade.pay接口的extend_params属性中必须设置DYNAMIC_TOKEN_OUT_BIZ_NO，且值必须与sence_no保持一致。
        /// </summary>
        /// <value>外部业务号，用于标识这笔解码请求，对同一个码的重复解码请求，sence_no必须与上一次保持一致，每次请求的sence_no必须不一样，如alipay.user.twostage.common.use接口配合alipay.trade.pay（统一收单交易支付接口）一并使用时，alipay.trade.pay接口的extend_params属性中必须设置DYNAMIC_TOKEN_OUT_BIZ_NO，且值必须与sence_no保持一致。</value>
        [DataMember(Name = "sence_no", EmitDefaultValue = false)]
        public string SenceNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserTwostageCommonUseModel {\n");
            sb.Append("  DynamicId: ").Append(DynamicId).Append("\n");
            sb.Append("  PayCheckStrategy: ").Append(PayCheckStrategy).Append("\n");
            sb.Append("  PayPid: ").Append(PayPid).Append("\n");
            sb.Append("  SenceNo: ").Append(SenceNo).Append("\n");
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
            return this.Equals(input as AlipayUserTwostageCommonUseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserTwostageCommonUseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserTwostageCommonUseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserTwostageCommonUseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DynamicId == input.DynamicId ||
                    (this.DynamicId != null &&
                    this.DynamicId.Equals(input.DynamicId))
                ) && 
                (
                    this.PayCheckStrategy == input.PayCheckStrategy ||
                    (this.PayCheckStrategy != null &&
                    this.PayCheckStrategy.Equals(input.PayCheckStrategy))
                ) && 
                (
                    this.PayPid == input.PayPid ||
                    (this.PayPid != null &&
                    this.PayPid.Equals(input.PayPid))
                ) && 
                (
                    this.SenceNo == input.SenceNo ||
                    (this.SenceNo != null &&
                    this.SenceNo.Equals(input.SenceNo))
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
                if (this.DynamicId != null)
                {
                    hashCode = (hashCode * 59) + this.DynamicId.GetHashCode();
                }
                if (this.PayCheckStrategy != null)
                {
                    hashCode = (hashCode * 59) + this.PayCheckStrategy.GetHashCode();
                }
                if (this.PayPid != null)
                {
                    hashCode = (hashCode * 59) + this.PayPid.GetHashCode();
                }
                if (this.SenceNo != null)
                {
                    hashCode = (hashCode * 59) + this.SenceNo.GetHashCode();
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
