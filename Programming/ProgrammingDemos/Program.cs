using System;
using System.Text;

namespace ProgrammingDemos
{
    class Program
    {
        static void Main(string[] args)
        {           

        var gcd = CalcuateGCD(20,8);
        Console.WriteLine($"GCD of 20 & 8 is {gcd}");


        gcd = CalcuateGCD(6,10);
        Console.WriteLine($"GCD of 6 & 10 is {gcd}");


        // string s1 = "abc*";
        // string s2 = "abd*";

        // var result = CompareStrings(s1,s2);
        
        }

        private static int CalcuateGCD(int a, int b)
        {
            // int r = -1;
            // while(r != 0) // -1!=0 => 4!=0
            // {
            //     if(a > b) // 20 > 8 => 8 > 4
            //     {   
            //         r = (a % b) == 0 ? 0 : (a % b); // 20%8 <> 0 => r = 4 ; 8%4 == 0 => r=4      
            //         if(r!=0)
            //         {
            //             a = b; // a = 20 => 8 => 4                    
            //             b = r; // 8 => 4 =>4
            //         }
            //     }
            // }
            int temp;
            while(b != 0) // 8!=0 => 4!=0 => 0!=0 (Stop and result is 2)
            {
                temp = a; // 20 => 8
                a = b; // 8 => 4
                b = temp % b; // 20 % 8 <> 0 => 4 => 8 % 4 == 0
            }
            return a;
        }

        private static bool CompareStrings(string s1, string s2)
        {
            string s1String = "";
            string s2String = "";

            s1String = Process(s1);
            s2String = Process(s2);

            if(s1String.Equals(s2String))
            {
                return true;
            }

            return false;
        }

        private static string Process(string str)
        {                        
            int index = 0;

            while(index != -1)
            {
                index = str.IndexOf('*');

                if(index != -1)
                { 
                    str = str.Remove(index);
                    if(index > 0)
                    {
                        str = str.Remove(index - 1); 
                    }
                }
            }

            return str;
        }
    }
}


// *abc
// index = 0 
// str = abc => bc
// str = ab

// a*c*b 
// index = 0 => 1 => 1
// str = *c*b => c*b => *b => b

// abc
// index = -1


// ****