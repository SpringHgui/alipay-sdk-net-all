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
    /// AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel")]
    public partial class AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel : IEquatable<AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel" /> class.
        /// </summary>
        /// <param name="equipId">商户同步的充电桩设备编码.</param>
        /// <param name="failReason">绑定关系结果接收失败原因.</param>
        /// <param name="resultStatus">0：成功 1：拒绝.</param>
        public AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel(string equipId = default(string), string failReason = default(string), string resultStatus = default(string))
        {
            this.EquipId = equipId;
            this.FailReason = failReason;
            this.ResultStatus = resultStatus;
        }

        /// <summary>
        /// 商户同步的充电桩设备编码
        /// </summary>
        /// <value>商户同步的充电桩设备编码</value>
        [DataMember(Name = "equip_id", EmitDefaultValue = false)]
        public string EquipId { get; set; }

        /// <summary>
        /// 绑定关系结果接收失败原因
        /// </summary>
        /// <value>绑定关系结果接收失败原因</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 0：成功 1：拒绝
        /// </summary>
        /// <value>0：成功 1：拒绝</value>
        [DataMember(Name = "result_status", EmitDefaultValue = false)]
        public string ResultStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel {\n");
            sb.Append("  EquipId: ").Append(EquipId).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  ResultStatus: ").Append(ResultStatus).Append("\n");
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
            return this.Equals(input as AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceTransportChargerChargerbindinfoSyncResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EquipId == input.EquipId ||
                    (this.EquipId != null &&
                    this.EquipId.Equals(input.EquipId))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.ResultStatus == input.ResultStatus ||
                    (this.ResultStatus != null &&
                    this.ResultStatus.Equals(input.ResultStatus))
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
                if (this.EquipId != null)
                {
                    hashCode = (hashCode * 59) + this.EquipId.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.ResultStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ResultStatus.GetHashCode();
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
