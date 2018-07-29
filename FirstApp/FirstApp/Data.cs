using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Data
    {
        static void Main(String[] args)
        {

            DateTime date = new DateTime();
            var date2 = new DateTime(2015, 9, 25);
            var now = DateTime.Now;
            var today = DateTime.Today;


            Console.WriteLine("godzina " + now.Hour);
            Console.WriteLine("godzina " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());

            Console.WriteLine(now.ToString("yy-MM--dd"));

            Console.WriteLine("-------------time------------");

        }


    }
}
