/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// ZhimaMerchantZmgoCumulateQueryResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaMerchantZmgoCumulateQueryResponseModel")]
    public partial class ZhimaMerchantZmgoCumulateQueryResponseModel : IEquatable<ZhimaMerchantZmgoCumulateQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoCumulateQueryResponseModel" /> class.
        /// </summary>
        /// <param name="aggrAmount">总共累计金额.</param>
        /// <param name="aggrDiscountAmount">总共累计优惠金额.</param>
        /// <param name="aggrTimes">总共累计次数.</param>
        /// <param name="agreementId">芝麻go协议号，唯一标识一个芝麻go协议。.</param>
        /// <param name="detailList">详情数据列表.</param>
        /// <param name="failReason">查询失败原因.</param>
        /// <param name="pageNo">分页参数，返回传入的值。.</param>
        /// <param name="pageSize">分页参数，返回传入的值。.</param>
        public ZhimaMerchantZmgoCumulateQueryResponseModel(string aggrAmount = default(string), string aggrDiscountAmount = default(string), int aggrTimes = default(int), string agreementId = default(string), List<CumulateDataDetail> detailList = default(List<CumulateDataDetail>), string failReason = default(string), int pageNo = default(int), int pageSize = default(int))
        {
            this.AggrAmount = aggrAmount;
            this.AggrDiscountAmount = aggrDiscountAmount;
            this.AggrTimes = aggrTimes;
            this.AgreementId = agreementId;
            this.DetailList = detailList;
            this.FailReason = failReason;
            this.PageNo = pageNo;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// 总共累计金额
        /// </summary>
        /// <value>总共累计金额</value>
        [DataMember(Name = "aggr_amount", EmitDefaultValue = false)]
        public string AggrAmount { get; set; }

        /// <summary>
        /// 总共累计优惠金额
        /// </summary>
        /// <value>总共累计优惠金额</value>
        [DataMember(Name = "aggr_discount_amount", EmitDefaultValue = false)]
        public string AggrDiscountAmount { get; set; }

        /// <summary>
        /// 总共累计次数
        /// </summary>
        /// <value>总共累计次数</value>
        [DataMember(Name = "aggr_times", EmitDefaultValue = false)]
        public int AggrTimes { get; set; }

        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        /// <value>芝麻go协议号，唯一标识一个芝麻go协议。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 详情数据列表
        /// </summary>
        /// <value>详情数据列表</value>
        [DataMember(Name = "detail_list", EmitDefaultValue = false)]
        public List<CumulateDataDetail> DetailList { get; set; }

        /// <summary>
        /// 查询失败原因
        /// </summary>
        /// <value>查询失败原因</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 分页参数，返回传入的值。
        /// </summary>
        /// <value>分页参数，返回传入的值。</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 分页参数，返回传入的值。
        /// </summary>
        /// <value>分页参数，返回传入的值。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaMerchantZmgoCumulateQueryResponseModel {\n");
            sb.Append("  AggrAmount: ").Append(AggrAmount).Append("\n");
            sb.Append("  AggrDiscountAmount: ").Append(AggrDiscountAmount).Append("\n");
            sb.Append("  AggrTimes: ").Append(AggrTimes).Append("\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  DetailList: ").Append(DetailList).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as ZhimaMerchantZmgoCumulateQueryResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaMerchantZmgoCumulateQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaMerchantZmgoCumulateQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaMerchantZmgoCumulateQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AggrAmount == input.AggrAmount ||
                    (this.AggrAmount != null &&
                    this.AggrAmount.Equals(input.AggrAmount))
                ) && 
                (
                    this.AggrDiscountAmount == input.AggrDiscountAmount ||
                    (this.AggrDiscountAmount != null &&
                    this.AggrDiscountAmount.Equals(input.AggrDiscountAmount))
                ) && 
                (
                    this.AggrTimes == input.AggrTimes ||
                    this.AggrTimes.Equals(input.AggrTimes)
                ) && 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.DetailList == input.DetailList ||
                    this.DetailList != null &&
                    input.DetailList != null &&
                    this.DetailList.SequenceEqual(input.DetailList)
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                if (this.AggrAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AggrAmount.GetHashCode();
                }
                if (this.AggrDiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.AggrDiscountAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AggrTimes.GetHashCode();
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.DetailList != null)
                {
                    hashCode = (hashCode * 59) + this.DetailList.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
