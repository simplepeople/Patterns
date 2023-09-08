namespace AbstractFactory.Core;

public abstract class ContentFactory
{
    public abstract IContent CreateSafeContent();
    
    public abstract INSFWContent CreateNSFWContent();

}