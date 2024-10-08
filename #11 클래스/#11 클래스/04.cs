using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 멤버 변수 (필드, Field)
public class Player : MonoBehaviour
{
    private string ID = "고박사";
    private int currentHP = 1000;

    public void TakeDamage(int damage)
    {
        if (currnetHP > damage)
        {
            currnetHP -= damage;
        }
    }
}