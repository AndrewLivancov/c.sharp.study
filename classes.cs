using System;

namespace MyApplication
{
  class Car
  {
    string color = "red";

static void Main(string[] args)
    {
      Car myObj = new Car();
      Car myObj2 = new Car();
      Console.WriteLine(myObj.color);
      Console.WriteLine(myObj2.color);
    }
  }
}
