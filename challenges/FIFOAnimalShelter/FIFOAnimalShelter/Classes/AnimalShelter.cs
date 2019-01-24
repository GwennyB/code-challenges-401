using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Queue QOne { get; set; }
        public Queue QTwo { get; set; }

        public Queue Primary { get; set; }
        private Queue Helper { get; set; }

        /// <summary>
        /// constructs a shelter by building 2 queues and pointing Primary and Helper refs at them 
        /// </summary>
        public AnimalShelter()
        {
            QOne = new Queue();
            QTwo = new Queue();
            Primary = QOne;
            Helper = QTwo;
        }

        /// <summary>
        /// adds an animal to the Primary queue
        /// </summary>
        /// <param name="newAnimal"> the Animal to be added </param>
        public void Enqueue(Animal newAnimal)
        {
            Primary.Enqueue(newAnimal);
        }

        /// <summary>
        /// returns the first of specified type in the queue
        /// if none of specified type, returns null
        /// if invalid type, returns null and reports invalid on console
        /// </summary>
        /// <param name="pref"> type of animal requested </param>
        /// <returns> found animal or null </returns>
        public Animal Dequeue(string pref)
        {
            Animal temp = null;

            if (pref == "")
            {
                return Primary.Dequeue();
            }

            if (pref != "dog" && pref != "cat")
            {
                Console.WriteLine($"This shelter doesn't house {pref}s.");
                return temp;
            }

            temp = Primary.Dequeue();

            while(Primary.Front != null && temp.Species != pref)
            {
                Helper.Enqueue(temp);
                temp = Primary.Dequeue();
            }
            while(Primary.Front != null)
            {
                Helper.Enqueue(Primary.Dequeue());
            }

            Queue hold;

            hold = Primary;
            Primary = Helper;
            Helper = hold;

            return temp;
        }
    }
}
