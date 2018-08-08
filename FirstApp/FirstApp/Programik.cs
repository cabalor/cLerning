using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    public class Osoba
    {
        public String name;


        public void Hello(String str)
        {
            Console.WriteLine("Hi {0}, Jestem {1}", str, name);
        }

        public static Osoba zmien(String str)
        {
            var pers = new Osoba();
            pers.name = str;
            return pers;
        }



    }


    class Programik
    {
        static void Main(String[] args)
        {
            Osoba person = new Osoba();
            var person1 = new Osoba();
            var p2 = Osoba.zmien("szczota");

            person.name = "jan";
            person.Hello("karol");
            p2.Hello("tedy");

            var warrior = new Wojownik
            {
                name = "rysio"
            };
            var bron = new Weapon();
            bron.setName("siekiera");

            var wojownik2 = new Wojownik();



        }


    }
}
