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
    /// AlipayOpenMiniQrcodeBindErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniQrcodeBindErrorResponseModel")]
    public partial class AlipayOpenMiniQrcodeBindErrorResponseModel : IEquatable<AlipayOpenMiniQrcodeBindErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum APPISNOTEXIST for value: APP_IS_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_IS_NOT_EXIST")]
            APPISNOTEXIST = 1,

            /// <summary>
            /// Enum ROUTECREATENEEDVERSION for value: ROUTE_CREATE_NEED_VERSION
            /// </summary>
            [EnumMember(Value = "ROUTE_CREATE_NEED_VERSION")]
            ROUTECREATENEEDVERSION = 2,

            /// <summary>
            /// Enum ROUTEOVERLIMIT for value: ROUTE_OVER_LIMIT
            /// </summary>
            [EnumMember(Value = "ROUTE_OVER_LIMIT")]
            ROUTEOVERLIMIT = 3,

            /// <summary>
            /// Enum ROUTERULECONFLICT for value: ROUTE_RULE_CONFLICT
            /// </summary>
            [EnumMember(Value = "ROUTE_RULE_CONFLICT")]
            ROUTERULECONFLICT = 4,

            /// <summary>
            /// Enum HOSTVERIFYFAILD for value: HOST_VERIFY_FAILD
            /// </summary>
            [EnumMember(Value = "HOST_VERIFY_FAILD")]
            HOSTVERIFYFAILD = 5,

            /// <summary>
            /// Enum INVALIDPARAM for value: INVALID_PARAM
            /// </summary>
            [EnumMember(Value = "INVALID_PARAM")]
            INVALIDPARAM = 6,

            /// <summary>
            /// Enum APPQRCODENOTTINYAPP for value: APPQRCODE_NOT_TINYAPP
            /// </summary>
            [EnumMember(Value = "APPQRCODE_NOT_TINYAPP")]
            APPQRCODENOTTINYAPP = 7,

            /// <summary>
            /// Enum ONLINEVERSIONNOTEXIST for value: ONLINE_VERSION_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ONLINE_VERSION_NOT_EXIST")]
            ONLINEVERSIONNOTEXIST = 8,

            /// <summary>
            /// Enum TEMPLATENOTHAVEHOST for value: TEMPLATE_NOT_HAVE_HOST
            /// </summary>
            [EnumMember(Value = "TEMPLATE_NOT_HAVE_HOST")]
            TEMPLATENOTHAVEHOST = 9,

            /// <summary>
            /// Enum TEMPLATEMISMATCHISVAPPID for value: TEMPLATE_MISMATCH_ISVAPPID
            /// </summary>
            [EnumMember(Value = "TEMPLATE_MISMATCH_ISVAPPID")]
            TEMPLATEMISMATCHISVAPPID = 10,

            /// <summary>
            /// Enum BUILDEDNOTBYTEMPLATE for value: BUILDED_NOT_BY_TEMPLATE
            /// </summary>
            [EnumMember(Value = "BUILDED_NOT_BY_TEMPLATE")]
            BUILDEDNOTBYTEMPLATE = 11,

            /// <summary>
            /// Enum NOTCURRENTLYAVALIALBE for value: NOT_CURRENTLY_AVALIALBE
            /// </summary>
            [EnumMember(Value = "NOT_CURRENTLY_AVALIALBE")]
            NOTCURRENTLYAVALIALBE = 12,

            /// <summary>
            /// Enum ROUTERULECONFLICTOTHER for value: ROUTE_RULE_CONFLICT_OTHER
            /// </summary>
            [EnumMember(Value = "ROUTE_RULE_CONFLICT_OTHER")]
            ROUTERULECONFLICTOTHER = 13,

            /// <summary>
            /// Enum QRCODEROUTEURLINVALID for value: QRCODE_ROUTE_URL_INVALID
            /// </summary>
            [EnumMember(Value = "QRCODE_ROUTE_URL_INVALID")]
            QRCODEROUTEURLINVALID = 14,

            /// <summary>
            /// Enum APPISNOTONLINE for value: APP_IS_NOT_ONLINE
            /// </summary>
            [EnumMember(Value = "APP_IS_NOT_ONLINE")]
            APPISNOTONLINE = 15,

            /// <summary>
            /// Enum QRCODEROUTEPATTERNNOTMATCH for value: QRCODE_ROUTE_PATTERN_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "QRCODE_ROUTE_PATTERN_NOT_MATCH")]
            QRCODEROUTEPATTERNNOTMATCH = 16,

            /// <summary>
            /// Enum QRCODEROUTEPATTERNNOTEXIST for value: QRCODE_ROUTE_PATTERN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "QRCODE_ROUTE_PATTERN_NOT_EXIST")]
            QRCODEROUTEPATTERNNOTEXIST = 17,

            /// <summary>
            /// Enum QRCODEROUTEPATTERNNOTPERMISSION for value: QRCODE_ROUTE_PATTERN_NOT_PERMISSION
            /// </summary>
            [EnumMember(Value = "QRCODE_ROUTE_PATTERN_NOT_PERMISSION")]
            QRCODEROUTEPATTERNNOTPERMISSION = 18,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 19,

            /// <summary>
            /// Enum SECUTIYSSRFURLILLEGAL for value: SECUTIY_SSRF_URL_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SECUTIY_SSRF_URL_ILLEGAL")]
            SECUTIYSSRFURLILLEGAL = 20,

            /// <summary>
            /// Enum SECUTIYSSRFURLFAILD for value: SECUTIY_SSRF_URL_FAILD
            /// </summary>
            [EnumMember(Value = "SECUTIY_SSRF_URL_FAILD")]
            SECUTIYSSRFURLFAILD = 21,

            /// <summary>
            /// Enum QRCODEHOSTROUTENUMLIMIT for value: QRCODE_HOST_ROUTE_NUM_LIMIT
            /// </summary>
            [EnumMember(Value = "QRCODE_HOST_ROUTE_NUM_LIMIT")]
            QRCODEHOSTROUTENUMLIMIT = 22

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniQrcodeBindErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniQrcodeBindErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniQrcodeBindErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniQrcodeBindErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniQrcodeBindErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniQrcodeBindErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniQrcodeBindErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniQrcodeBindErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniQrcodeBindErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniQrcodeBindErrorResponseModel input)
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
