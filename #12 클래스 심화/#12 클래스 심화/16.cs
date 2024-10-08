using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 매개변수가 인터페이스 타입일 경우
// 메소드 호출 시 해당 인터페이스를 구현한 클래스의 인스턴스를 매개변수로 제공
public class GameController : MonoBehaviour
{
    private IMobingEntity goblin;

    private void Awake()
    {
        goblin = new Goblin();
        Method(goblin);
    }

    public void Method(IMovingEntity entity)
    {
        // ...
    }
}

interface IMobingEntity
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