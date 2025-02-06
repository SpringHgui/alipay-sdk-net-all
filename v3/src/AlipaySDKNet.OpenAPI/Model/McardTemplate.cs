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
    /// McardTemplate
    /// </summary>
    [DataContract(Name = "McardTemplate")]
    public partial class McardTemplate : IEquatable<McardTemplate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="McardTemplate" /> class.
        /// </summary>
        /// <param name="cardType">卡类型.</param>
        /// <param name="gmtCreate">会员卡模板创建时间.</param>
        /// <param name="gmtModified">会员卡模板修改时间.</param>
        /// <param name="templateId">会员卡模板ID.</param>
        /// <param name="templateStyleInfo">templateStyleInfo.</param>
        public McardTemplate(string cardType = default(string), string gmtCreate = default(string), string gmtModified = default(string), string templateId = default(string), TemplateStyleInfoDTO templateStyleInfo = default(TemplateStyleInfoDTO))
        {
            this.CardType = cardType;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.TemplateId = templateId;
            this.TemplateStyleInfo = templateStyleInfo;
        }

        /// <summary>
        /// 卡类型
        /// </summary>
        /// <value>卡类型</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// 会员卡模板创建时间
        /// </summary>
        /// <value>会员卡模板创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 会员卡模板修改时间
        /// </summary>
        /// <value>会员卡模板修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 会员卡模板ID
        /// </summary>
        /// <value>会员卡模板ID</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateStyleInfo
        /// </summary>
        [DataMember(Name = "template_style_info", EmitDefaultValue = false)]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class McardTemplate {\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateStyleInfo: ").Append(TemplateStyleInfo).Append("\n");
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
            return this.Equals(input as McardTemplate);
        }

        /// <summary>
        /// Returns true if McardTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of McardTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(McardTemplate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateStyleInfo == input.TemplateStyleInfo ||
                    (this.TemplateStyleInfo != null &&
                    this.TemplateStyleInfo.Equals(input.TemplateStyleInfo))
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
                if (this.CardType != null)
                {
                    hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateStyleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateStyleInfo.GetHashCode();
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
