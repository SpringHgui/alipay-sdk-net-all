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
    /// AntMerchantExpandMccQueryResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandMccQueryResponseModel")]
    public partial class AntMerchantExpandMccQueryResponseModel : IEquatable<AntMerchantExpandMccQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandMccQueryResponseModel" /> class.
        /// </summary>
        /// <param name="mccInfoList">mcc查询信息结果列表.</param>
        public AntMerchantExpandMccQueryResponseModel(List<MccQueryInfo> mccInfoList = default(List<MccQueryInfo>))
        {
            this.MccInfoList = mccInfoList;
        }

        /// <summary>
        /// mcc查询信息结果列表
        /// </summary>
        /// <value>mcc查询信息结果列表</value>
        [DataMember(Name = "mcc_info_list", EmitDefaultValue = false)]
        public List<MccQueryInfo> MccInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandMccQueryResponseModel {\n");
            sb.Append("  MccInfoList: ").Append(MccInfoList).Append("\n");
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
            return this.Equals(input as AntMerchantExpandMccQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandMccQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandMccQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandMccQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MccInfoList == input.MccInfoList ||
                    this.MccInfoList != null &&
                    input.MccInfoList != null &&
                    this.MccInfoList.SequenceEqual(input.MccInfoList)
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
                if (this.MccInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.MccInfoList.GetHashCode();
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
