namespace AbstractFactoryModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MacUIFactory macUIFactory = new MacUIFactory();
            MacTextBox macTextBox =  macUIFactory.CreateTextBox() as MacTextBox;
            if (macTextBox != null)
                macTextBox.Input("AAAAAAAAA");
            MacButton macButton = macUIFactory.CreateButton() as MacButton;
            if (macButton != null)
                macButton.Click();

            WinUIFactory winUIFactory = new WinUIFactory();
            WinTextBox winTextBox = winUIFactory.CreateTextBox() as WinTextBox;
            if (winTextBox != null)
                winTextBox.Input("BBBBBBBBBB");
            WinButton winButton = winUIFactory.CreateButton() as WinButton;
            if (winButton != null)
                winButton.Click();
            Console.WriteLine("抽象工厂模型!");
        }
    }
}