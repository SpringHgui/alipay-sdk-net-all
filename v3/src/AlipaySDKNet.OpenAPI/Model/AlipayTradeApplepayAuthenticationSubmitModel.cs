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
    /// AlipayTradeApplepayAuthenticationSubmitModel
    /// </summary>
    [DataContract(Name = "AlipayTradeApplepayAuthenticationSubmitModel")]
    public partial class AlipayTradeApplepayAuthenticationSubmitModel : IEquatable<AlipayTradeApplepayAuthenticationSubmitModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeApplepayAuthenticationSubmitModel" /> class.
        /// </summary>
        /// <param name="authenticationResults">ApplePay核身鉴权结果，包括：支付密码、用户确认、数字签名.</param>
        /// <param name="deviceIdentifier">Apple端的设备ID.</param>
        /// <param name="dpanIdentifier">Apple绑定的BundleId.</param>
        /// <param name="transactionIdentifier">交易标识.</param>
        public AlipayTradeApplepayAuthenticationSubmitModel(List<AuthenticationResult> authenticationResults = default(List<AuthenticationResult>), string deviceIdentifier = default(string), string dpanIdentifier = default(string), string transactionIdentifier = default(string))
        {
            this.AuthenticationResults = authenticationResults;
            this.DeviceIdentifier = deviceIdentifier;
            this.DpanIdentifier = dpanIdentifier;
            this.TransactionIdentifier = transactionIdentifier;
        }

        /// <summary>
        /// ApplePay核身鉴权结果，包括：支付密码、用户确认、数字签名
        /// </summary>
        /// <value>ApplePay核身鉴权结果，包括：支付密码、用户确认、数字签名</value>
        [DataMember(Name = "authentication_results", EmitDefaultValue = false)]
        public List<AuthenticationResult> AuthenticationResults { get; set; }

        /// <summary>
        /// Apple端的设备ID
        /// </summary>
        /// <value>Apple端的设备ID</value>
        [DataMember(Name = "device_identifier", EmitDefaultValue = false)]
        public string DeviceIdentifier { get; set; }

        /// <summary>
        /// Apple绑定的BundleId
        /// </summary>
        /// <value>Apple绑定的BundleId</value>
        [DataMember(Name = "dpan_identifier", EmitDefaultValue = false)]
        public string DpanIdentifier { get; set; }

        /// <summary>
        /// 交易标识
        /// </summary>
        /// <value>交易标识</value>
        [DataMember(Name = "transaction_identifier", EmitDefaultValue = false)]
        public string TransactionIdentifier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeApplepayAuthenticationSubmitModel {\n");
            sb.Append("  AuthenticationResults: ").Append(AuthenticationResults).Append("\n");
            sb.Append("  DeviceIdentifier: ").Append(DeviceIdentifier).Append("\n");
            sb.Append("  DpanIdentifier: ").Append(DpanIdentifier).Append("\n");
            sb.Append("  TransactionIdentifier: ").Append(TransactionIdentifier).Append("\n");
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
            return this.Equals(input as AlipayTradeApplepayAuthenticationSubmitModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeApplepayAuthenticationSubmitModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeApplepayAuthenticationSubmitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeApplepayAuthenticationSubmitModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationResults == input.AuthenticationResults ||
                    this.AuthenticationResults != null &&
                    input.AuthenticationResults != null &&
                    this.AuthenticationResults.SequenceEqual(input.AuthenticationResults)
                ) && 
                (
                    this.DeviceIdentifier == input.DeviceIdentifier ||
                    (this.DeviceIdentifier != null &&
                    this.DeviceIdentifier.Equals(input.DeviceIdentifier))
                ) && 
                (
                    this.DpanIdentifier == input.DpanIdentifier ||
                    (this.DpanIdentifier != null &&
                    this.DpanIdentifier.Equals(input.DpanIdentifier))
                ) && 
                (
                    this.TransactionIdentifier == input.TransactionIdentifier ||
                    (this.TransactionIdentifier != null &&
                    this.TransactionIdentifier.Equals(input.TransactionIdentifier))
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
                if (this.AuthenticationResults != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationResults.GetHashCode();
                }
                if (this.DeviceIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceIdentifier.GetHashCode();
                }
                if (this.DpanIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.DpanIdentifier.GetHashCode();
                }
                if (this.TransactionIdentifier != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionIdentifier.GetHashCode();
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
