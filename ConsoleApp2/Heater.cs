public class Heater : IHeater
{
    public int CurrentTemperature { get; private set; }

    public void HeatTo(int temperature)
    {
        CurrentTemperature = temperature;
        Log.Information($"Нагрев воды до {temperature} градусов");
    }
}