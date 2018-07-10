using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp

    
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person(string fn, string ln)
        {
            this.firstName = fn;
            this.lastName = ln;
        }


        public void personOut()
        {
            Console.WriteLine("jestem " + firstName + " " + lastName);
        }
    }
}
