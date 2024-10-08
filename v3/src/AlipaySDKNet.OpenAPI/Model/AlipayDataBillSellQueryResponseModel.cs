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
    /// AlipayDataBillSellQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayDataBillSellQueryResponseModel")]
    public partial class AlipayDataBillSellQueryResponseModel : IEquatable<AlipayDataBillSellQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillSellQueryResponseModel" /> class.
        /// </summary>
        /// <param name="detailList">交易流水详情.</param>
        /// <param name="pageNo">分页号，从1开始.</param>
        /// <param name="pageSize">分页大小1000-2000.</param>
        /// <param name="totalSize">账务明细总数。返回满足查询条件的明细的数量.</param>
        public AlipayDataBillSellQueryResponseModel(List<TradeItemResult> detailList = default(List<TradeItemResult>), string pageNo = default(string), string pageSize = default(string), string totalSize = default(string))
        {
            this.DetailList = detailList;
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 交易流水详情
        /// </summary>
        /// <value>交易流水详情</value>
        [DataMember(Name = "detail_list", EmitDefaultValue = false)]
        public List<TradeItemResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        /// <value>分页号，从1开始</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小1000-2000
        /// </summary>
        /// <value>分页大小1000-2000</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 账务明细总数。返回满足查询条件的明细的数量
        /// </summary>
        /// <value>账务明细总数。返回满足查询条件的明细的数量</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public string TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataBillSellQueryResponseModel {\n");
            sb.Append("  DetailList: ").Append(DetailList).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as AlipayDataBillSellQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayDataBillSellQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataBillSellQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataBillSellQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DetailList == input.DetailList ||
                    this.DetailList != null &&
                    input.DetailList != null &&
                    this.DetailList.SequenceEqual(input.DetailList)
                ) && 
                (
                    this.PageNo == input.PageNo ||
                    (this.PageNo != null &&
                    this.PageNo.Equals(input.PageNo))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    (this.TotalSize != null &&
                    this.TotalSize.Equals(input.TotalSize))
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
                if (this.DetailList != null)
                {
                    hashCode = (hashCode * 59) + this.DetailList.GetHashCode();
                }
                if (this.PageNo != null)
                {
                    hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.TotalSize != null)
                {
                    hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
