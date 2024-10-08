using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

// 프로퍼티와 생성자
// 객체 생성시 생성자를 이용하지 않고 초기화 하는 방법
클래스이름 객체인스턴스 = new 클래스이름()
{
    프로퍼티1 = 값,
    프로퍼티2 = 값,
    프로퍼티3 = 값
};

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
        Player player = new Player()
        {
            player.ID = "고박사"
            player.CurrentHP = 100
        };

        Debug,Log($"{player.ID} HP : {player.CurrentHP}");
    }
}