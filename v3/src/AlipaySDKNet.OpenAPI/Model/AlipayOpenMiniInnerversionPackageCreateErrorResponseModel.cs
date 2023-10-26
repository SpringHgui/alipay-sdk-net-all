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
    /// AlipayOpenMiniInnerversionPackageCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionPackageCreateErrorResponseModel")]
    public partial class AlipayOpenMiniInnerversionPackageCreateErrorResponseModel : IEquatable<AlipayOpenMiniInnerversionPackageCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum PACKAGETYPENOTEXIST for value: PACKAGE_TYPE_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "PACKAGE_TYPE_NOT_EXIST")]
            PACKAGETYPENOTEXIST = 1,

            /// <summary>
            /// Enum PARAMSVALIDERROR for value: PARAMS_VALID_ERROR
            /// </summary>
            [EnumMember(Value = "PARAMS_VALID_ERROR")]
            PARAMSVALIDERROR = 2,

            /// <summary>
            /// Enum APPINFONOTEXIST for value: APP_INFO_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_INFO_NOT_EXIST")]
            APPINFONOTEXIST = 3,

            /// <summary>
            /// Enum APPLICATIONTYPENOTMINIAPP for value: APPLICATION_TYPE_NOT_MINIAPP
            /// </summary>
            [EnumMember(Value = "APPLICATION_TYPE_NOT_MINIAPP")]
            APPLICATIONTYPENOTMINIAPP = 4,

            /// <summary>
            /// Enum MINIAPPNOTONLINE for value: MINI_APP_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NOT_ONLINE")]
            MINIAPPNOTONLINE = 5,

            /// <summary>
            /// Enum NOPERMISSION for value: NO_PERMISSION
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION")]
            NOPERMISSION = 6,

            /// <summary>
            /// Enum PACKAGEVERSIONISBLANK for value: PACKAGE_VERSION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "PACKAGE_VERSION_IS_BLANK")]
            PACKAGEVERSIONISBLANK = 7,

            /// <summary>
            /// Enum VERSIONLENGTHERROR for value: VERSION_LENGTH_ERROR
            /// </summary>
            [EnumMember(Value = "VERSION_LENGTH_ERROR")]
            VERSIONLENGTHERROR = 8,

            /// <summary>
            /// Enum VERSIONEXCEEDEDLENGTH for value: VERSION_EXCEEDED_LENGTH
            /// </summary>
            [EnumMember(Value = "VERSION_EXCEEDED_LENGTH")]
            VERSIONEXCEEDEDLENGTH = 9,

            /// <summary>
            /// Enum BUNDLEIDNOTEXIST for value: BUNDLE_ID_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_NOT_EXIST")]
            BUNDLEIDNOTEXIST = 10,

            /// <summary>
            /// Enum INVALIDPARAMSWARN for value: INVALID_PARAMS_WARN
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMS_WARN")]
            INVALIDPARAMSWARN = 11,

            /// <summary>
            /// Enum MINIAPPVERSIONNOTEXIST for value: MINI_APP_VERSION_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_VERSION_NOT_EXIST")]
            MINIAPPVERSIONNOTEXIST = 12,

            /// <summary>
            /// Enum APPORIGINISBLANK for value: APP_ORIGIN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_IS_BLANK")]
            APPORIGINISBLANK = 13,

            /// <summary>
            /// Enum APPORIGINNOTEXIST for value: APP_ORIGIN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_NOT_EXIST")]
            APPORIGINNOTEXIST = 14,

            /// <summary>
            /// Enum APPISNOTHUOBAN for value: APP_IS_NOT_HUOBAN
            /// </summary>
            [EnumMember(Value = "APP_IS_NOT_HUOBAN")]
            APPISNOTHUOBAN = 15,

            /// <summary>
            /// Enum APPISBUILDBYTEMPLATE for value: APP_IS_BUILD_BY_TEMPLATE
            /// </summary>
            [EnumMember(Value = "APP_IS_BUILD_BY_TEMPLATE")]
            APPISBUILDBYTEMPLATE = 16,

            /// <summary>
            /// Enum MINIAPPVERSIONNOTINIT for value: MINI_APP_VERSION_NOT_INIT
            /// </summary>
            [EnumMember(Value = "MINI_APP_VERSION_NOT_INIT")]
            MINIAPPVERSIONNOTINIT = 17,

            /// <summary>
            /// Enum BUNDLEIDISBLANK for value: BUNDLE_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "BUNDLE_ID_IS_BLANK")]
            BUNDLEIDISBLANK = 18,

            /// <summary>
            /// Enum NOTCREATECOVERAGENOTALIPAY for value: NOT_CREATE_COVERAGE_NOT_ALIPAY
            /// </summary>
            [EnumMember(Value = "NOT_CREATE_COVERAGE_NOT_ALIPAY")]
            NOTCREATECOVERAGENOTALIPAY = 19,

            /// <summary>
            /// Enum APPISNOTINNER for value: APP_IS_NOT_INNER
            /// </summary>
            [EnumMember(Value = "APP_IS_NOT_INNER")]
            APPISNOTINNER = 20

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionPackageCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerversionPackageCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionPackageCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerversionPackageCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerversionPackageCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerversionPackageCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionPackageCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionPackageCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionPackageCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionPackageCreateErrorResponseModel input)
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
