using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstApp
{
    class Filessss
    {
         const int dupa = 5;


        static void Main(String[] args)
        {
            var path = @"d:\dupa.txt";
            

            String str = File.ReadAllText(path);
            String[] tab = str.Split(' ');


            Console.WriteLine(str + " " +tab.Length + " najdluzszy wyraz "+ count(tab));


            List<String> stringi = new List<string>();
            stringi.Add("f5 debug");
            stringi.Add("a to napis");

            Console.WriteLine(stringi.ElementAt(0));

            if(stringi.Count < dupa)
            {
                //throw new ArgumentOutOfRangeException("dupa jest za duza");
                Console.WriteLine("a jak sie wywali to jest okej ");
                    
            } else
            {
                stringi.Add("kolejny string");
            }



        }



        private static int count(String[] tab)
        {
            int longest = 0;
            foreach(var str in tab)
            {
                if(longest < str.Length)
                {
                    longest = str.Length;
                }


            }
            return longest;
        }


       

    }
}
