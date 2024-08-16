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
		int atk = attackPower;
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
		GD.Print("Rogue attacked");
		return atk;
	}

	public override int Defend()
	{
		GD.Print("Rogue Defended!");

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

	public override int RunAway()
	{
		GD.Print("Rogue attempts to run away with advantage!");
		int totalDex = dex;
		int dexBonus = dex * rand.Next(10) / 10;
		totalDex += dexBonus;
		
		
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
		GD.Print("Rogue Debuffs enemy");

		enemy.debuff++;
		buff++;
	}
}
