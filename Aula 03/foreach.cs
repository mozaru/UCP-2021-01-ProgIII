using System;
using System.Collections.Generic;

public class Foreach
{
   public static void Main()
   {
      int []vet = new int[]{0,1,2,3,4,5,6,7,8,9};	
      /*List<int> list = new List<int>();
      for(int i=0;i<10;i++)
	list.Add(2*i);
      */
      foreach(int x in vet)
         Console.WriteLine("{0}",x);      
   }
}