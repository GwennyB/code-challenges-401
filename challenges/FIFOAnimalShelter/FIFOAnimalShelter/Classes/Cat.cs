using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Cat : Animal
    {

        public Cat(string name)
        {
            Species = "cat";
            Name = name;
            Next = null;
        }
    }
}
