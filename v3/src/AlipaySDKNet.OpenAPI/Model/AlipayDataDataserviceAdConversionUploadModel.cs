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
    /// AlipayDataDataserviceAdConversionUploadModel
    /// </summary>
    [DataContract(Name = "AlipayDataDataserviceAdConversionUploadModel")]
    public partial class AlipayDataDataserviceAdConversionUploadModel : IEquatable<AlipayDataDataserviceAdConversionUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceAdConversionUploadModel" /> class.
        /// </summary>
        /// <param name="bizToken">代理商访问灯火平台的token.</param>
        /// <param name="conversionDataList">转化数据列表, 最多1000条.</param>
        public AlipayDataDataserviceAdConversionUploadModel(string bizToken = default(string), List<ConversionData> conversionDataList = default(List<ConversionData>))
        {
            this.BizToken = bizToken;
            this.ConversionDataList = conversionDataList;
        }

        /// <summary>
        /// 代理商访问灯火平台的token
        /// </summary>
        /// <value>代理商访问灯火平台的token</value>
        [DataMember(Name = "biz_token", EmitDefaultValue = false)]
        public string BizToken { get; set; }

        /// <summary>
        /// 转化数据列表, 最多1000条
        /// </summary>
        /// <value>转化数据列表, 最多1000条</value>
        [DataMember(Name = "conversion_data_list", EmitDefaultValue = false)]
        public List<ConversionData> ConversionDataList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataDataserviceAdConversionUploadModel {\n");
            sb.Append("  BizToken: ").Append(BizToken).Append("\n");
            sb.Append("  ConversionDataList: ").Append(ConversionDataList).Append("\n");
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
            return this.Equals(input as AlipayDataDataserviceAdConversionUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayDataDataserviceAdConversionUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataDataserviceAdConversionUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataDataserviceAdConversionUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizToken == input.BizToken ||
                    (this.BizToken != null &&
                    this.BizToken.Equals(input.BizToken))
                ) && 
                (
                    this.ConversionDataList == input.ConversionDataList ||
                    this.ConversionDataList != null &&
                    input.ConversionDataList != null &&
                    this.ConversionDataList.SequenceEqual(input.ConversionDataList)
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
                if (this.BizToken != null)
                {
                    hashCode = (hashCode * 59) + this.BizToken.GetHashCode();
                }
                if (this.ConversionDataList != null)
                {
                    hashCode = (hashCode * 59) + this.ConversionDataList.GetHashCode();
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
