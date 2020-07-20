using System;

namespace MyApplication
{
  // Interface
  interface Ianimal
  {
    void animalSound(); // interface method
  }
// Pig "implements" the Ianimal interface
class Pig : Ianimal
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
      Pig myPig = new Pig(); // Crete a Pig object
      myPig.animalSound();
    }
  }
}
