using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속 예제
public class Entity
{
    public string ID;
    protected int currentHP;

    private void Initialize()
    {
        ID = "Nonname";
    }

    public void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
}

// 파생 클래스(자식 클래스)와 기반 클래스(부모 클래스)
public class Player : Entity    // Player : 파생 클래스, Entity : 기반 클래스
{
    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;

        RecoveryHP(1000);

        // private이기 때문에 사용 불가
        Initialize();
    }
}