using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상 클래스 사용
public class GameController : MonoBehaviour
{
    private Entity entity;      // 추상 클래스는 인스턴스 생성 불가능
    private Entity goblin;
    private Entity slime;

    private void Awake
    {
        entity = new Entity();      // 추상 클래스는 인스턴스 생성 불가능
        goblin = new Goblin(5, 100);
        slime = new Slime(10, 50);

        goblin.Attack(slime);
        slime.Attack(goblin);
    }
}