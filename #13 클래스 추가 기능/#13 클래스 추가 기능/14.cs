using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적(static) 클래스
// static 클래스는 모든 멤버가 static 멤버로 되어 있어야 함.
public static class Calculator
{
    public static int num;

    // static 생성자
    static Calculator()
    {
        num = 1;
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

public class GameController
{
    private void Awake()
    {
        // static 클래스의 메소드 호출
        Debug.Log(Calculator.Sum(20, 55));
        // static 클래스의 변수 사용
        Debug.Log(Calculator.num);
    }
}