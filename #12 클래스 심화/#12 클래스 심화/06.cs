using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 업 캐스팅을 활용한 형식 통일 - 플레이어가 다양한 종류의 적을 공격
// Before Up-Casting
public class Goblin
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : {damage}만큼 체력 감소");
    }
}

public class Slime
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : {damage}만큼 체력 감소");
    }
}

public class Dragon
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : {damage}만큼 체력 감소");
    }
}

public class Player
{
    private int damage = 10;

    public void Hit(Goblin goblin)
    {
        goblin.TakeDamage(damage);
    }
    public void Hit(Slime slime)
    {
        slime.TakeDamage(damage);
    }
    public void Hit(Dragon dragon)
    {
        dragon.TakeDamage(damage);
    }

    ...
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        Goblin goblin = new Goblin();
        Slime slime = new Slime();
        Dragon dragon = new Dragon();

        player.Hit(goblin);
        player.Hit(slime);
        player.Hit(dragon);
    }
}

// After Up-Casting
public class Enemy
{
    public void TakeDamage(int damgae)
    {
        Debug.Log($"적 : {damgae}만큼 체력 감소");
    }
}

public class Goblin : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"고블린 : {damage}만큼 체력 감소");
    }
}
public class Slime : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"슬라임 : {damage}만큼 체력 감소");
    }
}
public class Dragon : Enemy
{
    public void TakeDamage(int damage)
    {
        Debug.Log($"드래곤 : {damage}만큼 체력 감소");
    }
}

public class Player : MonoBehaviour
{
    private int damage = 10;

    public void Hit(Enemy enemy)
    {
        enemy.TakeDamage(damage);
    }
}

public class GameController : MonoBehaviour
{
    private void Awake()
    {
        Player player = new Player();

        Enemy goblin = new Goblin();
        Enemy slime = new Slime();
        Enemy dragon = new Dragon();
    }
}