using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Punkt
    {
        public int x;
        public int y;


        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public void ruch(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ruch(Punkt zmianaLokacji)
        {
            try
            {
                ruch(zmianaLokacji.x, zmianaLokacji.y);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Source);


            }
        }

        public void ruchDrugi(Punkt zmianaLokacji)
        {
            if (zmianaLokacji == null)
            {
                throw new ArgumentNullException("dno pusta wartosc");
            }
            ruch(zmianaLokacji.x, zmianaLokacji.y);
        }

    }
}
