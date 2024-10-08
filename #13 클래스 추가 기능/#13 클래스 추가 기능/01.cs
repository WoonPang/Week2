using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메소드 숨기기
// 부모 클래스에서 구현한 메소드는 감추고
// 자식 클래스에서 구현한 메소드를 보여줌
public class 부모클래스
{
    public void 메소드이름()
    {
        // ...
    }
}

public class 자식클래스
{
    public new void 메소드이름()
    {
        // ...
    }
}