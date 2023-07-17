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
    /// AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel")]
    public partial class AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel : IEquatable<AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="contentDetails">内容详情列表.</param>
        /// <param name="contentIds">内容ID列表.</param>
        /// <param name="pageNum">当前分页.</param>
        /// <param name="pageSize">每页记录数.</param>
        /// <param name="total">总记录数.</param>
        public AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel(List<SourceContentInfo> contentDetails = default(List<SourceContentInfo>), List<string> contentIds = default(List<string>), int pageNum = default(int), int pageSize = default(int), int total = default(int))
        {
            this.ContentDetails = contentDetails;
            this.ContentIds = contentIds;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.Total = total;
        }

        /// <summary>
        /// 内容详情列表
        /// </summary>
        /// <value>内容详情列表</value>
        [DataMember(Name = "content_details", EmitDefaultValue = false)]
        public List<SourceContentInfo> ContentDetails { get; set; }

        /// <summary>
        /// 内容ID列表
        /// </summary>
        /// <value>内容ID列表</value>
        [DataMember(Name = "content_ids", EmitDefaultValue = false)]
        public List<string> ContentIds { get; set; }

        /// <summary>
        /// 当前分页
        /// </summary>
        /// <value>当前分页</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        /// <value>每页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        /// <value>总记录数</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel {\n");
            sb.Append("  ContentDetails: ").Append(ContentDetails).Append("\n");
            sb.Append("  ContentIds: ").Append(ContentIds).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySocialBaseContentlibStandardcontentBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentDetails == input.ContentDetails ||
                    this.ContentDetails != null &&
                    input.ContentDetails != null &&
                    this.ContentDetails.SequenceEqual(input.ContentDetails)
                ) && 
                (
                    this.ContentIds == input.ContentIds ||
                    this.ContentIds != null &&
                    input.ContentIds != null &&
                    this.ContentIds.SequenceEqual(input.ContentIds)
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
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.ContentDetails != null)
                {
                    hashCode = (hashCode * 59) + this.ContentDetails.GetHashCode();
                }
                if (this.ContentIds != null)
                {
                    hashCode = (hashCode * 59) + this.ContentIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
