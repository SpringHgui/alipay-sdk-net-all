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
    /// DeliverySingleMaterial
    /// </summary>
    [DataContract(Name = "DeliverySingleMaterial")]
    public partial class DeliverySingleMaterial : IEquatable<DeliverySingleMaterial>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverySingleMaterial" /> class.
        /// </summary>
        /// <param name="deliveryImage">投放计划图片素材。通过接口alipay.marketing.material.image.upload上传图片返回的resource_id。.</param>
        public DeliverySingleMaterial(string deliveryImage = default(string))
        {
            this.DeliveryImage = deliveryImage;
        }

        /// <summary>
        /// 投放计划图片素材。通过接口alipay.marketing.material.image.upload上传图片返回的resource_id。
        /// </summary>
        /// <value>投放计划图片素材。通过接口alipay.marketing.material.image.upload上传图片返回的resource_id。</value>
        [DataMember(Name = "delivery_image", EmitDefaultValue = false)]
        public string DeliveryImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliverySingleMaterial {\n");
            sb.Append("  DeliveryImage: ").Append(DeliveryImage).Append("\n");
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
            return this.Equals(input as DeliverySingleMaterial);
        }

        /// <summary>
        /// Returns true if DeliverySingleMaterial instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliverySingleMaterial to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliverySingleMaterial input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryImage == input.DeliveryImage ||
                    (this.DeliveryImage != null &&
                    this.DeliveryImage.Equals(input.DeliveryImage))
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
                if (this.DeliveryImage != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryImage.GetHashCode();
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
