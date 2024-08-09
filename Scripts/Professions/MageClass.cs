using Godot;
using Godot.Collections;

namespace EchoesofEternity.Scripts.Professions;

public class MageClass : BaseClass
{
	public MageClass(string name, Dictionary<string, int> stats) : base(name, stats)
	{
	}

	public override int Attack()
	{
		GD.Print("Mage attacked!");
		return 0;
	}

	public override int Defend()
	{
		GD.Print("Mage Defended with advantage");
		return 0;
	}

	public override int RunAway()
	{
		GD.Print("Mage attempts to run away!");
		return 0;
	}

	public override void SpecialAbility()
	{
		GD.Print("Mage buffs");
	}
}
