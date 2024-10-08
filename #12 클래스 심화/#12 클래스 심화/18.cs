using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스를 상속하는 인터페이스 예제
interface IMovingEntity
{
    void MpveTo(Vector3 destination);
}

interface IPerson : IMovingEntity
{
    void Talk(string word);
}

public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class Player : IPerson
{
    private string ID = "고박사";

    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{ID}님이 {destination}으로 이동");
    }

    public void Talk(string word)
    {
        Debug.Log($"{ID} : {word}");
    }
}

public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IPerson player;

    private void Awake()
    {
        goblin = new Goblin(0;
        player = new Player(0;

        goblin.MoveTo(new Vector3(1, 2, 3,);
        player.MoveTo(new Vector3(4, 5, 6);
        player.Talk("안녕하세요. 고박사 입니다.");
    }
}