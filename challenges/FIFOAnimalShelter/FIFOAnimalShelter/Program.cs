using System;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            // FIFOAnimalShelter();

            AnimalShelter shelter = new AnimalShelter();

            Console.WriteLine("Retrieve dog from empty shelter:");
            shelter.Dequeue("dog");

            Console.WriteLine("Retrieve cat from empty shelter:");
            shelter.Dequeue("cat");

            Console.WriteLine("Add some animals to the shelter:");
            Dog rocket = new Dog("Rocket");
            Cat bart = new Cat("Bart");
            Dog bandit = new Dog("Bandit");
            Cat bongo = new Cat("Bongo");
            Dog zuni = new Dog("Zuni");
            shelter.Enqueue(rocket);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} to the shelter.");
            shelter.Enqueue(bart);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} to the shelter.");
            shelter.Enqueue(bandit);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} to the shelter.");
            shelter.Enqueue(bongo);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} to the shelter.");
            shelter.Enqueue(zuni);
            Console.WriteLine($"Added {shelter.Primary.Rear.Name} to the shelter.");

            Animal adopted = shelter.Dequeue("dog");
            Console.WriteLine($"{adopted.Name} has been adopted! {shelter.Primary.Front.Name} is first in line.");
            adopted = shelter.Dequeue("dog");
            Console.WriteLine($"{adopted.Name} has been adopted! {shelter.Primary.Front.Name} is first in line.");
            adopted = shelter.Dequeue("cat");
            Console.WriteLine($"{adopted.Name} has been adopted! {shelter.Primary.Front.Name} is first in line.");

            Console.ReadLine();
        }

        static void FIFOAnimalShelter()
        {
        }
    }
}
