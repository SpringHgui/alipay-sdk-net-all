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
    /// ZhimaMerchantZmgoTemplateCreateResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaMerchantZmgoTemplateCreateResponseModel")]
    public partial class ZhimaMerchantZmgoTemplateCreateResponseModel : IEquatable<ZhimaMerchantZmgoTemplateCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantZmgoTemplateCreateResponseModel" /> class.
        /// </summary>
        /// <param name="templateNo">芝麻GO模板号.</param>
        public ZhimaMerchantZmgoTemplateCreateResponseModel(string templateNo = default(string))
        {
            this.TemplateNo = templateNo;
        }

        /// <summary>
        /// 芝麻GO模板号
        /// </summary>
        /// <value>芝麻GO模板号</value>
        [DataMember(Name = "template_no", EmitDefaultValue = false)]
        public string TemplateNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaMerchantZmgoTemplateCreateResponseModel {\n");
            sb.Append("  TemplateNo: ").Append(TemplateNo).Append("\n");
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
            return this.Equals(input as ZhimaMerchantZmgoTemplateCreateResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaMerchantZmgoTemplateCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaMerchantZmgoTemplateCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaMerchantZmgoTemplateCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TemplateNo == input.TemplateNo ||
                    (this.TemplateNo != null &&
                    this.TemplateNo.Equals(input.TemplateNo))
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
                if (this.TemplateNo != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateNo.GetHashCode();
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
