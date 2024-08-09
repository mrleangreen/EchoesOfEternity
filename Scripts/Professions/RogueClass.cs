using Godot;
using Godot.Collections;

namespace EchoesofEternity.Scripts.Professions;

public class RogueClass : BaseClass
{
	public RogueClass(string name, Dictionary<string, int> stats) : base(name, stats)
	{
	}


	public override int Attack()
	{
		GD.Print("Rogue Attacked!");
		return 0;
	}

	public override int Defend()
	{
		GD.Print("Rogue Defended!");
		return 0;
	}

	public override int RunAway()
	{
		GD.Print("Rogue attempts to run away with advantage!");
		return 0;
	}

	public override void SpecialAbility()
	{
		GD.Print("Rogue Debuffs enemy");
	}
}
