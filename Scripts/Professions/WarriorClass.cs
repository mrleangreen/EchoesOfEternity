using Godot;
using Godot.Collections;

namespace EchoesofEternity.Scripts.Professions;

public class WarriorClass : BaseClass
{
    public WarriorClass(string name, Dictionary<string, int> stats) : base(name, stats)
    {
    }

    public override void Attack()
    {
        GD.Print("Warrior attacks with advantage!");
    }

    public override void Defend()
    {
        GD.Print("Warrior defends!");
    }

    public override void RunAway()
    {
        GD.Print("Warrior attempts to run away!");
    }

    public override void SpecialAbility()
    {
        GD.Print("Warrior does BIG damage!");
    }
}