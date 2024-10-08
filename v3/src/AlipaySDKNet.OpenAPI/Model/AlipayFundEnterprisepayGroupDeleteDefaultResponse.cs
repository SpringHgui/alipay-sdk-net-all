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
    /// AlipayFundEnterprisepayGroupDeleteDefaultResponse
    /// </summary>
    [JsonConverter(typeof(AlipayFundEnterprisepayGroupDeleteDefaultResponseJsonConverter))]
    [DataContract(Name = "alipay_fund_enterprisepay_group_delete_default_response")]
    public partial class AlipayFundEnterprisepayGroupDeleteDefaultResponse : AbstractOpenAPISchema, IEquatable<AlipayFundEnterprisepayGroupDeleteDefaultResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupDeleteDefaultResponse" /> class
        /// with the <see cref="AlipayFundEnterprisepayGroupDeleteErrorResponseModel" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AlipayFundEnterprisepayGroupDeleteErrorResponseModel.</param>
        public AlipayFundEnterprisepayGroupDeleteDefaultResponse(AlipayFundEnterprisepayGroupDeleteErrorResponseModel actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayGroupDeleteDefaultResponse" /> class
        /// with the <see cref="CommonErrorType" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CommonErrorType.</param>
        public AlipayFundEnterprisepayGroupDeleteDefaultResponse(CommonErrorType actualInstance)
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
                if (value.GetType() == typeof(AlipayFundEnterprisepayGroupDeleteErrorResponseModel))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CommonErrorType))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AlipayFundEnterprisepayGroupDeleteErrorResponseModel, CommonErrorType");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `AlipayFundEnterprisepayGroupDeleteErrorResponseModel`. If the actual instance is not `AlipayFundEnterprisepayGroupDeleteErrorResponseModel`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AlipayFundEnterprisepayGroupDeleteErrorResponseModel</returns>
        public AlipayFundEnterprisepayGroupDeleteErrorResponseModel GetAlipayFundEnterprisepayGroupDeleteErrorResponseModel()
        {
            return (AlipayFundEnterprisepayGroupDeleteErrorResponseModel)this.ActualInstance;
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
            sb.Append("class AlipayFundEnterprisepayGroupDeleteDefaultResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, AlipayFundEnterprisepayGroupDeleteDefaultResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of AlipayFundEnterprisepayGroupDeleteDefaultResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of AlipayFundEnterprisepayGroupDeleteDefaultResponse</returns>
        public static AlipayFundEnterprisepayGroupDeleteDefaultResponse FromJson(string jsonString)
        {
            AlipayFundEnterprisepayGroupDeleteDefaultResponse newAlipayFundEnterprisepayGroupDeleteDefaultResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newAlipayFundEnterprisepayGroupDeleteDefaultResponse;
            }

            try
            {
                newAlipayFundEnterprisepayGroupDeleteDefaultResponse = new AlipayFundEnterprisepayGroupDeleteDefaultResponse(JsonConvert.DeserializeObject<AlipayFundEnterprisepayGroupDeleteErrorResponseModel>(jsonString, AlipayFundEnterprisepayGroupDeleteDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayFundEnterprisepayGroupDeleteDefaultResponse;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AlipayFundEnterprisepayGroupDeleteErrorResponseModel: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newAlipayFundEnterprisepayGroupDeleteDefaultResponse = new AlipayFundEnterprisepayGroupDeleteDefaultResponse(JsonConvert.DeserializeObject<CommonErrorType>(jsonString, AlipayFundEnterprisepayGroupDeleteDefaultResponse.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newAlipayFundEnterprisepayGroupDeleteDefaultResponse;
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
            return this.Equals(input as AlipayFundEnterprisepayGroupDeleteDefaultResponse);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepayGroupDeleteDefaultResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepayGroupDeleteDefaultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepayGroupDeleteDefaultResponse input)
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
    /// Custom JSON converter for AlipayFundEnterprisepayGroupDeleteDefaultResponse
    /// </summary>
    public class AlipayFundEnterprisepayGroupDeleteDefaultResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(AlipayFundEnterprisepayGroupDeleteDefaultResponse).GetMethod("ToJson").Invoke(value, null)));
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
                return AlipayFundEnterprisepayGroupDeleteDefaultResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
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
