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
    /// AlipayOpenAppServiceApplyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppServiceApplyModel")]
    public partial class AlipayOpenAppServiceApplyModel : IEquatable<AlipayOpenAppServiceApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppServiceApplyModel" /> class.
        /// </summary>
        /// <param name="categoryId">行业类目id.</param>
        /// <param name="outBizNo">外部业务编号,平台会基于appId+out_biz_no做幂等控制，如果出现幂等，会返回幂等的service_code.</param>
        /// <param name="schemaVersion">服务schema版本.</param>
        /// <param name="serviceCode">服务编码, 首次提报时设置空值，支付宝侧返回ServiceCode；当传入serviceCode，则对已提报服务做编辑操作。.</param>
        /// <param name="serviceXml">服务xml.</param>
        /// <param name="templateType">服务模版。若当前服务类目只有一个服务模版，可不填。.</param>
        public AlipayOpenAppServiceApplyModel(string categoryId = default(string), string outBizNo = default(string), string schemaVersion = default(string), string serviceCode = default(string), string serviceXml = default(string), string templateType = default(string))
        {
            this.CategoryId = categoryId;
            this.OutBizNo = outBizNo;
            this.SchemaVersion = schemaVersion;
            this.ServiceCode = serviceCode;
            this.ServiceXml = serviceXml;
            this.TemplateType = templateType;
        }

        /// <summary>
        /// 行业类目id
        /// </summary>
        /// <value>行业类目id</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 外部业务编号,平台会基于appId+out_biz_no做幂等控制，如果出现幂等，会返回幂等的service_code
        /// </summary>
        /// <value>外部业务编号,平台会基于appId+out_biz_no做幂等控制，如果出现幂等，会返回幂等的service_code</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 服务schema版本
        /// </summary>
        /// <value>服务schema版本</value>
        [DataMember(Name = "schema_version", EmitDefaultValue = false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// 服务编码, 首次提报时设置空值，支付宝侧返回ServiceCode；当传入serviceCode，则对已提报服务做编辑操作。
        /// </summary>
        /// <value>服务编码, 首次提报时设置空值，支付宝侧返回ServiceCode；当传入serviceCode，则对已提报服务做编辑操作。</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务xml
        /// </summary>
        /// <value>服务xml</value>
        [DataMember(Name = "service_xml", EmitDefaultValue = false)]
        public string ServiceXml { get; set; }

        /// <summary>
        /// 服务模版。若当前服务类目只有一个服务模版，可不填。
        /// </summary>
        /// <value>服务模版。若当前服务类目只有一个服务模版，可不填。</value>
        [DataMember(Name = "template_type", EmitDefaultValue = false)]
        public string TemplateType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppServiceApplyModel {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceXml: ").Append(ServiceXml).Append("\n");
            sb.Append("  TemplateType: ").Append(TemplateType).Append("\n");
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
            return this.Equals(input as AlipayOpenAppServiceApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppServiceApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppServiceApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppServiceApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.SchemaVersion == input.SchemaVersion ||
                    (this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(input.SchemaVersion))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ServiceXml == input.ServiceXml ||
                    (this.ServiceXml != null &&
                    this.ServiceXml.Equals(input.ServiceXml))
                ) && 
                (
                    this.TemplateType == input.TemplateType ||
                    (this.TemplateType != null &&
                    this.TemplateType.Equals(input.TemplateType))
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
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.SchemaVersion != null)
                {
                    hashCode = (hashCode * 59) + this.SchemaVersion.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ServiceXml != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceXml.GetHashCode();
                }
                if (this.TemplateType != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateType.GetHashCode();
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
