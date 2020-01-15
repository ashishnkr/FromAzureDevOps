using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarCipher.UnitTests
{
    [TestClass]
    public class CaesarCipherTests
    {
        [TestMethod]
        public void Scenario_Encrypt_ShiftMoreThan26()
        {
            String text = "JuliusCaesarWasAssassinated";
            int s = 28;
            String encryptedText = CaesarCipher.Encrypt(text, s);
            Assert.AreEqual(encryptedText, "LwnkwuEcguctYcuCuucuukpcvgf");
        }

        [TestMethod]
        public void Scenario_Decrypt_ShiftMoreThan26()
        {
            String text = "LwnkwuEcguctYcuCuucuukpcvgf";
            int s = 28;
            String decryptedText = CaesarCipher.Decrypt(text, s);
            Assert.AreEqual(decryptedText, "JuliusCaesarWasAssassinated");
        }

        [TestMethod]
        public void Scenario_Encrypt_ShiftLessThan26()
        {
            String text = "JuliusCaesarWasAssassinated";
            int s = 5;
            String encryptedText = CaesarCipher.Encrypt(text, s);
            Assert.AreEqual(encryptedText, "OzqnzxHfjxfwBfxFxxfxxnsfyji");
        }

        [TestMethod]
        public void Scenario_Decrypt_ShiftLessThan26()
        {
            String text = "OzqnzxHfjxfwBfxFxxfxxnsfyji";
            int s = 5;
            String decryptedText = CaesarCipher.Decrypt(text, s);
            Assert.AreEqual(decryptedText, "JuliusCaesarWasAssassinated");
        }

        [TestMethod]
        public void Scenario_EncryptDecrypt_SameString()
        {
            String text = "InputStringToBeCheckedAfterDecryption";
            int s = 5;
            String encryptedText = CaesarCipher.Encrypt(text, s);
            String decryptedText = CaesarCipher.Decrypt(encryptedText, s);
            Assert.AreEqual("InputStringToBeCheckedAfterDecryption", decryptedText);
        }
    }
}
