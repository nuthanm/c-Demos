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
    }
}