using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringPrograms
{
    internal class PrintString
    {


        public void PrintString1()
        {
            String str = "Welcome To DotNet ";



            for(int i=0;i<1;i++)
            {
                Console.Write(str+" ");
            }

            Console.WriteLine();

            for (int i=0;i<str.Length;i++)
            {
                Console.Write(str[i]+" ");

            }

            Console.WriteLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]+" ");
            }


            int count = 0;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i]==' ' || str[i]=='\n' || str[i]=='\t')
                {
                    count++;

                }
            }
            Console.WriteLine("Count "+count);

            Console.WriteLine();
            String[] str1 = str.Split(' ');

            Console.WriteLine(str1.Length);

        }
    }
}
