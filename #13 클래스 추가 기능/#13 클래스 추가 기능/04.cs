using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 중첩 클래스
public class OuterClass
{
    public class InnerClass
    {
        // ...
    }
}
// 중첩 클래스 InnerClass는 자신이 정의된 OuterClass의
// 모든 멤버(private 포함)에 접근할 수 있다.