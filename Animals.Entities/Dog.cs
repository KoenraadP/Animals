using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    // overerven van Animal
    public class Dog : Animal
    {

        // extra property voor breed (ras)
        public string Breed { get; set; }

        // constructor waarbij alle properties van Dog ingevuld worden
        public Dog(int legs, bool canFly, 
            int avgLifeExpect, string breed) : base (legs, canFly,
                avgLifeExpect)
        {
            Breed = breed;
        }

    }
}
