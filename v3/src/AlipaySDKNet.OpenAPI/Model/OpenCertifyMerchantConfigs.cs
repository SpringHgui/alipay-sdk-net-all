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
    /// OpenCertifyMerchantConfigs
    /// </summary>
    [DataContract(Name = "OpenCertifyMerchantConfigs")]
    public partial class OpenCertifyMerchantConfigs : IEquatable<OpenCertifyMerchantConfigs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenCertifyMerchantConfigs" /> class.
        /// </summary>
        /// <param name="faceReserveStrategy">不传默认为reserve.</param>
        /// <param name="returnUrl">认证成功后需要跳转的地址，一般为商户业务页面；若无跳转地址可填空字符\&quot;\&quot;。.</param>
        public OpenCertifyMerchantConfigs(string faceReserveStrategy = default(string), string returnUrl = default(string))
        {
            this.FaceReserveStrategy = faceReserveStrategy;
            this.ReturnUrl = returnUrl;
        }

        /// <summary>
        /// 不传默认为reserve
        /// </summary>
        /// <value>不传默认为reserve</value>
        [DataMember(Name = "face_reserve_strategy", EmitDefaultValue = false)]
        public string FaceReserveStrategy { get; set; }

        /// <summary>
        /// 认证成功后需要跳转的地址，一般为商户业务页面；若无跳转地址可填空字符\&quot;\&quot;。
        /// </summary>
        /// <value>认证成功后需要跳转的地址，一般为商户业务页面；若无跳转地址可填空字符\&quot;\&quot;。</value>
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenCertifyMerchantConfigs {\n");
            sb.Append("  FaceReserveStrategy: ").Append(FaceReserveStrategy).Append("\n");
            sb.Append("  ReturnUrl: ").Append(ReturnUrl).Append("\n");
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
            return this.Equals(input as OpenCertifyMerchantConfigs);
        }

        /// <summary>
        /// Returns true if OpenCertifyMerchantConfigs instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenCertifyMerchantConfigs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenCertifyMerchantConfigs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FaceReserveStrategy == input.FaceReserveStrategy ||
                    (this.FaceReserveStrategy != null &&
                    this.FaceReserveStrategy.Equals(input.FaceReserveStrategy))
                ) && 
                (
                    this.ReturnUrl == input.ReturnUrl ||
                    (this.ReturnUrl != null &&
                    this.ReturnUrl.Equals(input.ReturnUrl))
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
                if (this.FaceReserveStrategy != null)
                {
                    hashCode = (hashCode * 59) + this.FaceReserveStrategy.GetHashCode();
                }
                if (this.ReturnUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnUrl.GetHashCode();
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
