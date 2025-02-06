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
    /// AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel")]
    public partial class AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel : IEquatable<AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel" /> class.
        /// </summary>
        /// <param name="currentPage">当前页码.</param>
        /// <param name="pageSize">每页数量.</param>
        /// <param name="promotionRelations">推广服务商信息列表.</param>
        /// <param name="totalSize">总记录数.</param>
        public AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel(int currentPage = default(int), int pageSize = default(int), List<PromotionTaskRelation> promotionRelations = default(List<PromotionTaskRelation>), int totalSize = default(int))
        {
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.PromotionRelations = promotionRelations;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        /// <value>当前页码</value>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 每页数量
        /// </summary>
        /// <value>每页数量</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 推广服务商信息列表
        /// </summary>
        /// <value>推广服务商信息列表</value>
        [DataMember(Name = "promotion_relations", EmitDefaultValue = false)]
        public List<PromotionTaskRelation> PromotionRelations { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        /// <value>总记录数</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PromotionRelations: ").Append(PromotionRelations).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
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
            return this.Equals(input as AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketPromotiontaskRelationQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.PromotionRelations == input.PromotionRelations ||
                    this.PromotionRelations != null &&
                    input.PromotionRelations != null &&
                    this.PromotionRelations.SequenceEqual(input.PromotionRelations)
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    this.TotalSize.Equals(input.TotalSize)
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
                hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.PromotionRelations != null)
                {
                    hashCode = (hashCode * 59) + this.PromotionRelations.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
