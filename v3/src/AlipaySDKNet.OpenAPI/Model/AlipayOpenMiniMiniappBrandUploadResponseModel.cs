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
    /// AlipayOpenMiniMiniappBrandUploadResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniMiniappBrandUploadResponseModel")]
    public partial class AlipayOpenMiniMiniappBrandUploadResponseModel : IEquatable<AlipayOpenMiniMiniappBrandUploadResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniMiniappBrandUploadResponseModel" /> class.
        /// </summary>
        /// <param name="fileKey">图片上传成功后的图片存储键(可用于填写调用alipay.open.mini.miniapp.brand.submit时需要的图片类型的字段).</param>
        public AlipayOpenMiniMiniappBrandUploadResponseModel(string fileKey = default(string))
        {
            this.FileKey = fileKey;
        }

        /// <summary>
        /// 图片上传成功后的图片存储键(可用于填写调用alipay.open.mini.miniapp.brand.submit时需要的图片类型的字段)
        /// </summary>
        /// <value>图片上传成功后的图片存储键(可用于填写调用alipay.open.mini.miniapp.brand.submit时需要的图片类型的字段)</value>
        [DataMember(Name = "file_key", EmitDefaultValue = false)]
        public string FileKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniMiniappBrandUploadResponseModel {\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniMiniappBrandUploadResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniMiniappBrandUploadResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniMiniappBrandUploadResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniMiniappBrandUploadResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileKey == input.FileKey ||
                    (this.FileKey != null &&
                    this.FileKey.Equals(input.FileKey))
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
                if (this.FileKey != null)
                {
                    hashCode = (hashCode * 59) + this.FileKey.GetHashCode();
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
