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
    /// AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse
    /// </summary>
    [JsonConverter(typeof(AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponseJsonConverter))]
    [DataContract(Name = "alipay_open_mini_innerversion_uploadstatus_query_default_response")]
    public partial class AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse : AbstractOpenAPISchema, IEquatable<AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse" /> class
        /// with the <see cref="AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel.</param>
        public AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse(AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse(CommonErrorType actualInstance)
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
                if (value.GetType() == typeof(AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel, CommonErrorType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel`. If the actual instance is not `AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel</returns>
        public AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel GetAlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel()
        {
            return (AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel)this.ActualInstance;
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
            sb.Append("class AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse</returns>
        public static AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse FromJson(string jsonString)
        {
            AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse newAlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse;
            }

            try
            {
                newAlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse = new AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse(JsonConvert.DeserializeObject<AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel>(jsonString, AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AlipayOpenMiniInnerversionUploadstatusQueryErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse = new AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse;
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
            return this.Equals(input as AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse input)
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
    /// Custom JSON converter for AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse
    /// </summary>
    public class AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return AlipayOpenMiniInnerversionUploadstatusQueryDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
