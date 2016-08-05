using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EncryptionStrategy;

namespace UnitTest_Encrytion
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ROT13_Encrption_LowerCase()
        {
            IEncryption rot13 = new ROT13();
            
            string expected = "grfg";
            string actual = rot13.Encrypt("test");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ROT13_Decryption_LowerCase()
        {
            IEncryption rot13 = new ROT13();

            string expected = "test";
            string actual = rot13.Decrypt("grfg");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverse_Encryption_LowerCase()
        {
            IEncryption stringReverse = new StringReverse();

            string expected = "tset";
            string actual = stringReverse.Encrypt("test");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverse_Decryption_LowerCase()
        {
            IEncryption stringReverse = new StringReverse();

            string expected = "test";
            string actual = stringReverse.Decrypt("tset");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ROT13_Encrption_UpperCase()
        {
            IEncryption rot13 = new ROT13();

            string expected = "GRFG";
            string actual = rot13.Encrypt("TEST");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ROT13_Decryption_UpperCase()
        {
            IEncryption rot13 = new ROT13();

            string expected = "TEST";
            string actual = rot13.Decrypt("GRFG");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverse_Encryption_UpperCase()
        {
            IEncryption stringReverse = new StringReverse();

            string expected = "TSET";
            string actual = stringReverse.Encrypt("TEST");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StringReverse_Decryption_UpperCase()
        {
            IEncryption stringReverse = new StringReverse();

            string expected = "TEST";
            string actual = stringReverse.Decrypt("TSET");

            Assert.AreEqual(expected, actual);
        }
    }
}
