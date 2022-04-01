using System;
using System.Collections.Generic;
using System.Text;

namespace NaniLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            //your code goes here
            int len = words.Length;
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i<len;i++)
            {
                if(words[i].Contains(letter))
                {
                    sb.Append(words[i]);
                }
            }
            
            if(sb.Length == 0)
            {
                Console.WriteLine("No match");
            }
            Console.WriteLine(sb.ToString());
            
        }
    }
}
