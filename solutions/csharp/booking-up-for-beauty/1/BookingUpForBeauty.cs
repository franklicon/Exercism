static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        var dateTime = DateTime.Parse(appointmentDateDescription);
        return dateTime;
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        var currentDateTime = DateTime.Now;
        return appointmentDate < currentDateTime;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        var currentDateTime = DateTime.Now;
        return appointmentDate <= currentDateTime && appointmentDate.Hour is >= 12 and < 18;
    }

    public static string Description(DateTime appointmentDate)
    {
        return $"You have an appointment on {appointmentDate:M/d/yyyy h:mm:ss tt}.";
    }

    public static DateTime AnniversaryDate()
    {
        var currentYear = DateTime.Today.Year;
        return new DateTime(currentYear, 9, 15, 0, 0, 0);
    }
}