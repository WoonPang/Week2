using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 추상 클래스의 프로퍼티
// 일반 클래스처럼 구현된 프로퍼티 가질 수 O
// 인터페이스처럼 구현되지 않은 프로퍼티 가질 수 O
public abstract class 클래스이름
{
    abstract 접근지정자 데이터형식 프로퍼티이름1
    {
        get; set;
    }
}

public class 자식클래스 : 추상클래스이름
{
    public override 데이터형식 프로퍼티이름1
    {
        // get, set 구현
    }
}