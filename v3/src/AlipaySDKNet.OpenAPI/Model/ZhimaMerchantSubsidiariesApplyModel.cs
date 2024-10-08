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
    /// ZhimaMerchantSubsidiariesApplyModel
    /// </summary>
    [DataContract(Name = "ZhimaMerchantSubsidiariesApplyModel")]
    public partial class ZhimaMerchantSubsidiariesApplyModel : IEquatable<ZhimaMerchantSubsidiariesApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaMerchantSubsidiariesApplyModel" /> class.
        /// </summary>
        /// <param name="pid">商户pid.</param>
        /// <param name="serviceId">信用服务id.</param>
        /// <param name="smid">二级商户进件id.</param>
        /// <param name="subMerchantContactNumber">子商户联系电话.</param>
        /// <param name="subMerchantJumpLink">子商户跳转链接.</param>
        /// <param name="subMerchantLogoUrl">子商户logo地址.</param>
        /// <param name="subMerchantName">子商户名.</param>
        /// <param name="subPid">子商户id.</param>
        public ZhimaMerchantSubsidiariesApplyModel(string pid = default(string), string serviceId = default(string), string smid = default(string), string subMerchantContactNumber = default(string), string subMerchantJumpLink = default(string), string subMerchantLogoUrl = default(string), string subMerchantName = default(string), string subPid = default(string))
        {
            this.Pid = pid;
            this.ServiceId = serviceId;
            this.Smid = smid;
            this.SubMerchantContactNumber = subMerchantContactNumber;
            this.SubMerchantJumpLink = subMerchantJumpLink;
            this.SubMerchantLogoUrl = subMerchantLogoUrl;
            this.SubMerchantName = subMerchantName;
            this.SubPid = subPid;
        }

        /// <summary>
        /// 商户pid
        /// </summary>
        /// <value>商户pid</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 信用服务id
        /// </summary>
        /// <value>信用服务id</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 二级商户进件id
        /// </summary>
        /// <value>二级商户进件id</value>
        [DataMember(Name = "smid", EmitDefaultValue = false)]
        public string Smid { get; set; }

        /// <summary>
        /// 子商户联系电话
        /// </summary>
        /// <value>子商户联系电话</value>
        [DataMember(Name = "sub_merchant_contact_number", EmitDefaultValue = false)]
        public string SubMerchantContactNumber { get; set; }

        /// <summary>
        /// 子商户跳转链接
        /// </summary>
        /// <value>子商户跳转链接</value>
        [DataMember(Name = "sub_merchant_jump_link", EmitDefaultValue = false)]
        public string SubMerchantJumpLink { get; set; }

        /// <summary>
        /// 子商户logo地址
        /// </summary>
        /// <value>子商户logo地址</value>
        [DataMember(Name = "sub_merchant_logo_url", EmitDefaultValue = false)]
        public string SubMerchantLogoUrl { get; set; }

        /// <summary>
        /// 子商户名
        /// </summary>
        /// <value>子商户名</value>
        [DataMember(Name = "sub_merchant_name", EmitDefaultValue = false)]
        public string SubMerchantName { get; set; }

        /// <summary>
        /// 子商户id
        /// </summary>
        /// <value>子商户id</value>
        [DataMember(Name = "sub_pid", EmitDefaultValue = false)]
        public string SubPid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaMerchantSubsidiariesApplyModel {\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  Smid: ").Append(Smid).Append("\n");
            sb.Append("  SubMerchantContactNumber: ").Append(SubMerchantContactNumber).Append("\n");
            sb.Append("  SubMerchantJumpLink: ").Append(SubMerchantJumpLink).Append("\n");
            sb.Append("  SubMerchantLogoUrl: ").Append(SubMerchantLogoUrl).Append("\n");
            sb.Append("  SubMerchantName: ").Append(SubMerchantName).Append("\n");
            sb.Append("  SubPid: ").Append(SubPid).Append("\n");
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
            return this.Equals(input as ZhimaMerchantSubsidiariesApplyModel);
        }

        /// <summary>
        /// Returns true if ZhimaMerchantSubsidiariesApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaMerchantSubsidiariesApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaMerchantSubsidiariesApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.Smid == input.Smid ||
                    (this.Smid != null &&
                    this.Smid.Equals(input.Smid))
                ) && 
                (
                    this.SubMerchantContactNumber == input.SubMerchantContactNumber ||
                    (this.SubMerchantContactNumber != null &&
                    this.SubMerchantContactNumber.Equals(input.SubMerchantContactNumber))
                ) && 
                (
                    this.SubMerchantJumpLink == input.SubMerchantJumpLink ||
                    (this.SubMerchantJumpLink != null &&
                    this.SubMerchantJumpLink.Equals(input.SubMerchantJumpLink))
                ) && 
                (
                    this.SubMerchantLogoUrl == input.SubMerchantLogoUrl ||
                    (this.SubMerchantLogoUrl != null &&
                    this.SubMerchantLogoUrl.Equals(input.SubMerchantLogoUrl))
                ) && 
                (
                    this.SubMerchantName == input.SubMerchantName ||
                    (this.SubMerchantName != null &&
                    this.SubMerchantName.Equals(input.SubMerchantName))
                ) && 
                (
                    this.SubPid == input.SubPid ||
                    (this.SubPid != null &&
                    this.SubPid.Equals(input.SubPid))
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
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.Smid != null)
                {
                    hashCode = (hashCode * 59) + this.Smid.GetHashCode();
                }
                if (this.SubMerchantContactNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantContactNumber.GetHashCode();
                }
                if (this.SubMerchantJumpLink != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantJumpLink.GetHashCode();
                }
                if (this.SubMerchantLogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantLogoUrl.GetHashCode();
                }
                if (this.SubMerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantName.GetHashCode();
                }
                if (this.SubPid != null)
                {
                    hashCode = (hashCode * 59) + this.SubPid.GetHashCode();
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
