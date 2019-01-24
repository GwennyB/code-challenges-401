using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Animal
    {
        public string Name { get; set; }
        public Animal Next { get; set; }
        public string Species { get; set; }

        public Animal()
        {
            Next = null;
        }
    }
}
