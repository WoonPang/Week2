using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 참조 변수 형식과 메모리 할당 형식에 따른 사용 가능 멤버 (변수, 메소드)
public class Entity
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }

    public void Heal()
    {
        Debug.Log("체력을 회복한다.");
    }
}

public class Goblin : Entity
{
    public void Avoid()
    {
        Debug.Log("도망가자!!");
    }

    public void Heal()
    {
        Debug.Log("고블린의 체력 회복!");
    }
}

private Entity entity = new Entity();
// 사용 가능 멤버
Attack();
Heal();

private Goblin goblin = new Goblin();
// 사용 가능 멤버
Attack();
Avoid();
Heal();     // Goblin에 정의된 Heal()

private Entity entity = new Goblin();
// 사용 가능 멤버
Attack();
Heal();     // Entity에 정의된 Heal()