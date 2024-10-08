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
    /// AlipayIserviceCcmRobotAvatarbaseQueryModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmRobotAvatarbaseQueryModel")]
    public partial class AlipayIserviceCcmRobotAvatarbaseQueryModel : IEquatable<AlipayIserviceCcmRobotAvatarbaseQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmRobotAvatarbaseQueryModel" /> class.
        /// </summary>
        /// <param name="commodityCode">开通的数字人的商品码.</param>
        /// <param name="methodParams">method_params:对应target_method请求方法的具体传参值k-v map.</param>
        /// <param name="targetMethod">targetMethod；数字人目标方法调用.</param>
        /// <param name="tenantCode">租户code&amp;租户id，对于子部门客户需要上传子部门id.</param>
        public AlipayIserviceCcmRobotAvatarbaseQueryModel(string commodityCode = default(string), string methodParams = default(string), string targetMethod = default(string), string tenantCode = default(string))
        {
            this.CommodityCode = commodityCode;
            this.MethodParams = methodParams;
            this.TargetMethod = targetMethod;
            this.TenantCode = tenantCode;
        }

        /// <summary>
        /// 开通的数字人的商品码
        /// </summary>
        /// <value>开通的数字人的商品码</value>
        [DataMember(Name = "commodity_code", EmitDefaultValue = false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// method_params:对应target_method请求方法的具体传参值k-v map
        /// </summary>
        /// <value>method_params:对应target_method请求方法的具体传参值k-v map</value>
        [DataMember(Name = "method_params", EmitDefaultValue = false)]
        public string MethodParams { get; set; }

        /// <summary>
        /// targetMethod；数字人目标方法调用
        /// </summary>
        /// <value>targetMethod；数字人目标方法调用</value>
        [DataMember(Name = "target_method", EmitDefaultValue = false)]
        public string TargetMethod { get; set; }

        /// <summary>
        /// 租户code&amp;租户id，对于子部门客户需要上传子部门id
        /// </summary>
        /// <value>租户code&amp;租户id，对于子部门客户需要上传子部门id</value>
        [DataMember(Name = "tenant_code", EmitDefaultValue = false)]
        public string TenantCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmRobotAvatarbaseQueryModel {\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  MethodParams: ").Append(MethodParams).Append("\n");
            sb.Append("  TargetMethod: ").Append(TargetMethod).Append("\n");
            sb.Append("  TenantCode: ").Append(TenantCode).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmRobotAvatarbaseQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmRobotAvatarbaseQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmRobotAvatarbaseQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmRobotAvatarbaseQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommodityCode == input.CommodityCode ||
                    (this.CommodityCode != null &&
                    this.CommodityCode.Equals(input.CommodityCode))
                ) && 
                (
                    this.MethodParams == input.MethodParams ||
                    (this.MethodParams != null &&
                    this.MethodParams.Equals(input.MethodParams))
                ) && 
                (
                    this.TargetMethod == input.TargetMethod ||
                    (this.TargetMethod != null &&
                    this.TargetMethod.Equals(input.TargetMethod))
                ) && 
                (
                    this.TenantCode == input.TenantCode ||
                    (this.TenantCode != null &&
                    this.TenantCode.Equals(input.TenantCode))
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
                if (this.CommodityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityCode.GetHashCode();
                }
                if (this.MethodParams != null)
                {
                    hashCode = (hashCode * 59) + this.MethodParams.GetHashCode();
                }
                if (this.TargetMethod != null)
                {
                    hashCode = (hashCode * 59) + this.TargetMethod.GetHashCode();
                }
                if (this.TenantCode != null)
                {
                    hashCode = (hashCode * 59) + this.TenantCode.GetHashCode();
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
