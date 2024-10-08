using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 변수
// 클래스로부터 객체를 생성하지 않고 직접 호출
// 프로그램 로딩 시 단 한번만 생성되고 재사용함.
public class Enemy
{
    // static 변수 선언
    // 변수 형식 앞에 static 키워드 사용
    한정자 static 형식 변수이름;
}

public class GameController
{
    private void Awake()
    {
        // static 변수 사용
        Enemy.변수이름 = 1;
    }
}