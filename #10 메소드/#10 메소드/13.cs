using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 명명된 매개 변수
public void Player(string ID, int health)
{
    Debug.Log($"ID : {ID}, HP : {health}");
}

// 일반적인 매개 변수 사용
Player("고박사", 100);

// 명명된 매개 변수 사용
Player(ID: "고박사", health: 100);
Player(health: 100, ID: "고박사");
// 매개 변수의 순서가 바뀌어도 O