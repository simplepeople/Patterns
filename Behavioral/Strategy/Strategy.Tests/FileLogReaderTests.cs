using FluentAssertions;

namespace Strategy.Tests;

[Collection("log.txt")]
public class FileLogReaderTests
{
    private readonly ILogReader _logReader = new FileLogReader();

    public FileLogReaderTests(LogFileFixture logFileFixture)
    {
        string content =
            """
            300 qweewf
            100 werf
            501 grrg
            1000 ffsss
            """;

        logFileFixture.WriteContent(content);
    }
    
    [Fact]
    public void FilterLogs_FilterById_ReturnsTwoOfFourLogs()
    {
        var processor = new LogProcessor(_logReader);
        var logs = processor.FilterLogs(x => x.Id > 500);
        logs.Should().NotBeNullOrEmpty()
            .And.HaveCount(2)
            .And.AllSatisfy(log =>
                log.Id.Should().BeGreaterThan(500));
    }
}