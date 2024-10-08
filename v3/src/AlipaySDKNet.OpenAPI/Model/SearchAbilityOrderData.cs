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
    /// SearchAbilityOrderData
    /// </summary>
    [DataContract(Name = "SearchAbilityOrderData")]
    public partial class SearchAbilityOrderData : IEquatable<SearchAbilityOrderData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAbilityOrderData" /> class.
        /// </summary>
        /// <param name="accessType">申请单类型.</param>
        /// <param name="appName">小程序名称.</param>
        /// <param name="appStatus">小程序状态 ON_LINE、OFF_LINE.</param>
        /// <param name="appid">小程序id.</param>
        /// <param name="applyId">申请单id.</param>
        /// <param name="applyType">申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达.</param>
        /// <param name="auditStatus">申请状态 AGREE、REJECT、EDIT、AUDIT.</param>
        /// <param name="bizId">bizId 为品牌box的boxID.</param>
        /// <param name="boxStatus">品牌box的上下架状态 ONLINE OFFLINE.</param>
        /// <param name="brandTemplateId">品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四.</param>
        /// <param name="children">二级服务信息.</param>
        /// <param name="dataKey">二级服务的唯一标识.</param>
        /// <param name="gmtModified">更新时间.</param>
        /// <param name="id">服务的唯一标识（优先使用serviceCode可忽略）.</param>
        /// <param name="isOldData">是否是老工单.</param>
        /// <param name="majorStatus">服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效.</param>
        /// <param name="onlineTime">上架时间.</param>
        /// <param name="openStatus">服务的可见性状态.</param>
        /// <param name="_operator">下架操作者.</param>
        /// <param name="rejectReason">驳回原因.</param>
        /// <param name="sceneCode">场景码.</param>
        /// <param name="sceneName">场景名称.</param>
        /// <param name="serviceCode">服务码.</param>
        /// <param name="subServiceDesc">子功能描述.</param>
        /// <param name="subServiceName">子功能名称.</param>
        public SearchAbilityOrderData(string accessType = default(string), string appName = default(string), string appStatus = default(string), string appid = default(string), string applyId = default(string), string applyType = default(string), string auditStatus = default(string), string bizId = default(string), string boxStatus = default(string), string brandTemplateId = default(string), List<SearchAbilityOrderInfoOpenApi> children = default(List<SearchAbilityOrderInfoOpenApi>), string dataKey = default(string), string gmtModified = default(string), string id = default(string), string isOldData = default(string), string majorStatus = default(string), string onlineTime = default(string), bool openStatus = default(bool), string _operator = default(string), string rejectReason = default(string), string sceneCode = default(string), string sceneName = default(string), string serviceCode = default(string), string subServiceDesc = default(string), string subServiceName = default(string))
        {
            this.AccessType = accessType;
            this.AppName = appName;
            this.AppStatus = appStatus;
            this.Appid = appid;
            this.ApplyId = applyId;
            this.ApplyType = applyType;
            this.AuditStatus = auditStatus;
            this.BizId = bizId;
            this.BoxStatus = boxStatus;
            this.BrandTemplateId = brandTemplateId;
            this.Children = children;
            this.DataKey = dataKey;
            this.GmtModified = gmtModified;
            this.Id = id;
            this.IsOldData = isOldData;
            this.MajorStatus = majorStatus;
            this.OnlineTime = onlineTime;
            this.OpenStatus = openStatus;
            this.Operator = _operator;
            this.RejectReason = rejectReason;
            this.SceneCode = sceneCode;
            this.SceneName = sceneName;
            this.ServiceCode = serviceCode;
            this.SubServiceDesc = subServiceDesc;
            this.SubServiceName = subServiceName;
        }

        /// <summary>
        /// 申请单类型
        /// </summary>
        /// <value>申请单类型</value>
        [DataMember(Name = "access_type", EmitDefaultValue = false)]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        /// <value>小程序名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序状态 ON_LINE、OFF_LINE
        /// </summary>
        /// <value>小程序状态 ON_LINE、OFF_LINE</value>
        [DataMember(Name = "app_status", EmitDefaultValue = false)]
        public string AppStatus { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        /// <value>小程序id</value>
        [DataMember(Name = "appid", EmitDefaultValue = false)]
        public string Appid { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        /// <value>申请单id</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        /// <value>申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达</value>
        [DataMember(Name = "apply_type", EmitDefaultValue = false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// 申请状态 AGREE、REJECT、EDIT、AUDIT
        /// </summary>
        /// <value>申请状态 AGREE、REJECT、EDIT、AUDIT</value>
        [DataMember(Name = "audit_status", EmitDefaultValue = false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// bizId 为品牌box的boxID
        /// </summary>
        /// <value>bizId 为品牌box的boxID</value>
        [DataMember(Name = "biz_id", EmitDefaultValue = false)]
        public string BizId { get; set; }

        /// <summary>
        /// 品牌box的上下架状态 ONLINE OFFLINE
        /// </summary>
        /// <value>品牌box的上下架状态 ONLINE OFFLINE</value>
        [DataMember(Name = "box_status", EmitDefaultValue = false)]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        /// <value>品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四</value>
        [DataMember(Name = "brand_template_id", EmitDefaultValue = false)]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// 二级服务信息
        /// </summary>
        /// <value>二级服务信息</value>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public List<SearchAbilityOrderInfoOpenApi> Children { get; set; }

        /// <summary>
        /// 二级服务的唯一标识
        /// </summary>
        /// <value>二级服务的唯一标识</value>
        [DataMember(Name = "data_key", EmitDefaultValue = false)]
        public string DataKey { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <value>更新时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 服务的唯一标识（优先使用serviceCode可忽略）
        /// </summary>
        /// <value>服务的唯一标识（优先使用serviceCode可忽略）</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// 是否是老工单
        /// </summary>
        /// <value>是否是老工单</value>
        [DataMember(Name = "is_old_data", EmitDefaultValue = false)]
        public string IsOldData { get; set; }

        /// <summary>
        /// 服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效
        /// </summary>
        /// <value>服务主状态,INITIAL:初始化；VALID：已生效；INVALID：已失效</value>
        [DataMember(Name = "major_status", EmitDefaultValue = false)]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        /// <value>上架时间</value>
        [DataMember(Name = "online_time", EmitDefaultValue = false)]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 服务的可见性状态
        /// </summary>
        /// <value>服务的可见性状态</value>
        [DataMember(Name = "open_status", EmitDefaultValue = true)]
        public bool OpenStatus { get; set; }

        /// <summary>
        /// 下架操作者
        /// </summary>
        /// <value>下架操作者</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        /// <value>驳回原因</value>
        [DataMember(Name = "reject_reason", EmitDefaultValue = false)]
        public string RejectReason { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        /// <value>场景码</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 场景名称
        /// </summary>
        /// <value>场景名称</value>
        [DataMember(Name = "scene_name", EmitDefaultValue = false)]
        public string SceneName { get; set; }

        /// <summary>
        /// 服务码
        /// </summary>
        /// <value>服务码</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 子功能描述
        /// </summary>
        /// <value>子功能描述</value>
        [DataMember(Name = "sub_service_desc", EmitDefaultValue = false)]
        public string SubServiceDesc { get; set; }

        /// <summary>
        /// 子功能名称
        /// </summary>
        /// <value>子功能名称</value>
        [DataMember(Name = "sub_service_name", EmitDefaultValue = false)]
        public string SubServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchAbilityOrderData {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppStatus: ").Append(AppStatus).Append("\n");
            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  ApplyType: ").Append(ApplyType).Append("\n");
            sb.Append("  AuditStatus: ").Append(AuditStatus).Append("\n");
            sb.Append("  BizId: ").Append(BizId).Append("\n");
            sb.Append("  BoxStatus: ").Append(BoxStatus).Append("\n");
            sb.Append("  BrandTemplateId: ").Append(BrandTemplateId).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  DataKey: ").Append(DataKey).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsOldData: ").Append(IsOldData).Append("\n");
            sb.Append("  MajorStatus: ").Append(MajorStatus).Append("\n");
            sb.Append("  OnlineTime: ").Append(OnlineTime).Append("\n");
            sb.Append("  OpenStatus: ").Append(OpenStatus).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SceneName: ").Append(SceneName).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  SubServiceDesc: ").Append(SubServiceDesc).Append("\n");
            sb.Append("  SubServiceName: ").Append(SubServiceName).Append("\n");
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
            return this.Equals(input as SearchAbilityOrderData);
        }

        /// <summary>
        /// Returns true if SearchAbilityOrderData instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchAbilityOrderData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchAbilityOrderData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessType == input.AccessType ||
                    (this.AccessType != null &&
                    this.AccessType.Equals(input.AccessType))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppStatus == input.AppStatus ||
                    (this.AppStatus != null &&
                    this.AppStatus.Equals(input.AppStatus))
                ) && 
                (
                    this.Appid == input.Appid ||
                    (this.Appid != null &&
                    this.Appid.Equals(input.Appid))
                ) && 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.ApplyType == input.ApplyType ||
                    (this.ApplyType != null &&
                    this.ApplyType.Equals(input.ApplyType))
                ) && 
                (
                    this.AuditStatus == input.AuditStatus ||
                    (this.AuditStatus != null &&
                    this.AuditStatus.Equals(input.AuditStatus))
                ) && 
                (
                    this.BizId == input.BizId ||
                    (this.BizId != null &&
                    this.BizId.Equals(input.BizId))
                ) && 
                (
                    this.BoxStatus == input.BoxStatus ||
                    (this.BoxStatus != null &&
                    this.BoxStatus.Equals(input.BoxStatus))
                ) && 
                (
                    this.BrandTemplateId == input.BrandTemplateId ||
                    (this.BrandTemplateId != null &&
                    this.BrandTemplateId.Equals(input.BrandTemplateId))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.DataKey == input.DataKey ||
                    (this.DataKey != null &&
                    this.DataKey.Equals(input.DataKey))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsOldData == input.IsOldData ||
                    (this.IsOldData != null &&
                    this.IsOldData.Equals(input.IsOldData))
                ) && 
                (
                    this.MajorStatus == input.MajorStatus ||
                    (this.MajorStatus != null &&
                    this.MajorStatus.Equals(input.MajorStatus))
                ) && 
                (
                    this.OnlineTime == input.OnlineTime ||
                    (this.OnlineTime != null &&
                    this.OnlineTime.Equals(input.OnlineTime))
                ) && 
                (
                    this.OpenStatus == input.OpenStatus ||
                    this.OpenStatus.Equals(input.OpenStatus)
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.RejectReason == input.RejectReason ||
                    (this.RejectReason != null &&
                    this.RejectReason.Equals(input.RejectReason))
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.SceneName == input.SceneName ||
                    (this.SceneName != null &&
                    this.SceneName.Equals(input.SceneName))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.SubServiceDesc == input.SubServiceDesc ||
                    (this.SubServiceDesc != null &&
                    this.SubServiceDesc.Equals(input.SubServiceDesc))
                ) && 
                (
                    this.SubServiceName == input.SubServiceName ||
                    (this.SubServiceName != null &&
                    this.SubServiceName.Equals(input.SubServiceName))
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
                if (this.AccessType != null)
                {
                    hashCode = (hashCode * 59) + this.AccessType.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AppStatus.GetHashCode();
                }
                if (this.Appid != null)
                {
                    hashCode = (hashCode * 59) + this.Appid.GetHashCode();
                }
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.ApplyType != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyType.GetHashCode();
                }
                if (this.AuditStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AuditStatus.GetHashCode();
                }
                if (this.BizId != null)
                {
                    hashCode = (hashCode * 59) + this.BizId.GetHashCode();
                }
                if (this.BoxStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BoxStatus.GetHashCode();
                }
                if (this.BrandTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.BrandTemplateId.GetHashCode();
                }
                if (this.Children != null)
                {
                    hashCode = (hashCode * 59) + this.Children.GetHashCode();
                }
                if (this.DataKey != null)
                {
                    hashCode = (hashCode * 59) + this.DataKey.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IsOldData != null)
                {
                    hashCode = (hashCode * 59) + this.IsOldData.GetHashCode();
                }
                if (this.MajorStatus != null)
                {
                    hashCode = (hashCode * 59) + this.MajorStatus.GetHashCode();
                }
                if (this.OnlineTime != null)
                {
                    hashCode = (hashCode * 59) + this.OnlineTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OpenStatus.GetHashCode();
                if (this.Operator != null)
                {
                    hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                }
                if (this.RejectReason != null)
                {
                    hashCode = (hashCode * 59) + this.RejectReason.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.SceneName != null)
                {
                    hashCode = (hashCode * 59) + this.SceneName.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.SubServiceDesc != null)
                {
                    hashCode = (hashCode * 59) + this.SubServiceDesc.GetHashCode();
                }
                if (this.SubServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.SubServiceName.GetHashCode();
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
