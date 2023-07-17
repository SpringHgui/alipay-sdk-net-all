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
    /// AlipayTradeOrderSettleErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOrderSettleErrorResponseModel")]
    public partial class AlipayTradeOrderSettleErrorResponseModel : IEquatable<AlipayTradeOrderSettleErrorResponseModel>, IValidatableObject
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
            /// Enum TRADESTATUSERROR for value: ACQ.TRADE_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_STATUS_ERROR")]
            TRADESTATUSERROR = 4,

            /// <summary>
            /// Enum PARTNERERROR for value: ACQ.PARTNER_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.PARTNER_ERROR")]
            PARTNERERROR = 5,

            /// <summary>
            /// Enum DISCORDANTREPEATREQUEST for value: ACQ.DISCORDANT_REPEAT_REQUEST
            /// </summary>
            [EnumMember(Value = "ACQ.DISCORDANT_REPEAT_REQUEST")]
            DISCORDANTREPEATREQUEST = 6,

            /// <summary>
            /// Enum TRADESETTLEERROR for value: ACQ.TRADE_SETTLE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_SETTLE_ERROR")]
            TRADESETTLEERROR = 7,

            /// <summary>
            /// Enum USERLOGONIDDUP for value: ACQ.USER_LOGONID_DUP
            /// </summary>
            [EnumMember(Value = "ACQ.USER_LOGONID_DUP")]
            USERLOGONIDDUP = 8,

            /// <summary>
            /// Enum ROYALTYRECEIVERINVALID for value: ACQ.ROYALTY_RECEIVER_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_RECEIVER_INVALID")]
            ROYALTYRECEIVERINVALID = 9,

            /// <summary>
            /// Enum ALLOCAMOUNTVALIDATEERROR for value: ACQ.ALLOC_AMOUNT_VALIDATE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.ALLOC_AMOUNT_VALIDATE_ERROR")]
            ALLOCAMOUNTVALIDATEERROR = 10,

            /// <summary>
            /// Enum FREQUENCYLIMITED for value: ACQ.FREQUENCY_LIMITED
            /// </summary>
            [EnumMember(Value = "ACQ.FREQUENCY_LIMITED")]
            FREQUENCYLIMITED = 11,

            /// <summary>
            /// Enum CUSTOMERVALIDATEERROR for value: ACQ.CUSTOMER_VALIDATE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.CUSTOMER_VALIDATE_ERROR")]
            CUSTOMERVALIDATEERROR = 12,

            /// <summary>
            /// Enum USERACCOUNTHADFREEZEN for value: ACQ.USER_ACCOUNT_HAD_FREEZEN
            /// </summary>
            [EnumMember(Value = "ACQ.USER_ACCOUNT_HAD_FREEZEN")]
            USERACCOUNTHADFREEZEN = 13,

            /// <summary>
            /// Enum ILLEGALSETTLESTATE for value: ACQ.ILLEGAL_SETTLE_STATE
            /// </summary>
            [EnumMember(Value = "ACQ.ILLEGAL_SETTLE_STATE")]
            ILLEGALSETTLESTATE = 14,

            /// <summary>
            /// Enum TXNRESULTACCOUNTBALANCENOTENOUGH for value: ACQ.TXN_RESULT_ACCOUNT_BALANCE_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "ACQ.TXN_RESULT_ACCOUNT_BALANCE_NOT_ENOUGH")]
            TXNRESULTACCOUNTBALANCENOTENOUGH = 15,

            /// <summary>
            /// Enum REASONTRADESTATUSINVALID for value: ACQ.REASON_TRADE_STATUS_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.REASON_TRADE_STATUS_INVALID")]
            REASONTRADESTATUSINVALID = 16,

            /// <summary>
            /// Enum NOTSUPPORTROYALTY for value: ACQ.NOT_SUPPORT_ROYALTY
            /// </summary>
            [EnumMember(Value = "ACQ.NOT_SUPPORT_ROYALTY")]
            NOTSUPPORTROYALTY = 17,

            /// <summary>
            /// Enum ROYALTYACCOUNTNOTEXIST for value: ACQ.ROYALTY_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_ACCOUNT_NOT_EXIST")]
            ROYALTYACCOUNTNOTEXIST = 18,

            /// <summary>
            /// Enum ROYALTYACCOUNTINVALID for value: ACQ.ROYALTY_ACCOUNT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_ACCOUNT_INVALID")]
            ROYALTYACCOUNTINVALID = 19,

            /// <summary>
            /// Enum SETTLEENTITYIDINVALID for value: ACQ.SETTLE_ENTITY_ID_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_ENTITY_ID_INVALID")]
            SETTLEENTITYIDINVALID = 20,

            /// <summary>
            /// Enum ROYALTYACCOUNTSEQUAL for value: ACQ.ROYALTY_ACCOUNTS_EQUAL
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_ACCOUNTS_EQUAL")]
            ROYALTYACCOUNTSEQUAL = 21,

            /// <summary>
            /// Enum DUPOUTREQUESTNO for value: ACQ.DUP_OUT_REQUEST_NO
            /// </summary>
            [EnumMember(Value = "ACQ.DUP_OUT_REQUEST_NO")]
            DUPOUTREQUESTNO = 22,

            /// <summary>
            /// Enum MERCHANTRISKLIMIT for value: ACQ.MERCHANT_RISK_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_RISK_LIMIT")]
            MERCHANTRISKLIMIT = 23,

            /// <summary>
            /// Enum ROYALTYPAYERACCOUNTNOTEXIST for value: ACQ.ROYALTY_PAYER_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_PAYER_ACCOUNT_NOT_EXIST")]
            ROYALTYPAYERACCOUNTNOTEXIST = 24,

            /// <summary>
            /// Enum ROYALTYRECEIVERACCOUNTNOTEXIST for value: ACQ.ROYALTY_RECEIVER_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_RECEIVER_ACCOUNT_NOT_EXIST")]
            ROYALTYRECEIVERACCOUNTNOTEXIST = 25,

            /// <summary>
            /// Enum ROYALTYPAYERACCOUNTNOTCERTIFY for value: ACQ.ROYALTY_PAYER_ACCOUNT_NOT_CERTIFY
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_PAYER_ACCOUNT_NOT_CERTIFY")]
            ROYALTYPAYERACCOUNTNOTCERTIFY = 26,

            /// <summary>
            /// Enum ROYALTYRECEIVERACCOUNTNOTCERTIFY for value: ACQ.ROYALTY_RECEIVER_ACCOUNT_NOT_CERTIFY
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_RECEIVER_ACCOUNT_NOT_CERTIFY")]
            ROYALTYRECEIVERACCOUNTNOTCERTIFY = 27,

            /// <summary>
            /// Enum ROYALTYPAYERACCOUNTNOBALANCE for value: ACQ.ROYALTY_PAYER_ACCOUNT_NO_BALANCE
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_PAYER_ACCOUNT_NO_BALANCE")]
            ROYALTYPAYERACCOUNTNOBALANCE = 28,

            /// <summary>
            /// Enum ROYALTYRECEIVERACCOUNTNOBALANCE for value: ACQ.ROYALTY_RECEIVER_ACCOUNT_NO_BALANCE
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_RECEIVER_ACCOUNT_NO_BALANCE")]
            ROYALTYRECEIVERACCOUNTNOBALANCE = 29,

            /// <summary>
            /// Enum ROYALTYACCOUNTNAMENOTMATCH for value: ACQ.ROYALTY_ACCOUNT_NAME_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_ACCOUNT_NAME_NOT_MATCH")]
            ROYALTYACCOUNTNAMENOTMATCH = 30,

            /// <summary>
            /// Enum SETTLETOCARDNOTSUPPORT for value: ACQ.SETTLE_TO_CARD_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_TO_CARD_NOT_SUPPORT")]
            SETTLETOCARDNOTSUPPORT = 31,

            /// <summary>
            /// Enum REPLENISHACCOUNTINVALID for value: ACQ.REPLENISH_ACCOUNT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.REPLENISH_ACCOUNT_INVALID")]
            REPLENISHACCOUNTINVALID = 32,

            /// <summary>
            /// Enum INVALIDREPLENISHAMOUNT for value: ACQ.INVALID_REPLENISH_AMOUNT
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_REPLENISH_AMOUNT")]
            INVALIDREPLENISHAMOUNT = 33,

            /// <summary>
            /// Enum ASYNCALLOCNOTSUPPORTINPERIOD for value: ACQ.ASYNC_ALLOC_NOT_SUPPORT_IN_PERIOD
            /// </summary>
            [EnumMember(Value = "ACQ.ASYNC_ALLOC_NOT_SUPPORT_IN_PERIOD")]
            ASYNCALLOCNOTSUPPORTINPERIOD = 34,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDINVALID for value: ACQ.SECONDARY_MERCHANT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ID_INVALID")]
            SECONDARYMERCHANTIDINVALID = 35,

            /// <summary>
            /// Enum MUSTALLOCFROMROOTACCOUNT for value: ACQ.MUST_ALLOC_FROM_ROOT_ACCOUNT
            /// </summary>
            [EnumMember(Value = "ACQ.MUST_ALLOC_FROM_ROOT_ACCOUNT")]
            MUSTALLOCFROMROOTACCOUNT = 36,

            /// <summary>
            /// Enum UNSUPPORTBIZTYPE for value: ACQ.UN_SUPPORT_BIZ_TYPE
            /// </summary>
            [EnumMember(Value = "ACQ.UN_SUPPORT_BIZ_TYPE")]
            UNSUPPORTBIZTYPE = 37,

            /// <summary>
            /// Enum ACCESSFORBIDDEN for value: ACQ.ACCESS_FORBIDDEN
            /// </summary>
            [EnumMember(Value = "ACQ.ACCESS_FORBIDDEN")]
            ACCESSFORBIDDEN = 38,

            /// <summary>
            /// Enum ILLEGALREQUEST for value: ACQ.ILLEGAL_REQUEST
            /// </summary>
            [EnumMember(Value = "ACQ.ILLEGAL_REQUEST")]
            ILLEGALREQUEST = 39,

            /// <summary>
            /// Enum SETTLESCENENOTSUPPORT for value: ACQ.SETTLE_SCENE_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "ACQ.SETTLE_SCENE_NOT_SUPPORT")]
            SETTLESCENENOTSUPPORT = 40,

            /// <summary>
            /// Enum ALLOCREFUSEBEFORESETTLE for value: ACQ.ALLOC_REFUSE_BEFORE_SETTLE
            /// </summary>
            [EnumMember(Value = "ACQ.ALLOC_REFUSE_BEFORE_SETTLE")]
            ALLOCREFUSEBEFORESETTLE = 41,

            /// <summary>
            /// Enum ALLOCREFUSEAFTERREFUND for value: ACQ.ALLOC_REFUSE_AFTER_REFUND
            /// </summary>
            [EnumMember(Value = "ACQ.ALLOC_REFUSE_AFTER_REFUND")]
            ALLOCREFUSEAFTERREFUND = 42

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderSettleErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradeOrderSettleErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderSettleErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradeOrderSettleErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradeOrderSettleErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayTradeOrderSettleErrorResponseModel {\n");
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
            return this.Equals(input as AlipayTradeOrderSettleErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOrderSettleErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOrderSettleErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOrderSettleErrorResponseModel input)
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
