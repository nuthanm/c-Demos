// Foreground threads are default threads, Which executes even application quit
// Background threads active untill application is running, If application stops/quit then these threads are going to close state

using System;
using System.Threading;

public class ThreadingDemo
{
   public static void Main()
   {
	   // Convert this sequential calling to Parallel execution using Threads
		// Function1();
	    // Function2();
	   
	   Thread obj1 = new Thread(Function1);
	   Thread obj2 = new Thread(Function2); 
	   
	   // Invoking these threads
	   obj1.Start();
	   obj2.Start();
   }
	
	private static void Function1()
	{
		for(int i =0;i<=10;i++)
		{
			Console.WriteLine("Function 1 is on this thread: {0} and current iteration is : {1}", Thread.CurrentThread.ManagedThreadId,  i);
			Thread.Sleep(4000); // 4 * 1000
		}
	}	
	
	private static void Function2()
	{
		for(int i =0;i<=10;i++)
		{
			Console.WriteLine("Function 2 is on this thread: {0} and current iteration is : {1}", Thread.CurrentThread.ManagedThreadId, i);
			Thread.Sleep(4000); // 4 * 1000
		}
	}
}

/*
  This code is working on different threads but not parallel, which means once Function1 completes then only Function2 called
  Output:
Function 1 is on this thread: 328 and current iteration is : 0
Function 1 is on this thread: 328 and current iteration is : 1
Function 1 is on this thread: 328 and current iteration is : 2
Function 1 is on this thread: 328 and current iteration is : 3
Function 1 is on this thread: 328 and current iteration is : 4
Function 1 is on this thread: 328 and current iteration is : 5
Function 1 is on this thread: 328 and current iteration is : 6
Function 1 is on this thread: 328 and current iteration is : 7
Function 1 is on this thread: 328 and current iteration is : 8
Function 1 is on this thread: 328 and current iteration is : 9
Function 1 is on this thread: 328 and current iteration is : 10
Function 2 is on this thread: 327 and current iteration is : 0
Function 2 is on this thread: 327 and current iteration is : 1
Function 2 is on this thread: 327 and current iteration is : 2
Function 2 is on this thread: 327 and current iteration is : 3
Function 2 is on this thread: 327 and current iteration is : 4
Function 2 is on this thread: 327 and current iteration is : 5
Function 2 is on this thread: 327 and current iteration is : 6
Function 2 is on this thread: 327 and current iteration is : 7
Function 2 is on this thread: 327 and current iteration is : 8
Function 2 is on this thread: 327 and current iteration is : 9
Function 2 is on this thread: 327 and current iteration is : 10

To see parallel then use Thread.Sleep(<Milliseconds>)
Function 1 is on this thread: 328 and current iteration is : 0
Function 2 is on this thread: 329 and current iteration is : 0
Function 2 is on this thread: 329 and current iteration is : 1
Function 1 is on this thread: 328 and current iteration is : 1
*/
