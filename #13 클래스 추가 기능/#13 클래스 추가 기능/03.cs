using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 오버라이딩 봉인하기
public class Entity
{
    public virtual void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}

// 오버라이딩
public class MovingEntity : Entity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}

// 오버라이딩 봉인 - sealed 키워드
public class MovingEntity : Entity
{
    public sealed override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}

// 오버라이딩 봉인 시 에러 발생
public class Player : MovingEntity
{
    public override void TakeDamage(int damage)
    {
        Debug.Log($"Entity : {damage}만큼 체력 감소");
    }
}