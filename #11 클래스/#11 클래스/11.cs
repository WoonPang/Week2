using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자 메소드 오버로딩
public class Player
{
    public string ID;
    private int currentHP;

    public Player()
    {
        ID = "고박사";
        currentHP = 1000;
    }

    public Player(string id, int hp)
    {
        ID = id;
        currentHP = hp;
    }
}

public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player02 = new Player("유니티", 10);
    }
}