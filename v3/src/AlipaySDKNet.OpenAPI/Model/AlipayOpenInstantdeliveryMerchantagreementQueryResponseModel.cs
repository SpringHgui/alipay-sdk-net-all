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
    /// AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel")]
    public partial class AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel : IEquatable<AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agreementDetail">agreementDetail.</param>
        public AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel(AgreementDetail agreementDetail = default(AgreementDetail))
        {
            this.AgreementDetail = agreementDetail;
        }

        /// <summary>
        /// Gets or Sets AgreementDetail
        /// </summary>
        [DataMember(Name = "agreement_detail", EmitDefaultValue = false)]
        public AgreementDetail AgreementDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel {\n");
            sb.Append("  AgreementDetail: ").Append(AgreementDetail).Append("\n");
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
            return this.Equals(input as AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInstantdeliveryMerchantagreementQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementDetail == input.AgreementDetail ||
                    (this.AgreementDetail != null &&
                    this.AgreementDetail.Equals(input.AgreementDetail))
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
                if (this.AgreementDetail != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementDetail.GetHashCode();
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
