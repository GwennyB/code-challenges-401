using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Queue
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

        /// <summary>
        /// constructs new empty Queue object and points both Front and Rear at null
        /// </summary>
        public Queue()
        {
            Front = null;
            Rear = null;
        }

        /// <summary>
        /// adds new animal to Rear of queue
        /// </summary>
        /// <param name="newAnimal"> animal to be added </param>
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

        /// <summary>
        /// removes and returns animal at Front of queue
        /// </summary>
        /// <returns> animal at Front, or null if empty queue </returns>
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

        /// <summary>
        /// returns the animal at the Front of the queue
        /// </summary>
        /// <returns> animal at Front of queue </returns>
        public Animal Peek()
        {
            return Front;
        }
    }
}
