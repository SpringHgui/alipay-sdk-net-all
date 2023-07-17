/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
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
    /// FaceMachineInfo
    /// </summary>
    [DataContract(Name = "FaceMachineInfo")]
    public partial class FaceMachineInfo : IEquatable<FaceMachineInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceMachineInfo" /> class.
        /// </summary>
        /// <param name="cameraDriveVer">摄像头驱动版本号.</param>
        /// <param name="cameraModel">摄像头型号.</param>
        /// <param name="cameraName">摄像头名称.</param>
        /// <param name="cameraVer">摄像头版本号.</param>
        /// <param name="ext">扩展信息.</param>
        /// <param name="machineCode">机具编码.</param>
        /// <param name="machineModel">机具型号.</param>
        /// <param name="machineVer">机具版本号.</param>
        public FaceMachineInfo(string cameraDriveVer = default(string), string cameraModel = default(string), string cameraName = default(string), string cameraVer = default(string), string ext = default(string), string machineCode = default(string), string machineModel = default(string), string machineVer = default(string))
        {
            this.CameraDriveVer = cameraDriveVer;
            this.CameraModel = cameraModel;
            this.CameraName = cameraName;
            this.CameraVer = cameraVer;
            this.Ext = ext;
            this.MachineCode = machineCode;
            this.MachineModel = machineModel;
            this.MachineVer = machineVer;
        }

        /// <summary>
        /// 摄像头驱动版本号
        /// </summary>
        /// <value>摄像头驱动版本号</value>
        [DataMember(Name = "camera_drive_ver", EmitDefaultValue = false)]
        public string CameraDriveVer { get; set; }

        /// <summary>
        /// 摄像头型号
        /// </summary>
        /// <value>摄像头型号</value>
        [DataMember(Name = "camera_model", EmitDefaultValue = false)]
        public string CameraModel { get; set; }

        /// <summary>
        /// 摄像头名称
        /// </summary>
        /// <value>摄像头名称</value>
        [DataMember(Name = "camera_name", EmitDefaultValue = false)]
        public string CameraName { get; set; }

        /// <summary>
        /// 摄像头版本号
        /// </summary>
        /// <value>摄像头版本号</value>
        [DataMember(Name = "camera_ver", EmitDefaultValue = false)]
        public string CameraVer { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        /// <value>扩展信息</value>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public string Ext { get; set; }

        /// <summary>
        /// 机具编码
        /// </summary>
        /// <value>机具编码</value>
        [DataMember(Name = "machine_code", EmitDefaultValue = false)]
        public string MachineCode { get; set; }

        /// <summary>
        /// 机具型号
        /// </summary>
        /// <value>机具型号</value>
        [DataMember(Name = "machine_model", EmitDefaultValue = false)]
        public string MachineModel { get; set; }

        /// <summary>
        /// 机具版本号
        /// </summary>
        /// <value>机具版本号</value>
        [DataMember(Name = "machine_ver", EmitDefaultValue = false)]
        public string MachineVer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FaceMachineInfo {\n");
            sb.Append("  CameraDriveVer: ").Append(CameraDriveVer).Append("\n");
            sb.Append("  CameraModel: ").Append(CameraModel).Append("\n");
            sb.Append("  CameraName: ").Append(CameraName).Append("\n");
            sb.Append("  CameraVer: ").Append(CameraVer).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  MachineCode: ").Append(MachineCode).Append("\n");
            sb.Append("  MachineModel: ").Append(MachineModel).Append("\n");
            sb.Append("  MachineVer: ").Append(MachineVer).Append("\n");
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
            return this.Equals(input as FaceMachineInfo);
        }

        /// <summary>
        /// Returns true if FaceMachineInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FaceMachineInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaceMachineInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CameraDriveVer == input.CameraDriveVer ||
                    (this.CameraDriveVer != null &&
                    this.CameraDriveVer.Equals(input.CameraDriveVer))
                ) && 
                (
                    this.CameraModel == input.CameraModel ||
                    (this.CameraModel != null &&
                    this.CameraModel.Equals(input.CameraModel))
                ) && 
                (
                    this.CameraName == input.CameraName ||
                    (this.CameraName != null &&
                    this.CameraName.Equals(input.CameraName))
                ) && 
                (
                    this.CameraVer == input.CameraVer ||
                    (this.CameraVer != null &&
                    this.CameraVer.Equals(input.CameraVer))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
                ) && 
                (
                    this.MachineCode == input.MachineCode ||
                    (this.MachineCode != null &&
                    this.MachineCode.Equals(input.MachineCode))
                ) && 
                (
                    this.MachineModel == input.MachineModel ||
                    (this.MachineModel != null &&
                    this.MachineModel.Equals(input.MachineModel))
                ) && 
                (
                    this.MachineVer == input.MachineVer ||
                    (this.MachineVer != null &&
                    this.MachineVer.Equals(input.MachineVer))
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
                if (this.CameraDriveVer != null)
                {
                    hashCode = (hashCode * 59) + this.CameraDriveVer.GetHashCode();
                }
                if (this.CameraModel != null)
                {
                    hashCode = (hashCode * 59) + this.CameraModel.GetHashCode();
                }
                if (this.CameraName != null)
                {
                    hashCode = (hashCode * 59) + this.CameraName.GetHashCode();
                }
                if (this.CameraVer != null)
                {
                    hashCode = (hashCode * 59) + this.CameraVer.GetHashCode();
                }
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                }
                if (this.MachineCode != null)
                {
                    hashCode = (hashCode * 59) + this.MachineCode.GetHashCode();
                }
                if (this.MachineModel != null)
                {
                    hashCode = (hashCode * 59) + this.MachineModel.GetHashCode();
                }
                if (this.MachineVer != null)
                {
                    hashCode = (hashCode * 59) + this.MachineVer.GetHashCode();
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
