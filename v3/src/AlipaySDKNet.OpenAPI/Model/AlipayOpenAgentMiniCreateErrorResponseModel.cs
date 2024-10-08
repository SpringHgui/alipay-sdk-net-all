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
    /// AlipayOpenAgentMiniCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentMiniCreateErrorResponseModel")]
    public partial class AlipayOpenAgentMiniCreateErrorResponseModel : IEquatable<AlipayOpenAgentMiniCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 1,

            /// <summary>
            /// Enum INVALIDBATCHNO for value: INVALID_BATCH_NO
            /// </summary>
            [EnumMember(Value = "INVALID_BATCH_NO")]
            INVALIDBATCHNO = 2,

            /// <summary>
            /// Enum NOAPPPERMISSION for value: NO_APP_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_APP_PERMISSION")]
            NOAPPPERMISSION = 3,

            /// <summary>
            /// Enum BATCHSTATUSISFINAL for value: BATCH_STATUS_IS_FINAL
            /// </summary>
            [EnumMember(Value = "BATCH_STATUS_IS_FINAL")]
            BATCHSTATUSISFINAL = 4,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 5,

            /// <summary>
            /// Enum ISVAPPNOTINYAPPSCENE for value: ISV_APP_NO_TINYAPP_SCENE
            /// </summary>
            [EnumMember(Value = "ISV_APP_NO_TINYAPP_SCENE")]
            ISVAPPNOTINYAPPSCENE = 6,

            /// <summary>
            /// Enum BATCHISNOTEXIST for value: BATCH_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BATCH_IS_NOT_EXIST")]
            BATCHISNOTEXIST = 7,

            /// <summary>
            /// Enum MERCHANTNOTENTERPRISE for value: MERCHANT_NOT_ENTERPRISE
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_ENTERPRISE")]
            MERCHANTNOTENTERPRISE = 8,

            /// <summary>
            /// Enum APPNAMEISBLANK for value: APP_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_NAME_IS_BLANK")]
            APPNAMEISBLANK = 9,

            /// <summary>
            /// Enum INVALIDMINIAPPNAME for value: INVALID_MINI_APP_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME")]
            INVALIDMINIAPPNAME = 10,

            /// <summary>
            /// Enum INVALIDMINIAPPNAMELENGTH for value: INVALID_MINI_APP_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME_LENGTH")]
            INVALIDMINIAPPNAMELENGTH = 11,

            /// <summary>
            /// Enum MINIAPPNAMEDUPLICATE for value: MINI_APP_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_DUPLICATE")]
            MINIAPPNAMEDUPLICATE = 12,

            /// <summary>
            /// Enum MINIAPPNAMESENSITIVE for value: MINI_APP_NAME_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_SENSITIVE")]
            MINIAPPNAMESENSITIVE = 13,

            /// <summary>
            /// Enum ENGLISHNAMEISBLANK for value: ENGLISH_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "ENGLISH_NAME_IS_BLANK")]
            ENGLISHNAMEISBLANK = 14,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAME for value: INVALID_MINI_APP_EN_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME")]
            INVALIDMINIAPPENNAME = 15,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAMELENGTH for value: INVALID_MINI_APP_EN_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME_LENGTH")]
            INVALIDMINIAPPENNAMELENGTH = 16,

            /// <summary>
            /// Enum MINIAPPENNAMEDUPLICATE for value: MINI_APP_EN_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_DUPLICATE")]
            MINIAPPENNAMEDUPLICATE = 17,

            /// <summary>
            /// Enum MINIAPPENNAMESENSITIVE for value: MINI_APP_EN_NAME_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_SENSITIVE")]
            MINIAPPENNAMESENSITIVE = 18,

            /// <summary>
            /// Enum LOGOISBLANK for value: LOGO_IS_BLANK
            /// </summary>
            [EnumMember(Value = "LOGO_IS_BLANK")]
            LOGOISBLANK = 19,

            /// <summary>
            /// Enum SLOGANISBLANK for value: SLOGAN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SLOGAN_IS_BLANK")]
            SLOGANISBLANK = 20,

            /// <summary>
            /// Enum INVALIDMINIAPPSLOGANLENGTH for value: INVALID_MINI_APP_SLOGAN_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SLOGAN_LENGTH")]
            INVALIDMINIAPPSLOGANLENGTH = 21,

            /// <summary>
            /// Enum INVALIDMINIAPPSLOGAN for value: INVALID_MINI_APP_SLOGAN
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SLOGAN")]
            INVALIDMINIAPPSLOGAN = 22,

            /// <summary>
            /// Enum MINIAPPSLOGANSENSITIVE for value: MINI_APP_SLOGAN_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_SLOGAN_SENSITIVE")]
            MINIAPPSLOGANSENSITIVE = 23,

            /// <summary>
            /// Enum SERVICETELANDMAILBOTHBLANK for value: SERVICE_TEL_AND_MAIL_BOTH_BLANK
            /// </summary>
            [EnumMember(Value = "SERVICE_TEL_AND_MAIL_BOTH_BLANK")]
            SERVICETELANDMAILBOTHBLANK = 24,

            /// <summary>
            /// Enum INVALIDMINIAPPSERVICETEL for value: INVALID_MINI_APP_SERVICE_TEL
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SERVICE_TEL")]
            INVALIDMINIAPPSERVICETEL = 25,

            /// <summary>
            /// Enum INVALIDMINIAPPSERVICEMAIL for value: INVALID_MINI_APP_SERVICE_MAIL
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SERVICE_MAIL")]
            INVALIDMINIAPPSERVICEMAIL = 26,

            /// <summary>
            /// Enum MINIAPPSERVICEMAILSENSITIVE for value: MINI_APP_SERVICE_MAIL_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_SERVICE_MAIL_SENSITIVE")]
            MINIAPPSERVICEMAILSENSITIVE = 27,

            /// <summary>
            /// Enum CATEGORYISBLANK for value: CATEGORY_IS_BLANK
            /// </summary>
            [EnumMember(Value = "CATEGORY_IS_BLANK")]
            CATEGORYISBLANK = 28,

            /// <summary>
            /// Enum CATEGOTYNUMISINVALID for value: CATEGOTY_NUM_IS_INVALID
            /// </summary>
            [EnumMember(Value = "CATEGOTY_NUM_IS_INVALID")]
            CATEGOTYNUMISINVALID = 29,

            /// <summary>
            /// Enum INVALIDCATEGORY for value: INVALID_CATEGORY
            /// </summary>
            [EnumMember(Value = "INVALID_CATEGORY")]
            INVALIDCATEGORY = 30,

            /// <summary>
            /// Enum APPDESCISBLANK for value: APP_DESC_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_DESC_IS_BLANK")]
            APPDESCISBLANK = 31,

            /// <summary>
            /// Enum INVALIDMINIAPPDESCLENGTH for value: INVALID_MINI_APP_DESC_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_DESC_LENGTH")]
            INVALIDMINIAPPDESCLENGTH = 32,

            /// <summary>
            /// Enum INVALIDMINIAPPDESC for value: INVALID_MINI_APP_DESC
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_DESC")]
            INVALIDMINIAPPDESC = 33,

            /// <summary>
            /// Enum PIDISBLANK for value: PID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "PID_IS_BLANK")]
            PIDISBLANK = 34,

            /// <summary>
            /// Enum CREATEMINIAPPEXCEEDMAXCOUNT for value: CREATE_MINI_APP_EXCEED_MAX_COUNT
            /// </summary>
            [EnumMember(Value = "CREATE_MINI_APP_EXCEED_MAX_COUNT")]
            CREATEMINIAPPEXCEEDMAXCOUNT = 35,

            /// <summary>
            /// Enum CREATEMINIAPPPIDPUNISH for value: CREATE_MINI_APP_PID_PUNISH
            /// </summary>
            [EnumMember(Value = "CREATE_MINI_APP_PID_PUNISH")]
            CREATEMINIAPPPIDPUNISH = 36,

            /// <summary>
            /// Enum FILEFORMATISINVALID for value: FILE_FORMAT_IS_INVALID
            /// </summary>
            [EnumMember(Value = "FILE_FORMAT_IS_INVALID")]
            FILEFORMATISINVALID = 37,

            /// <summary>
            /// Enum FILESIZEOUTLIMIT for value: FILE_SIZE_OUT_LIMIT
            /// </summary>
            [EnumMember(Value = "FILE_SIZE_OUT_LIMIT")]
            FILESIZEOUTLIMIT = 38,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHTICKET for value: PRE_AUTH_INVALID_AUTH_TICKET
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_TICKET")]
            PREAUTHINVALIDAUTHTICKET = 39,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHTOKEN for value: PRE_AUTH_INVALID_AUTH_TOKEN
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_TOKEN")]
            PREAUTHINVALIDAUTHTOKEN = 40,

            /// <summary>
            /// Enum PREAUTHINVOKEAPINOTPERMITTE for value: PRE_AUTH_INVOKE_API_NOT_PERMITTE
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVOKE_API_NOT_PERMITTE")]
            PREAUTHINVOKEAPINOTPERMITTE = 41,

            /// <summary>
            /// Enum PREAUTHINVALIDCREATEAPPLICAT for value: PRE_AUTH_INVALID_CREATE_APPLICAT
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_CREATE_APPLICAT")]
            PREAUTHINVALIDCREATEAPPLICAT = 42,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHAPPID for value: PRE_AUTH_INVALID_AUTH_APP_ID
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_APP_ID")]
            PREAUTHINVALIDAUTHAPPID = 43,

            /// <summary>
            /// Enum PREAUTHTICKETCREATEAPPONCE for value: PRE_AUTH_TICKET_CREATE_APP_ONCE
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_TICKET_CREATE_APP_ONCE")]
            PREAUTHTICKETCREATEAPPONCE = 44,

            /// <summary>
            /// Enum BLACKLISTCHECKFAIL for value: BLACK_LIST_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "BLACK_LIST_CHECK_FAIL")]
            BLACKLISTCHECKFAIL = 45,

            /// <summary>
            /// Enum RISKDECISIONCHECKFAIL for value: RISK_DECISION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_CHECK_FAIL")]
            RISKDECISIONCHECKFAIL = 46,

            /// <summary>
            /// Enum RISKDECISIONHITBRAND for value: RISK_DECISION_HIT_BRAND
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_HIT_BRAND")]
            RISKDECISIONHITBRAND = 47,

            /// <summary>
            /// Enum INVALIDCONTACTMOBILE for value: INVALID_CONTACT_MOBILE
            /// </summary>
            [EnumMember(Value = "INVALID_CONTACT_MOBILE")]
            INVALIDCONTACTMOBILE = 48,

            /// <summary>
            /// Enum INVALIDCONTACTNAME for value: INVALID_CONTACT_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_CONTACT_NAME")]
            INVALIDCONTACTNAME = 49,

            /// <summary>
            /// Enum INVALIDCONTACTEMAIL for value: INVALID_CONTACT_EMAIL
            /// </summary>
            [EnumMember(Value = "INVALID_CONTACT_EMAIL")]
            INVALIDCONTACTEMAIL = 50,

            /// <summary>
            /// Enum MERCHANTISNOTEXIST for value: MERCHANT_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_IS_NOT_EXIST")]
            MERCHANTISNOTEXIST = 51,

            /// <summary>
            /// Enum MERCHANTNOTACTIVED for value: MERCHANT_NOT_ACTIVED
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_ACTIVED")]
            MERCHANTNOTACTIVED = 52,

            /// <summary>
            /// Enum MERCHANTCANNOTLOGON for value: MERCHANT_CAN_NOT_LOGON
            /// </summary>
            [EnumMember(Value = "MERCHANT_CAN_NOT_LOGON")]
            MERCHANTCANNOTLOGON = 53,

            /// <summary>
            /// Enum MERCHANTNOTENABLED for value: MERCHANT_NOT_ENABLED
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_ENABLED")]
            MERCHANTNOTENABLED = 54,

            /// <summary>
            /// Enum MERCHANTNOTCERTIFIED for value: MERCHANT_NOT_CERTIFIED
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_CERTIFIED")]
            MERCHANTNOTCERTIFIED = 55

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentMiniCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenAgentMiniCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentMiniCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenAgentMiniCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenAgentMiniCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenAgentMiniCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenAgentMiniCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentMiniCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentMiniCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentMiniCreateErrorResponseModel input)
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
