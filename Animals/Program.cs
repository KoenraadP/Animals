using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(3,true,5);
            Dog d = new Dog(4,false,60, "Duitse Herder");

            Console.WriteLine(a);
            Console.WriteLine(d);
        }
    }
}
