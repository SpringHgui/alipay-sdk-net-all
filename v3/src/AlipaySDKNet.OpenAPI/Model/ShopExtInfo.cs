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
    /// ShopExtInfo
    /// </summary>
    [DataContract(Name = "ShopExtInfo")]
    public partial class ShopExtInfo : IEquatable<ShopExtInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopExtInfo" /> class.
        /// </summary>
        /// <param name="keyName">KV数据对的key，表示该kv对象表示什么含义。.</param>
        /// <param name="value">kv对象的值.</param>
        public ShopExtInfo(string keyName = default(string), string value = default(string))
        {
            this.KeyName = keyName;
            this.Value = value;
        }

        /// <summary>
        /// KV数据对的key，表示该kv对象表示什么含义。
        /// </summary>
        /// <value>KV数据对的key，表示该kv对象表示什么含义。</value>
        [DataMember(Name = "key_name", EmitDefaultValue = false)]
        public string KeyName { get; set; }

        /// <summary>
        /// kv对象的值
        /// </summary>
        /// <value>kv对象的值</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShopExtInfo {\n");
            sb.Append("  KeyName: ").Append(KeyName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ShopExtInfo);
        }

        /// <summary>
        /// Returns true if ShopExtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopExtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopExtInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyName == input.KeyName ||
                    (this.KeyName != null &&
                    this.KeyName.Equals(input.KeyName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.KeyName != null)
                {
                    hashCode = (hashCode * 59) + this.KeyName.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
