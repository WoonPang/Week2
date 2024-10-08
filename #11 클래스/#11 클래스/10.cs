using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 생성자
public class Player
{
    public string ID;
    private int currentHP;

    // 생성자의 한정자는 public, 반환 형식 가질 수 X
    public Player()
    {
        ID = "고박사";
        currnetHP = 1000;
    }
}

public class GameController : MonoBehaviour
{
    public Player player01;

    private void Awake()
    {
        player01 = new Player(); // new 키워드로 생성자 호출
    }
}