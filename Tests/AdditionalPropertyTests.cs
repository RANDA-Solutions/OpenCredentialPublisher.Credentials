using System.Text.Json;
using OpenCredentialPublisher.Credentials.Clrs.v2_0;

namespace Tests
{
    public class AdditionalPropertyTests
    {
        [Fact]
        public void TestClrCredential_ShouldSaveAdditionalProperties()
        {
            string clrCredentialJsonString = "{" +
                "\"issuer\": {" +
                "   \"id\": \"issuer-id\"," +
                "   \"randomOtherProperty\": 3" +
                "}," +
                "\"credentialSubject\": {" +
                "   \"type\": [ \"ClrSubject\" ]," +
                "   \"id\": \"credential-subject-id\"," +
                "   \"givenName\": \"Luke\"," +
                "   \"familyName\": \"Skywalker\"" +
                "}," +
                "\"partial\": false," +
                "\"awardedDate\": \"2024-08-27T00:00:00Z\"," +
                "\"type\": [ \"VerifiableCredential\", \"ClrCredential\" ]," +
                "\"id\": \"clr-credential-id\"," +
                "\"booleanProperty\": true," +
                "\"validFrom\": \"2024-05-02T00:00:00Z\"" +
                "}";

            ClrCredential credential = JsonSerializer.Deserialize<ClrCredential>(clrCredentialJsonString)!;

            Assert.NotNull(credential.Issuer.AdditionalProperties);
            Assert.Single(credential.Issuer.AdditionalProperties);
            Assert.Equal(3, Convert.ToInt32(credential.Issuer.AdditionalProperties!["randomOtherProperty"].ToString()));

            Assert.NotNull(credential.CredentialSubject.AdditionalProperties);
            Assert.Equal(2, credential.CredentialSubject.AdditionalProperties.Count);
            Assert.Equal("Luke", credential.CredentialSubject.AdditionalProperties!["givenName"].ToString());
            Assert.Equal("Skywalker", credential.CredentialSubject.AdditionalProperties!["familyName"].ToString());

            Assert.NotNull(credential.AdditionalProperties);
            Assert.Single(credential.AdditionalProperties);
            Assert.True(Convert.ToBoolean(credential.AdditionalProperties!["booleanProperty"].ToString()));

            string serializedCredential = JsonSerializer.Serialize(credential);
            Assert.Contains("\"randomOtherProperty\":3", serializedCredential);
            Assert.Contains("\"givenName\":\"Luke\"", serializedCredential);
            Assert.Contains("\"familyName\":\"Skywalker\"", serializedCredential);
            Assert.Contains("\"booleanProperty\":true", serializedCredential);
        }

        [Fact]
        public void TestClrCredential_LocalContext()
        {
            ClrCredential credential = new ClrCredential();
            credential.Context.Add(JsonDocument.Parse("{ \"givenName\": \"https://schema.org/givenName\", \"familyName\": \"https://schema.org/familyName\", \"additionalName\": \"https://schema.org/additionalName\" }"));

            string serializedCredential = JsonSerializer.Serialize(credential);
            Assert.Contains("https://schema.org/additionalName", serializedCredential);
            var backAgain = JsonSerializer.Deserialize<ClrCredential>(serializedCredential);
            Assert.NotNull(backAgain);
        }
    }
}