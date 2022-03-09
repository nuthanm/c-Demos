using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class TimeSlicingVsTPL
{
   public static void Main()
   {
	   // var sw = Stopwatch.StartNew();
	   // Thread t1 = new Thread(RunMillionIterations);
	   // t1.Start();
	   // Console.WriteLine("Thread: {0} and total time to complete without TPL: {1} milliseconds",Thread.CurrentThread.ManagedThreadId, sw.Elapsed.TotalMilliseconds);
	   
	   var sw = Stopwatch.StartNew();
	   Parallel.For(0,1000000, x=> RunMillionIterations());
	   Console.WriteLine("Thread: {0} and total time to complete with TPL: {1} milliseconds",Thread.CurrentThread.ManagedThreadId, sw.Elapsed.TotalMilliseconds);
	   
	   Console.ReadLine();
   }
	
   private static void RunMillionIterations()
   {
	string s = string.Empty;
	for(int i =0;i<=1000000;i++)
	{		
	   s+=i;			
	}
   }
}
