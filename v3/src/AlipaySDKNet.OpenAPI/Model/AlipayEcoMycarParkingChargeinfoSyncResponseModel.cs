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
    /// AlipayEcoMycarParkingChargeinfoSyncResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingChargeinfoSyncResponseModel")]
    public partial class AlipayEcoMycarParkingChargeinfoSyncResponseModel : IEquatable<AlipayEcoMycarParkingChargeinfoSyncResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingChargeinfoSyncResponseModel" /> class.
        /// </summary>
        /// <param name="syncResult">同步结果：0 成功，1 失败.</param>
        public AlipayEcoMycarParkingChargeinfoSyncResponseModel(string syncResult = default(string))
        {
            this.SyncResult = syncResult;
        }

        /// <summary>
        /// 同步结果：0 成功，1 失败
        /// </summary>
        /// <value>同步结果：0 成功，1 失败</value>
        [DataMember(Name = "sync_result", EmitDefaultValue = false)]
        public string SyncResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingChargeinfoSyncResponseModel {\n");
            sb.Append("  SyncResult: ").Append(SyncResult).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingChargeinfoSyncResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingChargeinfoSyncResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingChargeinfoSyncResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingChargeinfoSyncResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SyncResult == input.SyncResult ||
                    (this.SyncResult != null &&
                    this.SyncResult.Equals(input.SyncResult))
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
                if (this.SyncResult != null)
                {
                    hashCode = (hashCode * 59) + this.SyncResult.GetHashCode();
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
