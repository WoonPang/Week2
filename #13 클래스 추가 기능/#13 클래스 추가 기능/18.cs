using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이름 공간 예제
// 이름 공간 선언
namespace Myspace
{
    public class Player
    {
        // 변수, 메소드
    }
}

namespace YourSpace
{
    public class Player
    {
        // 변수, 메소드
    }
}

// 이름공간에 있는 클래스, 구조체 사용
using MySpace;

public class GameController
{
    private void Awake()
    {
        // MySpace에 정의된 Player 사용 (using MySpace 때문)
        Player player01;
        // YourSpace에 정의된 Player 사용
        YourSpace.Player player02;
    }
}

// 서로 다른 이름공간에 같은 이름의 클래스가 정의되어 있는 경우
using MySpace;
using YourSpace;

public class GameController
{
    private void Awake()
    {
        Player palyer01;        // 둘 중 어떤 Player를 사용하는 것인지 컴파일러는 알지 X - 오류 발생
    }
}