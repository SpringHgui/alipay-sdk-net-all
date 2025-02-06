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
    /// AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse
    /// </summary>
    [JsonConverter(typeof(AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponseJsonConverter))]
    [DataContract(Name = "alipay_open_mini_innerversion_modelforoffline_query_default_response")]
    public partial class AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse : AbstractOpenAPISchema, IEquatable<AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse" /> class
        /// with the <see cref="AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel.</param>
        public AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse(AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse(CommonErrorType actualInstance)
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
                if (value.GetType() == typeof(AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel, CommonErrorType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel`. If the actual instance is not `AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel</returns>
        public AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel GetAlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel()
        {
            return (AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel)this.ActualInstance;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse</returns>
        public static AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse FromJson(string jsonString)
        {
            AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse newAlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse;
            }

            try
            {
                newAlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse = new AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse(JsonConvert.DeserializeObject<AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel>(jsonString, AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AlipayOpenMiniInnerversionModelforofflineQueryErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse = new AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CommonErrorType: {1}", jsonString, exception.ToString()));
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
            return this.Equals(input as AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse input)
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
    /// Custom JSON converter for AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse
    /// </summary>
    public class AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return AlipayOpenMiniInnerversionModelforofflineQueryDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
