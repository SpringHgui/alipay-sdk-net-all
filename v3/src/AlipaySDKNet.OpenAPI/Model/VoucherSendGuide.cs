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
    /// VoucherSendGuide
    /// </summary>
    [DataContract(Name = "VoucherSendGuide")]
    public partial class VoucherSendGuide : IEquatable<VoucherSendGuide>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSendGuide" /> class.
        /// </summary>
        /// <param name="voucherDetailUrl">领(购)券详情页链接，从支付宝公域跳转到服务商(商户)自定义领(购)券详情页。.</param>
        public VoucherSendGuide(string voucherDetailUrl = default(string))
        {
            this.VoucherDetailUrl = voucherDetailUrl;
        }

        /// <summary>
        /// 领(购)券详情页链接，从支付宝公域跳转到服务商(商户)自定义领(购)券详情页。
        /// </summary>
        /// <value>领(购)券详情页链接，从支付宝公域跳转到服务商(商户)自定义领(购)券详情页。</value>
        [DataMember(Name = "voucher_detail_url", EmitDefaultValue = false)]
        public string VoucherDetailUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherSendGuide {\n");
            sb.Append("  VoucherDetailUrl: ").Append(VoucherDetailUrl).Append("\n");
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
            return this.Equals(input as VoucherSendGuide);
        }

        /// <summary>
        /// Returns true if VoucherSendGuide instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSendGuide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSendGuide input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherDetailUrl == input.VoucherDetailUrl ||
                    (this.VoucherDetailUrl != null &&
                    this.VoucherDetailUrl.Equals(input.VoucherDetailUrl))
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
                if (this.VoucherDetailUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDetailUrl.GetHashCode();
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
