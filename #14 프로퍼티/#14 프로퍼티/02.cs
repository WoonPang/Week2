using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 멤버 변수의 은닉성을 지키기 위해 Get(), Set() 멤버 함수를 이용
public class Player
{
    // 멤버 변수를 private으로 은닉하고, Get()/Set() 메소드 작성'
    private int currentHP;
    public int GetCurrentHP() { return currentHP; }
    public void SetCurrentHP(int hp) { currentHP = hp; }
}

public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.SetCurrentHP(100);
        Debug.Log($"Player HP : {player.GetCurrentHP()}");
    }
}