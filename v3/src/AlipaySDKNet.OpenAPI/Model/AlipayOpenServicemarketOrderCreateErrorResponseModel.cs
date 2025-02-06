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
    /// AlipayOpenServicemarketOrderCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketOrderCreateErrorResponseModel")]
    public partial class AlipayOpenServicemarketOrderCreateErrorResponseModel : IEquatable<AlipayOpenServicemarketOrderCreateErrorResponseModel>, IValidatableObject
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
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 2,

            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 3,

            /// <summary>
            /// Enum AGENTAUTHFAIL for value: AGENT_AUTH_FAIL
            /// </summary>
            [EnumMember(Value = "AGENT_AUTH_FAIL")]
            AGENTAUTHFAIL = 4,

            /// <summary>
            /// Enum NOTSUPPORTORDERBYOPENAPI for value: NOT_SUPPORT_ORDER_BY_OPENAPI
            /// </summary>
            [EnumMember(Value = "NOT_SUPPORT_ORDER_BY_OPENAPI")]
            NOTSUPPORTORDERBYOPENAPI = 5,

            /// <summary>
            /// Enum USERINVALIDSTATUS for value: USER_INVALID_STATUS
            /// </summary>
            [EnumMember(Value = "USER_INVALID_STATUS")]
            USERINVALIDSTATUS = 6,

            /// <summary>
            /// Enum USERNOTEXIST for value: USER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "USER_NOT_EXIST")]
            USERNOTEXIST = 7,

            /// <summary>
            /// Enum SIGNAGREEMENTFAILED for value: SIGN_AGREEMENT_FAILED
            /// </summary>
            [EnumMember(Value = "SIGN_AGREEMENT_FAILED")]
            SIGNAGREEMENTFAILED = 8,

            /// <summary>
            /// Enum MINIAPPNAMEDUPLICATE for value: MINI_APP_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_DUPLICATE")]
            MINIAPPNAMEDUPLICATE = 9,

            /// <summary>
            /// Enum ENGLISHNAMEISBLANK for value: ENGLISH_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "ENGLISH_NAME_IS_BLANK")]
            ENGLISHNAMEISBLANK = 10,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAME for value: INVALID_MINI_APP_EN_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME")]
            INVALIDMINIAPPENNAME = 11,

            /// <summary>
            /// Enum MINIAPPNAMESENSITIVE for value: MINI_APP_NAME_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_SENSITIVE")]
            MINIAPPNAMESENSITIVE = 12,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAMELENGTH for value: INVALID_MINI_APP_EN_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME_LENGTH")]
            INVALIDMINIAPPENNAMELENGTH = 13,

            /// <summary>
            /// Enum APPNAMEISBLANK for value: APP_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_NAME_IS_BLANK")]
            APPNAMEISBLANK = 14,

            /// <summary>
            /// Enum INVALIDMINIAPPNAME for value: INVALID_MINI_APP_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME")]
            INVALIDMINIAPPNAME = 15,

            /// <summary>
            /// Enum INVALIDMINIAPPNAMELENGTH for value: INVALID_MINI_APP_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME_LENGTH")]
            INVALIDMINIAPPNAMELENGTH = 16,

            /// <summary>
            /// Enum CREATEMINIAPPEXCEEDMAXCOUNT for value: CREATE_MINI_APP_EXCEED_MAX_COUNT
            /// </summary>
            [EnumMember(Value = "CREATE_MINI_APP_EXCEED_MAX_COUNT")]
            CREATEMINIAPPEXCEEDMAXCOUNT = 17,

            /// <summary>
            /// Enum INVALIDCATEGORY for value: INVALID_CATEGORY
            /// </summary>
            [EnumMember(Value = "INVALID_CATEGORY")]
            INVALIDCATEGORY = 18,

            /// <summary>
            /// Enum RISKDECISIONCHECKFAIL for value: RISK_DECISION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_CHECK_FAIL")]
            RISKDECISIONCHECKFAIL = 19,

            /// <summary>
            /// Enum BLACKLISTCHECKFAIL for value: BLACK_LIST_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "BLACK_LIST_CHECK_FAIL")]
            BLACKLISTCHECKFAIL = 20,

            /// <summary>
            /// Enum MINIAPPENNAMESENSITIVE for value: MINI_APP_EN_NAME_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_SENSITIVE")]
            MINIAPPENNAMESENSITIVE = 21,

            /// <summary>
            /// Enum MINIAPPSLOGANSENSITIVE for value: MINI_APP_SLOGAN_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_SLOGAN_SENSITIVE")]
            MINIAPPSLOGANSENSITIVE = 22,

            /// <summary>
            /// Enum MINIAPPDESCSENSITIVE for value: MINI_APP_DESC_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_DESC_SENSITIVE")]
            MINIAPPDESCSENSITIVE = 23,

            /// <summary>
            /// Enum MINIAPPSERVICEMAILSENSITIVE for value: MINI_APP_SERVICE_MAIL_SENSITIVE
            /// </summary>
            [EnumMember(Value = "MINI_APP_SERVICE_MAIL_SENSITIVE")]
            MINIAPPSERVICEMAILSENSITIVE = 24,

            /// <summary>
            /// Enum CREATEMINIAPPPIDPUNISH for value: CREATE_MINI_APP_PID_PUNISH
            /// </summary>
            [EnumMember(Value = "CREATE_MINI_APP_PID_PUNISH")]
            CREATEMINIAPPPIDPUNISH = 25,

            /// <summary>
            /// Enum MINIAPPENNAMEDUPLICATE for value: MINI_APP_EN_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_DUPLICATE")]
            MINIAPPENNAMEDUPLICATE = 26,

            /// <summary>
            /// Enum APPIDEXIST for value: APP_ID_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ID_EXIST")]
            APPIDEXIST = 27,

            /// <summary>
            /// Enum APPIDILLEGAL for value: APP_ID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "APP_ID_ILLEGAL")]
            APPIDILLEGAL = 28,

            /// <summary>
            /// Enum INVALIDMINIAPPDESCLENGTH for value: INVALID_MINI_APP_DESC_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_DESC_LENGTH")]
            INVALIDMINIAPPDESCLENGTH = 29,

            /// <summary>
            /// Enum RISKDECISIONHITBRAND for value: RISK_DECISION_HIT_BRAND
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_HIT_BRAND")]
            RISKDECISIONHITBRAND = 30,

            /// <summary>
            /// Enum INVALIDMINIAPPSLOGANLENGTH for value: INVALID_MINI_APP_SLOGAN_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SLOGAN_LENGTH")]
            INVALIDMINIAPPSLOGANLENGTH = 31

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketOrderCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenServicemarketOrderCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketOrderCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenServicemarketOrderCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenServicemarketOrderCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenServicemarketOrderCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenServicemarketOrderCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketOrderCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketOrderCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketOrderCreateErrorResponseModel input)
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
