using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 클래스 객체 생성
public class GameController : MonoBehaviour
{
    public Player player01;
    public Player player02;

    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200); // NullException 발생(오류)
    }
}