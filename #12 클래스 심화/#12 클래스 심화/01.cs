using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정보은닉과 캡슐화 예제
public class Player
{
    private int currentHP;\

    public boid SetCurrentHP(int hp)
    {
        if (hp > 0)
        {
            currentHP = hp;
        }
    }

    public int GetCurrentHP()
    {
        return currentHP;
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        // private 멤버 변수에 접근 불가 - Error
        player.GetCurrentHP = 100;
        Debug.Log($"HP : {player.GetCurrentHP}");

        // currentHP의 Set, Get 메소드에 접근
        player.SetCurrentHP(100);
        Debug.Log($"HP : {player.GetCurrentHP()}");
    }
}