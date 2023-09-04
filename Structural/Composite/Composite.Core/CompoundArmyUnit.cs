namespace Composite.Core;

public abstract class CompoundArmyUnit : IArmyUnit
{
    private ICollection<IArmyUnit> ArmyUnits { get; } = new List<IArmyUnit>();
    public int GetSoldiersAmount() => ArmyUnits.Sum(u => u.GetSoldiersAmount());

    public void AddArmyUnit(IArmyUnit armyUnit) => ArmyUnits.Add(armyUnit);
}