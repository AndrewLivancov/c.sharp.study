using System;

namespace MyApplication
{
  class Program
    {
      static void MyMethod(string country = "Norway")
      {
        Console.WriteLine(country);
      }
  static void Main(string[] args)
    {
    MyMethod("Sweden");
    MyMethod("India");
    MyMethod();
    MyMethod("USA");
      }
    }
}
