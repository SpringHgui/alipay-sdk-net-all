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
    /// AlipayMerchantTradecomplainBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantTradecomplainBatchqueryResponseModel")]
    public partial class AlipayMerchantTradecomplainBatchqueryResponseModel : IEquatable<AlipayMerchantTradecomplainBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantTradecomplainBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="pageNum">当前页码数.</param>
        /// <param name="pageSize">每页记录数.</param>
        /// <param name="totalNum">总条数.</param>
        /// <param name="totalPageNum">总页码数.</param>
        /// <param name="tradeComplainInfos">交易纠纷工单列表信息.</param>
        public AlipayMerchantTradecomplainBatchqueryResponseModel(int pageNum = default(int), int pageSize = default(int), int totalNum = default(int), int totalPageNum = default(int), List<TradeComplainQueryResponse> tradeComplainInfos = default(List<TradeComplainQueryResponse>))
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalNum = totalNum;
            this.TotalPageNum = totalPageNum;
            this.TradeComplainInfos = tradeComplainInfos;
        }

        /// <summary>
        /// 当前页码数
        /// </summary>
        /// <value>当前页码数</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        /// <value>每页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        /// <value>总条数</value>
        [DataMember(Name = "total_num", EmitDefaultValue = false)]
        public int TotalNum { get; set; }

        /// <summary>
        /// 总页码数
        /// </summary>
        /// <value>总页码数</value>
        [DataMember(Name = "total_page_num", EmitDefaultValue = false)]
        public int TotalPageNum { get; set; }

        /// <summary>
        /// 交易纠纷工单列表信息
        /// </summary>
        /// <value>交易纠纷工单列表信息</value>
        [DataMember(Name = "trade_complain_infos", EmitDefaultValue = false)]
        public List<TradeComplainQueryResponse> TradeComplainInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantTradecomplainBatchqueryResponseModel {\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  TotalPageNum: ").Append(TotalPageNum).Append("\n");
            sb.Append("  TradeComplainInfos: ").Append(TradeComplainInfos).Append("\n");
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
            return this.Equals(input as AlipayMerchantTradecomplainBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantTradecomplainBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantTradecomplainBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantTradecomplainBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TotalNum == input.TotalNum ||
                    this.TotalNum.Equals(input.TotalNum)
                ) && 
                (
                    this.TotalPageNum == input.TotalPageNum ||
                    this.TotalPageNum.Equals(input.TotalPageNum)
                ) && 
                (
                    this.TradeComplainInfos == input.TradeComplainInfos ||
                    this.TradeComplainInfos != null &&
                    input.TradeComplainInfos != null &&
                    this.TradeComplainInfos.SequenceEqual(input.TradeComplainInfos)
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
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalNum.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPageNum.GetHashCode();
                if (this.TradeComplainInfos != null)
                {
                    hashCode = (hashCode * 59) + this.TradeComplainInfos.GetHashCode();
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
