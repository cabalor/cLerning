using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{



    class Programik3
    {

        static void Main(String[] args)
        {

            //var orderProcess = new OrderProcessor(new ShipCalc());
            //var order = new Order { };
            //orderProcess.Process(order);

            var migrator = new Migrator(new ConsoleLoger());
            migrator.Migrate();

            /*var sum = 0;
            int[,] tab = {{1 ,2 ,3 },{1 ,2 ,3 }, {1 ,2 ,3 } };

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    sum += tab[i][j];
                }
            }

            foreach(int i in tab)
            {
                sum += i;
            }

            Console.WriteLine(sum);*/

        }



    }
}

