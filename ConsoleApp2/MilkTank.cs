public class MilkTank : IMilkTank
{
    public int Milk { get; private set; }

    public MilkTank(int milk)
    {
        Milk = milk;
    }

    public void Take(int ml)
    {
        Milk -= ml;
    }
}