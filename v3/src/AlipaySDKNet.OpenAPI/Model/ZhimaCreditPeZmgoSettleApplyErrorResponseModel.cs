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
    /// ZhimaCreditPeZmgoSettleApplyErrorResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoSettleApplyErrorResponseModel")]
    public partial class ZhimaCreditPeZmgoSettleApplyErrorResponseModel : IEquatable<ZhimaCreditPeZmgoSettleApplyErrorResponseModel>, IValidatableObject
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
            /// Enum PAYAMOUNTIDEMPOTENTERROR for value: PAY_AMOUNT_IDEMPOTENT_ERROR
            /// </summary>
            [EnumMember(Value = "PAY_AMOUNT_IDEMPOTENT_ERROR")]
            PAYAMOUNTIDEMPOTENTERROR = 2,

            /// <summary>
            /// Enum SETTLEACCEPTNOTSUPPORT for value: SETTLE_ACCEPT_NOT_SUPPORT
            /// </summary>
            [EnumMember(Value = "SETTLE_ACCEPT_NOT_SUPPORT")]
            SETTLEACCEPTNOTSUPPORT = 3,

            /// <summary>
            /// Enum SETTLEWITHHOLDPLANNOTEXIST for value: SETTLE_WITHHOLD_PLAN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SETTLE_WITHHOLD_PLAN_NOT_EXIST")]
            SETTLEWITHHOLDPLANNOTEXIST = 4,

            /// <summary>
            /// Enum SETTLEWITHHOLDPLANNOERROR for value: SETTLE_WITHHOLD_PLAN_NO_ERROR
            /// </summary>
            [EnumMember(Value = "SETTLE_WITHHOLD_PLAN_NO_ERROR")]
            SETTLEWITHHOLDPLANNOERROR = 5,

            /// <summary>
            /// Enum ZMGOCONFIGSYSTEMERROR for value: ZMGO_CONFIG_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ZMGO_CONFIG_SYSTEM_ERROR")]
            ZMGOCONFIGSYSTEMERROR = 6,

            /// <summary>
            /// Enum SETTLEBALANCEACCOUNTERROR for value: SETTLE_BALANCE_ACCOUNT_ERROR
            /// </summary>
            [EnumMember(Value = "SETTLE_BALANCE_ACCOUNT_ERROR")]
            SETTLEBALANCEACCOUNTERROR = 7,

            /// <summary>
            /// Enum SETTLEBIZORDERNOTEXIST for value: SETTLE_BIZ_ORDER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SETTLE_BIZ_ORDER_NOT_EXIST")]
            SETTLEBIZORDERNOTEXIST = 8,

            /// <summary>
            /// Enum ZMGOBIZORDERSYSTEMERROR for value: ZMGO_BIZ_ORDER_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ZMGO_BIZ_ORDER_SYSTEM_ERROR")]
            ZMGOBIZORDERSYSTEMERROR = 9,

            /// <summary>
            /// Enum ZMGOSYSTEMAMOUNTNOTCLEAR for value: ZMGO_SYSTEM_AMOUNT_NOT_CLEAR
            /// </summary>
            [EnumMember(Value = "ZMGO_SYSTEM_AMOUNT_NOT_CLEAR")]
            ZMGOSYSTEMAMOUNTNOTCLEAR = 10,

            /// <summary>
            /// Enum ZMGOCREATEWPNSYSTEMERROR for value: ZMGO_CREATE_WPN_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ZMGO_CREATE_WPN_SYSTEM_ERROR")]
            ZMGOCREATEWPNSYSTEMERROR = 11,

            /// <summary>
            /// Enum ZMGOBIZAGRSYSTEMERROR for value: ZMGO_BIZ_AGR_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ZMGO_BIZ_AGR_SYSTEM_ERROR")]
            ZMGOBIZAGRSYSTEMERROR = 12,

            /// <summary>
            /// Enum SETTLEILLEGALRPC for value: SETTLE_ILLEGAL_RPC
            /// </summary>
            [EnumMember(Value = "SETTLE_ILLEGAL_RPC")]
            SETTLEILLEGALRPC = 13,

            /// <summary>
            /// Enum SETTLEWITHHOLDPLANSTATUSERROR for value: SETTLE_WITHHOLD_PLAN_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "SETTLE_WITHHOLD_PLAN_STATUS_ERROR")]
            SETTLEWITHHOLDPLANSTATUSERROR = 14,

            /// <summary>
            /// Enum SETTLEBIZAGREEMENTSTATUSFINISH for value: SETTLE_BIZ_AGREEMENT_STATUS_FINISH
            /// </summary>
            [EnumMember(Value = "SETTLE_BIZ_AGREEMENT_STATUS_FINISH")]
            SETTLEBIZAGREEMENTSTATUSFINISH = 15,

            /// <summary>
            /// Enum BALANCEAVAILABLEAMOUNTNOTENOUGH for value: BALANCE_AVAILABLE_AMOUNT_NOT_ENOUGH
            /// </summary>
            [EnumMember(Value = "BALANCE_AVAILABLE_AMOUNT_NOT_ENOUGH")]
            BALANCEAVAILABLEAMOUNTNOTENOUGH = 16,

            /// <summary>
            /// Enum ZMGOACCEPTEDSYSTEMERROR for value: ZMGO_ACCEPTED_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "ZMGO_ACCEPTED_SYSTEM_ERROR")]
            ZMGOACCEPTEDSYSTEMERROR = 17,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 18,

            /// <summary>
            /// Enum SETTLEINVALIDSETTLEMENTINFO for value: SETTLE_INVALID_SETTLEMENT_INFO
            /// </summary>
            [EnumMember(Value = "SETTLE_INVALID_SETTLEMENT_INFO")]
            SETTLEINVALIDSETTLEMENTINFO = 19,

            /// <summary>
            /// Enum PAYAMOUNTCHECKERROR for value: PAY_AMOUNT_CHECK_ERROR
            /// </summary>
            [EnumMember(Value = "PAY_AMOUNT_CHECK_ERROR")]
            PAYAMOUNTCHECKERROR = 20,

            /// <summary>
            /// Enum CYCLEWITHHOLDNOTINACCEPTTIME for value: CYCLE_WITHHOLD_NOTIN_ACCEPT_TIME
            /// </summary>
            [EnumMember(Value = "CYCLE_WITHHOLD_NOTIN_ACCEPT_TIME")]
            CYCLEWITHHOLDNOTINACCEPTTIME = 21,

            /// <summary>
            /// Enum CYCLEWITHHOLDPAYAMOUNTERROR for value: CYCLE_WITHHOLD_PAY_AMOUNT_ERROR
            /// </summary>
            [EnumMember(Value = "CYCLE_WITHHOLD_PAY_AMOUNT_ERROR")]
            CYCLEWITHHOLDPAYAMOUNTERROR = 22,

            /// <summary>
            /// Enum REQUESTACCESSILLEGAL for value: REQUEST_ACCESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "REQUEST_ACCESS_ILLEGAL")]
            REQUESTACCESSILLEGAL = 23

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleApplyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ZhimaCreditPeZmgoSettleApplyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleApplyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public ZhimaCreditPeZmgoSettleApplyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for ZhimaCreditPeZmgoSettleApplyErrorResponseModel and cannot be null");
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
            sb.Append("class ZhimaCreditPeZmgoSettleApplyErrorResponseModel {\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoSettleApplyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoSettleApplyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoSettleApplyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoSettleApplyErrorResponseModel input)
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
