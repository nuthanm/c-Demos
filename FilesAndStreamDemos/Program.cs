using System;

namespace FilesAndStreamDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            TextFileProcessor textFileProcessor = new TextFileProcessor(@"About_File_Streams_in_csharp.txt","output/Modified_FileLines.txt");
            textFileProcessor.Process();            
        }
    }
}
