/*
 * Comprehensive Learner Record Service OpenAPI (YAML) Definition
 *
 * The Comprehensive Learner Record Service enables the exchange of data about users and their achievements between a Comprehensive Learner Record Service Provider and the consumers of the associated data. This service has been described using the IMS Model Driven Specification development approach, this being the Platform Specific Model (PSM) of the service.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: lmattson@imsglobal.org
 * Generated by: https://openapi-generator.tech
 */

using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OpenCredentialPublisher.Credentials.Clrs.v1_0.Clr
{
    /// <summary>
    /// A set of CLRs. 
    /// </summary>
    [NotMapped]
    public partial class ClrSetDType
    { 
        /// <summary>
        /// URL to the JSON-LD context file.
        /// </summary>
        /// <value>URL to the JSON-LD context file.</value>
        [JsonPropertyName("@context"), Newtonsoft.Json.JsonProperty("@context")]
        [Description("URL to the JSON-LD context file.")]
        public string Context { get; set; }
        
        /// <summary>
        /// Unique IRI for the ClrSet. Model Primitive Datatype = NormalizedString.
        /// </summary>
        /// <value>Unique IRI for the ClrSet. Model Primitive Datatype = NormalizedString.</value>
        [JsonPropertyName("id"), Newtonsoft.Json.JsonProperty("id")]
        [Description("Unique IRI for the ClrSet. Model Primitive Datatype = NormalizedString.")]
        public string Id { get; set; }
        
        /// <summary>
        /// The JSON-LD type of this object. Normally 'CLRSet'. Model Primitive Datatype = NormalizedString.
        /// </summary>
        /// <value>The JSON-LD type of this object. Normally 'CLRSet'. Model Primitive Datatype = NormalizedString.</value>
        [JsonPropertyName("type"), Newtonsoft.Json.JsonProperty("type")]
        [Description("The JSON-LD type of this object. Normally 'CLRSet'. Model Primitive Datatype = NormalizedString.")]
        public string Type { get; set; }
        
        /// <summary>
        /// A set of Clrs 
        /// </summary>
        /// <value>A set of Clrs </value>
        [JsonPropertyName("clrs"), Newtonsoft.Json.JsonProperty("clrs")]
        [Description("A set of Clrs ")]
        public List<ClrDType> Clrs { get; set; }

        /// <summary>
        /// A set of Clrs in JWS Compact Serialization format. Model Primitive Datatype = String. 
        /// </summary>
        /// <value>A set of Clrs in JWS Compact Serialization format. Model Primitive Datatype = String. </value>
        [JsonPropertyName("signedClrs"), Newtonsoft.Json.JsonProperty("signedClrs")]
        [Description("A set of Clrs in JWS Compact Serialization format. Model Primitive Datatype = String. ")]
        public List<string> SignedClrs { get; set; }
        
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