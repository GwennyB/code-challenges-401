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
            newAnimal.Next = Rear;
            Rear = newAnimal;
            if(Front == null)
            {
                Front = newAnimal;
            }
        }

        public Animal Dequeue()
        {
            Animal temp = new Animal();
            temp = Front;
            try
            {
                Front = Front.Next;
                temp.Next = null;
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
