using Godot;
using Godot.Collections;

namespace EchoesofEternity.Scripts.Professions;

public class MageClass : BaseClass
{
    public MageClass(string name, Dictionary<string, int> stats) : base(name, stats)
    {
    }

    public override void Attack()
    {
        GD.Print("Mage attacked!");
    }

    public override void Defend()
    {
        GD.Print("Mage Defended with advantage");
    }

    public override void RunAway()
    {
        GD.Print("Mage attempts to run away!");
    }

    public override void SpecialAbility()
    {
        GD.Print("Mage buffs");
    }
}