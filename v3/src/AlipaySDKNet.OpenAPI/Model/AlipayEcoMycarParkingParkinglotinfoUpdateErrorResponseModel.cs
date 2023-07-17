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
    /// AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel")]
    public partial class AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel : IEquatable<AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel>, IValidatableObject
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
            /// Enum BIZERROR for value: BIZ_ERROR
            /// </summary>
            [EnumMember(Value = "BIZ_ERROR")]
            BIZERROR = 2,

            /// <summary>
            /// Enum MERCHANTIDISEMPTY for value: MERCHANT_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "MERCHANT_ID_IS_EMPTY")]
            MERCHANTIDISEMPTY = 3,

            /// <summary>
            /// Enum MERCHANTIDFORMATERROR for value: MERCHANT_ID_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "MERCHANT_ID_FORMAT_ERROR")]
            MERCHANTIDFORMATERROR = 4,

            /// <summary>
            /// Enum PARKINGPOIIDISEMPTY for value: PARKING_POI_ID_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_POI_ID_IS_EMPTY")]
            PARKINGPOIIDISEMPTY = 5,

            /// <summary>
            /// Enum PARKINGPOINOTFIND for value: PARKING_POI_NOT_FIND
            /// </summary>
            [EnumMember(Value = "PARKING_POI_NOT_FIND")]
            PARKINGPOINOTFIND = 6,

            /// <summary>
            /// Enum PARKINGPOITYPENOTMATCH for value: PARKING_POI_TYPE_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "PARKING_POI_TYPE_NOT_MATCH")]
            PARKINGPOITYPENOTMATCH = 7,

            /// <summary>
            /// Enum PARKINGLEADSHASREGISTERED for value: PARKING_LEADS_HAS_REGISTERED
            /// </summary>
            [EnumMember(Value = "PARKING_LEADS_HAS_REGISTERED")]
            PARKINGLEADSHASREGISTERED = 8,

            /// <summary>
            /// Enum PARKINGPOIHASREGISTERED for value: PARKING_POI_HAS_REGISTERED
            /// </summary>
            [EnumMember(Value = "PARKING_POI_HAS_REGISTERED")]
            PARKINGPOIHASREGISTERED = 9,

            /// <summary>
            /// Enum PARKINGIDFORMATERROR for value: PARKING_ID_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_ID_FORMAT_ERROR")]
            PARKINGIDFORMATERROR = 10,

            /// <summary>
            /// Enum PARKINGMOBILEISEMPTY for value: PARKING_MOBILE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "PARKING_MOBILE_IS_EMPTY")]
            PARKINGMOBILEISEMPTY = 11,

            /// <summary>
            /// Enum PARKINGISSUPPORTINVOICEILLEGAL for value: PARKING_IS_SUPPORT_INVOICE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_IS_SUPPORT_INVOICE_ILLEGAL")]
            PARKINGISSUPPORTINVOICEILLEGAL = 12,

            /// <summary>
            /// Enum PARKINGBIZTAGSILLEGAL for value: PARKING_BIZ_TAGS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_BIZ_TAGS_ILLEGAL")]
            PARKINGBIZTAGSILLEGAL = 13,

            /// <summary>
            /// Enum PARKINGSUMSPACEILLEGAL for value: PARKING_SUM_SPACE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_SUM_SPACE_ILLEGAL")]
            PARKINGSUMSPACEILLEGAL = 14,

            /// <summary>
            /// Enum PARKINGISVMOBILEFORMATERROR for value: PARKING_ISV_MOBILE_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_ISV_MOBILE_FORMAT_ERROR")]
            PARKINGISVMOBILEFORMATERROR = 15,

            /// <summary>
            /// Enum PARKINGORIGINALISVMOBILEFORMATERROR for value: PARKING_ORIGINAL_ISV_MOBILE_FORMAT_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_ORIGINAL_ISV_MOBILE_FORMAT_ERROR")]
            PARKINGORIGINALISVMOBILEFORMATERROR = 16,

            /// <summary>
            /// Enum PARKINGFEEDESCIMGILLEGAL for value: PARKING_FEE_DESC_IMG_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKING_FEE_DESC_IMG_ILLEGAL")]
            PARKINGFEEDESCIMGILLEGAL = 17,

            /// <summary>
            /// Enum PARKINGFEEDESCIMGUPLOADERROR for value: PARKING_FEE_DESC_IMG_UPLOAD_ERROR
            /// </summary>
            [EnumMember(Value = "PARKING_FEE_DESC_IMG_UPLOAD_ERROR")]
            PARKINGFEEDESCIMGUPLOADERROR = 18,

            /// <summary>
            /// Enum PARKINGLOTHASREGISTERED for value: PARKING_LOT_HAS_REGISTERED
            /// </summary>
            [EnumMember(Value = "PARKING_LOT_HAS_REGISTERED")]
            PARKINGLOTHASREGISTERED = 19,

            /// <summary>
            /// Enum PARKINGLOTNOTEXIST for value: PARKING_LOT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "PARKING_LOT_NOT_EXIST")]
            PARKINGLOTNOTEXIST = 20,

            /// <summary>
            /// Enum PARKINGISVNOTALLOWED for value: PARKING_ISV_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "PARKING_ISV_NOT_ALLOWED")]
            PARKINGISVNOTALLOWED = 21,

            /// <summary>
            /// Enum INVALIDUPDATEINBASESTATUS for value: INVALID_UPDATE_IN_BASE_STATUS
            /// </summary>
            [EnumMember(Value = "INVALID_UPDATE_IN_BASE_STATUS")]
            INVALIDUPDATEINBASESTATUS = 22,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 23,

            /// <summary>
            /// Enum INVALIDPARAMETERBUSINESSID for value: INVALID_PARAMETER_BUSINESS_ID
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER_BUSINESS_ID")]
            INVALIDPARAMETERBUSINESSID = 24,

            /// <summary>
            /// Enum INVALIDPARAMETERBUSINESSTYPE for value: INVALID_PARAMETER_BUSINESS_TYPE
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMETER_BUSINESS_TYPE")]
            INVALIDPARAMETERBUSINESSTYPE = 25,

            /// <summary>
            /// Enum ONLINETACCOUNTBADNOTAPPS for value: ONLINET_ACCOUNT_BAD_NOT_APPS
            /// </summary>
            [EnumMember(Value = "ONLINET_ACCOUNT_BAD_NOT_APPS")]
            ONLINETACCOUNTBADNOTAPPS = 26,

            /// <summary>
            /// Enum AGREEMENTACCOUNTBADNOTAPPS for value: AGREEMENT_ACCOUNT_BAD_NOT_APPS
            /// </summary>
            [EnumMember(Value = "AGREEMENT_ACCOUNT_BAD_NOT_APPS")]
            AGREEMENTACCOUNTBADNOTAPPS = 27,

            /// <summary>
            /// Enum AGREEMENTACCOUNTBADNOTSIGN for value: AGREEMENT_ACCOUNT_BAD_NOT_SIGN
            /// </summary>
            [EnumMember(Value = "AGREEMENT_ACCOUNT_BAD_NOT_SIGN")]
            AGREEMENTACCOUNTBADNOTSIGN = 28,

            /// <summary>
            /// Enum AGREEMENTACCOUNTBADINVALIDPAYEEID for value: AGREEMENT_ACCOUNT_BAD_INVALID_PAYEE_ID
            /// </summary>
            [EnumMember(Value = "AGREEMENT_ACCOUNT_BAD_INVALID_PAYEE_ID")]
            AGREEMENTACCOUNTBADINVALIDPAYEEID = 29,

            /// <summary>
            /// Enum PARKINGLOTTYPEERROR for value: PARKINGLOT_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_TYPE_ERROR")]
            PARKINGLOTTYPEERROR = 30,

            /// <summary>
            /// Enum PARKINGLOTBIZTYPEERROR for value: PARKINGLOT_BIZ_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_BIZ_TYPE_ERROR")]
            PARKINGLOTBIZTYPEERROR = 31,

            /// <summary>
            /// Enum PARKINGLOTONLINETACCOUNTNOTAPPS for value: PARKINGLOT_ONLINET_ACCOUNT_NOT_APPS
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_ONLINET_ACCOUNT_NOT_APPS")]
            PARKINGLOTONLINETACCOUNTNOTAPPS = 32,

            /// <summary>
            /// Enum PARKINGLOTAGREEMENTACCOUNTNOTAPPS for value: PARKINGLOT_AGREEMENT_ACCOUNT_NOT_APPS
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_AGREEMENT_ACCOUNT_NOT_APPS")]
            PARKINGLOTAGREEMENTACCOUNTNOTAPPS = 33,

            /// <summary>
            /// Enum PARKINGLOTAGREEMENTACCOUNTBADSIGN for value: PARKINGLOT_AGREEMENT_ACCOUNT_BAD_SIGN
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_AGREEMENT_ACCOUNT_BAD_SIGN")]
            PARKINGLOTAGREEMENTACCOUNTBADSIGN = 34,

            /// <summary>
            /// Enum PARKINGLOTPOITYPENOTMATCH for value: PARKINGLOT_POI_TYPE_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_POI_TYPE_NOT_MATCH")]
            PARKINGLOTPOITYPENOTMATCH = 35,

            /// <summary>
            /// Enum PARKINGLOTISVAPPIDILLEGAL for value: PARKINGLOT_ISV_APP_ID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_ISV_APP_ID_ILLEGAL")]
            PARKINGLOTISVAPPIDILLEGAL = 36,

            /// <summary>
            /// Enum PARKINGLOTPOINOTFIND for value: PARKINGLOT_POI_NOT_FIND
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_POI_NOT_FIND")]
            PARKINGLOTPOINOTFIND = 37,

            /// <summary>
            /// Enum PARKINGLOTPOIPARSEERROR for value: PARKINGLOT_POI_PARSE_ERROR
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_POI_PARSE_ERROR")]
            PARKINGLOTPOIPARSEERROR = 38,

            /// <summary>
            /// Enum PARKINGLOTISVNOTMATCH for value: PARKINGLOT_ISV_NOT_MATCH
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_ISV_NOT_MATCH")]
            PARKINGLOTISVNOTMATCH = 39,

            /// <summary>
            /// Enum PARKINGLOTINVALIDUPDATEINBASESTATUS for value: PARKINGLOT_INVALID_UPDATE_IN_BASE_STATUS
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_INVALID_UPDATE_IN_BASE_STATUS")]
            PARKINGLOTINVALIDUPDATEINBASESTATUS = 40,

            /// <summary>
            /// Enum PARKINGLOTMODIFYERROR for value: PARKINGLOT_MODIFY_ERROR
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_MODIFY_ERROR")]
            PARKINGLOTMODIFYERROR = 41,

            /// <summary>
            /// Enum PARKINGLOTSENDUPDATEEVENTFAIL for value: PARKINGLOT_SEND_UPDATE_EVENT_FAIL
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_SEND_UPDATE_EVENT_FAIL")]
            PARKINGLOTSENDUPDATEEVENTFAIL = 42,

            /// <summary>
            /// Enum PARKINGLOTNOTFIND for value: PARKINGLOT_NOT_FIND
            /// </summary>
            [EnumMember(Value = "PARKINGLOT_NOT_FIND")]
            PARKINGLOTNOTFIND = 43,

            /// <summary>
            /// Enum NOPERMISSIONERROR for value: NO_PERMISSION_ERROR
            /// </summary>
            [EnumMember(Value = "NO_PERMISSION_ERROR")]
            NOPERMISSIONERROR = 44

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingParkinglotinfoUpdateErrorResponseModel input)
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
