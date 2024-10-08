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
    /// AlipayTradeCustomsDeclareErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeCustomsDeclareErrorResponseModel")]
    public partial class AlipayTradeCustomsDeclareErrorResponseModel : IEquatable<AlipayTradeCustomsDeclareErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum TRADENOTEXIST for value: TRADE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "TRADE_NOT_EXIST")]
            TRADENOTEXIST = 1,

            /// <summary>
            /// Enum TRADESTATUSERROR for value: TRADE_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "TRADE_STATUS_ERROR")]
            TRADESTATUSERROR = 2,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 3,

            /// <summary>
            /// Enum CONTEXTINCONSISTENT for value: CONTEXT_INCONSISTENT
            /// </summary>
            [EnumMember(Value = "CONTEXT_INCONSISTENT")]
            CONTEXTINCONSISTENT = 4,

            /// <summary>
            /// Enum SAMECUSTOMSDECLAREONCE for value: SAME_CUSTOMS_DECLARE_ONCE
            /// </summary>
            [EnumMember(Value = "SAME_CUSTOMS_DECLARE_ONCE")]
            SAMECUSTOMSDECLAREONCE = 5,

            /// <summary>
            /// Enum REQUESTAMOUNTEXCEED for value: REQUEST_AMOUNT_EXCEED
            /// </summary>
            [EnumMember(Value = "REQUEST_AMOUNT_EXCEED")]
            REQUESTAMOUNTEXCEED = 6,

            /// <summary>
            /// Enum PARTNERERROR for value: PARTNER_ERROR
            /// </summary>
            [EnumMember(Value = "PARTNER_ERROR")]
            PARTNERERROR = 7,

            /// <summary>
            /// Enum PAYERENABLESTATUSFORBID for value: PAYER_ENABLE_STATUS_FORBID
            /// </summary>
            [EnumMember(Value = "PAYER_ENABLE_STATUS_FORBID")]
            PAYERENABLESTATUSFORBID = 8,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 9,

            /// <summary>
            /// Enum PAYERBUYERMISMATCH for value: PAYER_BUYER_MISMATCH
            /// </summary>
            [EnumMember(Value = "PAYER_BUYER_MISMATCH")]
            PAYERBUYERMISMATCH = 10,

            /// <summary>
            /// Enum DEPOSITTRADENOTEXIST for value: DEPOSIT_TRADE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "DEPOSIT_TRADE_NOT_EXIST")]
            DEPOSITTRADENOTEXIST = 11,

            /// <summary>
            /// Enum NOTSUPPORTSPLIT for value: NOT_SUPPORT_SPLIT
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORT_SPLIT")]
            NOTSUPPORTSPLIT = 12,

            /// <summary>
            /// Enum PAYERCERTINFOILLEGAL for value: PAYER_CERT_INFO_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PAYER_CERT_INFO_ILLEGAL")]
            PAYERCERTINFOILLEGAL = 13

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeCustomsDeclareErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradeCustomsDeclareErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeCustomsDeclareErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradeCustomsDeclareErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradeCustomsDeclareErrorResponseModel and cannot be null");
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
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeCustomsDeclareErrorResponseModel {\n");
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
            return this.Equals(input as AlipayTradeCustomsDeclareErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeCustomsDeclareErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeCustomsDeclareErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeCustomsDeclareErrorResponseModel input)
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
