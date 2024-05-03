using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Bird : Animal
    {
        public string[] Colors { get; set; }

        public Bird(int legs, bool canFly, int avgLifeExpect, string[] colors) : base(legs, canFly, avgLifeExpect)
        {
            Colors = colors;
        }

        public string Talk()
        {
            return "Tweet! Tweet!";
        }
    }
}
