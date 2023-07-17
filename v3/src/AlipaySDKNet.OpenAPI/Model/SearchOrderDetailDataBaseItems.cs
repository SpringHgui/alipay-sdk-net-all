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
    /// SearchOrderDetailDataBaseItems
    /// </summary>
    [DataContract(Name = "SearchOrderDetailDataBaseItems")]
    public partial class SearchOrderDetailDataBaseItems : IEquatable<SearchOrderDetailDataBaseItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrderDetailDataBaseItems" /> class.
        /// </summary>
        /// <param name="canSearch">搜索可见性.</param>
        /// <param name="desc">描述信息.</param>
        /// <param name="img">img地址.</param>
        /// <param name="keyWord">关键词.</param>
        /// <param name="name">应用名称.</param>
        /// <param name="region">基础工单详情region.</param>
        /// <param name="servCanSearch">搜索可见性.</param>
        /// <param name="servSearchKeywords">搜索关键词.</param>
        /// <param name="templateId">模板id.</param>
        /// <param name="url">跳转url链接.</param>
        public SearchOrderDetailDataBaseItems(string canSearch = default(string), string desc = default(string), string img = default(string), string keyWord = default(string), string name = default(string), string region = default(string), string servCanSearch = default(string), string servSearchKeywords = default(string), string templateId = default(string), string url = default(string))
        {
            this.CanSearch = canSearch;
            this.Desc = desc;
            this.Img = img;
            this.KeyWord = keyWord;
            this.Name = name;
            this.Region = region;
            this.ServCanSearch = servCanSearch;
            this.ServSearchKeywords = servSearchKeywords;
            this.TemplateId = templateId;
            this.Url = url;
        }

        /// <summary>
        /// 搜索可见性
        /// </summary>
        /// <value>搜索可见性</value>
        [DataMember(Name = "can_search", EmitDefaultValue = false)]
        public string CanSearch { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        /// <value>描述信息</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        /// <value>img地址</value>
        [DataMember(Name = "img", EmitDefaultValue = false)]
        public string Img { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        /// <value>关键词</value>
        [DataMember(Name = "key_word", EmitDefaultValue = false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        /// <value>应用名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 基础工单详情region
        /// </summary>
        /// <value>基础工单详情region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// 搜索可见性
        /// </summary>
        /// <value>搜索可见性</value>
        [DataMember(Name = "serv_can_search", EmitDefaultValue = false)]
        public string ServCanSearch { get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        /// <value>搜索关键词</value>
        [DataMember(Name = "serv_search_keywords", EmitDefaultValue = false)]
        public string ServSearchKeywords { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        /// <value>模板id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 跳转url链接
        /// </summary>
        /// <value>跳转url链接</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchOrderDetailDataBaseItems {\n");
            sb.Append("  CanSearch: ").Append(CanSearch).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  Img: ").Append(Img).Append("\n");
            sb.Append("  KeyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  ServCanSearch: ").Append(ServCanSearch).Append("\n");
            sb.Append("  ServSearchKeywords: ").Append(ServSearchKeywords).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as SearchOrderDetailDataBaseItems);
        }

        /// <summary>
        /// Returns true if SearchOrderDetailDataBaseItems instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchOrderDetailDataBaseItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrderDetailDataBaseItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanSearch == input.CanSearch ||
                    (this.CanSearch != null &&
                    this.CanSearch.Equals(input.CanSearch))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.Img == input.Img ||
                    (this.Img != null &&
                    this.Img.Equals(input.Img))
                ) && 
                (
                    this.KeyWord == input.KeyWord ||
                    (this.KeyWord != null &&
                    this.KeyWord.Equals(input.KeyWord))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.ServCanSearch == input.ServCanSearch ||
                    (this.ServCanSearch != null &&
                    this.ServCanSearch.Equals(input.ServCanSearch))
                ) && 
                (
                    this.ServSearchKeywords == input.ServSearchKeywords ||
                    (this.ServSearchKeywords != null &&
                    this.ServSearchKeywords.Equals(input.ServSearchKeywords))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.CanSearch != null)
                {
                    hashCode = (hashCode * 59) + this.CanSearch.GetHashCode();
                }
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.Img != null)
                {
                    hashCode = (hashCode * 59) + this.Img.GetHashCode();
                }
                if (this.KeyWord != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWord.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.ServCanSearch != null)
                {
                    hashCode = (hashCode * 59) + this.ServCanSearch.GetHashCode();
                }
                if (this.ServSearchKeywords != null)
                {
                    hashCode = (hashCode * 59) + this.ServSearchKeywords.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
