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
    /// VoucherRefundDetailInfo
    /// </summary>
    [DataContract(Name = "VoucherRefundDetailInfo")]
    public partial class VoucherRefundDetailInfo : IEquatable<VoucherRefundDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherRefundDetailInfo" /> class.
        /// </summary>
        /// <param name="voucherRefundUseTimes">本次取消核销次数.</param>
        public VoucherRefundDetailInfo(int voucherRefundUseTimes = default(int))
        {
            this.VoucherRefundUseTimes = voucherRefundUseTimes;
        }

        /// <summary>
        /// 本次取消核销次数
        /// </summary>
        /// <value>本次取消核销次数</value>
        [DataMember(Name = "voucher_refund_use_times", EmitDefaultValue = false)]
        public int VoucherRefundUseTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherRefundDetailInfo {\n");
            sb.Append("  VoucherRefundUseTimes: ").Append(VoucherRefundUseTimes).Append("\n");
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
            return this.Equals(input as VoucherRefundDetailInfo);
        }

        /// <summary>
        /// Returns true if VoucherRefundDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherRefundDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherRefundDetailInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherRefundUseTimes == input.VoucherRefundUseTimes ||
                    this.VoucherRefundUseTimes.Equals(input.VoucherRefundUseTimes)
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
                hashCode = (hashCode * 59) + this.VoucherRefundUseTimes.GetHashCode();
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
