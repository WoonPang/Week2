using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

// 클래스의 문법
public class Player : MonoBehaviour
{
    private string ID = "고박사";
    private int currnetHP = 1000;

    public void TakeDamage(int damage)
    {
        if (currnetHP > damage)
        {
            currnetHP -= damage;
        }
    }
}