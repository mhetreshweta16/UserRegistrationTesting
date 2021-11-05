using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string message = "Shw";
            string expected = "valid";

            //Act
            TestingClass   testing = new TestingClass(message);
            string actual = testing.getValidUserFirstName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
