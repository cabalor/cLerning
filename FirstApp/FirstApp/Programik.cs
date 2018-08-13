﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    public class Klient
    {
        public int id;
        public string imie;
        public int wiek;

        public List<Order> zamowienia = new List<Order>();

        public Klient(int wiek)
        {
            this.wiek = wiek;
        }

        public Klient(int id, string imie, int wiek)
            :this(wiek)
        {
            this.id = id;
            this.imie = imie;
        }
    }


    public class Order{


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


            //var number =  int.Parse("blalal");


            int liczba;
            Boolean b = int.TryParse("blalal", out liczba);

            if (b)
            {
                Console.WriteLine(liczba);
            } else
            {
                Console.WriteLine("problem");
            }


            var czlowien = new Czolwiek(new DateTime(1965, 1, 1));
            czlowien.setImie("turbo");
            Console.WriteLine(czlowien.ToString());
            Console.WriteLine(czlowien.wiek);



            var cook = new HttpCookie();

            cook["jeden"] = "pierwszy";

            Console.WriteLine(cook["jeden"]);





        }

        static void Params()
        {

            var cal = new Calc();

            Console.WriteLine(cal.Add(1, 2, 3));
            Console.WriteLine(cal.Add(1, 2, 3, 5, 6));

            Console.WriteLine(cal.Add(new int[] { 4, 5, 6, 7, 8 }));


        }





        static void Funkcja()
        {
            try
            {

                Punkt pkt = new Punkt(5, 5);
                pkt.ruch(new Punkt(10, 10));

                Console.WriteLine("punkt {0},{1}", pkt.x, pkt.y);


                pkt.ruch(35, 35);

                Console.WriteLine("punkt {0},{1}", pkt.x, pkt.y);

            }
            catch (Exception e)
            {
                Console.WriteLine("problem " + e.Source);

            }
        }


    }
}
