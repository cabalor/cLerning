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

    class Ludzik {

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

            var ar1 = new int[3] { 1, 2, 3 };
            var ar2 = ar1;

            for (int x = 0; x < ar2.Length; x++)
            {
                ar2[x]++;
            }

            Console.WriteLine(string.Format("pierwszy: {0}, drugi: {1}, trzeci:{2}", ar1[0], ar1[1], ar1[2]));
            Console.WriteLine(string.Format("pierwszy: {0}, drugi: {1}, trzeci:{2}", ar2[0], ar2[1], ar2[2]));


            var ludek = new Ludzik { wiek = 20 };


            var rok = Rok.jesien;

            switch (rok)
            {
                case Rok.wiosna:
                    Console.WriteLine("mamy wiosen");
                    break;
                case Rok.jesien:
                    Console.WriteLine("mamy jesien");
                    break;
            }


            int dana = 6;

            if (dana > 7)
            {
                Console.WriteLine("jestem duza");
            }
            else
            {
                Console.WriteLine("jestem mala");
            }


            for (int gg = 1; gg < 10; gg++) {
                if(gg%2 == 0)
                {
                    Console.WriteLine(gg);
                }

            }
            for (int gg = 10; gg > 0; gg--)
            {
                if (gg % 2 == 0)
                {
                    Console.WriteLine(gg);
                }

            }


            var imie = "ziomus";
            for(int gg =0; gg< imie.Length; gg++)
            {
                Console.WriteLine(imie[gg]);
            }
            Console.WriteLine(" ");
            foreach(char litera in imie)
            {
                Console.WriteLine(litera);
            }

            var liczby = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17 };

            foreach (int liczba in liczby)
            {
                Console.WriteLine(liczba);
            }

            var licz = 0;
            
            while(licz < 10)
            {
                Console.WriteLine(licz);
                licz++;

            }
            Boolean xx = true;
            while(xx == true)
            {
                Console.WriteLine("wpisz cos");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("wpisałeś dupe nic sie nie dzieje ");
                } else
                {
                    Console.WriteLine("wpisales ladnie "+input);
                    xx = false;
                
                }
            }


            var rnd = new Random();

            for (var t = 0; t < 5; t++)
            {
                rnd.Next(0, 50);
            }
            Console.Write((char)rnd.Next(122, 221));
            Console.WriteLine(" pusta linia \n");
            Console.Write((char)('a' + rnd.Next(0, 26)));


            const int lengtth = 8;
            char[] characters = new char[lengtth];

            for (var z = 0; z < lengtth; z++)
            {
                characters[z] = (char)('a'+rnd.Next(0, 26));
            }
            var pass = new String(characters);

            Console.WriteLine(pass);


        }
    }
}
