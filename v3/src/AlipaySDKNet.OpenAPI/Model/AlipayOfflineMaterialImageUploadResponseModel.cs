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
    /// AlipayOfflineMaterialImageUploadResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMaterialImageUploadResponseModel")]
    public partial class AlipayOfflineMaterialImageUploadResponseModel : IEquatable<AlipayOfflineMaterialImageUploadResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMaterialImageUploadResponseModel" /> class.
        /// </summary>
        /// <param name="imageId">图片/视频在商家中心的唯一标识.</param>
        /// <param name="imageUrl">图片/视频的访问地址（为了防止盗链，该地址不允许嵌在其他页面展示，只能在新页面展示）.</param>
        public AlipayOfflineMaterialImageUploadResponseModel(string imageId = default(string), string imageUrl = default(string))
        {
            this.ImageId = imageId;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// 图片/视频在商家中心的唯一标识
        /// </summary>
        /// <value>图片/视频在商家中心的唯一标识</value>
        [DataMember(Name = "image_id", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// 图片/视频的访问地址（为了防止盗链，该地址不允许嵌在其他页面展示，只能在新页面展示）
        /// </summary>
        /// <value>图片/视频的访问地址（为了防止盗链，该地址不允许嵌在其他页面展示，只能在新页面展示）</value>
        [DataMember(Name = "image_url", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMaterialImageUploadResponseModel {\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
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
            return this.Equals(input as AlipayOfflineMaterialImageUploadResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMaterialImageUploadResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMaterialImageUploadResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMaterialImageUploadResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.ImageId != null)
                {
                    hashCode = (hashCode * 59) + this.ImageId.GetHashCode();
                }
                if (this.ImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImageUrl.GetHashCode();
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
