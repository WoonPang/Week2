using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 접근 지정자 예제
public class Player
{
    public string ID;
    private int currentHP;

    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }    
    }
}