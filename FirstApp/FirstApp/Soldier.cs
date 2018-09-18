using System;

namespace FirstApp
{
    public abstract class Soldier
    {
        public String rank { get; set; }

        public abstract void rankUp();

        public void deRank()
        {
            Console.WriteLine("you have lost military rank ");
        }
        

        


    }
}
