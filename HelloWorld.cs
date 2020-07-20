using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    Console.WriteLine("Hello World!");
    long myNum = 1500000000000000L;
    Console.WriteLine(myNum);
    float myNu = 5.75F;
    Console.WriteLine(myNu);
    double myN = 19.99D;
    Console.WriteLine(myN);
    float f1  = 35e3F;
    double d1 = 12E4D;
    Console.WriteLine(f1);
    Console.WriteLine(d1);
    bool isCSharpFun = true;
    bool isFishTasty = false;
    Console.WriteLine(isCSharpFun);
    Console.WriteLine(isFishTasty);
    char myGrade = 'B';
    Console.WriteLine(myGrade);
    string greeting = "Hello World!\n";
    Console.Write(greeting);
    int myInt = 9;
    double myDouble = myInt;
    Console.WriteLine(myInt);
    Console.WriteLine(myDouble);
    double myDoubl = 9.78;
    int myIn = (int) myDoubl;
    Console.WriteLine(myDoubl);
    Console.WriteLine(myIn);
    int my = 10;
    double myDou = 5.25;
    bool myBool = true;
Console.WriteLine(Convert.ToString(my));
Console.WriteLine(Convert.ToDouble(my));
Console.WriteLine(Convert.ToInt32(myDou));
Console.WriteLine(Convert.ToString(myBool));
    }
  }
}
