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
    /// AlipayOpenMiniInnerbaseinfoApplogoUploadRequest
    /// </summary>
    [DataContract(Name = "alipay_open_mini_innerbaseinfo_applogo_upload_request")]
    public partial class AlipayOpenMiniInnerbaseinfoApplogoUploadRequest : IEquatable<AlipayOpenMiniInnerbaseinfoApplogoUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerbaseinfoApplogoUploadRequest" /> class.
        /// </summary>
        /// <param name="appLogo">appLogo.</param>
        public AlipayOpenMiniInnerbaseinfoApplogoUploadRequest(System.IO.Stream appLogo = default(System.IO.Stream))
        {
            this.AppLogo = appLogo;
        }

        /// <summary>
        /// Gets or Sets AppLogo
        /// </summary>
        [DataMember(Name = "app_logo", EmitDefaultValue = false)]
        public System.IO.Stream AppLogo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerbaseinfoApplogoUploadRequest {\n");
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerbaseinfoApplogoUploadRequest);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerbaseinfoApplogoUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerbaseinfoApplogoUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerbaseinfoApplogoUploadRequest input)
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
