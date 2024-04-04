using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPrograms
{
    internal class CheckingStrings
    {

        public void CheckingStrings1()
        {

            String str1 = "Teja";
            String str2 = "Teja";
               if(str1.Equals(str2))
            {
                Console.WriteLine("equalss");
            }

            bool eq1=str1==str2;
            bool eq2=str1.Equals(str2);
            Console.WriteLine("eq1 ==  "+eq1);
            Console.WriteLine("eq2 "+eq2);

            string str3 = "Teja";
            string str4 = "Sunil";
            bool eq3=(str3==str4);
            bool eq4=str3.Equals(str4);
            Console.WriteLine("eq3 ==  " +eq3 );
            Console.WriteLine("eq4  "+eq4 );


            Console.WriteLine("Starts With T "+str1.StartsWith("T"));
            Console.WriteLine("Starts With E "+str1.StartsWith("E"));
            Console.WriteLine("Ends With A "+str1.EndsWith("a"));
            Console.WriteLine("Ends With J "+str1.EndsWith("j"));


            Console.WriteLine("Contains te "+str1.Contains("T"));
            Console.WriteLine("Contains hi "+str1.Contains("h"));
            Console.WriteLine("Contains teh "+str1.Contains("e"));


            Console.WriteLine(str1.IndexOf('e'));
            Console.WriteLine(str1.IndexOf('T'));
            Console.WriteLine(str1.IndexOf('Z'));
            Console.WriteLine(str1.IndexOf('a'));
            Console.WriteLine(str1.IndexOf("ja"));

            String str5 = "Developer";
            Console.WriteLine(str5.IndexOf('e'));
            Console.WriteLine(str5.IndexOf('e',2));

            Console.WriteLine(str5.LastIndexOf('e'));
            Console.WriteLine(str5.LastIndexOf('e',2));


            String str6 = null;
            string str7 = "";
            string str8 = " ";

            bool isNullOrEmpty1 = String.IsNullOrEmpty(str5);
            bool isNullOrEmpty2 = string.IsNullOrEmpty(str6);
            bool isNullOrEmpty3=string.IsNullOrEmpty(str7);
            bool isNullOrEmpty4 =string.IsNullOrEmpty(str8);


           
            Console.WriteLine("IsNullOrEmpty OF str5 "+isNullOrEmpty1);
            Console.WriteLine("IsNullOrEmpty of str6 "+isNullOrEmpty2);
            Console.WriteLine("IsNullOrEmpty of str7 "+isNullOrEmpty3);
            Console.WriteLine("IsNullOrEmpty of str8 "+isNullOrEmpty4);


            if (string.IsNullOrEmpty(str6))
            {
                //Don;t store the value into property 
            }

            bool isNullOrWhiteSpace1 = String.IsNullOrWhiteSpace(str5);
            bool isNullOrWhiteSpace2 = string.IsNullOrWhiteSpace(str6);
            bool isNullOrWhiteSpace3 = string.IsNullOrWhiteSpace(str7);
            bool isNullOrWhiteSpace4 = string.IsNullOrWhiteSpace(str8);

            Console.WriteLine("isNullOrWhiteSpace1 of str5 " + isNullOrWhiteSpace1);
            Console.WriteLine("isNullOrWhiteSpace2 of str6 " + isNullOrWhiteSpace2);
            Console.WriteLine("isNullOrWhiteSpace3 of str7 " + isNullOrWhiteSpace3);
            Console.WriteLine("isNullOrWhiteSpace4 of str8 " + isNullOrWhiteSpace4);


            //formattingStringsss

            String director = "RajaMouli";
            Console.WriteLine(director);
            string movie = "Bahubali";
            Console.WriteLine(movie);
            String full = string.Format("{0} is the director of {1}", director, movie);
            Console.WriteLine(full);


            String hero = "prabhas";
            Console.WriteLine(hero);
            string details = $"{hero} is the hero for {movie}  movie";

            Console.WriteLine(details);


            //Modifying stringss

            string name = "Developer";
            Console.WriteLine();
            String name2=name.Insert(3, "Sad");
            Console.WriteLine(name2);


            String name3 = name2.Remove(3, 3);
            Console.WriteLine(name3);



            Console.WriteLine();


            string name4 = "BridgeLabz";
            for(int i = 0; i < name4.Length; i++)
            {
                Console.Write(name4[i]+"  ");
            }




            Console.WriteLine();
            String strr = "developer";

            char[] vowels = {'A','E','I','O','U','a','e','i','o','u' };


            int count = 0;
            for(int i=0;i<strr.Length; i++)
            {
                if (strr[i]=='a' || strr[i] =='e' || strr[i]=='i' || strr[i]=='o' || strr[i] == 'u')
                {
                    count++;
                }
            }

            Console.WriteLine("No of vowelss "+count);

            int count1 = 0;
            for(int i = 0; i < strr.Length; i++)
            {
                if (Array.IndexOf(vowels, strr[i])>0)
                {

                    count1++;

                }
            }

            Console.WriteLine(count++);


            //LINQ

            Console.WriteLine(strr.Count(ch => Array.IndexOf(vowels, ch) >= 0));



        }
    }

}
