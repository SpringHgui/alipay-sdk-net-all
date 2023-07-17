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
    /// AlipayTradeSettleReceivablesQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeSettleReceivablesQueryResponseModel")]
    public partial class AlipayTradeSettleReceivablesQueryResponseModel : IEquatable<AlipayTradeSettleReceivablesQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeSettleReceivablesQueryResponseModel" /> class.
        /// </summary>
        /// <param name="onSettleAmount">直付通请款模式下的结算在途金额，发起结算后 T+N 日到账场景下的处理中金额，人民币，单位为元.</param>
        /// <param name="unsettledAmount">待结算金额，人民币，单位为元.</param>
        public AlipayTradeSettleReceivablesQueryResponseModel(string onSettleAmount = default(string), string unsettledAmount = default(string))
        {
            this.OnSettleAmount = onSettleAmount;
            this.UnsettledAmount = unsettledAmount;
        }

        /// <summary>
        /// 直付通请款模式下的结算在途金额，发起结算后 T+N 日到账场景下的处理中金额，人民币，单位为元
        /// </summary>
        /// <value>直付通请款模式下的结算在途金额，发起结算后 T+N 日到账场景下的处理中金额，人民币，单位为元</value>
        [DataMember(Name = "on_settle_amount", EmitDefaultValue = false)]
        public string OnSettleAmount { get; set; }

        /// <summary>
        /// 待结算金额，人民币，单位为元
        /// </summary>
        /// <value>待结算金额，人民币，单位为元</value>
        [DataMember(Name = "unsettled_amount", EmitDefaultValue = false)]
        public string UnsettledAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeSettleReceivablesQueryResponseModel {\n");
            sb.Append("  OnSettleAmount: ").Append(OnSettleAmount).Append("\n");
            sb.Append("  UnsettledAmount: ").Append(UnsettledAmount).Append("\n");
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
            return this.Equals(input as AlipayTradeSettleReceivablesQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeSettleReceivablesQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeSettleReceivablesQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeSettleReceivablesQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OnSettleAmount == input.OnSettleAmount ||
                    (this.OnSettleAmount != null &&
                    this.OnSettleAmount.Equals(input.OnSettleAmount))
                ) && 
                (
                    this.UnsettledAmount == input.UnsettledAmount ||
                    (this.UnsettledAmount != null &&
                    this.UnsettledAmount.Equals(input.UnsettledAmount))
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
                if (this.OnSettleAmount != null)
                {
                    hashCode = (hashCode * 59) + this.OnSettleAmount.GetHashCode();
                }
                if (this.UnsettledAmount != null)
                {
                    hashCode = (hashCode * 59) + this.UnsettledAmount.GetHashCode();
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
