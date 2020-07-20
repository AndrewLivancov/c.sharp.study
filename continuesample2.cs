using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {

//Sort a string
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars) {
  Console.WriteLine(i);
                           }
// Sort an int
int[] myNumbers = {5, 1, 8, 9};
Array.Sort(myNumbers);
foreach (int i in myNumbers) {
Console.WriteLine(i);
                              }
Console.WriteLine(myNumbers.Max());
Console.WriteLine(myNumbers.Min());
Console.WriteLine(myNumbers.Sum());

string[] cars1;
cars1 = new string[] {"Volvo", "BMW", "Ford"};
Console.WriteLine(cars1[0]);
    }
  }
}
