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
    /// AlipayMarketingCardBenefitModifyModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardBenefitModifyModel")]
    public partial class AlipayMarketingCardBenefitModifyModel : IEquatable<AlipayMarketingCardBenefitModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardBenefitModifyModel" /> class.
        /// </summary>
        /// <param name="benefitId">权益ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\&quot;&gt;alipay.marketing.card.benefit.create&lt;/a&gt;(会员卡模板外部权益创建)接口创建获取。.</param>
        /// <param name="mcardTemplateBenefit">mcardTemplateBenefit.</param>
        public AlipayMarketingCardBenefitModifyModel(string benefitId = default(string), McardTemplateBenefit mcardTemplateBenefit = default(McardTemplateBenefit))
        {
            this.BenefitId = benefitId;
            this.McardTemplateBenefit = mcardTemplateBenefit;
        }

        /// <summary>
        /// 权益ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\&quot;&gt;alipay.marketing.card.benefit.create&lt;/a&gt;(会员卡模板外部权益创建)接口创建获取。
        /// </summary>
        /// <value>权益ID，通过 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_5/alipay.marketing.card.benefit.create\&quot;&gt;alipay.marketing.card.benefit.create&lt;/a&gt;(会员卡模板外部权益创建)接口创建获取。</value>
        [DataMember(Name = "benefit_id", EmitDefaultValue = false)]
        public string BenefitId { get; set; }

        /// <summary>
        /// Gets or Sets McardTemplateBenefit
        /// </summary>
        [DataMember(Name = "mcard_template_benefit", EmitDefaultValue = false)]
        public McardTemplateBenefit McardTemplateBenefit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardBenefitModifyModel {\n");
            sb.Append("  BenefitId: ").Append(BenefitId).Append("\n");
            sb.Append("  McardTemplateBenefit: ").Append(McardTemplateBenefit).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardBenefitModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardBenefitModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardBenefitModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardBenefitModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BenefitId == input.BenefitId ||
                    (this.BenefitId != null &&
                    this.BenefitId.Equals(input.BenefitId))
                ) && 
                (
                    this.McardTemplateBenefit == input.McardTemplateBenefit ||
                    (this.McardTemplateBenefit != null &&
                    this.McardTemplateBenefit.Equals(input.McardTemplateBenefit))
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
                if (this.BenefitId != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitId.GetHashCode();
                }
                if (this.McardTemplateBenefit != null)
                {
                    hashCode = (hashCode * 59) + this.McardTemplateBenefit.GetHashCode();
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
