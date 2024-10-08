using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 멤버 변수 개수가 많을 경우 작성해야할 내용을 줄이기 위한 프로퍼티
public class Player
{
    public int CurrentHP
    {
        get; set;
    }
}

// 위의 코드는 아래의 코드의 자동구현 프로퍼티
public class Player
{
    private int currentHP;
    public int CurrentHP
    {
        get => currentHP;
        set => currentHP = value;
    }
}