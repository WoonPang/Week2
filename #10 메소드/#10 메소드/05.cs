using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 반환 데이터가 없는 경우
public void Divide(int num1, int num2)
{
    if (num2 == 0)
    {
        Debug.Log("나누려는 값이 0이기 때문에 프로그램 종료");
        return;
    }

    float result = num1 / num2;
    Debug.Log($"{num1} / {num2} = {result}");
}