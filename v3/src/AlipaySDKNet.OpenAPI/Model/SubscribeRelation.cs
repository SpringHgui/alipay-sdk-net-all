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
    /// SubscribeRelation
    /// </summary>
    [DataContract(Name = "SubscribeRelation")]
    public partial class SubscribeRelation : IEquatable<SubscribeRelation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscribeRelation" /> class.
        /// </summary>
        /// <param name="keepState">订阅保持状态，即用户勾选“总是保持以上选择，不再询问”选项时勾选的订阅状态。枚举值： 0：保持订阅。 1：保持拒绝订阅。 说明：若用户“总是保持以上选择，不再询问”选项，且选择订阅消息。下次触发消息订阅组件时，支付宝将自动发起一次静默订阅（不再拉起订阅组件，无需用户手动订阅）。.</param>
        /// <param name="show">模板是否展示在订阅组件中。枚举值： true：订阅组件中展示查询的模板。 false：订阅组件中不展示模板.</param>
        /// <param name="subscribeState">订阅状态。枚举值 0：拒绝订阅。 1：订阅.</param>
        /// <param name="subscribeType">消息模板的订阅类型。枚举值： longterm：长期性订阅 onetime：一次性订阅.</param>
        /// <param name="templateId">消息模板id.</param>
        public SubscribeRelation(string keepState = default(string), bool show = default(bool), string subscribeState = default(string), string subscribeType = default(string), string templateId = default(string))
        {
            this.KeepState = keepState;
            this.Show = show;
            this.SubscribeState = subscribeState;
            this.SubscribeType = subscribeType;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// 订阅保持状态，即用户勾选“总是保持以上选择，不再询问”选项时勾选的订阅状态。枚举值： 0：保持订阅。 1：保持拒绝订阅。 说明：若用户“总是保持以上选择，不再询问”选项，且选择订阅消息。下次触发消息订阅组件时，支付宝将自动发起一次静默订阅（不再拉起订阅组件，无需用户手动订阅）。
        /// </summary>
        /// <value>订阅保持状态，即用户勾选“总是保持以上选择，不再询问”选项时勾选的订阅状态。枚举值： 0：保持订阅。 1：保持拒绝订阅。 说明：若用户“总是保持以上选择，不再询问”选项，且选择订阅消息。下次触发消息订阅组件时，支付宝将自动发起一次静默订阅（不再拉起订阅组件，无需用户手动订阅）。</value>
        [DataMember(Name = "keep_state", EmitDefaultValue = false)]
        public string KeepState { get; set; }

        /// <summary>
        /// 模板是否展示在订阅组件中。枚举值： true：订阅组件中展示查询的模板。 false：订阅组件中不展示模板
        /// </summary>
        /// <value>模板是否展示在订阅组件中。枚举值： true：订阅组件中展示查询的模板。 false：订阅组件中不展示模板</value>
        [DataMember(Name = "show", EmitDefaultValue = true)]
        public bool Show { get; set; }

        /// <summary>
        /// 订阅状态。枚举值 0：拒绝订阅。 1：订阅
        /// </summary>
        /// <value>订阅状态。枚举值 0：拒绝订阅。 1：订阅</value>
        [DataMember(Name = "subscribe_state", EmitDefaultValue = false)]
        public string SubscribeState { get; set; }

        /// <summary>
        /// 消息模板的订阅类型。枚举值： longterm：长期性订阅 onetime：一次性订阅
        /// </summary>
        /// <value>消息模板的订阅类型。枚举值： longterm：长期性订阅 onetime：一次性订阅</value>
        [DataMember(Name = "subscribe_type", EmitDefaultValue = false)]
        public string SubscribeType { get; set; }

        /// <summary>
        /// 消息模板id
        /// </summary>
        /// <value>消息模板id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscribeRelation {\n");
            sb.Append("  KeepState: ").Append(KeepState).Append("\n");
            sb.Append("  Show: ").Append(Show).Append("\n");
            sb.Append("  SubscribeState: ").Append(SubscribeState).Append("\n");
            sb.Append("  SubscribeType: ").Append(SubscribeType).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(input as SubscribeRelation);
        }

        /// <summary>
        /// Returns true if SubscribeRelation instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscribeRelation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscribeRelation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeepState == input.KeepState ||
                    (this.KeepState != null &&
                    this.KeepState.Equals(input.KeepState))
                ) && 
                (
                    this.Show == input.Show ||
                    this.Show.Equals(input.Show)
                ) && 
                (
                    this.SubscribeState == input.SubscribeState ||
                    (this.SubscribeState != null &&
                    this.SubscribeState.Equals(input.SubscribeState))
                ) && 
                (
                    this.SubscribeType == input.SubscribeType ||
                    (this.SubscribeType != null &&
                    this.SubscribeType.Equals(input.SubscribeType))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.KeepState != null)
                {
                    hashCode = (hashCode * 59) + this.KeepState.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Show.GetHashCode();
                if (this.SubscribeState != null)
                {
                    hashCode = (hashCode * 59) + this.SubscribeState.GetHashCode();
                }
                if (this.SubscribeType != null)
                {
                    hashCode = (hashCode * 59) + this.SubscribeType.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
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
