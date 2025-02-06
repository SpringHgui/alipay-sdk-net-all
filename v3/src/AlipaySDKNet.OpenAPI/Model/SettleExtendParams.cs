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
    /// SettleExtendParams
    /// </summary>
    [DataContract(Name = "SettleExtendParams")]
    public partial class SettleExtendParams : IEquatable<SettleExtendParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettleExtendParams" /> class.
        /// </summary>
        /// <param name="royaltyFinish">\&quot;冻结分账场景下生效，其他场景传入无效。代表该交易分账是否完结，可选值：true/false，不传默认为false。true：代表分账完结，则本次分账处理完成后会把该笔交易的剩余冻结金额全额解冻。false：代表分账未完结。\&quot;.</param>
        public SettleExtendParams(string royaltyFinish = default(string))
        {
            this.RoyaltyFinish = royaltyFinish;
        }

        /// <summary>
        /// \&quot;冻结分账场景下生效，其他场景传入无效。代表该交易分账是否完结，可选值：true/false，不传默认为false。true：代表分账完结，则本次分账处理完成后会把该笔交易的剩余冻结金额全额解冻。false：代表分账未完结。\&quot;
        /// </summary>
        /// <value>\&quot;冻结分账场景下生效，其他场景传入无效。代表该交易分账是否完结，可选值：true/false，不传默认为false。true：代表分账完结，则本次分账处理完成后会把该笔交易的剩余冻结金额全额解冻。false：代表分账未完结。\&quot;</value>
        [DataMember(Name = "royalty_finish", EmitDefaultValue = false)]
        public string RoyaltyFinish { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettleExtendParams {\n");
            sb.Append("  RoyaltyFinish: ").Append(RoyaltyFinish).Append("\n");
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
            return this.Equals(input as SettleExtendParams);
        }

        /// <summary>
        /// Returns true if SettleExtendParams instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleExtendParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleExtendParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoyaltyFinish == input.RoyaltyFinish ||
                    (this.RoyaltyFinish != null &&
                    this.RoyaltyFinish.Equals(input.RoyaltyFinish))
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
                if (this.RoyaltyFinish != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyFinish.GetHashCode();
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
