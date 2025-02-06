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
    /// AlipayFundAccountQueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAccountQueryErrorResponseModel")]
    public partial class AlipayFundAccountQueryErrorResponseModel : IEquatable<AlipayFundAccountQueryErrorResponseModel>, IValidatableObject
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
            /// Enum NOPERMISSIONACCOUNT for value: NO_PERMISSION_ACCOUNT
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION_ACCOUNT")]
            NOPERMISSIONACCOUNT = 3,

            /// <summary>
            /// Enum TRUSTEESHIPACCOUNTNOTEXIST for value: TRUSTEESHIP_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "TRUSTEESHIP_ACCOUNT_NOT_EXIST")]
            TRUSTEESHIPACCOUNTNOTEXIST = 4,

            /// <summary>
            /// Enum USERAGREEMENTVERIFYFAIL for value: USER_AGREEMENT_VERIFY_FAIL
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_VERIFY_FAIL")]
            USERAGREEMENTVERIFYFAIL = 5,

            /// <summary>
            /// Enum AUTHUSERIDISNOTMATCH for value: AUTH_USERID_IS_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "AUTH_USERID_IS_NOT_MATCH")]
            AUTHUSERIDISNOTMATCH = 6,

            /// <summary>
            /// Enum AUTHOREEISNOTMATCH for value: AUTHOREE_IS_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "AUTHOREE_IS_NOT_MATCH")]
            AUTHOREEISNOTMATCH = 7,

            /// <summary>
            /// Enum USERAGREEMENTSTATUSABNORMAL for value: USER_AGREEMENT_STATUS_ABNORMAL
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_STATUS_ABNORMAL")]
            USERAGREEMENTSTATUSABNORMAL = 8,

            /// <summary>
            /// Enum USERAGREEMENTISOUTOFDATE for value: USER_AGREEMENT_IS_OUT_OF_DATE
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_IS_OUT_OF_DATE")]
            USERAGREEMENTISOUTOFDATE = 9,

            /// <summary>
            /// Enum MERCHANTAGREEMENTVERIFYFAIL for value: MERCHANT_AGREEMENT_VERIFY_FAIL
            /// </summary>
            [EnumMember(Value = "MERCHANT_AGREEMENT_VERIFY_FAIL")]
            MERCHANTAGREEMENTVERIFYFAIL = 10,

            /// <summary>
            /// Enum AUTHINFONOTEXISTS for value: AUTH_INFO_NOT_EXISTS
            /// </summary>
            [EnumMember(Value = "AUTH_INFO_NOT_EXISTS")]
            AUTHINFONOTEXISTS = 11,

            /// <summary>
            /// Enum ALIPAYACCOUNTNOTEXIST for value: ALIPAY_ACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ALIPAY_ACCOUNT_NOT_EXIST")]
            ALIPAYACCOUNTNOTEXIST = 12,

            /// <summary>
            /// Enum AUTHCODEERROR for value: AUTH_CODE_ERROR
            /// </summary>
            [EnumMember(Value = "AUTH_CODE_ERROR")]
            AUTHCODEERROR = 13,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 14

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAccountQueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayFundAccountQueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAccountQueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayFundAccountQueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayFundAccountQueryErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayFundAccountQueryErrorResponseModel {\n");
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
            return this.Equals(input as AlipayFundAccountQueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAccountQueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAccountQueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAccountQueryErrorResponseModel input)
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
