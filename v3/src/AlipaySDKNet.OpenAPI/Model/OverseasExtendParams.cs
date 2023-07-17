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
    /// OverseasExtendParams
    /// </summary>
    [DataContract(Name = "OverseasExtendParams")]
    public partial class OverseasExtendParams : IEquatable<OverseasExtendParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OverseasExtendParams" /> class.
        /// </summary>
        /// <param name="goodsDetail">商品明细列表.</param>
        public OverseasExtendParams(string goodsDetail = default(string))
        {
            this.GoodsDetail = goodsDetail;
        }

        /// <summary>
        /// 商品明细列表
        /// </summary>
        /// <value>商品明细列表</value>
        [DataMember(Name = "goods_detail", EmitDefaultValue = false)]
        public string GoodsDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OverseasExtendParams {\n");
            sb.Append("  GoodsDetail: ").Append(GoodsDetail).Append("\n");
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
            return this.Equals(input as OverseasExtendParams);
        }

        /// <summary>
        /// Returns true if OverseasExtendParams instances are equal
        /// </summary>
        /// <param name="input">Instance of OverseasExtendParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OverseasExtendParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsDetail == input.GoodsDetail ||
                    (this.GoodsDetail != null &&
                    this.GoodsDetail.Equals(input.GoodsDetail))
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
                if (this.GoodsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetail.GetHashCode();
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
