using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 분할 클래스
// Player.cs 파일
public partial class Player
{
    public void CounterAttack() { ... }
}

// Player02.cs 파일
public partial class Player
{
    public void TakeDamage(int damage)
    {
        // 체력 감소
        // 같은 클래스이기 때문에 호출 가능
        CounterAttack();
    }
}
// 클래스명과 동일한 파일이 반드시 한 개 있어야 함.