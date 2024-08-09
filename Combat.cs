using Godot;
using System;

public partial class Combat : Node
{
    public BaseClass player;
    public BaseClass enemy;

    public Combat(BaseClass Player, BaseClass Enemy)
    {
        player = Player;
        enemy = Enemy;
    }

    public void PlayerAttack()
    {
        int playerAtk = player.Attack();
        int enemyDef = enemy.Defend();

        double dmg = playerAtk - enemyDef * (0.5);
        enemy.TakeDamage((int) dmg);
    }

    public void EnemyAttack()
    {
        int enemyAtk = enemy.Attack();
        int playerDef = player.Defend();

        double dmg = enemyAtk - playerDef * (0.5);
        player.TakeDamage((int) dmg);
    }

    public bool PlayerRunAway()
    {
        int playerRun = player.RunAway();
        //may want a class method for this to get stat to make opposition stay
        double enemyStay = (enemy.intelligence + enemy.str) * 0.3;
        
        //if playerRun capability is greater than enemy's ability to make them stay, end combat,
        //else do nothing OR take penality
        if (playerRun > enemyStay)
        {
            //TODO: END COMBAT
            //maybe in global handler, check if runaway was successful and then destroy the combat object
            return true;

        }

            //TODO: Maybe a penalty
            return false;
    }
    
    public bool EnemyRunAway()
    {
        int enemyRun = enemy.RunAway();
        //may want a class method for this to get stat to make opposition stay
        double playerStay = (player.intelligence + player.str) * 0.3;
        
        //if playerRun capability is greater than enemy's ability to make them stay, end combat,
        //else do nothing OR take penality
        if (enemyRun > playerStay)
        {
            //TODO: END COMBAT
            //maybe in global handler, check if runaway was successful and then destroy the combat object
            return true;

        }
            //TODO: Maybe a penalty
            return false;
    }
    
    
}
