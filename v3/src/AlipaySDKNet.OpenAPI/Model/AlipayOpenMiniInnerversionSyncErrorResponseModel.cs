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
    /// AlipayOpenMiniInnerversionSyncErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionSyncErrorResponseModel")]
    public partial class AlipayOpenMiniInnerversionSyncErrorResponseModel : IEquatable<AlipayOpenMiniInnerversionSyncErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 1,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 2,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 3,

            /// <summary>
            /// Enum APPORIGINISBLANK for value: APP_ORIGIN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_IS_BLANK")]
            APPORIGINISBLANK = 4,

            /// <summary>
            /// Enum APPORIGINNOTEXIST for value: APP_ORIGIN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_NOT_EXIST")]
            APPORIGINNOTEXIST = 5,

            /// <summary>
            /// Enum SYNCTYPEISBLANK for value: SYNC_TYPE_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SYNC_TYPE_IS_BLANK")]
            SYNCTYPEISBLANK = 6,

            /// <summary>
            /// Enum SYNCTYPENOTEXIST for value: SYNC_TYPE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SYNC_TYPE_NOT_EXIST")]
            SYNCTYPENOTEXIST = 7,

            /// <summary>
            /// Enum BUNDLEIDISBLANK for value: BUNDLE_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_IS_BLANK")]
            BUNDLEIDISBLANK = 8,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 9,

            /// <summary>
            /// Enum BUNDLEIDNOTINSYNC for value: BUNDLE_ID_NOT_IN_SYNC
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_IN_SYNC")]
            BUNDLEIDNOTINSYNC = 10,

            /// <summary>
            /// Enum SYNCWITHOUTONLINEERROR for value: SYNC_WITHOUT_ONLINE_ERROR
            /// </summary>
            [EnumMember(Value = "SYNC_WITHOUT_ONLINE_ERROR")]
            SYNCWITHOUTONLINEERROR = 11,

            /// <summary>
            /// Enum PKGCOREINVOKEERROR for value: PKGCORE_INVOKE_ERROR
            /// </summary>
            [EnumMember(Value = "PKGCORE_INVOKE_ERROR")]
            PKGCOREINVOKEERROR = 12,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 13,

            /// <summary>
            /// Enum MINICOREINVOKEERROR for value: MINICORE_INVOKE_ERROR
            /// </summary>
            [EnumMember(Value = "MINICORE_INVOKE_ERROR")]
            MINICOREINVOKEERROR = 14

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionSyncErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerversionSyncErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionSyncErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerversionSyncErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerversionSyncErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerversionSyncErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionSyncErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionSyncErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionSyncErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionSyncErrorResponseModel input)
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
