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
    /// AlipayIserviceCcmServiceCloseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmServiceCloseModel")]
    public partial class AlipayIserviceCcmServiceCloseModel : IEquatable<AlipayIserviceCcmServiceCloseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmServiceCloseModel" /> class.
        /// </summary>
        /// <param name="serviceCode">服务代码。通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01dmgh\&quot;&gt;alipay.iservice.ccm.service.initialize&lt;/a&gt;(isv服务初始化接口) 获取。.</param>
        public AlipayIserviceCcmServiceCloseModel(string serviceCode = default(string))
        {
            this.ServiceCode = serviceCode;
        }

        /// <summary>
        /// 服务代码。通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01dmgh\&quot;&gt;alipay.iservice.ccm.service.initialize&lt;/a&gt;(isv服务初始化接口) 获取。
        /// </summary>
        /// <value>服务代码。通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01dmgh\&quot;&gt;alipay.iservice.ccm.service.initialize&lt;/a&gt;(isv服务初始化接口) 获取。</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmServiceCloseModel {\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmServiceCloseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmServiceCloseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmServiceCloseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmServiceCloseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
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
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
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
