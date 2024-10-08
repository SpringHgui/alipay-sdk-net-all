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
    /// VoucherAvailableGeographyAllShopResultInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGeographyAllShopResultInfo")]
    public partial class VoucherAvailableGeographyAllShopResultInfo : IEquatable<VoucherAvailableGeographyAllShopResultInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGeographyAllShopResultInfo" /> class.
        /// </summary>
        /// <param name="failExcludeShopInfos">请求失败的不可用门店详情。.</param>
        /// <param name="successExcludeShopIds">请求成功的不可用门店列表。.</param>
        public VoucherAvailableGeographyAllShopResultInfo(List<VoucherFailShopInfo> failExcludeShopInfos = default(List<VoucherFailShopInfo>), List<string> successExcludeShopIds = default(List<string>))
        {
            this.FailExcludeShopInfos = failExcludeShopInfos;
            this.SuccessExcludeShopIds = successExcludeShopIds;
        }

        /// <summary>
        /// 请求失败的不可用门店详情。
        /// </summary>
        /// <value>请求失败的不可用门店详情。</value>
        [DataMember(Name = "fail_exclude_shop_infos", EmitDefaultValue = false)]
        public List<VoucherFailShopInfo> FailExcludeShopInfos { get; set; }

        /// <summary>
        /// 请求成功的不可用门店列表。
        /// </summary>
        /// <value>请求成功的不可用门店列表。</value>
        [DataMember(Name = "success_exclude_shop_ids", EmitDefaultValue = false)]
        public List<string> SuccessExcludeShopIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGeographyAllShopResultInfo {\n");
            sb.Append("  FailExcludeShopInfos: ").Append(FailExcludeShopInfos).Append("\n");
            sb.Append("  SuccessExcludeShopIds: ").Append(SuccessExcludeShopIds).Append("\n");
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
            return this.Equals(input as VoucherAvailableGeographyAllShopResultInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGeographyAllShopResultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGeographyAllShopResultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGeographyAllShopResultInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailExcludeShopInfos == input.FailExcludeShopInfos ||
                    this.FailExcludeShopInfos != null &&
                    input.FailExcludeShopInfos != null &&
                    this.FailExcludeShopInfos.SequenceEqual(input.FailExcludeShopInfos)
                ) && 
                (
                    this.SuccessExcludeShopIds == input.SuccessExcludeShopIds ||
                    this.SuccessExcludeShopIds != null &&
                    input.SuccessExcludeShopIds != null &&
                    this.SuccessExcludeShopIds.SequenceEqual(input.SuccessExcludeShopIds)
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
                if (this.FailExcludeShopInfos != null)
                {
                    hashCode = (hashCode * 59) + this.FailExcludeShopInfos.GetHashCode();
                }
                if (this.SuccessExcludeShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessExcludeShopIds.GetHashCode();
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
