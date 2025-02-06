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
    /// AlipayOfflineMaterialImageUploadModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMaterialImageUploadModel")]
    public partial class AlipayOfflineMaterialImageUploadModel : IEquatable<AlipayOfflineMaterialImageUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMaterialImageUploadModel" /> class.
        /// </summary>
        /// <param name="imageName">图片/视频名称.</param>
        /// <param name="imagePid">用于显示指定图片/视频所属的partnerId（支付宝内部使用，外部商户无需填写此字段）.</param>
        /// <param name="imageType">图片/视频格式.</param>
        public AlipayOfflineMaterialImageUploadModel(string imageName = default(string), string imagePid = default(string), string imageType = default(string))
        {
            this.ImageName = imageName;
            this.ImagePid = imagePid;
            this.ImageType = imageType;
        }

        /// <summary>
        /// 图片/视频名称
        /// </summary>
        /// <value>图片/视频名称</value>
        [DataMember(Name = "image_name", EmitDefaultValue = false)]
        public string ImageName { get; set; }

        /// <summary>
        /// 用于显示指定图片/视频所属的partnerId（支付宝内部使用，外部商户无需填写此字段）
        /// </summary>
        /// <value>用于显示指定图片/视频所属的partnerId（支付宝内部使用，外部商户无需填写此字段）</value>
        [DataMember(Name = "image_pid", EmitDefaultValue = false)]
        public string ImagePid { get; set; }

        /// <summary>
        /// 图片/视频格式
        /// </summary>
        /// <value>图片/视频格式</value>
        [DataMember(Name = "image_type", EmitDefaultValue = false)]
        public string ImageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMaterialImageUploadModel {\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  ImagePid: ").Append(ImagePid).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
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
            return this.Equals(input as AlipayOfflineMaterialImageUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMaterialImageUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMaterialImageUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMaterialImageUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ImagePid == input.ImagePid ||
                    (this.ImagePid != null &&
                    this.ImagePid.Equals(input.ImagePid))
                ) && 
                (
                    this.ImageType == input.ImageType ||
                    (this.ImageType != null &&
                    this.ImageType.Equals(input.ImageType))
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
                if (this.ImageName != null)
                {
                    hashCode = (hashCode * 59) + this.ImageName.GetHashCode();
                }
                if (this.ImagePid != null)
                {
                    hashCode = (hashCode * 59) + this.ImagePid.GetHashCode();
                }
                if (this.ImageType != null)
                {
                    hashCode = (hashCode * 59) + this.ImageType.GetHashCode();
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
