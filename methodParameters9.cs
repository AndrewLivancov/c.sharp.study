using System;

namespace MyApplication
{
  class Program
  {
    static void MyMethod(string child1 = "Liam",
    string child2 = "Jenny", string child3 = "John")
    {
      Console.WriteLine(child3);
    }
static void Main(string[] args)
    {
      MyMethod("child3");
    }
  }
}
