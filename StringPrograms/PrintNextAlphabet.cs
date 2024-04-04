using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class PrintNextAlphabet
    {


        public void PrintNextAlphabet1()
        {
            String str = "teja";
            String str1 = "Sunil";
            //Console.WriteLine(str);

            //char ch = 't';

            //int a = ch;
            //Console.WriteLine(a);

            //int b = ch + 1;
            //Console.WriteLine(b);

            //char ch1 =(char) b;
            //Console.WriteLine(ch1);

            for(int i = 0; i < str.Length; i++)
            {

                Console.Write(str[i]+" ");
            }

            Console.WriteLine();


            for (int i=0;i<str.Length;i++)
            {
                char ch2 = str[i];
                int a2 = ch2 + 1;
                char ch3=(char) a2;
                Console.Write(ch3+" ");
            }

            Console.WriteLine();
            for (int i=0;i<str1.Length;i++)
            {
                Console.Write(str1[i]+" ");
            }

            Console.WriteLine();
            for (int i=0;i<str1.Length;i++)
            {
                char ch3 = str1[i];
                int a4 = ch3 + 1;
                char ch5 = (char)a4;
                Console.Write(ch5+" ");
            }

            





        }
    }
}
