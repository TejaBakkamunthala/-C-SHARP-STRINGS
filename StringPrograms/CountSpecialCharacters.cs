using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    public class CountSpecialCharacters
    {
        public void SpecialCharcaters1()
        {

            String str = "HiiThis!$#$%IsTeja/#4%";
            char[] ch=str.ToCharArray();

            int count = 0;
            for(int i=0; i<ch.Length; i++)
            {
                if (ch[i]>=33 && ch[i] <= 47)
                {
                    count ++;
                    Console.Write(ch[i]+"  ");
                }
            }

            Console.WriteLine();
            if (count > 1)
            {
                Console.WriteLine("Special Characters Present"+count);
            }
            else
            {
                Console.WriteLine("No Special Characters in this string ");
            }
        }

    }
}
