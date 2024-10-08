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
    /// VoucherDetail
    /// </summary>
    [DataContract(Name = "VoucherDetail")]
    public partial class VoucherDetail : IEquatable<VoucherDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherDetail" /> class.
        /// </summary>
        /// <param name="amount">优惠券面额，它应该会等于商家出资加上其他出资方出资.</param>
        /// <param name="id">券id.</param>
        /// <param name="memo">优惠券备注信息.</param>
        /// <param name="merchantContribute">商家出资（特指发起交易的商家出资金额）.</param>
        /// <param name="name">券名称.</param>
        /// <param name="otherContribute">其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资.</param>
        /// <param name="otherContributeDetail">优惠券的其他出资方明细.</param>
        /// <param name="purchaseAntContribute">如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时平台优惠的金额.</param>
        /// <param name="purchaseBuyerContribute">如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时用户实际付款的金额.</param>
        /// <param name="purchaseMerchantContribute">如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时商户优惠的金额.</param>
        /// <param name="templateId">券模板id.</param>
        /// <param name="type">券类型.</param>
        public VoucherDetail(string amount = default(string), string id = default(string), string memo = default(string), string merchantContribute = default(string), string name = default(string), string otherContribute = default(string), List<ContributeDetail> otherContributeDetail = default(List<ContributeDetail>), string purchaseAntContribute = default(string), string purchaseBuyerContribute = default(string), string purchaseMerchantContribute = default(string), string templateId = default(string), string type = default(string))
        {
            this.Amount = amount;
            this.Id = id;
            this.Memo = memo;
            this.MerchantContribute = merchantContribute;
            this.Name = name;
            this.OtherContribute = otherContribute;
            this.OtherContributeDetail = otherContributeDetail;
            this.PurchaseAntContribute = purchaseAntContribute;
            this.PurchaseBuyerContribute = purchaseBuyerContribute;
            this.PurchaseMerchantContribute = purchaseMerchantContribute;
            this.TemplateId = templateId;
            this.Type = type;
        }

        /// <summary>
        /// 优惠券面额，它应该会等于商家出资加上其他出资方出资
        /// </summary>
        /// <value>优惠券面额，它应该会等于商家出资加上其他出资方出资</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 券id
        /// </summary>
        /// <value>券id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// 优惠券备注信息
        /// </summary>
        /// <value>优惠券备注信息</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 商家出资（特指发起交易的商家出资金额）
        /// </summary>
        /// <value>商家出资（特指发起交易的商家出资金额）</value>
        [DataMember(Name = "merchant_contribute", EmitDefaultValue = false)]
        public string MerchantContribute { get; set; }

        /// <summary>
        /// 券名称
        /// </summary>
        /// <value>券名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资
        /// </summary>
        /// <value>其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资</value>
        [DataMember(Name = "other_contribute", EmitDefaultValue = false)]
        public string OtherContribute { get; set; }

        /// <summary>
        /// 优惠券的其他出资方明细
        /// </summary>
        /// <value>优惠券的其他出资方明细</value>
        [DataMember(Name = "other_contribute_detail", EmitDefaultValue = false)]
        public List<ContributeDetail> OtherContributeDetail { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时平台优惠的金额
        /// </summary>
        /// <value>如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时平台优惠的金额</value>
        [DataMember(Name = "purchase_ant_contribute", EmitDefaultValue = false)]
        public string PurchaseAntContribute { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时用户实际付款的金额
        /// </summary>
        /// <value>如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时用户实际付款的金额</value>
        [DataMember(Name = "purchase_buyer_contribute", EmitDefaultValue = false)]
        public string PurchaseBuyerContribute { get; set; }

        /// <summary>
        /// 如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时商户优惠的金额
        /// </summary>
        /// <value>如果使用的这张券是用户购买的，则该字段代表用户在购买这张券时商户优惠的金额</value>
        [DataMember(Name = "purchase_merchant_contribute", EmitDefaultValue = false)]
        public string PurchaseMerchantContribute { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        /// <value>券模板id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        /// <value>券类型</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherDetail {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MerchantContribute: ").Append(MerchantContribute).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OtherContribute: ").Append(OtherContribute).Append("\n");
            sb.Append("  OtherContributeDetail: ").Append(OtherContributeDetail).Append("\n");
            sb.Append("  PurchaseAntContribute: ").Append(PurchaseAntContribute).Append("\n");
            sb.Append("  PurchaseBuyerContribute: ").Append(PurchaseBuyerContribute).Append("\n");
            sb.Append("  PurchaseMerchantContribute: ").Append(PurchaseMerchantContribute).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as VoucherDetail);
        }

        /// <summary>
        /// Returns true if VoucherDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MerchantContribute == input.MerchantContribute ||
                    (this.MerchantContribute != null &&
                    this.MerchantContribute.Equals(input.MerchantContribute))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OtherContribute == input.OtherContribute ||
                    (this.OtherContribute != null &&
                    this.OtherContribute.Equals(input.OtherContribute))
                ) && 
                (
                    this.OtherContributeDetail == input.OtherContributeDetail ||
                    this.OtherContributeDetail != null &&
                    input.OtherContributeDetail != null &&
                    this.OtherContributeDetail.SequenceEqual(input.OtherContributeDetail)
                ) && 
                (
                    this.PurchaseAntContribute == input.PurchaseAntContribute ||
                    (this.PurchaseAntContribute != null &&
                    this.PurchaseAntContribute.Equals(input.PurchaseAntContribute))
                ) && 
                (
                    this.PurchaseBuyerContribute == input.PurchaseBuyerContribute ||
                    (this.PurchaseBuyerContribute != null &&
                    this.PurchaseBuyerContribute.Equals(input.PurchaseBuyerContribute))
                ) && 
                (
                    this.PurchaseMerchantContribute == input.PurchaseMerchantContribute ||
                    (this.PurchaseMerchantContribute != null &&
                    this.PurchaseMerchantContribute.Equals(input.PurchaseMerchantContribute))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MerchantContribute != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantContribute.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OtherContribute != null)
                {
                    hashCode = (hashCode * 59) + this.OtherContribute.GetHashCode();
                }
                if (this.OtherContributeDetail != null)
                {
                    hashCode = (hashCode * 59) + this.OtherContributeDetail.GetHashCode();
                }
                if (this.PurchaseAntContribute != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseAntContribute.GetHashCode();
                }
                if (this.PurchaseBuyerContribute != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseBuyerContribute.GetHashCode();
                }
                if (this.PurchaseMerchantContribute != null)
                {
                    hashCode = (hashCode * 59) + this.PurchaseMerchantContribute.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
