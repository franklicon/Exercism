class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _distance;
    private int _battery = 100;
    private static int _nitroDistance = 50;
    private static int _nitroBatteryDrain = 4;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _battery < _batteryDrain;

    public int DistanceDriven() => _distance;

    public void Drive()
    {
        if(!BatteryDrained())
        {
            _distance += _speed;
            _battery -= _batteryDrain;
        } 
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(_nitroDistance, _nitroBatteryDrain);
    }
}

class RaceTrack
{
    private int _distance;
    public RaceTrack(int distance)
    {
        _distance = distance;    
    }
    
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
        {
            car.Drive();
            if(car.DistanceDriven() >= _distance)
            {
                return true;
            }
        }
        return false;
    }
}
