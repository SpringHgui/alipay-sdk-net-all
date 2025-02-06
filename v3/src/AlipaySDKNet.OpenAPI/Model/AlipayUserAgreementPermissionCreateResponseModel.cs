/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// AlipayUserAgreementPermissionCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementPermissionCreateResponseModel")]
    public partial class AlipayUserAgreementPermissionCreateResponseModel : IEquatable<AlipayUserAgreementPermissionCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementPermissionCreateResponseModel" /> class.
        /// </summary>
        /// <param name="deductPermission">商户代扣扣款许可.</param>
        /// <param name="effectiveTimeEnd">商户代扣扣款许可生效结束时间.</param>
        /// <param name="effectiveTimeStart">商户代扣扣款许可生效开始时间.</param>
        /// <param name="isSuccessSend">消息是否发送成功.</param>
        public AlipayUserAgreementPermissionCreateResponseModel(string deductPermission = default(string), string effectiveTimeEnd = default(string), string effectiveTimeStart = default(string), bool isSuccessSend = default(bool))
        {
            this.DeductPermission = deductPermission;
            this.EffectiveTimeEnd = effectiveTimeEnd;
            this.EffectiveTimeStart = effectiveTimeStart;
            this.IsSuccessSend = isSuccessSend;
        }

        /// <summary>
        /// 商户代扣扣款许可
        /// </summary>
        /// <value>商户代扣扣款许可</value>
        [DataMember(Name = "deduct_permission", EmitDefaultValue = false)]
        public string DeductPermission { get; set; }

        /// <summary>
        /// 商户代扣扣款许可生效结束时间
        /// </summary>
        /// <value>商户代扣扣款许可生效结束时间</value>
        [DataMember(Name = "effective_time_end", EmitDefaultValue = false)]
        public string EffectiveTimeEnd { get; set; }

        /// <summary>
        /// 商户代扣扣款许可生效开始时间
        /// </summary>
        /// <value>商户代扣扣款许可生效开始时间</value>
        [DataMember(Name = "effective_time_start", EmitDefaultValue = false)]
        public string EffectiveTimeStart { get; set; }

        /// <summary>
        /// 消息是否发送成功
        /// </summary>
        /// <value>消息是否发送成功</value>
        [DataMember(Name = "is_success_send", EmitDefaultValue = true)]
        public bool IsSuccessSend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAgreementPermissionCreateResponseModel {\n");
            sb.Append("  DeductPermission: ").Append(DeductPermission).Append("\n");
            sb.Append("  EffectiveTimeEnd: ").Append(EffectiveTimeEnd).Append("\n");
            sb.Append("  EffectiveTimeStart: ").Append(EffectiveTimeStart).Append("\n");
            sb.Append("  IsSuccessSend: ").Append(IsSuccessSend).Append("\n");
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
            return this.Equals(input as AlipayUserAgreementPermissionCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementPermissionCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementPermissionCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementPermissionCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeductPermission == input.DeductPermission ||
                    (this.DeductPermission != null &&
                    this.DeductPermission.Equals(input.DeductPermission))
                ) && 
                (
                    this.EffectiveTimeEnd == input.EffectiveTimeEnd ||
                    (this.EffectiveTimeEnd != null &&
                    this.EffectiveTimeEnd.Equals(input.EffectiveTimeEnd))
                ) && 
                (
                    this.EffectiveTimeStart == input.EffectiveTimeStart ||
                    (this.EffectiveTimeStart != null &&
                    this.EffectiveTimeStart.Equals(input.EffectiveTimeStart))
                ) && 
                (
                    this.IsSuccessSend == input.IsSuccessSend ||
                    this.IsSuccessSend.Equals(input.IsSuccessSend)
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
                if (this.DeductPermission != null)
                {
                    hashCode = (hashCode * 59) + this.DeductPermission.GetHashCode();
                }
                if (this.EffectiveTimeEnd != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveTimeEnd.GetHashCode();
                }
                if (this.EffectiveTimeStart != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveTimeStart.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsSuccessSend.GetHashCode();
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
