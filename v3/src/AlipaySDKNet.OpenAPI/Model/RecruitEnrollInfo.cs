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
    /// RecruitEnrollInfo
    /// </summary>
    [DataContract(Name = "RecruitEnrollInfo")]
    public partial class RecruitEnrollInfo : IEquatable<RecruitEnrollInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitEnrollInfo" /> class.
        /// </summary>
        /// <param name="cities">报名提交的活动城市码，详见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/02r07u\&quot; target&#x3D;\&quot;_blank\&quot;&gt;活动城市码&lt;/a&gt;.</param>
        /// <param name="enrollMerchant">enrollMerchant.</param>
        /// <param name="materials">报名提交的素材.</param>
        /// <param name="miniApps">报名提交的小程序信息，是否必选取决于方案要求.</param>
        /// <param name="vouchers">报名提交的券信息，是否必选取决于方案要求.</param>
        public RecruitEnrollInfo(List<string> cities = default(List<string>), RecruitEnrollMerchant enrollMerchant = default(RecruitEnrollMerchant), List<RecruitMaterial> materials = default(List<RecruitMaterial>), List<RecruitMiniApp> miniApps = default(List<RecruitMiniApp>), List<RecruitVoucher> vouchers = default(List<RecruitVoucher>))
        {
            this.Cities = cities;
            this.EnrollMerchant = enrollMerchant;
            this.Materials = materials;
            this.MiniApps = miniApps;
            this.Vouchers = vouchers;
        }

        /// <summary>
        /// 报名提交的活动城市码，详见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/02r07u\&quot; target&#x3D;\&quot;_blank\&quot;&gt;活动城市码&lt;/a&gt;
        /// </summary>
        /// <value>报名提交的活动城市码，详见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/02r07u\&quot; target&#x3D;\&quot;_blank\&quot;&gt;活动城市码&lt;/a&gt;</value>
        [DataMember(Name = "cities", EmitDefaultValue = false)]
        public List<string> Cities { get; set; }

        /// <summary>
        /// Gets or Sets EnrollMerchant
        /// </summary>
        [DataMember(Name = "enroll_merchant", EmitDefaultValue = false)]
        public RecruitEnrollMerchant EnrollMerchant { get; set; }

        /// <summary>
        /// 报名提交的素材
        /// </summary>
        /// <value>报名提交的素材</value>
        [DataMember(Name = "materials", EmitDefaultValue = false)]
        public List<RecruitMaterial> Materials { get; set; }

        /// <summary>
        /// 报名提交的小程序信息，是否必选取决于方案要求
        /// </summary>
        /// <value>报名提交的小程序信息，是否必选取决于方案要求</value>
        [DataMember(Name = "mini_apps", EmitDefaultValue = false)]
        public List<RecruitMiniApp> MiniApps { get; set; }

        /// <summary>
        /// 报名提交的券信息，是否必选取决于方案要求
        /// </summary>
        /// <value>报名提交的券信息，是否必选取决于方案要求</value>
        [DataMember(Name = "vouchers", EmitDefaultValue = false)]
        public List<RecruitVoucher> Vouchers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecruitEnrollInfo {\n");
            sb.Append("  Cities: ").Append(Cities).Append("\n");
            sb.Append("  EnrollMerchant: ").Append(EnrollMerchant).Append("\n");
            sb.Append("  Materials: ").Append(Materials).Append("\n");
            sb.Append("  MiniApps: ").Append(MiniApps).Append("\n");
            sb.Append("  Vouchers: ").Append(Vouchers).Append("\n");
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
            return this.Equals(input as RecruitEnrollInfo);
        }

        /// <summary>
        /// Returns true if RecruitEnrollInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RecruitEnrollInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecruitEnrollInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cities == input.Cities ||
                    this.Cities != null &&
                    input.Cities != null &&
                    this.Cities.SequenceEqual(input.Cities)
                ) && 
                (
                    this.EnrollMerchant == input.EnrollMerchant ||
                    (this.EnrollMerchant != null &&
                    this.EnrollMerchant.Equals(input.EnrollMerchant))
                ) && 
                (
                    this.Materials == input.Materials ||
                    this.Materials != null &&
                    input.Materials != null &&
                    this.Materials.SequenceEqual(input.Materials)
                ) && 
                (
                    this.MiniApps == input.MiniApps ||
                    this.MiniApps != null &&
                    input.MiniApps != null &&
                    this.MiniApps.SequenceEqual(input.MiniApps)
                ) && 
                (
                    this.Vouchers == input.Vouchers ||
                    this.Vouchers != null &&
                    input.Vouchers != null &&
                    this.Vouchers.SequenceEqual(input.Vouchers)
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
                if (this.Cities != null)
                {
                    hashCode = (hashCode * 59) + this.Cities.GetHashCode();
                }
                if (this.EnrollMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollMerchant.GetHashCode();
                }
                if (this.Materials != null)
                {
                    hashCode = (hashCode * 59) + this.Materials.GetHashCode();
                }
                if (this.MiniApps != null)
                {
                    hashCode = (hashCode * 59) + this.MiniApps.GetHashCode();
                }
                if (this.Vouchers != null)
                {
                    hashCode = (hashCode * 59) + this.Vouchers.GetHashCode();
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
