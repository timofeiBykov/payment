using ConsoleApp2;

namespace ConsoleApp2.Tests;

public class PaymentMethodTests
{
    [Theory]
    [InlineData(typeof(CardPay))]
    [InlineData(typeof(PayPalPay))]
    [InlineData(typeof(BankTransfer))]
    public void Pay_NegativeAmount_ReturnsFalse(Type methodType)
    {
        var method = (PayMethod)Activator.CreateInstance(methodType)!;

        Assert.False(method.Pay(-100));
    }

    [Theory]
    [InlineData(typeof(CardPay))]
    [InlineData(typeof(PayPalPay))]
    [InlineData(typeof(BankTransfer))]
    public void Pay_PositiveAmount_ReturnsTrue(Type methodType)
    {
        var method = (PayMethod)Activator.CreateInstance(methodType)!;

        Assert.True(method.Pay(100));
    }
}

public class RefundCapabilityTests
{
    [Fact]
    public void Card_SupportsRefund()
    {
        Assert.IsAssignableFrom<RefundMethod>(new CardPay());
    }

    [Fact]
    public void PayPal_SupportsRefund()
    {
        Assert.IsAssignableFrom<RefundMethod>(new PayPalPay());
    }

    [Fact]
    public void BankTransfer_DoesNotSupportRefund()
    {
        Assert.IsNotAssignableFrom<RefundMethod>(new BankTransfer());
    }

    [Fact]
    public void Card_Refund_ReturnsTrue()
    {
        var card = new CardPay();

        Assert.True(card.Refund(100));
    }
}