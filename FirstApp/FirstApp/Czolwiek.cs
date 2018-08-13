using System;

namespace FirstApp
{
    public class Czolwiek
    {
        private String imie;

        public String getImie()
        {
            return imie;
        }

        public void setImie(String imie)
        {
            this.imie = imie;
        }
        public DateTime urodziny { get; set; }

        public int wiek {

            get { var roznica = DateTime.Today - urodziny;
                var lata = roznica.Days / 365;
                return lata;
            }

        }


        public Czolwiek(DateTime uro)
        {
            urodziny = uro;
        }




        public override String ToString()
        {
            return "imie " + imie;
        }


    }
}
