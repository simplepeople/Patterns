namespace Strategy;

public class LogProcessor
{
    private readonly ILogReader _logReader;

    public LogProcessor(ILogReader logReader)
    {
        _logReader = logReader;
    }

    public IList<LogEntry> FilterLogs(Func<LogEntry, bool> filterPredicate)
    {
        return _logReader.ReadLogs().Where(filterPredicate).ToList();
    }
}