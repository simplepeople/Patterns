namespace Strategy;

public interface ILogReader
{
    IList<LogEntry> ReadLogs();
}