using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 업 캐스팅을 활용한 형식 통일 - 게임에 존재하는 다양한 적에게 같은 명령 하달
// Before Up-Casting
public class GameController : MonoBehaviour
{
    private Goblin goblin;
    private Slime slime;
    private Dragon dragon;
        // ... 100가지 종류의 적 생성

    private void Awake()
    {
        // ... 각 객체 메모리 할당
    }

    private void Update()
    {
        goblin.Attack();
        slime.Attack();
        dragon.Attack();
        ...
    }
}

// After Up-Casting
public class GameController : MonoBehaviour
{
    private Enemy[] enemys = new Enemy[100];

    private void Awake()
    {
        enemys[0] = new Goblin();
        enemys[1] = new Slime();
        // ... 각 객체 메모리 할당
    }

    private void Update()
    {
        for (int i = 0; i < enemys.Length; ++i)
        {
            enemys[i].Attack();
        }
    }
}