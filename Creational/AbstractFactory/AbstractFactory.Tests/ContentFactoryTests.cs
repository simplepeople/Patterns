using AbstractFactory.Core;

namespace AbstractFactory.Tests;

public class ContentFactoryTests
{
    [Fact]
    public void CreateSafeContent_ReturnsAudioContent()
    {
        ContentFactory factory = new AudioContentFactory();
        var content = factory.CreateSafeContent();

        Assert.IsType<AudioContent>(content);
    }
    
    [Fact]
    public void CreateSafeContent_ReturnsVideoContent()
    {
        ContentFactory factory = new VideoContentFactory();
        var content = factory.CreateSafeContent();

        Assert.IsType<VideoContent>(content);
    }
    
    [Fact]
    public void CreateNSFWContent_ReturnsAudioContent()
    {
        ContentFactory factory = new AudioContentFactory();
        var content = factory.CreateNSFWContent();

        Assert.IsType<NSFWAudioContent>(content);
    }
    
    [Fact]
    public void CreateNSFWContent_ReturnsVideoContent()
    {
        ContentFactory factory = new VideoContentFactory();
        var content = factory.CreateNSFWContent();

        Assert.IsType<NSFWVideoContent>(content);
    }
}

