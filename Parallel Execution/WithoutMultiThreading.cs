// Source: https://www.youtube.com/watch?v=Fzckqczmgd0

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class ThreadingDemo
{
   public static void Main()
   {
		Function1();
	    Function2();
   }
	
	private static void Function1()
	{
		for(int i =0;i<=10;i++)
		{
			Console.WriteLine("Function 1 Executing {0}",i);
		}
	}	
	
	private static void Function2()
	{
		for(int i =0;i<=10;i++)
		{
			Console.WriteLine("Function 2 Executing {0}",i);
		}
	}
}

/*
  Without multi threading implementation, the following output is determines synchrous/sequential operation
  Once Function1 completes then only Function2 call
  Output:
  unction 1 Executing 0
Function 1 Executing 1
Function 1 Executing 2
Function 1 Executing 3
Function 1 Executing 4
Function 1 Executing 5
Function 1 Executing 6
Function 1 Executing 7
Function 1 Executing 8
Function 1 Executing 9
Function 1 Executing 10
Function 2 Executing 0
Function 2 Executing 1
Function 2 Executing 2
Function 2 Executing 3
Function 2 Executing 4
Function 2 Executing 5
Function 2 Executing 6
Function 2 Executing 7
Function 2 Executing 8
Function 2 Executing 9
Function 2 Executing 10
*/
