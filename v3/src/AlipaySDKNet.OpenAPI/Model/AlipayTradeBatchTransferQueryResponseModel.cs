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
    /// AlipayTradeBatchTransferQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeBatchTransferQueryResponseModel")]
    public partial class AlipayTradeBatchTransferQueryResponseModel : IEquatable<AlipayTradeBatchTransferQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeBatchTransferQueryResponseModel" /> class.
        /// </summary>
        /// <param name="outRequestNo">批量结算时传入的外部流水号.</param>
        /// <param name="royaltyDetail">批量结算详情.</param>
        /// <param name="settleNo">结算单据号.</param>
        public AlipayTradeBatchTransferQueryResponseModel(string outRequestNo = default(string), List<BatchRoyaltyDetail> royaltyDetail = default(List<BatchRoyaltyDetail>), string settleNo = default(string))
        {
            this.OutRequestNo = outRequestNo;
            this.RoyaltyDetail = royaltyDetail;
            this.SettleNo = settleNo;
        }

        /// <summary>
        /// 批量结算时传入的外部流水号
        /// </summary>
        /// <value>批量结算时传入的外部流水号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 批量结算详情
        /// </summary>
        /// <value>批量结算详情</value>
        [DataMember(Name = "royalty_detail", EmitDefaultValue = false)]
        public List<BatchRoyaltyDetail> RoyaltyDetail { get; set; }

        /// <summary>
        /// 结算单据号
        /// </summary>
        /// <value>结算单据号</value>
        [DataMember(Name = "settle_no", EmitDefaultValue = false)]
        public string SettleNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeBatchTransferQueryResponseModel {\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RoyaltyDetail: ").Append(RoyaltyDetail).Append("\n");
            sb.Append("  SettleNo: ").Append(SettleNo).Append("\n");
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
            return this.Equals(input as AlipayTradeBatchTransferQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeBatchTransferQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeBatchTransferQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeBatchTransferQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.RoyaltyDetail == input.RoyaltyDetail ||
                    this.RoyaltyDetail != null &&
                    input.RoyaltyDetail != null &&
                    this.RoyaltyDetail.SequenceEqual(input.RoyaltyDetail)
                ) && 
                (
                    this.SettleNo == input.SettleNo ||
                    (this.SettleNo != null &&
                    this.SettleNo.Equals(input.SettleNo))
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
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RoyaltyDetail != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyDetail.GetHashCode();
                }
                if (this.SettleNo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleNo.GetHashCode();
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
