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

        static void Main(String[] args)
        {
            var path = @"d:\dupa.txt";


            String str = File.ReadAllText(path);
            String[] tab = str.Split(' ');


            Console.WriteLine(str + " " +tab.Length + " najdluzszy wyraz "+ count(tab));
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
