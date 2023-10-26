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
    /// SearchApplyPageQueryRequest
    /// </summary>
    [DataContract(Name = "SearchApplyPageQueryRequest")]
    public partial class SearchApplyPageQueryRequest : IEquatable<SearchApplyPageQueryRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApplyPageQueryRequest" /> class.
        /// </summary>
        /// <param name="applyType">申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达.</param>
        /// <param name="auditStatusList">筛选状态数组 AUDIT AGREE REJECT CANCEL EDIT.</param>
        /// <param name="categoryCode">类目编码.</param>
        /// <param name="name">服务名称.</param>
        /// <param name="pageNum">当前页码.</param>
        /// <param name="pageSize">页面的显示记录条数.</param>
        /// <param name="serviceCode">服务code.</param>
        /// <param name="serviceId">小程序appid.</param>
        /// <param name="startRow">起始记录，起始：0.</param>
        /// <param name="subServiceCode">二级服务code.</param>
        public SearchApplyPageQueryRequest(string applyType = default(string), List<string> auditStatusList = default(List<string>), string categoryCode = default(string), string name = default(string), string pageNum = default(string), string pageSize = default(string), string serviceCode = default(string), string serviceId = default(string), string startRow = default(string), string subServiceCode = default(string))
        {
            this.ApplyType = applyType;
            this.AuditStatusList = auditStatusList;
            this.CategoryCode = categoryCode;
            this.Name = name;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.ServiceCode = serviceCode;
            this.ServiceId = serviceId;
            this.StartRow = startRow;
            this.SubServiceCode = subServiceCode;
        }

        /// <summary>
        /// 申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达
        /// </summary>
        /// <value>申请类型 BASE：基础信息， BRAND_BOX：品牌直达，SERVICE_BOX服务直达</value>
        [DataMember(Name = "apply_type", EmitDefaultValue = false)]
        public string ApplyType { get; set; }

        /// <summary>
        /// 筛选状态数组 AUDIT AGREE REJECT CANCEL EDIT
        /// </summary>
        /// <value>筛选状态数组 AUDIT AGREE REJECT CANCEL EDIT</value>
        [DataMember(Name = "audit_status_list", EmitDefaultValue = false)]
        public List<string> AuditStatusList { get; set; }

        /// <summary>
        /// 类目编码
        /// </summary>
        /// <value>类目编码</value>
        [DataMember(Name = "category_code", EmitDefaultValue = false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <value>服务名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        /// <value>当前页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 页面的显示记录条数
        /// </summary>
        /// <value>页面的显示记录条数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        /// <value>服务code</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        /// <value>小程序appid</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 起始记录，起始：0
        /// </summary>
        /// <value>起始记录，起始：0</value>
        [DataMember(Name = "start_row", EmitDefaultValue = false)]
        public string StartRow { get; set; }

        /// <summary>
        /// 二级服务code
        /// </summary>
        /// <value>二级服务code</value>
        [DataMember(Name = "sub_service_code", EmitDefaultValue = false)]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchApplyPageQueryRequest {\n");
            sb.Append("  ApplyType: ").Append(ApplyType).Append("\n");
            sb.Append("  AuditStatusList: ").Append(AuditStatusList).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  StartRow: ").Append(StartRow).Append("\n");
            sb.Append("  SubServiceCode: ").Append(SubServiceCode).Append("\n");
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
            return this.Equals(input as SearchApplyPageQueryRequest);
        }

        /// <summary>
        /// Returns true if SearchApplyPageQueryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchApplyPageQueryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchApplyPageQueryRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyType == input.ApplyType ||
                    (this.ApplyType != null &&
                    this.ApplyType.Equals(input.ApplyType))
                ) && 
                (
                    this.AuditStatusList == input.AuditStatusList ||
                    this.AuditStatusList != null &&
                    input.AuditStatusList != null &&
                    this.AuditStatusList.SequenceEqual(input.AuditStatusList)
                ) && 
                (
                    this.CategoryCode == input.CategoryCode ||
                    (this.CategoryCode != null &&
                    this.CategoryCode.Equals(input.CategoryCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    (this.PageNum != null &&
                    this.PageNum.Equals(input.PageNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.StartRow == input.StartRow ||
                    (this.StartRow != null &&
                    this.StartRow.Equals(input.StartRow))
                ) && 
                (
                    this.SubServiceCode == input.SubServiceCode ||
                    (this.SubServiceCode != null &&
                    this.SubServiceCode.Equals(input.SubServiceCode))
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
                if (this.ApplyType != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyType.GetHashCode();
                }
                if (this.AuditStatusList != null)
                {
                    hashCode = (hashCode * 59) + this.AuditStatusList.GetHashCode();
                }
                if (this.CategoryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryCode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.StartRow != null)
                {
                    hashCode = (hashCode * 59) + this.StartRow.GetHashCode();
                }
                if (this.SubServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubServiceCode.GetHashCode();
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
