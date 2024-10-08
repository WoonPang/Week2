using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상 클래스의 프로퍼티 예제
public abstract class BaseEntity
{
    abstract public int Shield
    {
        get; set;
    }
    public int Defense
    {
        get; set;
    }
}

public class Player : BaseEntity
{
    public override int Shield
    {
        get; set;
    }
    public int ID
    {
        get; set;
    }
}
// 추상 프로퍼티의 Shield의 get, set은 자동 구현 프로퍼티가 아닌 구현부가 없는 선언
// 자식 클래스에서 재정의 해야함.

public class GameController
{
    private void Awake()
    {
        Player player = new Player()
        {
            player.ID = "고박사",
            player.Shield = 50,
            player.Defense = 10
        };

        Debug.Log($"ID : {player.ID}");
        Debug.Log($"방어력 : {player.Defense}, 방어막 : {player.Shield}");
    }
}

// 출력 결과
// ID : 고박사
// 방어력 : 10, 방어막 : 50