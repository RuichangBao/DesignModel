namespace SingletonModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = Singleton.Instance;
            Console.WriteLine("单例模式!");
        }
    }
}