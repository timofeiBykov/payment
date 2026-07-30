namespace ConsoleApp2;

public class PayPalPay : PayMethod
{
    public bool Pay(decimal price)
    {
        Console.WriteLine($"Bitcion");
        return true;
    }
}
