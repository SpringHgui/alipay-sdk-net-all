/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// AlipayMobilePublicMenuUpdateModel
    /// </summary>
    [DataContract(Name = "AlipayMobilePublicMenuUpdateModel")]
    public partial class AlipayMobilePublicMenuUpdateModel : IEquatable<AlipayMobilePublicMenuUpdateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMobilePublicMenuUpdateModel" /> class.
        /// </summary>
        /// <param name="bizContent">json串，&lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7386797.0.0.1l7WMo&amp;treeId&#x3D;53&amp;articleId&#x3D;103481&amp;docType&#x3D;1\&quot;&gt;详情请见&lt;/a&gt;.</param>
        public AlipayMobilePublicMenuUpdateModel(string bizContent = default(string))
        {
            this.BizContent = bizContent;
        }

        /// <summary>
        /// json串，&lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7386797.0.0.1l7WMo&amp;treeId&#x3D;53&amp;articleId&#x3D;103481&amp;docType&#x3D;1\&quot;&gt;详情请见&lt;/a&gt;
        /// </summary>
        /// <value>json串，&lt;a href&#x3D;\&quot;https://doc.open.alipay.com/doc2/detail.htm?spm&#x3D;a219a.7386797.0.0.1l7WMo&amp;treeId&#x3D;53&amp;articleId&#x3D;103481&amp;docType&#x3D;1\&quot;&gt;详情请见&lt;/a&gt;</value>
        [DataMember(Name = "biz_content", EmitDefaultValue = false)]
        public string BizContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMobilePublicMenuUpdateModel {\n");
            sb.Append("  BizContent: ").Append(BizContent).Append("\n");
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
            return this.Equals(input as AlipayMobilePublicMenuUpdateModel);
        }

        /// <summary>
        /// Returns true if AlipayMobilePublicMenuUpdateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMobilePublicMenuUpdateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMobilePublicMenuUpdateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizContent == input.BizContent ||
                    (this.BizContent != null &&
                    this.BizContent.Equals(input.BizContent))
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
                if (this.BizContent != null)
                {
                    hashCode = (hashCode * 59) + this.BizContent.GetHashCode();
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
