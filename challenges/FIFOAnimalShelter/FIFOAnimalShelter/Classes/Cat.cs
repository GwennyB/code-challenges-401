using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Cat : Animal
    {

        public Cat(string name)
        {
            Name = name;
            Next = null;
        }
    }
}
