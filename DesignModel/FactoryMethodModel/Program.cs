namespace FactoryMethodModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodA factoryMethodA = new FactoryMethodA();
            factoryMethodA.Create().Print();

            FactoryMethodB factoryMethodB = new FactoryMethodB();
            factoryMethodB.Create().Print();
            Console.WriteLine("工厂方法模式");
            
        }
    }
}