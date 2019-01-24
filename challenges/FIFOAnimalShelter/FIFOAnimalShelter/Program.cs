using System;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {

            AnimalShelter shelter = new AnimalShelter();
            FIFOAnimalShelter(shelter);

            Console.ReadLine();
        }

        /// <summary>
        /// demonstrates Enqueue and Dequeue behaviors for standard and edge cases
        /// </summary>
        /// <param name="shelter"> AnimalShelter object (empty) to test behaviors </param>
        static void FIFOAnimalShelter(AnimalShelter shelter)
        {
            Console.WriteLine("*** EMPTY SHELTER ***");
            Console.WriteLine("Retrieve dog from empty shelter:");
            shelter.Dequeue("dog");

            Console.WriteLine("Retrieve cat from empty shelter:");
            shelter.Dequeue("cat");

            Console.WriteLine("\n*** ADD SOME CRITTERS TO THE SHELTER ***");
            Dog rocket = new Dog("Rocket");
            Cat bart = new Cat("Bart");
            Dog bandit = new Dog("Bandit");
            Cat bongo = new Cat("Bongo");
            Dog zuni = new Dog("Zuni");
            shelter.Enqueue(rocket);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter.");
            shelter.Enqueue(bart);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter.");
            shelter.Enqueue(bandit);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter.");
            shelter.Enqueue(bongo);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter.");
            shelter.Enqueue(zuni);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} the {shelter.Primary.Rear.Species} to the shelter.");

            Console.WriteLine("\n*** HOST AN ADOPT-A-PET DAY IN THE WENDY'S PARKING LOT ***");

            Animal adopted = shelter.Dequeue("dog");
            Console.WriteLine($"{adopted.Name} the {adopted.Species} has been adopted! {shelter.Primary.Front.Name} the {shelter.Primary.Front.Species} is first in line.");
            adopted = shelter.Dequeue("dog");
            Console.WriteLine($"{adopted.Name} the {adopted.Species} has been adopted! {shelter.Primary.Front.Name} is first in line.");
            adopted = shelter.Dequeue("cat");
            Console.WriteLine($"{adopted.Name} the {adopted.Species} has been adopted! {shelter.Primary.Front.Name} the {shelter.Primary.Front.Species} is first in line.");

            Console.WriteLine("\n*** SOMEONE WANTS A PET-GRAB-BAG ***");
            adopted = shelter.Dequeue("");
            Console.WriteLine($"{adopted.Name} the {adopted.Species} has been adopted! {shelter.Primary.Front.Name} is first in line.");

            Console.WriteLine("\n*** A TEENAGER WANTS A BABBOON ***");
            adopted = shelter.Dequeue("babboon");
        }
    }
}
