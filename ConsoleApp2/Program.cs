using ConsoleApp2;

class Program
{
    static void Main(string[] args)
    {
        var waterTank = new WaterTank(1000);
        var beanContainer = new BeanContainer(500);
        var milkTank = new MilkTank(400);
        var heater = new Heater();
        var grinder = new Grinder();

        var coffeeMachine = new CoffeeMachine(
            waterTank,
            beanContainer,
            milkTank,
            heater,
            grinder
        );

        bool result = coffeeMachine.MakeCoffee(CoffeeButton.Latte);

        if (result)
        {
            Log.Information("Latte готов!");
        }
        else
        {
            Log.Information("Не хватает ресурсов");
        }
    }
}


