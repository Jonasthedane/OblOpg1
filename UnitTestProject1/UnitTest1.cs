using System;
using Book;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestForfatter()
        {

            Bog bog = new Bog();
            bog.Forfatter = "b";
            
        }

        [TestMethod]
        public void TestSidetal()
        {
            Bog bog = new Bog();
            bog.Sidetal = 4;
            Assert.AreEqual(4, bog.Sidetal);
        }

        [TestMethod]
        public void TestIsbn13()
        {
            Bog bog = new Bog();
            bog.Isbn13 = "1234567891123";
            Assert.AreEqual("1234567891123", bog.Isbn13);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Testbog()
        {
            Bog bog = new Bog();
            bog.Titel = "titel";
            bog.Forfatter = "forfatter";
            bog.Sidetal = 20;
            bog.Isbn13 = "39234567654322";
   
        }
    }
}
