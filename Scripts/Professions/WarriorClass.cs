using Godot;
using System;
using Godot.Collections;

public class WarriorClass : BaseClass
{
	public int rage;

	// Constructor
	public WarriorClass(string name, Dictionary<string, int> stats) : base(name, stats)
	{
		rage = stats.ContainsKey("rage") ? stats["rage"] : 0;
	}

	public override int Attack()
	{
		//base.Attack();
		GD.Print(characterName + " attacks with warrior's fury!");
		return 0;
	}

	public override int Defend()
	{
		//base.Defend();
		GD.Print(characterName + " defends with warrior's shield!");
		return 0;
	}

	public override void SpecialAbility()
	{
		GD.Print(characterName + " uses a powerful strike!");
	}

	public void BuildRage(int amount)
	{
		rage += amount;
		GD.Print(characterName + " builds rage. Current rage: " + rage);
	}
}
