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

        /// <summary>
        /// Tests the user email.
        /// </summary>
        [TestMethod]
        public void TestUserEmail()
        {
            string message = "abc.xyz@bl.co.in";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.getValidUserEmail();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Tests the user mobile number.
        /// </summary>
        [TestMethod]
        public void TestUserMobileNumber()
        {
            string message = "91 8686531051";
            string expected = "valid";

            //Act
            TestingClass testing = new TestingClass(message);
            string actual = testing.getValidMobileNumber();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
