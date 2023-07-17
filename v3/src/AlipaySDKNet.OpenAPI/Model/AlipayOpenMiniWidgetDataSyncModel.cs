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
    /// AlipayOpenMiniWidgetDataSyncModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniWidgetDataSyncModel")]
    public partial class AlipayOpenMiniWidgetDataSyncModel : IEquatable<AlipayOpenMiniWidgetDataSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniWidgetDataSyncModel" /> class.
        /// </summary>
        /// <param name="activityList">活动信息列表.</param>
        /// <param name="dataType">数据类型，可选值：ACTIVITY(活动数据)、GOODS(商品数据).</param>
        /// <param name="goodsList">商品信息列表.</param>
        /// <param name="miniAppId">商家小程序ID.</param>
        /// <param name="pid">小程序背后的商家，和mini_app_id要求对应.</param>
        public AlipayOpenMiniWidgetDataSyncModel(List<WidgetActivityInfo> activityList = default(List<WidgetActivityInfo>), string dataType = default(string), List<WidgetGoodsInfo> goodsList = default(List<WidgetGoodsInfo>), string miniAppId = default(string), string pid = default(string))
        {
            this.ActivityList = activityList;
            this.DataType = dataType;
            this.GoodsList = goodsList;
            this.MiniAppId = miniAppId;
            this.Pid = pid;
        }

        /// <summary>
        /// 活动信息列表
        /// </summary>
        /// <value>活动信息列表</value>
        [DataMember(Name = "activity_list", EmitDefaultValue = false)]
        public List<WidgetActivityInfo> ActivityList { get; set; }

        /// <summary>
        /// 数据类型，可选值：ACTIVITY(活动数据)、GOODS(商品数据)
        /// </summary>
        /// <value>数据类型，可选值：ACTIVITY(活动数据)、GOODS(商品数据)</value>
        [DataMember(Name = "data_type", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        /// <value>商品信息列表</value>
        [DataMember(Name = "goods_list", EmitDefaultValue = false)]
        public List<WidgetGoodsInfo> GoodsList { get; set; }

        /// <summary>
        /// 商家小程序ID
        /// </summary>
        /// <value>商家小程序ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序背后的商家，和mini_app_id要求对应
        /// </summary>
        /// <value>小程序背后的商家，和mini_app_id要求对应</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniWidgetDataSyncModel {\n");
            sb.Append("  ActivityList: ").Append(ActivityList).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  GoodsList: ").Append(GoodsList).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniWidgetDataSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniWidgetDataSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniWidgetDataSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniWidgetDataSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityList == input.ActivityList ||
                    this.ActivityList != null &&
                    input.ActivityList != null &&
                    this.ActivityList.SequenceEqual(input.ActivityList)
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.GoodsList == input.GoodsList ||
                    this.GoodsList != null &&
                    input.GoodsList != null &&
                    this.GoodsList.SequenceEqual(input.GoodsList)
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
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
                if (this.ActivityList != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityList.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                if (this.GoodsList != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsList.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
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
