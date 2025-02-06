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
    /// AlipayMarketingCampaignCashListQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCampaignCashListQueryResponseModel")]
    public partial class AlipayMarketingCampaignCashListQueryResponseModel : IEquatable<AlipayMarketingCampaignCashListQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashListQueryResponseModel" /> class.
        /// </summary>
        /// <param name="campList">活动列表.</param>
        /// <param name="pageIndex">分页的页码,起始从1开始.</param>
        /// <param name="pageSize">分页每页大小.</param>
        /// <param name="totalSize">活动总个数.</param>
        public AlipayMarketingCampaignCashListQueryResponseModel(List<CashCampaignInfo> campList = default(List<CashCampaignInfo>), string pageIndex = default(string), string pageSize = default(string), string totalSize = default(string))
        {
            this.CampList = campList;
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 活动列表
        /// </summary>
        /// <value>活动列表</value>
        [DataMember(Name = "camp_list", EmitDefaultValue = false)]
        public List<CashCampaignInfo> CampList { get; set; }

        /// <summary>
        /// 分页的页码,起始从1开始
        /// </summary>
        /// <value>分页的页码,起始从1开始</value>
        [DataMember(Name = "page_index", EmitDefaultValue = false)]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页每页大小
        /// </summary>
        /// <value>分页每页大小</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 活动总个数
        /// </summary>
        /// <value>活动总个数</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public string TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCampaignCashListQueryResponseModel {\n");
            sb.Append("  CampList: ").Append(CampList).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
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
            return this.Equals(input as AlipayMarketingCampaignCashListQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCampaignCashListQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCampaignCashListQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCampaignCashListQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampList == input.CampList ||
                    this.CampList != null &&
                    input.CampList != null &&
                    this.CampList.SequenceEqual(input.CampList)
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    (this.PageIndex != null &&
                    this.PageIndex.Equals(input.PageIndex))
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
                if (this.CampList != null)
                {
                    hashCode = (hashCode * 59) + this.CampList.GetHashCode();
                }
                if (this.PageIndex != null)
                {
                    hashCode = (hashCode * 59) + this.PageIndex.GetHashCode();
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
