namespace SingletonMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = Singleton.Instance;
            Console.WriteLine("Hello, World!");
        }
    }
}