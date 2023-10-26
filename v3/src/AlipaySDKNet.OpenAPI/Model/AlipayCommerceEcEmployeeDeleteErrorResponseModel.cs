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
    /// AlipayCommerceEcEmployeeDeleteErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEmployeeDeleteErrorResponseModel")]
    public partial class AlipayCommerceEcEmployeeDeleteErrorResponseModel : IEquatable<AlipayCommerceEcEmployeeDeleteErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum PARAMETERERROR for value: PARAMETER_ERROR
            /// </summary>
            [EnumMember(Value = "PARAMETER_ERROR")]
            PARAMETERERROR = 1,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 2,

            /// <summary>
            /// Enum NOAGREEMENT for value: NO_AGREEMENT
            /// </summary>
            [EnumMember(Value = "NO_AGREEMENT")]
            NOAGREEMENT = 3,

            /// <summary>
            /// Enum ENTERPRISENOTEXIST for value: ENTERPRISE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ENTERPRISE_NOT_EXIST")]
            ENTERPRISENOTEXIST = 4,

            /// <summary>
            /// Enum EMPLOYEENOTEXIST for value: EMPLOYEE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "EMPLOYEE_NOT_EXIST")]
            EMPLOYEENOTEXIST = 5,

            /// <summary>
            /// Enum MSGSENDERROR for value: MSG_SEND_ERROR
            /// </summary>
            [EnumMember(Value = "MSG_SEND_ERROR")]
            MSGSENDERROR = 6,

            /// <summary>
            /// Enum REMOTESERVICEERROR for value: REMOTE_SERVICE_ERROR
            /// </summary>
            [EnumMember(Value = "REMOTE_SERVICE_ERROR")]
            REMOTESERVICEERROR = 7,

            /// <summary>
            /// Enum IOTUSERDELETEERROR for value: IOT_USER_DELETE_ERROR
            /// </summary>
            [EnumMember(Value = "IOT_USER_DELETE_ERROR")]
            IOTUSERDELETEERROR = 8,

            /// <summary>
            /// Enum ENTERPRISENOTSIGNED for value: ENTERPRISE_NOT_SIGNED
            /// </summary>
            [EnumMember(Value = "ENTERPRISE_NOT_SIGNED")]
            ENTERPRISENOTSIGNED = 9,

            /// <summary>
            /// Enum PARAMERROR for value: PARAM_ERROR
            /// </summary>
            [EnumMember(Value = "PARAM_ERROR")]
            PARAMERROR = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeDeleteErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayCommerceEcEmployeeDeleteErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEmployeeDeleteErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayCommerceEcEmployeeDeleteErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayCommerceEcEmployeeDeleteErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayCommerceEcEmployeeDeleteErrorResponseModel {\n");
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
            return this.Equals(input as AlipayCommerceEcEmployeeDeleteErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEmployeeDeleteErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEmployeeDeleteErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEmployeeDeleteErrorResponseModel input)
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
