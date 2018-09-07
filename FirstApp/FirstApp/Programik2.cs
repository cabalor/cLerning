using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{

    class Programik2
    {


        static void Main(String[] args)
        {

            /*var text = new Text();
            text.Wysokosc = 100;
            text.Kop();



            var dataBase = new DataBase(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);


            dataBase.export();

            installer.install();

            var smerf = new Smerf();*/




            var car = new Car(123);

            var test1 = Test.testWithName("test 1");

            Console.WriteLine(test1.toString());





        }


    }
}
