using Composite.Core;

namespace Composite.Tests;

public class SoldierTests
{
    [Fact]
    public void GetSoldiersAmount_Returns1()
    {
        var soldier = new Soldier();
        
        var count = soldier.GetSoldiersAmount();
        
        Assert.Equal(1, count);
    }
}