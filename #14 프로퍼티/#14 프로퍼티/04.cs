using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// get { ... } 접근자 : 멤버 변수로부터 값을 읽어옴
// set { ... } 접근자 : 멤버 변수에 값을 할당
// set { ... } 접근자 안에 있는 value 키워드는 set 접근자의 암묵적 매개 변수
public class Player
{
    private int currentHP;
    public int CurrnetHP
    {
        get => currentHP;
        set
        {
            if (currentHP > 0)
            {
                currentHP = value;
            }
            else
            {
                currentHP = 0;
            }
        }
    }
}

public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.currentHP = 100;
        Debug.Log($"Player HP : {player.CurrnetHP}");
        player.CurrnetHP = -100;
        Debug.Log($"Player HP : {player.currentHP}");
    }
}

// 결과 출력
// Player HP : 100
// Player HP : 0