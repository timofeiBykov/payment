namespace ConsoleApp2;

public class PaymentFactory
{
    public PayMethod Create(PaymentType type)
    {
        switch (type)
        {
            case PaymentType.Card:
                return new CardPay();
            
            case PaymentType.BankTransfer:
                return new BankTransfer();
            
            case PaymentType.PayPal:
                return new PayPalPay();
            
            default: throw new ArgumentException("Неизвестный тип оплаты");
        }
    }
}