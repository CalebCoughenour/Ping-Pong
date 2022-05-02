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

      List<string> ListArray = new List<string>{};
      
      for (int i = 1; i <= numInput; i++) {
        if (i % 3 == 0 && i % 5 == 0)
        {
          string j = i.ToString();
          j = "Ping-Pong";
          ListArray.Add(j);
        }
        else if (i % 3 == 0)
        {
          string j = i.ToString();
          j = "Ping";
          ListArray.Add(j);
        }
        else if (i % 5 == 0)
        {
          string j = i.ToString();
          j = "Pong";
          ListArray.Add(j);
        }
        else
        {
          string j = i.ToString();
          ListArray.Add(j);
        } 
      }
      ListArray.ForEach(Console.WriteLine);
    }
  }
}


