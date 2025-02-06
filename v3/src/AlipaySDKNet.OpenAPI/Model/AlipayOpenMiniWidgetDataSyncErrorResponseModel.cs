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
    /// AlipayOpenMiniWidgetDataSyncErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniWidgetDataSyncErrorResponseModel")]
    public partial class AlipayOpenMiniWidgetDataSyncErrorResponseModel : IEquatable<AlipayOpenMiniWidgetDataSyncErrorResponseModel>, IValidatableObject
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
            /// Enum MINIAPPIDILLEGAL for value: MINI_APP_ID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MINI_APP_ID_ILLEGAL")]
            MINIAPPIDILLEGAL = 3,

            /// <summary>
            /// Enum PIDILLEGAL for value: PID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PID_ILLEGAL")]
            PIDILLEGAL = 4,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 5,

            /// <summary>
            /// Enum APPISNOTWIDGET for value: APP_IS_NOT_WIDGET
            /// </summary>
            [EnumMember(Value = "APP_IS_NOT_WIDGET")]
            APPISNOTWIDGET = 6,

            /// <summary>
            /// Enum AUDITINGVERSIONEXIST for value: AUDITING_VERSION_EXIST
            /// </summary>
            [EnumMember(Value = "AUDITING_VERSION_EXIST")]
            AUDITINGVERSIONEXIST = 7,

            /// <summary>
            /// Enum WIDGETDATAUPLOADFREQUENCY for value: WIDGET_DATA_UPLOAD_FREQUENCY
            /// </summary>
            [EnumMember(Value = "WIDGET_DATA_UPLOAD_FREQUENCY")]
            WIDGETDATAUPLOADFREQUENCY = 8,

            /// <summary>
            /// Enum WIDGETDATAMAXSIZELIMIT for value: WIDGET_DATA_MAX_SIZE_LIMIT
            /// </summary>
            [EnumMember(Value = "WIDGET_DATA_MAX_SIZE_LIMIT")]
            WIDGETDATAMAXSIZELIMIT = 9,

            /// <summary>
            /// Enum APPIDNOTEXIST for value: APP_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ID_NOT_EXIST")]
            APPIDNOTEXIST = 10,

            /// <summary>
            /// Enum APPTYPEINVALID for value: APP_TYPE_INVALID
            /// </summary>
            [EnumMember(Value = "APP_TYPE_INVALID")]
            APPTYPEINVALID = 11,

            /// <summary>
            /// Enum PICTURESIZEMORETHENMAX for value: PICTURE_SIZE_MORETHEN_MAX
            /// </summary>
            [EnumMember(Value = "PICTURE_SIZE_MORETHEN_MAX")]
            PICTURESIZEMORETHENMAX = 12,

            /// <summary>
            /// Enum CLICKURLSIZEMORETHENMAX for value: CLICK_URL_SIZE_MORETHEN_MAX
            /// </summary>
            [EnumMember(Value = "CLICK_URL_SIZE_MORETHEN_MAX")]
            CLICKURLSIZEMORETHENMAX = 13

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniWidgetDataSyncErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniWidgetDataSyncErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniWidgetDataSyncErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniWidgetDataSyncErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniWidgetDataSyncErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniWidgetDataSyncErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniWidgetDataSyncErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniWidgetDataSyncErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniWidgetDataSyncErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniWidgetDataSyncErrorResponseModel input)
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
