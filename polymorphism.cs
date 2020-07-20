using System;

namespace MyApplication
{

  class Animal // Base class (parent)
  {
    public void animalSound()
    {
      Console.WriteLine("The animal makes a sound");
    }
  }

  class Pig : Animal // Derived class (child)
  {
    public void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Dog : Animal // Derived class (child)
  {
    public void animalSound()
    {
      Console.WriteLine("The dog says: bow bow");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Animal myAnimal = new Animal(); // Crete an Animal object
      Animal myPig = new Pig(); // Create a Pig object
      Animal myDog = new Dog(); // Crete a dog object

      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();
    }
  }
}
