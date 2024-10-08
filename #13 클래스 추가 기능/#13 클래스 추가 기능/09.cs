using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 튜플 예제
var a = ("고박사", 35);
Debug.Log($"{a.Item1}, {a.Item2}");

// 튜플에 정의된 변수를 사용하거나 수정할 때 "튜플이름.Item숫자"로 접근
a.Item2 = 36;
Debug.Log($"{a.Item1, a.Item2}");

// 튜플 내부 변수 이름을 설정할 수 있다.
var a = (Name: "고박사", Age: 35);
Debug.Log($"{a.Name}, {a.Age}");

// 튜플은 분해해서 특정 변수에 저장 가능
var a = (Name: "고박사", Age: 35);
var (name, age) = a;
Debug.Log($"{name}, {age}");

// 튜플을 분해할 때 _를 사용하면 특정 변수 무시
var a = (Name: "고박사", Age: 35);
var (name, _) = a;
// 나이 필드를 무시했기 때문에 age 사용 불가능
Debug.Log($"{name}, {age}");