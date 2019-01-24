using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Dog : Animal
    {
        /// <summary>
        /// constructs Dog object with specified name and pointing at null
        /// </summary>
        /// <param name="name"> new dog's name </param>
        public Dog(string name)
        {
            Species = "dog";
            Name = name;
            Next = null;
        }

    }
}
