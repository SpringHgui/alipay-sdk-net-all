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
    /// KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse
    /// </summary>
    [JsonConverter(typeof(KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponseJsonConverter))]
    [DataContract(Name = "koubei_marketing_campaign_intelligent_template_consult_default_response")]
    public partial class KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse : AbstractOpenAPISchema, IEquatable<KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse(CommonErrorType actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse" /> class
        /// with the <see cref="KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel.</param>
        public KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse(KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CommonErrorType, KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CommonErrorType`. If the actual instance is not `CommonErrorType`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CommonErrorType</returns>
        public CommonErrorType GetCommonErrorType()
        {
            return (CommonErrorType)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel`. If the actual instance is not `KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel</returns>
        public KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel GetKoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel()
        {
            return (KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse</returns>
        public static KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse FromJson(string jsonString)
        {
            KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse newKoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newKoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse;
            }

            try
            {
                newKoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse = new KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newKoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CommonErrorType: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newKoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse = new KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse(JsonConvert.DeserializeObject<KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel>(jsonString, KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newKoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into KoubeiMarketingCampaignIntelligentTemplateConsultErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse);
        }

        /// <summary>
        /// Returns true if KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return KoubeiMarketingCampaignIntelligentTemplateConsultDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
