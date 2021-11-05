using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationTesting
{
   public class TestingClass
    {
        public string message;
        public TestingClass(string message)
        {
            this.message = message;

        }

        //User Registration Pattern
        string firstNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";
        string mobileNoPattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";
        string passwordPattern = "^(?=.*[0-9])(?=.*[A-Z])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{8}$";

        /// <summary>
        /// Gets the first name of the valid user.
        /// </summary>
        /// <returns></returns>
        public string getValidUserFirstName()
        {
            Regex regex = new Regex(firstNamePattern);
            

            if (regex.IsMatch(message))
            {
                //Console.WriteLine(word + "---> valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine(word + "---> invalid");
                return "invalid";
            }

        }

        /// <summary>
        /// Gets the last name of the valid user.
        /// </summary>
        /// <returns></returns>
        public string getValidUserLastName()
        {

            Regex regex = new Regex(lastNamePattern);


            if (regex.IsMatch(message))
            {
                //Console.WriteLine(word + "---> valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine(word + "---> invalid");
                return "invalid";
            }

        }

        /// <summary>
        /// Gets the valid user email.
        /// </summary>
        /// <returns></returns>
        public string getValidUserEmail()
        {
            Regex regex = new Regex(emailPattern);


            if (regex.IsMatch(message))
            {
                //Console.WriteLine(word + "---> valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine(word + "---> invalid");
                return "invalid";
            }

        }

        /// <summary>
        /// Gets the valid mobile number.
        /// </summary>
        /// <returns></returns>
        public string getValidMobileNumber()
        {
            Regex regex = new Regex(mobileNoPattern);


            if (regex.IsMatch(message))
            {
                //Console.WriteLine(word + "---> valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine(word + "---> invalid");
                return "invalid";
            }
        }

        public string getValidUserPassword()
        {

            Regex regex = new Regex(passwordPattern);


            if (regex.IsMatch(message))
            {
                //Console.WriteLine(word + "---> valid");
                return "valid";
            }
            else
            {
                //Console.WriteLine(word + "---> invalid");
                return "invalid";
            }
        }
    }
}
