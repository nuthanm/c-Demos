using System;
using System.IO;

namespace FilesAndStreamDemos
{
    public class TextFileProcessor
    {
        public string InputFilePath { get; set; }
        public string OutputFilePath { get; set; }

        public TextFileProcessor(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;            
        }

        public void Process()
        {
            ReadAllTextAndSave();
            ReadAllLinesAndSave();
        }

        private void ReadAllTextAndSave()
        {
            // Step 1: Assuming file is already there in a specified folder and read all the content and store it into Inmemory (string variable)
            string originalTextContent = File.ReadAllText(InputFilePath);
            Console.WriteLine(originalTextContent);
            // Step 2: Modified the original text format
            string modifiedOriginalContent = originalTextContent.ToUpperInvariant();
            Console.WriteLine(modifiedOriginalContent);

            // Step 3: Store this content in another file
            File.WriteAllText(OutputFilePath, modifiedOriginalContent);
        }

        private void ReadAllLinesAndSave()
        {
            // Step 1: Assuming file is already there in a specified folder and read all the lines and store it into Inmemory (string[] variable)
            string[] lines = File.ReadAllLines(InputFilePath);
            // Step 2: Modified any line of text.
            lines[0] = lines[0].ToUpperInvariant();

            // Step 3: Store this entire lines in another file
            File.WriteAllLines(OutputFilePath, lines);
        }
    }
}