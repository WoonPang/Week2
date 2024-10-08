using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스는 여러 개의 클래스를 한꺼번에 상속할 수 X (죽은의 다이아몬드)
public abstract class CombatEntity
{
    public abstract void Attack();
}

public class Berserker : CombatEntity
{
    public void Sword(0 { ... }
    public void Attack() { Sword(); }
}

public class Archer : CombatEntity
{
    public void Arrow() { ... }
    public void Attack(0 { Arrow(); }
}

public class Player : Berserker, Archer
{
}
// Player가 가지게 될 Attack() 메소드는?
// 오류 발생 - 클래스는 다중 상속 불가능