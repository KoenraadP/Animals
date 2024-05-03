using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public int Legs { get; set; }
        public bool CanFly { get; set; }
        public int AverageLifeExpectancy { get; set; }

        public Animal(int legs, bool canFly,
            int averageLifeExpectancy)
        {
            Legs = legs;
            CanFly = canFly;
            AverageLifeExpectancy = averageLifeExpectancy;
        }

        // info methode voor animal
        // return voorbeeld: This animal has 4 legs and cannot fly.
        public override string ToString()
        {
            return "This animal has " + Legs.ToString() + " legs and "
                + Flying() + " fly.";
        }

        // methode om can/cannot aan te vullen in de ToString
        private string Flying()
        {
            if (CanFly == true)
            {
                return "can";
            }

            return "cannot";
        } 

    }
}
