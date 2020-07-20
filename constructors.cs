using System;

namespace MyApplication
{
  // Create a Car class
  class Car
  {
    public string model; // Create a fieald
    // Create a class constructor for the Car class
    public Car()
    {
      model = "Mustang"; // Set the initial value for model
    }

        static void Main(string[] args)
    {
      Car Ford = new Car();
      Console.WriteLine(Ford.model);
    }
  }
}
