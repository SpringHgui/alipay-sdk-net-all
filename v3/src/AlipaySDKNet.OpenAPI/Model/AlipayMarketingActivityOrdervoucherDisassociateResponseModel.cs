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
    /// AlipayMarketingActivityOrdervoucherDisassociateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherDisassociateResponseModel")]
    public partial class AlipayMarketingActivityOrdervoucherDisassociateResponseModel : IEquatable<AlipayMarketingActivityOrdervoucherDisassociateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherDisassociateResponseModel" /> class.
        /// </summary>
        /// <param name="disassociateTime">支付宝系统取消关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss.</param>
        public AlipayMarketingActivityOrdervoucherDisassociateResponseModel(string disassociateTime = default(string))
        {
            this.DisassociateTime = disassociateTime;
        }

        /// <summary>
        /// 支付宝系统取消关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>支付宝系统取消关联订单成功的时间。 格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "disassociate_time", EmitDefaultValue = false)]
        public string DisassociateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherDisassociateResponseModel {\n");
            sb.Append("  DisassociateTime: ").Append(DisassociateTime).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherDisassociateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherDisassociateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherDisassociateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherDisassociateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisassociateTime == input.DisassociateTime ||
                    (this.DisassociateTime != null &&
                    this.DisassociateTime.Equals(input.DisassociateTime))
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
                if (this.DisassociateTime != null)
                {
                    hashCode = (hashCode * 59) + this.DisassociateTime.GetHashCode();
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
