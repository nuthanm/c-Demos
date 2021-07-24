namespace System
{
    public class CustomLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Log(string message, string messageType)
        {
            Console.WriteLine($"{messageType}: {message}");
        }
    }
}
