using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 메소드 숨기기 예제
public class Parent
{
    public void Method01()
    {
        Debug.Log("Parent");
    }
}

public class Child : Parent
{
    public new void Mehtod01()
    {
        Debug.Log("Child");
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Parent p = new Parent();
        p.Method01();

        Chlid c = new Child();
        c.Method01();

        Parent pc = new Child();
        pc.Method01();
    }
}

// 출력결과
// Parent
// Child
// Parent