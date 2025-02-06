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
    /// ZhimaMerchantZmgoTemplateQueryResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaMerchantZmgoTemplateQueryResponseModel")]
    public partial class ZhimaMerchantZmgoTemplateQueryResponseModel : IEquatable<ZhimaMerchantZmgoTemplateQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoTemplateQueryResponseModel" /> class.
        /// </summary>
        /// <param name="basicConfig">basicConfig.</param>
        /// <param name="extConfig">extConfig.</param>
        /// <param name="obligationConfig">obligationConfig.</param>
        /// <param name="openConfig">openConfig.</param>
        /// <param name="quitConfig">quitConfig.</param>
        /// <param name="rightConfig">rightConfig.</param>
        /// <param name="settlementConfig">settlementConfig.</param>
        public ZhimaMerchantZmgoTemplateQueryResponseModel(ZMGOBasicConfig basicConfig = default(ZMGOBasicConfig), ZMGOExtConfig extConfig = default(ZMGOExtConfig), ZMGOObligationConfig obligationConfig = default(ZMGOObligationConfig), ZMGOOpenConfig openConfig = default(ZMGOOpenConfig), ZMGOQuitConfig quitConfig = default(ZMGOQuitConfig), ZMGORightConfig rightConfig = default(ZMGORightConfig), ZMGOSettlementConfig settlementConfig = default(ZMGOSettlementConfig))
        {
            this.BasicConfig = basicConfig;
            this.ExtConfig = extConfig;
            this.ObligationConfig = obligationConfig;
            this.OpenConfig = openConfig;
            this.QuitConfig = quitConfig;
            this.RightConfig = rightConfig;
            this.SettlementConfig = settlementConfig;
        }

        /// <summary>
        /// Gets or Sets BasicConfig
        /// </summary>
        [DataMember(Name = "basic_config", EmitDefaultValue = false)]
        public ZMGOBasicConfig BasicConfig { get; set; }

        /// <summary>
        /// Gets or Sets ExtConfig
        /// </summary>
        [DataMember(Name = "ext_config", EmitDefaultValue = false)]
        public ZMGOExtConfig ExtConfig { get; set; }

        /// <summary>
        /// Gets or Sets ObligationConfig
        /// </summary>
        [DataMember(Name = "obligation_config", EmitDefaultValue = false)]
        public ZMGOObligationConfig ObligationConfig { get; set; }

        /// <summary>
        /// Gets or Sets OpenConfig
        /// </summary>
        [DataMember(Name = "open_config", EmitDefaultValue = false)]
        public ZMGOOpenConfig OpenConfig { get; set; }

        /// <summary>
        /// Gets or Sets QuitConfig
        /// </summary>
        [DataMember(Name = "quit_config", EmitDefaultValue = false)]
        public ZMGOQuitConfig QuitConfig { get; set; }

        /// <summary>
        /// Gets or Sets RightConfig
        /// </summary>
        [DataMember(Name = "right_config", EmitDefaultValue = false)]
        public ZMGORightConfig RightConfig { get; set; }

        /// <summary>
        /// Gets or Sets SettlementConfig
        /// </summary>
        [DataMember(Name = "settlement_config", EmitDefaultValue = false)]
        public ZMGOSettlementConfig SettlementConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaMerchantZmgoTemplateQueryResponseModel {\n");
            sb.Append("  BasicConfig: ").Append(BasicConfig).Append("\n");
            sb.Append("  ExtConfig: ").Append(ExtConfig).Append("\n");
            sb.Append("  ObligationConfig: ").Append(ObligationConfig).Append("\n");
            sb.Append("  OpenConfig: ").Append(OpenConfig).Append("\n");
            sb.Append("  QuitConfig: ").Append(QuitConfig).Append("\n");
            sb.Append("  RightConfig: ").Append(RightConfig).Append("\n");
            sb.Append("  SettlementConfig: ").Append(SettlementConfig).Append("\n");
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
            return this.Equals(input as ZhimaMerchantZmgoTemplateQueryResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaMerchantZmgoTemplateQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaMerchantZmgoTemplateQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaMerchantZmgoTemplateQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BasicConfig == input.BasicConfig ||
                    (this.BasicConfig != null &&
                    this.BasicConfig.Equals(input.BasicConfig))
                ) && 
                (
                    this.ExtConfig == input.ExtConfig ||
                    (this.ExtConfig != null &&
                    this.ExtConfig.Equals(input.ExtConfig))
                ) && 
                (
                    this.ObligationConfig == input.ObligationConfig ||
                    (this.ObligationConfig != null &&
                    this.ObligationConfig.Equals(input.ObligationConfig))
                ) && 
                (
                    this.OpenConfig == input.OpenConfig ||
                    (this.OpenConfig != null &&
                    this.OpenConfig.Equals(input.OpenConfig))
                ) && 
                (
                    this.QuitConfig == input.QuitConfig ||
                    (this.QuitConfig != null &&
                    this.QuitConfig.Equals(input.QuitConfig))
                ) && 
                (
                    this.RightConfig == input.RightConfig ||
                    (this.RightConfig != null &&
                    this.RightConfig.Equals(input.RightConfig))
                ) && 
                (
                    this.SettlementConfig == input.SettlementConfig ||
                    (this.SettlementConfig != null &&
                    this.SettlementConfig.Equals(input.SettlementConfig))
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
                if (this.BasicConfig != null)
                {
                    hashCode = (hashCode * 59) + this.BasicConfig.GetHashCode();
                }
                if (this.ExtConfig != null)
                {
                    hashCode = (hashCode * 59) + this.ExtConfig.GetHashCode();
                }
                if (this.ObligationConfig != null)
                {
                    hashCode = (hashCode * 59) + this.ObligationConfig.GetHashCode();
                }
                if (this.OpenConfig != null)
                {
                    hashCode = (hashCode * 59) + this.OpenConfig.GetHashCode();
                }
                if (this.QuitConfig != null)
                {
                    hashCode = (hashCode * 59) + this.QuitConfig.GetHashCode();
                }
                if (this.RightConfig != null)
                {
                    hashCode = (hashCode * 59) + this.RightConfig.GetHashCode();
                }
                if (this.SettlementConfig != null)
                {
                    hashCode = (hashCode * 59) + this.SettlementConfig.GetHashCode();
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
