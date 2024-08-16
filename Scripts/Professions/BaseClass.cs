using Godot;
using System;
using System.Transactions;
using Godot.Collections;

public partial class BaseClass
{
	public string characterName;
	public int attackPower;
	public int defense;
	public int health;
	public int maxHealth;
	public int specialPower;
	public int exp;
	public int dex;
	public int intelligence;
	public int str;
	
	//if we want stackable, maybe have buff and debuff be a number to describe how many stacks, or just have a counter
	public int buff = 0;
	public int debuff = 0;
	protected Random rand;

	//constructor
	public BaseClass(string name, Dictionary<string, int> stats)
	{
		characterName = name;
		attackPower = stats.ContainsKey("attackPower") ? stats["attackPower"] : 0;
		defense = stats.ContainsKey("defense") ? stats["attackPower"] : 0;
		health = stats.ContainsKey("health") ? stats["health"] : 0;
		maxHealth = stats.ContainsKey("maxHealth") ? stats["maxHealth"] : 100;
		specialPower = stats.ContainsKey("specialPower") ? stats["specialPower"] : 0;
		exp = stats.ContainsKey("exp") ? stats["exp"] : 0;
		dex = stats.ContainsKey("dex") ? stats["dex"] : 0;
		intelligence = stats.ContainsKey("intelligence") ? stats["intelligence"] : 0;
		str = stats.ContainsKey("strength") ? stats["strength"] : 0;
		rand = new Random();

	}
	public virtual int Attack()
	{
		return 0;
	}
	public virtual int Defend()
	{
		return 0;
	}

	public void TakeDamage(int damage)
	{
		health -= damage;
	}
	public virtual int RunAway()
	{
		return 0;
	}
	public void UseItem()
	{
		GD.Print("Character opened the item menu");
	}
	
	public virtual void SpecialAbility(BaseClass enemy)
	{
	}
}
