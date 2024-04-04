using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CopyOneString
    {

        public void  CopyOneString1() {
            String str = "Teja";
            String str1 = "";


            for(int i=0;i<str.Length; i++)
            {
                Console.Write(str[i]+" ");
            }
            Console.WriteLine();
            for (int i=0;i<str.Length;i++)
            {
                str1 = str1 + str[i];
            }

            for(int i=0;i< str1.Length;i++)
            {
                Console.Write(str1[i]+" ");
            }
            
        
         }
    }
}
