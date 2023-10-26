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
    /// BkAgentRespInfo
    /// </summary>
    [DataContract(Name = "BkAgentRespInfo")]
    public partial class BkAgentRespInfo : IEquatable<BkAgentRespInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BkAgentRespInfo" /> class.
        /// </summary>
        /// <param name="bindclrissrId">枚举值，01 银联；02 网联；03 连通等.</param>
        /// <param name="bindpyeracctbkId">付款机构在清算组织登记或分配的机构代码.</param>
        /// <param name="bindtrxId">原快捷交易流水号.</param>
        /// <param name="bkpyeruserCode">用户在银行付款账号的标记化处理编号.</param>
        /// <param name="estterLocation">设备推测位置.</param>
        public BkAgentRespInfo(string bindclrissrId = default(string), string bindpyeracctbkId = default(string), string bindtrxId = default(string), string bkpyeruserCode = default(string), string estterLocation = default(string))
        {
            this.BindclrissrId = bindclrissrId;
            this.BindpyeracctbkId = bindpyeracctbkId;
            this.BindtrxId = bindtrxId;
            this.BkpyeruserCode = bkpyeruserCode;
            this.EstterLocation = estterLocation;
        }

        /// <summary>
        /// 枚举值，01 银联；02 网联；03 连通等
        /// </summary>
        /// <value>枚举值，01 银联；02 网联；03 连通等</value>
        [DataMember(Name = "bindclrissr_id", EmitDefaultValue = false)]
        public string BindclrissrId { get; set; }

        /// <summary>
        /// 付款机构在清算组织登记或分配的机构代码
        /// </summary>
        /// <value>付款机构在清算组织登记或分配的机构代码</value>
        [DataMember(Name = "bindpyeracctbk_id", EmitDefaultValue = false)]
        public string BindpyeracctbkId { get; set; }

        /// <summary>
        /// 原快捷交易流水号
        /// </summary>
        /// <value>原快捷交易流水号</value>
        [DataMember(Name = "bindtrx_id", EmitDefaultValue = false)]
        public string BindtrxId { get; set; }

        /// <summary>
        /// 用户在银行付款账号的标记化处理编号
        /// </summary>
        /// <value>用户在银行付款账号的标记化处理编号</value>
        [DataMember(Name = "bkpyeruser_code", EmitDefaultValue = false)]
        public string BkpyeruserCode { get; set; }

        /// <summary>
        /// 设备推测位置
        /// </summary>
        /// <value>设备推测位置</value>
        [DataMember(Name = "estter_location", EmitDefaultValue = false)]
        public string EstterLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BkAgentRespInfo {\n");
            sb.Append("  BindclrissrId: ").Append(BindclrissrId).Append("\n");
            sb.Append("  BindpyeracctbkId: ").Append(BindpyeracctbkId).Append("\n");
            sb.Append("  BindtrxId: ").Append(BindtrxId).Append("\n");
            sb.Append("  BkpyeruserCode: ").Append(BkpyeruserCode).Append("\n");
            sb.Append("  EstterLocation: ").Append(EstterLocation).Append("\n");
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
            return this.Equals(input as BkAgentRespInfo);
        }

        /// <summary>
        /// Returns true if BkAgentRespInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BkAgentRespInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BkAgentRespInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindclrissrId == input.BindclrissrId ||
                    (this.BindclrissrId != null &&
                    this.BindclrissrId.Equals(input.BindclrissrId))
                ) && 
                (
                    this.BindpyeracctbkId == input.BindpyeracctbkId ||
                    (this.BindpyeracctbkId != null &&
                    this.BindpyeracctbkId.Equals(input.BindpyeracctbkId))
                ) && 
                (
                    this.BindtrxId == input.BindtrxId ||
                    (this.BindtrxId != null &&
                    this.BindtrxId.Equals(input.BindtrxId))
                ) && 
                (
                    this.BkpyeruserCode == input.BkpyeruserCode ||
                    (this.BkpyeruserCode != null &&
                    this.BkpyeruserCode.Equals(input.BkpyeruserCode))
                ) && 
                (
                    this.EstterLocation == input.EstterLocation ||
                    (this.EstterLocation != null &&
                    this.EstterLocation.Equals(input.EstterLocation))
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
                if (this.BindclrissrId != null)
                {
                    hashCode = (hashCode * 59) + this.BindclrissrId.GetHashCode();
                }
                if (this.BindpyeracctbkId != null)
                {
                    hashCode = (hashCode * 59) + this.BindpyeracctbkId.GetHashCode();
                }
                if (this.BindtrxId != null)
                {
                    hashCode = (hashCode * 59) + this.BindtrxId.GetHashCode();
                }
                if (this.BkpyeruserCode != null)
                {
                    hashCode = (hashCode * 59) + this.BkpyeruserCode.GetHashCode();
                }
                if (this.EstterLocation != null)
                {
                    hashCode = (hashCode * 59) + this.EstterLocation.GetHashCode();
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
