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

        }


    }
}
