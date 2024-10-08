using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 멤버 변수의 은닉성보단 편리함을 선택
public class Player
{
    // 변수 은닉을 신경 쓰지 않으면 변수에 원치 않는 값이 들어갈 수 O
    // 은닉과 캡슐화를 지키기에 너무 귀찮아 그냥 public을 쓰고 싶다
    public int currentHP;
}

public class GameController
{
    private void Awake()
    {
        Player player = new Player();
        player.currentHP = 100;
        Debug.Log($"Player HP : {player.currentHP}");
    }
}