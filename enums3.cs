using System;

namespace MyApplication
{
  class Program
  {
    enum Months
    {
      January, // 0
      February, // 1
      March,
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
