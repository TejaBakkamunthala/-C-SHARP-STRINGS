using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CompareTwoStrings
    {

        public void CompareTwoStrings1()
        {

            String str = "Teja";
            String str1 = "Teja";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str1.Length; j++)
            //    {
            //        if (st)
            //    }
            //    }

                if (str.Length == str1.Length)
            {
                if (str.Equals(str1))
                {
                    Console.WriteLine("Both String ae Equals ");
                }
                else
                {
                    Console.WriteLine("Both Strings are not equal ");
                }
            }
        }
    }


}
