public class WaterTank : IWaterTank
{
    public int Water { get; private set; }

    public WaterTank(int water)
    {
        Water = water;
    }

    public void Take(int ml)
    {
        Water -= ml;
    }
}