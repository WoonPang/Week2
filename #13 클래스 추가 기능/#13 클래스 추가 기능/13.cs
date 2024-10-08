using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적(static) 변수 예제
public class Enemy
{
    // instance 변수
    public int numeric;
    // static 변수
    public static string specise;
}

public class GameController
{
    private void Awake()
    {
        // instance 변수 사용
        Enemy enemy01 = new Enemy();
        enemy01.numeric = 0;
        Enemy enemy02 = new Enemy();
        enemy02.numeric = 1;

        Debug.Log(enemy01.numeric);
        Debug.Log(enemy02.numeric);

        // static 변수 사용
        Enemy.species = "고블린";
        Debug.Log(Enemy.species);
    }
}

// 결과 화면
// 0
// 1
// 고블린