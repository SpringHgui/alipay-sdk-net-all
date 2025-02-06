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
    /// AlipayOpenAgentConfirmErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentConfirmErrorResponseModel")]
    public partial class AlipayOpenAgentConfirmErrorResponseModel : IEquatable<AlipayOpenAgentConfirmErrorResponseModel>, IValidatableObject
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
            /// Enum BATCHISNOTEXIST for value: BATCH_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BATCH_IS_NOT_EXIST")]
            BATCHISNOTEXIST = 5,

            /// <summary>
            /// Enum BATCHISEMPTY for value: BATCH_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BATCH_IS_EMPTY")]
            BATCHISEMPTY = 6,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHTICKET for value: PRE_AUTH_INVALID_AUTH_TICKET
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_TICKET")]
            PREAUTHINVALIDAUTHTICKET = 7,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHTOKEN for value: PRE_AUTH_INVALID_AUTH_TOKEN
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_TOKEN")]
            PREAUTHINVALIDAUTHTOKEN = 8,

            /// <summary>
            /// Enum PREAUTHINVOKEAPINOTPERMITTE for value: PRE_AUTH_INVOKE_API_NOT_PERMITTE
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVOKE_API_NOT_PERMITTE")]
            PREAUTHINVOKEAPINOTPERMITTE = 9,

            /// <summary>
            /// Enum PREAUTHINVALIDAUTHAPPID for value: PRE_AUTH_INVALID_AUTH_APP_ID
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_INVALID_AUTH_APP_ID")]
            PREAUTHINVALIDAUTHAPPID = 10,

            /// <summary>
            /// Enum PREAUTHTICKETEXCHANGEFAILED for value: PRE_AUTH_TICKET_EXCHANGE_FAILED
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_TICKET_EXCHANGE_FAILED")]
            PREAUTHTICKETEXCHANGEFAILED = 11,

            /// <summary>
            /// Enum PREAUTHTICKETCREATEAPPONCE for value: PRE_AUTH_TICKET_CREATE_APP_ONCE
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_TICKET_CREATE_APP_ONCE")]
            PREAUTHTICKETCREATEAPPONCE = 12,

            /// <summary>
            /// Enum PREAUTHTICKETNEEDCREATEAPP for value: PRE_AUTH_TICKET_NEED_CREATE_APP
            /// </summary>
            [EnumMember(Value = "PRE_AUTH_TICKET_NEED_CREATE_APP")]
            PREAUTHTICKETNEEDCREATEAPP = 13,

            /// <summary>
            /// Enum BUSINESSLICENSENOEMPTY for value: BUSINESS_LICENSE_NO_EMPTY
            /// </summary>
            [EnumMember(Value = "BUSINESS_LICENSE_NO_EMPTY")]
            BUSINESSLICENSENOEMPTY = 14,

            /// <summary>
            /// Enum FEERATENOTINTERAVL for value: FEERATE_NOT_INTERAVL
            /// </summary>
            [EnumMember(Value = "FEERATE_NOT_INTERAVL")]
            FEERATENOTINTERAVL = 15,

            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 16,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 17,

            /// <summary>
            /// Enum NEWLINKCANNOTBATCHSIGN for value: NEW_LINK_CANNOT_BATCH_SIGN
            /// </summary>
            [EnumMember(Value = "NEW_LINK_CANNOT_BATCH_SIGN")]
            NEWLINKCANNOTBATCHSIGN = 18,

            /// <summary>
            /// Enum PRODUCTCANNOTMIXSIGN for value: PRODUCT_CANNOT_MIX_SIGN
            /// </summary>
            [EnumMember(Value = "PRODUCT_CANNOT_MIX_SIGN")]
            PRODUCTCANNOTMIXSIGN = 19,

            /// <summary>
            /// Enum PRODUCTOPENFAIL for value: PRODUCT_OPEN_FAIL
            /// </summary>
            [EnumMember(Value = "PRODUCT_OPEN_FAIL")]
            PRODUCTOPENFAIL = 20,

            /// <summary>
            /// Enum OPENAPISIGNISVNOTINWHITELIST for value: OPEN_API_SIGN_ISV_NOT_IN_WHITELIST
            /// </summary>
            [EnumMember(Value = "OPEN_API_SIGN_ISV_NOT_IN_WHITELIST")]
            OPENAPISIGNISVNOTINWHITELIST = 21,

            /// <summary>
            /// Enum ANTPRODUCTCONFLICT for value: ANT_PRODUCT_CONFLICT
            /// </summary>
            [EnumMember(Value = "ANT_PRODUCT_CONFLICT")]
            ANTPRODUCTCONFLICT = 22,

            /// <summary>
            /// Enum ISVAPPNOORDERPACKAGE for value: ISV_APP_NO_ORDER_PACKAGE
            /// </summary>
            [EnumMember(Value = "ISV_APP_NO_ORDER_PACKAGE")]
            ISVAPPNOORDERPACKAGE = 23

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentConfirmErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenAgentConfirmErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentConfirmErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenAgentConfirmErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenAgentConfirmErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenAgentConfirmErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenAgentConfirmErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentConfirmErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentConfirmErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentConfirmErrorResponseModel input)
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
