using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int sum1 = 100 + 50;   
      int sum2 = sum1 + 250;  
      int sum3 = sum2 + sum2; 
      Console.WriteLine(sum1);
      Console.WriteLine(sum2);
      Console.WriteLine(sum3);
     }
  }
}