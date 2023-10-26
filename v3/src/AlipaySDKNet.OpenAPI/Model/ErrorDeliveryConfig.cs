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
    /// ErrorDeliveryConfig
    /// </summary>
    [DataContract(Name = "ErrorDeliveryConfig")]
    public partial class ErrorDeliveryConfig : IEquatable<ErrorDeliveryConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDeliveryConfig" /> class.
        /// </summary>
        /// <param name="deliveryConfig">deliveryConfig.</param>
        /// <param name="errorCode">错误码。针对单个投放，具体的错误原因。.</param>
        /// <param name="errorMsg">详细的投放错误信息。用于判断具体的错误信息。.</param>
        public ErrorDeliveryConfig(DeliveryConfig deliveryConfig = default(DeliveryConfig), string errorCode = default(string), string errorMsg = default(string))
        {
            this.DeliveryConfig = deliveryConfig;
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
        }

        /// <summary>
        /// Gets or Sets DeliveryConfig
        /// </summary>
        [DataMember(Name = "delivery_config", EmitDefaultValue = false)]
        public DeliveryConfig DeliveryConfig { get; set; }

        /// <summary>
        /// 错误码。针对单个投放，具体的错误原因。
        /// </summary>
        /// <value>错误码。针对单个投放，具体的错误原因。</value>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 详细的投放错误信息。用于判断具体的错误信息。
        /// </summary>
        /// <value>详细的投放错误信息。用于判断具体的错误信息。</value>
        [DataMember(Name = "error_msg", EmitDefaultValue = false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorDeliveryConfig {\n");
            sb.Append("  DeliveryConfig: ").Append(DeliveryConfig).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
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
            return this.Equals(input as ErrorDeliveryConfig);
        }

        /// <summary>
        /// Returns true if ErrorDeliveryConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorDeliveryConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDeliveryConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryConfig == input.DeliveryConfig ||
                    (this.DeliveryConfig != null &&
                    this.DeliveryConfig.Equals(input.DeliveryConfig))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
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
                if (this.DeliveryConfig != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryConfig.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.ErrorMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMsg.GetHashCode();
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
