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
    /// AlipayOpenSpBlueseaactivityModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpBlueseaactivityModifyErrorResponseModel")]
    public partial class AlipayOpenSpBlueseaactivityModifyErrorResponseModel : IEquatable<AlipayOpenSpBlueseaactivityModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum ILLEGALPARAMS for value: ILLEGAL_PARAMS
            /// </summary>
            [EnumMember(Value = "ILLEGAL_PARAMS")]
            ILLEGALPARAMS = 1,

            /// <summary>
            /// Enum ACTIVITYAPPLYORDERNOTEXIST for value: ACTIVITY_APPLYORDER_NOTEXIST
            /// </summary>
            [EnumMember(Value = "ACTIVITY_APPLYORDER_NOTEXIST")]
            ACTIVITYAPPLYORDERNOTEXIST = 2,

            /// <summary>
            /// Enum MERCHANTACTIVITYAPPLIED for value: MERCHANT_ACTIVITY_APPLIED
            /// </summary>
            [EnumMember(Value = "MERCHANT_ACTIVITY_APPLIED")]
            MERCHANTACTIVITYAPPLIED = 3,

            /// <summary>
            /// Enum BLUESEAMCCLIMITED for value: BLUESEA_MCC_LIMITED
            /// </summary>
            [EnumMember(Value = "BLUESEA_MCC_LIMITED")]
            BLUESEAMCCLIMITED = 4,

            /// <summary>
            /// Enum BLUESEAQUALIFICATIONLICENSEINCOMPLETE for value: BLUESEA_QUALIFICATIONLICENSE_INCOMPLETE
            /// </summary>
            [EnumMember(Value = "BLUESEA_QUALIFICATIONLICENSE_INCOMPLETE")]
            BLUESEAQUALIFICATIONLICENSEINCOMPLETE = 5,

            /// <summary>
            /// Enum BLUESEAADDRESSINCOMPLETE for value: BLUESEA_ADDRESS_INCOMPLETE
            /// </summary>
            [EnumMember(Value = "BLUESEA_ADDRESS_INCOMPLETE")]
            BLUESEAADDRESSINCOMPLETE = 6,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 7,

            /// <summary>
            /// Enum ACTIVITYAPPLYORDERCANNOTEDIT for value: ACTIVITY_APPLYORDER_CANNOTEDIT
            /// </summary>
            [EnumMember(Value = "ACTIVITY_APPLYORDER_CANNOTEDIT")]
            ACTIVITYAPPLYORDERCANNOTEDIT = 8,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 9,

            /// <summary>
            /// Enum BLUESEAORDERINVALID for value: BLUESEA_ORDER_INVALID
            /// </summary>
            [EnumMember(Value = "BLUESEA_ORDER_INVALID")]
            BLUESEAORDERINVALID = 10

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpBlueseaactivityModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenSpBlueseaactivityModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpBlueseaactivityModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenSpBlueseaactivityModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenSpBlueseaactivityModifyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenSpBlueseaactivityModifyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenSpBlueseaactivityModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpBlueseaactivityModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpBlueseaactivityModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpBlueseaactivityModifyErrorResponseModel input)
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
