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
    /// AlipayFundAccountbookNotifyUnsubscribeModel
    /// </summary>
    [DataContract(Name = "AlipayFundAccountbookNotifyUnsubscribeModel")]
    public partial class AlipayFundAccountbookNotifyUnsubscribeModel : IEquatable<AlipayFundAccountbookNotifyUnsubscribeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAccountbookNotifyUnsubscribeModel" /> class.
        /// </summary>
        /// <param name="accountBookId">记账本ID.</param>
        /// <param name="agreementNo">协议号。 若是基于协议的记账本，则agreement_no必传； 若是自创建的记账本，则agreement_no不传；.</param>
        /// <param name="bizScene">场景码。固定为DEFAULT.</param>
        /// <param name="productCode">产品码。固定为SATF_FUND_BOOK.</param>
        public AlipayFundAccountbookNotifyUnsubscribeModel(string accountBookId = default(string), string agreementNo = default(string), string bizScene = default(string), string productCode = default(string))
        {
            this.AccountBookId = accountBookId;
            this.AgreementNo = agreementNo;
            this.BizScene = bizScene;
            this.ProductCode = productCode;
        }

        /// <summary>
        /// 记账本ID
        /// </summary>
        /// <value>记账本ID</value>
        [DataMember(Name = "account_book_id", EmitDefaultValue = false)]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 协议号。 若是基于协议的记账本，则agreement_no必传； 若是自创建的记账本，则agreement_no不传；
        /// </summary>
        /// <value>协议号。 若是基于协议的记账本，则agreement_no必传； 若是自创建的记账本，则agreement_no不传；</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 场景码。固定为DEFAULT
        /// </summary>
        /// <value>场景码。固定为DEFAULT</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码。固定为SATF_FUND_BOOK
        /// </summary>
        /// <value>产品码。固定为SATF_FUND_BOOK</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAccountbookNotifyUnsubscribeModel {\n");
            sb.Append("  AccountBookId: ").Append(AccountBookId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(input as AlipayFundAccountbookNotifyUnsubscribeModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAccountbookNotifyUnsubscribeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAccountbookNotifyUnsubscribeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAccountbookNotifyUnsubscribeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountBookId == input.AccountBookId ||
                    (this.AccountBookId != null &&
                    this.AccountBookId.Equals(input.AccountBookId))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
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
                if (this.AccountBookId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountBookId.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
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
