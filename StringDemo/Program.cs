using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Operations demos");
            StringOperations();
        }

        private static void StringOperations()
        {
            StringConversions();
            StringAsArray();
            EscapeString();
            AppendingStrings();
            InterpolationAndLiteral();
            StringBuilderDemo();
            WorkingWithArrays();
            PadAndTrim();
        }

        private static void StringConversions()
        {
            // Declaring a string
            string applyStringOperations = "thIs tExT we USE it FoR many operationsS";

            TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;

            // To set any specific language use the below way.
            TextInfo englishTextInfo = new CultureInfo("en-US", false).TextInfo;

            // Convert this string into lowercase.
            Console.WriteLine(applyStringOperations.ToLower());

            // Convert this string into uppercase.
            Console.WriteLine(applyStringOperations.ToUpper());

            // Convert this string into Capitalize the first letter in the word and except accornyms.
            Console.WriteLine(englishTextInfo.ToTitleCase(applyStringOperations));
        }
        private static void StringAsArray()
        {
            // Declare a string
            string sampleText = "Nani Potti";

            // Access each charecter from a string
            for(int i = 0; i < sampleText.Length;i++)
            {
                Console.WriteLine(sampleText[i]);                
            }

        }
        private static void EscapeString()
        {
            string sampleText = "Hello \"Potti\"";
            Console.WriteLine(sampleText); // Output: Hello "Potti"

            string filePath = "c:\temp\file.txt";
            Console.WriteLine(filePath); // Output: c:      emp♀ile.txt

           filePath = "c:\\temp\\file.txt";
           Console.WriteLine(filePath); // Output:  c:\temp\file.txt

           filePath = @"c:\temp\file.txt"; // Not required double slash if you use @ literal
           Console.WriteLine(filePath); // Output:  c:\temp\file.txt

           string multiLineText = @"First line
           Second Line
           Third Line"; // Not required double slash if you use @ literal
           Console.WriteLine(multiLineText); // Output: Same order
        }
        private static void AppendingStrings()
        {
            string firstName = "Nani";
            string lastName ="Potti";
            string fullName;

            // Option 1: using '+' symbol
            fullName = "My fullName: " + firstName + " "+lastName;
            Console.WriteLine(fullName);

            // Option 2: using string.Format
            fullName = string.Format("My FullName: {0} {1}", firstName, lastName);
            // fullName = string.Format("My FullName: {0} {2}", firstName, lastName); // Error: Unhandled exception. System.FormatException: Index (zero based) must be greater than or equal to zero and less than the size of the argument list.
            Console.WriteLine(fullName);

            // Option 3: String Interpollation
            fullName = $"My FullName: {firstName} {lastName}"; // This way anyone can readable using this new way of strings.
            Console.WriteLine(fullName);

            // Option 4: Without having string.format            
            Console.WriteLine("My FullName: {0} {1}", firstName, lastName);
        }
        private static void InterpolationAndLiteral()
        {
            string sampleText = "Nani Potti";
            
            // Option 1: @$ -- Order is not mandatory
            string filePath = @$"c:\temp\{sampleText}\sampleText.txt";
            Console.WriteLine(filePath); // Output: c:\temp\Nani Potti\sampleText.txt

            // Option 1: $@
            filePath = $@"c:\temp\{sampleText}\sampleText.txt";
            Console.WriteLine(filePath); // Output: c:\temp\Nani Potti\sampleText.txt
        }
        private static void StringBuilderDemo()
        {
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();

            string sampleText; // Initial null
            sampleText ="";
            // sampleText ="Nani";
            // sampleText="Potti";

            for(int i = 0; i<100000;i++)
            {
                sampleText += i;
            }

            stopWatch.Stop();
            Console.WriteLine($"Approach 1: String - Total Milliseconds: {stopWatch.ElapsedMilliseconds}"); // Output: Approach 1: String - Total Milliseconds: 8235
            
            // Immutable means never change the value in same memory. Instead it creates a new memory for each value change into that variable.
            // Like fist creates a memory for Potti and then create a new memory for Nani like go on.....

            Stopwatch builderStopWatch = new Stopwatch();

            builderStopWatch.Start();

            StringBuilder sb = new();
            long noOfTimes = 10000000L;
            for(int i = 0; i<noOfTimes;i++)
            {
                sb.Append(i);
            }

            builderStopWatch.Stop();
            Console.WriteLine($"Approach 2: StringBuilder - Total no.of times {noOfTimes} and took Total Milliseconds: {builderStopWatch.ElapsedMilliseconds}"); // Output: Approach 2: StringBuilder - Total no.of times 10000000 and took Total Milliseconds: 309
            
        }
        private static void WorkingWithArrays()
        {
            // Declaring an integer array
            int[] arrayOfValues = new int[] {10,12,29,20};
            string results;

            results = String.Concat(arrayOfValues); // Its concatinate all the values
            Console.WriteLine(results); // Output: 10122920

            results = String.Join(",", arrayOfValues); // Its put comma before each value
            Console.WriteLine(results); // Output: 10,12,29,20

            string stringToSplit = "Nani,Potti";
            string[] resultsInArray = stringToSplit.Split(',');
            Array.ForEach(resultsInArray, x => Console.WriteLine(x)); // Output: Nani Potti both these are in new lines.

            
            stringToSplit = "Nani, Potti";
            // resultsInArray = stringToSplit.Split(', '); // error CS1012: Too many characters in character literal [D:\POCs\cSharpDemos\StringDemo\StringDemo.csproj]
            resultsInArray = stringToSplit.Split(", "); 
            Array.ForEach(resultsInArray, x => Console.WriteLine(x)); // Output: Nani Potti both these are in new lines.


        }
        private static void PadAndTrim()
        {
            string sampleText = String.Empty;
            string results;

            // TRIM - are used to remove space either at start or end or both sides.
            sampleText = "    NaniPotti           ";
            results = sampleText.TrimStart();
            Console.WriteLine($"'{sampleText}'");// Output:     '    NaniPotti           '
            Console.WriteLine($"'{results}'");// Output:'NaniPotti           '

            sampleText = "         NaniPotti       ";
            results = sampleText.TrimEnd();            
            Console.WriteLine($"'{sampleText}'");// Output:     '    NaniPotti           '
            Console.WriteLine($"'{results}'");// Output:'         NaniPotti'

            sampleText = "         NaniPotti       ";
            results = sampleText.Trim();
            Console.WriteLine($"'{sampleText}'");// Output:     '    NaniPotti           '
            Console.WriteLine($"'{results}'");// Output:'NaniPotti'

            // PAD - add spaces either at start or end or in between
            sampleText = "29.20";
            results = string.Empty;

            results = sampleText.PadLeft(20,'0');
            Console.WriteLine($"'{sampleText}'");// Output:'29.20'
            Console.WriteLine($"'{results}'");// Output:'00000000000000029.20'
            Console.WriteLine(results);// Output:00000000000000029.20

            sampleText = "20.29";
            results = string.Empty;

            results = sampleText.PadRight(20,'*');
            Console.WriteLine($"'{sampleText}'");// Output:'20.29'
            Console.WriteLine($"'{results}'");// Output:'20.29***************'
            Console.WriteLine(results);// Output:20.29***************

            sampleText = "20";
            results = string.Empty;

            results = sampleText.PadRight(20,'*');
            Console.WriteLine($"'{sampleText}'");// Output:'29'
            Console.WriteLine($"'{results}'");// Output:'20***************'
            Console.WriteLine(results);// Output:20***************

 
            sampleText = "NaniPotti";
            results = string.Empty;

            results = sampleText.PadLeft(20,'0');
            Console.WriteLine($"'{sampleText}'");// Output:'NaniPotti'
            Console.WriteLine($"'{results}'");// Output:'***********NaniPotti'
            Console.WriteLine(results);// Output:***********NaniPotti
            
            sampleText = "Potti";
            results = string.Empty;

            results = sampleText.PadRight(20,'*');
            Console.WriteLine($"'{sampleText}'");// Output:'Potti'
            Console.WriteLine($"'{results}'");// Output:'Potti***************'
            Console.WriteLine(results);// Output:Potti***************

            


        }
    }
}
