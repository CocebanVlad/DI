using System;

namespace DI.Tests
{
    public class Dog : IAnimal
    {
        public Dog(IAnimalOwner owner)
        {
            Console.WriteLine(owner.Name + " has a dog");
        }

        /// <summary>
        /// Make animal specific sound
        /// </summary>
        public void MakeSound()
        {
            Console.WriteLine("Waf waf...");
        }
    }
}
