using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 매개 변수를 사용하는 이유

// 매개 변수가 없을 때
private void Awake()
{
    int a = 3, b = 4;
    Add();
    Add();
}

public void Add()
{
    int result = 10 + 12;
    Debug.Log($"{num1} x {num2} = {result}");)
}

// 매개 변수가 있을 때
private void Awake()
{
    int a = 3, b = 4;
    Add(a, b);
    Add(10, 20);
}

public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} x {num2} = {result}");
}