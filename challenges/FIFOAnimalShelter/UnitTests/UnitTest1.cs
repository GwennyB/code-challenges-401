using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace UnitTests
{
    public class UnitTest1
    {
        // ANIMAL SHELTER CONSTRUCTOR
        /// <summary>
        /// verifies constructor builds object of proper type
        /// </summary>
        [Fact]
        public void AnimalShelter_ConstructsAnimalShelterObject()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.IsType<AnimalShelter>(shelter);
        }

        /// <summary>
        /// verifies constructor creates new QOne of type 'Queue'
        /// </summary>
        [Fact]
        public void AnimalShelter_BuildsQOne()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.IsType<Queue>(shelter.QOne);
        }

        /// <summary>
        /// verifies constructor creates new QOne of type 'Queue'
        /// </summary>
        [Fact]
        public void AnimalShelter_BuildsQTwo()
        {
            AnimalShelter shelter = new AnimalShelter();
            Assert.IsType<Queue>(shelter.QTwo);
        }


        // ANIMAL SHELTER ENQUEUE
        /// <summary>
        /// verifies Enqueue adds new Dog to empty queue
        /// </summary>
        [Fact]
        public void Enqueue_AddsToEmptyShelterQueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog dog = new Dog("Puppers");
            shelter.Enqueue(dog);
            Assert.Equal("Puppers", shelter.QOne.Front.Name);
        }

        /// <summary>
        /// verifies Enqueue adds new Cat to rear of populated queue
        /// </summary>
        [Fact]
        public void Enqueue_AddsToRearOfNonEmptyShelterQueue()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog dog = new Dog("Puppers");
            shelter.Enqueue(dog);
            Cat cat = new Cat("Catters");
            shelter.Enqueue(cat);
            Assert.Equal("Catters", shelter.QOne.Rear.Name);
        }

        /// <summary>
        /// verifies Enqueue adds to queue without disrupting order
        /// </summary>
        [Fact]
        public void Enqueue_HoldsPlaceInLine()
        {
            AnimalShelter shelter = new AnimalShelter();
            Dog dog = new Dog("Puppers");
            shelter.Enqueue(dog);
            Cat cat = new Cat("Catters");
            shelter.Enqueue(cat);
            Assert.Equal("Puppers", shelter.QOne.Front.Name);
        }


        // ANIMAL SHELTER DEQUEUE
        /// <summary>
        /// verifies that Dequeue finds and returns first dog in line when it isn't at the front
        /// </summary>
        [Fact]
        public void Dequeue_ReturnsFirstDogWhenNotAtFrontOfLine()
        {
            AnimalShelter shelter = new AnimalShelter();
            Cat catters = new Cat("Catters");
            shelter.Enqueue(catters);
            Cat alley = new Cat("Alley");
            shelter.Enqueue(alley);
            Dog puppers = new Dog("Puppers");
            shelter.Enqueue(puppers);
            Dog doggo = new Dog("Doggo");
            shelter.Enqueue(doggo);
            Assert.Equal("Puppers", shelter.Dequeue("dog").Name);
        }

        // ANIMAL SHELTER DEQUEUE
        /// <summary>
        /// verifies that Dequeue finds and returns first cat in line when it is at the front
        /// </summary>
        [Fact]
        public void Dequeue_ReturnsFirstCatWhenAtFrontOfLine()
        {
            AnimalShelter shelter = new AnimalShelter();
            Cat catters = new Cat("Catters");
            shelter.Enqueue(catters);
            Cat alley = new Cat("Alley");
            shelter.Enqueue(alley);
            Dog puppers = new Dog("Puppers");
            shelter.Enqueue(puppers);
            Dog doggo = new Dog("Doggo");
            shelter.Enqueue(doggo);
            Assert.Equal("Catters", shelter.Dequeue("cat").Name);
        }

        // ANIMAL SHELTER DEQUEUE
        /// <summary>
        /// verifies that Dequeue returns shelter to its original order after finding and removing an animal
        /// </summary>
        [Fact]
        public void Dequeue_MaintainsOrderAfterDequeue()
        {
            AnimalShelter shelter = new AnimalShelter();
            Cat catters = new Cat("Catters");
            shelter.Enqueue(catters);
            Cat alley = new Cat("Alley");
            shelter.Enqueue(alley);
            Dog puppers = new Dog("Puppers");
            shelter.Enqueue(puppers);
            Dog doggo = new Dog("Doggo");
            shelter.Enqueue(doggo);
            shelter.Dequeue("dog");
            Assert.Equal("Catters", shelter.Primary.Front.Name);
        }

        // ANIMAL SHELTER DEQUEUE
        /// <summary>
        /// verifies that Dequeue finds and returns first cat in line when it is at the front
        /// </summary>
        [Fact]
        public void Dequeue_ReturnsNullWhenInvalidAnimalRequested()
        {
            AnimalShelter shelter = new AnimalShelter();
            Cat catters = new Cat("Catters");
            shelter.Enqueue(catters);
            Cat alley = new Cat("Alley");
            shelter.Enqueue(alley);
            Dog puppers = new Dog("Puppers");
            shelter.Enqueue(puppers);
            Dog doggo = new Dog("Doggo");
            shelter.Enqueue(doggo);
            Assert.Null(shelter.Dequeue("pony"));
        }
    }
}
