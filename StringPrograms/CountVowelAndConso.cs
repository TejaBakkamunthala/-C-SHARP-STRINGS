using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CountVowelAndConso
    {

        public void CountVowelAndConso1()
        {

            String str = "TejaBakkamunthala";

            Console.WriteLine(str.Length);
            int vowels = 0;
            int consonants = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }

            Console.WriteLine("Vowels "+vowels);
            Console.WriteLine("Consonants "+consonants);

            
        }
    }
}
