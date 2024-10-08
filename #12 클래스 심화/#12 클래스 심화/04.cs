using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속 관계에서 생성자와 소멸자의 호출 순서
// Entitiy의 생성자 - Player의 생성자 - Player의 소멸자 - Entity의 소멸자
public class Entity
{
    public Entity() { ... }
    ~Entity() { ... }
}

public class Player : Entity
{
    public Player() { ... }
    ~Player() {  ... }
}

public class GameController
{
    private Player player;

    private void Awake()
    {
        player = new Player();
    }
}