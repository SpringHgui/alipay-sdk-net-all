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
    /// AlipayOpenPublicMessageGroupSendErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMessageGroupSendErrorResponseModel")]
    public partial class AlipayOpenPublicMessageGroupSendErrorResponseModel : IEquatable<AlipayOpenPublicMessageGroupSendErrorResponseModel>, IValidatableObject
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
            /// Enum GROUPEMPTYERROR for value: GROUP_EMPTY_ERROR
            /// </summary>
            [EnumMember(Value = "GROUP_EMPTY_ERROR")]
            GROUPEMPTYERROR = 2,

            /// <summary>
            /// Enum ILLEGALBIZPARAMS for value: ILLEGAL_BIZ_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_BIZ_PARAMS")]
            ILLEGALBIZPARAMS = 3,

            /// <summary>
            /// Enum MSGBATCHSDOVER for value: MSG_BATCH_SD_OVER
            /// </summary>
            [EnumMember(Value = "MSG_BATCH_SD_OVER")]
            MSGBATCHSDOVER = 4,

            /// <summary>
            /// Enum MSGSENDILLEGAL for value: MSG_SEND_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MSG_SEND_ILLEGAL")]
            MSGSENDILLEGAL = 5,

            /// <summary>
            /// Enum IMAGESIZEERROR for value: IMAGE_SIZE_ERROR
            /// </summary>
            [EnumMember(Value = "IMAGE_SIZE_ERROR")]
            IMAGESIZEERROR = 6,

            /// <summary>
            /// Enum IMAGETOOLARGE for value: IMAGE_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "IMAGE_TOO_LARGE")]
            IMAGETOOLARGE = 7,

            /// <summary>
            /// Enum ILLEGALIMAGEFORMAT for value: ILLEGAL_IMAGE_FORMAT
            /// </summary>
            [EnumMember(Value = "ILLEGAL_IMAGE_FORMAT")]
            ILLEGALIMAGEFORMAT = 8,

            /// <summary>
            /// Enum MESSAGEISEMPTY for value: MESSAGE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "MESSAGE_IS_EMPTY")]
            MESSAGEISEMPTY = 9,

            /// <summary>
            /// Enum MESSAGEISINCOMPLETE for value: MESSAGE_IS_INCOMPLETE
            /// </summary>
            [EnumMember(Value = "MESSAGE_IS_INCOMPLETE")]
            MESSAGEISINCOMPLETE = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageGroupSendErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenPublicMessageGroupSendErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageGroupSendErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenPublicMessageGroupSendErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenPublicMessageGroupSendErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenPublicMessageGroupSendErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenPublicMessageGroupSendErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMessageGroupSendErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMessageGroupSendErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMessageGroupSendErrorResponseModel input)
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
