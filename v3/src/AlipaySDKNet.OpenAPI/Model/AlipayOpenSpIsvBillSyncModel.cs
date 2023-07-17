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
    /// AlipayOpenSpIsvBillSyncModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpIsvBillSyncModel")]
    public partial class AlipayOpenSpIsvBillSyncModel : IEquatable<AlipayOpenSpIsvBillSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpIsvBillSyncModel" /> class.
        /// </summary>
        /// <param name="endTime">账单结束时间.</param>
        /// <param name="generateTime">出账时间，回传出账信息时，必须传递.</param>
        /// <param name="itemCode">服务优选商品编码.</param>
        /// <param name="outBizNo">外部业务号，传isv系统生成的账单号，需要保证唯一.</param>
        /// <param name="payTime">账单支付时间，回传支付数时，必须传递.</param>
        /// <param name="price">账单金额，这里填写的是整数，单位为分，比如1元，那么输入100.</param>
        /// <param name="promotorPid">推广服务商(S2)pid.</param>
        /// <param name="startTime">账单开始时间.</param>
        /// <param name="status">GENERATE_BILL代表”已出账“，PAID_BILL代表”已支付“，选择这两者之一.</param>
        /// <param name="subPromotorPid">S1回传的S2的操作员工子账号，如果是子账号操作，请回传.</param>
        public AlipayOpenSpIsvBillSyncModel(string endTime = default(string), string generateTime = default(string), string itemCode = default(string), string outBizNo = default(string), string payTime = default(string), string price = default(string), string promotorPid = default(string), string startTime = default(string), string status = default(string), string subPromotorPid = default(string))
        {
            this.EndTime = endTime;
            this.GenerateTime = generateTime;
            this.ItemCode = itemCode;
            this.OutBizNo = outBizNo;
            this.PayTime = payTime;
            this.Price = price;
            this.PromotorPid = promotorPid;
            this.StartTime = startTime;
            this.Status = status;
            this.SubPromotorPid = subPromotorPid;
        }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        /// <value>账单结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 出账时间，回传出账信息时，必须传递
        /// </summary>
        /// <value>出账时间，回传出账信息时，必须传递</value>
        [DataMember(Name = "generate_time", EmitDefaultValue = false)]
        public string GenerateTime { get; set; }

        /// <summary>
        /// 服务优选商品编码
        /// </summary>
        /// <value>服务优选商品编码</value>
        [DataMember(Name = "item_code", EmitDefaultValue = false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// 外部业务号，传isv系统生成的账单号，需要保证唯一
        /// </summary>
        /// <value>外部业务号，传isv系统生成的账单号，需要保证唯一</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 账单支付时间，回传支付数时，必须传递
        /// </summary>
        /// <value>账单支付时间，回传支付数时，必须传递</value>
        [DataMember(Name = "pay_time", EmitDefaultValue = false)]
        public string PayTime { get; set; }

        /// <summary>
        /// 账单金额，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        /// <value>账单金额，这里填写的是整数，单位为分，比如1元，那么输入100</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        /// <value>推广服务商(S2)pid</value>
        [DataMember(Name = "promotor_pid", EmitDefaultValue = false)]
        public string PromotorPid { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        /// <value>账单开始时间</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// GENERATE_BILL代表”已出账“，PAID_BILL代表”已支付“，选择这两者之一
        /// </summary>
        /// <value>GENERATE_BILL代表”已出账“，PAID_BILL代表”已支付“，选择这两者之一</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// S1回传的S2的操作员工子账号，如果是子账号操作，请回传
        /// </summary>
        /// <value>S1回传的S2的操作员工子账号，如果是子账号操作，请回传</value>
        [DataMember(Name = "sub_promotor_pid", EmitDefaultValue = false)]
        public string SubPromotorPid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpIsvBillSyncModel {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  GenerateTime: ").Append(GenerateTime).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PayTime: ").Append(PayTime).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PromotorPid: ").Append(PromotorPid).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubPromotorPid: ").Append(SubPromotorPid).Append("\n");
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
            return this.Equals(input as AlipayOpenSpIsvBillSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpIsvBillSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpIsvBillSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpIsvBillSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.GenerateTime == input.GenerateTime ||
                    (this.GenerateTime != null &&
                    this.GenerateTime.Equals(input.GenerateTime))
                ) && 
                (
                    this.ItemCode == input.ItemCode ||
                    (this.ItemCode != null &&
                    this.ItemCode.Equals(input.ItemCode))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PayTime == input.PayTime ||
                    (this.PayTime != null &&
                    this.PayTime.Equals(input.PayTime))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PromotorPid == input.PromotorPid ||
                    (this.PromotorPid != null &&
                    this.PromotorPid.Equals(input.PromotorPid))
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
                ) && 
                (
                    this.SubPromotorPid == input.SubPromotorPid ||
                    (this.SubPromotorPid != null &&
                    this.SubPromotorPid.Equals(input.SubPromotorPid))
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
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.GenerateTime != null)
                {
                    hashCode = (hashCode * 59) + this.GenerateTime.GetHashCode();
                }
                if (this.ItemCode != null)
                {
                    hashCode = (hashCode * 59) + this.ItemCode.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PayTime != null)
                {
                    hashCode = (hashCode * 59) + this.PayTime.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.PromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.PromotorPid.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubPromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.SubPromotorPid.GetHashCode();
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
