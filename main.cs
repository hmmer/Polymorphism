using System;
using System.Collections.Generic;
using Poly;

class Program 
{
  public static void Main (string[] args) 
  {
      Console.WriteLine("***** Static Polymorphism *****");
      Laptop mac = new Mac();

      // static polymorphism where the method name is same with different parameters
      mac.TurnOn();
      mac.TurnOn(true);

      Console.WriteLine();
      
      Console.WriteLine("***** Dynamic Polymorphism *****");
      List<Laptop> laptops = new List<Laptop>() {new Lenovo(), new Azuz() };
      bool flag = true;
      
      foreach(var laptop in laptops)
      {
          // dynamic polymorphism where we dont which object TurnOn method is being called in the code level
          laptop.TurnOn();
          laptop.TurnOn(flag);
          flag = false;
      }
  }
}