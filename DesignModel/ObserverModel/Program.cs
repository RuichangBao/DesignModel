namespace ObserverModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();
            ConcreteObserver observer1 = new ConcreteObserver("Observer 1", subject);
            ConcreteObserver observer2 = new ConcreteObserver("Observer 2", subject);
            ConcreteObserver observer3 = new ConcreteObserver("Observer 3", subject);

            subject.AddObserver(observer1);
            subject.AddObserver(observer2);
            subject.AddObserver(observer3);

            subject.State = 1; // 触发通知
            Console.WriteLine("按下键盘继续修改被观察者状态");
            Console.ReadKey();
            subject.RemoveObserver(observer2);
            subject.State = 2; // 触发通知

            Console.WriteLine("观察者模式!");
        }
    }
}