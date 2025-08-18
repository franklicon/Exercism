static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) =>
        logLine[1..4] switch
        {
            _ when logLine.Contains("TRC") => LogLevel.Trace,
            _ when logLine.Contains("DBG") => LogLevel.Debug,
            _ when logLine.Contains("INF") => LogLevel.Info,
            _ when logLine.Contains("WRN") => LogLevel.Warning,
            _ when logLine.Contains("ERR") => LogLevel.Error,
            _ when logLine.Contains("FTL") => LogLevel.Fatal,
            _ => LogLevel.Unknown
        };

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}

public enum LogLevel
{
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
    Unknown = 0
}