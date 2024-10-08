using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

// this() 생성자
public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player()
    {
        ID = "고박사";
    }
    public Player(int hp)
    {
        ID = "고박사";
        currentHP = hp;
    }
    public Player(int hp, int mp)
    {
        ID = "고박사";
        currentHP = hp;
        currentMP = mp;
    }
}

// this를 이용해 생성자 호출 가능
// 위의 코드를 반복작성 필요 없이 this()와 같이 호출해서 사용
public class Player
{
    private string ID;
    private int currentHP;
    private int currentMP;

    public Player()
    {
        ID = "고박사";
    }
    public Player(int hp) : this()
    {
        currentHP = hp;
    }
    public Player(int hp, int mp) : this(hp)
    {
        currentMP = mp;
    }
}