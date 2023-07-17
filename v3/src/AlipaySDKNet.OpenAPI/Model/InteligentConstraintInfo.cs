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
    /// InteligentConstraintInfo
    /// </summary>
    [DataContract(Name = "InteligentConstraintInfo")]
    public partial class InteligentConstraintInfo : IEquatable<InteligentConstraintInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteligentConstraintInfo" /> class.
        /// </summary>
        /// <param name="crowdGroupId">人群组id，目前只支持返回时带出。.</param>
        /// <param name="itemIds">单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码.</param>
        /// <param name="minCost">最低消费金额，单位元  仅在创建消费送礼包活动时设置.</param>
        /// <param name="suitShops">活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店.</param>
        /// <param name="userWinCount">活动期间用户能够参与的次数限制  如果不设置则不限制参与次数.</param>
        /// <param name="userWinFrequency">活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3.</param>
        public InteligentConstraintInfo(string crowdGroupId = default(string), string itemIds = default(string), string minCost = default(string), List<string> suitShops = default(List<string>), string userWinCount = default(string), string userWinFrequency = default(string))
        {
            this.CrowdGroupId = crowdGroupId;
            this.ItemIds = itemIds;
            this.MinCost = minCost;
            this.SuitShops = suitShops;
            this.UserWinCount = userWinCount;
            this.UserWinFrequency = userWinFrequency;
        }

        /// <summary>
        /// 人群组id，目前只支持返回时带出。
        /// </summary>
        /// <value>人群组id，目前只支持返回时带出。</value>
        [DataMember(Name = "crowd_group_id", EmitDefaultValue = false)]
        public string CrowdGroupId { get; set; }

        /// <summary>
        /// 单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码
        /// </summary>
        /// <value>单品码列表  仅在创建消费单品送活动时设置，最多设置500个单品码,由商户根据自己的商品管理自定义，一般为国标码</value>
        [DataMember(Name = "item_ids", EmitDefaultValue = false)]
        public string ItemIds { get; set; }

        /// <summary>
        /// 最低消费金额，单位元  仅在创建消费送礼包活动时设置
        /// </summary>
        /// <value>最低消费金额，单位元  仅在创建消费送礼包活动时设置</value>
        [DataMember(Name = "min_cost", EmitDefaultValue = false)]
        public string MinCost { get; set; }

        /// <summary>
        /// 活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店
        /// </summary>
        /// <value>活动适用的门店列表  仅品牌商发起的招商活动可为空  最多支持10w家门店</value>
        [DataMember(Name = "suit_shops", EmitDefaultValue = false)]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的次数限制  如果不设置则不限制参与次数
        /// </summary>
        /// <value>活动期间用户能够参与的次数限制  如果不设置则不限制参与次数</value>
        [DataMember(Name = "user_win_count", EmitDefaultValue = false)]
        public string UserWinCount { get; set; }

        /// <summary>
        /// 活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3
        /// </summary>
        /// <value>活动期间用户能够参与的频率限制  如果不设置则不限制参与频率  每日中奖1次: D||1   每周中奖2次: W||2   每月中奖3次: M||3</value>
        [DataMember(Name = "user_win_frequency", EmitDefaultValue = false)]
        public string UserWinFrequency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteligentConstraintInfo {\n");
            sb.Append("  CrowdGroupId: ").Append(CrowdGroupId).Append("\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  MinCost: ").Append(MinCost).Append("\n");
            sb.Append("  SuitShops: ").Append(SuitShops).Append("\n");
            sb.Append("  UserWinCount: ").Append(UserWinCount).Append("\n");
            sb.Append("  UserWinFrequency: ").Append(UserWinFrequency).Append("\n");
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
            return this.Equals(input as InteligentConstraintInfo);
        }

        /// <summary>
        /// Returns true if InteligentConstraintInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of InteligentConstraintInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InteligentConstraintInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CrowdGroupId == input.CrowdGroupId ||
                    (this.CrowdGroupId != null &&
                    this.CrowdGroupId.Equals(input.CrowdGroupId))
                ) && 
                (
                    this.ItemIds == input.ItemIds ||
                    (this.ItemIds != null &&
                    this.ItemIds.Equals(input.ItemIds))
                ) && 
                (
                    this.MinCost == input.MinCost ||
                    (this.MinCost != null &&
                    this.MinCost.Equals(input.MinCost))
                ) && 
                (
                    this.SuitShops == input.SuitShops ||
                    this.SuitShops != null &&
                    input.SuitShops != null &&
                    this.SuitShops.SequenceEqual(input.SuitShops)
                ) && 
                (
                    this.UserWinCount == input.UserWinCount ||
                    (this.UserWinCount != null &&
                    this.UserWinCount.Equals(input.UserWinCount))
                ) && 
                (
                    this.UserWinFrequency == input.UserWinFrequency ||
                    (this.UserWinFrequency != null &&
                    this.UserWinFrequency.Equals(input.UserWinFrequency))
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
                if (this.CrowdGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdGroupId.GetHashCode();
                }
                if (this.ItemIds != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIds.GetHashCode();
                }
                if (this.MinCost != null)
                {
                    hashCode = (hashCode * 59) + this.MinCost.GetHashCode();
                }
                if (this.SuitShops != null)
                {
                    hashCode = (hashCode * 59) + this.SuitShops.GetHashCode();
                }
                if (this.UserWinCount != null)
                {
                    hashCode = (hashCode * 59) + this.UserWinCount.GetHashCode();
                }
                if (this.UserWinFrequency != null)
                {
                    hashCode = (hashCode * 59) + this.UserWinFrequency.GetHashCode();
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
