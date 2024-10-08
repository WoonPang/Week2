using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스의 프로퍼티
// 인터페이스의 프로퍼티는 컴파일러가 구현을 해주지 X
interface 인터페이스이름
{
    데이터형식 프로퍼티이름1
    {
        get; set;
    }
}

public class 자식클래스 : 인터페이스이름
{
    public 데이터형식 프로퍼티이름1
    {
        // get, set 구현
    }
}