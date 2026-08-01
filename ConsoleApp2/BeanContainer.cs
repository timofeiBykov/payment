public class BeanContainer : IBeanContainer
{
    public int Volume { get; private set; }

    public BeanContainer(int volume)
    {
        Volume = volume;
    }

    public void Take(int grams)
    {
        Volume -= grams;
    }
}