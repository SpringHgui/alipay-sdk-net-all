/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// PaymentVoucherSendRule
    /// </summary>
    [DataContract(Name = "PaymentVoucherSendRule")]
    public partial class PaymentVoucherSendRule : IEquatable<PaymentVoucherSendRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherSendRule" /> class.
        /// </summary>
        /// <param name="maxQuantityByDay">设置此字段，允许指定单天最大发券数量。  限制: 每天发放张数*活动天数应小于等于优惠券发放总量.</param>
        /// <param name="naturalPersonLimit">限制相同身份证号领取次数(voucher_quantity_limit_per_user)。默认false不限制。 枚举值 true：是 false：否.</param>
        /// <param name="phoneNumberLimit">限制相同手机号领取次数(voucher_quantity_limit_per_user)。默认false不限制 枚举值 true：是 false：否.</param>
        /// <param name="realNameLimit">限制支付宝实名用户才能领取支付券,默认为false表示不限制 枚举值 true\\false.</param>
        /// <param name="voucherQuantity">发行券的总数量。 限制： 1、发放总个数最少1个 2、发放总个数最多99999999个.</param>
        /// <param name="voucherQuantityLimitPerUser">每人领取限制。 默认按照支付宝账号进行领取限制;  不填写或填入0表示没有领取限制..</param>
        /// <param name="voucherQuantityLimitPerUserPeriodType">周期限领配置,限制每人在固定周期内领取张数(voucher_quantity_limit_per_user),默认LIFE_CYCLE.</param>
        public PaymentVoucherSendRule(int maxQuantityByDay = default(int), bool naturalPersonLimit = default(bool), bool phoneNumberLimit = default(bool), bool realNameLimit = default(bool), int voucherQuantity = default(int), int voucherQuantityLimitPerUser = default(int), string voucherQuantityLimitPerUserPeriodType = default(string))
        {
            this.MaxQuantityByDay = maxQuantityByDay;
            this.NaturalPersonLimit = naturalPersonLimit;
            this.PhoneNumberLimit = phoneNumberLimit;
            this.RealNameLimit = realNameLimit;
            this.VoucherQuantity = voucherQuantity;
            this.VoucherQuantityLimitPerUser = voucherQuantityLimitPerUser;
            this.VoucherQuantityLimitPerUserPeriodType = voucherQuantityLimitPerUserPeriodType;
        }

        /// <summary>
        /// 设置此字段，允许指定单天最大发券数量。  限制: 每天发放张数*活动天数应小于等于优惠券发放总量
        /// </summary>
        /// <value>设置此字段，允许指定单天最大发券数量。  限制: 每天发放张数*活动天数应小于等于优惠券发放总量</value>
        [DataMember(Name = "max_quantity_by_day", EmitDefaultValue = false)]
        public int MaxQuantityByDay { get; set; }

        /// <summary>
        /// 限制相同身份证号领取次数(voucher_quantity_limit_per_user)。默认false不限制。 枚举值 true：是 false：否
        /// </summary>
        /// <value>限制相同身份证号领取次数(voucher_quantity_limit_per_user)。默认false不限制。 枚举值 true：是 false：否</value>
        [DataMember(Name = "natural_person_limit", EmitDefaultValue = true)]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 限制相同手机号领取次数(voucher_quantity_limit_per_user)。默认false不限制 枚举值 true：是 false：否
        /// </summary>
        /// <value>限制相同手机号领取次数(voucher_quantity_limit_per_user)。默认false不限制 枚举值 true：是 false：否</value>
        [DataMember(Name = "phone_number_limit", EmitDefaultValue = true)]
        public bool PhoneNumberLimit { get; set; }

        /// <summary>
        /// 限制支付宝实名用户才能领取支付券,默认为false表示不限制 枚举值 true\\false
        /// </summary>
        /// <value>限制支付宝实名用户才能领取支付券,默认为false表示不限制 枚举值 true\\false</value>
        [DataMember(Name = "real_name_limit", EmitDefaultValue = true)]
        public bool RealNameLimit { get; set; }

        /// <summary>
        /// 发行券的总数量。 限制： 1、发放总个数最少1个 2、发放总个数最多99999999个
        /// </summary>
        /// <value>发行券的总数量。 限制： 1、发放总个数最少1个 2、发放总个数最多99999999个</value>
        [DataMember(Name = "voucher_quantity", EmitDefaultValue = false)]
        public int VoucherQuantity { get; set; }

        /// <summary>
        /// 每人领取限制。 默认按照支付宝账号进行领取限制;  不填写或填入0表示没有领取限制.
        /// </summary>
        /// <value>每人领取限制。 默认按照支付宝账号进行领取限制;  不填写或填入0表示没有领取限制.</value>
        [DataMember(Name = "voucher_quantity_limit_per_user", EmitDefaultValue = false)]
        public int VoucherQuantityLimitPerUser { get; set; }

        /// <summary>
        /// 周期限领配置,限制每人在固定周期内领取张数(voucher_quantity_limit_per_user),默认LIFE_CYCLE
        /// </summary>
        /// <value>周期限领配置,限制每人在固定周期内领取张数(voucher_quantity_limit_per_user),默认LIFE_CYCLE</value>
        [DataMember(Name = "voucher_quantity_limit_per_user_period_type", EmitDefaultValue = false)]
        public string VoucherQuantityLimitPerUserPeriodType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherSendRule {\n");
            sb.Append("  MaxQuantityByDay: ").Append(MaxQuantityByDay).Append("\n");
            sb.Append("  NaturalPersonLimit: ").Append(NaturalPersonLimit).Append("\n");
            sb.Append("  PhoneNumberLimit: ").Append(PhoneNumberLimit).Append("\n");
            sb.Append("  RealNameLimit: ").Append(RealNameLimit).Append("\n");
            sb.Append("  VoucherQuantity: ").Append(VoucherQuantity).Append("\n");
            sb.Append("  VoucherQuantityLimitPerUser: ").Append(VoucherQuantityLimitPerUser).Append("\n");
            sb.Append("  VoucherQuantityLimitPerUserPeriodType: ").Append(VoucherQuantityLimitPerUserPeriodType).Append("\n");
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
            return this.Equals(input as PaymentVoucherSendRule);
        }

        /// <summary>
        /// Returns true if PaymentVoucherSendRule instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherSendRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherSendRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxQuantityByDay == input.MaxQuantityByDay ||
                    this.MaxQuantityByDay.Equals(input.MaxQuantityByDay)
                ) && 
                (
                    this.NaturalPersonLimit == input.NaturalPersonLimit ||
                    this.NaturalPersonLimit.Equals(input.NaturalPersonLimit)
                ) && 
                (
                    this.PhoneNumberLimit == input.PhoneNumberLimit ||
                    this.PhoneNumberLimit.Equals(input.PhoneNumberLimit)
                ) && 
                (
                    this.RealNameLimit == input.RealNameLimit ||
                    this.RealNameLimit.Equals(input.RealNameLimit)
                ) && 
                (
                    this.VoucherQuantity == input.VoucherQuantity ||
                    this.VoucherQuantity.Equals(input.VoucherQuantity)
                ) && 
                (
                    this.VoucherQuantityLimitPerUser == input.VoucherQuantityLimitPerUser ||
                    this.VoucherQuantityLimitPerUser.Equals(input.VoucherQuantityLimitPerUser)
                ) && 
                (
                    this.VoucherQuantityLimitPerUserPeriodType == input.VoucherQuantityLimitPerUserPeriodType ||
                    (this.VoucherQuantityLimitPerUserPeriodType != null &&
                    this.VoucherQuantityLimitPerUserPeriodType.Equals(input.VoucherQuantityLimitPerUserPeriodType))
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
                hashCode = (hashCode * 59) + this.MaxQuantityByDay.GetHashCode();
                hashCode = (hashCode * 59) + this.NaturalPersonLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.PhoneNumberLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.RealNameLimit.GetHashCode();
                hashCode = (hashCode * 59) + this.VoucherQuantity.GetHashCode();
                hashCode = (hashCode * 59) + this.VoucherQuantityLimitPerUser.GetHashCode();
                if (this.VoucherQuantityLimitPerUserPeriodType != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherQuantityLimitPerUserPeriodType.GetHashCode();
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
