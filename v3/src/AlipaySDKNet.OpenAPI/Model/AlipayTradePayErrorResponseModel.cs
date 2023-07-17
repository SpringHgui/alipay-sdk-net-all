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
    /// AlipayTradePayErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradePayErrorResponseModel")]
    public partial class AlipayTradePayErrorResponseModel : IEquatable<AlipayTradePayErrorResponseModel>, IValidatableObject
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
            /// Enum ACCESSFORBIDDEN for value: ACQ.ACCESS_FORBIDDEN
            /// </summary>
            [EnumMember(Value = "ACQ.ACCESS_FORBIDDEN")]
            ACCESSFORBIDDEN = 3,

            /// <summary>
            /// Enum EXISTFORBIDDENWORD for value: ACQ.EXIST_FORBIDDEN_WORD
            /// </summary>
            [EnumMember(Value = "ACQ.EXIST_FORBIDDEN_WORD")]
            EXISTFORBIDDENWORD = 4,

            /// <summary>
            /// Enum PARTNERERROR for value: ACQ.PARTNER_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.PARTNER_ERROR")]
            PARTNERERROR = 5,

            /// <summary>
            /// Enum TOTALFEEEXCEED for value: ACQ.TOTAL_FEE_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.TOTAL_FEE_EXCEED")]
            TOTALFEEEXCEED = 6,

            /// <summary>
            /// Enum PAYMENTAUTHCODEINVALID for value: ACQ.PAYMENT_AUTH_CODE_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.PAYMENT_AUTH_CODE_INVALID")]
            PAYMENTAUTHCODEINVALID = 7,

            /// <summary>
            /// Enum CONTEXTINCONSISTENT for value: ACQ.CONTEXT_INCONSISTENT
            /// </summary>
            [EnumMember(Value = "ACQ.CONTEXT_INCONSISTENT")]
            CONTEXTINCONSISTENT = 8,

            /// <summary>
            /// Enum TRADEHASSUCCESS for value: ACQ.TRADE_HAS_SUCCESS
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_SUCCESS")]
            TRADEHASSUCCESS = 9,

            /// <summary>
            /// Enum TRADEHASCLOSE for value: ACQ.TRADE_HAS_CLOSE
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_HAS_CLOSE")]
            TRADEHASCLOSE = 10,

            /// <summary>
            /// Enum BUYERBALANCENOTENOUGH for value: ACQ.BUYER_BALANCE_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_BALANCE_NOT_ENOUGH")]
            BUYERBALANCENOTENOUGH = 11,

            /// <summary>
            /// Enum BUYERBANKCARDBALANCENOTENOUGH for value: ACQ.BUYER_BANKCARD_BALANCE_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_BANKCARD_BALANCE_NOT_ENOUGH")]
            BUYERBANKCARDBALANCENOTENOUGH = 12,

            /// <summary>
            /// Enum ERRORBALANCEPAYMENTDISABLE for value: ACQ.ERROR_BALANCE_PAYMENT_DISABLE
            /// </summary>
            [EnumMember(Value = "ACQ.ERROR_BALANCE_PAYMENT_DISABLE")]
            ERRORBALANCEPAYMENTDISABLE = 13,

            /// <summary>
            /// Enum BUYERSELLEREQUAL for value: ACQ.BUYER_SELLER_EQUAL
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_SELLER_EQUAL")]
            BUYERSELLEREQUAL = 14,

            /// <summary>
            /// Enum TRADEBUYERNOTMATCH for value: ACQ.TRADE_BUYER_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_BUYER_NOT_MATCH")]
            TRADEBUYERNOTMATCH = 15,

            /// <summary>
            /// Enum BUYERENABLESTATUSFORBID for value: ACQ.BUYER_ENABLE_STATUS_FORBID
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_ENABLE_STATUS_FORBID")]
            BUYERENABLESTATUSFORBID = 16,

            /// <summary>
            /// Enum PULLMOBILECASHIERFAIL for value: ACQ.PULL_MOBILE_CASHIER_FAIL
            /// </summary>
            [EnumMember(Value = "ACQ.PULL_MOBILE_CASHIER_FAIL")]
            PULLMOBILECASHIERFAIL = 17,

            /// <summary>
            /// Enum MOBILEPAYMENTSWITCHOFF for value: ACQ.MOBILE_PAYMENT_SWITCH_OFF
            /// </summary>
            [EnumMember(Value = "ACQ.MOBILE_PAYMENT_SWITCH_OFF")]
            MOBILEPAYMENTSWITCHOFF = 18,

            /// <summary>
            /// Enum PAYMENTFAIL for value: ACQ.PAYMENT_FAIL
            /// </summary>
            [EnumMember(Value = "ACQ.PAYMENT_FAIL")]
            PAYMENTFAIL = 19,

            /// <summary>
            /// Enum BUYERPAYMENTAMOUNTDAYLIMITERROR for value: ACQ.BUYER_PAYMENT_AMOUNT_DAY_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_PAYMENT_AMOUNT_DAY_LIMIT_ERROR")]
            BUYERPAYMENTAMOUNTDAYLIMITERROR = 20,

            /// <summary>
            /// Enum BEYONDPAYRESTRICTION for value: ACQ.BEYOND_PAY_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PAY_RESTRICTION")]
            BEYONDPAYRESTRICTION = 21,

            /// <summary>
            /// Enum BEYONDPERRECEIPTRESTRICTION for value: ACQ.BEYOND_PER_RECEIPT_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PER_RECEIPT_RESTRICTION")]
            BEYONDPERRECEIPTRESTRICTION = 22,

            /// <summary>
            /// Enum BUYERPAYMENTAMOUNTMONTHLIMITERROR for value: ACQ.BUYER_PAYMENT_AMOUNT_MONTH_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_PAYMENT_AMOUNT_MONTH_LIMIT_ERROR")]
            BUYERPAYMENTAMOUNTMONTHLIMITERROR = 23,

            /// <summary>
            /// Enum SELLERBEENBLOCKED for value: ACQ.SELLER_BEEN_BLOCKED
            /// </summary>
            [EnumMember(Value = "ACQ.SELLER_BEEN_BLOCKED")]
            SELLERBEENBLOCKED = 24,

            /// <summary>
            /// Enum ERRORBUYERCERTIFYLEVELLIMIT for value: ACQ.ERROR_BUYER_CERTIFY_LEVEL_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.ERROR_BUYER_CERTIFY_LEVEL_LIMIT")]
            ERRORBUYERCERTIFYLEVELLIMIT = 25,

            /// <summary>
            /// Enum PAYMENTREQUESTHASRISK for value: ACQ.PAYMENT_REQUEST_HAS_RISK
            /// </summary>
            [EnumMember(Value = "ACQ.PAYMENT_REQUEST_HAS_RISK")]
            PAYMENTREQUESTHASRISK = 26,

            /// <summary>
            /// Enum NOPAYMENTINSTRUMENTSAVAILABLE for value: ACQ.NO_PAYMENT_INSTRUMENTS_AVAILABLE
            /// </summary>
            [EnumMember(Value = "ACQ.NO_PAYMENT_INSTRUMENTS_AVAILABLE")]
            NOPAYMENTINSTRUMENTSAVAILABLE = 27,

            /// <summary>
            /// Enum USERFACEPAYMENTSWITCHOFF for value: ACQ.USER_FACE_PAYMENT_SWITCH_OFF
            /// </summary>
            [EnumMember(Value = "ACQ.USER_FACE_PAYMENT_SWITCH_OFF")]
            USERFACEPAYMENTSWITCHOFF = 28,

            /// <summary>
            /// Enum INVALIDSTOREID for value: ACQ.INVALID_STORE_ID
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_STORE_ID")]
            INVALIDSTOREID = 29,

            /// <summary>
            /// Enum SUBMERCHANTCREATEFAIL for value: ACQ.SUB_MERCHANT_CREATE_FAIL
            /// </summary>
            [EnumMember(Value = "ACQ.SUB_MERCHANT_CREATE_FAIL")]
            SUBMERCHANTCREATEFAIL = 30,

            /// <summary>
            /// Enum SUBMERCHANTTYPEINVALID for value: ACQ.SUB_MERCHANT_TYPE_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SUB_MERCHANT_TYPE_INVALID")]
            SUBMERCHANTTYPEINVALID = 31,

            /// <summary>
            /// Enum AGREEMENTNOTEXIST for value: ACQ.AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.AGREEMENT_NOT_EXIST")]
            AGREEMENTNOTEXIST = 32,

            /// <summary>
            /// Enum AGREEMENTINVALID for value: ACQ.AGREEMENT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.AGREEMENT_INVALID")]
            AGREEMENTINVALID = 33,

            /// <summary>
            /// Enum AGREEMENTSTATUSNOTNORMAL for value: ACQ.AGREEMENT_STATUS_NOT_NORMAL
            /// </summary>
            [EnumMember(Value = "ACQ.AGREEMENT_STATUS_NOT_NORMAL")]
            AGREEMENTSTATUSNOTNORMAL = 34,

            /// <summary>
            /// Enum MERCHANTAGREEMENTNOTEXIST for value: ACQ.MERCHANT_AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_AGREEMENT_NOT_EXIST")]
            MERCHANTAGREEMENTNOTEXIST = 35,

            /// <summary>
            /// Enum MERCHANTAGREEMENTINVALID for value: ACQ.MERCHANT_AGREEMENT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_AGREEMENT_INVALID")]
            MERCHANTAGREEMENTINVALID = 36,

            /// <summary>
            /// Enum MERCHANTSTATUSNOTNORMAL for value: ACQ.MERCHANT_STATUS_NOT_NORMAL
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_STATUS_NOT_NORMAL")]
            MERCHANTSTATUSNOTNORMAL = 37,

            /// <summary>
            /// Enum CARDUSERNOTMATCH for value: ACQ.CARD_USER_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.CARD_USER_NOT_MATCH")]
            CARDUSERNOTMATCH = 38,

            /// <summary>
            /// Enum CARDTYPEERROR for value: ACQ.CARD_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.CARD_TYPE_ERROR")]
            CARDTYPEERROR = 39,

            /// <summary>
            /// Enum CERTEXPIRED for value: ACQ.CERT_EXPIRED
            /// </summary>
            [EnumMember(Value = "ACQ.CERT_EXPIRED")]
            CERTEXPIRED = 40,

            /// <summary>
            /// Enum AMOUNTORCURRENCYERROR for value: ACQ.AMOUNT_OR_CURRENCY_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.AMOUNT_OR_CURRENCY_ERROR")]
            AMOUNTORCURRENCYERROR = 41,

            /// <summary>
            /// Enum CURRENCYNOTSUPPORT for value: ACQ.CURRENCY_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "ACQ.CURRENCY_NOT_SUPPORT")]
            CURRENCYNOTSUPPORT = 42,

            /// <summary>
            /// Enum MERCHANTUNSUPPORTADVANCE for value: ACQ.MERCHANT_UNSUPPORT_ADVANCE
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_UNSUPPORT_ADVANCE")]
            MERCHANTUNSUPPORTADVANCE = 43,

            /// <summary>
            /// Enum BUYERUNSUPPORTADVANCE for value: ACQ.BUYER_UNSUPPORT_ADVANCE
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_UNSUPPORT_ADVANCE")]
            BUYERUNSUPPORTADVANCE = 44,

            /// <summary>
            /// Enum ORDERUNSUPPORTADVANCE for value: ACQ.ORDER_UNSUPPORT_ADVANCE
            /// </summary>
            [EnumMember(Value = "ACQ.ORDER_UNSUPPORT_ADVANCE")]
            ORDERUNSUPPORTADVANCE = 45,

            /// <summary>
            /// Enum CYCLEPAYDATENOTMATCH for value: ACQ.CYCLE_PAY_DATE_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.CYCLE_PAY_DATE_NOT_MATCH")]
            CYCLEPAYDATENOTMATCH = 46,

            /// <summary>
            /// Enum CYCLEPAYSINGLEFEEEXCEED for value: ACQ.CYCLE_PAY_SINGLE_FEE_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.CYCLE_PAY_SINGLE_FEE_EXCEED")]
            CYCLEPAYSINGLEFEEEXCEED = 47,

            /// <summary>
            /// Enum CYCLEPAYTOTALFEEEXCEED for value: ACQ.CYCLE_PAY_TOTAL_FEE_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.CYCLE_PAY_TOTAL_FEE_EXCEED")]
            CYCLEPAYTOTALFEEEXCEED = 48,

            /// <summary>
            /// Enum CYCLEPAYTOTALTIMESEXCEED for value: ACQ.CYCLE_PAY_TOTAL_TIMES_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.CYCLE_PAY_TOTAL_TIMES_EXCEED")]
            CYCLEPAYTOTALTIMESEXCEED = 49,

            /// <summary>
            /// Enum SECONDARYMERCHANTSTATUSERROR for value: ACQ.SECONDARY_MERCHANT_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_STATUS_ERROR")]
            SECONDARYMERCHANTSTATUSERROR = 50,

            /// <summary>
            /// Enum AUTHNOERROR for value: ACQ.AUTH_NO_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.AUTH_NO_ERROR")]
            AUTHNOERROR = 51,

            /// <summary>
            /// Enum BUYERNOTEXIST for value: ACQ.BUYER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_NOT_EXIST")]
            BUYERNOTEXIST = 52,

            /// <summary>
            /// Enum PRODUCTAMOUNTLIMITERROR for value: ACQ.PRODUCT_AMOUNT_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.PRODUCT_AMOUNT_LIMIT_ERROR")]
            PRODUCTAMOUNTLIMITERROR = 53,

            /// <summary>
            /// Enum SECONDARYMERCHANTALIPAYACCOUNTINVALID for value: ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ALIPAY_ACCOUNT_INVALID")]
            SECONDARYMERCHANTALIPAYACCOUNTINVALID = 54,

            /// <summary>
            /// Enum INVALIDRECEIVEACCOUNT for value: ACQ.INVALID_RECEIVE_ACCOUNT
            /// </summary>
            [EnumMember(Value = "ACQ.INVALID_RECEIVE_ACCOUNT")]
            INVALIDRECEIVEACCOUNT = 55,

            /// <summary>
            /// Enum SELLERNOTEXIST for value: ACQ.SELLER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.SELLER_NOT_EXIST")]
            SELLERNOTEXIST = 56,

            /// <summary>
            /// Enum AUTHAMOUNTNOTENOUGH for value: ACQ.AUTH_AMOUNT_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "ACQ.AUTH_AMOUNT_NOT_ENOUGH")]
            AUTHAMOUNTNOTENOUGH = 57,

            /// <summary>
            /// Enum AGREEMENTERROR for value: ACQ.AGREEMENT_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.AGREEMENT_ERROR")]
            AGREEMENTERROR = 58,

            /// <summary>
            /// Enum BEYONDPERRECEIPTSINGLERESTRICTION for value: ACQ.BEYOND_PER_RECEIPT_SINGLE_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PER_RECEIPT_SINGLE_RESTRICTION")]
            BEYONDPERRECEIPTSINGLERESTRICTION = 59,

            /// <summary>
            /// Enum PAYERUNMATCHED for value: ACQ.PAYER_UNMATCHED
            /// </summary>
            [EnumMember(Value = "ACQ.PAYER_UNMATCHED")]
            PAYERUNMATCHED = 60,

            /// <summary>
            /// Enum PREAUTHPRODCODEINCONSISTENT for value: ACQ.PRE_AUTH_PROD_CODE_INCONSISTENT
            /// </summary>
            [EnumMember(Value = "ACQ.PRE_AUTH_PROD_CODE_INCONSISTENT")]
            PREAUTHPRODCODEINCONSISTENT = 61,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDINVALID for value: ACQ.SECONDARY_MERCHANT_ID_INVALID
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ID_INVALID")]
            SECONDARYMERCHANTIDINVALID = 62,

            /// <summary>
            /// Enum NOWTIMEAFTEREXPIRETIMEERROR for value: ACQ.NOW_TIME_AFTER_EXPIRE_TIME_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.NOW_TIME_AFTER_EXPIRE_TIME_ERROR")]
            NOWTIMEAFTEREXPIRETIMEERROR = 63,

            /// <summary>
            /// Enum SECONDARYMERCHANTNOTMATCH for value: ACQ.SECONDARY_MERCHANT_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_NOT_MATCH")]
            SECONDARYMERCHANTNOTMATCH = 64,

            /// <summary>
            /// Enum REQUESTAMOUNTEXCEED for value: ACQ.REQUEST_AMOUNT_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.REQUEST_AMOUNT_EXCEED")]
            REQUESTAMOUNTEXCEED = 65,

            /// <summary>
            /// Enum SUBGOODSSIZEMAXCOUNT for value: ACQ.SUB_GOODS_SIZE_MAX_COUNT
            /// </summary>
            [EnumMember(Value = "ACQ.SUB_GOODS_SIZE_MAX_COUNT")]
            SUBGOODSSIZEMAXCOUNT = 66,

            /// <summary>
            /// Enum NOTSUPPORTPAYMENTINST for value: ACQ.NOT_SUPPORT_PAYMENT_INST
            /// </summary>
            [EnumMember(Value = "ACQ.NOT_SUPPORT_PAYMENT_INST")]
            NOTSUPPORTPAYMENTINST = 67,

            /// <summary>
            /// Enum BUYERNOTMAINLANDCERT for value: ACQ.BUYER_NOT_MAINLAND_CERT
            /// </summary>
            [EnumMember(Value = "ACQ.BUYER_NOT_MAINLAND_CERT")]
            BUYERNOTMAINLANDCERT = 68,

            /// <summary>
            /// Enum SECONDARYMERCHANTIDBLANK for value: ACQ.SECONDARY_MERCHANT_ID_BLANK
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ID_BLANK")]
            SECONDARYMERCHANTIDBLANK = 69,

            /// <summary>
            /// Enum TRADESETTLEERROR for value: ACQ.TRADE_SETTLE_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_SETTLE_ERROR")]
            TRADESETTLEERROR = 70,

            /// <summary>
            /// Enum AUTHTOKENISNOTEXIST for value: ACQ.AUTH_TOKEN_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.AUTH_TOKEN_IS_NOT_EXIST")]
            AUTHTOKENISNOTEXIST = 71,

            /// <summary>
            /// Enum SMILEPAYMERCHANTNOTMATCH for value: ACQ.SMILE_PAY_MERCHANT_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "ACQ.SMILE_PAY_MERCHANT_NOT_MATCH")]
            SMILEPAYMERCHANTNOTMATCH = 72,

            /// <summary>
            /// Enum NOTCERTIFIEDUSER for value: ACQ.NOT_CERTIFIED_USER
            /// </summary>
            [EnumMember(Value = "ACQ.NOT_CERTIFIED_USER")]
            NOTCERTIFIEDUSER = 73,

            /// <summary>
            /// Enum SECONDARYMERCHANTISVPUNISHINDIRECT for value: ACQ.SECONDARY_MERCHANT_ISV_PUNISH_INDIRECT
            /// </summary>
            [EnumMember(Value = "ACQ.SECONDARY_MERCHANT_ISV_PUNISH_INDIRECT")]
            SECONDARYMERCHANTISVPUNISHINDIRECT = 74,

            /// <summary>
            /// Enum RESTRICTEDMERCHANTINDUSTRY for value: ACQ.RESTRICTED_MERCHANT_INDUSTRY
            /// </summary>
            [EnumMember(Value = "ACQ.RESTRICTED_MERCHANT_INDUSTRY")]
            RESTRICTEDMERCHANTINDUSTRY = 75,

            /// <summary>
            /// Enum PLATFORMBUSINESSACQUIREMODEMUSTMERCHANTID for value: ACQ.PLATFORM_BUSINESS_ACQUIRE_MODE_MUST_MERCHANT_ID
            /// </summary>
            [EnumMember(Value = "ACQ.PLATFORM_BUSINESS_ACQUIRE_MODE_MUST_MERCHANT_ID")]
            PLATFORMBUSINESSACQUIREMODEMUSTMERCHANTID = 76,

            /// <summary>
            /// Enum BEYONDPERRECEIPTDAYRESTRICTION for value: ACQ.BEYOND_PER_RECEIPT_DAY_RESTRICTION
            /// </summary>
            [EnumMember(Value = "ACQ.BEYOND_PER_RECEIPT_DAY_RESTRICTION")]
            BEYONDPERRECEIPTDAYRESTRICTION = 77,

            /// <summary>
            /// Enum TRADESTATUSERROR for value: ACQ.TRADE_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "ACQ.TRADE_STATUS_ERROR")]
            TRADESTATUSERROR = 78,

            /// <summary>
            /// Enum MERCHANTPERMRECEIPTSUSPENDLIMIT for value: ACQ.MERCHANT_PERM_RECEIPT_SUSPEND_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_PERM_RECEIPT_SUSPEND_LIMIT")]
            MERCHANTPERMRECEIPTSUSPENDLIMIT = 79,

            /// <summary>
            /// Enum MERCHANTPERMRECEIPTSINGLELIMIT for value: ACQ.MERCHANT_PERM_RECEIPT_SINGLE_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_PERM_RECEIPT_SINGLE_LIMIT")]
            MERCHANTPERMRECEIPTSINGLELIMIT = 80,

            /// <summary>
            /// Enum MERCHANTPERMRECEIPTDAYLIMIT for value: ACQ.MERCHANT_PERM_RECEIPT_DAY_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.MERCHANT_PERM_RECEIPT_DAY_LIMIT")]
            MERCHANTPERMRECEIPTDAYLIMIT = 81,

            /// <summary>
            /// Enum USERLOGONIDDUP for value: ACQ.USER_LOGONID_DUP
            /// </summary>
            [EnumMember(Value = "ACQ.USER_LOGONID_DUP")]
            USERLOGONIDDUP = 82,

            /// <summary>
            /// Enum AUTHORDERNOTPAID for value: ACQ.AUTH_ORDER_NOT_PAID
            /// </summary>
            [EnumMember(Value = "ACQ.AUTH_ORDER_NOT_PAID")]
            AUTHORDERNOTPAID = 83,

            /// <summary>
            /// Enum AUTHORDERHASFINISHED for value: ACQ.AUTH_ORDER_HAS_FINISHED
            /// </summary>
            [EnumMember(Value = "ACQ.AUTH_ORDER_HAS_FINISHED")]
            AUTHORDERHASFINISHED = 84,

            /// <summary>
            /// Enum AUTHORDERHASCLOSED for value: ACQ.AUTH_ORDER_HAS_CLOSED
            /// </summary>
            [EnumMember(Value = "ACQ.AUTH_ORDER_HAS_CLOSED")]
            AUTHORDERHASCLOSED = 85,

            /// <summary>
            /// Enum ZMAUTHAMOUNTEXCEED for value: ACQ.ZM_AUTH_AMOUNT_EXCEED
            /// </summary>
            [EnumMember(Value = "ACQ.ZM_AUTH_AMOUNT_EXCEED")]
            ZMAUTHAMOUNTEXCEED = 86,

            /// <summary>
            /// Enum ZMCREDITAUTHFAIL for value: ACQ.ZM_CREDIT_AUTH_FAIL
            /// </summary>
            [EnumMember(Value = "ACQ.ZM_CREDIT_AUTH_FAIL")]
            ZMCREDITAUTHFAIL = 87,

            /// <summary>
            /// Enum ZMAUTHRULELIMIT for value: ACQ.ZM_AUTH_RULE_LIMIT
            /// </summary>
            [EnumMember(Value = "ACQ.ZM_AUTH_RULE_LIMIT")]
            ZMAUTHRULELIMIT = 88,

            /// <summary>
            /// Enum ROYALTYACCOUNTNOTEXIST for value: ACQ.ROYALTY_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.ROYALTY_ACCOUNT_NOT_EXIST")]
            ROYALTYACCOUNTNOTEXIST = 89,

            /// <summary>
            /// Enum RISKMERCHANTIPNOTEXIST for value: ACQ.RISK_MERCHANT_IP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ACQ.RISK_MERCHANT_IP_NOT_EXIST")]
            RISKMERCHANTIPNOTEXIST = 90

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradePayErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayTradePayErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradePayErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayTradePayErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayTradePayErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayTradePayErrorResponseModel {\n");
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
            return this.Equals(input as AlipayTradePayErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradePayErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradePayErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradePayErrorResponseModel input)
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
