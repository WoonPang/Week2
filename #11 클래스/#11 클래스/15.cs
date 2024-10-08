using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// this 키워드
public class Player
{
    public string ID = "고초아";
    
    public SetID(string ID)
    {
        Debug.Log($"ID : {ID}");
        Debug.Log($"ID : {this.ID}");
    }
}

public class GameController
{
    private void Awake()
    {
        ...
        player01.SetID("유니티");
    }
}