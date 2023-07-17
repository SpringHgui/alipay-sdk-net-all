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
    /// AlipayIserviceCcmSwArticleCreateModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmSwArticleCreateModel")]
    public partial class AlipayIserviceCcmSwArticleCreateModel : IEquatable<AlipayIserviceCcmSwArticleCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwArticleCreateModel" /> class.
        /// </summary>
        /// <param name="categoryId">所属类目ID，如果search_all_category为true则不用填.</param>
        /// <param name="ccsInstanceId">子部门ID，不传为默认部门.</param>
        /// <param name="content">内容.</param>
        /// <param name="extendTitles">扩展标题.</param>
        /// <param name="keywords">标签.</param>
        /// <param name="libraryId">知识库ID.</param>
        /// <param name="sceneCodes">场景ID。KNOWLEDGE（内部知识库）；ROBOT（机器人）;HELP（帮助中心）；WHELP（无线帮助中心）.</param>
        /// <param name="title">标题.</param>
        public AlipayIserviceCcmSwArticleCreateModel(int categoryId = default(int), string ccsInstanceId = default(string), string content = default(string), List<string> extendTitles = default(List<string>), List<string> keywords = default(List<string>), string libraryId = default(string), List<string> sceneCodes = default(List<string>), string title = default(string))
        {
            this.CategoryId = categoryId;
            this.CcsInstanceId = ccsInstanceId;
            this.Content = content;
            this.ExtendTitles = extendTitles;
            this.Keywords = keywords;
            this.LibraryId = libraryId;
            this.SceneCodes = sceneCodes;
            this.Title = title;
        }

        /// <summary>
        /// 所属类目ID，如果search_all_category为true则不用填
        /// </summary>
        /// <value>所属类目ID，如果search_all_category为true则不用填</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        /// <value>子部门ID，不传为默认部门</value>
        [DataMember(Name = "ccs_instance_id", EmitDefaultValue = false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        /// <value>内容</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        /// <value>扩展标题</value>
        [DataMember(Name = "extend_titles", EmitDefaultValue = false)]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        /// <value>标签</value>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        /// <value>知识库ID</value>
        [DataMember(Name = "library_id", EmitDefaultValue = false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// 场景ID。KNOWLEDGE（内部知识库）；ROBOT（机器人）;HELP（帮助中心）；WHELP（无线帮助中心）
        /// </summary>
        /// <value>场景ID。KNOWLEDGE（内部知识库）；ROBOT（机器人）;HELP（帮助中心）；WHELP（无线帮助中心）</value>
        [DataMember(Name = "scene_codes", EmitDefaultValue = false)]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        /// <value>标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwArticleCreateModel {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ExtendTitles: ").Append(ExtendTitles).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  SceneCodes: ").Append(SceneCodes).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmSwArticleCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwArticleCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwArticleCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwArticleCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryId == input.CategoryId ||
                    this.CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    this.CcsInstanceId == input.CcsInstanceId ||
                    (this.CcsInstanceId != null &&
                    this.CcsInstanceId.Equals(input.CcsInstanceId))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ExtendTitles == input.ExtendTitles ||
                    this.ExtendTitles != null &&
                    input.ExtendTitles != null &&
                    this.ExtendTitles.SequenceEqual(input.ExtendTitles)
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.LibraryId == input.LibraryId ||
                    (this.LibraryId != null &&
                    this.LibraryId.Equals(input.LibraryId))
                ) && 
                (
                    this.SceneCodes == input.SceneCodes ||
                    this.SceneCodes != null &&
                    input.SceneCodes != null &&
                    this.SceneCodes.SequenceEqual(input.SceneCodes)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                if (this.CcsInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceId.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.ExtendTitles != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendTitles.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                if (this.LibraryId != null)
                {
                    hashCode = (hashCode * 59) + this.LibraryId.GetHashCode();
                }
                if (this.SceneCodes != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCodes.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
