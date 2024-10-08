using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 읽기/쓰기 전용 프로퍼티
// 읽기 전용 : 프로퍼니 내부에 get만 지정
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
    }
}

// 쓰기 전용 : 프로퍼티 내부에 set만 지정
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        set => currentHP = value;
    }
}

// prviate 접근 지정자를 이용하여 현재 클래스 내부에서만
// get 또는 set 프로퍼티를 사용할 수 있게 설정 가능
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        private set => currentHP = value;
        get => currentHP;
    }
}

public class Player
{
    public int CurrentHP
    {
        private set; get;
    }
}
