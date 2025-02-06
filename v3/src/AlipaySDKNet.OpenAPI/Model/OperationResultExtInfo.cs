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
    /// OperationResultExtInfo
    /// </summary>
    [DataContract(Name = "OperationResultExtInfo")]
    public partial class OperationResultExtInfo : IEquatable<OperationResultExtInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationResultExtInfo" /> class.
        /// </summary>
        /// <param name="activationTime">激活时间.</param>
        /// <param name="deviceNo">设备号.</param>
        public OperationResultExtInfo(string activationTime = default(string), string deviceNo = default(string))
        {
            this.ActivationTime = activationTime;
            this.DeviceNo = deviceNo;
        }

        /// <summary>
        /// 激活时间
        /// </summary>
        /// <value>激活时间</value>
        [DataMember(Name = "activation_time", EmitDefaultValue = false)]
        public string ActivationTime { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        /// <value>设备号</value>
        [DataMember(Name = "device_no", EmitDefaultValue = false)]
        public string DeviceNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperationResultExtInfo {\n");
            sb.Append("  ActivationTime: ").Append(ActivationTime).Append("\n");
            sb.Append("  DeviceNo: ").Append(DeviceNo).Append("\n");
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
            return this.Equals(input as OperationResultExtInfo);
        }

        /// <summary>
        /// Returns true if OperationResultExtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationResultExtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationResultExtInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivationTime == input.ActivationTime ||
                    (this.ActivationTime != null &&
                    this.ActivationTime.Equals(input.ActivationTime))
                ) && 
                (
                    this.DeviceNo == input.DeviceNo ||
                    (this.DeviceNo != null &&
                    this.DeviceNo.Equals(input.DeviceNo))
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
                if (this.ActivationTime != null)
                {
                    hashCode = (hashCode * 59) + this.ActivationTime.GetHashCode();
                }
                if (this.DeviceNo != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceNo.GetHashCode();
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
