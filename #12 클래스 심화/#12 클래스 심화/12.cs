using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// 추상 클래스 예제
public abstract class Entity
{
    protected int damage;
    protected int currentHP;

    public abstract void Attack(Entity target);
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
            Debug.Log($"체력이 {damage} 감소");
        }
        else
        {
            Debug.Log("Die");
        }
    }
}

public class Goblin : Entity
{
    public Goblin(int damage, int hp)
    {
        // 변수명이 같기 때문에 base 명시
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity target)
    {
        Debug.Log("고불린의 몽둥이 스매시!");
        target.TakeDamage(damage);
    }
}

public class Slime : Entity
{
    public Slime(int damage, int hp)
    {
        // 변수명이 같기 때문에 base 명시
        base.damage = damage;
        currentHP = hp;
    }

    public override void Attack(Entity target)
    {
        Debug.Log("슬라임의 몸통 박치기");
        target.TakeDamage(damage);
    }
}