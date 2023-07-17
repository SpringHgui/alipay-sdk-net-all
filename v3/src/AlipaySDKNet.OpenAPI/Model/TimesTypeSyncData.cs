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
    /// TimesTypeSyncData
    /// </summary>
    [DataContract(Name = "TimesTypeSyncData")]
    public partial class TimesTypeSyncData : IEquatable<TimesTypeSyncData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimesTypeSyncData" /> class.
        /// </summary>
        /// <param name="discountAmount">商户回传的优惠金额，如用户享受的红包金额，单位元.</param>
        /// <param name="discountDesc">商户数据回传的优惠信息的名称。.</param>
        /// <param name="taskAmount">用户和商户发生交易的交易单金额，单位元。.</param>
        /// <param name="taskDesc">任务描述.</param>
        /// <param name="taskTimes">当为次数型任务时必须传。.</param>
        public TimesTypeSyncData(string discountAmount = default(string), string discountDesc = default(string), string taskAmount = default(string), string taskDesc = default(string), int taskTimes = default(int))
        {
            this.DiscountAmount = discountAmount;
            this.DiscountDesc = discountDesc;
            this.TaskAmount = taskAmount;
            this.TaskDesc = taskDesc;
            this.TaskTimes = taskTimes;
        }

        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        /// <value>商户回传的优惠金额，如用户享受的红包金额，单位元</value>
        [DataMember(Name = "discount_amount", EmitDefaultValue = false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称。
        /// </summary>
        /// <value>商户数据回传的优惠信息的名称。</value>
        [DataMember(Name = "discount_desc", EmitDefaultValue = false)]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 用户和商户发生交易的交易单金额，单位元。
        /// </summary>
        /// <value>用户和商户发生交易的交易单金额，单位元。</value>
        [DataMember(Name = "task_amount", EmitDefaultValue = false)]
        public string TaskAmount { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        /// <value>任务描述</value>
        [DataMember(Name = "task_desc", EmitDefaultValue = false)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 当为次数型任务时必须传。
        /// </summary>
        /// <value>当为次数型任务时必须传。</value>
        [DataMember(Name = "task_times", EmitDefaultValue = false)]
        public int TaskTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimesTypeSyncData {\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountDesc: ").Append(DiscountDesc).Append("\n");
            sb.Append("  TaskAmount: ").Append(TaskAmount).Append("\n");
            sb.Append("  TaskDesc: ").Append(TaskDesc).Append("\n");
            sb.Append("  TaskTimes: ").Append(TaskTimes).Append("\n");
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
            return this.Equals(input as TimesTypeSyncData);
        }

        /// <summary>
        /// Returns true if TimesTypeSyncData instances are equal
        /// </summary>
        /// <param name="input">Instance of TimesTypeSyncData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimesTypeSyncData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.DiscountDesc == input.DiscountDesc ||
                    (this.DiscountDesc != null &&
                    this.DiscountDesc.Equals(input.DiscountDesc))
                ) && 
                (
                    this.TaskAmount == input.TaskAmount ||
                    (this.TaskAmount != null &&
                    this.TaskAmount.Equals(input.TaskAmount))
                ) && 
                (
                    this.TaskDesc == input.TaskDesc ||
                    (this.TaskDesc != null &&
                    this.TaskDesc.Equals(input.TaskDesc))
                ) && 
                (
                    this.TaskTimes == input.TaskTimes ||
                    this.TaskTimes.Equals(input.TaskTimes)
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
                if (this.DiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                }
                if (this.DiscountDesc != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountDesc.GetHashCode();
                }
                if (this.TaskAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaskAmount.GetHashCode();
                }
                if (this.TaskDesc != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDesc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaskTimes.GetHashCode();
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
