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
    /// SearchBoxActivityVideoInfo
    /// </summary>
    [DataContract(Name = "SearchBoxActivityVideoInfo")]
    public partial class SearchBoxActivityVideoInfo : IEquatable<SearchBoxActivityVideoInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBoxActivityVideoInfo" /> class.
        /// </summary>
        /// <param name="videoBtnText">视频按钮文案，2-4个汉字.</param>
        /// <param name="videoCoverimgId">视频封面图片id，图片id可以通过调用接口alipay.open.file.upload上传图片，获取图片id。图片规范：https://opendocs.alipay.com/mini/operation/atmospheredesign.</param>
        /// <param name="videoSubTitle">视频副标题，2-16个汉字.</param>
        /// <param name="videoTitle">视频主标题，2-10个汉字.</param>
        public SearchBoxActivityVideoInfo(string videoBtnText = default(string), string videoCoverimgId = default(string), string videoSubTitle = default(string), string videoTitle = default(string))
        {
            this.VideoBtnText = videoBtnText;
            this.VideoCoverimgId = videoCoverimgId;
            this.VideoSubTitle = videoSubTitle;
            this.VideoTitle = videoTitle;
        }

        /// <summary>
        /// 视频按钮文案，2-4个汉字
        /// </summary>
        /// <value>视频按钮文案，2-4个汉字</value>
        [DataMember(Name = "video_btn_text", EmitDefaultValue = false)]
        public string VideoBtnText { get; set; }

        /// <summary>
        /// 视频封面图片id，图片id可以通过调用接口alipay.open.file.upload上传图片，获取图片id。图片规范：https://opendocs.alipay.com/mini/operation/atmospheredesign
        /// </summary>
        /// <value>视频封面图片id，图片id可以通过调用接口alipay.open.file.upload上传图片，获取图片id。图片规范：https://opendocs.alipay.com/mini/operation/atmospheredesign</value>
        [DataMember(Name = "video_coverimg_id", EmitDefaultValue = false)]
        public string VideoCoverimgId { get; set; }

        /// <summary>
        /// 视频副标题，2-16个汉字
        /// </summary>
        /// <value>视频副标题，2-16个汉字</value>
        [DataMember(Name = "video_sub_title", EmitDefaultValue = false)]
        public string VideoSubTitle { get; set; }

        /// <summary>
        /// 视频主标题，2-10个汉字
        /// </summary>
        /// <value>视频主标题，2-10个汉字</value>
        [DataMember(Name = "video_title", EmitDefaultValue = false)]
        public string VideoTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBoxActivityVideoInfo {\n");
            sb.Append("  VideoBtnText: ").Append(VideoBtnText).Append("\n");
            sb.Append("  VideoCoverimgId: ").Append(VideoCoverimgId).Append("\n");
            sb.Append("  VideoSubTitle: ").Append(VideoSubTitle).Append("\n");
            sb.Append("  VideoTitle: ").Append(VideoTitle).Append("\n");
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
            return this.Equals(input as SearchBoxActivityVideoInfo);
        }

        /// <summary>
        /// Returns true if SearchBoxActivityVideoInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBoxActivityVideoInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBoxActivityVideoInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VideoBtnText == input.VideoBtnText ||
                    (this.VideoBtnText != null &&
                    this.VideoBtnText.Equals(input.VideoBtnText))
                ) && 
                (
                    this.VideoCoverimgId == input.VideoCoverimgId ||
                    (this.VideoCoverimgId != null &&
                    this.VideoCoverimgId.Equals(input.VideoCoverimgId))
                ) && 
                (
                    this.VideoSubTitle == input.VideoSubTitle ||
                    (this.VideoSubTitle != null &&
                    this.VideoSubTitle.Equals(input.VideoSubTitle))
                ) && 
                (
                    this.VideoTitle == input.VideoTitle ||
                    (this.VideoTitle != null &&
                    this.VideoTitle.Equals(input.VideoTitle))
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
                if (this.VideoBtnText != null)
                {
                    hashCode = (hashCode * 59) + this.VideoBtnText.GetHashCode();
                }
                if (this.VideoCoverimgId != null)
                {
                    hashCode = (hashCode * 59) + this.VideoCoverimgId.GetHashCode();
                }
                if (this.VideoSubTitle != null)
                {
                    hashCode = (hashCode * 59) + this.VideoSubTitle.GetHashCode();
                }
                if (this.VideoTitle != null)
                {
                    hashCode = (hashCode * 59) + this.VideoTitle.GetHashCode();
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
