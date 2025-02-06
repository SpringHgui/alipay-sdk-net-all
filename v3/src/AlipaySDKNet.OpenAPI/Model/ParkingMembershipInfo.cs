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
    /// ParkingMembershipInfo
    /// </summary>
    [DataContract(Name = "ParkingMembershipInfo")]
    public partial class ParkingMembershipInfo : IEquatable<ParkingMembershipInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParkingMembershipInfo" /> class.
        /// </summary>
        /// <param name="membershipBalance">周卡、月卡：剩余天数（包括今天），单位日； 次卡：剩余次数（包括本次），单位次； 储值：余额，单位元； 折扣：折扣力度，代表0-10折；0折即为免费；.</param>
        /// <param name="membershipType">会员类型； WEEK_CARD：周卡 MONTH_CARD：月卡 SEASON_CARD：季卡 YEAR_CARD：年卡 MULTIPLE_PASS_CARD：次卡 MONEY_STORED_CARD：储值 DISCOUNT_CARD：折扣.</param>
        public ParkingMembershipInfo(string membershipBalance = default(string), string membershipType = default(string))
        {
            this.MembershipBalance = membershipBalance;
            this.MembershipType = membershipType;
        }

        /// <summary>
        /// 周卡、月卡：剩余天数（包括今天），单位日； 次卡：剩余次数（包括本次），单位次； 储值：余额，单位元； 折扣：折扣力度，代表0-10折；0折即为免费；
        /// </summary>
        /// <value>周卡、月卡：剩余天数（包括今天），单位日； 次卡：剩余次数（包括本次），单位次； 储值：余额，单位元； 折扣：折扣力度，代表0-10折；0折即为免费；</value>
        [DataMember(Name = "membership_balance", EmitDefaultValue = false)]
        public string MembershipBalance { get; set; }

        /// <summary>
        /// 会员类型； WEEK_CARD：周卡 MONTH_CARD：月卡 SEASON_CARD：季卡 YEAR_CARD：年卡 MULTIPLE_PASS_CARD：次卡 MONEY_STORED_CARD：储值 DISCOUNT_CARD：折扣
        /// </summary>
        /// <value>会员类型； WEEK_CARD：周卡 MONTH_CARD：月卡 SEASON_CARD：季卡 YEAR_CARD：年卡 MULTIPLE_PASS_CARD：次卡 MONEY_STORED_CARD：储值 DISCOUNT_CARD：折扣</value>
        [DataMember(Name = "membership_type", EmitDefaultValue = false)]
        public string MembershipType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParkingMembershipInfo {\n");
            sb.Append("  MembershipBalance: ").Append(MembershipBalance).Append("\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
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
            return this.Equals(input as ParkingMembershipInfo);
        }

        /// <summary>
        /// Returns true if ParkingMembershipInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ParkingMembershipInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParkingMembershipInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MembershipBalance == input.MembershipBalance ||
                    (this.MembershipBalance != null &&
                    this.MembershipBalance.Equals(input.MembershipBalance))
                ) && 
                (
                    this.MembershipType == input.MembershipType ||
                    (this.MembershipType != null &&
                    this.MembershipType.Equals(input.MembershipType))
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
                if (this.MembershipBalance != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipBalance.GetHashCode();
                }
                if (this.MembershipType != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipType.GetHashCode();
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
