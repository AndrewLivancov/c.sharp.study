using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int x = 100 + 50;
      Console.WriteLine(x);
      int sum1 = 100 + 50;
      int sum2 = sum1 + 250;
      int sum3 = sum2 + sum2;
Console.WriteLine(sum1);
Console.WriteLine(sum2);
Console.WriteLine(sum3);
x += 50;
Console.WriteLine(x);
Console.WriteLine(Math.Max(5, 10));
Console.WriteLine(Math.Min(5, 10));
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Abs(-4.7));
Console.WriteLine(Math.Round(9.99));
string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);
string text = "Hello World";
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.ToLower());
string firstName = "John ";
string lastName = "Doe";
string name = firstName + lastName;
Console.WriteLine(name);
string name1 = string.Concat(firstName, lastName);
Console.WriteLine(name1);
string myString = "Hello";
Console.WriteLine(myString[0]);
Console.WriteLine(myString[1]);
Console.WriteLine(myString.IndexOf('e'));
string name3 = "John Doe";
int charPos = name3.IndexOf("D");
string lastName1 = name1.Substring(charPos);
Console.WriteLine(lastName1);
string txta = "We are the so-called \"Vikings\" from the north.";
Console.WriteLine(txta);
string txtb = "It\'s alright.";
Console.WriteLine(txtb);
string txtc = "The character \\ is called backslash.";
Console.WriteLine(txtc);
int q = 10;
int w = 20;
int e = q + w;
Console.WriteLine(e);
string r = "10";
string t = "20";
string u = r + t;
Console.WriteLine(u);
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);
Console.WriteLine(isFishTasty);
Console.WriteLine(x > q);
Console.WriteLine(10 > 9);
Console.WriteLine(x == 200);
Console.WriteLine(10 == 15);
    if (20 > 18) {
Console.WriteLine("20 is greater than 18");
                  }
int i = 20;
int o = 18;
    if (i > o)    {
Console.WriteLine("x is greater than y");
                  }
int time = 20;
if (time < 18)    {
Console.WriteLine("Good day.");
                  } else {
Console.WriteLine("Good evening.");
                  }
int time1 = 22;
if (time < 10)    {
Console.WriteLine("Good morning.");
                  } else if (time < 20) {
Console.WriteLine("Good day.");
                  } else {
Console.WriteLine("Good evening.");
                  }
int time2 = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);

int day = 4;
switch (day)  {
  case 1:
Console.WriteLine("Monaday");
    break;
  case 2:
Console.WriteLine("Tuesday");
    break;
  case 3:
Console.WriteLine("Wednesday");
    break;
  case 4:
Console.WriteLine("Thursday");
    break;
  case 5:
Console.WriteLine("Friday");
    break;
  case 6:
Console.WriteLine("Saturday");
    break;
  case 7:
Console.WriteLine("Sunday");
    break;
              }

    int day1 = 4;
    switch (day1)    {
case 6:
Console.WriteLine("Today is Saturday.");
break;
case 7:
Console.WriteLine("Today is Sunday.");
break;
default:
Console.WriteLine("Looking forward to the Weekend.");
break;
                      }
int p = 0;
while (p < 5) {
  Console.WriteLine(p);
  p++;
              }

            int l = 0;
            do {
Console.WriteLine(l);
l++;
                }
            while (l < 5);
      for (int s = 0; s < 5; s++) {
Console.WriteLine(s);
                                  }

      for (int d = 0; d <= 10; d = d +2) {
Console.WriteLine(d);
                                          }

string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
foreach (string f in cars) {
  Console.WriteLine(f);
                            }

      for (int g = 0; g <= 10; g++) {
        if (g == 4) {
          continue;
                    }
Console.WriteLine(g);
                                      }

      int h = 0;
      while (h < 10) {
Console.WriteLine(h);
h++;
if (h == 4) {
        break;
            }
                      }

int j = 0;
while (j < 10) {
if (j == 4) {
  j++;
  continue;
            }
Console.WriteLine(j);
j++;
                }

Console.WriteLine(cars[0]);
cars[0] = "Opel";
Console.WriteLine(cars[0]);
Console.WriteLine(cars.Length);
for (int k = 0; k < cars.Length; k++) {
  Console.WriteLine(cars[k]);
                                      }

  foreach (string k in cars) {
    Console.WriteLine(k);
                              }
    }
  }
}
