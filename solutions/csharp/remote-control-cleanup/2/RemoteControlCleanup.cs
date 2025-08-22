public class RemoteControlCar
{
    public interface ITelemetry
    {
        void Calibrate();
        bool SelfTest();
        void ShowSponsor(string sponsorName);
        void SetSpeed(decimal amount, string unitsString);
    }
    
    public ITelemetry Telemetry { get; }
    
    public RemoteControlCar()
    {
        Telemetry = new TelemetryImplementation(this);
    }
    private enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }
    private struct Speed
    {
        public decimal Amount { get; }
        public SpeedUnits SpeedUnits { get; }

        public Speed(decimal amount, SpeedUnits speedUnits)
        {
            Amount = amount;
            SpeedUnits = speedUnits;
        }

        public override string ToString()
        {
            string unitsString = "meters per second";
            if (SpeedUnits == SpeedUnits.CentimetersPerSecond)
            {
                unitsString = "centimeters per second";
            }

            return $"{Amount} {unitsString}";
        }
    }
    
    private Speed _currentSpeed;
    public string CurrentSponsor { get; private set; }  
    
    public class TelemetryImplementation(RemoteControlCar car) : ITelemetry
    {
        public void Calibrate() { }

        public bool SelfTest() => true;

        public void ShowSponsor(string sponsorName) => car.SetSponsor(sponsorName);

        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = SpeedUnits.MetersPerSecond;
            if (unitsString == "cps")
            {
                speedUnits = SpeedUnits.CentimetersPerSecond;
            }

            var speed = new Speed(amount, speedUnits);
            car.SetSpeed(speed);
        }
    }

    public string GetSpeed() => _currentSpeed.ToString();

    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;

    private void SetSpeed(Speed speed) => _currentSpeed = speed;
}