using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CountAlphabetsDIgits
    {
        public void CountAlphabetsDIgits1()
        {

            String str = "CountAlphabet12345sDIgits.@##$1233";

            Console.WriteLine( str.Length);

            int alpha = 0;
            int digits= 0;
            int specialCharacters= 0;
            for(int i=0;i<str.Length; i++)
            {
                if (str[i]>='A' && str[i]<='Z' || str[i]>='a' && str[i] <= 'z')
                {
                    alpha++;
                }
                else if (str[i]>='0' && str[i] <='9')
                {
                    digits++;
                }
                else
                {
                    specialCharacters++;
                }

            }

            Console.WriteLine("Alphabets Count " + alpha);
            Console.WriteLine("Digits "+digits);
            Console.WriteLine("Special Characters "+specialCharacters);

        }
    }
}
