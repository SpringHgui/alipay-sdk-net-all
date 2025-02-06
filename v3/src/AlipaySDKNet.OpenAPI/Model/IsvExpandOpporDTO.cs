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
    /// IsvExpandOpporDTO
    /// </summary>
    [DataContract(Name = "IsvExpandOpporDTO")]
    public partial class IsvExpandOpporDTO : IEquatable<IsvExpandOpporDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IsvExpandOpporDTO" /> class.
        /// </summary>
        /// <param name="address">商机地址.</param>
        /// <param name="leadsId">商机Id.</param>
        /// <param name="name">商机名称.</param>
        /// <param name="opporId">商机作业Id.</param>
        /// <param name="outBizNo">外部幂等唯一键.</param>
        /// <param name="phone">商机联系电话.</param>
        /// <param name="status">商机作业状态.</param>
        public IsvExpandOpporDTO(string address = default(string), string leadsId = default(string), string name = default(string), string opporId = default(string), string outBizNo = default(string), string phone = default(string), string status = default(string))
        {
            this.Address = address;
            this.LeadsId = leadsId;
            this.Name = name;
            this.OpporId = opporId;
            this.OutBizNo = outBizNo;
            this.Phone = phone;
            this.Status = status;
        }

        /// <summary>
        /// 商机地址
        /// </summary>
        /// <value>商机地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 商机Id
        /// </summary>
        /// <value>商机Id</value>
        [DataMember(Name = "leads_id", EmitDefaultValue = false)]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商机名称
        /// </summary>
        /// <value>商机名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 商机作业Id
        /// </summary>
        /// <value>商机作业Id</value>
        [DataMember(Name = "oppor_id", EmitDefaultValue = false)]
        public string OpporId { get; set; }

        /// <summary>
        /// 外部幂等唯一键
        /// </summary>
        /// <value>外部幂等唯一键</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商机联系电话
        /// </summary>
        /// <value>商机联系电话</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// 商机作业状态
        /// </summary>
        /// <value>商机作业状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IsvExpandOpporDTO {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LeadsId: ").Append(LeadsId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpporId: ").Append(OpporId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as IsvExpandOpporDTO);
        }

        /// <summary>
        /// Returns true if IsvExpandOpporDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of IsvExpandOpporDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IsvExpandOpporDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.LeadsId == input.LeadsId ||
                    (this.LeadsId != null &&
                    this.LeadsId.Equals(input.LeadsId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpporId == input.OpporId ||
                    (this.OpporId != null &&
                    this.OpporId.Equals(input.OpporId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.LeadsId != null)
                {
                    hashCode = (hashCode * 59) + this.LeadsId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OpporId != null)
                {
                    hashCode = (hashCode * 59) + this.OpporId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
