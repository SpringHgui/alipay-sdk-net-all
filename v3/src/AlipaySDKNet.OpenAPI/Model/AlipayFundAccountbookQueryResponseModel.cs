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
    /// AlipayFundAccountbookQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAccountbookQueryResponseModel")]
    public partial class AlipayFundAccountbookQueryResponseModel : IEquatable<AlipayFundAccountbookQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAccountbookQueryResponseModel" /> class.
        /// </summary>
        /// <param name="accountBookId">记账账簿id.</param>
        /// <param name="authInfo">authInfo.</param>
        /// <param name="availableAmount">可用余额.</param>
        /// <param name="extCardInfo">extCardInfo.</param>
        public AlipayFundAccountbookQueryResponseModel(string accountBookId = default(string), AuthInfoDTO authInfo = default(AuthInfoDTO), string availableAmount = default(string), ExtCardInfo extCardInfo = default(ExtCardInfo))
        {
            this.AccountBookId = accountBookId;
            this.AuthInfo = authInfo;
            this.AvailableAmount = availableAmount;
            this.ExtCardInfo = extCardInfo;
        }

        /// <summary>
        /// 记账账簿id
        /// </summary>
        /// <value>记账账簿id</value>
        [DataMember(Name = "account_book_id", EmitDefaultValue = false)]
        public string AccountBookId { get; set; }

        /// <summary>
        /// Gets or Sets AuthInfo
        /// </summary>
        [DataMember(Name = "auth_info", EmitDefaultValue = false)]
        public AuthInfoDTO AuthInfo { get; set; }

        /// <summary>
        /// 可用余额
        /// </summary>
        /// <value>可用余额</value>
        [DataMember(Name = "available_amount", EmitDefaultValue = false)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// Gets or Sets ExtCardInfo
        /// </summary>
        [DataMember(Name = "ext_card_info", EmitDefaultValue = false)]
        public ExtCardInfo ExtCardInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAccountbookQueryResponseModel {\n");
            sb.Append("  AccountBookId: ").Append(AccountBookId).Append("\n");
            sb.Append("  AuthInfo: ").Append(AuthInfo).Append("\n");
            sb.Append("  AvailableAmount: ").Append(AvailableAmount).Append("\n");
            sb.Append("  ExtCardInfo: ").Append(ExtCardInfo).Append("\n");
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
            return this.Equals(input as AlipayFundAccountbookQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAccountbookQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAccountbookQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAccountbookQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountBookId == input.AccountBookId ||
                    (this.AccountBookId != null &&
                    this.AccountBookId.Equals(input.AccountBookId))
                ) && 
                (
                    this.AuthInfo == input.AuthInfo ||
                    (this.AuthInfo != null &&
                    this.AuthInfo.Equals(input.AuthInfo))
                ) && 
                (
                    this.AvailableAmount == input.AvailableAmount ||
                    (this.AvailableAmount != null &&
                    this.AvailableAmount.Equals(input.AvailableAmount))
                ) && 
                (
                    this.ExtCardInfo == input.ExtCardInfo ||
                    (this.ExtCardInfo != null &&
                    this.ExtCardInfo.Equals(input.ExtCardInfo))
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
                if (this.AccountBookId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountBookId.GetHashCode();
                }
                if (this.AuthInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthInfo.GetHashCode();
                }
                if (this.AvailableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableAmount.GetHashCode();
                }
                if (this.ExtCardInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtCardInfo.GetHashCode();
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
