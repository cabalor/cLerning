using System;

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
}
