using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    class Queue
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        public Queue()
        {
            Front = null;
            Rear = null;
        }

        public void Enqueue(Animal newAnimal)
        {
            if(Rear != null)
            {
                Rear.Next = newAnimal;
            }
            if(Front == null)
            {
                Front = newAnimal;
            }
            Rear = newAnimal;
        }

        public Animal Dequeue()
        {
            Animal temp = null;
            temp = Front;
            try
            {
                Front = Front.Next;
                temp.Next = null;
                if (Front == null)
                {
                    Rear = null;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The shelter is empty!");
            }
            return temp;
        }

        public Animal Peek()
        {
            return Front;
        }
    }
}
