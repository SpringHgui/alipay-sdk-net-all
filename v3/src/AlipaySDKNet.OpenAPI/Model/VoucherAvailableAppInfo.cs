/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// VoucherAvailableAppInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableAppInfo")]
    public partial class VoucherAvailableAppInfo : IEquatable<VoucherAvailableAppInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableAppInfo" /> class.
        /// </summary>
        /// <param name="availableAppIds">可核销的支付宝小程序id.</param>
        public VoucherAvailableAppInfo(List<string> availableAppIds = default(List<string>))
        {
            this.AvailableAppIds = availableAppIds;
        }

        /// <summary>
        /// 可核销的支付宝小程序id
        /// </summary>
        /// <value>可核销的支付宝小程序id</value>
        [DataMember(Name = "available_app_ids", EmitDefaultValue = false)]
        public List<string> AvailableAppIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableAppInfo {\n");
            sb.Append("  AvailableAppIds: ").Append(AvailableAppIds).Append("\n");
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
            return this.Equals(input as VoucherAvailableAppInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableAppInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableAppInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableAppInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableAppIds == input.AvailableAppIds ||
                    this.AvailableAppIds != null &&
                    input.AvailableAppIds != null &&
                    this.AvailableAppIds.SequenceEqual(input.AvailableAppIds)
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
                if (this.AvailableAppIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableAppIds.GetHashCode();
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
