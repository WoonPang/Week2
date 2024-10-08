using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메소드 오버라이딩
public class Entity
{
    public virtual void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
}

public class Slime : Entity
{
    public override void Attack()
    {
        Debug.Log("슬라임의 몸통 박치기 공격!");
    }
}
public class Goblin : Entity
{
    public override void Attack()
    {
        Debug.Log("고블린의 몽둥이 스매시!!");
    }
}

public class GameController
{
    private Slime slime;
    private Goblin goblin;

    private void Awake()
    {
        ...
        slime.Attack();
        goblin.Attack();
    }
}

// 출력 결과
// 슬라임의 몸통 박치기 공격!
// 고블린의 몽둥이 스매시!!