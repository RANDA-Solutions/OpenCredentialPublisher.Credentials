using Multiformats.Base;
using OpenCredentialPublisher.Credentials.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class CryptoMethodsTests
    {
        [Fact]
        public void EncryptString_DecryptBytes_ShouldWorkCorrectly()
        {
            // Arrange
            var rsaKey = CryptoMethods.GenerateRsaKey();
            var publicKey = CryptoMethods.GetPublicRsaKey(rsaKey);
            var privateKey = rsaKey;
            var originalValue = "Test String";

            // Act
            var encrypted = CryptoMethods.EncryptString(publicKey, originalValue);
            var decrypted = CryptoMethods.DecryptBytes(privateKey, encrypted);

            // Assert
            Assert.Equal(originalValue, decrypted);
        }

        [Fact]
        public void SignString_VerifySignature_ShouldWorkCorrectly()
        {
            // Arrange
            var rsaKey = CryptoMethods.GenerateRsaKey();
            var publicKey = CryptoMethods.GetPublicRsaKey(rsaKey);
            var privateKey = rsaKey;
            var originalValue = "Test String";

            // Act
            var signature = CryptoMethods.SignString(KeyAlgorithmEnum.RSA, privateKey, originalValue);
            var isValid = CryptoMethods.VerifySignature(KeyAlgorithmEnum.RSA, publicKey, signature, originalValue);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void SignBytes_VerifySignature_ShouldWorkCorrectly()
        {
            // Arrange
            var keypair = CryptoMethods.GenerateEd25519Keys();
            var originalBytes = new byte[] { 1, 2, 3, 4, 5 };

            // Act
            var signature = CryptoMethods.SignBytes(KeyAlgorithmEnum.Ed25519, keypair.privateKey, originalBytes);
            var isValid = CryptoMethods.VerifySignature(KeyAlgorithmEnum.Ed25519, keypair.publicKey, CryptoMethods.Base58DecodeString(signature), originalBytes);

            // Assert
            Assert.True(isValid);
        }

        [Fact]
        public void GenerateSecretKey_ShouldGenerateKeyOfCorrectLength()
        {
            // Arrange
            var length = 32;

            // Act
            var secretKey = CryptoMethods.GenerateSecretKey(length);

            // Assert
            Assert.Equal(length, secretKey.Length);
        }

        [Fact]
        public void GenerateRsaKey_ShouldGenerateValidKey()
        {
            // Act
            var rsaKey = CryptoMethods.GenerateRsaKey();

            // Assert
            Assert.NotNull(rsaKey);
            Assert.True(rsaKey.Length > 0);
        }

        [Fact]
        public void FromCspBlobToRSAParameters_ShouldConvertCorrectly()
        {
            // Arrange
            var rsaKey = CryptoMethods.GenerateRsaKey();

            // Act
            var rsaParameters = rsaKey.FromCspBlobToRSAParameters();

            // Assert
            Assert.NotNull(rsaParameters);
        }

        [Fact]
        public void GetPublicRsaKey_ShouldExtractPublicKey()
        {
            // Arrange
            var rsaKey = CryptoMethods.GenerateRsaKey();

            // Act
            var publicKey = CryptoMethods.GetPublicRsaKey(rsaKey);

            // Assert
            Assert.NotNull(publicKey);
            Assert.NotEqual(rsaKey, publicKey);
        }

        [Fact]
        public void GetPublicEd25519Key_ShouldExtractPublicKey()
        {
            // Arrange
            var ed25519Key = CryptoMethods.GenerateEd25519Key();

            // Act
            var publicKey = CryptoMethods.GetPublicEd25519Key(ed25519Key);

            // Assert
            Assert.NotNull(publicKey);
            Assert.NotEqual(ed25519Key, publicKey);
        }

        [Fact]
        public void GenerateEd25519Keys_ShouldGenerateValidKeys()
        {
            // Act
            var (publicKey, privateKey) = CryptoMethods.GenerateEd25519Keys();

            // Assert
            Assert.NotNull(publicKey);
            Assert.NotNull(privateKey);
            Assert.NotEqual(publicKey, privateKey);
        }

        [Fact]
        public void Base58EncodeBytes_Base58DecodeString_ShouldWorkCorrectly()
        {
            // Arrange
            var originalBytes = new byte[] { 1, 2, 3, 4, 5 };

            // Act
            var encoded = CryptoMethods.Base58EncodeBytes(originalBytes);
            var decoded = CryptoMethods.Base58DecodeString(encoded);
            Multibase.TryDecode(encoded, out var encoding, out var decodedTwice);
            Assert.True(encoding == MultibaseEncoding.Base58Btc);
            // Assert
            Assert.Equal(originalBytes, decoded);
        }

        [Fact]
        public void GetDIDKeyEd25519Public_ShouldReturnCorrectFormat()
        {
            // Arrange
            var ed25519Key = CryptoMethods.GenerateEd25519Key();
            var publicKey = CryptoMethods.GetPublicEd25519Key(ed25519Key);

            // Act
            var didKey = CryptoMethods.GetDIDKeyEd25519Public(publicKey);

            // Assert
            Assert.StartsWith("did:key:", didKey);
        }

        [Theory]
        [InlineData("zGhhXyXmvuaCWpS4nA5EkM6rC2T2Fao1kSpQ7vXGfmieu")]
        [InlineData("z8u7VQXKW45PHF17ERtuEwbZgpsoEMQof6FED2XPjStyX")]
        [InlineData("zFpcdpeBn8Nc2Xkk4NscHgMeutTH2t5kC3erEuRHibR83")]
        [InlineData("zwiGYuUYC8G2Hd5a9A95KkvoLQ6Fm8RUN5J4r8MUj1yu")]
        public void Ed25519PublicKeyString_ShouldReturnCorrectFormat(string key)
        {
            // Arrange
            Multibase.TryDecode(key, out var encoding, out var decodedTwice);

            // Act
            Assert.True(encoding == MultibaseEncoding.Base58Btc);
        }

        [Theory]
        [InlineData("zGhhXyXmvuaCWpS4nA5EkM6rC2T2Fao1kSpQ7vXGfmieu")]
        [InlineData("z8u7VQXKW45PHF17ERtuEwbZgpsoEMQof6FED2XPjStyX")]
        [InlineData("zFpcdpeBn8Nc2Xkk4NscHgMeutTH2t5kC3erEuRHibR83")]
        [InlineData("zwiGYuUYC8G2Hd5a9A95KkvoLQ6Fm8RUN5J4r8MUj1yu")]
        public void ProvidedBase58EncodedEd25519PublicKey_ShouldHaveExpectedHeader(string key)
        {
            // Act
            var decodedPublicKey = CryptoMethods.Base58DecodeString(key);
            var fixedEncoding = CryptoMethods.Base58EncodeEd25519PublicKey(decodedPublicKey);
            var fixedPublicKey = CryptoMethods.Base58DecodeString(fixedEncoding);
            Console.WriteLine($"Bad Encoding: {key}, Fixed Encoding: {fixedEncoding}");
            // Assert
            Assert.NotNull(fixedPublicKey);
            Assert.True(fixedPublicKey.Length > 2, "Decoded public key should have at least 2 bytes for the header.");
            Assert.Equal(0xED, fixedPublicKey[0]); // Verify the first byte is the Ed25519 codec (0xED)
            Assert.Equal(0x01, fixedPublicKey[1]); // Verify the second byte is the multicodec version (0x01)
        }

        [Fact]
        public void Base58EncodedEd25519PublicKey_ShouldHaveExpectedHeader()
        {
            // Arrange
            var ed25519Key = CryptoMethods.GenerateEd25519Key();
            var publicKey = CryptoMethods.GetPublicEd25519Key(ed25519Key);
            var encodedPublicKey = CryptoMethods.Base58EncodeEd25519PublicKey(publicKey);

            // Act
            var decodedPublicKey = CryptoMethods.Base58DecodeString(encodedPublicKey);

            // Assert
            Assert.NotNull(decodedPublicKey);
            Assert.True(decodedPublicKey.Length > 2, "Decoded public key should have at least 2 bytes for the header.");
            Assert.Equal(0xED, decodedPublicKey[0]); // Verify the first byte is the Ed25519 codec (0xED)
            Assert.Equal(0x01, decodedPublicKey[1]); // Verify the second byte is the multicodec version (0x01)
        }

        [Fact]
        public void GetDIDKeyEd25519Private_ShouldReturnCorrectFormat()
        {
            // Arrange
            var ed25519Key = CryptoMethods.GenerateEd25519Key();

            // Act
            var didKey = CryptoMethods.GetDIDKeyEd25519Private(ed25519Key);

            // Assert
            Assert.StartsWith("did:key:", didKey);
        }
    }
}
