/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// AlipayMarketingActivityMerchantBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityMerchantBatchqueryResponseModel")]
    public partial class AlipayMarketingActivityMerchantBatchqueryResponseModel : IEquatable<AlipayMarketingActivityMerchantBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityMerchantBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="activityId">活动id.</param>
        /// <param name="merchantInfos">可用商户列表.</param>
        /// <param name="pageNum">分页查询页码。.</param>
        /// <param name="pageSize">分页查询单页数据条数。.</param>
        /// <param name="totalSize">可用商户总数量.</param>
        public AlipayMarketingActivityMerchantBatchqueryResponseModel(string activityId = default(string), List<ActivityMerchantInfo> merchantInfos = default(List<ActivityMerchantInfo>), int pageNum = default(int), int pageSize = default(int), int totalSize = default(int))
        {
            this.ActivityId = activityId;
            this.MerchantInfos = merchantInfos;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 活动id
        /// </summary>
        /// <value>活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 可用商户列表
        /// </summary>
        /// <value>可用商户列表</value>
        [DataMember(Name = "merchant_infos", EmitDefaultValue = false)]
        public List<ActivityMerchantInfo> MerchantInfos { get; set; }

        /// <summary>
        /// 分页查询页码。
        /// </summary>
        /// <value>分页查询页码。</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数。
        /// </summary>
        /// <value>分页查询单页数据条数。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 可用商户总数量
        /// </summary>
        /// <value>可用商户总数量</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityMerchantBatchqueryResponseModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  MerchantInfos: ").Append(MerchantInfos).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityMerchantBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityMerchantBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityMerchantBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityMerchantBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.MerchantInfos == input.MerchantInfos ||
                    this.MerchantInfos != null &&
                    input.MerchantInfos != null &&
                    this.MerchantInfos.SequenceEqual(input.MerchantInfos)
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
                    this.TotalSize == input.TotalSize ||
                    this.TotalSize.Equals(input.TotalSize)
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.MerchantInfos != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantInfos.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
