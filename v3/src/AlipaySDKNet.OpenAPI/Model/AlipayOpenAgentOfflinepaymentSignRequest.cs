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
    /// AlipayOpenAgentOfflinepaymentSignRequest
    /// </summary>
    [DataContract(Name = "alipay_open_agent_offlinepayment_sign_request")]
    public partial class AlipayOpenAgentOfflinepaymentSignRequest : IEquatable<AlipayOpenAgentOfflinepaymentSignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentOfflinepaymentSignRequest" /> class.
        /// </summary>
        /// <param name="businessLicensePic">businessLicensePic.</param>
        /// <param name="data">data.</param>
        /// <param name="shopScenePic">shopScenePic.</param>
        /// <param name="shopSignBoardPic">shopSignBoardPic.</param>
        /// <param name="specialLicensePic">specialLicensePic.</param>
        public AlipayOpenAgentOfflinepaymentSignRequest(System.IO.Stream businessLicensePic = default(System.IO.Stream), AlipayOpenAgentOfflinepaymentSignModel data = default(AlipayOpenAgentOfflinepaymentSignModel), System.IO.Stream shopScenePic = default(System.IO.Stream), System.IO.Stream shopSignBoardPic = default(System.IO.Stream), System.IO.Stream specialLicensePic = default(System.IO.Stream))
        {
            this.BusinessLicensePic = businessLicensePic;
            this.Data = data;
            this.ShopScenePic = shopScenePic;
            this.ShopSignBoardPic = shopSignBoardPic;
            this.SpecialLicensePic = specialLicensePic;
        }

        /// <summary>
        /// Gets or Sets BusinessLicensePic
        /// </summary>
        [DataMember(Name = "business_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream BusinessLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AlipayOpenAgentOfflinepaymentSignModel Data { get; set; }

        /// <summary>
        /// Gets or Sets ShopScenePic
        /// </summary>
        [DataMember(Name = "shop_scene_pic", EmitDefaultValue = false)]
        public System.IO.Stream ShopScenePic { get; set; }

        /// <summary>
        /// Gets or Sets ShopSignBoardPic
        /// </summary>
        [DataMember(Name = "shop_sign_board_pic", EmitDefaultValue = false)]
        public System.IO.Stream ShopSignBoardPic { get; set; }

        /// <summary>
        /// Gets or Sets SpecialLicensePic
        /// </summary>
        [DataMember(Name = "special_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream SpecialLicensePic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentOfflinepaymentSignRequest {\n");
            sb.Append("  BusinessLicensePic: ").Append(BusinessLicensePic).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ShopScenePic: ").Append(ShopScenePic).Append("\n");
            sb.Append("  ShopSignBoardPic: ").Append(ShopSignBoardPic).Append("\n");
            sb.Append("  SpecialLicensePic: ").Append(SpecialLicensePic).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentOfflinepaymentSignRequest);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentOfflinepaymentSignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentOfflinepaymentSignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentOfflinepaymentSignRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessLicensePic == input.BusinessLicensePic ||
                    (this.BusinessLicensePic != null &&
                    this.BusinessLicensePic.Equals(input.BusinessLicensePic))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.ShopScenePic == input.ShopScenePic ||
                    (this.ShopScenePic != null &&
                    this.ShopScenePic.Equals(input.ShopScenePic))
                ) && 
                (
                    this.ShopSignBoardPic == input.ShopSignBoardPic ||
                    (this.ShopSignBoardPic != null &&
                    this.ShopSignBoardPic.Equals(input.ShopSignBoardPic))
                ) && 
                (
                    this.SpecialLicensePic == input.SpecialLicensePic ||
                    (this.SpecialLicensePic != null &&
                    this.SpecialLicensePic.Equals(input.SpecialLicensePic))
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
                if (this.BusinessLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicensePic.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.ShopScenePic != null)
                {
                    hashCode = (hashCode * 59) + this.ShopScenePic.GetHashCode();
                }
                if (this.ShopSignBoardPic != null)
                {
                    hashCode = (hashCode * 59) + this.ShopSignBoardPic.GetHashCode();
                }
                if (this.SpecialLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialLicensePic.GetHashCode();
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
