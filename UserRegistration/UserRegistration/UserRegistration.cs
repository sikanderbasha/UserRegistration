using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class UserRegistration
    {
          public void Firstname()
          {
            Regex firstname = new Regex("^[A-Z]{1}[a-z]{3,15}$");
            Console.WriteLine("Enter first Name :");
            string first = Console.ReadLine();
            if (firstname.IsMatch(first))
            {
                Console.WriteLine("First Name : " + first);
            }
            else
            {
                Console.WriteLine("Enter name in valid format");
            }
        }

        public void Lastname()
        {
            Regex lastname = new Regex("^[A-Z]{1}[a-z]{3,15}$");
            Console.WriteLine("Enter last Name :");
            string last = Console.ReadLine();
            if (lastname.IsMatch(last))
            {
                Console.WriteLine("Last Name : " + last);
            }
            else
            {
                Console.WriteLine("Enter name in valid format");
            }
        }
        public void EmailID()
        {
            Regex lastname = new Regex("^[a-z0-9]{3,}[-a-z0-9._]+@([-a-z0-9]+.)+[a-z]{2,3}$");
            Console.WriteLine("Enter EmailID :");
            string Email = Console.ReadLine();
            if (lastname.IsMatch(Email))
            {
                Console.WriteLine("EmailID : " + Email);
            }
            else
            {
                Console.WriteLine("Enter EmailID in valid format");
            }
        }
        public void MobileNumber()
        {
            Regex number = new Regex("^[9][1]{1,2}[ ][6-9]{1}[0-9]{9}");
            Console.WriteLine("Enter mobile number :");
            string num = Console.ReadLine();
            if (number.IsMatch(num))
            {
                Console.WriteLine("Mobile number : " + num);
            }
            else
            {
                Console.WriteLine("Enter mobile number in valid format");
            }
        }

        public void Password()
        {
            Regex Password = new Regex("^.*[A-Z].{8,}$");
            Console.WriteLine("Enter a Password :");
            string Pass = Console.ReadLine();
            if (Password.IsMatch(Pass))
            {
                Console.WriteLine("Password : " + Pass);
            }
            else
            {
                Console.WriteLine("Enter Password in valid format");
            }
        }

    }
}
