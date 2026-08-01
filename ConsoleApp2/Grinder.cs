public class Grinder : IGrinder
{
    public void Grind(int grams)
    {
        Log.Information($"Измельчить {grams} граммов зерна");
    }
}