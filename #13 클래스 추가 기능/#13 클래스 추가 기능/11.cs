using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적(static) 메소드 예제
public class Enemy
{
    // instance 메소드
    public int InstanceRun() { return 1; }
    // static 메소드
    public static int StaticRun()
    {
        InstanceRun();      // 호출 불가능
        return 1;
    }
}

public class GameController
{
    private void Awake()
    {
        // static 메소드 호출
        int j = Enemy.StaticRun();
        // instance 메소드 호출
        Enemy enemy01 = new Enemy();
        int i = enemy01.InstanceRun();

        enemy01.StaticRun();        // 호출 불가능
    }
}