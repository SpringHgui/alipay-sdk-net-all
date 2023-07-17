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
    /// AlipayMerchantIotDeviceBindModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIotDeviceBindModel")]
    public partial class AlipayMerchantIotDeviceBindModel : IEquatable<AlipayMerchantIotDeviceBindModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIotDeviceBindModel" /> class.
        /// </summary>
        /// <param name="bizTid">设备 ID ，仅device_id_type 为 ID 时填写。.</param>
        /// <param name="deviceIdType">可选方式。枚举支持： *  ID：表示使用 biztid 作为设备唯一识别标识， *  SN：表示使用 supplier_id、device_sn联合作为设备唯一识别标识。 注意：由于不同机型的supplier_id不同，推荐使用 ID 。.</param>
        /// <param name="deviceSn">设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。.</param>
        /// <param name="merchantType">商户类型。枚举支持： *  direct：直连商户； *  indirect：间连商户。.</param>
        /// <param name="pid">直连场景填写商户收单pid。间连场景填写smid绑定的pid（可通过代运营授权API获取）。.</param>
        /// <param name="shopId">商户pid名下的门店 ID。可通过门店管理API获取，需注意请勿使用smid创建门店 ID。.</param>
        /// <param name="smid">直连场景不填，间连场景填写商户收单smid.</param>
        /// <param name="supplierId">设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。.</param>
        public AlipayMerchantIotDeviceBindModel(string bizTid = default(string), string deviceIdType = default(string), string deviceSn = default(string), string merchantType = default(string), string pid = default(string), string shopId = default(string), string smid = default(string), string supplierId = default(string))
        {
            this.BizTid = bizTid;
            this.DeviceIdType = deviceIdType;
            this.DeviceSn = deviceSn;
            this.MerchantType = merchantType;
            this.Pid = pid;
            this.ShopId = shopId;
            this.Smid = smid;
            this.SupplierId = supplierId;
        }

        /// <summary>
        /// 设备 ID ，仅device_id_type 为 ID 时填写。
        /// </summary>
        /// <value>设备 ID ，仅device_id_type 为 ID 时填写。</value>
        [DataMember(Name = "biz_tid", EmitDefaultValue = false)]
        public string BizTid { get; set; }

        /// <summary>
        /// 可选方式。枚举支持： *  ID：表示使用 biztid 作为设备唯一识别标识， *  SN：表示使用 supplier_id、device_sn联合作为设备唯一识别标识。 注意：由于不同机型的supplier_id不同，推荐使用 ID 。
        /// </summary>
        /// <value>可选方式。枚举支持： *  ID：表示使用 biztid 作为设备唯一识别标识， *  SN：表示使用 supplier_id、device_sn联合作为设备唯一识别标识。 注意：由于不同机型的supplier_id不同，推荐使用 ID 。</value>
        [DataMember(Name = "device_id_type", EmitDefaultValue = false)]
        public string DeviceIdType { get; set; }

        /// <summary>
        /// 设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。
        /// </summary>
        /// <value>设备序列号 ，device_id_type 为 SN 时填写。需配合supplier_id使用。</value>
        [DataMember(Name = "device_sn", EmitDefaultValue = false)]
        public string DeviceSn { get; set; }

        /// <summary>
        /// 商户类型。枚举支持： *  direct：直连商户； *  indirect：间连商户。
        /// </summary>
        /// <value>商户类型。枚举支持： *  direct：直连商户； *  indirect：间连商户。</value>
        [DataMember(Name = "merchant_type", EmitDefaultValue = false)]
        public string MerchantType { get; set; }

        /// <summary>
        /// 直连场景填写商户收单pid。间连场景填写smid绑定的pid（可通过代运营授权API获取）。
        /// </summary>
        /// <value>直连场景填写商户收单pid。间连场景填写smid绑定的pid（可通过代运营授权API获取）。</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 商户pid名下的门店 ID。可通过门店管理API获取，需注意请勿使用smid创建门店 ID。
        /// </summary>
        /// <value>商户pid名下的门店 ID。可通过门店管理API获取，需注意请勿使用smid创建门店 ID。</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 直连场景不填，间连场景填写商户收单smid
        /// </summary>
        /// <value>直连场景不填，间连场景填写商户收单smid</value>
        [DataMember(Name = "smid", EmitDefaultValue = false)]
        public string Smid { get; set; }

        /// <summary>
        /// 设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。
        /// </summary>
        /// <value>设备供应商ID ，device_id_type 为 SN 时填写。需注意不同机型的供应商ID可能不同。</value>
        [DataMember(Name = "supplier_id", EmitDefaultValue = false)]
        public string SupplierId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIotDeviceBindModel {\n");
            sb.Append("  BizTid: ").Append(BizTid).Append("\n");
            sb.Append("  DeviceIdType: ").Append(DeviceIdType).Append("\n");
            sb.Append("  DeviceSn: ").Append(DeviceSn).Append("\n");
            sb.Append("  MerchantType: ").Append(MerchantType).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  Smid: ").Append(Smid).Append("\n");
            sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
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
            return this.Equals(input as AlipayMerchantIotDeviceBindModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIotDeviceBindModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIotDeviceBindModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIotDeviceBindModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizTid == input.BizTid ||
                    (this.BizTid != null &&
                    this.BizTid.Equals(input.BizTid))
                ) && 
                (
                    this.DeviceIdType == input.DeviceIdType ||
                    (this.DeviceIdType != null &&
                    this.DeviceIdType.Equals(input.DeviceIdType))
                ) && 
                (
                    this.DeviceSn == input.DeviceSn ||
                    (this.DeviceSn != null &&
                    this.DeviceSn.Equals(input.DeviceSn))
                ) && 
                (
                    this.MerchantType == input.MerchantType ||
                    (this.MerchantType != null &&
                    this.MerchantType.Equals(input.MerchantType))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.Smid == input.Smid ||
                    (this.Smid != null &&
                    this.Smid.Equals(input.Smid))
                ) && 
                (
                    this.SupplierId == input.SupplierId ||
                    (this.SupplierId != null &&
                    this.SupplierId.Equals(input.SupplierId))
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
                if (this.BizTid != null)
                {
                    hashCode = (hashCode * 59) + this.BizTid.GetHashCode();
                }
                if (this.DeviceIdType != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceIdType.GetHashCode();
                }
                if (this.DeviceSn != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceSn.GetHashCode();
                }
                if (this.MerchantType != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantType.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.Smid != null)
                {
                    hashCode = (hashCode * 59) + this.Smid.GetHashCode();
                }
                if (this.SupplierId != null)
                {
                    hashCode = (hashCode * 59) + this.SupplierId.GetHashCode();
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
