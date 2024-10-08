using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적(static) 메소드
public class Enemy
{
    // static 메소드 정의
    // 메소드의 반환형식 앞에 static 키워드 사용
    한정자 static 반환형식 메소드이름 (매개변수목록)
    {
    }
}

public class GameController
{
    private void Awake()
    {
        // static 메소드 호출
        Enemy.메소드이름();
    }
}