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
    /// ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel")]
    public partial class ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel : IEquatable<ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel>, IValidatableObject
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
            /// Enum INVALIDPARAMETER for value: INVALID_PARAMETER
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER")]
            INVALIDPARAMETER = 2,

            /// <summary>
            /// Enum ZMGOCONFIGSYSTEMERROR for value: ZMGO_CONFIG_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ZMGO_CONFIG_SYSTEM_ERROR")]
            ZMGOCONFIGSYSTEMERROR = 3,

            /// <summary>
            /// Enum BALANCEAVAILABLEAMOUNTNOTENOUGH for value: BALANCE_AVAILABLE_AMOUNT_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "BALANCE_AVAILABLE_AMOUNT_NOT_ENOUGH")]
            BALANCEAVAILABLEAMOUNTNOTENOUGH = 4,

            /// <summary>
            /// Enum BALANCEACCOUNTMISSING for value: BALANCE_ACCOUNT_MISSING
            /// </summary>
            [EnumMember(Value = "BALANCE_ACCOUNT_MISSING")]
            BALANCEACCOUNTMISSING = 5,

            /// <summary>
            /// Enum BIZORDERNOTEXISTFAILURE for value: BIZ_ORDER_NOT_EXIST_FAILURE
            /// </summary>
            [EnumMember(Value = "BIZ_ORDER_NOT_EXIST_FAILURE")]
            BIZORDERNOTEXISTFAILURE = 6,

            /// <summary>
            /// Enum SETTLEBIZAGREEMENTNOTEXIST for value: SETTLE_BIZ_AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SETTLE_BIZ_AGREEMENT_NOT_EXIST")]
            SETTLEBIZAGREEMENTNOTEXIST = 7,

            /// <summary>
            /// Enum UNFREEZEAGRNSTATUS for value: UNFREEZE_AGR_N_STATUS
            /// </summary>
            [EnumMember(Value = "UNFREEZE_AGR_N_STATUS")]
            UNFREEZEAGRNSTATUS = 8,

            /// <summary>
            /// Enum BIZOPTIDEMPOTENTFAILURE for value: BIZ_OPT_IDEMPOTENT_FAILURE
            /// </summary>
            [EnumMember(Value = "BIZ_OPT_IDEMPOTENT_FAILURE")]
            BIZOPTIDEMPOTENTFAILURE = 9,

            /// <summary>
            /// Enum BIZOPTUPDATEFAILURE for value: BIZ_OPT_UPDATE_FAILURE
            /// </summary>
            [EnumMember(Value = "BIZ_OPT_UPDATE_FAILURE")]
            BIZOPTUPDATEFAILURE = 10,

            /// <summary>
            /// Enum BALANCEUSERLOCKCOLLISION for value: BALANCE_USER_LOCK_COLLISION
            /// </summary>
            [EnumMember(Value = "BALANCE_USER_LOCK_COLLISION")]
            BALANCEUSERLOCKCOLLISION = 11,

            /// <summary>
            /// Enum BALANCEIDEMPOTENTCHECKFAILURE for value: BALANCE_IDEMPOTENT_CHECK_FAILURE
            /// </summary>
            [EnumMember(Value = "BALANCE_IDEMPOTENT_CHECK_FAILURE")]
            BALANCEIDEMPOTENTCHECKFAILURE = 12,

            /// <summary>
            /// Enum BALANCESYSTEMAMOUNTNOTENOUGH for value: BALANCE_SYSTEM_AMOUNT_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "BALANCE_SYSTEM_AMOUNT_NOT_ENOUGH")]
            BALANCESYSTEMAMOUNTNOTENOUGH = 13,

            /// <summary>
            /// Enum REQUESTACCESSILLEGAL for value: REQUEST_ACCESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_ACCESS_ILLEGAL")]
            REQUESTACCESSILLEGAL = 14

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel and cannot be null");
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
            sb.Append("class ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel {\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoSettleUnfreezeErrorResponseModel input)
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
