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
    /// AlipayOpenFeeAdjustApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenFeeAdjustApplyErrorResponseModel")]
    public partial class AlipayOpenFeeAdjustApplyErrorResponseModel : IEquatable<AlipayOpenFeeAdjustApplyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum SIZEOUTLIMIT for value: SIZE_OUT_LIMIT
            /// </summary>
            [EnumMember(Value = "SIZE_OUT_LIMIT")]
            SIZEOUTLIMIT = 2,

            /// <summary>
            /// Enum SIZEMINLIMIT for value: SIZE_MIN_LIMIT
            /// </summary>
            [EnumMember(Value = "SIZE_MIN_LIMIT")]
            SIZEMINLIMIT = 3,

            /// <summary>
            /// Enum FILEFORMATINVALID for value: FILE_FORMAT_INVALID
            /// </summary>
            [EnumMember(Value = "FILE_FORMAT_INVALID")]
            FILEFORMATINVALID = 4,

            /// <summary>
            /// Enum INVALIDPARAMS for value: INVALID_PARAMS
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMS")]
            INVALIDPARAMS = 5,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 6,

            /// <summary>
            /// Enum CERTTYPEILLEGAL for value: CERT_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "CERT_TYPE_ILLEGAL")]
            CERTTYPEILLEGAL = 7,

            /// <summary>
            /// Enum CERTPICNULL for value: CERT_PIC_NULL
            /// </summary>
            [EnumMember(Value = "CERT_PIC_NULL")]
            CERTPICNULL = 8,

            /// <summary>
            /// Enum ATTACHMENTISNULL for value: ATTACHMENT_IS_NULL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_IS_NULL")]
            ATTACHMENTISNULL = 9,

            /// <summary>
            /// Enum MERCHANTACCOUNTERROR for value: MERCHANT_ACCOUNT_ERROR
            /// </summary>
            [EnumMember(Value = "MERCHANT_ACCOUNT_ERROR")]
            MERCHANTACCOUNTERROR = 10,

            /// <summary>
            /// Enum PRODUCTNOTSUPPORT for value: PRODUCT_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "PRODUCT_NOT_SUPPORT")]
            PRODUCTNOTSUPPORT = 11,

            /// <summary>
            /// Enum DAYSLIMITERROR for value: DAYS_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "DAYS_LIMIT_ERROR")]
            DAYSLIMITERROR = 12,

            /// <summary>
            /// Enum MERCHANTREALTIONERROR for value: MERCHANT_REALTION_ERROR
            /// </summary>
            [EnumMember(Value = "MERCHANT_REALTION_ERROR")]
            MERCHANTREALTIONERROR = 13,

            /// <summary>
            /// Enum CHANGERATEERROR for value: CHANGE_RATE_ERROR
            /// </summary>
            [EnumMember(Value = "CHANGE_RATE_ERROR")]
            CHANGERATEERROR = 14,

            /// <summary>
            /// Enum RATELIMITERROR for value: RATE_LIMIT_ERROR
            /// </summary>
            [EnumMember(Value = "RATE_LIMIT_ERROR")]
            RATELIMITERROR = 15,

            /// <summary>
            /// Enum MERCHANTNOTSUPPORT for value: MERCHANT_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_SUPPORT")]
            MERCHANTNOTSUPPORT = 16,

            /// <summary>
            /// Enum PRODUCTUNVALID for value: PRODUCT_UN_VALID
            /// </summary>
            [EnumMember(Value = "PRODUCT_UN_VALID")]
            PRODUCTUNVALID = 17,

            /// <summary>
            /// Enum ARRANGEMENTINEFFECTIVEERROR for value: ARRANGEMENT_INEFFECTIVE_ERROR
            /// </summary>
            [EnumMember(Value = "ARRANGEMENT_INEFFECTIVE_ERROR")]
            ARRANGEMENTINEFFECTIVEERROR = 18,

            /// <summary>
            /// Enum APPLYISPROCESSING for value: APPLY_IS_PROCESSING
            /// </summary>
            [EnumMember(Value = "APPLY_IS_PROCESSING")]
            APPLYISPROCESSING = 19,

            /// <summary>
            /// Enum NKAMERCHANTNOTSUPPORT for value: NKA_MERCHANT_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "NKA_MERCHANT_NOT_SUPPORT")]
            NKAMERCHANTNOTSUPPORT = 20,

            /// <summary>
            /// Enum ONLYTRADERELATIONADJUSTABLE for value: ONLY_TRADE_RELATION_ADJUSTABLE
            /// </summary>
            [EnumMember(Value = "ONLY_TRADE_RELATION_ADJUSTABLE")]
            ONLYTRADERELATIONADJUSTABLE = 21

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenFeeAdjustApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenFeeAdjustApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenFeeAdjustApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenFeeAdjustApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenFeeAdjustApplyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenFeeAdjustApplyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenFeeAdjustApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenFeeAdjustApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenFeeAdjustApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenFeeAdjustApplyErrorResponseModel input)
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
