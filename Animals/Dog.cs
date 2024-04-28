using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(int legs, bool canFly,
            int averageLifeExpectancy, string breed) : base(legs,
                canFly, averageLifeExpectancy)
        {
            Breed = breed;
        }
    }
}
