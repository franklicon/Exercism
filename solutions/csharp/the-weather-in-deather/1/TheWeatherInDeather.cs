public class WeatherStation
{
 private Reading _reading;
    private List<DateTime> _recordDates = [];
    private List<decimal> _temperatures = [];

    public void AcceptReading(Reading reading)
    {
        _reading = reading;
        _recordDates.Add(DateTime.Now);
        _temperatures.Add(reading.Temperature);
    }

    public void ClearAll()
    {
        _reading = new Reading();
        _recordDates.Clear();
        _temperatures.Clear();
    }

    public decimal LatestTemperature => _reading.Temperature;

    public decimal LatestPressure => _reading.Pressure;

    public decimal LatestRainfall => _reading.Rainfall;

    public bool HasHistory => _recordDates.Count > 1;

    public Outlook ShortTermOutlook
    {
        get
        {
            return _reading switch
            {
                var reading when reading.Equals(new Reading()) => throw new ArgumentException(),
                var reading when reading is {Pressure: < 10m, Temperature: < 30m } => Outlook.Cool,
                var reading when reading.Temperature > 50 => Outlook.Good,
                _ => Outlook.Warm
            };
        }
    }

    public Outlook LongTermOutlook
    {
        get
        {
            return _reading.WindDirection switch
            {
                WindDirection.Southerly => Outlook.Good,
                WindDirection.Easterly when _reading.Temperature > 20 => Outlook.Good,
                WindDirection.Northerly => Outlook.Cool,
                WindDirection.Easterly when _reading.Temperature <= 20 => Outlook.Warm,
                WindDirection.Westerly => Outlook.Rainy,
                _ => throw new ArgumentException()
            };
        }
    }

    public State RunSelfTest() => _reading.Equals(new Reading()) ? State.Bad : State.Good;
}

/*** Please do not modify this struct ***/
public struct Reading
{
    public decimal Temperature { get; }
    public decimal Pressure { get; }
    public decimal Rainfall { get; }
    public WindDirection WindDirection { get; }

    public Reading(decimal temperature, decimal pressure,
        decimal rainfall, WindDirection windDirection)
    {
        Temperature = temperature;
        Pressure = pressure;
        Rainfall = rainfall;
        WindDirection = windDirection;
    }
}

/*** Please do not modify this enum ***/
public enum State
{
    Good,
    Bad
}

/*** Please do not modify this enum ***/
public enum Outlook
{
    Cool,
    Rainy,
    Warm,
    Good
}

/*** Please do not modify this enum ***/
public enum WindDirection
{
    Unknown, // default
    Northerly,
    Easterly,
    Southerly,
    Westerly
}
