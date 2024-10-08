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
    /// AlipayMarketingActivityVoucherPublishResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityVoucherPublishResponseModel")]
    public partial class AlipayMarketingActivityVoucherPublishResponseModel : IEquatable<AlipayMarketingActivityVoucherPublishResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityVoucherPublishResponseModel" /> class.
        /// </summary>
        /// <param name="rechargeUrl">预充值链接.</param>
        public AlipayMarketingActivityVoucherPublishResponseModel(string rechargeUrl = default(string))
        {
            this.RechargeUrl = rechargeUrl;
        }

        /// <summary>
        /// 预充值链接
        /// </summary>
        /// <value>预充值链接</value>
        [DataMember(Name = "recharge_url", EmitDefaultValue = false)]
        public string RechargeUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityVoucherPublishResponseModel {\n");
            sb.Append("  RechargeUrl: ").Append(RechargeUrl).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityVoucherPublishResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityVoucherPublishResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityVoucherPublishResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityVoucherPublishResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RechargeUrl == input.RechargeUrl ||
                    (this.RechargeUrl != null &&
                    this.RechargeUrl.Equals(input.RechargeUrl))
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
                if (this.RechargeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RechargeUrl.GetHashCode();
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
