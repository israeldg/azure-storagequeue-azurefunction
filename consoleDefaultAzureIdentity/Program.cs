using Azure.Identity; 

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            var credential = new DefaultAzureCredential();
              Console.WriteLine("Hello, World!");
        }
    }
}