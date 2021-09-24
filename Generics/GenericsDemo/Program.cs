using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDouble();
            StackStrings();
            Console.ReadLine();
        }

        private static void StackDouble(){
            var stackDouble = new StackDouble();
            stackDouble.Push(1.2);
            stackDouble.Push(2.2);
            stackDouble.Push(3.4);

            while (stackDouble.Count > 0)
            {
                 Console.WriteLine($"Pop Item is : {stackDouble.Pop()}");
            }
        }

        private static void StackStrings()
        {
             var stackDouble = new StackStrings();
            stackDouble.Push("Nani");
            stackDouble.Push("Potti");
            stackDouble.Push("Nani Potti");

            while (stackDouble.Count > 0)
            {
                 Console.WriteLine($"Pop Item is : {stackDouble.Pop()}");
            }
        }
    }
}
