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
    /// A Profile is a collection of information that describes the person or organization using Comprehensive Learner Record (CLR). Publishers, learners, and issuers must be represented as profiles. Recipients, endorsers, or other entities may also be represented using this vocabulary. 
    /// </summary>
    [NotMapped]
    public class ProfileDType : ICommonProfileDType
    { 
        /// <summary>
        /// Unique IRI for the Learner, Publisher, and Issuer Profile document. The Assertion Recipient is identified by reference to the Learner's Profile via the id, email, url, telephone, sourcedId, or studentId property. Model Primitive Datatype = NormalizedString.
        /// </summary>
        /// <value>Unique IRI for the Learner, Publisher, and Issuer Profile document. The Assertion Recipient is identified by reference to the Learner's Profile via the id, email, url, telephone, sourcedId, or studentId property. Model Primitive Datatype = NormalizedString.</value>
        [Required]
        [JsonPropertyName("id"), Newtonsoft.Json.JsonProperty("id")]
        [Description("Unique IRI for the Learner, Publisher, and Issuer Profile document. The Assertion Recipient is identified by reference to the Learner's Profile via the id, email, url, telephone, sourcedId, or studentId property. Model Primitive Datatype = NormalizedString.")]
        public string Id { get; set; }
        
        /// <summary>
        /// The JSON-LD type of this object. Normally 'Profile'. Model Primitive Datatype = NormalizedString.
        /// </summary>
        /// <value>The JSON-LD type of this object. Normally 'Profile'. Model Primitive Datatype = NormalizedString.</value>
        [JsonPropertyName("type"), Newtonsoft.Json.JsonProperty("type")]
        [Description("The JSON-LD type of this object. Normally 'Profile'. Model Primitive Datatype = NormalizedString.")]
        public string Type { get; set; }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [JsonPropertyName("address"), Newtonsoft.Json.JsonProperty("address")]
        [Description("Address")]
        public virtual AddressDType Address { get; set; }

        [JsonPropertyName("additionalName"), Newtonsoft.Json.JsonProperty("additionalName")]
        [Description("An additional name for a person, can be used for a middle name. Model Primitive Datatype = String.")]
        public string AdditionalName { get; set; }

        [JsonPropertyName("birthDate"), Newtonsoft.Json.JsonProperty("birthDate")]
        [Description("Birthdate of the person. Model Primitive Datatype = Date.")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// A short description of the individual or organization. Model Primitive Datatype = String.
        /// </summary>
        /// <value>A short description of the individual or organization. Model Primitive Datatype = String.</value>
        [JsonPropertyName("description"), Newtonsoft.Json.JsonProperty("description")]
        [Description("A short description of the individual or organization. Model Primitive Datatype = String.")]
        public string Description { get; set; }
        
        /// <summary>
        /// A contact email address for the individual or organization. Model Primitive Datatype = String.
        /// </summary>
        /// <value>A contact email address for the individual or organization. Model Primitive Datatype = String.</value>
        [JsonPropertyName("email"), Newtonsoft.Json.JsonProperty("email")]
        [Description("A contact email address for the individual or organization. Model Primitive Datatype = String.")]
        public string Email { get; set; }
        
        /// <summary>
        /// Allows endorsers to make specific claims about the individual or organization represented by this profile. 
        /// </summary>
        /// <value>Allows endorsers to make specific claims about the individual or organization represented by this profile. </value>
        [JsonPropertyName("endorsements"), Newtonsoft.Json.JsonProperty("endorsements")]
        [Description("Allows endorsers to make specific claims about the individual or organization represented by this profile. ")]
        public virtual List<EndorsementDType> Endorsements { get; set; }

        [JsonPropertyName("familyName"), Newtonsoft.Json.JsonProperty("familyName")]
        [Description("Family name of a person. In the U.S., the last name of a person. Model Primitive Datatype = String.")]
        public string FamilyName { get; set; }

        [JsonPropertyName("givenName"), Newtonsoft.Json.JsonProperty("givenName")]
        [Description("Given name of a person. In the U.S., the first name of a person. Model Primitive Datatype = String.")]
        public string GivenName { get; set; }

        [JsonPropertyName("identifiers"), Newtonsoft.Json.JsonProperty("identifiers")]
        [Description("A set of System Identifiers that represent other identifiers for this Profile.")]
        public List<SystemIdentifierDType> Identifiers { get; set; }

        /// <summary>
        /// IRI of an image representing the individual or organization. May be a DATA URI or the URL where the image may be found. Model Primitive Datatype = NormalizedString.
        /// </summary>
        /// <value>IRI of an image representing the individual or organization. May be a DATA URI or the URL where the image may be found. Model Primitive Datatype = NormalizedString.</value>
        [JsonPropertyName("image"), Newtonsoft.Json.JsonProperty("image")]
        [Description("IRI of an image representing the individual or organization. May be a DATA URI or the URL where the image may be found. Model Primitive Datatype = NormalizedString.")]
        public string Image { get; set; }
        
        /// <summary>
        /// The name of the individual or organization. Model Primitive Datatype = String.
        /// </summary>
        /// <value>The name of the individual or organization. Model Primitive Datatype = String.</value>
        [Required]
        [JsonPropertyName("name"), Newtonsoft.Json.JsonProperty("name")]
        [Description("The name of the individual or organization. Model Primitive Datatype = String.")]
        public string Name { get; set; }

        [JsonPropertyName("official"), Newtonsoft.Json.JsonProperty("official")]
        [Description("The name of the authorized official for the Issuer. Model Primitive Datatype = String.")]
        public string Official { get; set; }

        [JsonPropertyName("parentOrg"), Newtonsoft.Json.JsonProperty("parentOrg")]
        [Description("The parent organization of the person or organization represented by this organization. Model Primitive Datatype = String.")]
        public ProfileDType ParentOrg { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [JsonPropertyName("publicKey"), Newtonsoft.Json.JsonProperty("publicKey")]
        [Description("PublicKey")]
        public virtual CryptographicKeyDType PublicKey { get; set; }
        
        /// <summary>
        /// The URL of the Revocation List document used for marking revocation of signed Assertions, CLRs, and Endorsements. Required for issuer profiles. Model Primitive Datatype = AnyURI.
        /// </summary>
        /// <value>The URL of the Revocation List document used for marking revocation of signed Assertions, CLRs, and Endorsements. Required for issuer profiles. Model Primitive Datatype = AnyURI.</value>
        [JsonPropertyName("revocationList"), Newtonsoft.Json.JsonProperty("revocationList")]
        [Description("The URL of the Revocation List document used for marking revocation of signed Assertions, CLRs, and Endorsements. Required for issuer profiles. Model Primitive Datatype = AnyURI.")]
        public string RevocationList { get; set; }
        
        /// <summary>
        /// Signed endorsements in JWS Compact Serialization format. Model Primitive Datatype = String. 
        /// </summary>
        /// <value>Signed endorsements in JWS Compact Serialization format. Model Primitive Datatype = String. </value>
        [JsonPropertyName("signedEndorsements"), Newtonsoft.Json.JsonProperty("signedEndorsements")]
        [Description("Signed endorsements in JWS Compact Serialization format. Model Primitive Datatype = String. ")]
        public List<string> SignedEndorsements { get; set; }
        
        /// <summary>
        /// The individual's or organization's unique 'sourcedId' value, which is used for providing interoperability with other identity systems. Model Primitive Datatype = String.
        /// </summary>
        /// <value>The individual's or organization's unique 'sourcedId' value, which is used for providing interoperability with other identity systems. Model Primitive Datatype = String.</value>
        [JsonPropertyName("sourcedId"), Newtonsoft.Json.JsonProperty("sourcedId")]
        [Description("The individual's or organization's unique 'sourcedId' value, which is used for providing interoperability with other identity systems. Model Primitive Datatype = String.")]
        public string SourcedId { get; set; }
        
        /// <summary>
        /// An institution's student identifier for the person. This is frequently issued through a Student Information System. Model Primitive Datatype = String.
        /// </summary>
        /// <value>An institution's student identifier for the person. This is frequently issued through a Student Information System. Model Primitive Datatype = String.</value>
        [JsonPropertyName("studentId"), Newtonsoft.Json.JsonProperty("studentId")]
        [Description("An institution's student identifier for the person. This is frequently issued through a Student Information System. Model Primitive Datatype = String.")]
        public string StudentId { get; set; }
        
        /// <summary>
        /// Primary phone number for the individual or organization. Model Primitive Datatype = String.
        /// </summary>
        /// <value>Primary phone number for the individual or organization. Model Primitive Datatype = String.</value>
        [JsonPropertyName("telephone"), Newtonsoft.Json.JsonProperty("telephone")]
        [Description("Primary phone number for the individual or organization. Model Primitive Datatype = String.")]
        public string Telephone { get; set; }
        
        /// <summary>
        /// Web resource that uniquely represents or belongs to the individual. This may be a resource about the individual, hosting provided by the institution to the individual, or an web resource independently controlled by the individual. Model Primitive Datatype = AnyURI.
        /// </summary>
        /// <value>Web resource that uniquely represents or belongs to the individual. This may be a resource about the individual, hosting provided by the institution to the individual, or an web resource independently controlled by the individual. Model Primitive Datatype = AnyURI.</value>
        [JsonPropertyName("url"), Newtonsoft.Json.JsonProperty("url")]
        [Description("Web resource that uniquely represents or belongs to the individual. This may be a resource about the individual, hosting provided by the instution to the individual, or an web resource independently controlled by the individual. Model Primitive Datatype = AnyURI.")]
        public string Url { get; set; }
        
        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [JsonPropertyName("verification"), Newtonsoft.Json.JsonProperty("verification")]
        [Description("Verification")]
        public virtual VerificationDType Verification { get; set; }

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