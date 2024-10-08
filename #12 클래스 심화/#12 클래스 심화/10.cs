using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// is, as 연산자 예제
public class Entity
{
    public void Attack()
    {
        Debug.Log("적을 공격한다.");
    }
}

public class Slime : Entity
{
}

public class Goblin : Entity
{
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Entity entity = new Slime();
        if ( entity is Slime)
        {
            Debug.Log("Entity type is Slime");
        }

        Goblin goblin = Entity as Goblin;
        if ( goblin == null )
        {
            Debug.Log("goblin is null");
        }
    }
}