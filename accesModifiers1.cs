using System;

namespace MyApplication
{
  class Car
  {
    private string model = "Mustang";

    static void Main(string[] args)
    {
      Car myObj = new Car();
      Console.Write(myObj.model);
    }
  }
}
