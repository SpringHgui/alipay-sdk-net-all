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
    /// KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel")]
    public partial class KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel : IEquatable<KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum PERMISSIONDENY for value: PERMISSION_DENY
            /// </summary>
            [EnumMember(Value = "PERMISSION_DENY")]
            PERMISSIONDENY = 1,

            /// <summary>
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 3,

            /// <summary>
            /// Enum INFOSECCHECKFAIL for value: INFO_SEC_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "INFO_SEC_CHECK_FAIL")]
            INFOSECCHECKFAIL = 4,

            /// <summary>
            /// Enum MERCHANTACTIVITYNOTEXIST for value: MERCHANT_ACTIVITY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_ACTIVITY_NOT_EXIST")]
            MERCHANTACTIVITYNOTEXIST = 5,

            /// <summary>
            /// Enum OPERATENEARCRITICALTIME for value: OPERATE_NEAR_CRITICAL_TIME
            /// </summary>
            [EnumMember(Value = "OPERATE_NEAR_CRITICAL_TIME")]
            OPERATENEARCRITICALTIME = 6,

            /// <summary>
            /// Enum ACTIVITYCOUNTOFITEMOVERLIMI for value: ACTIVITY_COUNT_OF_ITEM_OVER_LIMI
            /// </summary>
            [EnumMember(Value = "ACTIVITY_COUNT_OF_ITEM_OVER_LIMI")]
            ACTIVITYCOUNTOFITEMOVERLIMI = 7,

            /// <summary>
            /// Enum MERCHANTACTIVITYPROCESSING for value: MERCHANT_ACTIVITY_PROCESSING
            /// </summary>
            [EnumMember(Value = "MERCHANT_ACTIVITY_PROCESSING")]
            MERCHANTACTIVITYPROCESSING = 8,

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            [EnumMember(Value = "FAIL")]
            FAIL = 9

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel and cannot be null");
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
            sb.Append("class KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel {\n");
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
            return this.Equals(input as KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiMarketingCampaignItemMerchantactivityModifyErrorResponseModel input)
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
