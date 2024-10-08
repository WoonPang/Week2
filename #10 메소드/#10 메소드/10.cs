using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 출력 전용 매개 변수
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, ref result1, ref result2);
    Debug.Log($"몫={result1}, 나머지={result2}");
}

public void Divide(int num1, int num2, ref int result1, ref int result2)
{
    result1 = num1 / num2;
    result2 = num2 % num1;
}

// 출력 전용 매개 변수인 out 키워드 사용
private void Awake()
{
    int a = 5, b = 4, result1 = 0, result2 = 0;
    Divide(a, b, out result1, out result2);
    Debug.Log($"몫={result1}, 나머지={result2}");
}

public void Divide(int num1, int num2, out int result1, out int result2)
{
    result1 = num1 / num2;
    result2 = num2 % num1;
}