using Composite.Core;

namespace Composite.Tests;

public class BrigadeTests
{
    [Fact]
    public void GetSoldiersAmount_ZeroSolders_Returns0()
    {
        var brigade = new Brigade();

        var count = brigade.GetSoldiersAmount();
        
        Assert.Equal(0, count);
    }
    
    [Fact]
    public void GetSoldiersAmount_TwoSolders_Returns2()
    {
        var brigade = new Brigade();
        brigade.AddArmyUnit(new Soldier());
        brigade.AddArmyUnit(new Soldier());

        var count = brigade.GetSoldiersAmount();
        
        Assert.Equal(2, count);
    }
    
    [Fact]
    public void GetSoldiersAmount_FourSolders_Returns4()
    {
        var brigade = new Brigade();
        brigade.AddArmyUnit(new Soldier());
        brigade.AddArmyUnit(new Soldier());
        brigade.AddArmyUnit(new Soldier());
        brigade.AddArmyUnit(new Soldier());

        var count = brigade.GetSoldiersAmount();
        
        Assert.Equal(4, count);
    }
}