using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal static class Zoo
    {
        public static string Name = "Creo";
        public static string Location = "Scheutistenlaan 12, 8500 Kortrijk";
        public static string Logo { get; set; }
        public static List<Animal> Animals { get; set; }
    }
}
