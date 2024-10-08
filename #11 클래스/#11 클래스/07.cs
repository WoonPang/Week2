using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스의 이용
public class Player
{
    private string ID = "고박사";
    private int currentHP = 1000;

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}

public class Enemy
{
    private Player player;

    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}