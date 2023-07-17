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
    /// AlipayDataDataserviceAdPromotepageBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayDataDataserviceAdPromotepageBatchqueryResponseModel")]
    public partial class AlipayDataDataserviceAdPromotepageBatchqueryResponseModel : IEquatable<AlipayDataDataserviceAdPromotepageBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceAdPromotepageBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="list">自建推广页详情列表.</param>
        /// <param name="pageNo">分页参数之页数.</param>
        /// <param name="pageSize">分页参数之每页大小.</param>
        /// <param name="total">分页参数之总数据量.</param>
        public AlipayDataDataserviceAdPromotepageBatchqueryResponseModel(List<PromotePageDetail> list = default(List<PromotePageDetail>), int pageNo = default(int), int pageSize = default(int), int total = default(int))
        {
            this.List = list;
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.Total = total;
        }

        /// <summary>
        /// 自建推广页详情列表
        /// </summary>
        /// <value>自建推广页详情列表</value>
        [DataMember(Name = "list", EmitDefaultValue = false)]
        public List<PromotePageDetail> List { get; set; }

        /// <summary>
        /// 分页参数之页数
        /// </summary>
        /// <value>分页参数之页数</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 分页参数之每页大小
        /// </summary>
        /// <value>分页参数之每页大小</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 分页参数之总数据量
        /// </summary>
        /// <value>分页参数之总数据量</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataDataserviceAdPromotepageBatchqueryResponseModel {\n");
            sb.Append("  List: ").Append(List).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
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
            return this.Equals(input as AlipayDataDataserviceAdPromotepageBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayDataDataserviceAdPromotepageBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataDataserviceAdPromotepageBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataDataserviceAdPromotepageBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.List == input.List ||
                    this.List != null &&
                    input.List != null &&
                    this.List.SequenceEqual(input.List)
                ) && 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
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
                if (this.List != null)
                {
                    hashCode = (hashCode * 59) + this.List.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
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
