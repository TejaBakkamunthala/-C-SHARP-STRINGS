using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class StringMethodss
    {

       public void StringMethodss1() {

            String name = "Teja Bakkamunthala";

            String name1=name.ToLower(); ;
            String name2=name.ToUpper(); ;
            Console.WriteLine(name);
            Console.WriteLine(name1);
            Console.WriteLine(name2);

           String name4=name.Substring(5,13);
           Console.WriteLine(name4);

            String name5 = name.Substring(0, 4);
            Console.WriteLine(name5);

            String name6 = name.Replace('a', 'b');
            Console.WriteLine(name6);


            char[] ch = name.ToCharArray();
            for(int i = 0; i < ch.Length; i++)
            {
                Console.Write(ch[i]+" ");
            }
            Console.WriteLine();


            String[] name7=name.Split('a');

            for(int i=0;i<name7.Length;i++)
            {
                Console.Write(name7[i] +"  ");
            }


            Console.WriteLine();
            String name8 = " hello ";
            Console.WriteLine(name8.Length);
           String name9= name8.Trim();
            Console.WriteLine(name9.Length) ;


            String[] words = { "hii", "how", "are", "you" };
            String strJoin=string.Join("-",words);
            Console.WriteLine("Join  "+strJoin);


            char[] ch1={'a','e','i','o','u'};

            for(int i = 0; i < ch1.Length; i++)
            {
                Console.WriteLine(ch1[i]+" ");
            }


            string str = new string(ch1);

            Console.WriteLine("str "+str);





        }
    }
}
