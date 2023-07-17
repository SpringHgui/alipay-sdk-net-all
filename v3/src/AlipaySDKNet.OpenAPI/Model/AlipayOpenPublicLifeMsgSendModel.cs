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
    /// AlipayOpenPublicLifeMsgSendModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicLifeMsgSendModel")]
    public partial class AlipayOpenPublicLifeMsgSendModel : IEquatable<AlipayOpenPublicLifeMsgSendModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicLifeMsgSendModel" /> class.
        /// </summary>
        /// <param name="category">消息分类，请传入对应分类编码值.</param>
        /// <param name="content">消息正文，html原文或纯文本.</param>
        /// <param name="desc">消息概述.</param>
        /// <param name="msgType">媒体资讯类生活号消息类型.</param>
        /// <param name="sourceExtInfo">消息来源方附属信息，供搜索、推荐使用  publish_time（int）：消息发布时间，单位秒  keyword_list（String）: 文章的标签列表，英文逗号分隔  comment（int）：消息来源处评论次数  reward（int）：消息来源处打赏次数  is_recommended（boolean）：消息在来源处是否被推荐  is_news（boolean）：消息是否实时性内容  read（int）：消息在来源处被阅读次数  like（int）：消息在来源处被点赞次数  is_hot（boolean）：消息在来源平台是否是热门内容  share（int）：文章在来源平台的分享次数  deadline（int）：文章的失效时间，单位秒.</param>
        /// <param name="title">消息标题.</param>
        /// <param name="uniqueMsgId">来源方消息唯一标识；若不为空，根据此id和生活号id对消息去重；若为空，不去重.</param>
        /// <param name="videoLength">生活号消息视频时长，单位：秒（视频类消息必填）.</param>
        /// <param name="videoSamples">视频类型消息中视频抽样关键帧截图，视频类消息选填.</param>
        /// <param name="videoSize">视频大小，单位：KB（视频类消息必填）.</param>
        /// <param name="videoSource">视频资源来源id（视频类消息必填），取值限定youku, miaopai, taobao, sina中的一个.</param>
        /// <param name="videoTemporaryUrl">视频的临时链接（优酷来源的视频消息，该字段不能为空）.</param>
        /// <param name="videoUrl">生活号视频类消息视频id或url（视频类消息必填，根据来源区分）.</param>
        public AlipayOpenPublicLifeMsgSendModel(string category = default(string), string content = default(string), string desc = default(string), string msgType = default(string), string sourceExtInfo = default(string), string title = default(string), string uniqueMsgId = default(string), string videoLength = default(string), List<string> videoSamples = default(List<string>), string videoSize = default(string), string videoSource = default(string), string videoTemporaryUrl = default(string), string videoUrl = default(string))
        {
            this.Category = category;
            this.Content = content;
            this.Desc = desc;
            this.MsgType = msgType;
            this.SourceExtInfo = sourceExtInfo;
            this.Title = title;
            this.UniqueMsgId = uniqueMsgId;
            this.VideoLength = videoLength;
            this.VideoSamples = videoSamples;
            this.VideoSize = videoSize;
            this.VideoSource = videoSource;
            this.VideoTemporaryUrl = videoTemporaryUrl;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// 消息分类，请传入对应分类编码值
        /// </summary>
        /// <value>消息分类，请传入对应分类编码值</value>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// 消息正文，html原文或纯文本
        /// </summary>
        /// <value>消息正文，html原文或纯文本</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 消息概述
        /// </summary>
        /// <value>消息概述</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// 媒体资讯类生活号消息类型
        /// </summary>
        /// <value>媒体资讯类生活号消息类型</value>
        [DataMember(Name = "msg_type", EmitDefaultValue = false)]
        public string MsgType { get; set; }

        /// <summary>
        /// 消息来源方附属信息，供搜索、推荐使用  publish_time（int）：消息发布时间，单位秒  keyword_list（String）: 文章的标签列表，英文逗号分隔  comment（int）：消息来源处评论次数  reward（int）：消息来源处打赏次数  is_recommended（boolean）：消息在来源处是否被推荐  is_news（boolean）：消息是否实时性内容  read（int）：消息在来源处被阅读次数  like（int）：消息在来源处被点赞次数  is_hot（boolean）：消息在来源平台是否是热门内容  share（int）：文章在来源平台的分享次数  deadline（int）：文章的失效时间，单位秒
        /// </summary>
        /// <value>消息来源方附属信息，供搜索、推荐使用  publish_time（int）：消息发布时间，单位秒  keyword_list（String）: 文章的标签列表，英文逗号分隔  comment（int）：消息来源处评论次数  reward（int）：消息来源处打赏次数  is_recommended（boolean）：消息在来源处是否被推荐  is_news（boolean）：消息是否实时性内容  read（int）：消息在来源处被阅读次数  like（int）：消息在来源处被点赞次数  is_hot（boolean）：消息在来源平台是否是热门内容  share（int）：文章在来源平台的分享次数  deadline（int）：文章的失效时间，单位秒</value>
        [DataMember(Name = "source_ext_info", EmitDefaultValue = false)]
        public string SourceExtInfo { get; set; }

        /// <summary>
        /// 消息标题
        /// </summary>
        /// <value>消息标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 来源方消息唯一标识；若不为空，根据此id和生活号id对消息去重；若为空，不去重
        /// </summary>
        /// <value>来源方消息唯一标识；若不为空，根据此id和生活号id对消息去重；若为空，不去重</value>
        [DataMember(Name = "unique_msg_id", EmitDefaultValue = false)]
        public string UniqueMsgId { get; set; }

        /// <summary>
        /// 生活号消息视频时长，单位：秒（视频类消息必填）
        /// </summary>
        /// <value>生活号消息视频时长，单位：秒（视频类消息必填）</value>
        [DataMember(Name = "video_length", EmitDefaultValue = false)]
        public string VideoLength { get; set; }

        /// <summary>
        /// 视频类型消息中视频抽样关键帧截图，视频类消息选填
        /// </summary>
        /// <value>视频类型消息中视频抽样关键帧截图，视频类消息选填</value>
        [DataMember(Name = "video_samples", EmitDefaultValue = false)]
        public List<string> VideoSamples { get; set; }

        /// <summary>
        /// 视频大小，单位：KB（视频类消息必填）
        /// </summary>
        /// <value>视频大小，单位：KB（视频类消息必填）</value>
        [DataMember(Name = "video_size", EmitDefaultValue = false)]
        public string VideoSize { get; set; }

        /// <summary>
        /// 视频资源来源id（视频类消息必填），取值限定youku, miaopai, taobao, sina中的一个
        /// </summary>
        /// <value>视频资源来源id（视频类消息必填），取值限定youku, miaopai, taobao, sina中的一个</value>
        [DataMember(Name = "video_source", EmitDefaultValue = false)]
        public string VideoSource { get; set; }

        /// <summary>
        /// 视频的临时链接（优酷来源的视频消息，该字段不能为空）
        /// </summary>
        /// <value>视频的临时链接（优酷来源的视频消息，该字段不能为空）</value>
        [DataMember(Name = "video_temporary_url", EmitDefaultValue = false)]
        public string VideoTemporaryUrl { get; set; }

        /// <summary>
        /// 生活号视频类消息视频id或url（视频类消息必填，根据来源区分）
        /// </summary>
        /// <value>生活号视频类消息视频id或url（视频类消息必填，根据来源区分）</value>
        [DataMember(Name = "video_url", EmitDefaultValue = false)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicLifeMsgSendModel {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  MsgType: ").Append(MsgType).Append("\n");
            sb.Append("  SourceExtInfo: ").Append(SourceExtInfo).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UniqueMsgId: ").Append(UniqueMsgId).Append("\n");
            sb.Append("  VideoLength: ").Append(VideoLength).Append("\n");
            sb.Append("  VideoSamples: ").Append(VideoSamples).Append("\n");
            sb.Append("  VideoSize: ").Append(VideoSize).Append("\n");
            sb.Append("  VideoSource: ").Append(VideoSource).Append("\n");
            sb.Append("  VideoTemporaryUrl: ").Append(VideoTemporaryUrl).Append("\n");
            sb.Append("  VideoUrl: ").Append(VideoUrl).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicLifeMsgSendModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicLifeMsgSendModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicLifeMsgSendModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicLifeMsgSendModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.MsgType == input.MsgType ||
                    (this.MsgType != null &&
                    this.MsgType.Equals(input.MsgType))
                ) && 
                (
                    this.SourceExtInfo == input.SourceExtInfo ||
                    (this.SourceExtInfo != null &&
                    this.SourceExtInfo.Equals(input.SourceExtInfo))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UniqueMsgId == input.UniqueMsgId ||
                    (this.UniqueMsgId != null &&
                    this.UniqueMsgId.Equals(input.UniqueMsgId))
                ) && 
                (
                    this.VideoLength == input.VideoLength ||
                    (this.VideoLength != null &&
                    this.VideoLength.Equals(input.VideoLength))
                ) && 
                (
                    this.VideoSamples == input.VideoSamples ||
                    this.VideoSamples != null &&
                    input.VideoSamples != null &&
                    this.VideoSamples.SequenceEqual(input.VideoSamples)
                ) && 
                (
                    this.VideoSize == input.VideoSize ||
                    (this.VideoSize != null &&
                    this.VideoSize.Equals(input.VideoSize))
                ) && 
                (
                    this.VideoSource == input.VideoSource ||
                    (this.VideoSource != null &&
                    this.VideoSource.Equals(input.VideoSource))
                ) && 
                (
                    this.VideoTemporaryUrl == input.VideoTemporaryUrl ||
                    (this.VideoTemporaryUrl != null &&
                    this.VideoTemporaryUrl.Equals(input.VideoTemporaryUrl))
                ) && 
                (
                    this.VideoUrl == input.VideoUrl ||
                    (this.VideoUrl != null &&
                    this.VideoUrl.Equals(input.VideoUrl))
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
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.MsgType != null)
                {
                    hashCode = (hashCode * 59) + this.MsgType.GetHashCode();
                }
                if (this.SourceExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SourceExtInfo.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.UniqueMsgId != null)
                {
                    hashCode = (hashCode * 59) + this.UniqueMsgId.GetHashCode();
                }
                if (this.VideoLength != null)
                {
                    hashCode = (hashCode * 59) + this.VideoLength.GetHashCode();
                }
                if (this.VideoSamples != null)
                {
                    hashCode = (hashCode * 59) + this.VideoSamples.GetHashCode();
                }
                if (this.VideoSize != null)
                {
                    hashCode = (hashCode * 59) + this.VideoSize.GetHashCode();
                }
                if (this.VideoSource != null)
                {
                    hashCode = (hashCode * 59) + this.VideoSource.GetHashCode();
                }
                if (this.VideoTemporaryUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VideoTemporaryUrl.GetHashCode();
                }
                if (this.VideoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VideoUrl.GetHashCode();
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
