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
    /// SearchOrderDetailData
    /// </summary>
    [DataContract(Name = "SearchOrderDetailData")]
    public partial class SearchOrderDetailData : IEquatable<SearchOrderDetailData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrderDetailData" /> class.
        /// </summary>
        /// <param name="accessType">申请单类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达.</param>
        /// <param name="appCategory">小程序类目名.</param>
        /// <param name="appIcon">小程序图标.</param>
        /// <param name="appName">小程序名称.</param>
        /// <param name="appStatus">小程序状态.</param>
        /// <param name="appid">小程序ID.</param>
        /// <param name="baseOrderStatus">baseOrderStatus.</param>
        /// <param name="bizId">bizid 业务id.</param>
        /// <param name="boxOrderStatus">boxOrderStatus.</param>
        /// <param name="boxStatus">上下架状态 ONLINE OFFLINE.</param>
        /// <param name="brandTemplateId">品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四.</param>
        /// <param name="brandboxOrderstatus">brandboxOrderstatus.</param>
        /// <param name="canModifyKeyword">是否可修改关键词.</param>
        /// <param name="describe">服务描述.</param>
        /// <param name="detailBaseItems">detailBaseItems.</param>
        /// <param name="detailBrandItems">detailBrandItems.</param>
        /// <param name="detailServiceItems">detailServiceItems.</param>
        /// <param name="finalStatus">最终状态.</param>
        /// <param name="gmtmodified">最后修改时间.</param>
        /// <param name="keywordGmtModified">关键词的修改时间.</param>
        /// <param name="onlineTime">上架时间.</param>
        /// <param name="operatorType">操作人员类型.</param>
        /// <param name="orderId">申请单id.</param>
        /// <param name="partnerType">查询服务提供者生态类型 一二三方 1 | 2 | 3.</param>
        /// <param name="rejectNode">驳回节点.</param>
        /// <param name="rejectReason">驳回原因.</param>
        /// <param name="sceneCode">场景码.</param>
        /// <param name="sceneName">场景名称.</param>
        /// <param name="serviceCode">服务code.</param>
        /// <param name="serviceName">服务名.</param>
        /// <param name="status">申请单状态  AGREE、REJECT、AUDIT.</param>
        /// <param name="subServiceCode">二级服务code.</param>
        /// <param name="templateId">模板Id.</param>
        /// <param name="templateName">模板名称.</param>
        public SearchOrderDetailData(string accessType = default(string), string appCategory = default(string), string appIcon = default(string), string appName = default(string), string appStatus = default(string), string appid = default(string), OrderStatusData baseOrderStatus = default(OrderStatusData), string bizId = default(string), OrderStatusData boxOrderStatus = default(OrderStatusData), string boxStatus = default(string), string brandTemplateId = default(string), OrderStatusData brandboxOrderstatus = default(OrderStatusData), bool canModifyKeyword = default(bool), string describe = default(string), SearchOrderDetailDataBaseItems detailBaseItems = default(SearchOrderDetailDataBaseItems), SearchOrderDetailDataBrandItems detailBrandItems = default(SearchOrderDetailDataBrandItems), SearchOrderDetailDataServiceItems detailServiceItems = default(SearchOrderDetailDataServiceItems), string finalStatus = default(string), string gmtmodified = default(string), string keywordGmtModified = default(string), string onlineTime = default(string), string operatorType = default(string), string orderId = default(string), string partnerType = default(string), string rejectNode = default(string), string rejectReason = default(string), string sceneCode = default(string), string sceneName = default(string), string serviceCode = default(string), string serviceName = default(string), string status = default(string), string subServiceCode = default(string), string templateId = default(string), string templateName = default(string))
        {
            this.AccessType = accessType;
            this.AppCategory = appCategory;
            this.AppIcon = appIcon;
            this.AppName = appName;
            this.AppStatus = appStatus;
            this.Appid = appid;
            this.BaseOrderStatus = baseOrderStatus;
            this.BizId = bizId;
            this.BoxOrderStatus = boxOrderStatus;
            this.BoxStatus = boxStatus;
            this.BrandTemplateId = brandTemplateId;
            this.BrandboxOrderstatus = brandboxOrderstatus;
            this.CanModifyKeyword = canModifyKeyword;
            this.Describe = describe;
            this.DetailBaseItems = detailBaseItems;
            this.DetailBrandItems = detailBrandItems;
            this.DetailServiceItems = detailServiceItems;
            this.FinalStatus = finalStatus;
            this.Gmtmodified = gmtmodified;
            this.KeywordGmtModified = keywordGmtModified;
            this.OnlineTime = onlineTime;
            this.OperatorType = operatorType;
            this.OrderId = orderId;
            this.PartnerType = partnerType;
            this.RejectNode = rejectNode;
            this.RejectReason = rejectReason;
            this.SceneCode = sceneCode;
            this.SceneName = sceneName;
            this.ServiceCode = serviceCode;
            this.ServiceName = serviceName;
            this.Status = status;
            this.SubServiceCode = subServiceCode;
            this.TemplateId = templateId;
            this.TemplateName = templateName;
        }

        /// <summary>
        /// 申请单类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        /// <value>申请单类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达</value>
        [DataMember(Name = "access_type", EmitDefaultValue = false)]
        public string AccessType { get; set; }

        /// <summary>
        /// 小程序类目名
        /// </summary>
        /// <value>小程序类目名</value>
        [DataMember(Name = "app_category", EmitDefaultValue = false)]
        public string AppCategory { get; set; }

        /// <summary>
        /// 小程序图标
        /// </summary>
        /// <value>小程序图标</value>
        [DataMember(Name = "app_icon", EmitDefaultValue = false)]
        public string AppIcon { get; set; }

        /// <summary>
        /// 小程序名称
        /// </summary>
        /// <value>小程序名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        /// <value>小程序状态</value>
        [DataMember(Name = "app_status", EmitDefaultValue = false)]
        public string AppStatus { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        /// <value>小程序ID</value>
        [DataMember(Name = "appid", EmitDefaultValue = false)]
        public string Appid { get; set; }

        /// <summary>
        /// Gets or Sets BaseOrderStatus
        /// </summary>
        [DataMember(Name = "base_order_status", EmitDefaultValue = false)]
        public OrderStatusData BaseOrderStatus { get; set; }

        /// <summary>
        /// bizid 业务id
        /// </summary>
        /// <value>bizid 业务id</value>
        [DataMember(Name = "biz_id", EmitDefaultValue = false)]
        public string BizId { get; set; }

        /// <summary>
        /// Gets or Sets BoxOrderStatus
        /// </summary>
        [DataMember(Name = "box_order_status", EmitDefaultValue = false)]
        public OrderStatusData BoxOrderStatus { get; set; }

        /// <summary>
        /// 上下架状态 ONLINE OFFLINE
        /// </summary>
        /// <value>上下架状态 ONLINE OFFLINE</value>
        [DataMember(Name = "box_status", EmitDefaultValue = false)]
        public string BoxStatus { get; set; }

        /// <summary>
        /// 品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四
        /// </summary>
        /// <value>品牌的模板id ONE_WITH_TWO：一拖二、DEFAULT：一拖四</value>
        [DataMember(Name = "brand_template_id", EmitDefaultValue = false)]
        public string BrandTemplateId { get; set; }

        /// <summary>
        /// Gets or Sets BrandboxOrderstatus
        /// </summary>
        [DataMember(Name = "brandbox_orderstatus", EmitDefaultValue = false)]
        public OrderStatusData BrandboxOrderstatus { get; set; }

        /// <summary>
        /// 是否可修改关键词
        /// </summary>
        /// <value>是否可修改关键词</value>
        [DataMember(Name = "can_modify_keyword", EmitDefaultValue = true)]
        public bool CanModifyKeyword { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        /// <value>服务描述</value>
        [DataMember(Name = "describe", EmitDefaultValue = false)]
        public string Describe { get; set; }

        /// <summary>
        /// Gets or Sets DetailBaseItems
        /// </summary>
        [DataMember(Name = "detail_base_items", EmitDefaultValue = false)]
        public SearchOrderDetailDataBaseItems DetailBaseItems { get; set; }

        /// <summary>
        /// Gets or Sets DetailBrandItems
        /// </summary>
        [DataMember(Name = "detail_brand_items", EmitDefaultValue = false)]
        public SearchOrderDetailDataBrandItems DetailBrandItems { get; set; }

        /// <summary>
        /// Gets or Sets DetailServiceItems
        /// </summary>
        [DataMember(Name = "detail_service_items", EmitDefaultValue = false)]
        public SearchOrderDetailDataServiceItems DetailServiceItems { get; set; }

        /// <summary>
        /// 最终状态
        /// </summary>
        /// <value>最终状态</value>
        [DataMember(Name = "final_status", EmitDefaultValue = false)]
        public string FinalStatus { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        /// <value>最后修改时间</value>
        [DataMember(Name = "gmtmodified", EmitDefaultValue = false)]
        public string Gmtmodified { get; set; }

        /// <summary>
        /// 关键词的修改时间
        /// </summary>
        /// <value>关键词的修改时间</value>
        [DataMember(Name = "keyword_gmt_modified", EmitDefaultValue = false)]
        public string KeywordGmtModified { get; set; }

        /// <summary>
        /// 上架时间
        /// </summary>
        /// <value>上架时间</value>
        [DataMember(Name = "online_time", EmitDefaultValue = false)]
        public string OnlineTime { get; set; }

        /// <summary>
        /// 操作人员类型
        /// </summary>
        /// <value>操作人员类型</value>
        [DataMember(Name = "operator_type", EmitDefaultValue = false)]
        public string OperatorType { get; set; }

        /// <summary>
        /// 申请单id
        /// </summary>
        /// <value>申请单id</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 查询服务提供者生态类型 一二三方 1 | 2 | 3
        /// </summary>
        /// <value>查询服务提供者生态类型 一二三方 1 | 2 | 3</value>
        [DataMember(Name = "partner_type", EmitDefaultValue = false)]
        public string PartnerType { get; set; }

        /// <summary>
        /// 驳回节点
        /// </summary>
        /// <value>驳回节点</value>
        [DataMember(Name = "reject_node", EmitDefaultValue = false)]
        public string RejectNode { get; set; }

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
        /// 服务code
        /// </summary>
        /// <value>服务code</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名
        /// </summary>
        /// <value>服务名</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 申请单状态  AGREE、REJECT、AUDIT
        /// </summary>
        /// <value>申请单状态  AGREE、REJECT、AUDIT</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        /// <value>二级服务code</value>
        [DataMember(Name = "sub_service_code", EmitDefaultValue = false)]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 模板Id
        /// </summary>
        /// <value>模板Id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        /// <value>模板名称</value>
        [DataMember(Name = "template_name", EmitDefaultValue = false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchOrderDetailData {\n");
            sb.Append("  AccessType: ").Append(AccessType).Append("\n");
            sb.Append("  AppCategory: ").Append(AppCategory).Append("\n");
            sb.Append("  AppIcon: ").Append(AppIcon).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppStatus: ").Append(AppStatus).Append("\n");
            sb.Append("  Appid: ").Append(Appid).Append("\n");
            sb.Append("  BaseOrderStatus: ").Append(BaseOrderStatus).Append("\n");
            sb.Append("  BizId: ").Append(BizId).Append("\n");
            sb.Append("  BoxOrderStatus: ").Append(BoxOrderStatus).Append("\n");
            sb.Append("  BoxStatus: ").Append(BoxStatus).Append("\n");
            sb.Append("  BrandTemplateId: ").Append(BrandTemplateId).Append("\n");
            sb.Append("  BrandboxOrderstatus: ").Append(BrandboxOrderstatus).Append("\n");
            sb.Append("  CanModifyKeyword: ").Append(CanModifyKeyword).Append("\n");
            sb.Append("  Describe: ").Append(Describe).Append("\n");
            sb.Append("  DetailBaseItems: ").Append(DetailBaseItems).Append("\n");
            sb.Append("  DetailBrandItems: ").Append(DetailBrandItems).Append("\n");
            sb.Append("  DetailServiceItems: ").Append(DetailServiceItems).Append("\n");
            sb.Append("  FinalStatus: ").Append(FinalStatus).Append("\n");
            sb.Append("  Gmtmodified: ").Append(Gmtmodified).Append("\n");
            sb.Append("  KeywordGmtModified: ").Append(KeywordGmtModified).Append("\n");
            sb.Append("  OnlineTime: ").Append(OnlineTime).Append("\n");
            sb.Append("  OperatorType: ").Append(OperatorType).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PartnerType: ").Append(PartnerType).Append("\n");
            sb.Append("  RejectNode: ").Append(RejectNode).Append("\n");
            sb.Append("  RejectReason: ").Append(RejectReason).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SceneName: ").Append(SceneName).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubServiceCode: ").Append(SubServiceCode).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
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
            return this.Equals(input as SearchOrderDetailData);
        }

        /// <summary>
        /// Returns true if SearchOrderDetailData instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchOrderDetailData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrderDetailData input)
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
                    this.AppCategory == input.AppCategory ||
                    (this.AppCategory != null &&
                    this.AppCategory.Equals(input.AppCategory))
                ) && 
                (
                    this.AppIcon == input.AppIcon ||
                    (this.AppIcon != null &&
                    this.AppIcon.Equals(input.AppIcon))
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
                    this.BaseOrderStatus == input.BaseOrderStatus ||
                    (this.BaseOrderStatus != null &&
                    this.BaseOrderStatus.Equals(input.BaseOrderStatus))
                ) && 
                (
                    this.BizId == input.BizId ||
                    (this.BizId != null &&
                    this.BizId.Equals(input.BizId))
                ) && 
                (
                    this.BoxOrderStatus == input.BoxOrderStatus ||
                    (this.BoxOrderStatus != null &&
                    this.BoxOrderStatus.Equals(input.BoxOrderStatus))
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
                    this.BrandboxOrderstatus == input.BrandboxOrderstatus ||
                    (this.BrandboxOrderstatus != null &&
                    this.BrandboxOrderstatus.Equals(input.BrandboxOrderstatus))
                ) && 
                (
                    this.CanModifyKeyword == input.CanModifyKeyword ||
                    this.CanModifyKeyword.Equals(input.CanModifyKeyword)
                ) && 
                (
                    this.Describe == input.Describe ||
                    (this.Describe != null &&
                    this.Describe.Equals(input.Describe))
                ) && 
                (
                    this.DetailBaseItems == input.DetailBaseItems ||
                    (this.DetailBaseItems != null &&
                    this.DetailBaseItems.Equals(input.DetailBaseItems))
                ) && 
                (
                    this.DetailBrandItems == input.DetailBrandItems ||
                    (this.DetailBrandItems != null &&
                    this.DetailBrandItems.Equals(input.DetailBrandItems))
                ) && 
                (
                    this.DetailServiceItems == input.DetailServiceItems ||
                    (this.DetailServiceItems != null &&
                    this.DetailServiceItems.Equals(input.DetailServiceItems))
                ) && 
                (
                    this.FinalStatus == input.FinalStatus ||
                    (this.FinalStatus != null &&
                    this.FinalStatus.Equals(input.FinalStatus))
                ) && 
                (
                    this.Gmtmodified == input.Gmtmodified ||
                    (this.Gmtmodified != null &&
                    this.Gmtmodified.Equals(input.Gmtmodified))
                ) && 
                (
                    this.KeywordGmtModified == input.KeywordGmtModified ||
                    (this.KeywordGmtModified != null &&
                    this.KeywordGmtModified.Equals(input.KeywordGmtModified))
                ) && 
                (
                    this.OnlineTime == input.OnlineTime ||
                    (this.OnlineTime != null &&
                    this.OnlineTime.Equals(input.OnlineTime))
                ) && 
                (
                    this.OperatorType == input.OperatorType ||
                    (this.OperatorType != null &&
                    this.OperatorType.Equals(input.OperatorType))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PartnerType == input.PartnerType ||
                    (this.PartnerType != null &&
                    this.PartnerType.Equals(input.PartnerType))
                ) && 
                (
                    this.RejectNode == input.RejectNode ||
                    (this.RejectNode != null &&
                    this.RejectNode.Equals(input.RejectNode))
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
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubServiceCode == input.SubServiceCode ||
                    (this.SubServiceCode != null &&
                    this.SubServiceCode.Equals(input.SubServiceCode))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
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
                if (this.AppCategory != null)
                {
                    hashCode = (hashCode * 59) + this.AppCategory.GetHashCode();
                }
                if (this.AppIcon != null)
                {
                    hashCode = (hashCode * 59) + this.AppIcon.GetHashCode();
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
                if (this.BaseOrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BaseOrderStatus.GetHashCode();
                }
                if (this.BizId != null)
                {
                    hashCode = (hashCode * 59) + this.BizId.GetHashCode();
                }
                if (this.BoxOrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BoxOrderStatus.GetHashCode();
                }
                if (this.BoxStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BoxStatus.GetHashCode();
                }
                if (this.BrandTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.BrandTemplateId.GetHashCode();
                }
                if (this.BrandboxOrderstatus != null)
                {
                    hashCode = (hashCode * 59) + this.BrandboxOrderstatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CanModifyKeyword.GetHashCode();
                if (this.Describe != null)
                {
                    hashCode = (hashCode * 59) + this.Describe.GetHashCode();
                }
                if (this.DetailBaseItems != null)
                {
                    hashCode = (hashCode * 59) + this.DetailBaseItems.GetHashCode();
                }
                if (this.DetailBrandItems != null)
                {
                    hashCode = (hashCode * 59) + this.DetailBrandItems.GetHashCode();
                }
                if (this.DetailServiceItems != null)
                {
                    hashCode = (hashCode * 59) + this.DetailServiceItems.GetHashCode();
                }
                if (this.FinalStatus != null)
                {
                    hashCode = (hashCode * 59) + this.FinalStatus.GetHashCode();
                }
                if (this.Gmtmodified != null)
                {
                    hashCode = (hashCode * 59) + this.Gmtmodified.GetHashCode();
                }
                if (this.KeywordGmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.KeywordGmtModified.GetHashCode();
                }
                if (this.OnlineTime != null)
                {
                    hashCode = (hashCode * 59) + this.OnlineTime.GetHashCode();
                }
                if (this.OperatorType != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorType.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.PartnerType != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerType.GetHashCode();
                }
                if (this.RejectNode != null)
                {
                    hashCode = (hashCode * 59) + this.RejectNode.GetHashCode();
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
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubServiceCode.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateName != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateName.GetHashCode();
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
