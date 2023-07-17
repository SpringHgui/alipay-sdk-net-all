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
    /// AlipayIserviceCcmSwArticleBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmSwArticleBatchqueryModel")]
    public partial class AlipayIserviceCcmSwArticleBatchqueryModel : IEquatable<AlipayIserviceCcmSwArticleBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwArticleBatchqueryModel" /> class.
        /// </summary>
        /// <param name="categoryId">所属类目ID，如果search_all_category为true则不用填.</param>
        /// <param name="ccsInstanceId">子部门ID，不传为默认部门.</param>
        /// <param name="endTime">结束时间，并且开始时间不能为空.</param>
        /// <param name="ids">文章ID集合.</param>
        /// <param name="keyword">关键字.</param>
        /// <param name="keywords">标签.</param>
        /// <param name="libraryId">知识库ID.</param>
        /// <param name="pageNum">页数，page_size不能为空.</param>
        /// <param name="pageSize">页大小，page_num不能为空.</param>
        /// <param name="searchAllCategory">是否搜索所有类目，如果为true则不用填写category_id值.</param>
        /// <param name="searchCategoryType">Current（搜索当前节点）； Children（搜索当前节点以及子节点）.</param>
        /// <param name="startTime">开始时间，并且结束时间不能为空.</param>
        /// <param name="status">状态，PUBLISHED（已发布），UNPUBLISH（未发布），EXPIRED（失效），DELETED（已删除）.</param>
        public AlipayIserviceCcmSwArticleBatchqueryModel(int categoryId = default(int), string ccsInstanceId = default(string), string endTime = default(string), List<int> ids = default(List<int>), string keyword = default(string), List<string> keywords = default(List<string>), int libraryId = default(int), int pageNum = default(int), int pageSize = default(int), bool searchAllCategory = default(bool), string searchCategoryType = default(string), string startTime = default(string), string status = default(string))
        {
            this.CategoryId = categoryId;
            this.CcsInstanceId = ccsInstanceId;
            this.EndTime = endTime;
            this.Ids = ids;
            this.Keyword = keyword;
            this.Keywords = keywords;
            this.LibraryId = libraryId;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.SearchAllCategory = searchAllCategory;
            this.SearchCategoryType = searchCategoryType;
            this.StartTime = startTime;
            this.Status = status;
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
        /// 结束时间，并且开始时间不能为空
        /// </summary>
        /// <value>结束时间，并且开始时间不能为空</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 文章ID集合
        /// </summary>
        /// <value>文章ID集合</value>
        [DataMember(Name = "ids", EmitDefaultValue = false)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        /// <value>关键字</value>
        [DataMember(Name = "keyword", EmitDefaultValue = false)]
        public string Keyword { get; set; }

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
        public int LibraryId { get; set; }

        /// <summary>
        /// 页数，page_size不能为空
        /// </summary>
        /// <value>页数，page_size不能为空</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 页大小，page_num不能为空
        /// </summary>
        /// <value>页大小，page_num不能为空</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 是否搜索所有类目，如果为true则不用填写category_id值
        /// </summary>
        /// <value>是否搜索所有类目，如果为true则不用填写category_id值</value>
        [DataMember(Name = "search_all_category", EmitDefaultValue = true)]
        public bool SearchAllCategory { get; set; }

        /// <summary>
        /// Current（搜索当前节点）； Children（搜索当前节点以及子节点）
        /// </summary>
        /// <value>Current（搜索当前节点）； Children（搜索当前节点以及子节点）</value>
        [DataMember(Name = "search_category_type", EmitDefaultValue = false)]
        public string SearchCategoryType { get; set; }

        /// <summary>
        /// 开始时间，并且结束时间不能为空
        /// </summary>
        /// <value>开始时间，并且结束时间不能为空</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态，PUBLISHED（已发布），UNPUBLISH（未发布），EXPIRED（失效），DELETED（已删除）
        /// </summary>
        /// <value>状态，PUBLISHED（已发布），UNPUBLISH（未发布），EXPIRED（失效），DELETED（已删除）</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwArticleBatchqueryModel {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  Keyword: ").Append(Keyword).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SearchAllCategory: ").Append(SearchAllCategory).Append("\n");
            sb.Append("  SearchCategoryType: ").Append(SearchCategoryType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmSwArticleBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwArticleBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwArticleBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwArticleBatchqueryModel input)
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
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Ids == input.Ids ||
                    this.Ids != null &&
                    input.Ids != null &&
                    this.Ids.SequenceEqual(input.Ids)
                ) && 
                (
                    this.Keyword == input.Keyword ||
                    (this.Keyword != null &&
                    this.Keyword.Equals(input.Keyword))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.LibraryId == input.LibraryId ||
                    this.LibraryId.Equals(input.LibraryId)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.SearchAllCategory == input.SearchAllCategory ||
                    this.SearchAllCategory.Equals(input.SearchAllCategory)
                ) && 
                (
                    this.SearchCategoryType == input.SearchCategoryType ||
                    (this.SearchCategoryType != null &&
                    this.SearchCategoryType.Equals(input.SearchCategoryType))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.Ids != null)
                {
                    hashCode = (hashCode * 59) + this.Ids.GetHashCode();
                }
                if (this.Keyword != null)
                {
                    hashCode = (hashCode * 59) + this.Keyword.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LibraryId.GetHashCode();
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.SearchAllCategory.GetHashCode();
                if (this.SearchCategoryType != null)
                {
                    hashCode = (hashCode * 59) + this.SearchCategoryType.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
