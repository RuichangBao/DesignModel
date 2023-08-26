namespace FactoryMethodModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FactoryMethodA factoryMethodA = new FactoryMethodA();
            ProductA productA =  factoryMethodA.Create() as ProductA;
            if (productA != null)
                productA.Print();

            FactoryMethodB factoryMethodB = new FactoryMethodB();
            ProductB productB = factoryMethodB.Create() as ProductB;
            if (productB != null)
                productB.Print();

            Console.WriteLine("工厂方法模式");
            
        }
    }
}