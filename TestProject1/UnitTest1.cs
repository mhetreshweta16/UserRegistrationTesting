using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Tests the Fisrt Name of User.
        /// </summary>
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

        /// <summary>
        /// Tests the last name.
        /// </summary>
        [TestMethod]
        public void TestLastName()
        {
            string message = "Mhe";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.getValidUserLastName();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
