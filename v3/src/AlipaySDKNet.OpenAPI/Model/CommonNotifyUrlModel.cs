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
    /// CommonNotifyUrlModel
    /// </summary>
    [DataContract(Name = "CommonNotifyUrlModel")]
    public partial class CommonNotifyUrlModel : IEquatable<CommonNotifyUrlModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonNotifyUrlModel" /> class.
        /// </summary>
        /// <param name="notifyUrl">通知地址.</param>
        public CommonNotifyUrlModel(string notifyUrl = default(string))
        {
            this.NotifyUrl = notifyUrl;
        }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonNotifyUrlModel {\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
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
            return this.Equals(input as CommonNotifyUrlModel);
        }

        /// <summary>
        /// Returns true if CommonNotifyUrlModel instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonNotifyUrlModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonNotifyUrlModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
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
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
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
