using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스 예제
// 인터페이스 정의
interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}

// 인터페이스 상속 및 사용
public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}

public class Slime : IMovingEntity
{
    public void MoveTo(Vector3 destinaiton)
    {
        Debug.Log($"{destination}까지 기어서 이동");
    }
}

public class Butterfly : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 날아서 이동");
    }
}

public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;
    private IMovingEntity slime;
    private IMovingEntity butterfly;

    private void Awake()
    {
        goblin = new Goblin();
        slime = new Slime();
        butterfly = new Butterfly();

        goblin.MoveTo(new Vector3(1, 2, 3));
        slime.MoveTo(new Vector(4, 5, 6,);
        butterfly.MoveTo(new Vector3(7, 8, 9);
    }
}