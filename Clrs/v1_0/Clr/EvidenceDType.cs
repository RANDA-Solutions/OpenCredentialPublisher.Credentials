/*
 * Comprehensive Learner Record Service OpenAPI (YAML) Definition
 *
 * The Comprehensive Learner Record Service enables the exchange of data about users and their achievements between a Comprehensive Learner Record Service Provider and the consumers of the associated data. This service has been described using the IMS Model Driven Specification development approach, this being the Platform Specific Model (PSM) of the service.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: lmattson@imsglobal.org
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    /// <summary>
    /// One or more artifacts that represent supporting evidence for the record. Examples include text, media, websites, etc. 
    /// </summary>
    [NotMapped]
    public class EvidenceDType
    {
        /// <summary>
        /// The URI of a webpage presenting evidence of achievement. Model Primitive Datatype = AnyURI.
        /// </summary>
        /// <value>The URI of a webpage presenting evidence of achievement. Model Primitive Datatype = AnyURI.</value>
        [JsonPropertyName("id"), Newtonsoft.Json.JsonProperty("id")]
        [Description("The URI of a webpage presenting evidence of achievement. Model Primitive Datatype = AnyURI.")]
        public string Id { get; set; }

        /// <summary>
        /// The JSON-LD type of this entity. Normally 'Evidence'. Model Primitive Datatype = NormalizedString.
        /// </summary>
        /// <value>The JSON-LD type of this entity. Normally 'Evidence'. Model Primitive Datatype = NormalizedString.</value>
        [JsonPropertyName("type"), Newtonsoft.Json.JsonProperty("type")]
        [Description("The JSON-LD type of this entity. Normally 'Evidence'. Model Primitive Datatype = NormalizedString.")]
        public string Type { get; set; }

        /// <summary>
        /// Artifacts that are part of the evidence. 
        /// </summary>
        /// <value>Artifacts that are part of the evidence. </value>
        [JsonPropertyName("artifacts"), Newtonsoft.Json.JsonProperty("artifacts")]
        [Description("Artifacts that are part of the evidence. ")]
        public virtual List<ArtifactDType> Artifacts { get; set; }

        /// <summary>
        /// A description of the intended audience for a piece of evidence. Model Primitive Datatype = String.
        /// </summary>
        /// <value>A description of the intended audience for a piece of evidence. Model Primitive Datatype = String.</value>
        [JsonPropertyName("audience"), Newtonsoft.Json.JsonProperty("audience")]
        [Description("A description of the intended audience for a piece of evidence. Model Primitive Datatype = String.")]
        public string Audience { get; set; }

        /// <summary>
        /// A longer description of the evidence. Model Primitive Datatype = String.
        /// </summary>
        /// <value>A longer description of the evidence. Model Primitive Datatype = String.</value>
        [JsonPropertyName("description"), Newtonsoft.Json.JsonProperty("description")]
        [Description("A longer description of the evidence. Model Primitive Datatype = String.")]
        public string Description { get; set; }

        /// <summary>
        /// A string that describes the type of evidence. For example, Poetry, Prose, Film. Model Primitive Datatype = String.
        /// </summary>
        /// <value>A string that describes the type of evidence. For example, Poetry, Prose, Film. Model Primitive Datatype = String.</value>
        [JsonPropertyName("genre"), Newtonsoft.Json.JsonProperty("genre")]
        [Description("A string that describes the type of evidence. For example, Poetry, Prose, Film. Model Primitive Datatype = String.")]
        public string Genre { get; set; }

        /// <summary>
        /// The name of the evidence. Model Primitive Datatype = String.
        /// </summary>
        /// <value>The name of the evidence. Model Primitive Datatype = String.</value>
        [Required]
        [JsonPropertyName("name"), Newtonsoft.Json.JsonProperty("name")]
        [Description("The name of the evidence. Model Primitive Datatype = String.")]
        public string Name { get; set; }

        /// <summary>
        /// A narrative that describes the evidence and process of achievement that led to an assertion. Markdown allowed. Model Primitive Datatype = String.
        /// </summary>
        /// <value>A narrative that describes the evidence and process of achievement that led to an assertion. Markdown allowed. Model Primitive Datatype = String.</value>
        [JsonPropertyName("narrative"), Newtonsoft.Json.JsonProperty("narrative")]
        [Description("A narrative that describes the evidence and process of achievement that led to an assertion. Markdown allowed. Model Primitive Datatype = String.")]
        public string Narrative { get; set; }

        /// <summary>
        /// Additional properties of the object
        /// </summary>
        [JsonExtensionData]
        [JsonPropertyName("additionalProperties"), Newtonsoft.Json.JsonProperty("additionalProperties")]
        public Dictionary<String, Object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this, Credentials.Extensions.TWJson.IgnoreNulls);
        }
    }
}