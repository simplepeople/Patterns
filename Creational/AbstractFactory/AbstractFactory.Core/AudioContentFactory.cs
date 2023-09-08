namespace AbstractFactory.Core;

public class AudioContentFactory : ContentFactory
{
    public override IContent CreateSafeContent() => new AudioContent();
    
    public override INSFWContent CreateNSFWContent() => new NSFWAudioContent();
}