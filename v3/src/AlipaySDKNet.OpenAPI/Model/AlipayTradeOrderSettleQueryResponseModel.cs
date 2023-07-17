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
    /// AlipayTradeOrderSettleQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOrderSettleQueryResponseModel")]
    public partial class AlipayTradeOrderSettleQueryResponseModel : IEquatable<AlipayTradeOrderSettleQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderSettleQueryResponseModel" /> class.
        /// </summary>
        /// <param name="operationDt">分账受理时间.</param>
        /// <param name="outRequestNo">商户分账请求单号.</param>
        /// <param name="royaltyDetailList">分账明细.</param>
        public AlipayTradeOrderSettleQueryResponseModel(string operationDt = default(string), string outRequestNo = default(string), List<RoyaltyDetail> royaltyDetailList = default(List<RoyaltyDetail>))
        {
            this.OperationDt = operationDt;
            this.OutRequestNo = outRequestNo;
            this.RoyaltyDetailList = royaltyDetailList;
        }

        /// <summary>
        /// 分账受理时间
        /// </summary>
        /// <value>分账受理时间</value>
        [DataMember(Name = "operation_dt", EmitDefaultValue = false)]
        public string OperationDt { get; set; }

        /// <summary>
        /// 商户分账请求单号
        /// </summary>
        /// <value>商户分账请求单号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细
        /// </summary>
        /// <value>分账明细</value>
        [DataMember(Name = "royalty_detail_list", EmitDefaultValue = false)]
        public List<RoyaltyDetail> RoyaltyDetailList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeOrderSettleQueryResponseModel {\n");
            sb.Append("  OperationDt: ").Append(OperationDt).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RoyaltyDetailList: ").Append(RoyaltyDetailList).Append("\n");
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
            return this.Equals(input as AlipayTradeOrderSettleQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOrderSettleQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOrderSettleQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOrderSettleQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OperationDt == input.OperationDt ||
                    (this.OperationDt != null &&
                    this.OperationDt.Equals(input.OperationDt))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.RoyaltyDetailList == input.RoyaltyDetailList ||
                    this.RoyaltyDetailList != null &&
                    input.RoyaltyDetailList != null &&
                    this.RoyaltyDetailList.SequenceEqual(input.RoyaltyDetailList)
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
                if (this.OperationDt != null)
                {
                    hashCode = (hashCode * 59) + this.OperationDt.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RoyaltyDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyDetailList.GetHashCode();
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
