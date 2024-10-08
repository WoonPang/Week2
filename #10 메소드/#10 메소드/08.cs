using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 값에 의한 전달 (Call By Value)
private void Awake()
{
    int a = 3, b = 4;
    Add(a, b);
}

public void Add(int num1, int num2)
{
    int result = num1 + num2;
    DebugLog($"{num1} x {num2} = {result}");
}

// 값에 의한 전달 예제
private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"Before a={a}, b={b}");
    Swap(a, b);
    Debug.Log($"After a={a}, b={b}");
}

public void Swap(int num1, int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}