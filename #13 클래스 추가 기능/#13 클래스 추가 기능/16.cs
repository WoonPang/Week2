using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 확장 메소드 예제
// string 클래스에 PrintData() 메소드를 추가 확장하는 메소드 추가 예제
public static class StringExtension
{
    // 첫 번째 매개변수는 확장하력 하는 대상
    public static void PrintData(this string str)
    {
        Debug.Log(str);
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        string str = "안녕하세요. 고박사입니다.";
        str.PrintData();
    }
}