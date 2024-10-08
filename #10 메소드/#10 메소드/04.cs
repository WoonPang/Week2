using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Return 이란?
private void Awake()
{
    int a = int.Max(10, 20);
    Debug.Log(Max(100, 200));
    Max(5, 10);
}

public int Max(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1;
    }
    return num2;
}