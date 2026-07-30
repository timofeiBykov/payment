namespace ConsoleApp2;

public class BankTransfer : PayMethod
{
    public bool Pay(decimal amount)
    {
        Console.WriteLine($"Оплата банковским переводом");
        return true;
    }
}