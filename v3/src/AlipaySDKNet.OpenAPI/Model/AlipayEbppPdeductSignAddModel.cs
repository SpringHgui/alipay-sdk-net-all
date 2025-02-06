/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// AlipayEbppPdeductSignAddModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductSignAddModel")]
    public partial class AlipayEbppPdeductSignAddModel : IEquatable<AlipayEbppPdeductSignAddModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductSignAddModel" /> class.
        /// </summary>
        /// <param name="agentChannel">机构签约代扣来源渠道  PUBLICPLATFORM：服务窗.</param>
        /// <param name="agentCode">从服务窗发起则为publicId的值.</param>
        /// <param name="billKey">户号，机构针对于每户的水、电都会有唯一的标识户号.</param>
        /// <param name="bizType">业务类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。 *IND：保险缴费。.</param>
        /// <param name="chargeInst">支付宝缴费系统中的出账机构ID.</param>
        /// <param name="deductProdCode">代扣产品码。 缴费业务场景中，传入INST_DIRECT_DEDUCT。保险业务场景中, 传入INSURANCE_MERCHANT_DEDUCT。.</param>
        /// <param name="deductType">签约类型可为空.</param>
        /// <param name="extUserInfo">外部用户实名认证相关信息, 用于做签约时的实名校验。   注：     name: 姓名  cert_type: 身份证：IDENTITY_CARD、护照：PASSPORT、军官证：OFFICER_CARD、士兵证：SOLDIER_CARD、户口本：HOKOU等  cert_no: 证件号码  need_check_info取值 T/F，只有为T时才做强制校验。  mobile:手机号，目前暂不使用此字段做校验  min_age: 允许的最小买家年龄,min_age为整数，必须大于等于0..</param>
        /// <param name="extendField">扩展字段.</param>
        /// <param name="notifyConfig">通知方式设置，可为空.</param>
        /// <param name="openId">用户UserId在应用AppId下的唯一用户标识.</param>
        /// <param name="outAgreementId">外部产生的协议ID.</param>
        /// <param name="ownerName">户名，户主真实姓名.</param>
        /// <param name="payConfig">支付工具设置，目前可为空.</param>
        /// <param name="payPasswordToken">支付密码鉴权token，需要用户首先处于登陆态，然后访问https://ebppprod.alipay.com/deduct/enterMobileicPayPassword.htm?cb&#x3D;自己指定的回跳连接地址，访问页面后会进到独立密码校验页，用户输入密码校验成功后，会生成token回调到指定的回跳地址，如果设置cb&#x3D;www.alipay.com则最后回调的内容是www.alipay.com?token&#x3D;312314ADFDSFAS，然后签约时直接取得地址后token的值即可。.</param>
        /// <param name="pid">商户id，商户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        /// <param name="signExpireDate">签约到期时间。空表示无限期，一期固定传空。.</param>
        /// <param name="subBizType">业务子类型。业务子类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *TRAFFIC：缴交通罚款。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 *CAR：车险。 *LIFE：寿险。 *HEALTH：健康险。 例如：WATER表示JF下面的水费。.</param>
        /// <param name="userId">用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        public AlipayEbppPdeductSignAddModel(string agentChannel = default(string), string agentCode = default(string), string billKey = default(string), string bizType = default(string), string chargeInst = default(string), string deductProdCode = default(string), string deductType = default(string), string extUserInfo = default(string), string extendField = default(string), string notifyConfig = default(string), string openId = default(string), string outAgreementId = default(string), string ownerName = default(string), string payConfig = default(string), string payPasswordToken = default(string), string pid = default(string), string signExpireDate = default(string), string subBizType = default(string), string userId = default(string))
        {
            this.AgentChannel = agentChannel;
            this.AgentCode = agentCode;
            this.BillKey = billKey;
            this.BizType = bizType;
            this.ChargeInst = chargeInst;
            this.DeductProdCode = deductProdCode;
            this.DeductType = deductType;
            this.ExtUserInfo = extUserInfo;
            this.ExtendField = extendField;
            this.NotifyConfig = notifyConfig;
            this.OpenId = openId;
            this.OutAgreementId = outAgreementId;
            this.OwnerName = ownerName;
            this.PayConfig = payConfig;
            this.PayPasswordToken = payPasswordToken;
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
        /// 从服务窗发起则为publicId的值
        /// </summary>
        /// <value>从服务窗发起则为publicId的值</value>
        [DataMember(Name = "agent_code", EmitDefaultValue = false)]
        public string AgentCode { get; set; }

        /// <summary>
        /// 户号，机构针对于每户的水、电都会有唯一的标识户号
        /// </summary>
        /// <value>户号，机构针对于每户的水、电都会有唯一的标识户号</value>
        [DataMember(Name = "bill_key", EmitDefaultValue = false)]
        public string BillKey { get; set; }

        /// <summary>
        /// 业务类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。 *IND：保险缴费。
        /// </summary>
        /// <value>业务类型。枚举支持： *JF：公共事业缴纳。 *WUYE：物业缴费。 *HK：信用卡还款。 *TX：通讯缴费。 *IND：保险缴费。</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 支付宝缴费系统中的出账机构ID
        /// </summary>
        /// <value>支付宝缴费系统中的出账机构ID</value>
        [DataMember(Name = "charge_inst", EmitDefaultValue = false)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 代扣产品码。 缴费业务场景中，传入INST_DIRECT_DEDUCT。保险业务场景中, 传入INSURANCE_MERCHANT_DEDUCT。
        /// </summary>
        /// <value>代扣产品码。 缴费业务场景中，传入INST_DIRECT_DEDUCT。保险业务场景中, 传入INSURANCE_MERCHANT_DEDUCT。</value>
        [DataMember(Name = "deduct_prod_code", EmitDefaultValue = false)]
        public string DeductProdCode { get; set; }

        /// <summary>
        /// 签约类型可为空
        /// </summary>
        /// <value>签约类型可为空</value>
        [DataMember(Name = "deduct_type", EmitDefaultValue = false)]
        public string DeductType { get; set; }

        /// <summary>
        /// 外部用户实名认证相关信息, 用于做签约时的实名校验。   注：     name: 姓名  cert_type: 身份证：IDENTITY_CARD、护照：PASSPORT、军官证：OFFICER_CARD、士兵证：SOLDIER_CARD、户口本：HOKOU等  cert_no: 证件号码  need_check_info取值 T/F，只有为T时才做强制校验。  mobile:手机号，目前暂不使用此字段做校验  min_age: 允许的最小买家年龄,min_age为整数，必须大于等于0.
        /// </summary>
        /// <value>外部用户实名认证相关信息, 用于做签约时的实名校验。   注：     name: 姓名  cert_type: 身份证：IDENTITY_CARD、护照：PASSPORT、军官证：OFFICER_CARD、士兵证：SOLDIER_CARD、户口本：HOKOU等  cert_no: 证件号码  need_check_info取值 T/F，只有为T时才做强制校验。  mobile:手机号，目前暂不使用此字段做校验  min_age: 允许的最小买家年龄,min_age为整数，必须大于等于0.</value>
        [DataMember(Name = "ext_user_info", EmitDefaultValue = false)]
        public string ExtUserInfo { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        /// <value>扩展字段</value>
        [DataMember(Name = "extend_field", EmitDefaultValue = false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// 通知方式设置，可为空
        /// </summary>
        /// <value>通知方式设置，可为空</value>
        [DataMember(Name = "notify_config", EmitDefaultValue = false)]
        public string NotifyConfig { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        /// <value>用户UserId在应用AppId下的唯一用户标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部产生的协议ID
        /// </summary>
        /// <value>外部产生的协议ID</value>
        [DataMember(Name = "out_agreement_id", EmitDefaultValue = false)]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 户名，户主真实姓名
        /// </summary>
        /// <value>户名，户主真实姓名</value>
        [DataMember(Name = "owner_name", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 支付工具设置，目前可为空
        /// </summary>
        /// <value>支付工具设置，目前可为空</value>
        [DataMember(Name = "pay_config", EmitDefaultValue = false)]
        public string PayConfig { get; set; }

        /// <summary>
        /// 支付密码鉴权token，需要用户首先处于登陆态，然后访问https://ebppprod.alipay.com/deduct/enterMobileicPayPassword.htm?cb&#x3D;自己指定的回跳连接地址，访问页面后会进到独立密码校验页，用户输入密码校验成功后，会生成token回调到指定的回跳地址，如果设置cb&#x3D;www.alipay.com则最后回调的内容是www.alipay.com?token&#x3D;312314ADFDSFAS，然后签约时直接取得地址后token的值即可。
        /// </summary>
        /// <value>支付密码鉴权token，需要用户首先处于登陆态，然后访问https://ebppprod.alipay.com/deduct/enterMobileicPayPassword.htm?cb&#x3D;自己指定的回跳连接地址，访问页面后会进到独立密码校验页，用户输入密码校验成功后，会生成token回调到指定的回跳地址，如果设置cb&#x3D;www.alipay.com则最后回调的内容是www.alipay.com?token&#x3D;312314ADFDSFAS，然后签约时直接取得地址后token的值即可。</value>
        [DataMember(Name = "pay_password_token", EmitDefaultValue = false)]
        public string PayPasswordToken { get; set; }

        /// <summary>
        /// 商户id，商户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>商户id，商户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 签约到期时间。空表示无限期，一期固定传空。
        /// </summary>
        /// <value>签约到期时间。空表示无限期，一期固定传空。</value>
        [DataMember(Name = "sign_expire_date", EmitDefaultValue = false)]
        public string SignExpireDate { get; set; }

        /// <summary>
        /// 业务子类型。业务子类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *TRAFFIC：缴交通罚款。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 *CAR：车险。 *LIFE：寿险。 *HEALTH：健康险。 例如：WATER表示JF下面的水费。
        /// </summary>
        /// <value>业务子类型。业务子类型是业务类型的下一级概念。枚举支持： *WATER：缴水费。 *ELECTRIC：缴电费。 *GAS：缴燃气费。 *COMMUN：缴固话宽带费。 *CATV：缴有线电视费。 *TRAFFIC：缴交通罚款。 *WUYE：缴物业费。 *RC：定期还车贷代扣。 *RH：定期还房贷代扣。 *RR：定期还房租代扣。 *RN：定期还网贷代扣。 *CZ：手机充值代扣。 *CAR：车险。 *LIFE：寿险。 *HEALTH：健康险。 例如：WATER表示JF下面的水费。</value>
        [DataMember(Name = "sub_biz_type", EmitDefaultValue = false)]
        public string SubBizType { get; set; }

        /// <summary>
        /// 用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>用户 id，用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductSignAddModel {\n");
            sb.Append("  AgentChannel: ").Append(AgentChannel).Append("\n");
            sb.Append("  AgentCode: ").Append(AgentCode).Append("\n");
            sb.Append("  BillKey: ").Append(BillKey).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  ChargeInst: ").Append(ChargeInst).Append("\n");
            sb.Append("  DeductProdCode: ").Append(DeductProdCode).Append("\n");
            sb.Append("  DeductType: ").Append(DeductType).Append("\n");
            sb.Append("  ExtUserInfo: ").Append(ExtUserInfo).Append("\n");
            sb.Append("  ExtendField: ").Append(ExtendField).Append("\n");
            sb.Append("  NotifyConfig: ").Append(NotifyConfig).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutAgreementId: ").Append(OutAgreementId).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PayConfig: ").Append(PayConfig).Append("\n");
            sb.Append("  PayPasswordToken: ").Append(PayPasswordToken).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductSignAddModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductSignAddModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductSignAddModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductSignAddModel input)
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
                    this.DeductProdCode == input.DeductProdCode ||
                    (this.DeductProdCode != null &&
                    this.DeductProdCode.Equals(input.DeductProdCode))
                ) && 
                (
                    this.DeductType == input.DeductType ||
                    (this.DeductType != null &&
                    this.DeductType.Equals(input.DeductType))
                ) && 
                (
                    this.ExtUserInfo == input.ExtUserInfo ||
                    (this.ExtUserInfo != null &&
                    this.ExtUserInfo.Equals(input.ExtUserInfo))
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
                    this.PayPasswordToken == input.PayPasswordToken ||
                    (this.PayPasswordToken != null &&
                    this.PayPasswordToken.Equals(input.PayPasswordToken))
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
                if (this.DeductProdCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeductProdCode.GetHashCode();
                }
                if (this.DeductType != null)
                {
                    hashCode = (hashCode * 59) + this.DeductType.GetHashCode();
                }
                if (this.ExtUserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtUserInfo.GetHashCode();
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
                if (this.PayPasswordToken != null)
                {
                    hashCode = (hashCode * 59) + this.PayPasswordToken.GetHashCode();
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
