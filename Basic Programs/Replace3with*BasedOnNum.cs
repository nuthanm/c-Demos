using System;
using System.Text;

namespace NaniLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i<=number;i++)
            {
                if(i%3 == 0)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(i);
                }
            }

            Console.WriteLine(sb.ToString());
            
        }
    }
}
