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
    /// AlipayFundJointaccountRuleModifyModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountRuleModifyModel")]
    public partial class AlipayFundJointaccountRuleModifyModel : IEquatable<AlipayFundJointaccountRuleModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountRuleModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">账本ID.</param>
        /// <param name="accountName">账本名称.</param>
        /// <param name="accountQuota">账户额度.</param>
        /// <param name="agreementNo">授权协议号.</param>
        /// <param name="authorizedRule">authorizedRule.</param>
        /// <param name="bizScene">场景码.</param>
        /// <param name="productCode">产品码.</param>
        public AlipayFundJointaccountRuleModifyModel(string accountId = default(string), string accountName = default(string), List<JointAccountQuotaDTO> accountQuota = default(List<JointAccountQuotaDTO>), string agreementNo = default(string), AuthorizedRuleDTO authorizedRule = default(AuthorizedRuleDTO), string bizScene = default(string), string productCode = default(string))
        {
            this.AccountId = accountId;
            this.AccountName = accountName;
            this.AccountQuota = accountQuota;
            this.AgreementNo = agreementNo;
            this.AuthorizedRule = authorizedRule;
            this.BizScene = bizScene;
            this.ProductCode = productCode;
        }

        /// <summary>
        /// 账本ID
        /// </summary>
        /// <value>账本ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 账本名称
        /// </summary>
        /// <value>账本名称</value>
        [DataMember(Name = "account_name", EmitDefaultValue = false)]
        public string AccountName { get; set; }

        /// <summary>
        /// 账户额度
        /// </summary>
        /// <value>账户额度</value>
        [DataMember(Name = "account_quota", EmitDefaultValue = false)]
        public List<JointAccountQuotaDTO> AccountQuota { get; set; }

        /// <summary>
        /// 授权协议号
        /// </summary>
        /// <value>授权协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizedRule
        /// </summary>
        [DataMember(Name = "authorized_rule", EmitDefaultValue = false)]
        public AuthorizedRuleDTO AuthorizedRule { get; set; }

        /// <summary>
        /// 场景码
        /// </summary>
        /// <value>场景码</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        /// <value>产品码</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountRuleModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  AccountQuota: ").Append(AccountQuota).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AuthorizedRule: ").Append(AuthorizedRule).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountRuleModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountRuleModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountRuleModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountRuleModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountQuota == input.AccountQuota ||
                    this.AccountQuota != null &&
                    input.AccountQuota != null &&
                    this.AccountQuota.SequenceEqual(input.AccountQuota)
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AuthorizedRule == input.AuthorizedRule ||
                    (this.AuthorizedRule != null &&
                    this.AuthorizedRule.Equals(input.AuthorizedRule))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.AccountName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountName.GetHashCode();
                }
                if (this.AccountQuota != null)
                {
                    hashCode = (hashCode * 59) + this.AccountQuota.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AuthorizedRule != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizedRule.GetHashCode();
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
