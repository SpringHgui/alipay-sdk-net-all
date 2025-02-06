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
    /// AlipayUserCertifyOpenQueryErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserCertifyOpenQueryErrorResponseModel")]
    public partial class AlipayUserCertifyOpenQueryErrorResponseModel : IEquatable<AlipayUserCertifyOpenQueryErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum UNKNOWNERROR for value: UNKNOWN_ERROR
            /// </summary>
            [EnumMember(Value = "UNKNOWN_ERROR")]
            UNKNOWNERROR = 1,

            /// <summary>
            /// Enum ILLEGALARGUMENTFORMAT for value: ILLEGAL_ARGUMENT_FORMAT
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ARGUMENT_FORMAT")]
            ILLEGALARGUMENTFORMAT = 2,

            /// <summary>
            /// Enum CERTIFYIDEXPIRED for value: CERTIFY_ID_EXPIRED
            /// </summary>
            [EnumMember(Value = "CERTIFY_ID_EXPIRED")]
            CERTIFYIDEXPIRED = 3,

            /// <summary>
            /// Enum OPENCERTIFYBILLNOTEXIST for value: OPEN_CERTIFY_BILL_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "OPEN_CERTIFY_BILL_NOT_EXIST")]
            OPENCERTIFYBILLNOTEXIST = 4,

            /// <summary>
            /// Enum OPENCERTIFYBILLSTATUSERROR for value: OPEN_CERTIFY_BILL_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "OPEN_CERTIFY_BILL_STATUS_ERROR")]
            OPENCERTIFYBILLSTATUSERROR = 5,

            /// <summary>
            /// Enum UNABLEGETIMAGE for value: UNABLE_GET_IMAGE
            /// </summary>
            [EnumMember(Value = "UNABLE_GET_IMAGE")]
            UNABLEGETIMAGE = 6

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserCertifyOpenQueryErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayUserCertifyOpenQueryErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserCertifyOpenQueryErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayUserCertifyOpenQueryErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayUserCertifyOpenQueryErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayUserCertifyOpenQueryErrorResponseModel {\n");
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
            return this.Equals(input as AlipayUserCertifyOpenQueryErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserCertifyOpenQueryErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserCertifyOpenQueryErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserCertifyOpenQueryErrorResponseModel input)
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
