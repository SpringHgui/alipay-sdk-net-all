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
    /// IndirectQualificationInfo
    /// </summary>
    [DataContract(Name = "IndirectQualificationInfo")]
    public partial class IndirectQualificationInfo : IEquatable<IndirectQualificationInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndirectQualificationInfo" /> class.
        /// </summary>
        /// <param name="imageList">行业经营许可证资质照片，一个行业类目下最多上传6张资质照片（使用图片上传接口）.</param>
        /// <param name="mccCode">行业类目编号，支付宝商家行业二级类目code.</param>
        public IndirectQualificationInfo(List<string> imageList = default(List<string>), string mccCode = default(string))
        {
            this.ImageList = imageList;
            this.MccCode = mccCode;
        }

        /// <summary>
        /// 行业经营许可证资质照片，一个行业类目下最多上传6张资质照片（使用图片上传接口）
        /// </summary>
        /// <value>行业经营许可证资质照片，一个行业类目下最多上传6张资质照片（使用图片上传接口）</value>
        [DataMember(Name = "image_list", EmitDefaultValue = false)]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 行业类目编号，支付宝商家行业二级类目code
        /// </summary>
        /// <value>行业类目编号，支付宝商家行业二级类目code</value>
        [DataMember(Name = "mcc_code", EmitDefaultValue = false)]
        public string MccCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IndirectQualificationInfo {\n");
            sb.Append("  ImageList: ").Append(ImageList).Append("\n");
            sb.Append("  MccCode: ").Append(MccCode).Append("\n");
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
            return this.Equals(input as IndirectQualificationInfo);
        }

        /// <summary>
        /// Returns true if IndirectQualificationInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of IndirectQualificationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndirectQualificationInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImageList == input.ImageList ||
                    this.ImageList != null &&
                    input.ImageList != null &&
                    this.ImageList.SequenceEqual(input.ImageList)
                ) && 
                (
                    this.MccCode == input.MccCode ||
                    (this.MccCode != null &&
                    this.MccCode.Equals(input.MccCode))
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
                if (this.ImageList != null)
                {
                    hashCode = (hashCode * 59) + this.ImageList.GetHashCode();
                }
                if (this.MccCode != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode.GetHashCode();
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
