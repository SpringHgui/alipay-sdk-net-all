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
    /// AlipayOpenAppApiFieldApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppApiFieldApplyErrorResponseModel")]
    public partial class AlipayOpenAppApiFieldApplyErrorResponseModel : IEquatable<AlipayOpenAppApiFieldApplyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 1,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 2,

            /// <summary>
            /// Enum APPIDISBLANK for value: APP_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_ID_IS_BLANK")]
            APPIDISBLANK = 3,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 4,

            /// <summary>
            /// Enum AUTHFIELDAPPLYISBLANK for value: AUTHFIELDAPPLY_IS_BLANK
            /// </summary>
            [EnumMember(Value = "AUTHFIELDAPPLY_IS_BLANK")]
            AUTHFIELDAPPLYISBLANK = 5,

            /// <summary>
            /// Enum APINAMEISBLANK for value: API_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "API_NAME_IS_BLANK")]
            APINAMEISBLANK = 6,

            /// <summary>
            /// Enum FIELDNAMEISBLANK for value: FIELD_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "FIELD_NAME_IS_BLANK")]
            FIELDNAMEISBLANK = 7,

            /// <summary>
            /// Enum PACKAGECODEISBLANK for value: PACKAGE_CODE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "PACKAGE_CODE_IS_BLANK")]
            PACKAGECODEISBLANK = 8,

            /// <summary>
            /// Enum SCENECODEISBLANK for value: SCENE_CODE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SCENE_CODE_IS_BLANK")]
            SCENECODEISBLANK = 9,

            /// <summary>
            /// Enum QPSANSWERISBLANK for value: QPS_ANSWER_IS_BLANK
            /// </summary>
            [EnumMember(Value = "QPS_ANSWER_IS_BLANK")]
            QPSANSWERISBLANK = 10,

            /// <summary>
            /// Enum CUSTOMERANSWERISBLANK for value: CUSTOMER_ANSWER_IS_BLANK
            /// </summary>
            [EnumMember(Value = "CUSTOMER_ANSWER_IS_BLANK")]
            CUSTOMERANSWERISBLANK = 11,

            /// <summary>
            /// Enum FILEITEMSISBLANK for value: FILE_ITEMS_IS_BLANK
            /// </summary>
            [EnumMember(Value = "FILE_ITEMS_IS_BLANK")]
            FILEITEMSISBLANK = 12,

            /// <summary>
            /// Enum AUTHFIELDSCENEISBLANK for value: AUTH_FIELD_SCENE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "AUTH_FIELD_SCENE_IS_BLANK")]
            AUTHFIELDSCENEISBLANK = 13,

            /// <summary>
            /// Enum SCENECODEERROR for value: SCENE_CODE_ERROR
            /// </summary>
            [EnumMember(Value = "SCENE_CODE_ERROR")]
            SCENECODEERROR = 14,

            /// <summary>
            /// Enum USERIDNOPERMISSION for value: USER_ID_NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "USER_ID_NO_PERMISSION")]
            USERIDNOPERMISSION = 15,

            /// <summary>
            /// Enum SHOWPACKAGEISBLANK for value: SHOW_PACKAGE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SHOW_PACKAGE_IS_BLANK")]
            SHOWPACKAGEISBLANK = 16,

            /// <summary>
            /// Enum PACKAGECODEERROR for value: PACKAGE_CODE_ERROR
            /// </summary>
            [EnumMember(Value = "PACKAGE_CODE_ERROR")]
            PACKAGECODEERROR = 17,

            /// <summary>
            /// Enum TINYAPPHEALTHCHECKINVALID for value: TINYAPP_HEALTH_CHECK_INVALID
            /// </summary>
            [EnumMember(Value = "TINYAPP_HEALTH_CHECK_INVALID")]
            TINYAPPHEALTHCHECKINVALID = 18,

            /// <summary>
            /// Enum TINYAPPSAFETYCHECKINVALID for value: TINYAPP_SAFETY_CHECK_INVALID
            /// </summary>
            [EnumMember(Value = "TINYAPP_SAFETY_CHECK_INVALID")]
            TINYAPPSAFETYCHECKINVALID = 19,

            /// <summary>
            /// Enum APINAMEERROR for value: API_NAME_ERROR
            /// </summary>
            [EnumMember(Value = "API_NAME_ERROR")]
            APINAMEERROR = 20,

            /// <summary>
            /// Enum AUTHAPIFIELDISBLANK for value: AUTH_API_FIELD_IS_BLANK
            /// </summary>
            [EnumMember(Value = "AUTH_API_FIELD_IS_BLANK")]
            AUTHAPIFIELDISBLANK = 21,

            /// <summary>
            /// Enum AUTHAPIAPPLYISPASS for value: AUTH_API_APPLY_IS_PASS
            /// </summary>
            [EnumMember(Value = "AUTH_API_APPLY_IS_PASS")]
            AUTHAPIAPPLYISPASS = 22,

            /// <summary>
            /// Enum FILEFORMATISINVALID for value: FILE_FORMAT_IS_INVALID
            /// </summary>
            [EnumMember(Value = "FILE_FORMAT_IS_INVALID")]
            FILEFORMATISINVALID = 23,

            /// <summary>
            /// Enum FILESIZEMINLIMIT for value: FILE_SIZE_MIN_LIMIT
            /// </summary>
            [EnumMember(Value = "FILE_SIZE_MIN_LIMIT")]
            FILESIZEMINLIMIT = 24,

            /// <summary>
            /// Enum FILESIZEOUTLIMIT for value: FILE_SIZE_OUT_LIMIT
            /// </summary>
            [EnumMember(Value = "FILE_SIZE_OUT_LIMIT")]
            FILESIZEOUTLIMIT = 25,

            /// <summary>
            /// Enum FILEQUALITYISINVALID for value: FILE_QUALITY_IS_INVALID
            /// </summary>
            [EnumMember(Value = "FILE_QUALITY_IS_INVALID")]
            FILEQUALITYISINVALID = 26,

            /// <summary>
            /// Enum AUTHAPIFIELDISAUDITING for value: AUTH_API_FIELD_IS_AUDITING
            /// </summary>
            [EnumMember(Value = "AUTH_API_FIELD_IS_AUDITING")]
            AUTHAPIFIELDISAUDITING = 27,

            /// <summary>
            /// Enum ACCOUNTTYPEERROR for value: ACCOUNT_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "ACCOUNT_TYPE_ERROR")]
            ACCOUNTTYPEERROR = 28

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppApiFieldApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenAppApiFieldApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppApiFieldApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenAppApiFieldApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenAppApiFieldApplyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenAppApiFieldApplyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenAppApiFieldApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppApiFieldApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppApiFieldApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppApiFieldApplyErrorResponseModel input)
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
