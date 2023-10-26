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
    /// AlipayOpenMiniTemplatemsgMaketingBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTemplatemsgMaketingBatchqueryModel")]
    public partial class AlipayOpenMiniTemplatemsgMaketingBatchqueryModel : IEquatable<AlipayOpenMiniTemplatemsgMaketingBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplatemsgMaketingBatchqueryModel" /> class.
        /// </summary>
        /// <param name="pageNum">分页查询页码.</param>
        /// <param name="pageSize">每页展示条数，最大支持50个.</param>
        public AlipayOpenMiniTemplatemsgMaketingBatchqueryModel(int pageNum = default(int), int pageSize = default(int))
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        /// <value>分页查询页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 每页展示条数，最大支持50个
        /// </summary>
        /// <value>每页展示条数，最大支持50个</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTemplatemsgMaketingBatchqueryModel {\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTemplatemsgMaketingBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTemplatemsgMaketingBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTemplatemsgMaketingBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTemplatemsgMaketingBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
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
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
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
