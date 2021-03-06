using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUrlLibrary.MsTest
{
    [TestClass]
    public class TestingUrls
    {
        [TestMethod]
        public void IsValidURL() {
            var url = new MyUrlParse("https://www.youtube.com/watch?v=YR12Z8f1Dh8&feature=relmfu");
            Assert.IsTrue(true==url.valid);
        }

        [TestMethod]
        public void IsValidEmptyUrl() {
            var url = new MyUrlParse("");
            Assert.IsTrue(false==url.valid);
        }

        [TestMethod]
        public void IsValidNullUrl() {
            var url = new MyUrlParse(null);
            Assert.IsTrue(false==url.valid);
        }
        
        [TestMethod] 
        public void IsInvalidURL() {
            var url = new MyUrlParse("123");
            Assert.IsTrue(false==url.valid);
        }

        [TestMethod]
        public void SchemeTest() {
            var url = new MyUrlParse("https://www.youtube.com/watch?v=YR12Z8f1Dh8&feature=relmfu");
            Assert.IsTrue("https"==url.scheme);
        }

        [TestMethod]
        public void UserTest() {
            var url = new MyUrlParse("http://username:password@example.com/");
            Assert.IsTrue("username"==url.user);
        }

        [TestMethod]
        public void PasswordTest() {
            var url = new MyUrlParse("http://username:password@example.com/");
            Assert.IsTrue("password"==url.password);
        }

        [TestMethod]
        public void HostTest() {
            var url = new MyUrlParse("foo://example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("example.com"==url.host);
        }

        [TestMethod]
        public void HostTestUserInfo() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("example.com"==url.host);
        }


        [TestMethod]
        public void PortTest() {
            var url = new MyUrlParse("foo://example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("8042"==url.port);
        }

        [TestMethod]
        public void PortTestUserInfo() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("8042"==url.port);
        }

        [TestMethod]
        public void PathTest() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("/over/there"==url.path);
        }

        [TestMethod]
        public void QueryTest() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("?name=ferret"==url.query);
        }

        [TestMethod]
        public void QueryEmptyTest() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there#nose");
            Assert.IsTrue(""==url.query);
        }

        [TestMethod]
        public void FragmentTest() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there?name=ferret#nose");
            Assert.IsTrue("#nose"==url.fragment);
        }

        [TestMethod]
        public void FragmentTestWithoutQuery() {
            var url = new MyUrlParse("foo://user:password@example.com:8042/over/there#nose");
            Assert.IsTrue("#nose"==url.fragment);
        }
    }
}
