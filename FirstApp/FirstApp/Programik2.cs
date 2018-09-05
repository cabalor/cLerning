using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    public class SuperSmerf : Smerf
    {

        public void superAttack()
        {

            Console.WriteLine("smerf's punch");
        } 


    }

    class Programik2
    {


        static void Main(String[] args)
        {

            var text = new Text();
            text.Wysokosc = 100;
            text.Kop();



            var dataBase = new DataBase(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);


            dataBase.export();

            installer.install();

            var smerf = new Smerf();







        }


    }
}
