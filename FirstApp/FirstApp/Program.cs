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
            long dd;
            const float Pi = 3.15f;
            decimal big = 3.5657765m;
            double dob = 4.5;
            char s = 's';
            Console.WriteLine("number"+number+" "+dob+" "+big+" "+Pi+" "+num+" "+s);
            Console.WriteLine(dob);
        }
    }
}
