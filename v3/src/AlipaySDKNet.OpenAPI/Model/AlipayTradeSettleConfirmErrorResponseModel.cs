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
    /// AlipayTradeSettleConfirmErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeSettleConfirmErrorResponseModel")]
    public partial class AlipayTradeSettleConfirmErrorResponseModel : IEquatable<AlipayTradeSettleConfirmErrorResponseModel>, IValidatableObject
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
            /// Enum TRADENOTEXIST for value: ACQ.TRADE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_NOT_EXIST")]
            TRADENOTEXIST = 3,

            /// <summary>
            /// Enum PARTNERERROR for value: ACQ.PARTNER_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.PARTNER_ERROR")]
            PARTNERERROR = 4,

            /// <summary>
            /// Enum DUPOUTREQUESTNO for value: ACQ.DUP_OUT_REQUEST_NO
            /// </summary>
            [EnumMember(Value = "ACQ.DUP_OUT_REQUEST_NO")]
            DUPOUTREQUESTNO = 5,

            /// <summary>
            /// Enum TRADESETTLEERROR for value: ACQ.TRADE_SETTLE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_SETTLE_ERROR")]
            TRADESETTLEERROR = 6,

            /// <summary>
            /// Enum ILLEGALSETTLESTATE for value: ACQ.ILLEGAL_SETTLE_STATE
            /// </summary>
            [EnumMember(Value = "ACQ.ILLEGAL_SETTLE_STATE")]
            ILLEGALSETTLESTATE = 7,

            /// <summary>
            /// Enum REASONILLEGALSTATUS for value: ACQ.REASON_ILLEGAL_STATUS
            /// </summary>
            [EnumMember(Value = "ACQ.REASON_ILLEGAL_STATUS")]
            REASONILLEGALSTATUS = 8,

            /// <summary>
            /// Enum SECONDARYMERCHANTALIPAYACCOUNTNOTEXIST for value: ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_NOT_EXIST")]
            SECONDARYMERCHANTALIPAYACCOUNTNOTEXIST = 9,

            /// <summary>
            /// Enum DEFAULTSETTLERULENOTEXIST for value: ACQ.DEFAULT_SETTLE_RULE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.DEFAULT_SETTLE_RULE_NOT_EXIST")]
            DEFAULTSETTLERULENOTEXIST = 10,

            /// <summary>
            /// Enum REASONTRADESTATUSINVALID for value: ACQ.REASON_TRADE_STATUS_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.REASON_TRADE_STATUS_INVALID")]
            REASONTRADESTATUSINVALID = 11,

            /// <summary>
            /// Enum FREQUENCYLIMITED for value: ACQ.FREQUENCY_LIMITED
            /// </summary>
            [EnumMember(Value = "ACQ.FREQUENCY_LIMITED")]
            FREQUENCYLIMITED = 12,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDINVALID for value: ACQ.SECONDARY_MERCHANT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ID_INVALID")]
            SECONDARYMERCHANTIDINVALID = 13,

            /// <summary>
            /// Enum USERACCOUNTHADFREEZEN for value: ACQ.USER_ACCOUNT_HAD_FREEZEN
            /// </summary>
            [EnumMember(Value = "ACQ.USER_ACCOUNT_HAD_FREEZEN")]
            USERACCOUNTHADFREEZEN = 14,

            /// <summary>
            /// Enum DISCORDANTREPEATREQUEST for value: ACQ.DISCORDANT_REPEAT_REQUEST
            /// </summary>
            [EnumMember(Value = "ACQ.DISCORDANT_REPEAT_REQUEST")]
            DISCORDANTREPEATREQUEST = 15,

            /// <summary>
            /// Enum TXNRESULTACCOUNTBALANCENOTENOUGH for value: ACQ.TXN_RESULT_ACCOUNT_BALANCE_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "ACQ.TXN_RESULT_ACCOUNT_BALANCE_NOT_ENOUGH")]
            TXNRESULTACCOUNTBALANCENOTENOUGH = 16,

            /// <summary>
            /// Enum SETTLEENTITYIDINVALID for value: ACQ.SETTLE_ENTITY_ID_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_ENTITY_ID_INVALID")]
            SETTLEENTITYIDINVALID = 17,

            /// <summary>
            /// Enum RISKSETTLESUSPEND for value: ACQ.RISK_SETTLE_SUSPEND
            /// </summary>
            [EnumMember(Value = "ACQ.RISK_SETTLE_SUSPEND")]
            RISKSETTLESUSPEND = 18,

            /// <summary>
            /// Enum SETTLEACCOUNTNOTEXIST for value: ACQ.SETTLE_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_ACCOUNT_NOT_EXIST")]
            SETTLEACCOUNTNOTEXIST = 19,

            /// <summary>
            /// Enum SETTLEACCOUNTNOTCERTIFY for value: ACQ.SETTLE_ACCOUNT_NOT_CERTIFY
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_ACCOUNT_NOT_CERTIFY")]
            SETTLEACCOUNTNOTCERTIFY = 20,

            /// <summary>
            /// Enum SETTLEACCOUNTNOBALANCE for value: ACQ.SETTLE_ACCOUNT_NO_BALANCE
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_ACCOUNT_NO_BALANCE")]
            SETTLEACCOUNTNOBALANCE = 21,

            /// <summary>
            /// Enum INVALIDSETTLEAMOUNTPARAMETER for value: ACQ.INVALID_SETTLE_AMOUNT_PARAMETER
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_SETTLE_AMOUNT_PARAMETER")]
            INVALIDSETTLEAMOUNTPARAMETER = 22,

            /// <summary>
            /// Enum USERLOGONIDDUP for value: ACQ.USER_LOGONID_DUP
            /// </summary>
            [EnumMember(Value = "ACQ.USER_LOGONID_DUP")]
            USERLOGONIDDUP = 23,

            /// <summary>
            /// Enum SECONDARYMERCHANTALIPAYACCOUNTINVALID for value: ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_INVALID")]
            SECONDARYMERCHANTALIPAYACCOUNTINVALID = 24,

            /// <summary>
            /// Enum ALREADYCONFIRMSETTLE for value: ACQ.ALREADY_CONFIRM_SETTLE
            /// </summary>
            [EnumMember(Value = "ACQ.ALREADY_CONFIRM_SETTLE")]
            ALREADYCONFIRMSETTLE = 25,

            /// <summary>
            /// Enum SETTLEACCOUNTHASBEENFROZEN for value: ACQ.SETTLE_ACCOUNT_HAS_BEEN_FROZEN
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_ACCOUNT_HAS_BEEN_FROZEN")]
            SETTLEACCOUNTHASBEENFROZEN = 26,

            /// <summary>
            /// Enum TRADEHASCLOSE for value: ACQ.TRADE_HAS_CLOSE
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_CLOSE")]
            TRADEHASCLOSE = 27,

            /// <summary>
            /// Enum TRADEHASFINISHED for value: ACQ.TRADE_HAS_FINISHED
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_FINISHED")]
            TRADEHASFINISHED = 28,

            /// <summary>
            /// Enum ILLEGALREQUEST for value: ACQ.ILLEGAL_REQUEST
            /// </summary>
            [EnumMember(Value = "ACQ.ILLEGAL_REQUEST")]
            ILLEGALREQUEST = 29,

            /// <summary>
            /// Enum CONFIRMREFUSEAFTERREFUND for value: ACQ.CONFIRM_REFUSE_AFTER_REFUND
            /// </summary>
            [EnumMember(Value = "ACQ.CONFIRM_REFUSE_AFTER_REFUND")]
            CONFIRMREFUSEAFTERREFUND = 30,

            /// <summary>
            /// Enum SETTLESCENENOTSUPPORT for value: ACQ.SETTLE_SCENE_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_SCENE_NOT_SUPPORT")]
            SETTLESCENENOTSUPPORT = 31,

            /// <summary>
            /// Enum INVALIDSTOREID for value: ACQ.INVALID_STORE_ID
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_STORE_ID")]
            INVALIDSTOREID = 32

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeSettleConfirmErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradeSettleConfirmErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeSettleConfirmErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradeSettleConfirmErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradeSettleConfirmErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayTradeSettleConfirmErrorResponseModel {\n");
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
            return this.Equals(input as AlipayTradeSettleConfirmErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeSettleConfirmErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeSettleConfirmErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeSettleConfirmErrorResponseModel input)
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
