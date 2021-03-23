
using System;
using System.Collections.Generic;

public class Foreach
{
   public static void Main(String []args)
   {
      Console.WriteLine("argumentos:");
      foreach(String x in args)
         Console.WriteLine("{0}",x);      
   }
}