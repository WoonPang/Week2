using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 선택적 매개 변수
public void Player(string ID, int health=1000)
{
    Debug.Log($"ID : {ID}, HP : {health}");
}

// Player() 메소드 호출
Player("고박사");
Player("rhqkrtk", 3000);

// Console View 결과
ID: 고박사, HP: 1000
ID: 고박사, HP: 3000

// 선택적 매개 변수 예
public void Player(string ID="고박사", int health, int mana) { ... }   // 불가능
public void Player(string ID, int health=100, int mana) { ... }   // 불가능
public void Player(string ID, int health, int mana = 100) { ... }   // 가능
public void Player(string ID, int health=100, int mana = 100) { ... }   // 가능
public void Player(string ID = "고박사", int health, int mana = 100) { ... }   // 가능
