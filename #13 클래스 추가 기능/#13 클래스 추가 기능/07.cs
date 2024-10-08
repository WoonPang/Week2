using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// 구조체 예제
public class GameController
{
    private void Awake()
    {
        Stats player01 = new Stats();
        Stats player02;

        player02.ID = "고박사";
        player02.currentHP = 100000;
        player02.damage = 99999;

        Debug.Log($"{player01.ID}, 체력 : {player01.currentHP}, 공격력 : {player01.damage}");
        Debug.Log($"{player02.ID}, 체력 : {player02.currentHP}, 공격력 : {player02.damage}");

    }
}

public struct Stats
{
    public string ID;
    public int curretHP;
    public int damage;
}