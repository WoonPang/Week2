using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 참조에 의한 전달 예제
private void Awake()
{
    int a = 3, b = 4;
    Debug.Log($"a={a}, b={b}");
    Swap(ref a, ref b);
    Debug.Log($"a={a}, b={b}");
}

public void Swap(ref int num1, ref int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}