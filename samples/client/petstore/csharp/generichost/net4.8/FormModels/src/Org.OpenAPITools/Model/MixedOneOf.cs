// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MixedOneOf
    /// </summary>
    public partial class MixedOneOf : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedOneOf" /> class.
        /// </summary>
        /// <param name="content">content</param>
        [JsonConstructor]
        public MixedOneOf(Option<MixedOneOfContent> content = default)
        {
            ContentOption = content;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Content
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<MixedOneOfContent> ContentOption { get; private set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [JsonPropertyName("content")]
        public MixedOneOfContent Content { get { return this.ContentOption; } set { this.ContentOption = new Option<MixedOneOfContent>(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MixedOneOf {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MixedOneOf" />
    /// </summary>
    public class MixedOneOfJsonConverter : JsonConverter<MixedOneOf>
    {
        /// <summary>
        /// Deserializes json to <see cref="MixedOneOf" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MixedOneOf Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<MixedOneOfContent> content = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "content":
                            content = new Option<MixedOneOfContent>(JsonSerializer.Deserialize<MixedOneOfContent>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        default:
                            break;
                    }
                }
            }

            if (content.IsSet && content.Value == null)
                throw new ArgumentNullException(nameof(content), "Property is not nullable for class MixedOneOf.");

            return new MixedOneOf(content);
        }

        /// <summary>
        /// Serializes a <see cref="MixedOneOf" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedOneOf"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MixedOneOf mixedOneOf, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, mixedOneOf, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MixedOneOf" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedOneOf"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, MixedOneOf mixedOneOf, JsonSerializerOptions jsonSerializerOptions)
        {
            if (mixedOneOf.ContentOption.IsSet && mixedOneOf.Content == null)
                throw new ArgumentNullException(nameof(mixedOneOf.Content), "Property is required for class MixedOneOf.");

            if (mixedOneOf.ContentOption.IsSet)
            {
                writer.WritePropertyName("content");
                JsonSerializer.Serialize(writer, mixedOneOf.Content, jsonSerializerOptions);
            }
        }
    }
}
