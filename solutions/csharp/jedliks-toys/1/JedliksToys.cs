class RemoteControlCar
{
    private int _meters = 0;
    private int _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_meters} meters";
    }

    public string BatteryDisplay()
    {
        if(_battery == 0)
            return "Battery empty";
        
        return $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if(_battery == 0)
            return;
        
        _meters += 20;
        _battery -= 1;
    }
}
