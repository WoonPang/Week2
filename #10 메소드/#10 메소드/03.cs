using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 메소드의 장점
// 변수 선언 및 초기화
int num1 = 0, num2 = 0, result = 0;

num1 = 3;
num2 = 4;
result = num1 * num2;
Debug.Log($"{num1} x {num2} = {result}");

num1 = 5;
num2 = 8;
result = num1 * num2;
Debug.Log($"{num1} x {num2} = {result}");

num1 = 4;
num2 = 6;
result = num1 * num2;
Debug.Log($"{num1} x {num2} = {result}");

// 위 코드를 메소드를 이용하여 간편하게 나타낼 수 있다.
private void Awake()
{
    // 메소드의 이름을 불러서 사용
    Multiple(3, 4);
    Multiple(5, 8);
    Multiple(4, 6);
}

// num1과 num2의 곱을 출력하는 메소드 정의
public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
