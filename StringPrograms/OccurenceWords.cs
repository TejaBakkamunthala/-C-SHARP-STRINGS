using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class OccurenceWords
    {
        public void OccurenceWords1()
        {
            //string[] str = {"teja","pavan","teja","pavan","hii","hii","daa","teja","daa"};

            String str = "teja pavan teja pavan kumar hii hii daa teja";

            String[] str1=str.Split(' ');

            for(int i=0;i<str1.Length; i++)
            {
                string str2 = str1[i];
                if (str2 != "0")
                {
                    int count = 0;
                    for (int j = 0; j < str1.Length; j++)
                    {

                        if (str2.Equals(str1[j]))
                        {
                            count++;
                            str1[j] = "0";
                        }
                    }
                    Console.WriteLine(str2 + " " + count);
                }
            }
        }
    }
}
