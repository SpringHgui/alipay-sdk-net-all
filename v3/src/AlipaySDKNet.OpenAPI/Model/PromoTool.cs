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
    /// PromoTool
    /// </summary>
    [DataContract(Name = "PromoTool")]
    public partial class PromoTool : IEquatable<PromoTool>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoTool" /> class.
        /// </summary>
        /// <param name="pointCard">pointCard.</param>
        /// <param name="sendRule">sendRule.</param>
        /// <param name="status">单个营销工具的生效状态，当在招商部分券失效后会使用这个字段.</param>
        /// <param name="voucher">voucher.</param>
        /// <param name="voucherNo">营销工具uid,创建营销活动时无需设置.</param>
        public PromoTool(PointCard pointCard = default(PointCard), SendRule sendRule = default(SendRule), string status = default(string), Voucher voucher = default(Voucher), string voucherNo = default(string))
        {
            this.PointCard = pointCard;
            this.SendRule = sendRule;
            this.Status = status;
            this.Voucher = voucher;
            this.VoucherNo = voucherNo;
        }

        /// <summary>
        /// Gets or Sets PointCard
        /// </summary>
        [DataMember(Name = "point_card", EmitDefaultValue = false)]
        public PointCard PointCard { get; set; }

        /// <summary>
        /// Gets or Sets SendRule
        /// </summary>
        [DataMember(Name = "send_rule", EmitDefaultValue = false)]
        public SendRule SendRule { get; set; }

        /// <summary>
        /// 单个营销工具的生效状态，当在招商部分券失效后会使用这个字段
        /// </summary>
        /// <value>单个营销工具的生效状态，当在招商部分券失效后会使用这个字段</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Voucher
        /// </summary>
        [DataMember(Name = "voucher", EmitDefaultValue = false)]
        public Voucher Voucher { get; set; }

        /// <summary>
        /// 营销工具uid,创建营销活动时无需设置
        /// </summary>
        /// <value>营销工具uid,创建营销活动时无需设置</value>
        [DataMember(Name = "voucher_no", EmitDefaultValue = false)]
        public string VoucherNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromoTool {\n");
            sb.Append("  PointCard: ").Append(PointCard).Append("\n");
            sb.Append("  SendRule: ").Append(SendRule).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Voucher: ").Append(Voucher).Append("\n");
            sb.Append("  VoucherNo: ").Append(VoucherNo).Append("\n");
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
            return this.Equals(input as PromoTool);
        }

        /// <summary>
        /// Returns true if PromoTool instances are equal
        /// </summary>
        /// <param name="input">Instance of PromoTool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromoTool input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PointCard == input.PointCard ||
                    (this.PointCard != null &&
                    this.PointCard.Equals(input.PointCard))
                ) && 
                (
                    this.SendRule == input.SendRule ||
                    (this.SendRule != null &&
                    this.SendRule.Equals(input.SendRule))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Voucher == input.Voucher ||
                    (this.Voucher != null &&
                    this.Voucher.Equals(input.Voucher))
                ) && 
                (
                    this.VoucherNo == input.VoucherNo ||
                    (this.VoucherNo != null &&
                    this.VoucherNo.Equals(input.VoucherNo))
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
                if (this.PointCard != null)
                {
                    hashCode = (hashCode * 59) + this.PointCard.GetHashCode();
                }
                if (this.SendRule != null)
                {
                    hashCode = (hashCode * 59) + this.SendRule.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Voucher != null)
                {
                    hashCode = (hashCode * 59) + this.Voucher.GetHashCode();
                }
                if (this.VoucherNo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherNo.GetHashCode();
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
