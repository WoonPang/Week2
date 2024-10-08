using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 멤버 함수 (메소드, Method)
public class Player : MonoBehaviour
{
    private string ID = "고박사";
    private int currentHP = 1000;

    private void Awake()
    {
        TakeDamage(100);
    }

    public void TakeDamage(int damage)
    {
        if (currnetHP > damage)
        {
            currnetHP -= damage;
        }
    }
}