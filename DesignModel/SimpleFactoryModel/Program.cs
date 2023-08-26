namespace SimpleFactoryModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISimpleFactory simpleFactoryA = SimpleFactory.Printer(ESimpleFactoryType.SimpleFactoryA);
            ISimpleFactory simpleFactoryB = SimpleFactory.Printer(ESimpleFactoryType.SimpleFactoryB);
            simpleFactoryA.Print();
            simpleFactoryB.Print();
            Console.WriteLine("简单工厂模式!");
        }

    }
}