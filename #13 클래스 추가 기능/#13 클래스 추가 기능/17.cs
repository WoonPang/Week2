using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 이름 공간
// 하는 일이 비슷한 클래스, 구조체를 하나로 묶어 놓은 것
// 이름공간 선언
namespace 이름공간
{
    // 클래스, 구조체 정의
}

// 다른 이름공간에 정의된 클래스, 구조체를 사용하려면
using 이름공간; // or 이름공간.클래스명

// 긴 이름의 이름공간을 줄여서 사용하고 싶을 때
using Random = UnityEngine.Random;