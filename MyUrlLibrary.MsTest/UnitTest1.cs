using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MyUrlLibrary.MsTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void SchemeTest() 
        {
            var url = new MyUrlParse();
            url.MakeParsing("https://www.youtube.com/watch?v=YR12Z8f1Dh8&feature=relmfu");
            Assert.IsTrue("https"==url.scheme);
        }

        [TestMethod]
        public void IsValidURL() 
        {
            var url = new MyUrlParse();
            url.MakeParsing("https://www.youtube.com/watch?v=YR12Z8f1Dh8&feature=relmfu");
            Assert.IsTrue(true==url.valid);
        }

        [TestMethod]
        public void UserTest() 
        {
            var url = new MyUrlParse();
            url.MakeParsing("https://www.youtube.com/watch?v=YR12Z8f1Dh8&feature=relmfu");
            Assert.IsTrue(""==url.user);
        }
        
    }
}
