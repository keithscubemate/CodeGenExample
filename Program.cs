namespace ConsoleApp;

partial class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hey World");
    HelloFrom("Generated Code");
  }

  static partial void HelloFrom(string name);
}
