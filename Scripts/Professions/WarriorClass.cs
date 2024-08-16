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
		GD.Print(characterName + " attacks with warrior's fury!");
		int atk = attackPower;
		int bonus = str * rand.Next(10) / 10;
		atk += bonus;
		
		if (buff > 0)
		{
			float buffStat = rand.Next(1, 10) / 10 * buff;
			atk += (int) (str * buffStat);
			buff = 0;
		}

		if (debuff > 0)
		{
			float debuffStat = rand.Next(1, 5) / 10 * debuff;
			atk -= (int) (str * debuffStat);
			debuff = 0;
		}
		
		
		return atk;
	}

	public override int Defend()
	{
		GD.Print(characterName + " defends with warrior's shield!");
		int totalDef = defense;
		if (buff > 0)
		{
			float buffStat = rand.Next(1, 10) / 10 * buff;
			totalDef += (int) (intelligence * buffStat);
			buff = 0;
		}

		if (debuff > 0)
		{
			float debuffStat = rand.Next(1, 5) / 10 * debuff;
			totalDef -= (int) (intelligence * debuffStat);
			debuff = 0;
		}

		return totalDef;
	}

	public override void SpecialAbility(BaseClass enemy)
	{
		GD.Print(characterName + " uses a powerful strike!");
		buff += 2;

		int specialDamage = Attack();
		specialDamage += rage;

		specialDamage -= (int) (enemy.Defend() * 0.5);
		
		enemy.TakeDamage(specialDamage);

	}

	public void BuildRage(int amount)
	{
		rage += amount;
		GD.Print(characterName + " builds rage. Current rage: " + rage);
	}
}
