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
    /// PaidOuterCardExtraInfoDTO
    /// </summary>
    [DataContract(Name = "PaidOuterCardExtraInfoDTO")]
    public partial class PaidOuterCardExtraInfoDTO : IEquatable<PaidOuterCardExtraInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaidOuterCardExtraInfoDTO" /> class.
        /// </summary>
        /// <param name="action">用户操作类型.</param>
        /// <param name="cycleInfo">cycleInfo.</param>
        /// <param name="purchaseInfo">purchaseInfo.</param>
        public PaidOuterCardExtraInfoDTO(string action = default(string), PaidOuterCardCycleInfoDTO cycleInfo = default(PaidOuterCardCycleInfoDTO), PaidOuterCardPurchaseInfoDTO purchaseInfo = default(PaidOuterCardPurchaseInfoDTO))
        {
            this.Action = action;
            this.CycleInfo = cycleInfo;
            this.PurchaseInfo = purchaseInfo;
        }

        /// <summary>
        /// 用户操作类型
        /// </summary>
        /// <value>用户操作类型</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets CycleInfo
        /// </summary>
        [DataMember(Name = "cycle_info", EmitDefaultValue = false)]
        public PaidOuterCardCycleInfoDTO CycleInfo { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseInfo
        /// </summary>
        [DataMember(Name = "purchase_info", EmitDefaultValue = false)]
        public PaidOuterCardPurchaseInfoDTO PurchaseInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaidOuterCardExtraInfoDTO {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CycleInfo: ").Append(CycleInfo).Append("\n");
            sb.Append("  PurchaseInfo: ").Append(PurchaseInfo).Append("\n");
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
            return this.Equals(input as PaidOuterCardExtraInfoDTO);
        }

        /// <summary>
        /// Returns true if PaidOuterCardExtraInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PaidOuterCardExtraInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaidOuterCardExtraInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.CycleInfo == input.CycleInfo ||
                    (this.CycleInfo != null &&
                    this.CycleInfo.Equals(input.CycleInfo))
                ) && 
                (
                    this.PurchaseInfo == input.PurchaseInfo ||
                    (this.PurchaseInfo != null &&
                    this.PurchaseInfo.Equals(input.PurchaseInfo))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.CycleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CycleInfo.GetHashCode();
                }
                if (this.PurchaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseInfo.GetHashCode();
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
