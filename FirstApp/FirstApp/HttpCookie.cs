using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{


    class HttpCookie
    {

        private readonly Dictionary<String, String> slownik; //ma hashtable, tylko raz sie inicjalizuje


        public HttpCookie()
        {

            slownik = new Dictionary<string, string>();
        }

       
        public string this[string key]
        {
            get { return slownik[key]; }
            set { slownik[key] = value; }
        
        }



    }
}
