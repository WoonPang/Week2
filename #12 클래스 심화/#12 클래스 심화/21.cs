using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속이 아닌 방법으로 다른 클래스의 기능을 물려받는(사용하는) 방법
// 객체 인스턴스 생성 후 사용
public class Player
{
    private Berserker berserker;
    private Archer archer;

    private void Awake()
    {
        berserker = new Berserker();
        archer = new Archer();
    }

    public void SwordAttack() { berserker.Sword(); }
    public void ArrowAttack() { archer.Arrow(); }
}