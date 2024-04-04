using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class MaximumCharater
    {

        public void MaximumCharacter()
        {

            String str = "aaaabbbbbbbzzzzxxyyyfffccaad";

            char[] ch = str.ToCharArray();
            int[] arr = new int[26];

            for(int i=0; i<ch.Length; i++) {
                Console.Write(ch[i]+" ");
            }

            
            for(int i = 0; i < ch.Length; i++)
            {
                int index = ch[i]-97;
                arr[index]++;
            }

            Console.WriteLine();
            for (int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.WriteLine();

            int max = arr[0];
            int n = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                    n = i;

                }
            }

            Console.WriteLine(" Max "+max);
            Console.WriteLine("Index "+n);


           // char ch1 = (char)n + 97; ;
            Console.WriteLine("HII");

            Console.WriteLine(str[n]);

            Console.WriteLine("HII");

            int n1 = 98;
            
            Char ch2 = (char)n1;
            Console.WriteLine(ch2);


            int n3 = 97 + n;

            char ch3 = (char)n3;
            Console.WriteLine(ch3);
            Console.WriteLine();

            int nn= 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1)
                {
                    //Console.Write(arr[i]+"  ");
                    nn = arr[i];
                    int n4 = i + 97;
                    char ch4 = (char)n4;
                    Console.WriteLine(arr[i]+"  "+ ch4+" ");
                }

            }

        }
    }
}
