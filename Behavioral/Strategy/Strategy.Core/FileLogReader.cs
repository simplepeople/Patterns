namespace Strategy;

public class FileLogReader : ILogReader
{
    public IList<LogEntry> ReadLogs()
    {
        return File.ReadAllLines("log.txt").Select(x =>
        {
            var splitted = x.Split(' ');
            return new LogEntry
            {
                Id = Convert.ToInt32(splitted[0]),
                Event = splitted[1],
            };
        }).ToList();
    }
}