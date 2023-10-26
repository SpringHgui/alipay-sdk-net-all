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
    /// MerchantOnlineActivityOpenModel
    /// </summary>
    [DataContract(Name = "MerchantOnlineActivityOpenModel")]
    public partial class MerchantOnlineActivityOpenModel : IEquatable<MerchantOnlineActivityOpenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantOnlineActivityOpenModel" /> class.
        /// </summary>
        /// <param name="activityId">活动Id.</param>
        /// <param name="campId">营销活动Id.</param>
        /// <param name="countLimit">活动优惠次数限制.</param>
        /// <param name="countLimitPerDay">活动优惠单日次数限制.</param>
        /// <param name="countLimitPerUser">活动单用户限次.</param>
        /// <param name="countLimitPerUserPerDay">活动单用户单日限次.</param>
        /// <param name="crowd">人群规则  DEFAULT：全部用户  ONLINE_NEWCOMER：在线购买新人  MEMBER：会员.</param>
        /// <param name="deductAmount">代金券面额.</param>
        /// <param name="externalUniqueId">外部Id.</param>
        /// <param name="gmtEnd">活动结束时间  格式为：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="gmtStart">活动开始时间，格式为:yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="itemIds">商品列表.</param>
        /// <param name="memo">备注.</param>
        /// <param name="minCost">使用门槛，满X元可用，使用门槛必须大于券面额.</param>
        /// <param name="obtainManually">是否手动领取，本期只支持true.</param>
        /// <param name="voucherInfo">voucherInfo.</param>
        public MerchantOnlineActivityOpenModel(string activityId = default(string), string campId = default(string), int countLimit = default(int), int countLimitPerDay = default(int), int countLimitPerUser = default(int), int countLimitPerUserPerDay = default(int), string crowd = default(string), string deductAmount = default(string), string externalUniqueId = default(string), string gmtEnd = default(string), string gmtStart = default(string), List<string> itemIds = default(List<string>), string memo = default(string), string minCost = default(string), bool obtainManually = default(bool), MerchantActivityVoucherInfo voucherInfo = default(MerchantActivityVoucherInfo))
        {
            this.ActivityId = activityId;
            this.CampId = campId;
            this.CountLimit = countLimit;
            this.CountLimitPerDay = countLimitPerDay;
            this.CountLimitPerUser = countLimitPerUser;
            this.CountLimitPerUserPerDay = countLimitPerUserPerDay;
            this.Crowd = crowd;
            this.DeductAmount = deductAmount;
            this.ExternalUniqueId = externalUniqueId;
            this.GmtEnd = gmtEnd;
            this.GmtStart = gmtStart;
            this.ItemIds = itemIds;
            this.Memo = memo;
            this.MinCost = minCost;
            this.ObtainManually = obtainManually;
            this.VoucherInfo = voucherInfo;
        }

        /// <summary>
        /// 活动Id
        /// </summary>
        /// <value>活动Id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 营销活动Id
        /// </summary>
        /// <value>营销活动Id</value>
        [DataMember(Name = "camp_id", EmitDefaultValue = false)]
        public string CampId { get; set; }

        /// <summary>
        /// 活动优惠次数限制
        /// </summary>
        /// <value>活动优惠次数限制</value>
        [DataMember(Name = "count_limit", EmitDefaultValue = false)]
        public int CountLimit { get; set; }

        /// <summary>
        /// 活动优惠单日次数限制
        /// </summary>
        /// <value>活动优惠单日次数限制</value>
        [DataMember(Name = "count_limit_per_day", EmitDefaultValue = false)]
        public int CountLimitPerDay { get; set; }

        /// <summary>
        /// 活动单用户限次
        /// </summary>
        /// <value>活动单用户限次</value>
        [DataMember(Name = "count_limit_per_user", EmitDefaultValue = false)]
        public int CountLimitPerUser { get; set; }

        /// <summary>
        /// 活动单用户单日限次
        /// </summary>
        /// <value>活动单用户单日限次</value>
        [DataMember(Name = "count_limit_per_user_per_day", EmitDefaultValue = false)]
        public int CountLimitPerUserPerDay { get; set; }

        /// <summary>
        /// 人群规则  DEFAULT：全部用户  ONLINE_NEWCOMER：在线购买新人  MEMBER：会员
        /// </summary>
        /// <value>人群规则  DEFAULT：全部用户  ONLINE_NEWCOMER：在线购买新人  MEMBER：会员</value>
        [DataMember(Name = "crowd", EmitDefaultValue = false)]
        public string Crowd { get; set; }

        /// <summary>
        /// 代金券面额
        /// </summary>
        /// <value>代金券面额</value>
        [DataMember(Name = "deduct_amount", EmitDefaultValue = false)]
        public string DeductAmount { get; set; }

        /// <summary>
        /// 外部Id
        /// </summary>
        /// <value>外部Id</value>
        [DataMember(Name = "external_unique_id", EmitDefaultValue = false)]
        public string ExternalUniqueId { get; set; }

        /// <summary>
        /// 活动结束时间  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>活动结束时间  格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "gmt_end", EmitDefaultValue = false)]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 活动开始时间，格式为:yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>活动开始时间，格式为:yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "gmt_start", EmitDefaultValue = false)]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品列表
        /// </summary>
        /// <value>商品列表</value>
        [DataMember(Name = "item_ids", EmitDefaultValue = false)]
        public List<string> ItemIds { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 使用门槛，满X元可用，使用门槛必须大于券面额
        /// </summary>
        /// <value>使用门槛，满X元可用，使用门槛必须大于券面额</value>
        [DataMember(Name = "min_cost", EmitDefaultValue = false)]
        public string MinCost { get; set; }

        /// <summary>
        /// 是否手动领取，本期只支持true
        /// </summary>
        /// <value>是否手动领取，本期只支持true</value>
        [DataMember(Name = "obtain_manually", EmitDefaultValue = true)]
        public bool ObtainManually { get; set; }

        /// <summary>
        /// Gets or Sets VoucherInfo
        /// </summary>
        [DataMember(Name = "voucher_info", EmitDefaultValue = false)]
        public MerchantActivityVoucherInfo VoucherInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantOnlineActivityOpenModel {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  CampId: ").Append(CampId).Append("\n");
            sb.Append("  CountLimit: ").Append(CountLimit).Append("\n");
            sb.Append("  CountLimitPerDay: ").Append(CountLimitPerDay).Append("\n");
            sb.Append("  CountLimitPerUser: ").Append(CountLimitPerUser).Append("\n");
            sb.Append("  CountLimitPerUserPerDay: ").Append(CountLimitPerUserPerDay).Append("\n");
            sb.Append("  Crowd: ").Append(Crowd).Append("\n");
            sb.Append("  DeductAmount: ").Append(DeductAmount).Append("\n");
            sb.Append("  ExternalUniqueId: ").Append(ExternalUniqueId).Append("\n");
            sb.Append("  GmtEnd: ").Append(GmtEnd).Append("\n");
            sb.Append("  GmtStart: ").Append(GmtStart).Append("\n");
            sb.Append("  ItemIds: ").Append(ItemIds).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MinCost: ").Append(MinCost).Append("\n");
            sb.Append("  ObtainManually: ").Append(ObtainManually).Append("\n");
            sb.Append("  VoucherInfo: ").Append(VoucherInfo).Append("\n");
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
            return this.Equals(input as MerchantOnlineActivityOpenModel);
        }

        /// <summary>
        /// Returns true if MerchantOnlineActivityOpenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantOnlineActivityOpenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantOnlineActivityOpenModel input)
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
                    this.CampId == input.CampId ||
                    (this.CampId != null &&
                    this.CampId.Equals(input.CampId))
                ) && 
                (
                    this.CountLimit == input.CountLimit ||
                    this.CountLimit.Equals(input.CountLimit)
                ) && 
                (
                    this.CountLimitPerDay == input.CountLimitPerDay ||
                    this.CountLimitPerDay.Equals(input.CountLimitPerDay)
                ) && 
                (
                    this.CountLimitPerUser == input.CountLimitPerUser ||
                    this.CountLimitPerUser.Equals(input.CountLimitPerUser)
                ) && 
                (
                    this.CountLimitPerUserPerDay == input.CountLimitPerUserPerDay ||
                    this.CountLimitPerUserPerDay.Equals(input.CountLimitPerUserPerDay)
                ) && 
                (
                    this.Crowd == input.Crowd ||
                    (this.Crowd != null &&
                    this.Crowd.Equals(input.Crowd))
                ) && 
                (
                    this.DeductAmount == input.DeductAmount ||
                    (this.DeductAmount != null &&
                    this.DeductAmount.Equals(input.DeductAmount))
                ) && 
                (
                    this.ExternalUniqueId == input.ExternalUniqueId ||
                    (this.ExternalUniqueId != null &&
                    this.ExternalUniqueId.Equals(input.ExternalUniqueId))
                ) && 
                (
                    this.GmtEnd == input.GmtEnd ||
                    (this.GmtEnd != null &&
                    this.GmtEnd.Equals(input.GmtEnd))
                ) && 
                (
                    this.GmtStart == input.GmtStart ||
                    (this.GmtStart != null &&
                    this.GmtStart.Equals(input.GmtStart))
                ) && 
                (
                    this.ItemIds == input.ItemIds ||
                    this.ItemIds != null &&
                    input.ItemIds != null &&
                    this.ItemIds.SequenceEqual(input.ItemIds)
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MinCost == input.MinCost ||
                    (this.MinCost != null &&
                    this.MinCost.Equals(input.MinCost))
                ) && 
                (
                    this.ObtainManually == input.ObtainManually ||
                    this.ObtainManually.Equals(input.ObtainManually)
                ) && 
                (
                    this.VoucherInfo == input.VoucherInfo ||
                    (this.VoucherInfo != null &&
                    this.VoucherInfo.Equals(input.VoucherInfo))
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
                if (this.CampId != null)
                {
                    hashCode = (hashCode * 59) + this.CampId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CountLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.CountLimitPerDay.GetHashCode();
                hashCode = (hashCode * 59) + this.CountLimitPerUser.GetHashCode();
                hashCode = (hashCode * 59) + this.CountLimitPerUserPerDay.GetHashCode();
                if (this.Crowd != null)
                {
                    hashCode = (hashCode * 59) + this.Crowd.GetHashCode();
                }
                if (this.DeductAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DeductAmount.GetHashCode();
                }
                if (this.ExternalUniqueId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalUniqueId.GetHashCode();
                }
                if (this.GmtEnd != null)
                {
                    hashCode = (hashCode * 59) + this.GmtEnd.GetHashCode();
                }
                if (this.GmtStart != null)
                {
                    hashCode = (hashCode * 59) + this.GmtStart.GetHashCode();
                }
                if (this.ItemIds != null)
                {
                    hashCode = (hashCode * 59) + this.ItemIds.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MinCost != null)
                {
                    hashCode = (hashCode * 59) + this.MinCost.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ObtainManually.GetHashCode();
                if (this.VoucherInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherInfo.GetHashCode();
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
