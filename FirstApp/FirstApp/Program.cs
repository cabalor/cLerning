using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            byte number =  4;
            int num = 333;
            long dd = 1231L;
            const float Pi = 3.14f;
            decimal big = 3.5657765m;
            double dob = 4.5;
            char s = 's';
            var dupa = true;
            var character = 's';
            Console.WriteLine("number"+number+" "+dob+" "+big+" "+Pi+" "+num+" "+s+" "+dd);
            Console.WriteLine(dupa + " "+ character);
            Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);
            Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);

            int k = 4;
            string str = "21";
            int kk = Convert.ToInt32(str);
            String str2 = Convert.ToString(k); ;
            Console.WriteLine(k+" string maly "+str+" int dziwny "+kk+" string duzy "+str2);
            int kk3 = int.Parse(str2);

            int liczb1 = 1;
            int liczba = 3;
            Console.WriteLine(dodaj(liczb1, liczba));

        }

        public static int dodaj(int a, int b)
        {
            return a + b;
        }
    }
}
