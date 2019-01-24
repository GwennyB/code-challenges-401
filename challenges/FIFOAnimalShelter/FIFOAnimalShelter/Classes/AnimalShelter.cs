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

        public AnimalShelter()
        {
            QOne = new Queue();
            QTwo = new Queue();
            Primary = QOne;
            Helper = QTwo;
        }

        public void Enqueue(Animal newAnimal)
        {
            Primary.Enqueue(newAnimal);
        }

        public Animal Dequeue(string pref)
        {
            Animal temp = null;

            if (pref != "dog" && pref != "cat")
            {
                Console.WriteLine($"This shelter doesn't house {pref}s.");
                return temp;
            }
            if (pref == "")
            {
                return Primary.Dequeue();
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
