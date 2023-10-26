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
    /// AlipayOpenMiniVersionAuditApplyRequest
    /// </summary>
    [DataContract(Name = "alipay_open_mini_version_audit_apply_request")]
    public partial class AlipayOpenMiniVersionAuditApplyRequest : IEquatable<AlipayOpenMiniVersionAuditApplyRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionAuditApplyRequest" /> class.
        /// </summary>
        /// <param name="appLogo">appLogo.</param>
        /// <param name="data">data.</param>
        /// <param name="fifthLicensePic">fifthLicensePic.</param>
        /// <param name="fifthScreenShot">fifthScreenShot.</param>
        /// <param name="firstLicensePic">firstLicensePic.</param>
        /// <param name="firstScreenShot">firstScreenShot.</param>
        /// <param name="firstSpecialLicensePic">firstSpecialLicensePic.</param>
        /// <param name="fourthLicensePic">fourthLicensePic.</param>
        /// <param name="fourthScreenShot">fourthScreenShot.</param>
        /// <param name="outDoorPic">outDoorPic.</param>
        /// <param name="secondLicensePic">secondLicensePic.</param>
        /// <param name="secondScreenShot">secondScreenShot.</param>
        /// <param name="secondSpecialLicensePic">secondSpecialLicensePic.</param>
        /// <param name="testFileName">testFileName.</param>
        /// <param name="thirdLicensePic">thirdLicensePic.</param>
        /// <param name="thirdScreenShot">thirdScreenShot.</param>
        /// <param name="thirdSpecialLicensePic">thirdSpecialLicensePic.</param>
        public AlipayOpenMiniVersionAuditApplyRequest(System.IO.Stream appLogo = default(System.IO.Stream), AlipayOpenMiniVersionAuditApplyModel data = default(AlipayOpenMiniVersionAuditApplyModel), System.IO.Stream fifthLicensePic = default(System.IO.Stream), System.IO.Stream fifthScreenShot = default(System.IO.Stream), System.IO.Stream firstLicensePic = default(System.IO.Stream), System.IO.Stream firstScreenShot = default(System.IO.Stream), System.IO.Stream firstSpecialLicensePic = default(System.IO.Stream), System.IO.Stream fourthLicensePic = default(System.IO.Stream), System.IO.Stream fourthScreenShot = default(System.IO.Stream), System.IO.Stream outDoorPic = default(System.IO.Stream), System.IO.Stream secondLicensePic = default(System.IO.Stream), System.IO.Stream secondScreenShot = default(System.IO.Stream), System.IO.Stream secondSpecialLicensePic = default(System.IO.Stream), System.IO.Stream testFileName = default(System.IO.Stream), System.IO.Stream thirdLicensePic = default(System.IO.Stream), System.IO.Stream thirdScreenShot = default(System.IO.Stream), System.IO.Stream thirdSpecialLicensePic = default(System.IO.Stream))
        {
            this.AppLogo = appLogo;
            this.Data = data;
            this.FifthLicensePic = fifthLicensePic;
            this.FifthScreenShot = fifthScreenShot;
            this.FirstLicensePic = firstLicensePic;
            this.FirstScreenShot = firstScreenShot;
            this.FirstSpecialLicensePic = firstSpecialLicensePic;
            this.FourthLicensePic = fourthLicensePic;
            this.FourthScreenShot = fourthScreenShot;
            this.OutDoorPic = outDoorPic;
            this.SecondLicensePic = secondLicensePic;
            this.SecondScreenShot = secondScreenShot;
            this.SecondSpecialLicensePic = secondSpecialLicensePic;
            this.TestFileName = testFileName;
            this.ThirdLicensePic = thirdLicensePic;
            this.ThirdScreenShot = thirdScreenShot;
            this.ThirdSpecialLicensePic = thirdSpecialLicensePic;
        }

        /// <summary>
        /// Gets or Sets AppLogo
        /// </summary>
        [DataMember(Name = "app_logo", EmitDefaultValue = false)]
        public System.IO.Stream AppLogo { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AlipayOpenMiniVersionAuditApplyModel Data { get; set; }

        /// <summary>
        /// Gets or Sets FifthLicensePic
        /// </summary>
        [DataMember(Name = "fifth_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream FifthLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets FifthScreenShot
        /// </summary>
        [DataMember(Name = "fifth_screen_shot", EmitDefaultValue = false)]
        public System.IO.Stream FifthScreenShot { get; set; }

        /// <summary>
        /// Gets or Sets FirstLicensePic
        /// </summary>
        [DataMember(Name = "first_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream FirstLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets FirstScreenShot
        /// </summary>
        [DataMember(Name = "first_screen_shot", EmitDefaultValue = false)]
        public System.IO.Stream FirstScreenShot { get; set; }

        /// <summary>
        /// Gets or Sets FirstSpecialLicensePic
        /// </summary>
        [DataMember(Name = "first_special_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream FirstSpecialLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets FourthLicensePic
        /// </summary>
        [DataMember(Name = "fourth_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream FourthLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets FourthScreenShot
        /// </summary>
        [DataMember(Name = "fourth_screen_shot", EmitDefaultValue = false)]
        public System.IO.Stream FourthScreenShot { get; set; }

        /// <summary>
        /// Gets or Sets OutDoorPic
        /// </summary>
        [DataMember(Name = "out_door_pic", EmitDefaultValue = false)]
        public System.IO.Stream OutDoorPic { get; set; }

        /// <summary>
        /// Gets or Sets SecondLicensePic
        /// </summary>
        [DataMember(Name = "second_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream SecondLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets SecondScreenShot
        /// </summary>
        [DataMember(Name = "second_screen_shot", EmitDefaultValue = false)]
        public System.IO.Stream SecondScreenShot { get; set; }

        /// <summary>
        /// Gets or Sets SecondSpecialLicensePic
        /// </summary>
        [DataMember(Name = "second_special_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream SecondSpecialLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets TestFileName
        /// </summary>
        [DataMember(Name = "test_file_name", EmitDefaultValue = false)]
        public System.IO.Stream TestFileName { get; set; }

        /// <summary>
        /// Gets or Sets ThirdLicensePic
        /// </summary>
        [DataMember(Name = "third_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream ThirdLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets ThirdScreenShot
        /// </summary>
        [DataMember(Name = "third_screen_shot", EmitDefaultValue = false)]
        public System.IO.Stream ThirdScreenShot { get; set; }

        /// <summary>
        /// Gets or Sets ThirdSpecialLicensePic
        /// </summary>
        [DataMember(Name = "third_special_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream ThirdSpecialLicensePic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniVersionAuditApplyRequest {\n");
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  FifthLicensePic: ").Append(FifthLicensePic).Append("\n");
            sb.Append("  FifthScreenShot: ").Append(FifthScreenShot).Append("\n");
            sb.Append("  FirstLicensePic: ").Append(FirstLicensePic).Append("\n");
            sb.Append("  FirstScreenShot: ").Append(FirstScreenShot).Append("\n");
            sb.Append("  FirstSpecialLicensePic: ").Append(FirstSpecialLicensePic).Append("\n");
            sb.Append("  FourthLicensePic: ").Append(FourthLicensePic).Append("\n");
            sb.Append("  FourthScreenShot: ").Append(FourthScreenShot).Append("\n");
            sb.Append("  OutDoorPic: ").Append(OutDoorPic).Append("\n");
            sb.Append("  SecondLicensePic: ").Append(SecondLicensePic).Append("\n");
            sb.Append("  SecondScreenShot: ").Append(SecondScreenShot).Append("\n");
            sb.Append("  SecondSpecialLicensePic: ").Append(SecondSpecialLicensePic).Append("\n");
            sb.Append("  TestFileName: ").Append(TestFileName).Append("\n");
            sb.Append("  ThirdLicensePic: ").Append(ThirdLicensePic).Append("\n");
            sb.Append("  ThirdScreenShot: ").Append(ThirdScreenShot).Append("\n");
            sb.Append("  ThirdSpecialLicensePic: ").Append(ThirdSpecialLicensePic).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniVersionAuditApplyRequest);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionAuditApplyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionAuditApplyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionAuditApplyRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppLogo == input.AppLogo ||
                    (this.AppLogo != null &&
                    this.AppLogo.Equals(input.AppLogo))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.FifthLicensePic == input.FifthLicensePic ||
                    (this.FifthLicensePic != null &&
                    this.FifthLicensePic.Equals(input.FifthLicensePic))
                ) && 
                (
                    this.FifthScreenShot == input.FifthScreenShot ||
                    (this.FifthScreenShot != null &&
                    this.FifthScreenShot.Equals(input.FifthScreenShot))
                ) && 
                (
                    this.FirstLicensePic == input.FirstLicensePic ||
                    (this.FirstLicensePic != null &&
                    this.FirstLicensePic.Equals(input.FirstLicensePic))
                ) && 
                (
                    this.FirstScreenShot == input.FirstScreenShot ||
                    (this.FirstScreenShot != null &&
                    this.FirstScreenShot.Equals(input.FirstScreenShot))
                ) && 
                (
                    this.FirstSpecialLicensePic == input.FirstSpecialLicensePic ||
                    (this.FirstSpecialLicensePic != null &&
                    this.FirstSpecialLicensePic.Equals(input.FirstSpecialLicensePic))
                ) && 
                (
                    this.FourthLicensePic == input.FourthLicensePic ||
                    (this.FourthLicensePic != null &&
                    this.FourthLicensePic.Equals(input.FourthLicensePic))
                ) && 
                (
                    this.FourthScreenShot == input.FourthScreenShot ||
                    (this.FourthScreenShot != null &&
                    this.FourthScreenShot.Equals(input.FourthScreenShot))
                ) && 
                (
                    this.OutDoorPic == input.OutDoorPic ||
                    (this.OutDoorPic != null &&
                    this.OutDoorPic.Equals(input.OutDoorPic))
                ) && 
                (
                    this.SecondLicensePic == input.SecondLicensePic ||
                    (this.SecondLicensePic != null &&
                    this.SecondLicensePic.Equals(input.SecondLicensePic))
                ) && 
                (
                    this.SecondScreenShot == input.SecondScreenShot ||
                    (this.SecondScreenShot != null &&
                    this.SecondScreenShot.Equals(input.SecondScreenShot))
                ) && 
                (
                    this.SecondSpecialLicensePic == input.SecondSpecialLicensePic ||
                    (this.SecondSpecialLicensePic != null &&
                    this.SecondSpecialLicensePic.Equals(input.SecondSpecialLicensePic))
                ) && 
                (
                    this.TestFileName == input.TestFileName ||
                    (this.TestFileName != null &&
                    this.TestFileName.Equals(input.TestFileName))
                ) && 
                (
                    this.ThirdLicensePic == input.ThirdLicensePic ||
                    (this.ThirdLicensePic != null &&
                    this.ThirdLicensePic.Equals(input.ThirdLicensePic))
                ) && 
                (
                    this.ThirdScreenShot == input.ThirdScreenShot ||
                    (this.ThirdScreenShot != null &&
                    this.ThirdScreenShot.Equals(input.ThirdScreenShot))
                ) && 
                (
                    this.ThirdSpecialLicensePic == input.ThirdSpecialLicensePic ||
                    (this.ThirdSpecialLicensePic != null &&
                    this.ThirdSpecialLicensePic.Equals(input.ThirdSpecialLicensePic))
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
                if (this.AppLogo != null)
                {
                    hashCode = (hashCode * 59) + this.AppLogo.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.FifthLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.FifthLicensePic.GetHashCode();
                }
                if (this.FifthScreenShot != null)
                {
                    hashCode = (hashCode * 59) + this.FifthScreenShot.GetHashCode();
                }
                if (this.FirstLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.FirstLicensePic.GetHashCode();
                }
                if (this.FirstScreenShot != null)
                {
                    hashCode = (hashCode * 59) + this.FirstScreenShot.GetHashCode();
                }
                if (this.FirstSpecialLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.FirstSpecialLicensePic.GetHashCode();
                }
                if (this.FourthLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.FourthLicensePic.GetHashCode();
                }
                if (this.FourthScreenShot != null)
                {
                    hashCode = (hashCode * 59) + this.FourthScreenShot.GetHashCode();
                }
                if (this.OutDoorPic != null)
                {
                    hashCode = (hashCode * 59) + this.OutDoorPic.GetHashCode();
                }
                if (this.SecondLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.SecondLicensePic.GetHashCode();
                }
                if (this.SecondScreenShot != null)
                {
                    hashCode = (hashCode * 59) + this.SecondScreenShot.GetHashCode();
                }
                if (this.SecondSpecialLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.SecondSpecialLicensePic.GetHashCode();
                }
                if (this.TestFileName != null)
                {
                    hashCode = (hashCode * 59) + this.TestFileName.GetHashCode();
                }
                if (this.ThirdLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdLicensePic.GetHashCode();
                }
                if (this.ThirdScreenShot != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdScreenShot.GetHashCode();
                }
                if (this.ThirdSpecialLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdSpecialLicensePic.GetHashCode();
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
