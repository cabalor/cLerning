using System;

namespace FirstApp
{

    public class BoxController : UserController, IDrage, IDrop
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }

        public void drop()
        {
            throw new NotImplementedException();
        }
    }


    public class UserController
    {

        public int Id { get; set; }
        public Size Size { get; set; }

    
        public void Wypisuje()
        {
            Console.WriteLine("wypisanie");
        }

    }
}

