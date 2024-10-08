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
    /// AlipayOfflineMarketApplyorderBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMarketApplyorderBatchqueryModel")]
    public partial class AlipayOfflineMarketApplyorderBatchqueryModel : IEquatable<AlipayOfflineMarketApplyorderBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMarketApplyorderBatchqueryModel" /> class.
        /// </summary>
        /// <param name="action">操作动作.</param>
        /// <param name="applyIds">支付宝流水ID列表，最大不超过100个.</param>
        /// <param name="bizId">业务主体ID。根据biz_type不同可能对应shop_id或item_id。.</param>
        /// <param name="bizType">业务类型：SHOP-店铺，ITEM-商品。.</param>
        /// <param name="endTime">查询的流水创建时间最后值。格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="opId">操作用户的支付账号id.</param>
        /// <param name="opRole">系统集成商统一传入ISV.</param>
        /// <param name="pageNo">页码，留空标示第一页，默认20个结果为一页.</param>
        /// <param name="pageSize">每页记录数。默认20，最大100。.</param>
        /// <param name="requestIds">请求ID列表，最大不超过100个。  注意：暂时不支持此字段查询。.</param>
        /// <param name="startTime">查询的流水创建时间起始值，只能查询近3个月数据。格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="status">流水状态：INIT-初始，PROCESS-处理中，SUCCESS-成功，FAIL-失败。.</param>
        public AlipayOfflineMarketApplyorderBatchqueryModel(string action = default(string), List<string> applyIds = default(List<string>), string bizId = default(string), string bizType = default(string), string endTime = default(string), string opId = default(string), string opRole = default(string), int pageNo = default(int), int pageSize = default(int), List<string> requestIds = default(List<string>), string startTime = default(string), string status = default(string))
        {
            this.Action = action;
            this.ApplyIds = applyIds;
            this.BizId = bizId;
            this.BizType = bizType;
            this.EndTime = endTime;
            this.OpId = opId;
            this.OpRole = opRole;
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.RequestIds = requestIds;
            this.StartTime = startTime;
            this.Status = status;
        }

        /// <summary>
        /// 操作动作
        /// </summary>
        /// <value>操作动作</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 支付宝流水ID列表，最大不超过100个
        /// </summary>
        /// <value>支付宝流水ID列表，最大不超过100个</value>
        [DataMember(Name = "apply_ids", EmitDefaultValue = false)]
        public List<string> ApplyIds { get; set; }

        /// <summary>
        /// 业务主体ID。根据biz_type不同可能对应shop_id或item_id。
        /// </summary>
        /// <value>业务主体ID。根据biz_type不同可能对应shop_id或item_id。</value>
        [DataMember(Name = "biz_id", EmitDefaultValue = false)]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型：SHOP-店铺，ITEM-商品。
        /// </summary>
        /// <value>业务类型：SHOP-店铺，ITEM-商品。</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 查询的流水创建时间最后值。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>查询的流水创建时间最后值。格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        /// <value>操作用户的支付账号id</value>
        [DataMember(Name = "op_id", EmitDefaultValue = false)]
        public string OpId { get; set; }

        /// <summary>
        /// 系统集成商统一传入ISV
        /// </summary>
        /// <value>系统集成商统一传入ISV</value>
        [DataMember(Name = "op_role", EmitDefaultValue = false)]
        public string OpRole { get; set; }

        /// <summary>
        /// 页码，留空标示第一页，默认20个结果为一页
        /// </summary>
        /// <value>页码，留空标示第一页，默认20个结果为一页</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 每页记录数。默认20，最大100。
        /// </summary>
        /// <value>每页记录数。默认20，最大100。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 请求ID列表，最大不超过100个。  注意：暂时不支持此字段查询。
        /// </summary>
        /// <value>请求ID列表，最大不超过100个。  注意：暂时不支持此字段查询。</value>
        [DataMember(Name = "request_ids", EmitDefaultValue = false)]
        public List<string> RequestIds { get; set; }

        /// <summary>
        /// 查询的流水创建时间起始值，只能查询近3个月数据。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>查询的流水创建时间起始值，只能查询近3个月数据。格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 流水状态：INIT-初始，PROCESS-处理中，SUCCESS-成功，FAIL-失败。
        /// </summary>
        /// <value>流水状态：INIT-初始，PROCESS-处理中，SUCCESS-成功，FAIL-失败。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMarketApplyorderBatchqueryModel {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ApplyIds: ").Append(ApplyIds).Append("\n");
            sb.Append("  BizId: ").Append(BizId).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  OpId: ").Append(OpId).Append("\n");
            sb.Append("  OpRole: ").Append(OpRole).Append("\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  RequestIds: ").Append(RequestIds).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayOfflineMarketApplyorderBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMarketApplyorderBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMarketApplyorderBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMarketApplyorderBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.ApplyIds == input.ApplyIds ||
                    this.ApplyIds != null &&
                    input.ApplyIds != null &&
                    this.ApplyIds.SequenceEqual(input.ApplyIds)
                ) && 
                (
                    this.BizId == input.BizId ||
                    (this.BizId != null &&
                    this.BizId.Equals(input.BizId))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.OpId == input.OpId ||
                    (this.OpId != null &&
                    this.OpId.Equals(input.OpId))
                ) && 
                (
                    this.OpRole == input.OpRole ||
                    (this.OpRole != null &&
                    this.OpRole.Equals(input.OpRole))
                ) && 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.RequestIds == input.RequestIds ||
                    this.RequestIds != null &&
                    input.RequestIds != null &&
                    this.RequestIds.SequenceEqual(input.RequestIds)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.ApplyIds != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyIds.GetHashCode();
                }
                if (this.BizId != null)
                {
                    hashCode = (hashCode * 59) + this.BizId.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.OpId != null)
                {
                    hashCode = (hashCode * 59) + this.OpId.GetHashCode();
                }
                if (this.OpRole != null)
                {
                    hashCode = (hashCode * 59) + this.OpRole.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.RequestIds != null)
                {
                    hashCode = (hashCode * 59) + this.RequestIds.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
