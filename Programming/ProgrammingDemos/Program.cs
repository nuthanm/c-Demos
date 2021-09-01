using System;
using System.Text;

namespace ProgrammingDemos
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Dvd[] dvdCollection = new Dvd[15];
            // Dvd naniLovesPotti = new Dvd("NaniLovesPotti",2021, "Nani");
            // dvdCollection[9] = naniLovesPotti;
            
            // // Console.WriteLine(dvdCollection[8]);

            // #region ArrayofSquareIntegers
            // int[] squres = new int[9];

            // for(int i =0 ;i < 9; i++)
            // {
            //     squres[i] = (i*i);
            // }

            // foreach(int square in squres)
            // {
            //     Console.WriteLine($"Value of square: {square}");
            // }
            // #endregion

            // // Read Movies from an array
            // foreach(var movie in dvdCollection)
            // {
            //     Console.WriteLine( dvdCollection[9] );
            // }

        string s1 = "abc*";
        string s2 = "abd*";

        var result = CompareStrings(s1,s2);
        
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