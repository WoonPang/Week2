using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 매개 변수란?
private void Awake()
{
    int a = 3, b = 4;
    Add(a, b);
}

public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}