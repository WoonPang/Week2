using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스는 다중 상속이 가능
interface IMovingEntity
{
    void Move(Vector3 destination);
}

interface ICombatEntitty
{
    void Attack(Entity target);
}

public class Player : IMovingEntity, ICombatEntitty
{
    public void Move(Vector3 destination)
    {
        Debug.Log($"{destination}까지 걸어서 이동");
    }

    public void Attack(Entity target)
    {
        Debug.Log($"{target}을 공격합니다.");
    }
}