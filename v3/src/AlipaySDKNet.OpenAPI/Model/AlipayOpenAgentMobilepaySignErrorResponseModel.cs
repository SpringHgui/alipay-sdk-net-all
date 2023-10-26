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
    /// AlipayOpenAgentMobilepaySignErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentMobilepaySignErrorResponseModel")]
    public partial class AlipayOpenAgentMobilepaySignErrorResponseModel : IEquatable<AlipayOpenAgentMobilepaySignErrorResponseModel>, IValidatableObject
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
            /// Enum BATCHSTATUSISFINAL for value: BATCH_STATUS_IS_FINAL
            /// </summary>
            [EnumMember(Value = "BATCH_STATUS_IS_FINAL")]
            BATCHSTATUSISFINAL = 3,

            /// <summary>
            /// Enum BATCHISNOTEXIST for value: BATCH_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BATCH_IS_NOT_EXIST")]
            BATCHISNOTEXIST = 4,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 5,

            /// <summary>
            /// Enum ISVAPPORDERPACKAGEEMPTY for value: ISV_APP_ORDER_PACKAGE_EMPTY
            /// </summary>
            [EnumMember(Value = "ISV_APP_ORDER_PACKAGE_EMPTY")]
            ISVAPPORDERPACKAGEEMPTY = 6,

            /// <summary>
            /// Enum ISVAPPNOORDERPACKAGE for value: ISV_APP_NO_ORDER_PACKAGE
            /// </summary>
            [EnumMember(Value = "ISV_APP_NO_ORDER_PACKAGE")]
            ISVAPPNOORDERPACKAGE = 7,

            /// <summary>
            /// Enum MERCHANTSIGNPRODUCTINAUDIT for value: MERCHANT_SIGN_PRODUCT_IN_AUDIT
            /// </summary>
            [EnumMember(Value = "MERCHANT_SIGN_PRODUCT_IN_AUDIT")]
            MERCHANTSIGNPRODUCTINAUDIT = 8,

            /// <summary>
            /// Enum MERCHANTSIGNPRODUCTINFORBIDD for value: MERCHANT_SIGN_PRODUCT_IN_FORBIDD
            /// </summary>
            [EnumMember(Value = "MERCHANT_SIGN_PRODUCT_IN_FORBIDD")]
            MERCHANTSIGNPRODUCTINFORBIDD = 9,

            /// <summary>
            /// Enum NOAPPPERMISSION for value: NO_APP_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_APP_PERMISSION")]
            NOAPPPERMISSION = 10,

            /// <summary>
            /// Enum FILESIZEOUTLIMIT for value: FILE_SIZE_OUT_LIMIT
            /// </summary>
            [EnumMember(Value = "FILE_SIZE_OUT_LIMIT")]
            FILESIZEOUTLIMIT = 11,

            /// <summary>
            /// Enum FILESIZEMINLIMIT for value: FILE_SIZE_MIN_LIMIT
            /// </summary>
            [EnumMember(Value = "FILE_SIZE_MIN_LIMIT")]
            FILESIZEMINLIMIT = 12,

            /// <summary>
            /// Enum FILEFORMATISINVALID for value: FILE_FORMAT_IS_INVALID
            /// </summary>
            [EnumMember(Value = "FILE_FORMAT_IS_INVALID")]
            FILEFORMATISINVALID = 13,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHTICKET for value: PRE_AUTH_INVALID_AUTH_TICKET
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_TICKET")]
            PREAUTHINVALIDAUTHTICKET = 14,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHTOKEN for value: PRE_AUTH_INVALID_AUTH_TOKEN
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_TOKEN")]
            PREAUTHINVALIDAUTHTOKEN = 15,

            /// <summary>
            /// Enum PREAUTHINVOKEAPINOTPERMITTE for value: PRE_AUTH_INVOKE_API_NOT_PERMITTE
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVOKE_API_NOT_PERMITTE")]
            PREAUTHINVOKEAPINOTPERMITTE = 16,

            /// <summary>
            /// Enum PREAUTHINVALIDPACKAGE for value: PRE_AUTH_INVALID_PACKAGE
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_PACKAGE")]
            PREAUTHINVALIDPACKAGE = 17,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHAPPID for value: PRE_AUTH_INVALID_AUTH_APP_ID
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_APP_ID")]
            PREAUTHINVALIDAUTHAPPID = 18,

            /// <summary>
            /// Enum MERCHANTNEEDFACECERTIFY for value: MERCHANT_NEED_FACE_CERTIFY
            /// </summary>
            [EnumMember(Value = "MERCHANT_NEED_FACE_CERTIFY")]
            MERCHANTNEEDFACECERTIFY = 19,

            /// <summary>
            /// Enum MERCHANTSTATENOTSATISFY for value: MERCHANT_STATE_NOT_SATISFY
            /// </summary>
            [EnumMember(Value = "MERCHANT_STATE_NOT_SATISFY")]
            MERCHANTSTATENOTSATISFY = 20,

            /// <summary>
            /// Enum UNSUPPORTACCOUNTCERTIFYLEVEL for value: UN_SUPPORT_ACCOUNT_CERTIFY_LEVEL
            /// </summary>
            [EnumMember(Value = "UN_SUPPORT_ACCOUNT_CERTIFY_LEVEL")]
            UNSUPPORTACCOUNTCERTIFYLEVEL = 21,

            /// <summary>
            /// Enum UNSUPPORTACCOUNTTYPE for value: UN_SUPPORT_ACCOUNT_TYPE
            /// </summary>
            [EnumMember(Value = "UN_SUPPORT_ACCOUNT_TYPE")]
            UNSUPPORTACCOUNTTYPE = 22,

            /// <summary>
            /// Enum ANTPRODUCTCONFLICT for value: ANT_PRODUCT_CONFLICT
            /// </summary>
            [EnumMember(Value = "ANT_PRODUCT_CONFLICT")]
            ANTPRODUCTCONFLICT = 23,

            /// <summary>
            /// Enum USERCARDBALANCEPAYCLOSED for value: USER_CARD_BALANCE_PAY_CLOSED
            /// </summary>
            [EnumMember(Value = "USER_CARD_BALANCE_PAY_CLOSED")]
            USERCARDBALANCEPAYCLOSED = 24,

            /// <summary>
            /// Enum CHECKAGDSSELLERACCESSFAILED for value: CHECK_AGDS_SELLER_ACCESS_FAILED
            /// </summary>
            [EnumMember(Value = "CHECK_AGDS_SELLER_ACCESS_FAILED")]
            CHECKAGDSSELLERACCESSFAILED = 25,

            /// <summary>
            /// Enum ANTPRODUCTDEPENDENCYREQUIRED for value: ANT_PRODUCT_DEPENDENCY_REQUIRED
            /// </summary>
            [EnumMember(Value = "ANT_PRODUCT_DEPENDENCY_REQUIRED")]
            ANTPRODUCTDEPENDENCYREQUIRED = 26,

            /// <summary>
            /// Enum ISVIDENTITYNOTSATISFY for value: ISV_IDENTITY_NOT_SATISFY
            /// </summary>
            [EnumMember(Value = "ISV_IDENTITY_NOT_SATISFY")]
            ISVIDENTITYNOTSATISFY = 27,

            /// <summary>
            /// Enum NOTMATCHEDSSUORPS for value: NOT_MATCHED_SSU_OR_PS
            /// </summary>
            [EnumMember(Value = "NOT_MATCHED_SSU_OR_PS")]
            NOTMATCHEDSSUORPS = 28,

            /// <summary>
            /// Enum ADMITORDERNOPASS for value: ADMIT_ORDER_NO_PASS
            /// </summary>
            [EnumMember(Value = "ADMIT_ORDER_NO_PASS")]
            ADMITORDERNOPASS = 29

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentMobilepaySignErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenAgentMobilepaySignErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentMobilepaySignErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenAgentMobilepaySignErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenAgentMobilepaySignErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenAgentMobilepaySignErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenAgentMobilepaySignErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentMobilepaySignErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentMobilepaySignErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentMobilepaySignErrorResponseModel input)
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
