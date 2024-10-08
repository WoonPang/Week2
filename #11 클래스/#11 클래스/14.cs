using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 깊은 복사
public class GameController : MonoBehaviour
{
    private Player player01;
    private Player player02;

    private void Awake()
    {
        player01 = new Player("고박사", 1000);

        player02 = player01.DeepCopy();
        player02.ID = "유니티";

        Debug.Log($"ID : {player01.ID}");
        Debug.Log($"ID : {player02.ID}");
    }
}

public class Player
{
    public string ID;
    private int currentHP;

    ...

    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
    }
}