Composite is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

```mermaid
---
title: Composite
---
classDiagram

    class IArmyUnit{
        <<interface>>
        + GetSoldiersAmount()
    }

    class Soldier
    IArmyUnit <|.. Soldier

    class CompoundArmyUnit{
        <<abstract>>
        - armyUnits : List~IArmyUnit~
        + Add(IArmyUnit unit)
    }

    IArmyUnit <|.. CompoundArmyUnit
    
    class Brigade{
    }
    CompoundArmyUnit <|-- Brigade

    class Division{
    }
    CompoundArmyUnit <|-- Division

```