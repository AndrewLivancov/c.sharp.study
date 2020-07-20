using System;

namespace MyApplication
{
  class Program
  {
    enum Months
    {
      January,
      February,
      March=6,
      April,
      May,
      June,
      July
    }
    static void Main(string[] args)
    {
      int myNum = (int) Months.April;
      Console.WriteLine(myNum);
    }
  }
}
