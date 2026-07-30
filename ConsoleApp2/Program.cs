using ConsoleApp2;

decimal balance = 2000;
decimal priceToPay = 4000;

var factory = new PaymentFactory();

PayMethod payMethod = factory.Create(PaymentType.Card);


if (priceToPay > balance)
{
    Console.WriteLine("недостаточно средств");
}
else if (payMethod.Pay(priceToPay))
{
    balance -= priceToPay;
}

Console.WriteLine($"Balance: {balance}");



