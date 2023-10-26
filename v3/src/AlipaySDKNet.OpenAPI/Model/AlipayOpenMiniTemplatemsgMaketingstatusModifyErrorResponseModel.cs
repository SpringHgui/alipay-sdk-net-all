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
    /// AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel")]
    public partial class AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel : IEquatable<AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum DELIVERYDETAILIDISNULL for value: DELIVERY_DETAIL_ID_IS_NULL
            /// </summary>
            [EnumMember(Value = "DELIVERY_DETAIL_ID_IS_NULL")]
            DELIVERYDETAILIDISNULL = 1,

            /// <summary>
            /// Enum DELIVERYDETAILSTATUSNOTVALID for value: DELIVERY_DETAIL_STATUS_NOT_VALID
            /// </summary>
            [EnumMember(Value = "DELIVERY_DETAIL_STATUS_NOT_VALID")]
            DELIVERYDETAILSTATUSNOTVALID = 2,

            /// <summary>
            /// Enum DELIVERYAPPAUTHNOTVALID for value: DELIVERY_APP_AUTH_NOT_VALID
            /// </summary>
            [EnumMember(Value = "DELIVERY_APP_AUTH_NOT_VALID")]
            DELIVERYAPPAUTHNOTVALID = 3,

            /// <summary>
            /// Enum DELETESTATUSCANNOTUPDATE for value: DELETE_STATUS_CANNOT_UPDATE
            /// </summary>
            [EnumMember(Value = "DELETE_STATUS_CANNOT_UPDATE")]
            DELETESTATUSCANNOTUPDATE = 4,

            /// <summary>
            /// Enum DELIVERYSTATUSISONLINE for value: DELIVERY_STATUS_IS_ONLINE
            /// </summary>
            [EnumMember(Value = "DELIVERY_STATUS_IS_ONLINE")]
            DELIVERYSTATUSISONLINE = 5,

            /// <summary>
            /// Enum DELIVERYSTATUSISINIT for value: DELIVERY_STATUS_IS_INIT
            /// </summary>
            [EnumMember(Value = "DELIVERY_STATUS_IS_INIT")]
            DELIVERYSTATUSISINIT = 6,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 7

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTemplatemsgMaketingstatusModifyErrorResponseModel input)
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
