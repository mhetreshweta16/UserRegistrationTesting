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

        //string firstNameInput = "Shw" ;
        string firstNamePattern = "^[A-Z]{1}[a-z]{2}$";
        public string getValidUserFirstName()
        {
            Regex regex = new Regex(firstNamePattern);
            //  Console.WriteLine("UC8 Rule4 password Validation ");

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
