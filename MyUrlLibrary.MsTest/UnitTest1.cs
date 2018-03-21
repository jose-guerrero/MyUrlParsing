using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUrlLibrary.MsTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void GetScheme() 
        {
            var sut = new MyUrlParse();
            sut.MakeParsing("http://sdsd");
            Assert.IsTrue("http"==sut.scheme);
        }

        [TestMethod]
        public void IsValidURL() 
        {
            var sut = new MyUrlParse();
            sut.MakeParsing("http://sdsd");
            Assert.IsTrue(false==sut.valid);
        }
        
    }
}
