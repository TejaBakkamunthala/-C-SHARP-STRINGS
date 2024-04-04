using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class Palindrome
    {

        public void Palindrome1()
        {
            string str = "malayalam";
            string str1 = "";



            Regex re = new Regex("^[A-Z a-z$]");

           // Console.WriteLine(str);

            if (re.IsMatch(str1))
            {
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    str1 += str[i];
                }
               // Console.WriteLine(str1);
                if (str.Equals(str1))
                {
                    Console.WriteLine("It's a palindrome");
                }
                else
                {
                    Console.WriteLine("Not a Palindrome ");
                }
            }
        }
       
    }
}
