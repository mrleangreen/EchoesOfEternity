using System;
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
		int atk = attackPower;
		if (buff > 0)
		{
			float buffStat = rand.Next(1, 10) / 10 * buff;
			atk += (int) (str * buffStat);
			buff = 0;
		}

		if (debuff > 0)
		{
			float debuffStat = rand.Next(1, 5) / 10;
			atk -= (int) (str * debuffStat);
			debuff = 0;
		}
		GD.Print("Mage attacked");
		return atk;
	}

	public override int Defend()
	{
	
		GD.Print("Mage Defended with advantage");
		int bonus = intelligence * rand.Next(10)/ 10;
		int totalDef = defense + bonus;
		
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

	public override int RunAway()
	{
		int totalDex = dex;
		GD.Print("Mage attempts to run away!");
		if (buff > 0)
		{
			float buffStat = rand.Next(1, 10) / 10 * buff;
			totalDex += (int) (dex * buffStat);
			buff = 0;
		}

		if (debuff > 0)
		{
			float debuffStat = rand.Next(1, 5) / 10 * debuff;
			totalDex -= (int) (dex * debuffStat);
			debuff = 0;
		}
		
		return totalDex;
	}

	public override void SpecialAbility(BaseClass enemy)
	{
		GD.Print("Mage buff + heals");
		buff++;
		int addHealth = 50;	//still don't know the base values :,)
		if (buff > 0)
		{
			int bonus = addHealth * rand.Next(1, 10) / 10 * buff;
			addHealth += bonus;
		}
		health += addHealth;
	}
}
