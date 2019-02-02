using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        /// <summary>
        /// constructs Cat object with specified name and pointing at null
        /// </summary>
        /// <param name="name"> new cat's name </param>
        public Cat(string name)
        {
            Species = "cat";
            Name = name;
            Next = null;
        }
    }
}
