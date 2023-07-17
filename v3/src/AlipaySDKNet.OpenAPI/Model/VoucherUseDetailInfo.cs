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
    /// VoucherUseDetailInfo
    /// </summary>
    [DataContract(Name = "VoucherUseDetailInfo")]
    public partial class VoucherUseDetailInfo : IEquatable<VoucherUseDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUseDetailInfo" /> class.
        /// </summary>
        /// <param name="voucherUseTimes">本次核销次数.</param>
        public VoucherUseDetailInfo(int voucherUseTimes = default(int))
        {
            this.VoucherUseTimes = voucherUseTimes;
        }

        /// <summary>
        /// 本次核销次数
        /// </summary>
        /// <value>本次核销次数</value>
        [DataMember(Name = "voucher_use_times", EmitDefaultValue = false)]
        public int VoucherUseTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherUseDetailInfo {\n");
            sb.Append("  VoucherUseTimes: ").Append(VoucherUseTimes).Append("\n");
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
            return this.Equals(input as VoucherUseDetailInfo);
        }

        /// <summary>
        /// Returns true if VoucherUseDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUseDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUseDetailInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherUseTimes == input.VoucherUseTimes ||
                    this.VoucherUseTimes.Equals(input.VoucherUseTimes)
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
                hashCode = (hashCode * 59) + this.VoucherUseTimes.GetHashCode();
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
