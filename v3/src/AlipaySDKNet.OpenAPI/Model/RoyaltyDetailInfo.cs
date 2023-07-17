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
    /// RoyaltyDetailInfo
    /// </summary>
    [DataContract(Name = "RoyaltyDetailInfo")]
    public partial class RoyaltyDetailInfo : IEquatable<RoyaltyDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoyaltyDetailInfo" /> class.
        /// </summary>
        /// <param name="amount">分账金额，单位为元.</param>
        /// <param name="desc">分账描述.</param>
        /// <param name="transInAccountId">分账转入账户id。当分账账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当分账账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当分账账户id类型是loginName时，本参数为用户的支付宝登录号;当分账账户id类型是openId时，本参数为用户的在该应用下的支付宝OpenId; 当 trans_in_account_type 为defaultSettle时，本参数必须为空.</param>
        /// <param name="transInAccountIdType">分账转入账户id类型。 当trans_in_account_type 为bankCard时，本参数为cardSerialNo，表示分账账户id是银行卡编号; 当trans_in_account_type 为alipayBalance时，本参数为userId或者loginName或者openId，其中userId表示分账账户id是支付宝唯一用户号，loginName表示分账账户id是支付宝登录号，openId表示分账账户id是支付宝OpenId; 当 trans_in_account_type 为 defaultSettle 时，本参数必须为空。.</param>
        /// <param name="transInAccountType">分账账户类型。 bankCard: 分账账户为银行卡； alipayBalance: 分账账户为支付宝余额户; defaultSettle: 按默认结算规则分账.</param>
        /// <param name="transInEntityId">分账转出主体账 号。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID    当分账转出类型为Store，本参数为StoreID.</param>
        /// <param name="transInEntityType">分账转入主体类型。 SecondMerchant：分账转入主体为二级商户    Store: 结算门店.</param>
        /// <param name="transInSubMerchant">transInSubMerchant.</param>
        /// <param name="transOutEntityId">分账转出主体账。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantId    当分账转出类型为Store，本参数为StoreID.</param>
        /// <param name="transOutEntityType">分账转出主体类型。 SecondMerchant：结算主体为二级商户    Store: 结算门店.</param>
        /// <param name="transOutSubMerchant">transOutSubMerchant.</param>
        public RoyaltyDetailInfo(string amount = default(string), string desc = default(string), string transInAccountId = default(string), string transInAccountIdType = default(string), string transInAccountType = default(string), string transInEntityId = default(string), string transInEntityType = default(string), SubMerchant transInSubMerchant = default(SubMerchant), string transOutEntityId = default(string), string transOutEntityType = default(string), SubMerchant transOutSubMerchant = default(SubMerchant))
        {
            this.Amount = amount;
            this.Desc = desc;
            this.TransInAccountId = transInAccountId;
            this.TransInAccountIdType = transInAccountIdType;
            this.TransInAccountType = transInAccountType;
            this.TransInEntityId = transInEntityId;
            this.TransInEntityType = transInEntityType;
            this.TransInSubMerchant = transInSubMerchant;
            this.TransOutEntityId = transOutEntityId;
            this.TransOutEntityType = transOutEntityType;
            this.TransOutSubMerchant = transOutSubMerchant;
        }

        /// <summary>
        /// 分账金额，单位为元
        /// </summary>
        /// <value>分账金额，单位为元</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 分账描述
        /// </summary>
        /// <value>分账描述</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// 分账转入账户id。当分账账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当分账账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当分账账户id类型是loginName时，本参数为用户的支付宝登录号;当分账账户id类型是openId时，本参数为用户的在该应用下的支付宝OpenId; 当 trans_in_account_type 为defaultSettle时，本参数必须为空
        /// </summary>
        /// <value>分账转入账户id。当分账账户id类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号；当分账账户id类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号；当分账账户id类型是loginName时，本参数为用户的支付宝登录号;当分账账户id类型是openId时，本参数为用户的在该应用下的支付宝OpenId; 当 trans_in_account_type 为defaultSettle时，本参数必须为空</value>
        [DataMember(Name = "trans_in_account_id", EmitDefaultValue = false)]
        public string TransInAccountId { get; set; }

        /// <summary>
        /// 分账转入账户id类型。 当trans_in_account_type 为bankCard时，本参数为cardSerialNo，表示分账账户id是银行卡编号; 当trans_in_account_type 为alipayBalance时，本参数为userId或者loginName或者openId，其中userId表示分账账户id是支付宝唯一用户号，loginName表示分账账户id是支付宝登录号，openId表示分账账户id是支付宝OpenId; 当 trans_in_account_type 为 defaultSettle 时，本参数必须为空。
        /// </summary>
        /// <value>分账转入账户id类型。 当trans_in_account_type 为bankCard时，本参数为cardSerialNo，表示分账账户id是银行卡编号; 当trans_in_account_type 为alipayBalance时，本参数为userId或者loginName或者openId，其中userId表示分账账户id是支付宝唯一用户号，loginName表示分账账户id是支付宝登录号，openId表示分账账户id是支付宝OpenId; 当 trans_in_account_type 为 defaultSettle 时，本参数必须为空。</value>
        [DataMember(Name = "trans_in_account_id_type", EmitDefaultValue = false)]
        public string TransInAccountIdType { get; set; }

        /// <summary>
        /// 分账账户类型。 bankCard: 分账账户为银行卡； alipayBalance: 分账账户为支付宝余额户; defaultSettle: 按默认结算规则分账
        /// </summary>
        /// <value>分账账户类型。 bankCard: 分账账户为银行卡； alipayBalance: 分账账户为支付宝余额户; defaultSettle: 按默认结算规则分账</value>
        [DataMember(Name = "trans_in_account_type", EmitDefaultValue = false)]
        public string TransInAccountType { get; set; }

        /// <summary>
        /// 分账转出主体账 号。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID    当分账转出类型为Store，本参数为StoreID
        /// </summary>
        /// <value>分账转出主体账 号。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID    当分账转出类型为Store，本参数为StoreID</value>
        [DataMember(Name = "trans_in_entity_id", EmitDefaultValue = false)]
        public string TransInEntityId { get; set; }

        /// <summary>
        /// 分账转入主体类型。 SecondMerchant：分账转入主体为二级商户    Store: 结算门店
        /// </summary>
        /// <value>分账转入主体类型。 SecondMerchant：分账转入主体为二级商户    Store: 结算门店</value>
        [DataMember(Name = "trans_in_entity_type", EmitDefaultValue = false)]
        public string TransInEntityType { get; set; }

        /// <summary>
        /// Gets or Sets TransInSubMerchant
        /// </summary>
        [DataMember(Name = "trans_in_sub_merchant", EmitDefaultValue = false)]
        public SubMerchant TransInSubMerchant { get; set; }

        /// <summary>
        /// 分账转出主体账。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantId    当分账转出类型为Store，本参数为StoreID
        /// </summary>
        /// <value>分账转出主体账。    当分账转出主体类型为SecondMerchant，本参数为二级商户的SecondMerchantId    当分账转出类型为Store，本参数为StoreID</value>
        [DataMember(Name = "trans_out_entity_id", EmitDefaultValue = false)]
        public string TransOutEntityId { get; set; }

        /// <summary>
        /// 分账转出主体类型。 SecondMerchant：结算主体为二级商户    Store: 结算门店
        /// </summary>
        /// <value>分账转出主体类型。 SecondMerchant：结算主体为二级商户    Store: 结算门店</value>
        [DataMember(Name = "trans_out_entity_type", EmitDefaultValue = false)]
        public string TransOutEntityType { get; set; }

        /// <summary>
        /// Gets or Sets TransOutSubMerchant
        /// </summary>
        [DataMember(Name = "trans_out_sub_merchant", EmitDefaultValue = false)]
        public SubMerchant TransOutSubMerchant { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoyaltyDetailInfo {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  TransInAccountId: ").Append(TransInAccountId).Append("\n");
            sb.Append("  TransInAccountIdType: ").Append(TransInAccountIdType).Append("\n");
            sb.Append("  TransInAccountType: ").Append(TransInAccountType).Append("\n");
            sb.Append("  TransInEntityId: ").Append(TransInEntityId).Append("\n");
            sb.Append("  TransInEntityType: ").Append(TransInEntityType).Append("\n");
            sb.Append("  TransInSubMerchant: ").Append(TransInSubMerchant).Append("\n");
            sb.Append("  TransOutEntityId: ").Append(TransOutEntityId).Append("\n");
            sb.Append("  TransOutEntityType: ").Append(TransOutEntityType).Append("\n");
            sb.Append("  TransOutSubMerchant: ").Append(TransOutSubMerchant).Append("\n");
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
            return this.Equals(input as RoyaltyDetailInfo);
        }

        /// <summary>
        /// Returns true if RoyaltyDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RoyaltyDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoyaltyDetailInfo input)
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
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.TransInAccountId == input.TransInAccountId ||
                    (this.TransInAccountId != null &&
                    this.TransInAccountId.Equals(input.TransInAccountId))
                ) && 
                (
                    this.TransInAccountIdType == input.TransInAccountIdType ||
                    (this.TransInAccountIdType != null &&
                    this.TransInAccountIdType.Equals(input.TransInAccountIdType))
                ) && 
                (
                    this.TransInAccountType == input.TransInAccountType ||
                    (this.TransInAccountType != null &&
                    this.TransInAccountType.Equals(input.TransInAccountType))
                ) && 
                (
                    this.TransInEntityId == input.TransInEntityId ||
                    (this.TransInEntityId != null &&
                    this.TransInEntityId.Equals(input.TransInEntityId))
                ) && 
                (
                    this.TransInEntityType == input.TransInEntityType ||
                    (this.TransInEntityType != null &&
                    this.TransInEntityType.Equals(input.TransInEntityType))
                ) && 
                (
                    this.TransInSubMerchant == input.TransInSubMerchant ||
                    (this.TransInSubMerchant != null &&
                    this.TransInSubMerchant.Equals(input.TransInSubMerchant))
                ) && 
                (
                    this.TransOutEntityId == input.TransOutEntityId ||
                    (this.TransOutEntityId != null &&
                    this.TransOutEntityId.Equals(input.TransOutEntityId))
                ) && 
                (
                    this.TransOutEntityType == input.TransOutEntityType ||
                    (this.TransOutEntityType != null &&
                    this.TransOutEntityType.Equals(input.TransOutEntityType))
                ) && 
                (
                    this.TransOutSubMerchant == input.TransOutSubMerchant ||
                    (this.TransOutSubMerchant != null &&
                    this.TransOutSubMerchant.Equals(input.TransOutSubMerchant))
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
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.TransInAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.TransInAccountId.GetHashCode();
                }
                if (this.TransInAccountIdType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInAccountIdType.GetHashCode();
                }
                if (this.TransInAccountType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInAccountType.GetHashCode();
                }
                if (this.TransInEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.TransInEntityId.GetHashCode();
                }
                if (this.TransInEntityType != null)
                {
                    hashCode = (hashCode * 59) + this.TransInEntityType.GetHashCode();
                }
                if (this.TransInSubMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.TransInSubMerchant.GetHashCode();
                }
                if (this.TransOutEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutEntityId.GetHashCode();
                }
                if (this.TransOutEntityType != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutEntityType.GetHashCode();
                }
                if (this.TransOutSubMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutSubMerchant.GetHashCode();
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
