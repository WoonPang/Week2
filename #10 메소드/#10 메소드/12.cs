using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 가변 길이 매개 변수
public void Sum(params int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; ++i)
    {
        sum += nums[i];
    }
    Debug.Log($"합계 : {sum}");
}