using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// base 키워드
public class Entity
{
    public string ID;
    protected int currentHP;
}

public class Player : Entity
{
    private string ID;

    public Player(string id, int hp)
    {
        base.ID = "Nonname";
        ID = id;
        currentHP = hp;
    }
}