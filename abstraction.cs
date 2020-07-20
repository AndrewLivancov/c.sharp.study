using System;

namespace MyApplication
{
  // Abstract class
  abstract class Animal
  {
    // Abstract method does not have body
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
      Console.WriteLine("Zzz");
    }
  }

  // Derived class (Inherit from animal)
  class Pig : Animal
  {
    public override void animalSound()
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee weee");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pig myPig = new Pig(); // Create a Pig object
      myPig.animalSound();
      myPig.sleep();
    }
  }
}
