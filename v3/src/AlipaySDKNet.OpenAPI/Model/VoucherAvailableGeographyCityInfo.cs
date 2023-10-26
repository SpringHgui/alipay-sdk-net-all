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
    /// VoucherAvailableGeographyCityInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGeographyCityInfo")]
    public partial class VoucherAvailableGeographyCityInfo : IEquatable<VoucherAvailableGeographyCityInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGeographyCityInfo" /> class.
        /// </summary>
        /// <param name="allCity">是否全国。 选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。.</param>
        /// <param name="availableCityCodes">城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        public VoucherAvailableGeographyCityInfo(bool allCity = default(bool), List<string> availableCityCodes = default(List<string>))
        {
            this.AllCity = allCity;
            this.AvailableCityCodes = availableCityCodes;
        }

        /// <summary>
        /// 是否全国。 选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。
        /// </summary>
        /// <value>是否全国。 选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。</value>
        [DataMember(Name = "all_city", EmitDefaultValue = true)]
        public bool AllCity { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "available_city_codes", EmitDefaultValue = false)]
        public List<string> AvailableCityCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGeographyCityInfo {\n");
            sb.Append("  AllCity: ").Append(AllCity).Append("\n");
            sb.Append("  AvailableCityCodes: ").Append(AvailableCityCodes).Append("\n");
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
            return this.Equals(input as VoucherAvailableGeographyCityInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGeographyCityInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGeographyCityInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGeographyCityInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllCity == input.AllCity ||
                    this.AllCity.Equals(input.AllCity)
                ) && 
                (
                    this.AvailableCityCodes == input.AvailableCityCodes ||
                    this.AvailableCityCodes != null &&
                    input.AvailableCityCodes != null &&
                    this.AvailableCityCodes.SequenceEqual(input.AvailableCityCodes)
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
                hashCode = (hashCode * 59) + this.AllCity.GetHashCode();
                if (this.AvailableCityCodes != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableCityCodes.GetHashCode();
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
