using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 소멸자
public class Player
{
    public string ID;
    private int health;

    ~Player()
    {
        // 삭제됩니다
    }
}