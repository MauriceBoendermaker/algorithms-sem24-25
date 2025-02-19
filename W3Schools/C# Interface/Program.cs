using System;
using System.Net;

namespace Interface
{
    interface IAnimal
    {
        void animalSound(); // interface method (thus without body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig(); // Create a pig object
            myPig.animalSound();
        }
    }
}