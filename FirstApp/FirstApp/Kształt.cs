using System;

namespace FirstApp
{




    public class Kształt
    {

        public int Wysokosc { get; set; }
        public int Szerokosc { get; set; }
        public Pozycja pozycja { get; set; }



        public virtual void Rysuj()
        {
            Console.WriteLine("rysujemy");
        }

    }
}
