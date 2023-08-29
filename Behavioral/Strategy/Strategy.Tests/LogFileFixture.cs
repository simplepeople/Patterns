namespace Strategy.Tests;

public class LogFileFixture : IDisposable
{
    private const string fileLogPath = "log.txt";

    public LogFileFixture()
    {
        if (File.Exists(fileLogPath))
        {
            throw new FileAlreadyExistedException();
        }
    }
    
    public void WriteContent(string content)
    {
        File.WriteAllText(fileLogPath, content);
    }
    
    public void Dispose()
    {
        File.Delete(fileLogPath);
    }
}

public class FileAlreadyExistedException : Exception
{
}

[CollectionDefinition("log.txt")]
public class LogFileCollection : ICollectionFixture<LogFileFixture>
{
    
}