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
    /// AlipayEcoMycarParkingEnterinfoSyncResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingEnterinfoSyncResponseModel")]
    public partial class AlipayEcoMycarParkingEnterinfoSyncResponseModel : IEquatable<AlipayEcoMycarParkingEnterinfoSyncResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingEnterinfoSyncResponseModel" /> class.
        /// </summary>
        /// <param name="agreementScene">用户签约的代扣场景字符集，多个英文逗号分割，当车场为ORC识别车牌的场景，返回值包含PLATE_PAY时，表示代扣协议可用。 当车场为ETC设备识别车牌，返回值包含ETC_PAY时表示协议可用。当用户未签约任何代扣场景时返回NO_AGREEMENT_SCENE.</param>
        /// <param name="agreementStatus">该字段已废弃,请使用agreement_scene字段.</param>
        /// <param name="carStatus">当前车辆在支付宝侧的信息，是否可以使用无感支付，可选返回项为： NORMAL：正常缴费用户 NON-SENSE-PAY：可无感支付用户.</param>
        /// <param name="currentTime">当前时间戳(查询签约状态和是否支持无感支付仅代表当前时间点查询结果，不作为最后代扣结果，应在发起代扣前再次查询).</param>
        /// <param name="serialNo">支付宝业务流水号，用于记录车辆从驶入到驶出的全流程.</param>
        public AlipayEcoMycarParkingEnterinfoSyncResponseModel(string agreementScene = default(string), string agreementStatus = default(string), string carStatus = default(string), string currentTime = default(string), string serialNo = default(string))
        {
            this.AgreementScene = agreementScene;
            this.AgreementStatus = agreementStatus;
            this.CarStatus = carStatus;
            this.CurrentTime = currentTime;
            this.SerialNo = serialNo;
        }

        /// <summary>
        /// 用户签约的代扣场景字符集，多个英文逗号分割，当车场为ORC识别车牌的场景，返回值包含PLATE_PAY时，表示代扣协议可用。 当车场为ETC设备识别车牌，返回值包含ETC_PAY时表示协议可用。当用户未签约任何代扣场景时返回NO_AGREEMENT_SCENE
        /// </summary>
        /// <value>用户签约的代扣场景字符集，多个英文逗号分割，当车场为ORC识别车牌的场景，返回值包含PLATE_PAY时，表示代扣协议可用。 当车场为ETC设备识别车牌，返回值包含ETC_PAY时表示协议可用。当用户未签约任何代扣场景时返回NO_AGREEMENT_SCENE</value>
        [DataMember(Name = "agreement_scene", EmitDefaultValue = false)]
        public string AgreementScene { get; set; }

        /// <summary>
        /// 该字段已废弃,请使用agreement_scene字段
        /// </summary>
        /// <value>该字段已废弃,请使用agreement_scene字段</value>
        [DataMember(Name = "agreement_status", EmitDefaultValue = false)]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 当前车辆在支付宝侧的信息，是否可以使用无感支付，可选返回项为： NORMAL：正常缴费用户 NON-SENSE-PAY：可无感支付用户
        /// </summary>
        /// <value>当前车辆在支付宝侧的信息，是否可以使用无感支付，可选返回项为： NORMAL：正常缴费用户 NON-SENSE-PAY：可无感支付用户</value>
        [DataMember(Name = "car_status", EmitDefaultValue = false)]
        public string CarStatus { get; set; }

        /// <summary>
        /// 当前时间戳(查询签约状态和是否支持无感支付仅代表当前时间点查询结果，不作为最后代扣结果，应在发起代扣前再次查询)
        /// </summary>
        /// <value>当前时间戳(查询签约状态和是否支持无感支付仅代表当前时间点查询结果，不作为最后代扣结果，应在发起代扣前再次查询)</value>
        [DataMember(Name = "current_time", EmitDefaultValue = false)]
        public string CurrentTime { get; set; }

        /// <summary>
        /// 支付宝业务流水号，用于记录车辆从驶入到驶出的全流程
        /// </summary>
        /// <value>支付宝业务流水号，用于记录车辆从驶入到驶出的全流程</value>
        [DataMember(Name = "serial_no", EmitDefaultValue = false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingEnterinfoSyncResponseModel {\n");
            sb.Append("  AgreementScene: ").Append(AgreementScene).Append("\n");
            sb.Append("  AgreementStatus: ").Append(AgreementStatus).Append("\n");
            sb.Append("  CarStatus: ").Append(CarStatus).Append("\n");
            sb.Append("  CurrentTime: ").Append(CurrentTime).Append("\n");
            sb.Append("  SerialNo: ").Append(SerialNo).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingEnterinfoSyncResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingEnterinfoSyncResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingEnterinfoSyncResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingEnterinfoSyncResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementScene == input.AgreementScene ||
                    (this.AgreementScene != null &&
                    this.AgreementScene.Equals(input.AgreementScene))
                ) && 
                (
                    this.AgreementStatus == input.AgreementStatus ||
                    (this.AgreementStatus != null &&
                    this.AgreementStatus.Equals(input.AgreementStatus))
                ) && 
                (
                    this.CarStatus == input.CarStatus ||
                    (this.CarStatus != null &&
                    this.CarStatus.Equals(input.CarStatus))
                ) && 
                (
                    this.CurrentTime == input.CurrentTime ||
                    (this.CurrentTime != null &&
                    this.CurrentTime.Equals(input.CurrentTime))
                ) && 
                (
                    this.SerialNo == input.SerialNo ||
                    (this.SerialNo != null &&
                    this.SerialNo.Equals(input.SerialNo))
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
                if (this.AgreementScene != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementScene.GetHashCode();
                }
                if (this.AgreementStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementStatus.GetHashCode();
                }
                if (this.CarStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CarStatus.GetHashCode();
                }
                if (this.CurrentTime != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentTime.GetHashCode();
                }
                if (this.SerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.SerialNo.GetHashCode();
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
