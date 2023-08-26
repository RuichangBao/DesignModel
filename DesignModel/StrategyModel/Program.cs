namespace StrategyModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new StrategyA());
            context.ExecuteStrategy();

            context.SetStrategy(new StrategyB());
            context.ExecuteStrategy();
            Console.WriteLine("策略模式!");
        }
    }
}