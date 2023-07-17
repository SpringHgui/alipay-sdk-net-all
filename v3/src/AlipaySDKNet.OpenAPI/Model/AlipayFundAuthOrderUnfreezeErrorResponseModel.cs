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
    /// AlipayFundAuthOrderUnfreezeErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOrderUnfreezeErrorResponseModel")]
    public partial class AlipayFundAuthOrderUnfreezeErrorResponseModel : IEquatable<AlipayFundAuthOrderUnfreezeErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALARGUMENT for value: ILLEGAL_ARGUMENT
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ARGUMENT")]
            ILLEGALARGUMENT = 1,

            /// <summary>
            /// Enum UNIQUEVIOLATION for value: UNIQUE_VIOLATION
            /// </summary>
            [EnumMember(Value = "UNIQUE_VIOLATION")]
            UNIQUEVIOLATION = 2,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 3,

            /// <summary>
            /// Enum PAYERUSERSTATUSLIMIT for value: PAYER_USER_STATUS_LIMIT
            /// </summary>
            [EnumMember(Value = "PAYER_USER_STATUS_LIMIT")]
            PAYERUSERSTATUSLIMIT = 4,

            /// <summary>
            /// Enum AUTHORDERNOTEXIST for value: AUTH_ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "AUTH_ORDER_NOT_EXIST")]
            AUTHORDERNOTEXIST = 5,

            /// <summary>
            /// Enum REQUESTAMOUNTEXCEED for value: REQUEST_AMOUNT_EXCEED
            /// </summary>
            [EnumMember(Value = "REQUEST_AMOUNT_EXCEED")]
            REQUESTAMOUNTEXCEED = 6,

            /// <summary>
            /// Enum ILLEGALSTATUS for value: ILLEGAL_STATUS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_STATUS")]
            ILLEGALSTATUS = 7,

            /// <summary>
            /// Enum ORDERALREADYFINISH for value: ORDER_ALREADY_FINISH
            /// </summary>
            [EnumMember(Value = "ORDER_ALREADY_FINISH")]
            ORDERALREADYFINISH = 8,

            /// <summary>
            /// Enum ORDERALREADYCLOSED for value: ORDER_ALREADY_CLOSED
            /// </summary>
            [EnumMember(Value = "ORDER_ALREADY_CLOSED")]
            ORDERALREADYCLOSED = 9,

            /// <summary>
            /// Enum PAYERNOTEXIST for value: PAYER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "PAYER_NOT_EXIST")]
            PAYERNOTEXIST = 10,

            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 11,

            /// <summary>
            /// Enum ACCESSFORBIDDEN for value: ACCESS_FORBIDDEN
            /// </summary>
            [EnumMember(Value = "ACCESS_FORBIDDEN")]
            ACCESSFORBIDDEN = 12

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOrderUnfreezeErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayFundAuthOrderUnfreezeErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOrderUnfreezeErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayFundAuthOrderUnfreezeErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayFundAuthOrderUnfreezeErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayFundAuthOrderUnfreezeErrorResponseModel {\n");
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
            return this.Equals(input as AlipayFundAuthOrderUnfreezeErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOrderUnfreezeErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOrderUnfreezeErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOrderUnfreezeErrorResponseModel input)
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
