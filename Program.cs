using System;
using System.Collections.Generic;
using PingPong.Models;

namespace PingPong 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      string stringInput = Console.ReadLine();
      int numInput = int.Parse(stringInput);

      List<int> NumbersInputted = new List<int>{};

      // foreach (int number in NumbersInputted)
      // {
      //   if (numInput >= NumbersInputted(number)); 
      //   return NumbersInputted.Add(numInput);
      // }
      //   Console.WriteLine(NumbersInputted);
      
      for (int i = 1; i <= numInput; i++) {
          NumbersInputted.Add(i);
          Console.WriteLine(i);
      }
      Console.WriteLine(List(NumbersInputted));
    }
  }
}