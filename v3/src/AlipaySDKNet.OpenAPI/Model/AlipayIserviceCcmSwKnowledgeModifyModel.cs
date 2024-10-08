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
    /// AlipayIserviceCcmSwKnowledgeModifyModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmSwKnowledgeModifyModel")]
    public partial class AlipayIserviceCcmSwKnowledgeModifyModel : IEquatable<AlipayIserviceCcmSwKnowledgeModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwKnowledgeModifyModel" /> class.
        /// </summary>
        /// <param name="categoryId">所属类目ID.</param>
        /// <param name="categoryName">知识点所属类目.</param>
        /// <param name="content">知识点答案内容.</param>
        /// <param name="extId">外部知识点ID.</param>
        /// <param name="extendTitles">扩展标题（问法）.</param>
        /// <param name="icon">问答关联图片附件地址.</param>
        /// <param name="id">知识点ID.</param>
        /// <param name="isDelete">默认为false，为true且id非空时，表示删除知识点.</param>
        /// <param name="isSearchable">是否被检索到，默认false，系统希望为true.</param>
        /// <param name="libraryId">知识库ID.</param>
        /// <param name="libraryName">知识库名称.</param>
        /// <param name="spu">spu.</param>
        /// <param name="tags">以逗号分割的字符串列表.</param>
        /// <param name="title">知识点标题.</param>
        public AlipayIserviceCcmSwKnowledgeModifyModel(int categoryId = default(int), string categoryName = default(string), string content = default(string), string extId = default(string), List<string> extendTitles = default(List<string>), string icon = default(string), int id = default(int), bool isDelete = default(bool), bool isSearchable = default(bool), int libraryId = default(int), string libraryName = default(string), SpuDetail spu = default(SpuDetail), List<string> tags = default(List<string>), string title = default(string))
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.Content = content;
            this.ExtId = extId;
            this.ExtendTitles = extendTitles;
            this.Icon = icon;
            this.Id = id;
            this.IsDelete = isDelete;
            this.IsSearchable = isSearchable;
            this.LibraryId = libraryId;
            this.LibraryName = libraryName;
            this.Spu = spu;
            this.Tags = tags;
            this.Title = title;
        }

        /// <summary>
        /// 所属类目ID
        /// </summary>
        /// <value>所属类目ID</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// 知识点所属类目
        /// </summary>
        /// <value>知识点所属类目</value>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 知识点答案内容
        /// </summary>
        /// <value>知识点答案内容</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 外部知识点ID
        /// </summary>
        /// <value>外部知识点ID</value>
        [DataMember(Name = "ext_id", EmitDefaultValue = false)]
        public string ExtId { get; set; }

        /// <summary>
        /// 扩展标题（问法）
        /// </summary>
        /// <value>扩展标题（问法）</value>
        [DataMember(Name = "extend_titles", EmitDefaultValue = false)]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 问答关联图片附件地址
        /// </summary>
        /// <value>问答关联图片附件地址</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// 知识点ID
        /// </summary>
        /// <value>知识点ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 默认为false，为true且id非空时，表示删除知识点
        /// </summary>
        /// <value>默认为false，为true且id非空时，表示删除知识点</value>
        [DataMember(Name = "is_delete", EmitDefaultValue = true)]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否被检索到，默认false，系统希望为true
        /// </summary>
        /// <value>是否被检索到，默认false，系统希望为true</value>
        [DataMember(Name = "is_searchable", EmitDefaultValue = true)]
        public bool IsSearchable { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        /// <value>知识库ID</value>
        [DataMember(Name = "library_id", EmitDefaultValue = false)]
        public int LibraryId { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        /// <value>知识库名称</value>
        [DataMember(Name = "library_name", EmitDefaultValue = false)]
        public string LibraryName { get; set; }

        /// <summary>
        /// Gets or Sets Spu
        /// </summary>
        [DataMember(Name = "spu", EmitDefaultValue = false)]
        public SpuDetail Spu { get; set; }

        /// <summary>
        /// 以逗号分割的字符串列表
        /// </summary>
        /// <value>以逗号分割的字符串列表</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 知识点标题
        /// </summary>
        /// <value>知识点标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwKnowledgeModifyModel {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ExtId: ").Append(ExtId).Append("\n");
            sb.Append("  ExtendTitles: ").Append(ExtendTitles).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsDelete: ").Append(IsDelete).Append("\n");
            sb.Append("  IsSearchable: ").Append(IsSearchable).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  LibraryName: ").Append(LibraryName).Append("\n");
            sb.Append("  Spu: ").Append(Spu).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmSwKnowledgeModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwKnowledgeModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwKnowledgeModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwKnowledgeModifyModel input)
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
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.ExtId == input.ExtId ||
                    (this.ExtId != null &&
                    this.ExtId.Equals(input.ExtId))
                ) && 
                (
                    this.ExtendTitles == input.ExtendTitles ||
                    this.ExtendTitles != null &&
                    input.ExtendTitles != null &&
                    this.ExtendTitles.SequenceEqual(input.ExtendTitles)
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.IsDelete == input.IsDelete ||
                    this.IsDelete.Equals(input.IsDelete)
                ) && 
                (
                    this.IsSearchable == input.IsSearchable ||
                    this.IsSearchable.Equals(input.IsSearchable)
                ) && 
                (
                    this.LibraryId == input.LibraryId ||
                    this.LibraryId.Equals(input.LibraryId)
                ) && 
                (
                    this.LibraryName == input.LibraryName ||
                    (this.LibraryName != null &&
                    this.LibraryName.Equals(input.LibraryName))
                ) && 
                (
                    this.Spu == input.Spu ||
                    (this.Spu != null &&
                    this.Spu.Equals(input.Spu))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.ExtId != null)
                {
                    hashCode = (hashCode * 59) + this.ExtId.GetHashCode();
                }
                if (this.ExtendTitles != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendTitles.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                hashCode = (hashCode * 59) + this.IsDelete.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSearchable.GetHashCode();
                hashCode = (hashCode * 59) + this.LibraryId.GetHashCode();
                if (this.LibraryName != null)
                {
                    hashCode = (hashCode * 59) + this.LibraryName.GetHashCode();
                }
                if (this.Spu != null)
                {
                    hashCode = (hashCode * 59) + this.Spu.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
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
