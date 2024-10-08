using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 반환타입이 인터페이스 타입일 경우
// 메소드가 해당 인터페이스를 구현한 클래스의 인스턴스를 반환해야함
public class GameController : MonoBehaviour
{
    private IMovingEntity goblin;

    private void Awake()
    {
        goblin = Method();
    }

    public IMovingEntity Method()
    {
        Goblin goblin = new Goblin();

        return goblin;
    }
}

interface IMovingEntity
{
    void MoveTo(Vector3 destination);
}

public class Goblin : IMovingEntity
{
    public void MoveTo(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }
}
