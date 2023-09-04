using Composite.Core;

namespace Composite.Tests;

public class DivisionTests
{
    [Fact]
    public void GetSoldiersAmount_ZeroSolders_Returns0()
    {
        var division = new Division();

        var count = division.GetSoldiersAmount();
        
        Assert.Equal(0, count);
    }
    
    [Fact]
    public void GetSoldiersAmount_TwoSolders_Returns2()
    {
        var division = new Division();
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());

        var count = division.GetSoldiersAmount();
        
        Assert.Equal(2, count);
    }
    
    [Fact]
    public void GetSoldiersAmount_FourSolders_Returns4()
    {
        var division = new Division();
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());

        var count = division.GetSoldiersAmount();
        
        Assert.Equal(4, count);
    }
    
    [Fact]
    public void GetSoldiersAmount_7SoldersTwoBrigades_Returns4()
    {
        var division = new Division();
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());
        division.AddArmyUnit(new Soldier());
        var brigade1 = new Brigade();
        brigade1.AddArmyUnit(new Soldier());
        brigade1.AddArmyUnit(new Soldier());
        division.AddArmyUnit(brigade1);
        var brigade2 = new Brigade();
        brigade2.AddArmyUnit(new Soldier());
        division.AddArmyUnit(brigade2);
        
        var count = division.GetSoldiersAmount();
        
        Assert.Equal(7, count);
    }
}