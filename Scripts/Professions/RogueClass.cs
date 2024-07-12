using Godot;
using Godot.Collections;

namespace EchoesofEternity.Scripts.Professions;

public class RogueClass : BaseClass
{
    public RogueClass(string name, Dictionary<string, int> stats) : base(name, stats)
    {
    }


    public override void Attack()
    {
        GD.Print("Rogue Attacked!");
    }

    public override void Defend()
    {
        GD.Print("Rogue Defended!");
    }

    public override void RunAway()
    {
        GD.Print("Rogue attempts to run away with advantage!");
    }

    public override void SpecialAbility()
    {
        GD.Print("Rogue Debuffs enemy");
    }
}