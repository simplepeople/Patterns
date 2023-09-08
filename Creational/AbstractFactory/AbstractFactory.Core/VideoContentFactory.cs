namespace AbstractFactory.Core;

public class VideoContentFactory : ContentFactory
{
    public override IContent CreateSafeContent() => new VideoContent();
    
    public override INSFWContent CreateNSFWContent() => new NSFWVideoContent();
}