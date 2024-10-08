using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// 부모 클래스와 자식 클래스 사이의 형 변환
public class Entity
{
}

public class Goblin : Entity
{
}

// 업 캐스팅 가능
private Entity entity = new Goblin();       // 부모 참조 변수 = 자식 메모리, 업 캐스팅

// 다운 캐스팅 가능
private Entity entity = new Goblin();
private Goblin goblin = (Goblin)Entity;     // 자식 = (자식)부모, 다운 캐스팅

// 다운 캐스팅 불가능
private Entity entitiy = new Entity();
private Goblin goblin = (Goblin)Entity;