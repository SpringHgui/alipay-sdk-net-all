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
    /// ReceiverAddressInfo
    /// </summary>
    [DataContract(Name = "ReceiverAddressInfo")]
    public partial class ReceiverAddressInfo : IEquatable<ReceiverAddressInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReceiverAddressInfo" /> class.
        /// </summary>
        /// <param name="address">收货地址.</param>
        /// <param name="divisionCode">中国标准城市区域码.</param>
        /// <param name="mobile">收货人手机号.</param>
        /// <param name="name">收货人的姓名.</param>
        /// <param name="zip">收货地址邮编.</param>
        public ReceiverAddressInfo(string address = default(string), string divisionCode = default(string), string mobile = default(string), string name = default(string), string zip = default(string))
        {
            this.Address = address;
            this.DivisionCode = divisionCode;
            this.Mobile = mobile;
            this.Name = name;
            this.Zip = zip;
        }

        /// <summary>
        /// 收货地址
        /// </summary>
        /// <value>收货地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 中国标准城市区域码
        /// </summary>
        /// <value>中国标准城市区域码</value>
        [DataMember(Name = "division_code", EmitDefaultValue = false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        /// <value>收货人手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 收货人的姓名
        /// </summary>
        /// <value>收货人的姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 收货地址邮编
        /// </summary>
        /// <value>收货地址邮编</value>
        [DataMember(Name = "zip", EmitDefaultValue = false)]
        public string Zip { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReceiverAddressInfo {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  DivisionCode: ").Append(DivisionCode).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
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
            return this.Equals(input as ReceiverAddressInfo);
        }

        /// <summary>
        /// Returns true if ReceiverAddressInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ReceiverAddressInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReceiverAddressInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DivisionCode == input.DivisionCode ||
                    (this.DivisionCode != null &&
                    this.DivisionCode.Equals(input.DivisionCode))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Zip == input.Zip ||
                    (this.Zip != null &&
                    this.Zip.Equals(input.Zip))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.DivisionCode != null)
                {
                    hashCode = (hashCode * 59) + this.DivisionCode.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Zip != null)
                {
                    hashCode = (hashCode * 59) + this.Zip.GetHashCode();
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
