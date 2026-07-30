namespace ConsoleApp2;

public class CardPay : PayMethod, RefundMethod, PartialRefund
{
    public bool Pay(decimal price)
    {
        if (price < 0)
        {
            Console.WriteLine("Сумма не может быть меньше 0");
            return false;
        }

        Console.WriteLine($"Card");
        return true;
    }

    public bool Refund(decimal price)
    {
        Console.WriteLine($"Refund " + price);
        return true;
    }

    public bool RefundPartial(decimal price)
    {
        Console.WriteLine($"Refund partial" + price);
        return true;
    }
}