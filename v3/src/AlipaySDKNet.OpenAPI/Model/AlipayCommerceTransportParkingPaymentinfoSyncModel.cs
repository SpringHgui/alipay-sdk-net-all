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
    /// AlipayCommerceTransportParkingPaymentinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceTransportParkingPaymentinfoSyncModel")]
    public partial class AlipayCommerceTransportParkingPaymentinfoSyncModel : IEquatable<AlipayCommerceTransportParkingPaymentinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceTransportParkingPaymentinfoSyncModel" /> class.
        /// </summary>
        /// <param name="freeExitMinutes">停车场内缴费后，允许出场的免费时长分钟数.</param>
        /// <param name="isEncryptPlateNo">车牌是否加密，true为加密，false为不加密，默认为false.</param>
        /// <param name="openAppid">蚂蚁会员统一ID对应的归属应用appid.</param>
        /// <param name="openId">蚂蚁会员统一ID.</param>
        /// <param name="outSerialNo">外部停车流水号(用于串通进场与出场信息).</param>
        /// <param name="paymentTime">场内缴费时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，场内缴费不应晚于当前网络时间.</param>
        /// <param name="paymentType">支付方式 ALIPAY：支付宝支付 CASH：现金 OTHER：其他渠道 FREE：免费.</param>
        /// <param name="plateColor">车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。.</param>
        /// <param name="plateNo">车牌号（支持加密格式）.</param>
        /// <param name="serviceUrl">停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex.</param>
        public AlipayCommerceTransportParkingPaymentinfoSyncModel(string freeExitMinutes = default(string), bool isEncryptPlateNo = default(bool), string openAppid = default(string), string openId = default(string), string outSerialNo = default(string), string paymentTime = default(string), string paymentType = default(string), string plateColor = default(string), string plateNo = default(string), string serviceUrl = default(string))
        {
            this.FreeExitMinutes = freeExitMinutes;
            this.IsEncryptPlateNo = isEncryptPlateNo;
            this.OpenAppid = openAppid;
            this.OpenId = openId;
            this.OutSerialNo = outSerialNo;
            this.PaymentTime = paymentTime;
            this.PaymentType = paymentType;
            this.PlateColor = plateColor;
            this.PlateNo = plateNo;
            this.ServiceUrl = serviceUrl;
        }

        /// <summary>
        /// 停车场内缴费后，允许出场的免费时长分钟数
        /// </summary>
        /// <value>停车场内缴费后，允许出场的免费时长分钟数</value>
        [DataMember(Name = "free_exit_minutes", EmitDefaultValue = false)]
        public string FreeExitMinutes { get; set; }

        /// <summary>
        /// 车牌是否加密，true为加密，false为不加密，默认为false
        /// </summary>
        /// <value>车牌是否加密，true为加密，false为不加密，默认为false</value>
        [DataMember(Name = "is_encrypt_plate_no", EmitDefaultValue = true)]
        public bool IsEncryptPlateNo { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID对应的归属应用appid
        /// </summary>
        /// <value>蚂蚁会员统一ID对应的归属应用appid</value>
        [DataMember(Name = "open_appid", EmitDefaultValue = false)]
        public string OpenAppid { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        /// <value>蚂蚁会员统一ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        /// <value>外部停车流水号(用于串通进场与出场信息)</value>
        [DataMember(Name = "out_serial_no", EmitDefaultValue = false)]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 场内缴费时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，场内缴费不应晚于当前网络时间
        /// </summary>
        /// <value>场内缴费时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，场内缴费不应晚于当前网络时间</value>
        [DataMember(Name = "payment_time", EmitDefaultValue = false)]
        public string PaymentTime { get; set; }

        /// <summary>
        /// 支付方式 ALIPAY：支付宝支付 CASH：现金 OTHER：其他渠道 FREE：免费
        /// </summary>
        /// <value>支付方式 ALIPAY：支付宝支付 CASH：现金 OTHER：其他渠道 FREE：免费</value>
        [DataMember(Name = "payment_type", EmitDefaultValue = false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        /// <value>车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。</value>
        [DataMember(Name = "plate_color", EmitDefaultValue = false)]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号（支持加密格式）
        /// </summary>
        /// <value>车牌号（支持加密格式）</value>
        [DataMember(Name = "plate_no", EmitDefaultValue = false)]
        public string PlateNo { get; set; }

        /// <summary>
        /// 停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex
        /// </summary>
        /// <value>停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F 2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex 3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex</value>
        [DataMember(Name = "service_url", EmitDefaultValue = false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceTransportParkingPaymentinfoSyncModel {\n");
            sb.Append("  FreeExitMinutes: ").Append(FreeExitMinutes).Append("\n");
            sb.Append("  IsEncryptPlateNo: ").Append(IsEncryptPlateNo).Append("\n");
            sb.Append("  OpenAppid: ").Append(OpenAppid).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutSerialNo: ").Append(OutSerialNo).Append("\n");
            sb.Append("  PaymentTime: ").Append(PaymentTime).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  PlateColor: ").Append(PlateColor).Append("\n");
            sb.Append("  PlateNo: ").Append(PlateNo).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
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
            return this.Equals(input as AlipayCommerceTransportParkingPaymentinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceTransportParkingPaymentinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceTransportParkingPaymentinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceTransportParkingPaymentinfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FreeExitMinutes == input.FreeExitMinutes ||
                    (this.FreeExitMinutes != null &&
                    this.FreeExitMinutes.Equals(input.FreeExitMinutes))
                ) && 
                (
                    this.IsEncryptPlateNo == input.IsEncryptPlateNo ||
                    this.IsEncryptPlateNo.Equals(input.IsEncryptPlateNo)
                ) && 
                (
                    this.OpenAppid == input.OpenAppid ||
                    (this.OpenAppid != null &&
                    this.OpenAppid.Equals(input.OpenAppid))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutSerialNo == input.OutSerialNo ||
                    (this.OutSerialNo != null &&
                    this.OutSerialNo.Equals(input.OutSerialNo))
                ) && 
                (
                    this.PaymentTime == input.PaymentTime ||
                    (this.PaymentTime != null &&
                    this.PaymentTime.Equals(input.PaymentTime))
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    (this.PaymentType != null &&
                    this.PaymentType.Equals(input.PaymentType))
                ) && 
                (
                    this.PlateColor == input.PlateColor ||
                    (this.PlateColor != null &&
                    this.PlateColor.Equals(input.PlateColor))
                ) && 
                (
                    this.PlateNo == input.PlateNo ||
                    (this.PlateNo != null &&
                    this.PlateNo.Equals(input.PlateNo))
                ) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
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
                if (this.FreeExitMinutes != null)
                {
                    hashCode = (hashCode * 59) + this.FreeExitMinutes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEncryptPlateNo.GetHashCode();
                if (this.OpenAppid != null)
                {
                    hashCode = (hashCode * 59) + this.OpenAppid.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutSerialNo.GetHashCode();
                }
                if (this.PaymentTime != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentTime.GetHashCode();
                }
                if (this.PaymentType != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentType.GetHashCode();
                }
                if (this.PlateColor != null)
                {
                    hashCode = (hashCode * 59) + this.PlateColor.GetHashCode();
                }
                if (this.PlateNo != null)
                {
                    hashCode = (hashCode * 59) + this.PlateNo.GetHashCode();
                }
                if (this.ServiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceUrl.GetHashCode();
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
