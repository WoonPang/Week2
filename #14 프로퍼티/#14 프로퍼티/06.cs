using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자동 구현 프로퍼티 예제
public class Player
{
    public int CurrentHP
    {
        get; set;
    }
    public string ID
    {
        get; set;
    }
}

public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.ID = "고박사";
        player.CurrentHP = 100;
        Debug.Log($"{player.ID} HP : {player.CurrentHP}");
    }
}

// 출력 결과
// 고박사 HP : 100