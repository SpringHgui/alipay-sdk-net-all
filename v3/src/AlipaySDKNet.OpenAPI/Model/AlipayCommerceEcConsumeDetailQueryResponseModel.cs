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
    /// AlipayCommerceEcConsumeDetailQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcConsumeDetailQueryResponseModel")]
    public partial class AlipayCommerceEcConsumeDetailQueryResponseModel : IEquatable<AlipayCommerceEcConsumeDetailQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcConsumeDetailQueryResponseModel" /> class.
        /// </summary>
        /// <param name="consumeInfo">consumeInfo.</param>
        /// <param name="relatedOrderInfo">relatedOrderInfo.</param>
        /// <param name="relatedRefundList">关联账单列表.</param>
        /// <param name="relatedVoucherList">关联凭证详情列表.</param>
        public AlipayCommerceEcConsumeDetailQueryResponseModel(EcConsumeInfo consumeInfo = default(EcConsumeInfo), EcOrderInfo relatedOrderInfo = default(EcOrderInfo), List<EcConsumeInfo> relatedRefundList = default(List<EcConsumeInfo>), List<EcVoucherInfo> relatedVoucherList = default(List<EcVoucherInfo>))
        {
            this.ConsumeInfo = consumeInfo;
            this.RelatedOrderInfo = relatedOrderInfo;
            this.RelatedRefundList = relatedRefundList;
            this.RelatedVoucherList = relatedVoucherList;
        }

        /// <summary>
        /// Gets or Sets ConsumeInfo
        /// </summary>
        [DataMember(Name = "consume_info", EmitDefaultValue = false)]
        public EcConsumeInfo ConsumeInfo { get; set; }

        /// <summary>
        /// Gets or Sets RelatedOrderInfo
        /// </summary>
        [DataMember(Name = "related_order_info", EmitDefaultValue = false)]
        public EcOrderInfo RelatedOrderInfo { get; set; }

        /// <summary>
        /// 关联账单列表
        /// </summary>
        /// <value>关联账单列表</value>
        [DataMember(Name = "related_refund_list", EmitDefaultValue = false)]
        public List<EcConsumeInfo> RelatedRefundList { get; set; }

        /// <summary>
        /// 关联凭证详情列表
        /// </summary>
        /// <value>关联凭证详情列表</value>
        [DataMember(Name = "related_voucher_list", EmitDefaultValue = false)]
        public List<EcVoucherInfo> RelatedVoucherList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcConsumeDetailQueryResponseModel {\n");
            sb.Append("  ConsumeInfo: ").Append(ConsumeInfo).Append("\n");
            sb.Append("  RelatedOrderInfo: ").Append(RelatedOrderInfo).Append("\n");
            sb.Append("  RelatedRefundList: ").Append(RelatedRefundList).Append("\n");
            sb.Append("  RelatedVoucherList: ").Append(RelatedVoucherList).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcConsumeDetailQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcConsumeDetailQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcConsumeDetailQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcConsumeDetailQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumeInfo == input.ConsumeInfo ||
                    (this.ConsumeInfo != null &&
                    this.ConsumeInfo.Equals(input.ConsumeInfo))
                ) && 
                (
                    this.RelatedOrderInfo == input.RelatedOrderInfo ||
                    (this.RelatedOrderInfo != null &&
                    this.RelatedOrderInfo.Equals(input.RelatedOrderInfo))
                ) && 
                (
                    this.RelatedRefundList == input.RelatedRefundList ||
                    this.RelatedRefundList != null &&
                    input.RelatedRefundList != null &&
                    this.RelatedRefundList.SequenceEqual(input.RelatedRefundList)
                ) && 
                (
                    this.RelatedVoucherList == input.RelatedVoucherList ||
                    this.RelatedVoucherList != null &&
                    input.RelatedVoucherList != null &&
                    this.RelatedVoucherList.SequenceEqual(input.RelatedVoucherList)
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
                if (this.ConsumeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeInfo.GetHashCode();
                }
                if (this.RelatedOrderInfo != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedOrderInfo.GetHashCode();
                }
                if (this.RelatedRefundList != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedRefundList.GetHashCode();
                }
                if (this.RelatedVoucherList != null)
                {
                    hashCode = (hashCode * 59) + this.RelatedVoucherList.GetHashCode();
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
