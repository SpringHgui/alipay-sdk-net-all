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
    /// AlipayMerchantImageUploadResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantImageUploadResponseModel")]
    public partial class AlipayMerchantImageUploadResponseModel : IEquatable<AlipayMerchantImageUploadResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantImageUploadResponseModel" /> class.
        /// </summary>
        /// <param name="imageId">图片在文件存储平台的标识.</param>
        public AlipayMerchantImageUploadResponseModel(string imageId = default(string))
        {
            this.ImageId = imageId;
        }

        /// <summary>
        /// 图片在文件存储平台的标识
        /// </summary>
        /// <value>图片在文件存储平台的标识</value>
        [DataMember(Name = "image_id", EmitDefaultValue = false)]
        public string ImageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantImageUploadResponseModel {\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
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
            return this.Equals(input as AlipayMerchantImageUploadResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantImageUploadResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantImageUploadResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantImageUploadResponseModel input)
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
