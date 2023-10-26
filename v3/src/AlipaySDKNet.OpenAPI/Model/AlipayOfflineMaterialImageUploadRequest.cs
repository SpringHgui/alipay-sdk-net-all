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
    /// AlipayOfflineMaterialImageUploadRequest
    /// </summary>
    [DataContract(Name = "alipay_offline_material_image_upload_request")]
    public partial class AlipayOfflineMaterialImageUploadRequest : IEquatable<AlipayOfflineMaterialImageUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMaterialImageUploadRequest" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="imageContent">imageContent.</param>
        public AlipayOfflineMaterialImageUploadRequest(AlipayOfflineMaterialImageUploadModel data = default(AlipayOfflineMaterialImageUploadModel), System.IO.Stream imageContent = default(System.IO.Stream))
        {
            this.Data = data;
            this.ImageContent = imageContent;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AlipayOfflineMaterialImageUploadModel Data { get; set; }

        /// <summary>
        /// Gets or Sets ImageContent
        /// </summary>
        [DataMember(Name = "image_content", EmitDefaultValue = false)]
        public System.IO.Stream ImageContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMaterialImageUploadRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  ImageContent: ").Append(ImageContent).Append("\n");
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
            return this.Equals(input as AlipayOfflineMaterialImageUploadRequest);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMaterialImageUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMaterialImageUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMaterialImageUploadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.ImageContent == input.ImageContent ||
                    (this.ImageContent != null &&
                    this.ImageContent.Equals(input.ImageContent))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.ImageContent != null)
                {
                    hashCode = (hashCode * 59) + this.ImageContent.GetHashCode();
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
