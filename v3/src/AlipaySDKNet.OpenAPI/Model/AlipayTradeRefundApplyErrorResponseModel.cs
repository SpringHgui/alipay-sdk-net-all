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
    /// AlipayTradeRefundApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeRefundApplyErrorResponseModel")]
    public partial class AlipayTradeRefundApplyErrorResponseModel : IEquatable<AlipayTradeRefundApplyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: ACQ.SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: ACQ.INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum REFUNDAMTNOTEQUALTOTAL for value: ACQ.REFUND_AMT_NOT_EQUAL_TOTAL
            /// </summary>
            [EnumMember(Value = "ACQ.REFUND_AMT_NOT_EQUAL_TOTAL")]
            REFUNDAMTNOTEQUALTOTAL = 3,

            /// <summary>
            /// Enum TRADENOTEXIST for value: ACQ.TRADE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_NOT_EXIST")]
            TRADENOTEXIST = 4,

            /// <summary>
            /// Enum TRADEHASFINISHED for value: ACQ.TRADE_HAS_FINISHED
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_FINISHED")]
            TRADEHASFINISHED = 5,

            /// <summary>
            /// Enum TRADESTATUSERROR for value: ACQ.TRADE_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_STATUS_ERROR")]
            TRADESTATUSERROR = 6,

            /// <summary>
            /// Enum DISCORDANTREPEATREQUEST for value: ACQ.DISCORDANT_REPEAT_REQUEST
            /// </summary>
            [EnumMember(Value = "ACQ.DISCORDANT_REPEAT_REQUEST")]
            DISCORDANTREPEATREQUEST = 7,

            /// <summary>
            /// Enum REASONTRADEREFUNDFEEERR for value: ACQ.REASON_TRADE_REFUND_FEE_ERR
            /// </summary>
            [EnumMember(Value = "ACQ.REASON_TRADE_REFUND_FEE_ERR")]
            REASONTRADEREFUNDFEEERR = 8,

            /// <summary>
            /// Enum TRADENOTALLOWREFUND for value: ACQ.TRADE_NOT_ALLOW_REFUND
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_NOT_ALLOW_REFUND")]
            TRADENOTALLOWREFUND = 9,

            /// <summary>
            /// Enum REASONILLEGALSTATUS for value: ACQ.REASON_ILLEGAL_STATUS
            /// </summary>
            [EnumMember(Value = "ACQ.REASON_ILLEGAL_STATUS")]
            REASONILLEGALSTATUS = 10,

            /// <summary>
            /// Enum REFUNDTRADEFEEERROR for value: ACQ.REFUND_TRADE_FEE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.REFUND_TRADE_FEE_ERROR")]
            REFUNDTRADEFEEERROR = 11,

            /// <summary>
            /// Enum UNSUPPORTBIZTYPE for value: ACQ.UN_SUPPORT_BIZ_TYPE
            /// </summary>
            [EnumMember(Value = "ACQ.UN_SUPPORT_BIZ_TYPE")]
            UNSUPPORTBIZTYPE = 12,

            /// <summary>
            /// Enum TRADEHASCLOSE for value: ACQ.TRADE_HAS_CLOSE
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_CLOSE")]
            TRADEHASCLOSE = 13

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeRefundApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradeRefundApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeRefundApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradeRefundApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradeRefundApplyErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeRefundApplyErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AlipayTradeRefundApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeRefundApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeRefundApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeRefundApplyErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
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
