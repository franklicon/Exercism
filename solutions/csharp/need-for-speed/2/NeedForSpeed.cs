public class RemoteControlCar(int speed, int batteryDrain)
{
    private int _distance;
    private int _battery = 100;
    private static readonly int _nitroDistance = 50;
    private static readonly int _nitroBatteryDrain = 4;

    public bool BatteryDrained() => _battery < batteryDrain;

    public int DistanceDriven() => _distance;

    public void Drive()
    {
        if (BatteryDrained()) return;
        _distance += speed;
        _battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro() 
        => new RemoteControlCar(_nitroDistance, _nitroBatteryDrain);
}

public class RaceTrack(int distance)
{
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
            if(car.DistanceDriven() >= distance)
            {
                return true;
            }
        }
        return false;
    }
}
