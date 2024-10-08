using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스 프로퍼티 예제
interface IBaseEntity
{
    string ID { get; set; }
    int Damage { get; set; }
    int CurrentHP { get; set; }
}

public class Player : IBaseEntity
{
    private string id;
    public string ID
    {
        get => id;
        set => id = value;
    }
    public int Damage;
    {
        get; set;
    }
    public int CurrentHP
    {
        get; set;
    }
}