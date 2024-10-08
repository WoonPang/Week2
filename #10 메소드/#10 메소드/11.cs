using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메소드 오버로딩
public void AddInt(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

public void AddFloat(float num1, float num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

// 동일한 메소드 이름으로 여러 종류의 메소드를 구현
public void Add(int num1, int num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

public void Add(float num1, float num2)
{
    int result = num1 + num2;
    Debug.Log($"{num1} + {num2} = {result}");
}

Add(10, 20);    // 정수형 호출 계산
Add(172.3f, 89.5f); // 실수형 계산 호출