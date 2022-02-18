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
    }
}
