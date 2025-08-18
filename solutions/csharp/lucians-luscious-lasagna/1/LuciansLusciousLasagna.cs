class Lasagna
{
    private const int _oven = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => _oven;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutes)
    {
        if(minutes >= 40)
            return 0;
        if(minutes <= 0)
            return _oven;
        return _oven - minutes;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        if(layers < 0)
            throw new ArgumentException("layers cannot be negative");
        return 2 * layers;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int minutes)
    {
        return (2 * layers) + minutes;
    }
}
