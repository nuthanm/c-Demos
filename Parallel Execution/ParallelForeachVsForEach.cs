/* Source I learned it from this video: https://www.youtube.com/watch?v=lzRKWzvLgME */
/* Main Difference between Parallel.ForEach vs ForEach
   ForEach works on same thread and order of values in same.
   Parallel.ForEach works on multiple threads and order of values, not in the same way
   Execution time: traditional foreach is bit faster than Parallel.ForEach, Parallel.ForEach => Variable time which may fast sometimes than traditioanl foreach.
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

public class ParallelForEachVsForEach
{
   public static void Main()
   {
	   string[] names = {"Nani","Potti","Nuthan","Ramya"};
	   
	   // Using traditional foreach
	   var sw = Stopwatch.StartNew();
	   foreach(var name in names)
	   {
		   Console.WriteLine("Name:{0} and current thread:{1}", name, Thread.CurrentThread.ManagedThreadId);
	   }
	   Console.WriteLine("Total number of milliseconds to complete his process:{0}", sw.Elapsed.Milliseconds);
	   
	   // Using Parallel.ForEach
	   sw = Stopwatch.StartNew();
	   Parallel.ForEach(names, name =>
	   {
		   Console.WriteLine("Name:{0} and current thread:{1}", name, Thread.CurrentThread.ManagedThreadId);
		   Thread.Sleep(10);
	   });
	   Console.WriteLine("Total number of milliseconds to complete his process:{0}", sw.Elapsed.Milliseconds);
	   Console.ReadLine();
   }
}
