using ConsoleApp2;

namespace ConsoleApp2.Tests;

public class PaymentFactoryTests
{
    private readonly PaymentFactory _factory = new();

    [Fact]
    public void Create_Card_ReturnsCardPay()
    {
        var method = _factory.Create(PaymentType.Card);

        Assert.IsType<CardPay>(method);
    }

    [Fact]
    public void Create_PayPal_ReturnsPayPalPay()
    {
        var method = _factory.Create(PaymentType.PayPal);

        Assert.IsType<PayPalPay>(method);
    }

    [Fact]
    public void Create_BankTransfer_ReturnsBankTransfer()
    {
        var method = _factory.Create(PaymentType.BankTransfer);

        Assert.IsType<BankTransfer>(method);
    }

    [Fact]
    public void Create_Crypto_NotSupportedYet()
    {
        Assert.Throws<ArgumentException>(() => _factory.Create(PaymentType.Crypto));
    }
}
