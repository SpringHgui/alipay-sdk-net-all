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
    /// AlipayDataBillBizfundagentQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayDataBillBizfundagentQueryResponseModel")]
    public partial class AlipayDataBillBizfundagentQueryResponseModel : IEquatable<AlipayDataBillBizfundagentQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillBizfundagentQueryResponseModel" /> class.
        /// </summary>
        /// <param name="detailList">资金明细记录.</param>
        /// <param name="pageNo">分页号，从1开始.</param>
        /// <param name="pageSize">页面大小，最大2000.</param>
        /// <param name="totalSize">数据分页总页数.</param>
        public AlipayDataBillBizfundagentQueryResponseModel(List<BizFundReportResult> detailList = default(List<BizFundReportResult>), string pageNo = default(string), string pageSize = default(string), string totalSize = default(string))
        {
            this.DetailList = detailList;
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 资金明细记录
        /// </summary>
        /// <value>资金明细记录</value>
        [DataMember(Name = "detail_list", EmitDefaultValue = false)]
        public List<BizFundReportResult> DetailList { get; set; }

        /// <summary>
        /// 分页号，从1开始
        /// </summary>
        /// <value>分页号，从1开始</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public string PageNo { get; set; }

        /// <summary>
        /// 页面大小，最大2000
        /// </summary>
        /// <value>页面大小，最大2000</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 数据分页总页数
        /// </summary>
        /// <value>数据分页总页数</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public string TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataBillBizfundagentQueryResponseModel {\n");
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
            return this.Equals(input as AlipayDataBillBizfundagentQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayDataBillBizfundagentQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataBillBizfundagentQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataBillBizfundagentQueryResponseModel input)
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
