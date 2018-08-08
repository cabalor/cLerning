using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Wojownik
    {
        public string name;
        public int weigth;
        public List<Weapon> bron;


        public Wojownik()
        {
            bron = new List<Weapon>();
        }

        /*public Wojownik(string name)
            :this() // this will call a default constructor, the one withour parametrs
        {
            this.name = name;
        }

        public Wojownik(string name, int weigth)
            :this(name)
        {
            this.weigth = weigth;
        }*/

    }
}
