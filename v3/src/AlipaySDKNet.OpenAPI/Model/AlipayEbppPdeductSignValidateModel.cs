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
    /// AlipayEbppPdeductSignValidateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductSignValidateModel")]
    public partial class AlipayEbppPdeductSignValidateModel : IEquatable<AlipayEbppPdeductSignValidateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignValidateModel" /> class.
        /// </summary>
        /// <param name="agentChannel">机构签约代扣来源渠道  PUBLICPLATFORM：服务窗.</param>
        /// <param name="agentCode">从服务窗发起则为该服务窗的appid的值.</param>
        /// <param name="billKey">户号，机构针对于每户的水、电都会有唯一的标识户号.</param>
        /// <param name="bizType">业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值.</param>
        /// <param name="chargeInst">支付宝缴费系统中的出账机构ID.</param>
        /// <param name="deductType">签约类型,可为空。目前类型有INST_DIRECT_DEDUCT.</param>
        /// <param name="extendField">扩展字段.</param>
        /// <param name="notifyConfig">通知方式设置，本期预留字段，固定传空。.</param>
        /// <param name="openId">用户UserId在应用AppId下的唯一用户标识.</param>
        /// <param name="outAgreementId">外部机构签约的协议id.</param>
        /// <param name="ownerName">户名，户主真实姓名.</param>
        /// <param name="payConfig">支付工具设置，目前可为空。类型有：BALANCE;CARTOON;BIGAMOUNT_CREDIT_CARTOON;DEBIT_EXPRESS;OPTIMIZED_MOTO;PCREDIT_PAY;MONEY_FUND.</param>
        /// <param name="pid">商户签约支付宝账号的userid，2088开头16位长度的字符串，在支付宝系统中唯一.</param>
        /// <param name="signExpireDate">签约到期时间。空表示无限期，一期固定传空。.</param>
        /// <param name="subBizType">业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值.</param>
        /// <param name="userId">用户支付宝账号id，2088开头16位长度的字符串，在支付宝系统中唯一.</param>
        public AlipayEbppPdeductSignValidateModel(string agentChannel = default(string), string agentCode = default(string), string billKey = default(string), string bizType = default(string), string chargeInst = default(string), string deductType = default(string), string extendField = default(string), string notifyConfig = default(string), string openId = default(string), string outAgreementId = default(string), string ownerName = default(string), string payConfig = default(string), string pid = default(string), string signExpireDate = default(string), string subBizType = default(string), string userId = default(string))
        {
            this.AgentChannel = agentChannel;
            this.AgentCode = agentCode;
            this.BillKey = billKey;
            this.BizType = bizType;
            this.ChargeInst = chargeInst;
            this.DeductType = deductType;
            this.ExtendField = extendField;
            this.NotifyConfig = notifyConfig;
            this.OpenId = openId;
            this.OutAgreementId = outAgreementId;
            this.OwnerName = ownerName;
            this.PayConfig = payConfig;
            this.Pid = pid;
            this.SignExpireDate = signExpireDate;
            this.SubBizType = subBizType;
            this.UserId = userId;
        }

        /// <summary>
        /// 机构签约代扣来源渠道  PUBLICPLATFORM：服务窗
        /// </summary>
        /// <value>机构签约代扣来源渠道  PUBLICPLATFORM：服务窗</value>
        [DataMember(Name = "agent_channel", EmitDefaultValue = false)]
        public string AgentChannel { get; set; }

        /// <summary>
        /// 从服务窗发起则为该服务窗的appid的值
        /// </summary>
        /// <value>从服务窗发起则为该服务窗的appid的值</value>
        [DataMember(Name = "agent_code", EmitDefaultValue = false)]
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        /// <value>户号，机构针对于每户的水、电都会有唯一的标识户号</value>
        [DataMember(Name = "bill_key", EmitDefaultValue = false)]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值
        /// </summary>
        /// <value>业务类型。  JF：缴水、电、燃气、固话宽带、有线电视、交通罚款费用  WUYE：缴物业费  HK：信用卡还款  TX：手机充值</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        /// <value>支付宝缴费系统中的出账机构ID</value>
        [DataMember(Name = "charge_inst", EmitDefaultValue = false)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 签约类型,可为空。目前类型有INST_DIRECT_DEDUCT
        /// </summary>
        /// <value>签约类型,可为空。目前类型有INST_DIRECT_DEDUCT</value>
        [DataMember(Name = "deduct_type", EmitDefaultValue = false)]
        public string DeductType { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        /// <value>扩展字段</value>
        [DataMember(Name = "extend_field", EmitDefaultValue = false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置，本期预留字段，固定传空。
        /// </summary>
        /// <value>通知方式设置，本期预留字段，固定传空。</value>
        [DataMember(Name = "notify_config", EmitDefaultValue = false)]
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        /// <value>用户UserId在应用AppId下的唯一用户标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部机构签约的协议id
        /// </summary>
        /// <value>外部机构签约的协议id</value>
        [DataMember(Name = "out_agreement_id", EmitDefaultValue = false)]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 户名，户主真实姓名
        /// </summary>
        /// <value>户名，户主真实姓名</value>
        [DataMember(Name = "owner_name", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 支付工具设置，目前可为空。类型有：BALANCE;CARTOON;BIGAMOUNT_CREDIT_CARTOON;DEBIT_EXPRESS;OPTIMIZED_MOTO;PCREDIT_PAY;MONEY_FUND
        /// </summary>
        /// <value>支付工具设置，目前可为空。类型有：BALANCE;CARTOON;BIGAMOUNT_CREDIT_CARTOON;DEBIT_EXPRESS;OPTIMIZED_MOTO;PCREDIT_PAY;MONEY_FUND</value>
        [DataMember(Name = "pay_config", EmitDefaultValue = false)]
        public string PayConfig { get; set; }

        /// <summary>
        /// 商户签约支付宝账号的userid，2088开头16位长度的字符串，在支付宝系统中唯一
        /// </summary>
        /// <value>商户签约支付宝账号的userid，2088开头16位长度的字符串，在支付宝系统中唯一</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 签约到期时间。空表示无限期，一期固定传空。
        /// </summary>
        /// <value>签约到期时间。空表示无限期，一期固定传空。</value>
        [DataMember(Name = "sign_expire_date", EmitDefaultValue = false)]
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值
        /// </summary>
        /// <value>业务子类型。  WATER：缴水费  ELECTRIC：缴电费  GAS：缴燃气费  COMMUN：缴固话宽带  CATV：缴有线电视费  TRAFFIC：缴交通罚款  WUYE：缴物业费  HK：信用卡还款  CZ：手机充值</value>
        [DataMember(Name = "sub_biz_type", EmitDefaultValue = false)]
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户支付宝账号id，2088开头16位长度的字符串，在支付宝系统中唯一
        /// </summary>
        /// <value>用户支付宝账号id，2088开头16位长度的字符串，在支付宝系统中唯一</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductSignValidateModel {\n");
            sb.Append("  AgentChannel: ").Append(AgentChannel).Append("\n");
            sb.Append("  AgentCode: ").Append(AgentCode).Append("\n");
            sb.Append("  BillKey: ").Append(BillKey).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  ChargeInst: ").Append(ChargeInst).Append("\n");
            sb.Append("  DeductType: ").Append(DeductType).Append("\n");
            sb.Append("  ExtendField: ").Append(ExtendField).Append("\n");
            sb.Append("  NotifyConfig: ").Append(NotifyConfig).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutAgreementId: ").Append(OutAgreementId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PayConfig: ").Append(PayConfig).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  SignExpireDate: ").Append(SignExpireDate).Append("\n");
            sb.Append("  SubBizType: ").Append(SubBizType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductSignValidateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductSignValidateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductSignValidateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductSignValidateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgentChannel == input.AgentChannel ||
                    (this.AgentChannel != null &&
                    this.AgentChannel.Equals(input.AgentChannel))
                ) && 
                (
                    this.AgentCode == input.AgentCode ||
                    (this.AgentCode != null &&
                    this.AgentCode.Equals(input.AgentCode))
                ) && 
                (
                    this.BillKey == input.BillKey ||
                    (this.BillKey != null &&
                    this.BillKey.Equals(input.BillKey))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.ChargeInst == input.ChargeInst ||
                    (this.ChargeInst != null &&
                    this.ChargeInst.Equals(input.ChargeInst))
                ) && 
                (
                    this.DeductType == input.DeductType ||
                    (this.DeductType != null &&
                    this.DeductType.Equals(input.DeductType))
                ) && 
                (
                    this.ExtendField == input.ExtendField ||
                    (this.ExtendField != null &&
                    this.ExtendField.Equals(input.ExtendField))
                ) && 
                (
                    this.NotifyConfig == input.NotifyConfig ||
                    (this.NotifyConfig != null &&
                    this.NotifyConfig.Equals(input.NotifyConfig))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutAgreementId == input.OutAgreementId ||
                    (this.OutAgreementId != null &&
                    this.OutAgreementId.Equals(input.OutAgreementId))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.PayConfig == input.PayConfig ||
                    (this.PayConfig != null &&
                    this.PayConfig.Equals(input.PayConfig))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.SignExpireDate == input.SignExpireDate ||
                    (this.SignExpireDate != null &&
                    this.SignExpireDate.Equals(input.SignExpireDate))
                ) && 
                (
                    this.SubBizType == input.SubBizType ||
                    (this.SubBizType != null &&
                    this.SubBizType.Equals(input.SubBizType))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AgentChannel != null)
                {
                    hashCode = (hashCode * 59) + this.AgentChannel.GetHashCode();
                }
                if (this.AgentCode != null)
                {
                    hashCode = (hashCode * 59) + this.AgentCode.GetHashCode();
                }
                if (this.BillKey != null)
                {
                    hashCode = (hashCode * 59) + this.BillKey.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.ChargeInst != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeInst.GetHashCode();
                }
                if (this.DeductType != null)
                {
                    hashCode = (hashCode * 59) + this.DeductType.GetHashCode();
                }
                if (this.ExtendField != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendField.GetHashCode();
                }
                if (this.NotifyConfig != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyConfig.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutAgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.OutAgreementId.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.PayConfig != null)
                {
                    hashCode = (hashCode * 59) + this.PayConfig.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.SignExpireDate != null)
                {
                    hashCode = (hashCode * 59) + this.SignExpireDate.GetHashCode();
                }
                if (this.SubBizType != null)
                {
                    hashCode = (hashCode * 59) + this.SubBizType.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
