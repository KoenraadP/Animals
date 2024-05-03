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

            // dier aanmaken dat 3 poten heeft, wel kan vliegen en gemiddeld 5 jaar leeft
            Animal a = new Animal(3, true, 5);

            // hond aanmaken, vrije keuze!
            Dog d = new Dog(4, false, 1, "Labrador");

            // info over vreemd dier en hond in console plaatsen
            Console.WriteLine(a);
            Console.WriteLine(d);

            Console.WriteLine(Zoo.Name);
            Console.WriteLine(Zoo.Location);

            Zoo.Animals = new List<Animal> { a, d};

            // readline om het programma nog even te laten wachten
            Console.ReadLine();
        }
    }
}
