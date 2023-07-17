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
    /// AlipayTradeRoyaltyRelationBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeRoyaltyRelationBatchqueryResponseModel")]
    public partial class AlipayTradeRoyaltyRelationBatchqueryResponseModel : IEquatable<AlipayTradeRoyaltyRelationBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeRoyaltyRelationBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="currentPageNum">当前页数.</param>
        /// <param name="currentPageSize">当前页面大小.</param>
        /// <param name="receiverList">分账收款方列表.</param>
        /// <param name="resultCode">业务结果码。SUCCESS：分账关系查询成功；FAIL：分账关系查询失败。.</param>
        /// <param name="totalPageNum">总页数.</param>
        /// <param name="totalRecordNum">分账关系记录总数.</param>
        public AlipayTradeRoyaltyRelationBatchqueryResponseModel(int currentPageNum = default(int), int currentPageSize = default(int), List<RoyaltyEntity> receiverList = default(List<RoyaltyEntity>), string resultCode = default(string), int totalPageNum = default(int), int totalRecordNum = default(int))
        {
            this.CurrentPageNum = currentPageNum;
            this.CurrentPageSize = currentPageSize;
            this.ReceiverList = receiverList;
            this.ResultCode = resultCode;
            this.TotalPageNum = totalPageNum;
            this.TotalRecordNum = totalRecordNum;
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        /// <value>当前页数</value>
        [DataMember(Name = "current_page_num", EmitDefaultValue = false)]
        public int CurrentPageNum { get; set; }

        /// <summary>
        /// 当前页面大小
        /// </summary>
        /// <value>当前页面大小</value>
        [DataMember(Name = "current_page_size", EmitDefaultValue = false)]
        public int CurrentPageSize { get; set; }

        /// <summary>
        /// 分账收款方列表
        /// </summary>
        /// <value>分账收款方列表</value>
        [DataMember(Name = "receiver_list", EmitDefaultValue = false)]
        public List<RoyaltyEntity> ReceiverList { get; set; }

        /// <summary>
        /// 业务结果码。SUCCESS：分账关系查询成功；FAIL：分账关系查询失败。
        /// </summary>
        /// <value>业务结果码。SUCCESS：分账关系查询成功；FAIL：分账关系查询失败。</value>
        [DataMember(Name = "result_code", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_page_num", EmitDefaultValue = false)]
        public int TotalPageNum { get; set; }

        /// <summary>
        /// 分账关系记录总数
        /// </summary>
        /// <value>分账关系记录总数</value>
        [DataMember(Name = "total_record_num", EmitDefaultValue = false)]
        public int TotalRecordNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeRoyaltyRelationBatchqueryResponseModel {\n");
            sb.Append("  CurrentPageNum: ").Append(CurrentPageNum).Append("\n");
            sb.Append("  CurrentPageSize: ").Append(CurrentPageSize).Append("\n");
            sb.Append("  ReceiverList: ").Append(ReceiverList).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  TotalPageNum: ").Append(TotalPageNum).Append("\n");
            sb.Append("  TotalRecordNum: ").Append(TotalRecordNum).Append("\n");
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
            return this.Equals(input as AlipayTradeRoyaltyRelationBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeRoyaltyRelationBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeRoyaltyRelationBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeRoyaltyRelationBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentPageNum == input.CurrentPageNum ||
                    this.CurrentPageNum.Equals(input.CurrentPageNum)
                ) && 
                (
                    this.CurrentPageSize == input.CurrentPageSize ||
                    this.CurrentPageSize.Equals(input.CurrentPageSize)
                ) && 
                (
                    this.ReceiverList == input.ReceiverList ||
                    this.ReceiverList != null &&
                    input.ReceiverList != null &&
                    this.ReceiverList.SequenceEqual(input.ReceiverList)
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.TotalPageNum == input.TotalPageNum ||
                    this.TotalPageNum.Equals(input.TotalPageNum)
                ) && 
                (
                    this.TotalRecordNum == input.TotalRecordNum ||
                    this.TotalRecordNum.Equals(input.TotalRecordNum)
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
                hashCode = (hashCode * 59) + this.CurrentPageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.CurrentPageSize.GetHashCode();
                if (this.ReceiverList != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverList.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalRecordNum.GetHashCode();
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
