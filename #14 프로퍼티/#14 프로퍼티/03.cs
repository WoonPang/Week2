using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프로퍼티 선언
// 멤버 변수의 은닉성 보장, 변수에 접근하는 것과 같이 대입 연산자(=) 사용 가능
// get, set의 내용이 여러 줄일 경우
public class Player
{
    데이터형식 멤버변수이름;
    접근지정자 데이터형식 프로퍼티이름
    {
        get
        {
            return 멤버변수이름;
        }
        set
        {
            멤버변수이름 = value;
        }
    }
}

//get, set의 내용이 한 줄일 경우
public class Player
{
    데이터형식 멤버변수이름;
    접근지정자 데이터형식 프로퍼티이름
    {
        get => 멤버변수이름;
        set => 멤버변수이름 = ValueTuple;
    }
}