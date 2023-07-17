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
    /// InteligentMerchantPromo
    /// </summary>
    [DataContract(Name = "InteligentMerchantPromo")]
    public partial class InteligentMerchantPromo : IEquatable<InteligentMerchantPromo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentMerchantPromo" /> class.
        /// </summary>
        /// <param name="generalPromo">generalPromo.</param>
        /// <param name="promoType">子活动营销类型；枚举值：（GENERAL_MERCHANT：商户自运营活动）.</param>
        public InteligentMerchantPromo(InteligentGeneralMerchantPromo generalPromo = default(InteligentGeneralMerchantPromo), string promoType = default(string))
        {
            this.GeneralPromo = generalPromo;
            this.PromoType = promoType;
        }

        /// <summary>
        /// Gets or Sets GeneralPromo
        /// </summary>
        [DataMember(Name = "general_promo", EmitDefaultValue = false)]
        public InteligentGeneralMerchantPromo GeneralPromo { get; set; }

        /// <summary>
        /// 子活动营销类型；枚举值：（GENERAL_MERCHANT：商户自运营活动）
        /// </summary>
        /// <value>子活动营销类型；枚举值：（GENERAL_MERCHANT：商户自运营活动）</value>
        [DataMember(Name = "promo_type", EmitDefaultValue = false)]
        public string PromoType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentMerchantPromo {\n");
            sb.Append("  GeneralPromo: ").Append(GeneralPromo).Append("\n");
            sb.Append("  PromoType: ").Append(PromoType).Append("\n");
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
            return this.Equals(input as InteligentMerchantPromo);
        }

        /// <summary>
        /// Returns true if InteligentMerchantPromo instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentMerchantPromo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentMerchantPromo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GeneralPromo == input.GeneralPromo ||
                    (this.GeneralPromo != null &&
                    this.GeneralPromo.Equals(input.GeneralPromo))
                ) && 
                (
                    this.PromoType == input.PromoType ||
                    (this.PromoType != null &&
                    this.PromoType.Equals(input.PromoType))
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
                if (this.GeneralPromo != null)
                {
                    hashCode = (hashCode * 59) + this.GeneralPromo.GetHashCode();
                }
                if (this.PromoType != null)
                {
                    hashCode = (hashCode * 59) + this.PromoType.GetHashCode();
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
