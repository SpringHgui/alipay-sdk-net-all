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
    /// AlipayCommerceTransportParkingExitinfoSyncResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceTransportParkingExitinfoSyncResponseModel")]
    public partial class AlipayCommerceTransportParkingExitinfoSyncResponseModel : IEquatable<AlipayCommerceTransportParkingExitinfoSyncResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceTransportParkingExitinfoSyncResponseModel" /> class.
        /// </summary>
        /// <param name="bizCode">具体错误码.</param>
        /// <param name="bizMsg">具体错误原因.</param>
        public AlipayCommerceTransportParkingExitinfoSyncResponseModel(string bizCode = default(string), string bizMsg = default(string))
        {
            this.BizCode = bizCode;
            this.BizMsg = bizMsg;
        }

        /// <summary>
        /// 具体错误码
        /// </summary>
        /// <value>具体错误码</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 具体错误原因
        /// </summary>
        /// <value>具体错误原因</value>
        [DataMember(Name = "biz_msg", EmitDefaultValue = false)]
        public string BizMsg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceTransportParkingExitinfoSyncResponseModel {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  BizMsg: ").Append(BizMsg).Append("\n");
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
            return this.Equals(input as AlipayCommerceTransportParkingExitinfoSyncResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceTransportParkingExitinfoSyncResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceTransportParkingExitinfoSyncResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceTransportParkingExitinfoSyncResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizCode == input.BizCode ||
                    (this.BizCode != null &&
                    this.BizCode.Equals(input.BizCode))
                ) && 
                (
                    this.BizMsg == input.BizMsg ||
                    (this.BizMsg != null &&
                    this.BizMsg.Equals(input.BizMsg))
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
                if (this.BizCode != null)
                {
                    hashCode = (hashCode * 59) + this.BizCode.GetHashCode();
                }
                if (this.BizMsg != null)
                {
                    hashCode = (hashCode * 59) + this.BizMsg.GetHashCode();
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
