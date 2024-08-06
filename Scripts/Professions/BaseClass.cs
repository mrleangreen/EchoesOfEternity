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

    }
    public virtual void Attack()
    {

    }
    public virtual void Defend()
    {

    }
    public virtual void RunAway()
    {

    }
    public void UseItem()
    {
        GD.Print("Character opened the item menu");
    }
    public virtual void SpecialAbility()
    {
        
    }
}
