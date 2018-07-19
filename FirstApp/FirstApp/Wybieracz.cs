using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    public enum Things
    {
        Kompa = 1,
        Myszka = 2,
        Dzojstik = 3

    }

    class Ludzik{

        public int wiek;
        }


    class Wybieracz
    {

        static void Main(string[] args)
        {


            var cos = Things.Kompa;
            Console.WriteLine((int)cos);

            var cosId = 3;

            Console.WriteLine((Things)cosId);
            Console.WriteLine(cos.ToString());

            var enumek = "Kompa";

            var zamiana = (Things)Enum.Parse(typeof(Things), enumek);

            Console.WriteLine(zamiana);


            int i = 10;
            var b = i;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", i, b));

            var ar1 = new int[3] {1, 2, 3 };
            var ar2 = ar1;

            for(int x =0; x< ar2.Length; x++)
            {
                ar2[x]++;
            }

            Console.WriteLine(string.Format("pierwszy: {0}, drugi: {1}, trzeci:{2}", ar1[0], ar1[1], ar1[2]));
            Console.WriteLine(string.Format("pierwszy: {0}, drugi: {1}, trzeci:{2}", ar2[0], ar2[1], ar2[2]));


            var ludek = new Ludzik {wiek = 20 };

        }


    }
}
